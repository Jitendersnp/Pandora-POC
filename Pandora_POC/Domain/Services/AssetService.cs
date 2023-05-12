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
using System.Threading.Tasks;

namespace Pandora_POC.Helpers
{
    public class AssetService : IAssetService
    {
        public AssetService()
        {

        }

        public async Task<int> SaveAssetDetails(string request)
        {
            // Call Data service to save asset details...
            
            
            return 200;

        }
    }
       
}