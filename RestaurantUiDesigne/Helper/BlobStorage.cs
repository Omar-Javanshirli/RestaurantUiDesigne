using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUiDesigne.Helper
{
    public class BlobStorage
    {
        public static List<string> DownloadImage()
        {
            var imagelist=new List<string>(); 
            var account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=imagestorageaccountjc;AccountKey=f/vnqvTrI1XwLdJrXsoYsupP9wJfNyxCDQA743IZFTXz7U0gctxcyGIJI+/fZWGfeCpP2YsI1MfZ+ASt9JcpRg==;EndpointSuffix=core.windows.net");
            var client = account.CreateCloudBlobClient();

            var container = client.GetContainerReference("image");
            //container.CreateIfNotExists();

            var files = container.ListBlobs();

            foreach (var item in files)
            {
                string path = item.Uri.ToString().Substring(58);
                var a = container.GetBlockBlobReference(path);
                imagelist.Add(path);
                //string image = path;
                //a.DownloadToFile($"~/../../../Image/{image}", FileMode.OpenOrCreate);
            }
            return imagelist;
        }
    }
}  