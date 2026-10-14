using System;
using System.Collections.Generic;
using System.IO;
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
            #region CancelCluster-1

            var client = new AmazonSnowballClient();
            var response = client.CancelCluster(new CancelClusterRequest
            {
                ClusterId = "CID123e4567-e89b-12d3-a456-426655440000"
            });


            #endregion
        }

        public void SnowballCancelJob()
        {
            #region CancelJob-1

            var client = new AmazonSnowballClient();
            var response = client.CancelJob(new CancelJobRequest
            {
                JobId = "JID123e4567-e89b-12d3-a456-426655440000"
            });


            #endregion
        }

        public void SnowballCreateAddress()
        {
            #region CreateAddress-1

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
            #region CreateCluster-1

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
            #region CreateJob-1

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
            #region DescribeAddress-1

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
            #region DescribeAddresses-1

            var client = new AmazonSnowballClient();
            var response = client.DescribeAddresses(new DescribeAddressesRequest
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void SnowballGetJobManifest()
        {
            #region GetJobManifest-1

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
            #region GetJobUnlockCode-1

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
            #region GetSnowballUsage-1

            var client = new AmazonSnowballClient();
            var response = client.GetSnowballUsage(new GetSnowballUsageRequest
            {
            });

            int? snowballLimit = response.SnowballLimit;
            int? snowballsInUse = response.SnowballsInUse;

            #endregion
        }

        public void SnowballListPickupLocations()
        {
            #region ListPickupLocations-1

            var client = new AmazonSnowballClient();
            var response = client.ListPickupLocations(new ListPickupLocationsRequest
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void SnowballUpdateCluster()
        {
            #region UpdateCluster-1

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
            #region UpdateJob-1

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

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
