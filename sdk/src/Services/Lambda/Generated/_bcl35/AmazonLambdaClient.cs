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
        /// Adds permissions to the resource-based policy of a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>. Use this action to grant layer usage permission to other accounts.
        /// You can grant permission to a single account, all AWS accounts, or all accounts in
        /// an organization.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddLayerVersionPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual IAsyncResult BeginAddLayerVersionPermission(AddLayerVersionPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLayerVersionPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddLayerVersionPermission.</param>
        /// 
        /// <returns>Returns a  AddLayerVersionPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual AddLayerVersionPermissionResponse EndAddLayerVersionPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddLayerVersionPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddPermission

        /// <summary>
        /// Grants an AWS service or another account permission to use a function. You can apply
        /// the policy at the function level, or specify a qualifier to restrict access to a single
        /// version or alias. If you use a qualifier, the invoker must use the full Amazon Resource
        /// Name (ARN) of that version or alias to invoke the function.
        /// 
        ///  
        /// <para>
        /// To grant permission to another account, specify the account ID as the <code>Principal</code>.
        /// For AWS services, the principal is a domain-style identifier defined by the service,
        /// like <code>s3.amazonaws.com</code> or <code>sns.amazonaws.com</code>. For AWS services,
        /// you can also specify the ARN or owning account of the associated resource as the <code>SourceArn</code>
        /// or <code>SourceAccount</code>. If you grant permission to a service principal without
        /// specifying the source, other accounts could potentially configure resources in their
        /// account to invoke your Lambda function.
        /// </para>
        ///  
        /// <para>
        /// This action adds a statement to a resource-based permission policy for the function.
        /// For more information about function policies, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Lambda
        /// Function Policies</a>. 
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates an <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>
        /// for a Lambda function version. Use aliases to provide clients with a function identifier
        /// that you can update to invoke a different version.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split invocation requests between two versions. Use the
        /// <code>RoutingConfig</code> parameter to specify a second version and the percentage
        /// of invocation requests that it receives.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSourceMapping(CreateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  CreateEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual CreateEventSourceMappingResponse EndCreateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFunction

        /// <summary>
        /// Creates a Lambda function. To create a function, you need a <a href="http://docs.aws.amazon.com/lambda/latest/dg/deployment-package-v2.html">deployment
        /// package</a> and an <a href="http://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
        /// role</a>. The deployment package contains your function code. The execution role grants
        /// the function permission to use AWS services such as Amazon CloudWatch Logs for log
        /// streaming and AWS X-Ray for request tracing.
        /// 
        ///  
        /// <para>
        /// A function has an unpublished version, and can have published versions and aliases.
        /// A published version is a snapshot of your function code and configuration that can
        /// not be changed. An alias is a named resource that maps to a version, and can be changed
        /// to map to a different version. Use the <code>Publish</code> parameter to create version
        /// <code>1</code> of your function from its initial configuration.
        /// </para>
        ///  
        /// <para>
        /// The other parameters let you configure version-specific and function-level settings.
        /// You can modify version-specific settings later with <a>UpdateFunctionConfiguration</a>.
        /// Function-level settings apply to both the unpublished and published versions of the
        /// function and include tags (<a>TagResource</a>) and per-function concurrency limits
        /// (<a>PutFunctionConcurrency</a>).
        /// </para>
        ///  
        /// <para>
        /// If another account or a AWS service invokes your function, use <a>AddPermission</a>
        /// to grant permission by creating a resource-based IAM policy. You can grant permissions
        /// at the function level, on a version, or on an alias.
        /// </para>
        ///  
        /// <para>
        /// To invoke your function directly, use <a>Invoke</a>. To invoke your function in response
        /// to events in other AWS services, create an event source mapping (<a>CreateEventSourceMapping</a>),
        /// or configure a function trigger in the other service. For more information, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/invoking-lambda-functions.html">Invoking
        /// Functions</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual IAsyncResult BeginCreateFunction(CreateFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunction.</param>
        /// 
        /// <returns>Returns a  CreateFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse EndCreateFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Deletes a Lambda function <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSourceMapping

        /// <summary>
        /// Deletes an <a href="http://docs.aws.amazon.com/lambda/latest/dg/intro-invocation-modes.html">event
        /// source mapping</a>. You can get the identifier of a mapping from the output of <a>ListEventSourceMappings</a>.
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
        /// to update an EventSource Mapping in CREATING, or tried to delete a EventSource mapping
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSourceMapping(DeleteEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  DeleteEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual DeleteEventSourceMappingResponse EndDeleteEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunction

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
        public virtual DeleteFunctionResponse DeleteFunction(string functionName)
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            return DeleteFunction(request);
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
        /// Request throughput limit exceeded.
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
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunctionConcurrency

        /// <summary>
        /// Removes a concurrent execution limit from a function.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionConcurrency.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionConcurrencyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual DeleteFunctionConcurrencyResponse EndDeleteFunctionConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLayerVersion

        /// <summary>
        /// Deletes a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>. Deleted versions can no longer be viewed or added to functions.
        /// To avoid breaking functions, a copy of the version remains in Lambda until no functions
        /// refer to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteLayerVersion(DeleteLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayerVersion.</param>
        /// 
        /// <returns>Returns a  DeleteLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual DeleteLayerVersionResponse EndDeleteLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLayerVersionResponse>(asyncResult);
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAlias

        /// <summary>
        /// Returns details about a Lambda function <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual IAsyncResult BeginGetAlias(GetAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlias.</param>
        /// 
        /// <returns>Returns a  GetAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual GetAliasResponse EndGetAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventSourceMapping

        /// <summary>
        /// Returns details about an event source mapping. You can get the identifier of a mapping
        /// from the output of <a>ListEventSourceMappings</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginGetEventSourceMapping(GetEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  GetEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual GetEventSourceMappingResponse EndGetEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunction

        /// <summary>
        /// Returns information about function or function version, with a link to download the
        /// deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details specific to that version are returned.
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        public virtual GetFunctionResponse GetFunction(string functionName)
        {
            var request = new GetFunctionRequest();
            request.FunctionName = functionName;
            return GetFunction(request);
        }


        /// <summary>
        /// Returns information about function or function version, with a link to download the
        /// deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details specific to that version are returned.
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
        /// Request throughput limit exceeded.
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
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse EndGetFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionConfiguration

        /// <summary>
        /// Returns a the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> - <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
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
        public virtual GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName)
        {
            var request = new GetFunctionConfigurationRequest();
            request.FunctionName = functionName;
            return GetFunctionConfiguration(request);
        }


        /// <summary>
        /// Returns a the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
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
        /// Request throughput limit exceeded.
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
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionConfiguration(GetFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFunctionConfigurationResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse EndGetFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayerVersion

        /// <summary>
        /// Returns information about a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>, with a link to download the layer archive that's valid for 10 minutes.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginGetLayerVersion(GetLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayerVersion.</param>
        /// 
        /// <returns>Returns a  GetLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual GetLayerVersionResponse EndGetLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayerVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayerVersionPolicy

        /// <summary>
        /// Returns the permission policy for a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayerVersionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetLayerVersionPolicy(GetLayerVersionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayerVersionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayerVersionPolicy.</param>
        /// 
        /// <returns>Returns a  GetLayerVersionPolicyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual GetLayerVersionPolicyResponse EndGetLayerVersionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayerVersionPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns the <a href="http://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
        /// IAM policy</a> for a function, version, or alias.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  Invoke

        /// <summary>
        /// Invokes a Lambda function. You can invoke a function synchronously and wait for the
        /// response, or asynchronously. To invoke a function asynchronously, set <code>InvocationType</code>
        /// to <code>Event</code>.
        /// 
        ///  
        /// <para>
        /// For synchronous invocation, details about the function response, including errors,
        /// are included in the response body and headers. For either invocation type, you can
        /// find more information in the <a href="http://docs.aws.amazon.com/lambda/latest/dg/monitoring-functions.html">execution
        /// log</a> and <a href="http://docs.aws.amazon.com/lambda/latest/dg/dlq.html">trace</a>.
        /// To record function errors for asynchronous invocations, configure your function with
        /// a <a href="http://docs.aws.amazon.com/lambda/latest/dg/dlq.html">dead letter queue</a>.
        /// </para>
        ///  
        /// <para>
        /// The status code in the API response does not reflect function errors. Error codes
        /// are reserved for errors that prevent your function from executing, such as permissions
        /// errors, <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">limit errors</a>,
        /// or issues with your function's code and configuration. For example, Lambda returns
        /// <code>TooManyRequestsException</code> if executing the function would cause you to
        /// exceed a concurrency limit at either the account level (<code>ConcurrentInvocationLimitExceeded</code>)
        /// or function level (<code>ReservedFunctionConcurrentInvocationLimitExceeded</code>).
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the Invoke operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvoke
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual IAsyncResult BeginInvoke(InvokeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Invoke operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvoke.</param>
        /// 
        /// <returns>Returns a  InvokeResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual InvokeResponse EndInvoke(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeResponse>(asyncResult);
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
        /// Invokes a function asynchronously.
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
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core and PCL, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual IAsyncResult BeginInvokeAsync(InvokeAsyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAsync.</param>
        /// 
        /// <returns>Returns a  InvokeAsyncResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core and PCL, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual InvokeAsyncResponse EndInvokeAsync(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeAsyncResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Returns a list of <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">aliases</a>
        /// for a Lambda function.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventSourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual IAsyncResult BeginListEventSourceMappings(ListEventSourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSourceMappings.</param>
        /// 
        /// <returns>Returns a  ListEventSourceMappingsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual ListEventSourceMappingsResponse EndListEventSourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventSourceMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctions

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
        public virtual ListFunctionsResponse ListFunctions()
        {
            var request = new ListFunctionsRequest();
            return ListFunctions(request);
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
        /// Request throughput limit exceeded.
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
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLayers

        /// <summary>
        /// Lists <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layers</a> and shows information about the latest version of each. Specify
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListLayers operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLayers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual IAsyncResult BeginListLayers(ListLayersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLayers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLayers.</param>
        /// 
        /// <returns>Returns a  ListLayersResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual ListLayersResponse EndListLayers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLayersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLayerVersions

        /// <summary>
        /// Lists the versions of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>. Versions that have been deleted aren't listed. Specify a <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLayerVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual IAsyncResult BeginListLayerVersions(ListLayerVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayerVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayerVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLayerVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLayerVersions.</param>
        /// 
        /// <returns>Returns a  ListLayerVersionsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual ListLayerVersionsResponse EndListLayerVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLayerVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns a function's <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>.
        /// You can also view tags with <a>GetFunction</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVersionsByFunction

        /// <summary>
        /// Returns a list of <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">versions</a>,
        /// with the version-specific configuration of each.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersionsByFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual IAsyncResult BeginListVersionsByFunction(ListVersionsByFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersionsByFunction.</param>
        /// 
        /// <returns>Returns a  ListVersionsByFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual ListVersionsByFunctionResponse EndListVersionsByFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVersionsByFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishLayerVersion

        /// <summary>
        /// Creates an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a> from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginPublishLayerVersion(PublishLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishLayerVersion.</param>
        /// 
        /// <returns>Returns a  PublishLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual PublishLayerVersionResponse EndPublishLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishLayerVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishVersion

        /// <summary>
        /// Creates a <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version</a>
        /// from the current code and configuration of a function. Use versions to create a snapshot
        /// of your function code and configuration that doesn't change.
        /// 
        ///  
        /// <para>
        /// AWS Lambda does not publish a version if the function's configuration and code hasn't
        /// changed since the last version. Use <a>UpdateFunctionCode</a> or <a>UpdateFunctionConfiguration</a>
        /// to update the function prior to publishing a version.
        /// </para>
        ///  
        /// <para>
        /// Clients can invoke versions directly or with an alias. To create an alias, use <a>CreateAlias</a>.
        /// </para>
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual IAsyncResult BeginPublishVersion(PublishVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishVersion.</param>
        /// 
        /// <returns>Returns a  PublishVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual PublishVersionResponse EndPublishVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFunctionConcurrency

        /// <summary>
        /// Sets the maximum number of simultaneous executions for a function, and reserves capacity
        /// for that concurrency level.
        /// 
        ///  
        /// <para>
        /// Concurrency settings apply to the function as a whole, including all published versions
        /// and the unpublished version. Reserving concurrency both guarantees that your function
        /// has capacity to process the specified number of events simultaneously, and prevents
        /// it from scaling beyond that level. Use <a>GetFunction</a> to see the current setting
        /// for a function.
        /// </para>
        ///  
        /// <para>
        /// Use <a>GetAccountSettings</a> to see your regional concurrency limit. You can reserve
        /// concurrency for as many functions as you like, as long as you leave at least 100 simultaneous
        /// executions unreserved for functions that aren't configured with a per-function limit.
        /// For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html">Managing
        /// Concurrency</a>.
        /// </para>
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFunctionConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual IAsyncResult BeginPutFunctionConcurrency(PutFunctionConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFunctionConcurrency.</param>
        /// 
        /// <returns>Returns a  PutFunctionConcurrencyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual PutFunctionConcurrencyResponse EndPutFunctionConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFunctionConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveLayerVersionPermission

        /// <summary>
        /// Removes a statement from the permissions policy for a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
        /// Lambda layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveLayerVersionPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual IAsyncResult BeginRemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLayerVersionPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveLayerVersionPermission.</param>
        /// 
        /// <returns>Returns a  RemoveLayerVersionPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual RemoveLayerVersionPermissionResponse EndRemoveLayerVersionPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveLayerVersionPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Revokes function use permission from an AWS service or another account. You can get
        /// the ID of the statement from the output of <a>GetPolicy</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a> to
        /// a function.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// from a function.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Updates the configuration of a Lambda function <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAliasResponse>(asyncResult);
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
        /// to update an EventSource Mapping in CREATING, or tried to delete a EventSource mapping
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventSourceMapping(UpdateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  UpdateEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual UpdateEventSourceMappingResponse EndUpdateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionCode

        /// <summary>
        /// Updates a Lambda function's code.
        /// 
        ///  
        /// <para>
        /// The function's code is locked when you publish a version. You cannot modify the code
        /// of a published version, only the unpublished version.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionCode(UpdateFunctionCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionCode.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionCodeResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual UpdateFunctionCodeResponse EndUpdateFunctionCode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionConfiguration

        /// <summary>
        /// Modify the version-specifc settings of a Lambda function.
        /// 
        ///  
        /// <para>
        /// These settings can vary between versions of a function and are locked when you publish
        /// a version. You cannot modify the configuration of a published version, only the unpublished
        /// version.
        /// </para>
        ///  
        /// <para>
        /// To configure function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke
        /// permissions to an account or AWS service, use <a>AddPermission</a>.
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
        /// Request throughput limit exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionConfigurationResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual UpdateFunctionConfigurationResponse EndUpdateFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}