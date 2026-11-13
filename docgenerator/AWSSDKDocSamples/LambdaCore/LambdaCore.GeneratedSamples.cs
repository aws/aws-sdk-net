using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.LambdaCore;
using Amazon.LambdaCore.Model;

namespace AWSSDKDocSamples.Amazon.LambdaCore.Generated
{
    class LambdaCoreSamples : ISample
    {
        public void LambdaCoreCreateRuntime()
        {
            #region CreateRuntime-1

            var client = new AmazonLambdaCoreClient();
            var response = client.CreateRuntime(new CreateRuntimeRequest
            {
                Description = "PHP 8 custom runtime",
                LicenseInfo = "MIT",
                Name = "php8",
                Tags = new Dictionary<string, string> {
                    { "team", "runtimes" }
                }
            });

            string arn = response.Arn;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string licenseInfo = response.LicenseInfo;
            string name = response.Name;

            #endregion
        }

        public void LambdaCoreCreateRuntimeAlias()
        {
            #region CreateRuntimeAlias-1

            var client = new AmazonLambdaCoreClient();
            var response = client.CreateRuntimeAlias(new CreateRuntimeAliasRequest
            {
                Description = "Points at the newest published version",
                Name = "latest",
                RuntimeName = "php8",
                RuntimeVersion = "v1"
            });

            string arn = response.Arn;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string name = response.Name;
            string runtimeVersion = response.RuntimeVersion;
            string runtimeVersionArn = response.RuntimeVersionArn;
            RuntimeAliasState state = response.State;

            #endregion
        }

        public void LambdaCoreCreateRuntimeVersion()
        {
            #region CreateRuntimeVersion-1

            var client = new AmazonLambdaCoreClient();
            var response = client.CreateRuntimeVersion(new CreateRuntimeVersionRequest
            {
                ImageUri = "123456789012.dkr.ecr.us-west-2.amazonaws.com/php8:latest",
                Name = "v1",
                ReleaseNotes = "Initial release",
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            Compatibility compatibility = response.Compatibility;
            string created = response.Created;
            string lastModified = response.LastModified;
            string name = response.Name;
            List<Platform> platforms = response.Platforms;
            string releaseNotes = response.ReleaseNotes;
            string resolvedUri = response.ResolvedUri;
            RuntimeVersionState state = response.State;

            #endregion
        }

        public void LambdaCoreDeleteRuntime()
        {
            #region DeleteRuntime-1

            var client = new AmazonLambdaCoreClient();
            var response = client.DeleteRuntime(new DeleteRuntimeRequest
            {
                RuntimeName = "php8"
            });


            #endregion
        }

        public void LambdaCoreDeleteRuntimeAlias()
        {
            #region DeleteRuntimeAlias-1

            var client = new AmazonLambdaCoreClient();
            var response = client.DeleteRuntimeAlias(new DeleteRuntimeAliasRequest
            {
                Name = "latest",
                RuntimeName = "php8"
            });


            #endregion
        }

        public void LambdaCoreDeleteRuntimeVersion()
        {
            #region DeleteRuntimeVersion-1

            var client = new AmazonLambdaCoreClient();
            var response = client.DeleteRuntimeVersion(new DeleteRuntimeVersionRequest
            {
                Name = "v1",
                RuntimeName = "php8"
            });


            #endregion
        }

        public void LambdaCoreGetRuntime()
        {
            #region GetRuntime-1

            var client = new AmazonLambdaCoreClient();
            var response = client.GetRuntime(new GetRuntimeRequest
            {
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string licenseInfo = response.LicenseInfo;
            string name = response.Name;
            RuntimeReleaseLifecycle releaseLifecycle = response.ReleaseLifecycle;

            #endregion
        }

        public void LambdaCoreGetRuntimeAlias()
        {
            #region GetRuntimeAlias-1

            var client = new AmazonLambdaCoreClient();
            var response = client.GetRuntimeAlias(new GetRuntimeAliasRequest
            {
                Name = "latest",
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            Compatibility compatibility = response.Compatibility;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string name = response.Name;
            RuntimeReleaseLifecycle releaseLifecycle = response.ReleaseLifecycle;
            string runtimeVersion = response.RuntimeVersion;
            string runtimeVersionArn = response.RuntimeVersionArn;
            RuntimeAliasState state = response.State;

            #endregion
        }

        public void LambdaCoreGetRuntimeVersion()
        {
            #region GetRuntimeVersion-1

            var client = new AmazonLambdaCoreClient();
            var response = client.GetRuntimeVersion(new GetRuntimeVersionRequest
            {
                Name = "v1",
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            Compatibility compatibility = response.Compatibility;
            string created = response.Created;
            string lastModified = response.LastModified;
            string name = response.Name;
            List<Platform> platforms = response.Platforms;
            string releaseNotes = response.ReleaseNotes;
            string resolvedUri = response.ResolvedUri;
            RuntimeVersionState state = response.State;

            #endregion
        }

        public void LambdaCoreListRuntimeAliases()
        {
            #region ListRuntimeAliases-1

            var client = new AmazonLambdaCoreClient();
            var response = client.ListRuntimeAliases(new ListRuntimeAliasesRequest
            {
                MaxResults = 10,
                RuntimeName = "php8"
            });

            List<RuntimeAliasInfo> items = response.Items;

            #endregion
        }

        public void LambdaCoreListRuntimes()
        {
            #region ListRuntimes-1

            var client = new AmazonLambdaCoreClient();
            var response = client.ListRuntimes(new ListRuntimesRequest
            {
                MaxResults = 10
            });

            List<RuntimeInfo> items = response.Items;

            #endregion
        }

        public void LambdaCoreListRuntimeVersions()
        {
            #region ListRuntimeVersions-1

            var client = new AmazonLambdaCoreClient();
            var response = client.ListRuntimeVersions(new ListRuntimeVersionsRequest
            {
                MaxResults = 10,
                RuntimeName = "php8"
            });

            List<RuntimeVersionInfo> items = response.Items;

            #endregion
        }

        public void LambdaCoreRestoreRuntime()
        {
            #region RestoreRuntime-1

            var client = new AmazonLambdaCoreClient();
            var response = client.RestoreRuntime(new RestoreRuntimeRequest
            {
                RuntimeAlias = "release",
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            string lastModified = response.LastModified;
            string runtimeAlias = response.RuntimeAlias;
            string runtimeName = response.RuntimeName;
            RuntimeState state = response.State;

            #endregion
        }

        public void LambdaCoreRestoreRuntime()
        {
            #region RestoreRuntime-2

            var client = new AmazonLambdaCoreClient();
            var response = client.RestoreRuntime(new RestoreRuntimeRequest
            {
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            string lastModified = response.LastModified;
            string runtimeName = response.RuntimeName;
            RuntimeState state = response.State;

            #endregion
        }

        public void LambdaCoreUpdateRuntime()
        {
            #region UpdateRuntime-1

            var client = new AmazonLambdaCoreClient();
            var response = client.UpdateRuntime(new UpdateRuntimeRequest
            {
                Description = "PHP 8 custom runtime (updated)",
                ReleaseLifecycle = new RuntimeReleaseLifecycle { ReleaseState = "GA" },
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string licenseInfo = response.LicenseInfo;
            string name = response.Name;
            RuntimeReleaseLifecycle releaseLifecycle = response.ReleaseLifecycle;

            #endregion
        }

        public void LambdaCoreUpdateRuntimeAlias()
        {
            #region UpdateRuntimeAlias-1

            var client = new AmazonLambdaCoreClient();
            var response = client.UpdateRuntimeAlias(new UpdateRuntimeAliasRequest
            {
                Name = "latest",
                RuntimeName = "php8",
                RuntimeVersion = "v2"
            });

            string arn = response.Arn;
            string created = response.Created;
            string description = response.Description;
            string lastModified = response.LastModified;
            string name = response.Name;
            string runtimeName = response.RuntimeName;
            string runtimeVersion = response.RuntimeVersion;
            string runtimeVersionArn = response.RuntimeVersionArn;
            RuntimeAliasState state = response.State;

            #endregion
        }

        public void LambdaCoreUpdateRuntimeVersion()
        {
            #region UpdateRuntimeVersion-1

            var client = new AmazonLambdaCoreClient();
            var response = client.UpdateRuntimeVersion(new UpdateRuntimeVersionRequest
            {
                Name = "v1",
                ReleaseNotes = "Patched OpenSSL to 3.0.14",
                RuntimeName = "php8"
            });

            string arn = response.Arn;
            string created = response.Created;
            string lastModified = response.LastModified;
            string name = response.Name;
            string releaseNotes = response.ReleaseNotes;
            string resolvedUri = response.ResolvedUri;
            RuntimeVersionState state = response.State;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
