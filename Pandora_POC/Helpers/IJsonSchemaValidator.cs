using Pandora_POC.Models;
using System.Collections.Generic;

namespace Pandora_POC.Helpers
{
    public interface IJsonSchemaValidator
    {
        Dictionary<string, object> SchemasList { get; }
        ValidateResponse ValidateInputAndOutput(string input);
        ValidateResponse ValidateSchema(object jsonInput, object schemaInput);
    }
}