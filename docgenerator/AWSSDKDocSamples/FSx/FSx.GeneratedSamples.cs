using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.FSx;
using Amazon.FSx.Model;

namespace AWSSDKDocSamples.Amazon.FSx.Generated
{
    class FSxSamples : ISample
    {
        public void FSxCopyBackup()
        {
            #region CopyBackup-1

            var client = new AmazonFSxClient();
            var response = client.CopyBackup(new CopyBackupRequest
            {
                SourceBackupId = "backup-03e3c82e0183b7b6b",
                SourceRegion = "us-east-2"
            });

            Backup backup = response.Backup;

            #endregion
        }

        public void FSxDeleteBackup()
        {
            #region DeleteBackup-1

            var client = new AmazonFSxClient();
            var response = client.DeleteBackup(new DeleteBackupRequest
            {
                BackupId = "backup-03e3c82e0183b7b6b"
            });

            string backupId = response.BackupId;
            BackupLifecycle lifecycle = response.Lifecycle;

            #endregion
        }

        public void FSxDeleteFileSystem()
        {
            #region DeleteFileSystem-1

            var client = new AmazonFSxClient();
            var response = client.DeleteFileSystem(new DeleteFileSystemRequest
            {
                FileSystemId = "fs-0498eed5fe91001ec"
            });

            string fileSystemId = response.FileSystemId;
            FileSystemLifecycle lifecycle = response.Lifecycle;

            #endregion
        }

        public void FSxListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonFSxClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceARN = "arn:aws:fsx:us-east-1:012345678912:file-system/fs-0498eed5fe91001ec"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void FSxTagResource()
        {
            #region TagResource-1

            var client = new AmazonFSxClient();
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
            #region UntagResource-1

            var client = new AmazonFSxClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceARN = "arn:aws:fsx:us-east-1:012345678912:file-system/fs-0498eed5fe91001ec",
                TagKeys = new List<string> {
                    "Name"
                }
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
