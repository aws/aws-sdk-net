using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Snowball;
using Amazon.Snowball.Model;

namespace AWSSDKDocSamples.Amazon.Snowball.Generated
{
    class SnowballSamples : ISample
    {
        public void SnowballCancelCluster()
        {
            #region to-cancel-a-cluster-job-1482533760554

            var client = new AmazonSnowballClient();
            var response = client.CancelCluster(new CancelClusterRequest 
            {
                ClusterId = "CID123e4567-e89b-12d3-a456-426655440000"
            });


            #endregion
        }

        public void SnowballCancelJob()
        {
            #region to-cancel-a-job-for-a-snowball-device-1482534699477

            var client = new AmazonSnowballClient();
            var response = client.CancelJob(new CancelJobRequest 
            {
                JobId = "JID123e4567-e89b-12d3-a456-426655440000"
            });


            #endregion
        }

        public void SnowballCreateAddress()
        {
            #region to-create-an-address-for-a-job-1482535416294

            var client = new AmazonSnowballClient();
            var response = client.CreateAddress(new CreateAddressRequest 
            {
                Address = new Address {
                    City = "Seattle",
                    Company = "My Company's Name",
                    Country = "USA",
                    Name = "My Name",
                    PhoneNumber = "425-555-5555",
                    PostalCode = "98101",
                    StateOrProvince = "WA",
                    Street1 = "123 Main Street"
                }
            });

            string addressId = response.AddressId;

            #endregion
        }

        public void SnowballCreateCluster()
        {
            #region to-create-a-cluster-1482864724077

            var client = new AmazonSnowballClient();
            var response = client.CreateCluster(new CreateClusterRequest 
            {
                AddressId = "ADID1234ab12-3eec-4eb3-9be6-9374c10eb51b",
                Description = "MyCluster",
                JobType = "LOCAL_USE",
                KmsKeyARN = "arn:aws:kms:us-east-1:123456789012:key/abcd1234-12ab-34cd-56ef-123456123456",
                Notification = new Notification {
                    JobStatesToNotify = new List<string> {
                        
                    },
                    NotifyAll = false
                },
                Resources = new JobResource { S3Resources = new List<S3Resource> {
                    new S3Resource {
                        BucketArn = "arn:aws:s3:::MyBucket",
                        KeyRange = new KeyRange {  }
                    }
                } },
                RoleARN = "arn:aws:iam::123456789012:role/snowball-import-S3-role",
                ShippingOption = "SECOND_DAY",
                SnowballType = "EDGE"
            });

            string clusterId = response.ClusterId;

            #endregion
        }

        public void SnowballCreateJob()
        {
            #region to-create-a-job-1482864834886

            var client = new AmazonSnowballClient();
            var response = client.CreateJob(new CreateJobRequest 
            {
                AddressId = "ADID1234ab12-3eec-4eb3-9be6-9374c10eb51b",
                Description = "My Job",
                JobType = "IMPORT",
                KmsKeyARN = "arn:aws:kms:us-east-1:123456789012:key/abcd1234-12ab-34cd-56ef-123456123456",
                Notification = new Notification {
                    JobStatesToNotify = new List<string> {
                        
                    },
                    NotifyAll = false
                },
                Resources = new JobResource { S3Resources = new List<S3Resource> {
                    new S3Resource {
                        BucketArn = "arn:aws:s3:::MyBucket",
                        KeyRange = new KeyRange {  }
                    }
                } },
                RoleARN = "arn:aws:iam::123456789012:role/snowball-import-S3-role",
                ShippingOption = "SECOND_DAY",
                SnowballCapacityPreference = "T80",
                SnowballType = "STANDARD"
            });

            string jobId = response.JobId;

            #endregion
        }

        public void SnowballDescribeAddress()
        {
            #region to-describe-an-address-for-a-job-1482538608745

            var client = new AmazonSnowballClient();
            var response = client.DescribeAddress(new DescribeAddressRequest 
            {
                AddressId = "ADID1234ab12-3eec-4eb3-9be6-9374c10eb51b"
            });

            Address address = response.Address;

            #endregion
        }

        public void SnowballDescribeAddresses()
        {
            #region to-describe-all-the-addresses-youve-created-for-aws-snowball-1482538936603

            var client = new AmazonSnowballClient();
            var response = client.DescribeAddresses(new DescribeAddressesRequest 
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void SnowballDescribeCluster()
        {
            #region to-describe-a-cluster-1482864218396

            var client = new AmazonSnowballClient();
            var response = client.DescribeCluster(new DescribeClusterRequest 
            {
                ClusterId = "CID123e4567-e89b-12d3-a456-426655440000"
            });

            ClusterMetadata clusterMetadata = response.ClusterMetadata;

            #endregion
        }

        public void SnowballDescribeJob()
        {
            #region to-describe-a-job-youve-created-for-aws-snowball-1482539500180

            var client = new AmazonSnowballClient();
            var response = client.DescribeJob(new DescribeJobRequest 
            {
                JobId = "JID123e4567-e89b-12d3-a456-426655440000"
            });

            JobMetadata jobMetadata = response.JobMetadata;

            #endregion
        }

        public void SnowballGetJobManifest()
        {
            #region to-get-the-manifest-for-a-job-youve-created-for-aws-snowball-1482540389246

            var client = new AmazonSnowballClient();
            var response = client.GetJobManifest(new GetJobManifestRequest 
            {
                JobId = "JID123e4567-e89b-12d3-a456-426655440000"
            });

            string manifestURI = response.ManifestURI;

            #endregion
        }

        public void SnowballGetJobUnlockCode()
        {
            #region to-get-the-unlock-code-for-a-job-youve-created-for-aws-snowball-1482541987286

            var client = new AmazonSnowballClient();
            var response = client.GetJobUnlockCode(new GetJobUnlockCodeRequest 
            {
                JobId = "JID123e4567-e89b-12d3-a456-426655440000"
            });

            string unlockCode = response.UnlockCode;

            #endregion
        }

        public void SnowballGetSnowballUsage()
        {
            #region to-see-your-snowball-service-limit-and-the-number-of-snowballs-you-have-in-use-1482863394588

            var client = new AmazonSnowballClient();
            var response = client.GetSnowballUsage(new GetSnowballUsageRequest 
            {
            });

            int snowballLimit = response.SnowballLimit;
            int snowballsInUse = response.SnowballsInUse;

            #endregion
        }

        public void SnowballListClusterJobs()
        {
            #region to-get-a-list-of-jobs-in-a-cluster-that-youve-created-for-aws-snowball-1482863105773

            var client = new AmazonSnowballClient();
            var response = client.ListClusterJobs(new ListClusterJobsRequest 
            {
                ClusterId = "CID123e4567-e89b-12d3-a456-426655440000"
            });

            List<JobListEntry> jobListEntries = response.JobListEntries;

            #endregion
        }

        public void SnowballListClusters()
        {
            #region to-get-a-list-of-clusters-that-youve-created-for-aws-snowball-1482862223003

            var client = new AmazonSnowballClient();
            var response = client.ListClusters(new ListClustersRequest 
            {
            });

            List<ClusterListEntry> clusterListEntries = response.ClusterListEntries;

            #endregion
        }

        public void SnowballListJobs()
        {
            #region to-get-a-list-of-jobs-that-youve-created-for-aws-snowball-1482542167627

            var client = new AmazonSnowballClient();
            var response = client.ListJobs(new ListJobsRequest 
            {
            });

            List<JobListEntry> jobListEntries = response.JobListEntries;

            #endregion
        }

        public void SnowballListPickupLocations()
        {
            #region to-get-a-list-of-locations-from-which-the-customer-can-choose-to-pickup-a-device-1482542167627

            var client = new AmazonSnowballClient();
            var response = client.ListPickupLocations(new ListPickupLocationsRequest 
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void SnowballUpdateCluster()
        {
            #region to-update-a-cluster-1482863900595

            var client = new AmazonSnowballClient();
            var response = client.UpdateCluster(new UpdateClusterRequest 
            {
                AddressId = "ADID1234ab12-3eec-4eb3-9be6-9374c10eb51b",
                ClusterId = "CID123e4567-e89b-12d3-a456-426655440000",
                Description = "updated-cluster-name"
            });


            #endregion
        }

        public void SnowballUpdateJob()
        {
            #region to-update-a-job-1482863556886

            var client = new AmazonSnowballClient();
            var response = client.UpdateJob(new UpdateJobRequest 
            {
                AddressId = "ADID1234ab12-3eec-4eb3-9be6-9374c10eb51b",
                Description = "updated-job-name",
                JobId = "JID123e4567-e89b-12d3-a456-426655440000",
                ShippingOption = "NEXT_DAY",
                SnowballCapacityPreference = "T100"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}