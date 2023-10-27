// See https://aka.ms/new-console-template for more information
/* upload file sql to Container IN azure Storage account */

using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;


string connectionString = "DefaultEndpointsProtocol=https;AccountName=vitaostoragecool;AccountKey=A8fLCpZMZybiHExeY2MX3/D4nGify1kMpADu1+ijEF9obgOCEVtiuZaj5q2uQmEujfGQDGC8Y0jf+ASt54mwKQ==;EndpointSuffix=core.windows.net";
string containerName = "scripts";
string blobName = "scripts.sql"; // insert file name that you want to upload in the destiny
string filePath = "C:\\Users\\victo\\OneDrive\\Documentos\\PROJETOS .NET\\BlobApp\\scripts.sql.accdb"; // use the path of file


BlobContainerClient blobService
     = new BlobContainerClient(connectionString,containerName);

BlobClient blobCriente=blobService.GetBlobClient(blobName);
await blobCriente.UploadAsync(filePath, true); // true ensure to update currect file and uploadasync ensure to sent it in assincrounisly mode


