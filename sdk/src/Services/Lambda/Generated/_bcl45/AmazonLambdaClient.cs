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
    /// additional information. For the service overview, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the <b>AWS Lambda Developer Guide</b>.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaMetadata();
        #region Constructors

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


        /// <summary>
        /// Adds permissions to the resource-based policy of a version of a function layer. Use
        /// this action to grant layer usage permission to other accounts. You can grant permission
        /// to a single account, all AWS accounts, or all accounts in an organization.
        /// 
        ///  
        /// <para>
        /// To revoke permission, call <a>RemoveLayerVersionPermission</a> with the statement
        /// ID that you specified when you added it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the AddLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// Lambda function access policy is limited to 20 KB.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual AddLayerVersionPermissionResponse AddLayerVersionPermission(AddLayerVersionPermissionRequest request)
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


        /// <summary>
        /// Adds a permission to the resource policy associated with the specified AWS Lambda
        /// function. You use resource policies to grant permissions to event sources that use
        /// the <i>push</i> model. In a <i>push</i> model, event sources (such as Amazon S3 and
        /// custom applications) invoke your Lambda function. Each permission you add to the resource
        /// policy allows an event source permission to invoke the Lambda function. 
        /// 
        ///  
        /// <para>
        /// Permissions apply to the Amazon Resource Name (ARN) used to invoke the function, which
        /// can be unqualified (the unpublished version of the function), or include a version
        /// or alias. If a client uses a version or alias to invoke a function, use the <code>Qualifier</code>
        /// parameter to apply permissions to that ARN. For more information about versioning,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:AddPermission</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// Lambda function access policy is limited to 20 KB.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual AddPermissionResponse AddPermission(AddPermissionRequest request)
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


        /// <summary>
        /// Creates an alias that points to the specified Lambda function version. For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Introduction
        /// to AWS Lambda Aliases</a>.
        /// 
        ///  
        /// <para>
        /// Alias names are unique for a given function. This requires permission for the lambda:CreateAlias
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
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


        /// <summary>
        /// Creates a mapping between an event source and an AWS Lambda function. Lambda reads
        /// items from the event source and triggers the function.
        /// 
        ///  
        /// <para>
        /// For details about each event source type, see the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html">Using AWS
        /// Lambda with Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html">Using AWS Lambda
        /// with Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html">Using AWS Lambda
        /// with Amazon DynamoDB</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the CreateEventSourceMapping service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual CreateEventSourceMappingResponse CreateEventSourceMapping(CreateEventSourceMappingRequest request)
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


        /// <summary>
        /// Creates a new Lambda function. The function configuration is created from the request
        /// parameters, and the code for the function is provided by a .zip file. The function
        /// name is case-sensitive.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:CreateFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// You have exceeded your maximum total code size per account. <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">Limits</a>
        /// </exception>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
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


        /// <summary>
        /// Deletes the specified Lambda function alias. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Introduction
        /// to AWS Lambda Aliases</a>.
        /// 
        ///  
        /// <para>
        /// This requires permission for the lambda:DeleteAlias action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
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


        /// <summary>
        /// Deletes an event source mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you attempted
        /// to update an EventSoure Mapping in CREATING, or tried to delete a EventSoure mapping
        /// currently in the UPDATING state.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual DeleteEventSourceMappingResponse DeleteEventSourceMapping(DeleteEventSourceMappingRequest request)
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


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted. Event source mappings
        /// are not deleted.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse DeleteFunction(string functionName)
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            return DeleteFunction(request);
        }


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted. Event source mappings
        /// are not deleted.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted. Event source mappings
        /// are not deleted.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
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


        /// <summary>
        /// Removes concurrent execution limits from this function. For more information, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html">Managing
        /// Concurrency</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionConcurrency service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual DeleteFunctionConcurrencyResponse DeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request)
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


        /// <summary>
        /// Deletes a version of a function layer. Deleted versions can no longer be viewed or
        /// added to functions. However, a copy of the version remains in Lambda until no functions
        /// refer to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual DeleteLayerVersionResponse DeleteLayerVersion(DeleteLayerVersionRequest request)
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


        /// <summary>
        /// Retrieves details about your account's <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">limits</a>
        /// and usage in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
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


        /// <summary>
        /// Returns the specified alias information such as the alias ARN, description, and function
        /// version it is pointing to. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Introduction
        /// to AWS Lambda Aliases</a>.
        /// 
        ///  
        /// <para>
        /// This requires permission for the <code>lambda:GetAlias</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
        /// 
        /// <returns>The response from the GetAlias service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual GetAliasResponse GetAlias(GetAliasRequest request)
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


        /// <summary>
        /// Returns details about an event source mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the GetEventSourceMapping service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual GetEventSourceMappingResponse GetEventSourceMapping(GetEventSourceMappingRequest request)
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


        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>CreateFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// Use the <code>Qualifier</code> parameter to retrieve a published version of the function.
        /// Otherwise, returns the unpublished version (<code>$LATEST</code>). For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse GetFunction(string functionName)
        {
            var request = new GetFunctionRequest();
            request.FunctionName = functionName;
            return GetFunction(request);
        }


        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>CreateFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// Use the <code>Qualifier</code> parameter to retrieve a published version of the function.
        /// Otherwise, returns the unpublished version (<code>$LATEST</code>). For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }


        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>CreateFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// Use the <code>Qualifier</code> parameter to retrieve a published version of the function.
        /// Otherwise, returns the unpublished version (<code>$LATEST</code>). For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
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


        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>CreateFunction</a>.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can retrieve this information for a specific
        /// function version by using the optional <code>Qualifier</code> parameter and specifying
        /// the function version or alias that points to it. If you don't provide it, the API
        /// returns information about the $LATEST version of the function. For more information
        /// about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName)
        {
            var request = new GetFunctionConfigurationRequest();
            request.FunctionName = functionName;
            return GetFunctionConfiguration(request);
        }


        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>CreateFunction</a>.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can retrieve this information for a specific
        /// function version by using the optional <code>Qualifier</code> parameter and specifying
        /// the function version or alias that points to it. If you don't provide it, the API
        /// returns information about the $LATEST version of the function. For more information
        /// about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration service method.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>CreateFunction</a>.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can retrieve this information for a specific
        /// function version by using the optional <code>Qualifier</code> parameter and specifying
        /// the function version or alias that points to it. If you don't provide it, the API
        /// returns information about the $LATEST version of the function. For more information
        /// about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>MyFunction</code>. </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>. </li> </ul> The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        /// Request throughput limit exceeded
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


        /// <summary>
        /// Returns information about a version of a function layer, with a link to download the
        /// layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersion service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual GetLayerVersionResponse GetLayerVersion(GetLayerVersionRequest request)
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


        /// <summary>
        /// Returns the permission policy for a layer version. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersionPolicy service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual GetLayerVersionPolicyResponse GetLayerVersionPolicy(GetLayerVersionPolicyRequest request)
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


        /// <summary>
        /// Returns the resource policy associated with the specified Lambda function.
        /// 
        ///  
        /// <para>
        /// This action requires permission for the <code>lambda:GetPolicy action.</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
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


        /// <summary>
        /// Invokes a Lambda function. For an example, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-dynamodb-create-function.html#with-dbb-invoke-manually">Create
        /// the Lambda Function and Test It Manually</a>. 
        /// 
        ///  
        /// <para>
        /// Specify just a function name to invoke the latest version of the function. To invoke
        /// a published version, use the <code>Qualifier</code> parameter to specify a <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version
        /// or alias</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>RequestResponse</code> (synchronous) invocation option, the function
        /// will be invoked only once. If you use the <code>Event</code> (asynchronous) invocation
        /// option, the function will be invoked at least once in response to an event and the
        /// function must be idempotent to handle this.
        /// </para>
        ///  
        /// <para>
        /// For functions with a long timeout, your client may be disconnected during synchronous
        /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
        /// proxy, or operating system to allow for long connections with timeout or keep-alive
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeFunction</code> action.
        /// </para>
        ///  
        /// <para>
        /// The <code>TooManyRequestsException</code> noted below will return the following: <code>ConcurrentInvocationLimitExceeded</code>
        /// will be returned if you have no functions with reserved concurrency and have exceeded
        /// your account concurrent limit or if a function without reserved concurrency exceeds
        /// the account's unreserved concurrency limit. <code>ReservedFunctionConcurrentInvocationLimitExceeded</code>
        /// will be returned when a function with reserved concurrency exceeds its configured
        /// concurrency limit. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Invoke service method.</param>
        /// 
        /// <returns>The response from the Invoke service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.EC2AccessDeniedException">
        /// Need additional permissions to configure VPC settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2ThrottledException">
        /// AWS Lambda was throttled by Amazon EC2 during Lambda function initialization using
        /// the execution role provided for the Lambda function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2UnexpectedException">
        /// AWS Lambda received an unexpected EC2 client exception while setting up for the Lambda
        /// function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ENILimitReachedException">
        /// AWS Lambda was not able to create an Elastic Network Interface (ENI) in the VPC, specified
        /// as part of Lambda function configuration, because the limit for network interfaces
        /// has been reached.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSecurityGroupIDException">
        /// The Security Group ID provided in the Lambda function VPC configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSubnetIDException">
        /// The Subnet ID provided in the Lambda function VPC configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidZipFileException">
        /// AWS Lambda could not unzip the deployment package.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSAccessDeniedException">
        /// Lambda was unable to decrypt the environment variables because KMS access was denied.
        /// Check the Lambda function's KMS permissions.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSDisabledException">
        /// Lambda was unable to decrypt the environment variables because the KMS key used is
        /// disabled. Check the Lambda function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSInvalidStateException">
        /// Lambda was unable to decrypt the environment variables because the KMS key used is
        /// in an invalid state for Decrypt. Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSNotFoundException">
        /// Lambda was unable to decrypt the environment variables because the KMS key was not
        /// found. Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.RequestTooLargeException">
        /// The request payload exceeded the <code>Invoke</code> request body JSON input limit.
        /// For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SubnetIPAddressLimitReachedException">
        /// AWS Lambda was not able to set up VPC access for the Lambda function because one or
        /// more configured subnets has no available IP addresses.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.UnsupportedMediaTypeException">
        /// The content type of the <code>Invoke</code> request body is not JSON.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual InvokeResponse Invoke(InvokeRequest request)
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


        /// <summary>
        /// <important> 
        /// <para>
        /// For asynchronous function invocation, use <a>Invoke</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Submits an invocation request to AWS Lambda. Upon receiving the request, Lambda executes
        /// the specified function asynchronously. To see the logs generated by the Lambda function
        /// execution, see the CloudWatch Logs console.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core and PCL, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request)
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


        /// <summary>
        /// Returns list of aliases created for a Lambda function. For each alias, the response
        /// includes information such as the alias ARN, description, alias name, and the function
        /// version to which it points. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Introduction
        /// to AWS Lambda Aliases</a>.
        /// 
        ///  
        /// <para>
        /// This requires permission for the lambda:ListAliases action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
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


        /// <summary>
        /// Lists event source mappings. Specify an <code>EventSourceArn</code> to only show event
        /// source mappings for a single event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings service method.</param>
        /// 
        /// <returns>The response from the ListEventSourceMappings service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual ListEventSourceMappingsResponse ListEventSourceMappings(ListEventSourceMappingsRequest request)
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


        /// <summary>
        /// Returns a list of your Lambda functions. For each function, the response includes
        /// the function configuration information. You must use <a>GetFunction</a> to retrieve
        /// the code for your function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
        /// </para>
        ///  
        /// <para>
        /// If you are using the versioning feature, you can list all of your functions or only
        /// <code>$LATEST</code> versions. For information about the versioning feature, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
        /// Function Versioning and Aliases</a>. 
        /// </para>
        /// </summary>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse ListFunctions()
        {
            var request = new ListFunctionsRequest();
            return ListFunctions(request);
        }


        /// <summary>
        /// Returns a list of your Lambda functions. For each function, the response includes
        /// the function configuration information. You must use <a>GetFunction</a> to retrieve
        /// the code for your function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
        /// </para>
        ///  
        /// <para>
        /// If you are using the versioning feature, you can list all of your functions or only
        /// <code>$LATEST</code> versions. For information about the versioning feature, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
        /// Function Versioning and Aliases</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of your Lambda functions. For each function, the response includes
        /// the function configuration information. You must use <a>GetFunction</a> to retrieve
        /// the code for your function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
        /// </para>
        ///  
        /// <para>
        /// If you are using the versioning feature, you can list all of your functions or only
        /// <code>$LATEST</code> versions. For information about the versioning feature, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
        /// Function Versioning and Aliases</a>. 
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
        /// Request throughput limit exceeded
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


        /// <summary>
        /// Lists function layers and shows information about the latest version of each. Specify
        /// a <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only layers that indicate that they're compatible with that
        /// runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayers service method.</param>
        /// 
        /// <returns>The response from the ListLayers service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual ListLayersResponse ListLayers(ListLayersRequest request)
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


        /// <summary>
        /// Lists the versions of a function layer. Versions that have been deleted aren't listed.
        /// Specify a <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only versions that indicate that they're compatible with that
        /// runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions service method.</param>
        /// 
        /// <returns>The response from the ListLayerVersions service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual ListLayerVersionsResponse ListLayerVersions(ListLayerVersionsRequest request)
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


        /// <summary>
        /// Returns a list of tags assigned to a function when supplied the function ARN (Amazon
        /// Resource Name). For more information on Tagging, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging
        /// Lambda Functions</a> in the <b>AWS Lambda Developer Guide</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
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


        /// <summary>
        /// Lists all versions of a function. For information about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction service method.</param>
        /// 
        /// <returns>The response from the ListVersionsByFunction service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual ListVersionsByFunctionResponse ListVersionsByFunction(ListVersionsByFunctionRequest request)
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


        /// <summary>
        /// Creates a function layer from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
        /// with the same version name, a new version is created.
        /// 
        ///  
        /// <para>
        /// Add layers to your function with <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion service method.</param>
        /// 
        /// <returns>The response from the PublishLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// You have exceeded your maximum total code size per account. <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">Limits</a>
        /// </exception>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual PublishLayerVersionResponse PublishLayerVersion(PublishLayerVersionRequest request)
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


        /// <summary>
        /// Publishes a version of your function from the current snapshot of $LATEST. That is,
        /// AWS Lambda takes a snapshot of the function code and configuration information from
        /// $LATEST and publishes a new version. The code and configuration cannot be modified
        /// after publication. For information about the versioning feature, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion service method.</param>
        /// 
        /// <returns>The response from the PublishVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// You have exceeded your maximum total code size per account. <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">Limits</a>
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual PublishVersionResponse PublishVersion(PublishVersionRequest request)
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


        /// <summary>
        /// Sets a limit on the number of concurrent executions available to this function. It
        /// is a subset of your account's total concurrent execution limit per region. Note that
        /// Lambda automatically reserves a buffer of 100 concurrent executions for functions
        /// without any reserved concurrency limit. This means if your account limit is 1000,
        /// you have a total of 900 available to allocate to individual functions. For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html">Managing
        /// Concurrency</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the PutFunctionConcurrency service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual PutFunctionConcurrencyResponse PutFunctionConcurrency(PutFunctionConcurrencyRequest request)
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


        /// <summary>
        /// Removes a statement from the permissions policy for a layer version. For more information,
        /// see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the RemoveLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual RemoveLayerVersionPermissionResponse RemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request)
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


        /// <summary>
        /// Removes permissions from a function. You can remove individual permissions from an
        /// resource policy associated with a Lambda function by providing a statement ID that
        /// you provided when you added the permission. When you remove permissions, disable the
        /// event source mapping or trigger configuration first to avoid errors.
        /// 
        ///  
        /// <para>
        /// Permissions apply to the Amazon Resource Name (ARN) used to invoke the function, which
        /// can be unqualified (the unpublished version of the function), or include a version
        /// or alias. If a client uses a version or alias to invoke a function, use the <code>Qualifier</code>
        /// parameter to apply permissions to that ARN. For more information about versioning,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// You need permission for the <code>lambda:RemovePermission</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
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


        /// <summary>
        /// Creates a list of tags (key-value pairs) on the Lambda function. Requires the Lambda
        /// function ARN (Amazon Resource Name). If a key is specified without a value, Lambda
        /// creates a tag with the specified key and a value of null. For more information, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging Lambda
        /// Functions</a> in the <b>AWS Lambda Developer Guide</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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


        /// <summary>
        /// Removes tags from a Lambda function. Requires the function ARN (Amazon Resource Name).
        /// For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging
        /// Lambda Functions</a> in the <b>AWS Lambda Developer Guide</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lambda.</returns>
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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


        /// <summary>
        /// Using this API you can update the function version to which the alias points and the
        /// alias description. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Introduction
        /// to AWS Lambda Aliases</a>.
        /// 
        ///  
        /// <para>
        /// This requires permission for the lambda:UpdateAlias action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
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


        /// <summary>
        /// Updates an event source mapping. You can change the function that AWS Lambda invokes,
        /// or pause invocation and resume later from the same location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you attempted
        /// to update an EventSoure Mapping in CREATING, or tried to delete a EventSoure mapping
        /// currently in the UPDATING state.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual UpdateEventSourceMappingResponse UpdateEventSourceMapping(UpdateEventSourceMappingRequest request)
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


        /// <summary>
        /// Updates the code for the specified Lambda function. This operation must only be used
        /// on an existing Lambda function and cannot be used to update the function configuration.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, note this API will always update the $LATEST
        /// version of your Lambda function. For information about the versioning feature, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:UpdateFunctionCode</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionCode service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// You have exceeded your maximum total code size per account. <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">Limits</a>
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest request)
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


        /// <summary>
        /// Updates the configuration parameters for the specified Lambda function by using the
        /// values provided in the request. You provide only the parameters you want to change.
        /// This operation must only be used on an existing Lambda function and cannot be used
        /// to update the function's code.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, note this API will always update the $LATEST
        /// version of your Lambda function. For information about the versioning feature, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:UpdateFunctionConfiguration</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API to retrieve
        /// the latest RevisionId for your resource.
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
        /// Request throughput limit exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request)
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