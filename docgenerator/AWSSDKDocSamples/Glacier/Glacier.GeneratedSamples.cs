using System;
using System.Collections.Generic;
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
            #region f3d907f6-e71c-420c-8f71-502346a2c48a

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
            #region to-abort-a-vault-lock-1481839357947

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
            #region add-tags-to-vault-post-tags-add-1481663457694

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
            #region 272aa0b8-e44c-4a64-add2-ad905a37984d

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
            #region to-complete-a-vault-lock-1481839721312

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
            #region 1dc0313d-ace1-4e6c-9d13-1ec7813b14b7

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
            #region delete-archive-1481667809463

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
            #region 7f7f000b-4bdb-40d2-91e6-7c902f60f60f

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
            #region to-delete-the-vault-access-policy-1481840424677

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
            #region to-delete-the-notification-configuration-set-for-a-vault-1481840646090

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
            #region to-get-information-about-a-job-you-previously-initiated-1481840928592

            var client = new AmazonGlacierClient();
            var response = client.DescribeJob(new DescribeJobRequest 
            {
                AccountId = "-",
                JobId = "zbxcm3Z_3z5UkoroF7SuZKrxgGoDc3RloGduS7Eg-RO47Yc6FxsdGBgf_Q2DK5Ejh18CnTS5XW4_XqlNHS61dsO4Cn",
                VaultName = "my-vault"
            });

            string action = response.Action;
            bool completed = response.Completed;
            string creationDate = response.CreationDate;
            InventoryRetrievalJobDescription inventoryRetrievalParameters = response.InventoryRetrievalParameters;
            string jobId = response.JobId;
            string statusCode = response.StatusCode;
            string vaultARN = response.VaultARN;

            #endregion
        }

        public void GlacierDescribeVault()
        {
            #region 3c1c6e9d-f5a2-427a-aa6a-f439eacfc05f

            var client = new AmazonGlacierClient();
            var response = client.DescribeVault(new DescribeVaultRequest 
            {
                AccountId = "-",
                VaultName = "my-vault"
            });

            string creationDate = response.CreationDate;
            long numberOfArchives = response.NumberOfArchives;
            long sizeInBytes = response.SizeInBytes;
            string vaultARN = response.VaultARN;
            string vaultName = response.VaultName;

            #endregion
        }

        public void GlacierGetDataRetrievalPolicy()
        {
            #region to-get-the-current-data-retrieval-policy-for-the-account-1481851580439

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
            #region to-get-the-output-of-a-previously-initiated-job-1481848550859

            var client = new AmazonGlacierClient();
            var response = client.GetJobOutput(new GetJobOutputRequest 
            {
                AccountId = "-",
                JobId = "zbxcm3Z_3z5UkoroF7SuZKrxgGoDc3RloGduS7Eg-RO47Yc6FxsdGBgf_Q2DK5Ejh18CnTS5XW4_XqlNHS61dsO4CnMW",
                Range = "",
                VaultName = "my-vaul"
            });

            string acceptRanges = response.AcceptRanges;
            MemoryStream body = response.Body;
            string contentType = response.ContentType;
            int status = response.Status;

            #endregion
        }

        public void GlacierGetVaultAccessPolicy()
        {
            #region to--get-the-access-policy-set-on-the-vault-1481936004590

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
            #region to-retrieve-vault-lock-policy-related-attributes-that-are-set-on-a-vault-1481851363097

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
            #region to-get-the-notification-configuration-for-the-specified-vault-1481918746677

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
            #region to-initiate-an-inventory-retrieval-job-1482186883826

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
            #region 72f2db19-3d93-4c74-b2ed-38703baacf49

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
            #region to-initiate-the-vault-locking-process-1481919693394

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
            #region to-list-jobs-for-a-vault-1481920530537

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
            #region to-list-all-the-in-progress-multipart-uploads-for-a-vault-1481935250590

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
            #region to-list-the-parts-of-an-archive-that-have-been-uploaded-in-a-multipart-upload-1481921767590

            var client = new AmazonGlacierClient();
            var response = client.ListParts(new ListPartsRequest 
            {
                AccountId = "-",
                UploadId = "OW2fM5iVylEpFEMM9_HpKowRapC3vn5sSL39_396UW9zLFUWVrnRHaPjUJddQ5OxSHVXjYtrN47NBZ-khxOjyEXAMPLE",
                VaultName = "examplevault"
            });

            string archiveDescription = response.ArchiveDescription;
            string creationDate = response.CreationDate;
            string marker = response.Marker;
            string multipartUploadId = response.MultipartUploadId;
            long partSizeInBytes = response.PartSizeInBytes;
            List<PartListElement> parts = response.Parts;
            string vaultARN = response.VaultARN;

            #endregion
        }

        public void GlacierListProvisionedCapacity()
        {
            #region to-list-the-provisioned-capacity-units-for-an-account-1481923656130

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
            #region list-tags-for-vault-1481755839720

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
            #region list-vaults-1481753006990

            var client = new AmazonGlacierClient();
            var response = client.ListVaults(new ListVaultsRequest 
            {
                AccountId = "-",
                Limit = "",
                Marker = ""
            });

            List<DescribeVaultOutput> vaultList = response.VaultList;

            #endregion
        }

        public void GlacierPurchaseProvisionedCapacity()
        {
            #region to-purchases-a-provisioned-capacity-unit-for-an-aws-account-1481927446662

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
            #region remove-tags-from-vault-1481754998801

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
            #region to-set-and-then-enact-a-data-retrieval-policy--1481928352408

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
            #region to--set-the-access-policy-on-a-vault-1482185872517

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
            #region to-configure-a-vault-to-post-a-message-to-an-amazon-simple-notification-service-amazon-sns-topic-when-jobs-complete-1482186397475

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
            #region upload-archive-1481668510494

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
            #region to-upload-the-first-part-of-an-archive-1481835899519

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}