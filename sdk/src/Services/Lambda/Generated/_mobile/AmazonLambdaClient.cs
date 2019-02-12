/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Lambda.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lambda
{
    /// <summary>
    /// Implementation for accessing Lambda
    ///
    /// AWS Lambda 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the <i>AWS Lambda API Reference</i>. The AWS Lambda Developer Guide provides
    /// additional information. For the service overview, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the <b>AWS Lambda Developer Guide</b>.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonLambdaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLambdaConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLambdaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(AmazonLambdaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials and an
        /// AmazonLambdaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(AWSCredentials credentials, AmazonLambdaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddLayerVersionPermission

        internal virtual AddLayerVersionPermissionResponse AddLayerVersionPermission(AddLayerVersionPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLayerVersionPermissionResponseUnmarshaller.Instance;

            return Invoke<AddLayerVersionPermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual Task<AddLayerVersionPermissionResponse> AddLayerVersionPermissionAsync(AddLayerVersionPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLayerVersionPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddLayerVersionPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddPermission

        internal virtual AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSourceMapping

        internal virtual CreateEventSourceMappingResponse CreateEventSourceMapping(CreateEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<CreateEventSourceMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual Task<CreateEventSourceMappingResponse> CreateEventSourceMappingAsync(CreateEventSourceMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSourceMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFunction

        internal virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSourceMapping

        internal virtual DeleteEventSourceMappingResponse DeleteEventSourceMapping(DeleteEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSourceMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual Task<DeleteEventSourceMappingResponse> DeleteEventSourceMappingAsync(DeleteEventSourceMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSourceMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunction

        internal virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For AWS services and resources that invoke your function directly, delete the trigger
        /// in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function or version. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>my-function</code> (name-only), <code>my-function:1</code> (with version). </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual Task<DeleteFunctionResponse> DeleteFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            return DeleteFunctionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunctionConcurrency

        internal virtual DeleteFunctionConcurrencyResponse DeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionConcurrencyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual Task<DeleteFunctionConcurrencyResponse> DeleteFunctionConcurrencyAsync(DeleteFunctionConcurrencyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionConcurrencyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLayerVersion

        internal virtual DeleteLayerVersionResponse DeleteLayerVersion(DeleteLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteLayerVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual Task<DeleteLayerVersionResponse> DeleteLayerVersionAsync(DeleteLayerVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLayerVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAlias

        internal virtual GetAliasResponse GetAlias(GetAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return Invoke<GetAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual Task<GetAliasResponse> GetAliasAsync(GetAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventSourceMapping

        internal virtual GetEventSourceMappingResponse GetEventSourceMapping(GetEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<GetEventSourceMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual Task<GetEventSourceMappingResponse> GetEventSourceMappingAsync(GetEventSourceMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventSourceMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFunction

        internal virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual Task<GetFunctionResponse> GetFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetFunctionRequest();
            request.FunctionName = functionName;
            return GetFunctionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionConfiguration

        internal virtual GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetFunctionConfigurationRequest();
            request.FunctionName = functionName;
            return GetFunctionConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLayerVersion

        internal virtual GetLayerVersionResponse GetLayerVersion(GetLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionResponseUnmarshaller.Instance;

            return Invoke<GetLayerVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual Task<GetLayerVersionResponse> GetLayerVersionAsync(GetLayerVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLayerVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLayerVersionPolicy

        internal virtual GetLayerVersionPolicyResponse GetLayerVersionPolicy(GetLayerVersionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetLayerVersionPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLayerVersionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual Task<GetLayerVersionPolicyResponse> GetLayerVersionPolicyAsync(GetLayerVersionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLayerVersionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Invoke

        internal virtual InvokeResponse Invoke(InvokeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeResponseUnmarshaller.Instance;

            return Invoke<InvokeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Invoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Invoke operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual Task<InvokeResponse> InvokeAsync(InvokeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeAsync

        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core and PCL, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        internal virtual InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeAsyncResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core and PCL, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeAsyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventSourceMappings

        internal virtual ListEventSourceMappingsResponse ListEventSourceMappings(ListEventSourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return Invoke<ListEventSourceMappingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual Task<ListEventSourceMappingsResponse> ListEventSourceMappingsAsync(ListEventSourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSourceMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFunctions

        internal virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version. To get more information about
        /// a function or version, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual Task<ListFunctionsResponse> ListFunctionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListFunctionsRequest();
            return ListFunctionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLayers

        internal virtual ListLayersResponse ListLayers(ListLayersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayersResponseUnmarshaller.Instance;

            return Invoke<ListLayersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLayers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLayers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayersResponseUnmarshaller.Instance;

            return InvokeAsync<ListLayersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLayerVersions

        internal virtual ListLayerVersionsResponse ListLayerVersions(ListLayerVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayerVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayerVersionsResponseUnmarshaller.Instance;

            return Invoke<ListLayerVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLayerVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual Task<ListLayerVersionsResponse> ListLayerVersionsAsync(ListLayerVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayerVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayerVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLayerVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVersionsByFunction

        internal virtual ListVersionsByFunctionResponse ListVersionsByFunction(ListVersionsByFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListVersionsByFunctionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual Task<ListVersionsByFunctionResponse> ListVersionsByFunctionAsync(ListVersionsByFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsByFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishLayerVersion

        internal virtual PublishLayerVersionResponse PublishLayerVersion(PublishLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishLayerVersionResponseUnmarshaller.Instance;

            return Invoke<PublishLayerVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PublishLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual Task<PublishLayerVersionResponse> PublishLayerVersionAsync(PublishLayerVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishLayerVersionResponseUnmarshaller.Instance;

            return InvokeAsync<PublishLayerVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishVersion

        internal virtual PublishVersionResponse PublishVersion(PublishVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return Invoke<PublishVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual Task<PublishVersionResponse> PublishVersionAsync(PublishVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return InvokeAsync<PublishVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFunctionConcurrency

        internal virtual PutFunctionConcurrencyResponse PutFunctionConcurrency(PutFunctionConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;

            return Invoke<PutFunctionConcurrencyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual Task<PutFunctionConcurrencyResponse> PutFunctionConcurrencyAsync(PutFunctionConcurrencyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;

            return InvokeAsync<PutFunctionConcurrencyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveLayerVersionPermission

        internal virtual RemoveLayerVersionPermissionResponse RemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLayerVersionPermissionResponseUnmarshaller.Instance;

            return Invoke<RemoveLayerVersionPermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual Task<RemoveLayerVersionPermissionResponse> RemoveLayerVersionPermissionAsync(RemoveLayerVersionPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLayerVersionPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveLayerVersionPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        internal virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventSourceMapping

        internal virtual UpdateEventSourceMappingResponse UpdateEventSourceMapping(UpdateEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateEventSourceMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual Task<UpdateEventSourceMappingResponse> UpdateEventSourceMappingAsync(UpdateEventSourceMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventSourceMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunctionCode

        internal virtual UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionCodeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual Task<UpdateFunctionCodeResponse> UpdateFunctionCodeAsync(UpdateFunctionCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunctionConfiguration

        internal virtual UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}