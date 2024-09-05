using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;
using System.IO;
using System.Threading.Tasks;

namespace BlobDataInsert
{
    public static class Upload
    {

        public static async Task<bool> UploadFileToStorage(Stream fileStream, string fileName, BlobContainerClient container)
        {
            BlockBlobClient blockBlob = container.GetBlockBlobClient(fileName);
                
            await blockBlob.UploadAsync(fileStream);

            return await Task.FromResult(true);
        }
    }
}
