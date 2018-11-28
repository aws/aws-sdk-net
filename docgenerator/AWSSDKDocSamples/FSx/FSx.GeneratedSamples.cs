using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.FSx;
using Amazon.FSx.Model;

namespace AWSSDKDocSamples.Amazon.FSx.Generated
{
    class FSxSamples : ISample
    {
        static IAmazonFSx client = new AmazonFSxClient();
        public void FSxCreateBackup()
        {
            #region to-create-a-new-backup-1481840798597

            var response = client.CreateBackup(new CreateBackupRequest 
            {
                FileSystemId = "fs-0498eed5fe91001ec",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyBackup"
                    }
                }
            });

            Backup backup = response.Backup;

            #endregion
        }

        public void FSxCreateFileSystem()
        {
            #region to-create-a-new-file-system-1481840798547

            var response = client.CreateFileSystem(new CreateFileSystemRequest 
            {
                ClientRequestToken = "a8ca07e4-61ec-4399-99f4-19853801bcd5",
                FileSystemType = "WINDOWS",
                KmsKeyId = "arn:aws:kms:us-east-1:012345678912:key/0ff3ea8d-130e-4133-877f-93908b6fdbd6",
                SecurityGroupIds = new List<string> {
                    "sg-edcd9784"
                },
                StorageCapacity = 300,
                SubnetIds = new List<string> {
                    "subnet-1234abcd"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyFileSystem"
                    }
                },
                WindowsConfiguration = new CreateFileSystemWindowsConfiguration {
                    ActiveDirectoryId = "d-1234abcd12",
                    AutomaticBackupRetentionDays = 30,
                    DailyAutomaticBackupStartTime = "05:00",
                    ThroughputCapacity = 8,
                    WeeklyMaintenanceStartTime = "1:05:00"
                }
            });

            FileSystem fileSystem = response.FileSystem;

            #endregion
        }

        public void FSxCreateFileSystemFromBackup()
        {
            #region to-create-a-new-file-system-from-backup-1481840798598

            var response = client.CreateFileSystemFromBackup(new CreateFileSystemFromBackupRequest 
            {
                BackupId = "backup-03e3c82e0183b7b6b",
                ClientRequestToken = "f4c94ed7-238d-4c46-93db-48cd62ec33b7",
                SecurityGroupIds = new List<string> {
                    "sg-edcd9784"
                },
                SubnetIds = new List<string> {
                    "subnet-1234abcd"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyFileSystem"
                    }
                },
                WindowsConfiguration = new CreateFileSystemWindowsConfiguration { ThroughputCapacity = 8 }
            });

            FileSystem fileSystem = response.FileSystem;

            #endregion
        }

        public void FSxDeleteBackup()
        {
            #region to-delete-a-file-system-1481847318399

            var response = client.DeleteBackup(new DeleteBackupRequest 
            {
                BackupId = "backup-03e3c82e0183b7b6b"
            });

            string backupId = response.BackupId;
            string lifecycle = response.Lifecycle;

            #endregion
        }

        public void FSxDeleteFileSystem()
        {
            #region to-delete-a-file-system-1481847318348

            var response = client.DeleteFileSystem(new DeleteFileSystemRequest 
            {
                FileSystemId = "fs-0498eed5fe91001ec"
            });

            string fileSystemId = response.FileSystemId;
            string lifecycle = response.Lifecycle;

            #endregion
        }

        public void FSxDescribeBackups()
        {
            #region to-describe-backups-1481848448499

            var response = client.DescribeBackups(new DescribeBackupsRequest 
            {
            });

            List<Backup> backups = response.Backups;

            #endregion
        }

        public void FSxDescribeFileSystems()
        {
            #region to-describe-a-file-systems-1481848448460

            var response = client.DescribeFileSystems(new DescribeFileSystemsRequest 
            {
            });

            List<FileSystem> fileSystems = response.FileSystems;

            #endregion
        }

        public void FSxListTagsForResource()
        {
            #region to-list-tags-for-a-fsx-resource-1481847318372

            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:fsx:us-east-1:012345678912:file-system/fs-0498eed5fe91001ec"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void FSxTagResource()
        {
            #region to-tag-a-fsx-resource-1481847318371

            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:fsx:us-east-1:012345678912:file-system/fs-0498eed5fe91001ec",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Name",
                        Value = "MyFileSystem"
                    }
                }
            });


            #endregion
        }

        public void FSxUntagResource()
        {
            #region to-untag-a-fsx-resource-1481847318373

            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:fsx:us-east-1:012345678912:file-system/fs-0498eed5fe91001ec",
                TagKeys = new List<string> {
                    "Name"
                }
            });


            #endregion
        }

        public void FSxUpdateFileSystem()
        {
            #region to-update-a-file-system-1481840798595

            var response = client.UpdateFileSystem(new UpdateFileSystemRequest 
            {
                FileSystemId = "fs-0498eed5fe91001ec",
                WindowsConfiguration = new UpdateFileSystemWindowsConfiguration {
                    AutomaticBackupRetentionDays = 10,
                    DailyAutomaticBackupStartTime = "06:00",
                    WeeklyMaintenanceStartTime = "3:06:00"
                }
            });

            FileSystem fileSystem = response.FileSystem;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}