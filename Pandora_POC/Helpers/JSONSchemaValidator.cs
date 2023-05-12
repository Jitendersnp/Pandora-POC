using Newtonsoft.Json.Linq;
using NJsonSchema.Validation;
using Pandora_POC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pandora_POC.Helpers
{
    public class JsonSchemaValidator : IJsonSchemaValidator
    {

        public Dictionary<string, object> SchemasList
        {
            get { return _SchemasList; }

        }

        private readonly Dictionary<string, object> _SchemasList = new Dictionary<string, object>();

        public JsonSchemaValidator()
        {
            string folderPath = "SchemaFiles";
            LoadSchmemaFiles(folderPath);

        }

        private void LoadSchmemaFiles(string path)
        {
            try
            {

                _SchemasList.Clear();

                string[] filePaths = Directory.GetFiles(path);

                foreach (var filePath in filePaths)
                {
                    string schema = File.ReadAllText(@filePath, Encoding.UTF8);

                    JObject jSchema = JObject.Parse(schema);

                    string fileName = Path.GetFileNameWithoutExtension(filePath);

                    _SchemasList.Add(fileName.ToLower(), jSchema);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ValidateResponse ValidateSchema(object jsonInput, object schemaInput)
        {
            if (schemaInput != null && jsonInput != null && jsonInput.ToString() != "")
            {
                var schema = NJsonSchema.JsonSchema.FromJsonAsync(schemaInput.ToString());

                JToken jToken = JToken.Parse(jsonInput.ToString());
                ICollection<ValidationError> errors = schema.Result.Validate(jToken);
                bool valid = errors.Count == 0;
                // validate json
                // return error messages and line info to the browser

                ValidateResponse validateResponse = new ValidateResponse
                {
                    Valid = valid,
                    ErrorDescription = string.Join(",", errors.Select(i => i.ToString()).ToArray())
                };

                return validateResponse;
            }
            return null;
        }
        public ValidateResponse ValidateInputAndOutput(string input)
        {
            object schemaInput;

            string apiURL = "";

            string schemaFileName = "v1_pandora_post_request";

            if (SchemasList.TryGetValue(schemaFileName, out schemaInput))
            {
                var validateResponse = ValidateSchema(input, schemaInput);

                if (validateResponse != null)
                {
                    if (validateResponse.Valid)
                    {
                        Console.WriteLine("Schema validated and passed successfully !");
                    }
                    else
                    {
                        Console.WriteLine("Schema validation Failed..... !");
                    }
                }

                return validateResponse;
            }
            else
            {
                return null;
            }
        }

    }
}