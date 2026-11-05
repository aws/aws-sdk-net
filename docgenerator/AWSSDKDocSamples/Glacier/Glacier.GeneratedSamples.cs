using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Glacier;
using Amazon.Glacier.Model;

namespace AWSSDKDocSamples.Amazon.Glacier.Generated
{
    class GlacierSamples : ISample
    {
        public void GlacierAbortMultipartUpload()
        {
            #region AbortMultipartUpload-1

            var client = new AmazonGlacierClient();
            var response = client.AbortMultipartUpload(new AbortMultipartUploadRequest
            {
                AccountId = "-",
                UploadId = "19gaRezEXAMPLES6Ry5YYdqthHOC_kGRCT03L9yetr220UmPtBYKk-OssZtLqyFu7sY1_lR7vgFuJV6NtcV5zpsJ",
                VaultName = "my-vault"
            });


            #endregion
        }

        public void GlacierAbortVaultLock()
        {
            #region AbortVaultLock-1

            var client = new AmazonGlacierClient();
            var response = client.AbortVaultLock(new AbortVaultLockRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierAddTagsToVault()
        {
            #region AddTagsToVault-1

            var client = new AmazonGlacierClient();
            var response = client.AddTagsToVault(new AddTagsToVaultRequest
            {
                Tags = new Dictionary<string, string> {
                    { "examplekey1", "examplevalue1" },
                    { "examplekey2", "examplevalue2" }
                },
                AccountId = "-",
                VaultName = "my-vault"
            });


            #endregion
        }

        public void GlacierCompleteMultipartUpload()
        {
            #region CompleteMultipartUpload-1

            var client = new AmazonGlacierClient();
            var response = client.CompleteMultipartUpload(new CompleteMultipartUploadRequest
            {
                AccountId = "-",
                ArchiveSize = "3145728",
                Checksum = "9628195fcdbcbbe76cdde456d4646fa7de5f219fb39823836d81f0cc0e18aa67",
                UploadId = "19gaRezEXAMPLES6Ry5YYdqthHOC_kGRCT03L9yetr220UmPtBYKk-OssZtLqyFu7sY1_lR7vgFuJV6NtcV5zpsJ",
                VaultName = "my-vault"
            });

            string archiveId = response.ArchiveId;
            string checksum = response.Checksum;
            string location = response.Location;

            #endregion
        }

        public void GlacierCompleteVaultLock()
        {
            #region CompleteVaultLock-1

            var client = new AmazonGlacierClient();
            var response = client.CompleteVaultLock(new CompleteVaultLockRequest
            {
                AccountId = "-",
                LockId = "AE863rKkWZU53SLW5be4DUcW",
                VaultName = "example-vault"
            });


            #endregion
        }

        public void GlacierCreateVault()
        {
            #region CreateVault-1

            var client = new AmazonGlacierClient();
            var response = client.CreateVault(new CreateVaultRequest
            {
                AccountId = "-",
                VaultName = "my-vault"
            });

            string location = response.Location;

            #endregion
        }

        public void GlacierDeleteArchive()
        {
            #region DeleteArchive-1

            var client = new AmazonGlacierClient();
            var response = client.DeleteArchive(new DeleteArchiveRequest
            {
                AccountId = "-",
                ArchiveId = "NkbByEejwEggmBz2fTHgJrg0XBoDfjP4q6iu87-TjhqG6eGoOY9Z8i1_AUyUsuhPAdTqLHy8pTl5nfCFJmDl2yEZONi5L26Omw12vcs01MNGntHEQL8MBfGlqrEXAMPLEArchiveId",
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierDeleteVault()
        {
            #region DeleteVault-1

            var client = new AmazonGlacierClient();
            var response = client.DeleteVault(new DeleteVaultRequest
            {
                AccountId = "-",
                VaultName = "my-vault"
            });


            #endregion
        }

        public void GlacierDeleteVaultAccessPolicy()
        {
            #region DeleteVaultAccessPolicy-1

            var client = new AmazonGlacierClient();
            var response = client.DeleteVaultAccessPolicy(new DeleteVaultAccessPolicyRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierDeleteVaultNotifications()
        {
            #region DeleteVaultNotifications-1

            var client = new AmazonGlacierClient();
            var response = client.DeleteVaultNotifications(new DeleteVaultNotificationsRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierDescribeJob()
        {
            #region DescribeJob-1

            var client = new AmazonGlacierClient();
            var response = client.DescribeJob(new DescribeJobRequest
            {
                AccountId = "-",
                JobId = "zbxcm3Z_3z5UkoroF7SuZKrxgGoDc3RloGduS7Eg-RO47Yc6FxsdGBgf_Q2DK5Ejh18CnTS5XW4_XqlNHS61dsO4Cn",
                VaultName = "my-vault"
            });

            ActionCode action = response.Action;
            bool? completed = response.Completed;
            DateTime? creationDate = response.CreationDate;
            InventoryRetrievalJobDescription inventoryRetrievalParameters = response.InventoryRetrievalParameters;
            string jobId = response.JobId;
            StatusCode statusCode = response.StatusCode;
            string vaultARN = response.VaultARN;

            #endregion
        }

        public void GlacierDescribeVault()
        {
            #region DescribeVault-1

            var client = new AmazonGlacierClient();
            var response = client.DescribeVault(new DescribeVaultRequest
            {
                AccountId = "-",
                VaultName = "my-vault"
            });

            DateTime? creationDate = response.CreationDate;
            long? numberOfArchives = response.NumberOfArchives;
            long? sizeInBytes = response.SizeInBytes;
            string vaultARN = response.VaultARN;
            string vaultName = response.VaultName;

            #endregion
        }

        public void GlacierGetDataRetrievalPolicy()
        {
            #region GetDataRetrievalPolicy-1

            var client = new AmazonGlacierClient();
            var response = client.GetDataRetrievalPolicy(new GetDataRetrievalPolicyRequest
            {
                AccountId = "-"
            });

            DataRetrievalPolicy policy = response.Policy;

            #endregion
        }

        public void GlacierGetJobOutput()
        {
            #region GetJobOutput-1

            var client = new AmazonGlacierClient();
            var response = client.GetJobOutput(new GetJobOutputRequest
            {
                AccountId = "-",
                JobId = "zbxcm3Z_3z5UkoroF7SuZKrxgGoDc3RloGduS7Eg-RO47Yc6FxsdGBgf_Q2DK5Ejh18CnTS5XW4_XqlNHS61dsO4CnMW",
                Range = "",
                VaultName = "my-vaul"
            });

            string acceptRanges = response.AcceptRanges;
            Stream body = response.Body;
            string contentType = response.ContentType;
            int? status = response.Status;

            #endregion
        }

        public void GlacierGetVaultAccessPolicy()
        {
            #region GetVaultAccessPolicy-1

            var client = new AmazonGlacierClient();
            var response = client.GetVaultAccessPolicy(new GetVaultAccessPolicyRequest
            {
                AccountId = "-",
                VaultName = "example-vault"
            });

            VaultAccessPolicy policy = response.Policy;

            #endregion
        }

        public void GlacierGetVaultLock()
        {
            #region GetVaultLock-1

            var client = new AmazonGlacierClient();
            var response = client.GetVaultLock(new GetVaultLockRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });

            string creationDate = response.CreationDate;
            string expirationDate = response.ExpirationDate;
            string policy = response.Policy;
            string state = response.State;

            #endregion
        }

        public void GlacierGetVaultNotifications()
        {
            #region GetVaultNotifications-1

            var client = new AmazonGlacierClient();
            var response = client.GetVaultNotifications(new GetVaultNotificationsRequest
            {
                AccountId = "-",
                VaultName = "my-vault"
            });

            VaultNotificationConfig vaultNotificationConfig = response.VaultNotificationConfig;

            #endregion
        }

        public void GlacierInitiateJob()
        {
            #region InitiateJob-1

            var client = new AmazonGlacierClient();
            var response = client.InitiateJob(new InitiateJobRequest
            {
                AccountId = "-",
                JobParameters = new JobParameters {
                    Description = "My inventory job",
                    Format = "CSV",
                    SNSTopic = "arn:aws:sns:us-west-2:111111111111:Glacier-InventoryRetrieval-topic-Example",
                    Type = "inventory-retrieval"
                },
                VaultName = "examplevault"
            });

            string jobId = response.JobId;
            string location = response.Location;

            #endregion
        }

        public void GlacierInitiateMultipartUpload()
        {
            #region InitiateMultipartUpload-1

            var client = new AmazonGlacierClient();
            var response = client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
            {
                AccountId = "-",
                PartSize = "1048576",
                VaultName = "my-vault"
            });

            string location = response.Location;
            string uploadId = response.UploadId;

            #endregion
        }

        public void GlacierInitiateVaultLock()
        {
            #region InitiateVaultLock-1

            var client = new AmazonGlacierClient();
            var response = client.InitiateVaultLock(new InitiateVaultLockRequest
            {
                AccountId = "-",
                Policy = new VaultLockPolicy { Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Define-vault-lock\",\"Effect\":\"Deny\",\"Principal\":{\"AWS\":\"arn:aws:iam::999999999999:root\"},\"Action\":\"glacier:DeleteArchive\",\"Resource\":\"arn:aws:glacier:us-west-2:999999999999:vaults/examplevault\",\"Condition\":{\"NumericLessThanEquals\":{\"glacier:ArchiveAgeinDays\":\"365\"}}}]}" },
                VaultName = "my-vault"
            });

            string lockId = response.LockId;

            #endregion
        }

        public void GlacierListJobs()
        {
            #region ListJobs-1

            var client = new AmazonGlacierClient();
            var response = client.ListJobs(new ListJobsRequest
            {
                AccountId = "-",
                VaultName = "my-vault"
            });

            List<GlacierJobDescription> jobList = response.JobList;

            #endregion
        }

        public void GlacierListMultipartUploads()
        {
            #region ListMultipartUploads-1

            var client = new AmazonGlacierClient();
            var response = client.ListMultipartUploads(new ListMultipartUploadsRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });

            string marker = response.Marker;
            List<UploadListElement> uploadsList = response.UploadsList;

            #endregion
        }

        public void GlacierListParts()
        {
            #region ListParts-1

            var client = new AmazonGlacierClient();
            var response = client.ListParts(new ListPartsRequest
            {
                AccountId = "-",
                UploadId = "OW2fM5iVylEpFEMM9_HpKowRapC3vn5sSL39_396UW9zLFUWVrnRHaPjUJddQ5OxSHVXjYtrN47NBZ-khxOjyEXAMPLE",
                VaultName = "examplevault"
            });

            string archiveDescription = response.ArchiveDescription;
            DateTime? creationDate = response.CreationDate;
            string marker = response.Marker;
            string multipartUploadId = response.MultipartUploadId;
            long? partSizeInBytes = response.PartSizeInBytes;
            List<PartListElement> parts = response.Parts;
            string vaultARN = response.VaultARN;

            #endregion
        }

        public void GlacierListProvisionedCapacity()
        {
            #region ListProvisionedCapacity-1

            var client = new AmazonGlacierClient();
            var response = client.ListProvisionedCapacity(new ListProvisionedCapacityRequest
            {
                AccountId = "-"
            });

            List<ProvisionedCapacityDescription> provisionedCapacityList = response.ProvisionedCapacityList;

            #endregion
        }

        public void GlacierListTagsForVault()
        {
            #region ListTagsForVault-1

            var client = new AmazonGlacierClient();
            var response = client.ListTagsForVault(new ListTagsForVaultRequest
            {
                AccountId = "-",
                VaultName = "examplevault"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void GlacierListVaults()
        {
            #region ListVaults-1

            var client = new AmazonGlacierClient();
            var response = client.ListVaults(new ListVaultsRequest
            {
                AccountId = "-",
                Marker = ""
            });

            List<DescribeVaultOutput> vaultList = response.VaultList;

            #endregion
        }

        public void GlacierPurchaseProvisionedCapacity()
        {
            #region PurchaseProvisionedCapacity-1

            var client = new AmazonGlacierClient();
            var response = client.PurchaseProvisionedCapacity(new PurchaseProvisionedCapacityRequest
            {
                AccountId = "-"
            });

            string capacityId = response.CapacityId;

            #endregion
        }

        public void GlacierRemoveTagsFromVault()
        {
            #region RemoveTagsFromVault-1

            var client = new AmazonGlacierClient();
            var response = client.RemoveTagsFromVault(new RemoveTagsFromVaultRequest
            {
                TagKeys = new List<string> {
                    "examplekey1",
                    "examplekey2"
                },
                AccountId = "-",
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierSetDataRetrievalPolicy()
        {
            #region SetDataRetrievalPolicy-1

            var client = new AmazonGlacierClient();
            var response = client.SetDataRetrievalPolicy(new SetDataRetrievalPolicyRequest
            {
                Policy = new DataRetrievalPolicy { Rules = new List<DataRetrievalRule> {
                    new DataRetrievalRule {
                        BytesPerHour = 10737418240,
                        Strategy = "BytesPerHour"
                    }
                } },
                AccountId = "-"
            });


            #endregion
        }

        public void GlacierSetVaultAccessPolicy()
        {
            #region SetVaultAccessPolicy-1

            var client = new AmazonGlacierClient();
            var response = client.SetVaultAccessPolicy(new SetVaultAccessPolicyRequest
            {
                AccountId = "-",
                Policy = new VaultAccessPolicy { Policy = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Define-owner-access-rights\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::999999999999:root\"},\"Action\":\"glacier:DeleteArchive\",\"Resource\":\"arn:aws:glacier:us-west-2:999999999999:vaults/examplevault\"}]}" },
                VaultName = "examplevault"
            });


            #endregion
        }

        public void GlacierSetVaultNotifications()
        {
            #region SetVaultNotifications-1

            var client = new AmazonGlacierClient();
            var response = client.SetVaultNotifications(new SetVaultNotificationsRequest
            {
                AccountId = "-",
                VaultName = "examplevault",
                VaultNotificationConfig = new VaultNotificationConfig {
                    Events = new List<string> {
                        "ArchiveRetrievalCompleted",
                        "InventoryRetrievalCompleted"
                    },
                    SNSTopic = "arn:aws:sns:us-west-2:012345678901:mytopic"
                }
            });


            #endregion
        }

        public void GlacierUploadArchive()
        {
            #region UploadArchive-1

            var client = new AmazonGlacierClient();
            var response = client.UploadArchive(new UploadArchiveRequest
            {
                AccountId = "-",
                ArchiveDescription = "",
                Body = new MemoryStream(example-data-to-upload),
                Checksum = "",
                VaultName = "my-vault"
            });

            string archiveId = response.ArchiveId;
            string checksum = response.Checksum;
            string location = response.Location;

            #endregion
        }

        public void GlacierUploadMultipartPart()
        {
            #region UploadMultipartPart-1

            var client = new AmazonGlacierClient();
            var response = client.UploadMultipartPart(new UploadMultipartPartRequest
            {
                AccountId = "-",
                Body = new MemoryStream(part1),
                Checksum = "c06f7cd4baacb087002a99a5f48bf953",
                Range = "bytes 0-1048575/*",
                UploadId = "19gaRezEXAMPLES6Ry5YYdqthHOC_kGRCT03L9yetr220UmPtBYKk-OssZtLqyFu7sY1_lR7vgFuJV6NtcV5zpsJ",
                VaultName = "examplevault"
            });

            string checksum = response.Checksum;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
