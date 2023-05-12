using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NJsonSchema.Validation;
using Pandora_POC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pandora_POC.Domain.Services
{
    public class AssetService : IAssetService
    {

       
     
        //public ValidateResponse ValidateInputAndOutput(string input)
        //{
        //    object schemaInput;

        //    string apiURL = "";

        //    string schemaFileName = "v1_pandora_post_request";

        //    if (SchemasList.TryGetValue(schemaFileName, out schemaInput))
        //    {
        //        var validateResponse = ValidateSchema(input, schemaInput);

        //        if (validateResponse != null)
        //        {
        //            if (validateResponse.Valid)
        //            {
        //                Console.WriteLine("Schema validated and passed successfully !");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Schema validation Failed..... !");
        //            }
        //        }

        //        return validateResponse;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

    }
}