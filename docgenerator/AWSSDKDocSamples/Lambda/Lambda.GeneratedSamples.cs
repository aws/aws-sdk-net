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
        static IAmazonLambda client = new AmazonLambdaClient();
        public void LambdaAddPermission()
        {
            #region add-permission-1474651469455

            var response = client.AddPermission(new AddPermissionRequest 
            {
                Action = "lambda:InvokeFunction",
                FunctionName = "MyFunction",
                Principal = "s3.amazonaws.com",
                SourceAccount = "123456789012",
                SourceArn = "arn:aws:s3:::examplebucket/*",
                StatementId = "ID-1"
            });

            string statement = response.Statement;

            #endregion
        }

        public void LambdaCreateFunction()
        {
            #region create-function-1474653449931

            var response = client.CreateFunction(new CreateFunctionRequest 
            {
                Code = new FunctionCode {  },
                Description = "",
                FunctionName = "MyFunction",
                Handler = "souce_file.handler_name", // is of the form of the name of your source file and then name of your function handler
                MemorySize = 128,
                Publish = true,
                Role = "arn:aws:iam::123456789012:role/service-role/role-name", // replace with the actual arn of the execution role you created
                Runtime = "nodejs4.3",
                Timeout = 15,
                VpcConfig = new VpcConfig {  }
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            integer memorySize = response.MemorySize;
            string role = response.Role;
            string runtime = response.Runtime;
            integer timeout = response.Timeout;
            string version = response.Version;
            VpcConfigDetail vpcConfig = response.VpcConfig;

            #endregion
        }

        public void LambdaDeleteAlias()
        {
            #region to-delete-a-lambda-function-alias-1481660370804

            var response = client.DeleteAlias(new DeleteAliasRequest 
            {
                FunctionName = "myFunction",
                Name = "alias"
            });


            #endregion
        }

        public void LambdaDeleteEventSourceMapping()
        {
            #region to-delete-a-lambda-function-event-source-mapping-1481658973862

            var response = client.DeleteEventSourceMapping(new DeleteEventSourceMappingRequest 
            {
                UUID = "12345kxodurf3443"
            });

            integer batchSize = response.BatchSize;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string lastProcessingResult = response.LastProcessingResult;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaDeleteFunction()
        {
            #region to-delete-a-lambda-function-1481648553696

            var response = client.DeleteFunction(new DeleteFunctionRequest 
            {
                FunctionName = "myFunction",
                Qualifier = "1"
            });


            #endregion
        }

        public void LambdaGetAccountSettings()
        {
            #region to-retrieves-a-lambda-customers-account-settings-1481657495274

            var response = client.GetAccountSettings(new GetAccountSettingsRequest 
            {
            });

            AccountLimit accountLimit = response.AccountLimit;
            AccountUsage accountUsage = response.AccountUsage;

            #endregion
        }

        public void LambdaGetAlias()
        {
            #region to-retrieve-a-lambda-function-alias-1481648742254

            var response = client.GetAlias(new GetAliasRequest 
            {
                FunctionName = "myFunction",
                Name = "myFunctionAlias"
            });

            string aliasArn = response.AliasArn;
            string description = response.Description;
            string functionVersion = response.FunctionVersion;
            string name = response.Name;

            #endregion
        }

        public void LambdaGetEventSourceMapping()
        {
            #region to-retrieve-a-lambda-functions-event-source-mapping-1481661622799

            var response = client.GetEventSourceMapping(new GetEventSourceMappingRequest 
            {
                UUID = "123489-xxxxx-kdla8d89d7"
            });

            integer batchSize = response.BatchSize;
            string eventSourceArn = response.EventSourceArn;
            string functionArn = response.FunctionArn;
            DateTime lastModified = response.LastModified;
            string lastProcessingResult = response.LastProcessingResult;
            string state = response.State;
            string stateTransitionReason = response.StateTransitionReason;
            string uuid = response.UUID;

            #endregion
        }

        public void LambdaGetFunction()
        {
            #region to-retrieve-a-lambda-functions-event-source-mapping-1481661622799

            var response = client.GetFunction(new GetFunctionRequest 
            {
                FunctionName = "myFunction",
                Qualifier = "1"
            });

            FunctionCodeLocation code = response.Code;
            FunctionConfiguration configuration = response.Configuration;

            #endregion
        }

        public void LambdaGetFunctionConfiguration()
        {
            #region to-retrieve-a-lambda-functions-event-source-mapping-1481661622799

            var response = client.GetFunctionConfiguration(new GetFunctionConfigurationRequest 
            {
                FunctionName = "myFunction",
                Qualifier = "1"
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            DeadLetterConfig deadLetterConfig = response.DeadLetterConfig;
            string description = response.Description;
            EnvironmentResponse environment = response.Environment;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string kmsKeyArn = response.KMSKeyArn;
            string lastModified = response.LastModified;
            integer memorySize = response.MemorySize;
            string role = response.Role;
            string runtime = response.Runtime;
            integer timeout = response.Timeout;
            string version = response.Version;
            VpcConfigDetail vpcConfig = response.VpcConfig;

            #endregion
        }

        public void LambdaGetPolicy()
        {
            #region to-retrieve-a-lambda-function-policy-1481649319053

            var response = client.GetPolicy(new GetPolicyRequest 
            {
                FunctionName = "myFunction",
                Qualifier = "1"
            });

            string policy = response.Policy;

            #endregion
        }

        public void LambdaInvoke()
        {
            #region to-invoke-a-lambda-function-1481659683915

            var response = client.Invoke(new InvokeRequest 
            {
                FunctionName = "MyFunction",
                InvocationType = "Event",
                LogType = "Tail",
                Qualifier = "1"
            });

            string functionError = response.FunctionError;
            string logResult = response.LogResult;
            blob payload = response.Payload;
            integer statusCode = response.StatusCode;

            #endregion
        }

        public void LambdaInvokeAsync()
        {
            #region to-invoke-a-lambda-function-asynchronously-1481649694923

            var response = client.InvokeAsync(new InvokeAsyncRequest 
            {
                FunctionName = "myFunction",
            });

            integer status = response.Status;

            #endregion
        }

        public void LambdaListAliases()
        {
            #region to-retrieve-a-lambda-function-aliases-1481650199732

            var response = client.ListAliases(new ListAliasesRequest 
            {
                FunctionName = "myFunction",
                FunctionVersion = "1",
                Marker = "",
                MaxItems = 123
            });

            List<AliasConfiguration> aliases = response.Aliases;
            string nextMarker = response.NextMarker;

            #endregion
        }

        public void LambdaListFunctions()
        {
            #region to-retrieve-a-list-of-lambda-functions-1481650507425

            var response = client.ListFunctions(new ListFunctionsRequest 
            {
                Marker = "",
                MaxItems = 123
            });

            List<FunctionConfiguration> functions = response.Functions;
            string nextMarker = response.NextMarker;

            #endregion
        }

        public void LambdaListVersionsByFunction()
        {
            #region to-retrieve-a-list-of-lambda-function-versions-1481650603750

            var response = client.ListVersionsByFunction(new ListVersionsByFunctionRequest 
            {
                FunctionName = "myFunction",
                Marker = "",
                MaxItems = 123
            });

            string nextMarker = response.NextMarker;
            List<FunctionConfiguration> versions = response.Versions;

            #endregion
        }

        public void LambdaPublishVersion()
        {
            #region to-publish-a-version-of-a-lambda-function-1481650704986

            var response = client.PublishVersion(new PublishVersionRequest 
            {
                CodeSha256 = "",
                Description = "",
                FunctionName = "myFunction"
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            integer memorySize = response.MemorySize;
            string role = response.Role;
            string runtime = response.Runtime;
            integer timeout = response.Timeout;
            string version = response.Version;
            VpcConfigDetail vpcConfig = response.VpcConfig;

            #endregion
        }

        public void LambdaRemovePermission()
        {
            #region to-remove-a-lambda-functions-permissions-1481661337021

            var response = client.RemovePermission(new RemovePermissionRequest 
            {
                FunctionName = "myFunction",
                Qualifier = "1",
                StatementId = "role-statement-id"
            });


            #endregion
        }

        public void LambdaUpdateAlias()
        {
            #region to-update-a-lambda-function-alias-1481650817950

            var response = client.UpdateAlias(new UpdateAliasRequest 
            {
                Description = "",
                FunctionName = "myFunction",
                FunctionVersion = "1",
                Name = "functionAlias"
            });

            string aliasArn = response.AliasArn;
            string description = response.Description;
            string functionVersion = response.FunctionVersion;
            string name = response.Name;

            #endregion
        }

        public void LambdaUpdateEventSourceMapping()
        {
            #region to-update-a-lambda-function-event-source-mapping-1481650907413

            var response = client.UpdateEventSourceMapping(new UpdateEventSourceMappingRequest 
            {
                BatchSize = 123,
                Enabled = true,
                FunctionName = "myFunction",
                UUID = "1234xCy789012"
            });

            integer batchSize = response.BatchSize;
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
            #region to-update-a-lambda-functions-code-1481650992672

            var response = client.UpdateFunctionCode(new UpdateFunctionCodeRequest 
            {
                FunctionName = "myFunction",
                Publish = true,
                S3Bucket = "myBucket",
                S3Key = "myKey",
                S3ObjectVersion = "1",
                ZipFile = 
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            integer memorySize = response.MemorySize;
            string role = response.Role;
            string runtime = response.Runtime;
            integer timeout = response.Timeout;
            string version = response.Version;
            VpcConfigDetail vpcConfig = response.VpcConfig;

            #endregion
        }

        public void LambdaUpdateFunctionConfiguration()
        {
            #region to-update-a-lambda-functions-configuration-1481651096447

            var response = client.UpdateFunctionConfiguration(new UpdateFunctionConfigurationRequest 
            {
                Description = "",
                FunctionName = "myFunction",
                Handler = "index.handler",
                MemorySize = 128,
                Role = "arn:aws:iam::123456789012:role/lambda_basic_execution",
                Runtime = "python2.7",
                Timeout = 123,
                VpcConfig = new VpcConfig {  }
            });

            string codeSha256 = response.CodeSha256;
            long codeSize = response.CodeSize;
            string description = response.Description;
            string functionArn = response.FunctionArn;
            string functionName = response.FunctionName;
            string handler = response.Handler;
            string lastModified = response.LastModified;
            integer memorySize = response.MemorySize;
            string role = response.Role;
            string runtime = response.Runtime;
            integer timeout = response.Timeout;
            string version = response.Version;
            VpcConfigDetail vpcConfig = response.VpcConfig;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}