using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticFileSystem;
using Amazon.ElasticFileSystem.Model;

namespace AWSSDKDocSamples.Amazon.ElasticFileSystem.Generated
{
    class ElasticFileSystemSamples : ISample
    {
        public void ElasticFileSystemCreateFileSystem()
        {
            #region to-create-a-new-file-system-1481840798547

            var client = new AmazonElasticFileSystemClient();
            var response = client.CreateFileSystem(new CreateFileSystemRequest 
            {
                Backup = true,
                CreationToken = "tokenstring",
                Encrypted = true,
                PerformanceMode = "generalPurpose",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyFileSystem"
                    }
                }
            });

            DateTime creationTime = response.CreationTime;
            string creationToken = response.CreationToken;
            bool encrypted = response.Encrypted;
            string fileSystemId = response.FileSystemId;
            string lifeCycleState = response.LifeCycleState;
            int numberOfMountTargets = response.NumberOfMountTargets;
            string ownerId = response.OwnerId;
            string performanceMode = response.PerformanceMode;
            FileSystemSize sizeInBytes = response.SizeInBytes;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void ElasticFileSystemCreateMountTarget()
        {
            #region to-create-a-new-mount-target-1481842289329

            var client = new AmazonElasticFileSystemClient();
            var response = client.CreateMountTarget(new CreateMountTargetRequest 
            {
                FileSystemId = "fs-01234567",
                SubnetId = "subnet-1234abcd"
            });

            string fileSystemId = response.FileSystemId;
            string ipAddress = response.IpAddress;
            string lifeCycleState = response.LifeCycleState;
            string mountTargetId = response.MountTargetId;
            string networkInterfaceId = response.NetworkInterfaceId;
            string ownerId = response.OwnerId;
            string subnetId = response.SubnetId;

            #endregion
        }

        public void ElasticFileSystemCreateTags()
        {
            #region to-create-a-new-tag-1481843409357

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
            #region to-delete-a-file-system-1481847318348

            var client = new AmazonElasticFileSystemClient();
            var response = client.DeleteFileSystem(new DeleteFileSystemRequest 
            {
                FileSystemId = "fs-01234567"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteMountTarget()
        {
            #region to-delete-a-mount-target-1481847635607

            var client = new AmazonElasticFileSystemClient();
            var response = client.DeleteMountTarget(new DeleteMountTargetRequest 
            {
                MountTargetId = "fsmt-12340abc"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteTags()
        {
            #region to-delete-tags-for-an-efs-file-system-1481848189061

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

        public void ElasticFileSystemDescribeFileSystems()
        {
            #region to-describe-an-efs-file-system-1481848448460

            var client = new AmazonElasticFileSystemClient();
            var response = client.DescribeFileSystems(new DescribeFileSystemsRequest 
            {
            });

            List<FileSystemDescription> fileSystems = response.FileSystems;

            #endregion
        }

        public void ElasticFileSystemDescribeLifecycleConfiguration()
        {
            #region to-describe-the-lifecycle-configuration-for-a-file-system-1551200664502

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
            #region to-describe-the-mount-targets-for-a-file-system-1481849958584

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
            #region to-describe-the-security-groups-for-a-mount-target-1481849317823

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
            #region to-describe-the-tags-for-a-file-system-1481850497090

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
            #region to-modify-the-security-groups-associated-with-a-mount-target-for-a-file-system-1481850772562

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
            #region creates-a-new-lifecycleconfiguration-object-for-a-file-system-1551201594692

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}