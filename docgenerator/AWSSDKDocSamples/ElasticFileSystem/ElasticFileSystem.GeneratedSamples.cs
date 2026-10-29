using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticFileSystem;
using Amazon.ElasticFileSystem.Model;

namespace AWSSDKDocSamples.Amazon.ElasticFileSystem.Generated
{
    class ElasticFileSystemSamples : ISample
    {
        public void ElasticFileSystemCreateMountTarget()
        {
            #region CreateMountTarget-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.CreateMountTarget(new CreateMountTargetRequest
            {
                FileSystemId = "fs-01234567",
                SubnetId = "subnet-1234abcd"
            });

            string fileSystemId = response.FileSystemId;
            string ipAddress = response.IpAddress;
            LifeCycleState lifeCycleState = response.LifeCycleState;
            string mountTargetId = response.MountTargetId;
            string networkInterfaceId = response.NetworkInterfaceId;
            string ownerId = response.OwnerId;
            string subnetId = response.SubnetId;

            #endregion
        }

        public void ElasticFileSystemCreateTags()
        {
            #region CreateTags-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.CreateTags(new CreateTagsRequest
            {
                FileSystemId = "fs-01234567",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyFileSystem"
                    }
                }
            });


            #endregion
        }

        public void ElasticFileSystemDeleteFileSystem()
        {
            #region DeleteFileSystem-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DeleteFileSystem(new DeleteFileSystemRequest
            {
                FileSystemId = "fs-01234567"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteMountTarget()
        {
            #region DeleteMountTarget-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DeleteMountTarget(new DeleteMountTargetRequest
            {
                MountTargetId = "fsmt-12340abc"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteTags()
        {
            #region DeleteTags-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DeleteTags(new DeleteTagsRequest
            {
                FileSystemId = "fs-01234567",
                TagKeys = new List<string> {
                    "Name"
                }
            });


            #endregion
        }

        public void ElasticFileSystemDescribeLifecycleConfiguration()
        {
            #region DescribeLifecycleConfiguration-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DescribeLifecycleConfiguration(new DescribeLifecycleConfigurationRequest
            {
                FileSystemId = "fs-01234567"
            });

            List<LifecyclePolicy> lifecyclePolicies = response.LifecyclePolicies;

            #endregion
        }

        public void ElasticFileSystemDescribeMountTargets()
        {
            #region DescribeMountTargets-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DescribeMountTargets(new DescribeMountTargetsRequest
            {
                FileSystemId = "fs-01234567"
            });

            List<MountTargetDescription> mountTargets = response.MountTargets;

            #endregion
        }

        public void ElasticFileSystemDescribeMountTargetSecurityGroups()
        {
            #region DescribeMountTargetSecurityGroups-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DescribeMountTargetSecurityGroups(new DescribeMountTargetSecurityGroupsRequest
            {
                MountTargetId = "fsmt-12340abc"
            });

            List<string> securityGroups = response.SecurityGroups;

            #endregion
        }

        public void ElasticFileSystemDescribeTags()
        {
            #region DescribeTags-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.DescribeTags(new DescribeTagsRequest
            {
                FileSystemId = "fs-01234567"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void ElasticFileSystemModifyMountTargetSecurityGroups()
        {
            #region ModifyMountTargetSecurityGroups-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.ModifyMountTargetSecurityGroups(new ModifyMountTargetSecurityGroupsRequest
            {
                MountTargetId = "fsmt-12340abc",
                SecurityGroups = new List<string> {
                    "sg-abcd1234"
                }
            });


            #endregion
        }

        public void ElasticFileSystemPutLifecycleConfiguration()
        {
            #region PutLifecycleConfiguration-1

            var client = new AmazonElasticFileSystemClient();
            var response = client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest
            {
                FileSystemId = "fs-01234567",
                LifecyclePolicies = new List<LifecyclePolicy> {
                    new LifecyclePolicy { TransitionToIA = "AFTER_30_DAYS" }
                }
            });

            List<LifecyclePolicy> lifecyclePolicies = response.LifecyclePolicies;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
