using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Lambda;
using Amazon.Lambda.Model;

namespace AWSSDKDocSamples.Amazon.Lambda.Generated
{
    class LambdaSamples : ISample
    {
        public void LambdaAddLayerVersionPermission()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.AddLayerVersionPermission(new AddLayerVersionPermissionRequest 
            {
                Action = "lambda:GetLayerVersion",
                LayerName = "my-layer",
                Principal = "223456789012",
                StatementId = "xaccount",
                VersionNumber = 1
            });

            string revisionId = response.RevisionId;
            string statement = response.Statement;

            #endregion
        }

        public void LambdaAddPermission()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.AddPermission(new AddPermissionRequest 
            {
                Action = "lambda:InvokeFunction",
                FunctionName = "my-function",
                Principal = "s3.amazonaws.com",
                SourceAccount = "123456789012",
                SourceArn = "arn:aws:s3:::my-bucket-1xpuxmplzrlbh/*",
                StatementId = "s3"
            });

            string statement = response.Statement;

            #endregion
        }

        public void LambdaAddPermission()
        {
            #region example-2

            var client = new AmazonLambdaClient();
            var response = client.AddPermission(new AddPermissionRequest 
            {
                Action = "lambda:InvokeFunction",
                FunctionName = "my-function",
                Principal = "223456789012",
                StatementId = "xaccount"
            });

            string statement = response.Statement;

            #endregion
        }

        public void LambdaCreateAlias()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.CreateAlias(new CreateAliasRequest 
            {
                Description = "alias for live version of function",
                FunctionName = "my-function",
                FunctionVersion = "1",
                Name = "LIVE"
            });

            string aliasArn = response.AliasArn;
            string description = response.Description;
            string functionVersion = response.FunctionVersion;
            string name = response.Name;
            string revisionId = response.RevisionId;

            #endregion
        }

        public void LambdaCreateEventSourceMapping()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.CreateEventSourceMapping(new CreateEventSourceMappingRequest 
            {
                BatchSize = 5,
                EventSourceArn = "arn:aws:sqs:us-west-2:123456789012:my-queue",
                FunctionName = "my-function"
            });

            int batchSize = response.BatchSize;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaCreateFunction()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.CreateFunction(new CreateFunctionRequest 
            {
                Code = new FunctionCode {
                    S3Bucket = "my-bucket-1xpuxmplzrlbh",
                    S3Key = "function.zip"
                },
                Description = "Process image objects from Amazon S3.",
                Environment = new Environment { Variables = new Dictionary<string, string> {
                    { "BUCKET", "my-bucket-1xpuxmplzrlbh" },
                    { "PREFIX", "inbound" }
                } },
                FunctionName = "my-function",
                Handler = "index.handler",
                KMSKeyArn = "arn:aws:kms:us-west-2:123456789012:key/b0844d6c-xmpl-4463-97a4-d49f50839966",
                MemorySize = 256,
                Publish = true,
                Role = "arn:aws:iam::123456789012:role/lambda-role",
                Runtime = "nodejs12.x",
                Tags = new Dictionary<string, string> {
                    { "DEPARTMENT", "Assets" }
                },
                Timeout = 15,
                TracingConfig = new TracingConfig { Mode = "Active" }
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            EnvironmentResponse environment = response.Environment;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string kmsKeyArn = response.KMSKeyArn;
            string lastModified = response.LastModified;
            string lastUpdateStatus = response.LastUpdateStatus;
            int memorySize = response.MemorySize;
            string revisionId = response.RevisionId;
            string role = response.Role;
            string runtime = response.Runtime;
            string state = response.State;
            int timeout = response.Timeout;
            TracingConfigResponse tracingConfig = response.TracingConfig;
            string version = response.Version;

            #endregion
        }

        public void LambdaDeleteAlias()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteAlias(new DeleteAliasRequest 
            {
                FunctionName = "my-function",
                Name = "BLUE"
            });


            #endregion
        }

        public void LambdaDeleteEventSourceMapping()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteEventSourceMapping(new DeleteEventSourceMappingRequest 
            {
                UUID = "14e0db71-xmpl-4eb5-b481-8945cf9d10c2"
            });

            int batchSize = response.BatchSize;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaDeleteFunction()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteFunction(new DeleteFunctionRequest 
            {
                FunctionName = "my-function",
                Qualifier = "1"
            });


            #endregion
        }

        public void LambdaDeleteFunctionConcurrency()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteFunctionConcurrency(new DeleteFunctionConcurrencyRequest 
            {
                FunctionName = "my-function"
            });


            #endregion
        }

        public void LambdaDeleteFunctionEventInvokeConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteFunctionEventInvokeConfig(new DeleteFunctionEventInvokeConfigRequest 
            {
                FunctionName = "my-function",
                Qualifier = "GREEN"
            });


            #endregion
        }

        public void LambdaDeleteLayerVersion()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteLayerVersion(new DeleteLayerVersionRequest 
            {
                LayerName = "my-layer",
                VersionNumber = 2
            });


            #endregion
        }

        public void LambdaDeleteProvisionedConcurrencyConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.DeleteProvisionedConcurrencyConfig(new DeleteProvisionedConcurrencyConfigRequest 
            {
                FunctionName = "my-function",
                Qualifier = "GREEN"
            });


            #endregion
        }

        public void LambdaGetAccountSettings()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetAccountSettings(new GetAccountSettingsRequest 
            {
            });

            AccountLimit accountLimit = response.AccountLimit;
            AccountUsage accountUsage = response.AccountUsage;

            #endregion
        }

        public void LambdaGetAlias()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetAlias(new GetAliasRequest 
            {
                FunctionName = "my-function",
                Name = "BLUE"
            });

            string aliasArn = response.AliasArn;
            string description = response.Description;
            string functionVersion = response.FunctionVersion;
            string name = response.Name;
            string revisionId = response.RevisionId;

            #endregion
        }

        public void LambdaGetEventSourceMapping()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetEventSourceMapping(new GetEventSourceMappingRequest 
            {
                UUID = "14e0db71-xmpl-4eb5-b481-8945cf9d10c2"
            });

            int batchSize = response.BatchSize;
            bool bisectBatchOnFunctionError = response.BisectBatchOnFunctionError;
            DestinationConfig destinationConfig = response.DestinationConfig;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string lastProcessingResult = response.LastProcessingResult;
            int maximumRecordAgeInSeconds = response.MaximumRecordAgeInSeconds;
            int maximumRetryAttempts = response.MaximumRetryAttempts;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaGetFunction()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetFunction(new GetFunctionRequest 
            {
                FunctionName = "my-function",
                Qualifier = "1"
            });

            FunctionCodeLocation code = response.Code;
            FunctionConfiguration configuration = response.Configuration;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void LambdaGetFunctionConcurrency()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetFunctionConcurrency(new GetFunctionConcurrencyRequest 
            {
                FunctionName = "my-function"
            });

            int reservedConcurrentExecutions = response.ReservedConcurrentExecutions;

            #endregion
        }

        public void LambdaGetFunctionConfiguration()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetFunctionConfiguration(new GetFunctionConfigurationRequest 
            {
                FunctionName = "my-function",
                Qualifier = "1"
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            EnvironmentResponse environment = response.Environment;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string kmsKeyArn = response.KMSKeyArn;
            string lastModified = response.LastModified;
            string lastUpdateStatus = response.LastUpdateStatus;
            int memorySize = response.MemorySize;
            string revisionId = response.RevisionId;
            string role = response.Role;
            string runtime = response.Runtime;
            string state = response.State;
            int timeout = response.Timeout;
            TracingConfigResponse tracingConfig = response.TracingConfig;
            string version = response.Version;

            #endregion
        }

        public void LambdaGetFunctionEventInvokeConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetFunctionEventInvokeConfig(new GetFunctionEventInvokeConfigRequest 
            {
                FunctionName = "my-function",
                Qualifier = "BLUE"
            });

            DestinationConfig destinationConfig = response.DestinationConfig;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            int maximumEventAgeInSeconds = response.MaximumEventAgeInSeconds;
            int maximumRetryAttempts = response.MaximumRetryAttempts;

            #endregion
        }

        public void LambdaGetLayerVersion()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetLayerVersion(new GetLayerVersionRequest 
            {
                LayerName = "my-layer",
                VersionNumber = 1
            });

            List<string> compatibleRuntimes = response.CompatibleRuntimes;
            LayerVersionContentOutput content = response.Content;
            string createdDate = response.CreatedDate;
            string description = response.Description;
            string layerArn = response.LayerArn;
            string layerVersionArn = response.LayerVersionArn;
            string licenseInfo = response.LicenseInfo;
            long version = response.Version;

            #endregion
        }

        public void LambdaGetLayerVersionByArn()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetLayerVersionByArn(new GetLayerVersionByArnRequest 
            {
                Arn = "arn:aws:lambda:ca-central-1:123456789012:layer:blank-python-lib:3"
            });

            List<string> compatibleRuntimes = response.CompatibleRuntimes;
            LayerVersionContentOutput content = response.Content;
            string createdDate = response.CreatedDate;
            string description = response.Description;
            string layerArn = response.LayerArn;
            string layerVersionArn = response.LayerVersionArn;
            long version = response.Version;

            #endregion
        }

        public void LambdaGetPolicy()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetPolicy(new GetPolicyRequest 
            {
                FunctionName = "my-function",
                Qualifier = "1"
            });

            string policy = response.Policy;
            string revisionId = response.RevisionId;

            #endregion
        }

        public void LambdaGetProvisionedConcurrencyConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.GetProvisionedConcurrencyConfig(new GetProvisionedConcurrencyConfigRequest 
            {
                FunctionName = "my-function",
                Qualifier = "BLUE"
            });

            int allocatedProvisionedConcurrentExecutions = response.AllocatedProvisionedConcurrentExecutions;
            int availableProvisionedConcurrentExecutions = response.AvailableProvisionedConcurrentExecutions;
            string lastModified = response.LastModified;
            int requestedProvisionedConcurrentExecutions = response.RequestedProvisionedConcurrentExecutions;
            string status = response.Status;

            #endregion
        }

        public void LambdaGetProvisionedConcurrencyConfig()
        {
            #region example-2

            var client = new AmazonLambdaClient();
            var response = client.GetProvisionedConcurrencyConfig(new GetProvisionedConcurrencyConfigRequest 
            {
                FunctionName = "my-function",
                Qualifier = "BLUE"
            });

            int allocatedProvisionedConcurrentExecutions = response.AllocatedProvisionedConcurrentExecutions;
            int availableProvisionedConcurrentExecutions = response.AvailableProvisionedConcurrentExecutions;
            string lastModified = response.LastModified;
            int requestedProvisionedConcurrentExecutions = response.RequestedProvisionedConcurrentExecutions;
            string status = response.Status;

            #endregion
        }

        public void LambdaInvoke()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.Invoke(new InvokeRequest 
            {
                FunctionName = "my-function",
                Qualifier = "1"
            });

            MemoryStream payload = response.Payload;
            int statusCode = response.StatusCode;

            #endregion
        }

        public void LambdaInvoke()
        {
            #region example-2

            var client = new AmazonLambdaClient();
            var response = client.Invoke(new InvokeRequest 
            {
                FunctionName = "my-function",
                InvocationType = "Event",
                Qualifier = "1"
            });

            MemoryStream payload = response.Payload;
            int statusCode = response.StatusCode;

            #endregion
        }

        public void LambdaListAliases()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListAliases(new ListAliasesRequest 
            {
                FunctionName = "my-function"
            });

            List<AliasConfiguration> aliases = response.Aliases;

            #endregion
        }

        public void LambdaListEventSourceMappings()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListEventSourceMappings(new ListEventSourceMappingsRequest 
            {
                FunctionName = "my-function"
            });

            List<EventSourceMappingConfiguration> eventSourceMappings = response.EventSourceMappings;

            #endregion
        }

        public void LambdaListFunctionEventInvokeConfigs()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListFunctionEventInvokeConfigs(new ListFunctionEventInvokeConfigsRequest 
            {
                FunctionName = "my-function"
            });

            List<FunctionEventInvokeConfig> functionEventInvokeConfigs = response.FunctionEventInvokeConfigs;

            #endregion
        }

        public void LambdaListFunctions()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListFunctions(new ListFunctionsRequest 
            {
            });

            List<FunctionConfiguration> functions = response.Functions;
            string nextMarker = response.NextMarker;

            #endregion
        }

        public void LambdaListLayers()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListLayers(new ListLayersRequest 
            {
                CompatibleRuntime = "python3.7"
            });

            List<LayersListItem> layers = response.Layers;

            #endregion
        }

        public void LambdaListLayerVersions()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListLayerVersions(new ListLayerVersionsRequest 
            {
                LayerName = "blank-java-lib"
            });

            List<LayerVersionsListItem> layerVersions = response.LayerVersions;

            #endregion
        }

        public void LambdaListProvisionedConcurrencyConfigs()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListProvisionedConcurrencyConfigs(new ListProvisionedConcurrencyConfigsRequest 
            {
                FunctionName = "my-function"
            });

            List<ProvisionedConcurrencyConfigListItem> provisionedConcurrencyConfigs = response.ProvisionedConcurrencyConfigs;

            #endregion
        }

        public void LambdaListTags()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListTags(new ListTagsRequest 
            {
                Resource = "arn:aws:lambda:us-west-2:123456789012:function:my-function"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void LambdaListVersionsByFunction()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.ListVersionsByFunction(new ListVersionsByFunctionRequest 
            {
                FunctionName = "my-function"
            });

            List<FunctionConfiguration> versions = response.Versions;

            #endregion
        }

        public void LambdaPublishLayerVersion()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.PublishLayerVersion(new PublishLayerVersionRequest 
            {
                CompatibleRuntimes = new List<string> {
                    "python3.6",
                    "python3.7"
                },
                Content = new LayerVersionContentInput {
                    S3Bucket = "lambda-layers-us-west-2-123456789012",
                    S3Key = "layer.zip"
                },
                Description = "My Python layer",
                LayerName = "my-layer",
                LicenseInfo = "MIT"
            });

            List<string> compatibleRuntimes = response.CompatibleRuntimes;
            LayerVersionContentOutput content = response.Content;
            string createdDate = response.CreatedDate;
            string description = response.Description;
            string layerArn = response.LayerArn;
            string layerVersionArn = response.LayerVersionArn;
            string licenseInfo = response.LicenseInfo;
            long version = response.Version;

            #endregion
        }

        public void LambdaPublishVersion()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.PublishVersion(new PublishVersionRequest 
            {
                CodeSha256 = "",
                Description = "",
                FunctionName = "myFunction"
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            EnvironmentResponse environment = response.Environment;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string kmsKeyArn = response.KMSKeyArn;
            string lastModified = response.LastModified;
            string lastUpdateStatus = response.LastUpdateStatus;
            int memorySize = response.MemorySize;
            string revisionId = response.RevisionId;
            string role = response.Role;
            string runtime = response.Runtime;
            string state = response.State;
            int timeout = response.Timeout;
            TracingConfigResponse tracingConfig = response.TracingConfig;
            string version = response.Version;

            #endregion
        }

        public void LambdaPutFunctionConcurrency()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.PutFunctionConcurrency(new PutFunctionConcurrencyRequest 
            {
                FunctionName = "my-function",
                ReservedConcurrentExecutions = 100
            });

            int reservedConcurrentExecutions = response.ReservedConcurrentExecutions;

            #endregion
        }

        public void LambdaPutFunctionEventInvokeConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.PutFunctionEventInvokeConfig(new PutFunctionEventInvokeConfigRequest 
            {
                FunctionName = "my-function",
                MaximumEventAgeInSeconds = 3600,
                MaximumRetryAttempts = 0
            });

            DestinationConfig destinationConfig = response.DestinationConfig;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            int maximumEventAgeInSeconds = response.MaximumEventAgeInSeconds;
            int maximumRetryAttempts = response.MaximumRetryAttempts;

            #endregion
        }

        public void LambdaPutProvisionedConcurrencyConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.PutProvisionedConcurrencyConfig(new PutProvisionedConcurrencyConfigRequest 
            {
                FunctionName = "my-function",
                ProvisionedConcurrentExecutions = 100,
                Qualifier = "BLUE"
            });

            int allocatedProvisionedConcurrentExecutions = response.AllocatedProvisionedConcurrentExecutions;
            string lastModified = response.LastModified;
            int requestedProvisionedConcurrentExecutions = response.RequestedProvisionedConcurrentExecutions;
            string status = response.Status;

            #endregion
        }

        public void LambdaRemoveLayerVersionPermission()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.RemoveLayerVersionPermission(new RemoveLayerVersionPermissionRequest 
            {
                LayerName = "my-layer",
                StatementId = "xaccount",
                VersionNumber = 1
            });


            #endregion
        }

        public void LambdaRemovePermission()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.RemovePermission(new RemovePermissionRequest 
            {
                FunctionName = "my-function",
                Qualifier = "PROD",
                StatementId = "xaccount"
            });


            #endregion
        }

        public void LambdaTagResource()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                Resource = "arn:aws:lambda:us-west-2:123456789012:function:my-function",
                Tags = new Dictionary<string, string> {
                    { "DEPARTMENT", "Department A" }
                }
            });


            #endregion
        }

        public void LambdaUntagResource()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                Resource = "arn:aws:lambda:us-west-2:123456789012:function:my-function",
                TagKeys = new List<string> {
                    "DEPARTMENT"
                }
            });


            #endregion
        }

        public void LambdaUpdateAlias()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UpdateAlias(new UpdateAliasRequest 
            {
                FunctionName = "my-function",
                FunctionVersion = "2",
                Name = "BLUE",
                RoutingConfig = new AliasRoutingConfiguration { AdditionalVersionWeights = new Dictionary<string, double> {
                    { "1", 0.7 }
                } }
            });

            string aliasArn = response.AliasArn;
            string description = response.Description;
            string functionVersion = response.FunctionVersion;
            string name = response.Name;
            string revisionId = response.RevisionId;
            AliasRoutingConfiguration routingConfig = response.RoutingConfig;

            #endregion
        }

        public void LambdaUpdateEventSourceMapping()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UpdateEventSourceMapping(new UpdateEventSourceMappingRequest 
            {
                BatchSize = 123,
                Enabled = true,
                FunctionName = "myFunction",
                UUID = "1234xCy789012"
            });

            int batchSize = response.BatchSize;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string lastProcessingResult = response.LastProcessingResult;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaUpdateFunctionCode()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UpdateFunctionCode(new UpdateFunctionCodeRequest 
            {
                FunctionName = "my-function",
                S3Bucket = "my-bucket-1xpuxmplzrlbh",
                S3Key = "function.zip"
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            int memorySize = response.MemorySize;
            string revisionId = response.RevisionId;
            string role = response.Role;
            string runtime = response.Runtime;
            int timeout = response.Timeout;
            TracingConfigResponse tracingConfig = response.TracingConfig;
            string version = response.Version;

            #endregion
        }

        public void LambdaUpdateFunctionConfiguration()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UpdateFunctionConfiguration(new UpdateFunctionConfigurationRequest 
            {
                FunctionName = "my-function",
                MemorySize = 256
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            int memorySize = response.MemorySize;
            string revisionId = response.RevisionId;
            string role = response.Role;
            string runtime = response.Runtime;
            int timeout = response.Timeout;
            TracingConfigResponse tracingConfig = response.TracingConfig;
            string version = response.Version;

            #endregion
        }

        public void LambdaUpdateFunctionEventInvokeConfig()
        {
            #region example-1

            var client = new AmazonLambdaClient();
            var response = client.UpdateFunctionEventInvokeConfig(new UpdateFunctionEventInvokeConfigRequest 
            {
                DestinationConfig = new DestinationConfig { OnFailure = new OnFailure { Destination = "arn:aws:sqs:us-east-2:123456789012:destination" } },
                FunctionName = "my-function"
            });

            DestinationConfig destinationConfig = response.DestinationConfig;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            int maximumEventAgeInSeconds = response.MaximumEventAgeInSeconds;
            int maximumRetryAttempts = response.MaximumRetryAttempts;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}