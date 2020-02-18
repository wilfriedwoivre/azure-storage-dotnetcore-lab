using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOAT.Labs.Configs;
using SOAT.Labs.Models;
using Azure.Storage.Blobs;
using SOAT.Labs.DataAccess;

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

            var cmn = new BlobDataAccess(storageConnectionString);
            BlobContainerClient blobcntclt = cmn.CheckStorageContainer(cntName);
            List<ImageItem> result = cmn.GetStorageBlobList(blobcntclt);

            return result;
        }
    }
}
