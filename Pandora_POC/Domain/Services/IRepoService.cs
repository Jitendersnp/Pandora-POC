using Pandora_POC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandora_POC.Helpers
{
    public interface IAssetService
    {
        Task<int> SaveAssetDetails(string request);
    }
}