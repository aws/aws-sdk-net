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
        static IAmazonElasticFileSystem client = new AmazonElasticFileSystemClient();
        public void ElasticFileSystemCreateFileSystem()
        {
            #region to-create-a-new-file-system-1481840798547

            var response = client.CreateFileSystem(new CreateFileSystemRequest 
            {
                CreationToken = "tokenstring",
                PerformanceMode = "generalPurpose"
            });

            DateTime creationTime = response.CreationTime;
            string creationToken = response.CreationToken;
            string fileSystemId = response.FileSystemId;
            string lifeCycleState = response.LifeCycleState;
            integer numberOfMountTargets = response.NumberOfMountTargets;
            string ownerId = response.OwnerId;
            string performanceMode = response.PerformanceMode;
            FileSystemSize sizeInBytes = response.SizeInBytes;

            #endregion
        }

        public void ElasticFileSystemCreateMountTarget()
        {
            #region to-create-a-new-mount-target-1481842289329

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

            var response = client.DeleteFileSystem(new DeleteFileSystemRequest 
            {
                FileSystemId = "fs-01234567"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteMountTarget()
        {
            #region to-delete-a-mount-target-1481847635607

            var response = client.DeleteMountTarget(new DeleteMountTargetRequest 
            {
                MountTargetId = "fsmt-12340abc"
            });


            #endregion
        }

        public void ElasticFileSystemDeleteTags()
        {
            #region to-delete-tags-for-an-efs-file-system-1481848189061

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

            var response = client.DescribeFileSystems(new DescribeFileSystemsRequest 
            {
            });

            List<FileSystemDescription> fileSystems = response.FileSystems;

            #endregion
        }

        public void ElasticFileSystemDescribeMountTargets()
        {
            #region to-describe-the-mount-targets-for-a-file-system-1481849958584

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

            var response = client.ModifyMountTargetSecurityGroups(new ModifyMountTargetSecurityGroupsRequest 
            {
                MountTargetId = "fsmt-12340abc",
                SecurityGroups = new List<string> {
                    "sg-abcd1234"
                }
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