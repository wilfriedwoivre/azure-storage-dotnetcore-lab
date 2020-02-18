using System.Collections.Generic;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using SOAT.Labs.Models;

namespace SOAT.Labs.DataAccess
{
    public class BlobDataAccess
    {
        private string storageConnectionString { get; set; }

        public BlobDataAccess(string cnxString)
        {
            this.storageConnectionString = cnxString;
        }

        public BlobContainerClient CheckStorageContainer(string containerName)
        {
            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient(this.storageConnectionString);

            var blobcntclient = blobServiceClient.GetBlobContainerClient(containerName);

            if (blobcntclient == null)
            {
                // Create the container and return a container client object
                blobcntclient = blobServiceClient.CreateBlobContainerAsync(containerName).Result;
            }

            return blobcntclient;
        }

        public List<ImageItem> GetStorageBlobList(BlobContainerClient containerClient)
        {
            List<ImageItem> result = new List<ImageItem>();
            // List all blobs in the container
            foreach (BlobItem blobItem in containerClient.GetBlobs())
            {
                result.Add(new ImageItem(blobItem.Name, containerClient.Uri + "/" + blobItem.Name));
            }
            return result;
        }

    }
}