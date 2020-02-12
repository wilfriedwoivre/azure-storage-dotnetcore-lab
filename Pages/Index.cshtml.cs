using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOAT.Labs.Configs;
using SOAT.Labs.Models;

namespace SOAT.Labs.Pages
{
    public class IndexModel : PageModel
    {
        public List<ImageItem> Images { get; private set; }
        
        public void OnGet()
        {
            Images = LoadData();
        }

        public List<ImageItem> LoadData()
        {
            string storageConnectionString = AppSettingsHelper.LoadAppSettings().StorageOptions.ConnectionString;
            string cntName = AppSettingsHelper.LoadAppSettings().StorageOptions.ContainerImg;

            var result = new List<ImageItem>();

            return result;
        }
    }
}
