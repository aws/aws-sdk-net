using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


//using Amazon.S3;
//using Amazon.S3.Model;

using Amazon.Glacier;
using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer;

using Amazon.Runtime;

using Xunit;

using ThirdParty.Json.LitJson;
using Amazon;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Amazon.DNXCore.IntegrationTests
{
    public class ArchiveTransferManagerTests
    {

        static string testingVaultName = "sdk-dot-archive-manager-tests";
        
        static DownloadOptions defaultDownloadOptions = new DownloadOptions() { PollingInterval = 0.1 };
        

        [Fact]

        public async Task Createvault()
        {
            var Client = TestUtil.GlacierClient;
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);

            Assert.NotNull(await Client.ListJobsAsync(new ListJobsRequest { VaultName = testingVaultName }).ConfigureAwait(false));
            Assert.NotNull(await Client.ListMultipartUploadsAsync(new Glacier.Model.ListMultipartUploadsRequest { VaultName = testingVaultName }).ConfigureAwait(false));
            Assert.NotNull(await Client.ListVaultsAsync(new ListVaultsRequest()).ConfigureAwait(false));

            await Client.DeleteVaultAsync(new DeleteVaultRequest { VaultName = testingVaultName }).ConfigureAwait(false);
            //ListVaultsRequest l1 = new ListVaultsRequest();
            //l1.Limit = 1000;
            //ListVaultsResponse ls = await Client.ListVaultsAsync(l1).ConfigureAwait(false);
            //int cp= 0;
            //while (ls.Marker != null)
            //{
            //    cp += ls.VaultList.Count;
            //    l1 = new ListVaultsRequest();
            //    l1.Marker = ls.Marker;
            //    ls = await Client.ListVaultsAsync(l1).ConfigureAwait(false);
            //}
            //int cp1 = cp;
            //    count += ls.VaultList.Count;
            //    ls = await Client.ListVaultsAsync().ConfigureAwait(false);
            //    foreach (DescribeVaultOutput i in ls.VaultList)
            //    {
            //        if (i.NumberOfArchives.Equals(0) || i.SizeInBytes.Equals(0))
            //        {
            //            await Client.DeleteVaultAsync(new DeleteVaultRequest
            //            {
            //                VaultName = i.VaultName
            //            }).ConfigureAwait(false);
            //        }
            //    }
            //}
            //foreach (DescribeVaultOutput i in ls.VaultList)
            //{
            //    if (i.NumberOfArchives.Equals(0)|| i.SizeInBytes.Equals(0))
            //    {
            //        await Client.DeleteVaultAsync(new DeleteVaultRequest
            //        {
            //            VaultName = i.VaultName
            //        }).ConfigureAwait(false);
            //    }
            //}
            //await TestUtil.GlacierClient.CreateVaultAsync(new CreateVaultRequest
            //{
            //    VaultName = testingVaultName
            //}).ConfigureAwait(false);
        }

        [Fact]

        public async Task TestSimpleUpload()
        {
            var Client = TestUtil.GlacierClient;
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);
            const string accountID = "-";
            string archiveID = null;

            try
            {
                var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes("data to archive"));
                var uploadArchiveRequest = new UploadArchiveRequest
                {
                    VaultName = testingVaultName,
                    Body = memoryStream,
                    Checksum = TreeHashGenerator.CalculateTreeHash(memoryStream),
                    AccountId = accountID,
                    ArchiveDescription = "my first archive"
                };

                var response = await Client.UploadArchiveAsync(uploadArchiveRequest).ConfigureAwait(false);
                archiveID = response.ArchiveId;
            }
            finally
            {
                await Client.DeleteArchiveAsync(new DeleteArchiveRequest { AccountId = accountID, VaultName = testingVaultName, ArchiveId = archiveID }).ConfigureAwait(false);
            }
        }
        [Fact]

        public async Task UploadSmallFile()
        {
            var Client = TestUtil.GlacierClient;
            ArchiveTransferManager manager = new ArchiveTransferManager(Client);
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);
            string fileOneMeg = @"c:\temp\UploadOneMegWithFileStream.bin";
            string downloadFile = @"c:\temp\download.bin";
            string downloadFile2 = @"c:\temp\download2.bin";
            CreateTempFile(fileOneMeg, (long)Math.Pow(2, 20));
            try
            {
                UploadResult result = await manager.UploadAsync(testingVaultName, "test file", fileOneMeg).ConfigureAwait(false);
                Assert.NotNull(result.ArchiveId);
                Assert.NotNull(result.Checksum);

                await manager.DownloadAsync(testingVaultName, result.ArchiveId, downloadFile, defaultDownloadOptions).ConfigureAwait(false);
                CompareFile(fileOneMeg, downloadFile);
                //if (File.Exists(downloadFile))
                //{
                //    File.Delete(downloadFile);
                //}
                

                string jobId = await manager.InitiateArchiveRetrievalJobAsync(testingVaultName, result.ArchiveId).ConfigureAwait(false);

                await Task.Delay(10 * 1000);
                
                await manager.DownloadJobAsync(testingVaultName, jobId, downloadFile2).ConfigureAwait(false);
                CompareFile(fileOneMeg, downloadFile2);
                await manager.DeleteArchiveAsync(testingVaultName, result.ArchiveId).ConfigureAwait(false);
            }
            finally
            {
                //if (File.Exists(downloadFile))
                //{
                //    File.Delete(downloadFile);
                //}
                //if (File.Exists(fileOneMeg))
                //{
                //    File.Delete(fileOneMeg);
                //}
                
            }
        }

        [Fact]

        public async Task TestMultiPartUpload()
        {
            var Client = TestUtil.GlacierClient;
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);

            InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                ArchiveDescription = "dotnet mp upload",
                PartSize = 1048576
            };
            InitiateMultipartUploadResponse initResponse = await Client.InitiateMultipartUploadAsync(initRequest).ConfigureAwait(false);
            string uploadId = initResponse.UploadId;


            MemoryStream totalStream = new MemoryStream();
            for (int i = 0; i < 1048576 + 1048576 / 2; i++)
            {
                totalStream.WriteByte((byte)(i % byte.MaxValue));
            }
            totalStream.Position = 0;

            List<string> md5s = new List<string>();
            long currentPosition = 0;
            long partSize = 1048576;
            while (totalStream.Position < totalStream.Length)
            {
                Stream partStream = GlacierUtils.CreatePartStream(totalStream, partSize);
                string checkSum = TreeHashGenerator.CalculateTreeHash(partStream);
                md5s.Add(checkSum);

                UploadMultipartPartRequest partRequest = new UploadMultipartPartRequest()
                {
                    VaultName = testingVaultName,
                    UploadId = uploadId,
                    Body = partStream,
                    Checksum = checkSum
                };
                partRequest.SetRange(currentPosition, currentPosition + partStream.Length - 1);
                await Client.UploadMultipartPartAsync(partRequest).ConfigureAwait(false);
                currentPosition += partStream.Length;
            }

            CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
            {
                VaultName = testingVaultName,
                UploadId = uploadId,
                ArchiveSize = totalStream.Length.ToString(),
                Checksum = TreeHashGenerator.CalculateTreeHash(md5s)
            };
            CompleteMultipartUploadResponse compResponse = await Client.CompleteMultipartUploadAsync(compRequest).ConfigureAwait(false);
            Assert.NotNull(compResponse.Location);
            Assert.NotNull(compResponse.Checksum);
            string archiveId = compResponse.ArchiveId;

            DeleteArchiveRequest delArchiveRequest = new DeleteArchiveRequest()
            {
                VaultName = testingVaultName,
                ArchiveId = archiveId
            };
            DeleteArchiveResponse delArchiveResponse = await Client.DeleteArchiveAsync(delArchiveRequest).ConfigureAwait(false);
        }
        [Fact]
        public async Task Upload1GigFile()
        {
            var Client = TestUtil.GlacierClient;
            ArchiveTransferManager manager = new ArchiveTransferManager(Client);
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);
            string fileOneGig = @"c:\temp\UploadOneGigWithFileStream.bin";
            string downloadFile = @"c:\temp\download.bin";
            //            string checkSum = "d742e9348a3267650c7098bb3bd3cc55c98b75c1ce85663a1807d19151f8cb3e";
            CreateTempFile(fileOneGig, (long)Math.Pow(2, 30) + 2040010);
            //CreateTempFile(fileOneGig, (long)Math.Pow(2, 0));
            try
            {
                string archiveId = "";
                var result = await manager.UploadAsync(testingVaultName, "test file", fileOneGig).ConfigureAwait(false);

                using (Stream stream = File.OpenRead(fileOneGig))
                using (StreamWriter logFile = new StreamWriter(File.OpenWrite(@"c:\temp\progress.txt")))
                {
                    var request = new UploadArchiveRequest()
                    {
                        VaultName = testingVaultName,
                        ArchiveDescription = "Test File",
                        Body = stream,
                        Checksum = TreeHashGenerator.CalculateTreeHash(stream)
                    };
                    request.StreamTransferProgress += this.progress;

                    //var result = TestUtil.GlacierClient.BeginUploadArchive(request, null, null);
                    //var response = TestUtil.GlacierClient.EndUploadArchive(result);
                    //archiveId = response.ArchiveId;
                    archiveId = (await TestUtil.GlacierClient.UploadArchiveAsync(request).ConfigureAwait(false)).ArchiveId;
                }
                Assert.NotNull(result.ArchiveId);
                Assert.NotNull(result.Checksum);

                var downloadOptions = new DownloadOptions() { PollingInterval = 0.1 };
                downloadOptions.StreamTransferProgress += this.progress;
                await manager.DownloadAsync(testingVaultName, archiveId, downloadFile, defaultDownloadOptions).ConfigureAwait(false);
                CompareFile(fileOneGig, downloadFile);

                await manager.DeleteArchiveAsync(testingVaultName, archiveId).ConfigureAwait(false);
            }
            finally
            {
                //                File.Delete(fileOneGig);
            }
        }

        int percent = -1;
        StreamWriter logFile;
        void progress(object sender, Amazon.Runtime.StreamTransferProgressArgs args)
        {
            if (logFile != null && percent != args.PercentDone)
            {
                logFile.WriteLine("Uploading Files: {0}, Total Files: {1}", args.TransferredBytes, args.TotalBytes);
                logFile.Flush();
                percent = args.PercentDone;
            }
        }

        void downloadProgress(object sender, StreamTransferProgressArgs args)
        {
            if (logFile != null && percent != args.PercentDone)
            {
                logFile.WriteLine("Downloading Files: {0}, Total Files: {1}", args.TransferredBytes, args.TotalBytes);
                logFile.Flush();
                percent = args.PercentDone;
            }
        }

        [Fact]
        public async Task UploadLargeFile()
        {
            var Client = TestUtil.GlacierClient;
            ArchiveTransferManager manager = new ArchiveTransferManager(Client);
            await Client.CreateVaultAsync(new CreateVaultRequest()
            {
                VaultName = testingVaultName
            }).ConfigureAwait(false);
            string fileToUpload = @"c:\temp\UploadLargeFile.bin";
            string downloadFile = @"c:\temp\download.bin";
            CreateTempFile(fileToUpload, (long)(Math.Pow(2, 20) * 16) + 1000);
            try
            {
                UploadResult result = null;
                using (logFile = new StreamWriter(File.OpenWrite(@"c:\temp\upload.txt")))
                {
                    var options = new UploadOptions();
                    options.StreamTransferProgress += this.progress;
                    result = await manager.UploadAsync(testingVaultName, "test file", fileToUpload, options).ConfigureAwait(false);
                    Assert.NotNull(result.ArchiveId);
                    Assert.NotNull(result.Checksum);
                }

                using (logFile = new StreamWriter(File.OpenWrite(@"c:\temp\download.txt")))
                {
                    var options = new DownloadOptions();
                    options.StreamTransferProgress += this.downloadProgress;
                    options.PollingInterval = 0.1;
                    await manager.DownloadAsync(testingVaultName, result.ArchiveId, downloadFile, options).ConfigureAwait(false);
                }
                CompareFile(fileToUpload, downloadFile);

                await manager.DeleteArchiveAsync(testingVaultName, result.ArchiveId).ConfigureAwait(false);
                //File.Delete(downloadFile);
            }
            finally
            {
                //File.Delete(fileToUpload);
            }
        }

        public void CreateTempFile(string filePath, long size)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);

            var random = new Random();
            using (FileStream write = File.OpenWrite(filePath))
            {
                for (long i = 0; i < size; i++)
                {
                    write.WriteByte((byte)random.Next(byte.MinValue, byte.MaxValue));
                }
            }
        }
        public void CompareFile(string file1, string file2)
        {
            Assert.Equal(new FileInfo(file1).Length, new FileInfo(file2).Length);
            long length = new FileInfo(file1).Length;
            using (Stream file1Stream = File.OpenRead(file1))
            {
                using (Stream file2Stream = File.OpenRead(file2))
                {
                    for (int i = 0; i < length; i++)
                    {
                        var b1 = file1Stream.ReadByte();
                        var b2 = file2Stream.ReadByte();

                        Assert.Equal(b1, b2);
                    }
                }
            }
            

            byte[] file1MD5 = MD5.Create().ComputeHash(File.OpenRead(file1));
            byte[] file2MD5 = MD5.Create().ComputeHash(File.OpenRead(file2));

            Assert.Equal(file1MD5.Length, file2MD5.Length);
        }


    }

    public sealed class TestUtil
    {
        //private static TestCredentials defaultTestCredentials = null;
        //private static TestCredentials DefaultTestCredentials
        //{
        //    get
        //    {
        //        if (defaultTestCredentials == null)
        //        {
        //            defaultTestCredentials = TestCredentials.DefaultCredentials;
        //        }
        //        return defaultTestCredentials;
        //    }
        //}
        private static AmazonGlacierClient glacierClient;
        //public static string DEFAULT_ACCESS_KEY { get { return DefaultTestCredentials.AccessKey; } }
        //public static string DEFAULT_SECRET_KEY { get { return DefaultTestCredentials.SecretKey; } }
        //public static BasicAWSCredentials DefaultCredentials = new BasicAWSCredentials(DEFAULT_ACCESS_KEY, DEFAULT_SECRET_KEY);
        public static AmazonGlacierClient GlacierClient
        {
            get
            {
                if (glacierClient == null)
                {
                    AmazonGlacierConfig config = new AmazonGlacierConfig();
                    //config.RegionEndpoint = RegionEndpoint.USEast1;
                    config.ServiceURL = "http://glacier-gamma-iad.iad.proxy.amazon.com";
                    config.AuthenticationRegion = "us-east-1";
                    config.AuthenticationServiceName = "glacier";
                    glacierClient = new AmazonGlacierClient(config);

                }
                return glacierClient;
            }
        }
    }
}