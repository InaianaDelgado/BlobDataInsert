using Azure.Storage.Blobs;
using System.Threading.Tasks;

namespace BlobDataInsert
{
    class Program
    {
        const string CONNECT_STRING = "<CONNECTION_STRING>";
        const string LOCAL_PATH = "../../../data/";

        static async Task Main(string[] args)
        {
            int count = 50;

            while (count != 0)
            {
                var storage = new StorageConfiguration(CONNECT_STRING);
                BlobContainerClient container = storage.ConfigClouldStoraAccount();

                var fileName = FileGenerator.Generate(LOCAL_PATH);
                var uploadFileStream = FileGenerator.GenerateStream(LOCAL_PATH, fileName);

                await Upload.UploadFileToStorage(uploadFileStream, fileName, container);
                uploadFileStream.Close();

                count--;
            }
        }
    }
}
