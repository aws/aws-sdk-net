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

using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
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
    /// additional information. For the service overview, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the <i>AWS Lambda Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
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

        
        #region  AddPermission

        /// <summary>
        /// Adds a permission to the resource policy associated with the specified AWS Lambda
        /// function. You use resource policies to grant permissions to event sources that use
        /// <i>push</i> model. In a <i>push</i> model, event sources (such as Amazon S3 and custom
        /// applications) invoke your Lambda function. Each permission you add to the resource
        /// policy allows an event source, permission to invoke the Lambda function. 
        /// 
        ///  
        /// <para>
        /// For information about the push model, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
        /// Lambda: How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you are using versioning, the permissions you add are specific to the Lambda function
        /// version or alias you specify in the <code>AddPermission</code> request via the <code>Qualifier</code>
        /// parameter. For more information about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
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
        /// 
        /// </exception>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionRequest,AddPermissionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<AddPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from Lambda.</returns>
        public  AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPermissionResponse>(asyncResult);
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
        /// 
        /// </exception>
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from Lambda.</returns>
        public  CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSourceMapping

        /// <summary>
        /// Identifies a stream as an event source for a Lambda function. It can be either an
        /// Amazon Kinesis stream or an Amazon DynamoDB stream. AWS Lambda invokes the specified
        /// function when records are posted to the stream.
        /// 
        ///  
        /// <para>
        /// This association between a stream source and a Lambda function is called the event
        /// source mapping.
        /// </para>
        ///  <important>
        /// <para>
        /// This event source mapping is relevant only in the AWS Lambda pull model, where AWS
        /// Lambda invokes the function. For more information, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
        /// Lambda: How it Works</a> in the <i>AWS Lambda Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You provide mapping information (for example, which stream to read from and which
        /// Lambda function to invoke) in the request body.
        /// </para>
        ///  
        /// <para>
        /// Each event source, such as an Amazon Kinesis or a DynamoDB stream, can be associated
        /// with multiple AWS Lambda function. A given Lambda function can be associated with
        /// multiple AWS event sources.
        /// </para>
        ///  
        /// <para>
        /// If you are using versioning, you can specify a specific function version or an alias
        /// via the function name parameter. For more information about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:CreateEventSourceMapping</code>
        /// action.
        /// </para>
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
        /// 
        /// </exception>
        public CreateEventSourceMappingResponse CreateEventSourceMapping(CreateEventSourceMappingRequest request)
        {
            var marshaller = new CreateEventSourceMappingRequestMarshaller();
            var unmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<CreateEventSourceMappingRequest,CreateEventSourceMappingResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateEventSourceMapping(CreateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateEventSourceMappingRequestMarshaller();
            var unmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke<CreateEventSourceMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  CreateEventSourceMappingResult from Lambda.</returns>
        public  CreateEventSourceMappingResponse EndCreateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFunction

        /// <summary>
        /// Creates a new Lambda function. The function metadata is created from the request parameters,
        /// and the code for the function is provided by a .zip file in the request body. If the
        /// function name already exists, the operation will fail. Note that the function name
        /// is case-sensitive.
        /// 
        ///  
        /// <para>
        ///  If you are using versioning, you can also publish a version of the Lambda function
        /// you are creating using the <code>Publish</code> parameter. For more information about
        /// versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
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
        /// 
        /// </exception>
        public CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var marshaller = new CreateFunctionRequestMarshaller();
            var unmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionRequest,CreateFunctionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateFunction(CreateFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateFunctionRequestMarshaller();
            var unmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunction.</param>
        /// 
        /// <returns>Returns a  CreateFunctionResult from Lambda.</returns>
        public  CreateFunctionResponse EndCreateFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionResponse>(asyncResult);
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
        /// 
        /// </exception>
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from Lambda.</returns>
        public  DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSourceMapping

        /// <summary>
        /// Removes an event source mapping. This means AWS Lambda will no longer invoke the function
        /// for events in the associated source.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteEventSourceMapping</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSourceMapping service method, as returned by Lambda.</returns>
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
        /// 
        /// </exception>
        public DeleteEventSourceMappingResponse DeleteEventSourceMapping(DeleteEventSourceMappingRequest request)
        {
            var marshaller = new DeleteEventSourceMappingRequestMarshaller();
            var unmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSourceMappingRequest,DeleteEventSourceMappingResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteEventSourceMapping(DeleteEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteEventSourceMappingRequestMarshaller();
            var unmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEventSourceMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  DeleteEventSourceMappingResult from Lambda.</returns>
        public  DeleteEventSourceMappingResponse EndDeleteEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunction

        /// <summary>
        /// Deletes the specified Lambda function code and configuration.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature and you don't specify a function version in
        /// your <code>DeleteFunction</code> request, AWS Lambda will delete the function, including
        /// all its versions, and any aliases pointing to the function versions. To delete a specific
        /// function version, you must provide the function version via the <code>Qualifier</code>
        /// parameter. For information about function versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// When you delete a function the associated resource policy is also deleted. You will
        /// need to delete the event source mappings explicitly.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The Lambda function to delete.  You can specify the function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). If you are using versioning, you can also provide a qualified function ARN (ARN that is qualified with function version or alias name as suffix). AWS Lambda also allows you to specify only the function name with the account ID qualifier (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 character in length. </param>
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
        /// 
        /// </exception>
        public DeleteFunctionResponse DeleteFunction(string functionName)
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            return DeleteFunction(request);
        }


        /// <summary>
        /// Deletes the specified Lambda function code and configuration.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature and you don't specify a function version in
        /// your <code>DeleteFunction</code> request, AWS Lambda will delete the function, including
        /// all its versions, and any aliases pointing to the function versions. To delete a specific
        /// function version, you must provide the function version via the <code>Qualifier</code>
        /// parameter. For information about function versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// When you delete a function the associated resource policy is also deleted. You will
        /// need to delete the event source mappings explicitly.
        /// </para>
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
        /// 
        /// </exception>
        public DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var marshaller = new DeleteFunctionRequestMarshaller();
            var unmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionRequest,DeleteFunctionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFunctionRequestMarshaller();
            var unmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from Lambda.</returns>
        public  DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionResponse>(asyncResult);
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
        /// 
        /// </exception>
        public GetAliasResponse GetAlias(GetAliasRequest request)
        {
            var marshaller = new GetAliasRequestMarshaller();
            var unmarshaller = GetAliasResponseUnmarshaller.Instance;

            return Invoke<GetAliasRequest,GetAliasResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginGetAlias(GetAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAliasRequestMarshaller();
            var unmarshaller = GetAliasResponseUnmarshaller.Instance;

            return BeginInvoke<GetAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlias.</param>
        /// 
        /// <returns>Returns a  GetAliasResult from Lambda.</returns>
        public  GetAliasResponse EndGetAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventSourceMapping

        /// <summary>
        /// Returns configuration information for the specified event source mapping (see <a>CreateEventSourceMapping</a>).
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetEventSourceMapping</code>
        /// action.
        /// </para>
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
        /// 
        /// </exception>
        public GetEventSourceMappingResponse GetEventSourceMapping(GetEventSourceMappingRequest request)
        {
            var marshaller = new GetEventSourceMappingRequestMarshaller();
            var unmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<GetEventSourceMappingRequest,GetEventSourceMappingResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginGetEventSourceMapping(GetEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetEventSourceMappingRequestMarshaller();
            var unmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke<GetEventSourceMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  GetEventSourceMappingResult from Lambda.</returns>
        public  GetEventSourceMappingResponse EndGetEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventSourceMappingResponse>(asyncResult);
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
        /// Using the optional <code>Qualifier</code> parameter, you can specify a specific function
        /// version for which you want this information. If you don't specify this parameter,
        /// the API uses unqualified function ARN which return information about the <code>$LATEST</code>
        /// version of the Lambda function. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The Lambda function name.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 character in length. </param>
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
        /// 
        /// </exception>
        public GetFunctionResponse GetFunction(string functionName)
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
        /// Using the optional <code>Qualifier</code> parameter, you can specify a specific function
        /// version for which you want this information. If you don't specify this parameter,
        /// the API uses unqualified function ARN which return information about the <code>$LATEST</code>
        /// version of the Lambda function. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
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
        /// 
        /// </exception>
        public GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var marshaller = new GetFunctionRequestMarshaller();
            var unmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionRequest,GetFunctionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetFunctionRequestMarshaller();
            var unmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<GetFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from Lambda.</returns>
        public  GetFunctionResponse EndGetFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionResponse>(asyncResult);
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
        /// <param name="functionName">The name of the Lambda function for which you want to retrieve the configuration information.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 character in length. </param>
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
        /// 
        /// </exception>
        public GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName)
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
        /// 
        /// </exception>
        public GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request)
        {
            var marshaller = new GetFunctionConfigurationRequestMarshaller();
            var unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConfigurationRequest,GetFunctionConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginGetFunctionConfiguration(GetFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetFunctionConfigurationRequestMarshaller();
            var unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetFunctionConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFunctionConfigurationResult from Lambda.</returns>
        public  GetFunctionConfigurationResponse EndGetFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns the resource policy associated with the specified Lambda function.
        /// 
        ///  
        /// <para>
        ///  If you are using the versioning feature, you can get the resource policy associated
        /// with the specific Lambda function version or alias by specifying the version or alias
        /// name using the <code>Qualifier</code> parameter. For more information about versioning,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about adding permissions, see <a>AddPermission</a>.
        /// </para>
        ///  
        /// <para>
        /// You need permission for the <code>lambda:GetPolicy action.</code> 
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
        /// 
        /// </exception>
        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyRequest,GetPolicyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from Lambda.</returns>
        public  GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  Invoke

        /// <summary>
        /// Invokes a specific Lambda function. For an example, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-dynamodb-create-function.html#with-dbb-invoke-manually">Create
        /// the Lambda Function and Test It Manually</a>. 
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can invoke the specific function version
        /// by providing function version or alias name that is pointing to the function version
        /// using the <code>Qualifier</code> parameter in the request. If you don't provide the
        /// <code>Qualifier</code> parameter, the <code>$LATEST</code> version of the Lambda function
        /// is invoked. Invocations occur at least once in response to an event and functions
        /// must be idempotent to handle this. For information about the versioning feature, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
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
        /// 
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
        /// <exception cref="Amazon.Lambda.Model.InvalidSecurityGroupIDException">
        /// The Security Group ID provided in the Lambda function VPC configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSubnetIDException">
        /// The Subnet ID provided in the Lambda function VPC configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidZipFileException">
        /// AWS Lambda could not unzip the function zip file.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSAccessDeniedException">
        /// Lambda was unable to decrypt the environment variables becauses KMS access was denied.
        /// Please check the Lambda function's KMS permissions.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSDisabledException">
        /// Lambda was unable to decrypt the environment variables because the KMS key used is
        /// disabled. Please check the Lambda function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSInvalidStateException">
        /// Lambda was unable to decrypt the environment variables because the KMS key used is
        /// in an invalid state for Decrypt. Please check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSNotFoundException">
        /// Lambda was unable to decrypt the environment variables because the KMS key was not
        /// found. Please check the function's KMS key settings.
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.UnsupportedMediaTypeException">
        /// The content type of the <code>Invoke</code> request body is not JSON.
        /// </exception>
        public InvokeResponse Invoke(InvokeRequest request)
        {
            var marshaller = new InvokeRequestMarshaller();
            var unmarshaller = InvokeResponseUnmarshaller.Instance;

            return Invoke<InvokeRequest,InvokeResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginInvoke(InvokeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new InvokeRequestMarshaller();
            var unmarshaller = InvokeResponseUnmarshaller.Instance;

            return BeginInvoke<InvokeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Invoke operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvoke.</param>
        /// 
        /// <returns>Returns a  InvokeResult from Lambda.</returns>
        public  InvokeResponse EndInvoke(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeAsync

        /// <summary>
        /// <important>
        /// <para>
        /// This API is deprecated. We recommend you use <code>Invoke</code> API (see <a>Invoke</a>).
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        [Obsolete("This API is deprecated. We recommend that you use Invoke API instead.")]
        public InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request)
        {
            var marshaller = new InvokeAsyncRequestMarshaller();
            var unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeAsyncRequest,InvokeAsyncResponse>(request, marshaller, unmarshaller);
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
        [Obsolete("This API is deprecated. We recommend that you use Invoke API instead.")]
        public IAsyncResult BeginInvokeAsync(InvokeAsyncRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new InvokeAsyncRequestMarshaller();
            var unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return BeginInvoke<InvokeAsyncRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAsync.</param>
        /// 
        /// <returns>Returns a  InvokeAsyncResult from Lambda.</returns>
        [Obsolete("This API is deprecated. We recommend that you use Invoke API instead.")]
        public  InvokeAsyncResponse EndInvokeAsync(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeAsyncResponse>(asyncResult);
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
        /// 
        /// </exception>
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAliasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from Lambda.</returns>
        public  ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventSourceMappings

        /// <summary>
        /// Returns a list of event source mappings you created using the <code>CreateEventSourceMapping</code>
        /// (see <a>CreateEventSourceMapping</a>). 
        /// 
        ///  
        /// <para>
        /// For each mapping, the API returns configuration information. You can optionally specify
        /// filters to retrieve specific event source mappings.
        /// </para>
        ///  
        /// <para>
        /// If you are using the versioning feature, you can get list of event source mappings
        /// for a specific Lambda function version or an alias as described in the <code>FunctionName</code>
        /// parameter. For information about the versioning feature, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListEventSourceMappings</code>
        /// action.
        /// </para>
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
        /// 
        /// </exception>
        public ListEventSourceMappingsResponse ListEventSourceMappings(ListEventSourceMappingsRequest request)
        {
            var marshaller = new ListEventSourceMappingsRequestMarshaller();
            var unmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return Invoke<ListEventSourceMappingsRequest,ListEventSourceMappingsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListEventSourceMappings(ListEventSourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListEventSourceMappingsRequestMarshaller();
            var unmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke<ListEventSourceMappingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSourceMappings.</param>
        /// 
        /// <returns>Returns a  ListEventSourceMappingsResult from Lambda.</returns>
        public  ListEventSourceMappingsResponse EndListEventSourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventSourceMappingsResponse>(asyncResult);
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
        /// If you are using versioning feature, the response returns list of $LATEST versions
        /// of your functions. For information about the versioning feature, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public ListFunctionsResponse ListFunctions()
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
        /// If you are using versioning feature, the response returns list of $LATEST versions
        /// of your functions. For information about the versioning feature, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var marshaller = new ListFunctionsRequestMarshaller();
            var unmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsRequest,ListFunctionsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFunctionsRequestMarshaller();
            var unmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFunctionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from Lambda.</returns>
        public  ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVersionsByFunction

        /// <summary>
        /// List all versions of a function. For information about the versioning feature, see
        /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
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
        /// 
        /// </exception>
        public ListVersionsByFunctionResponse ListVersionsByFunction(ListVersionsByFunctionRequest request)
        {
            var marshaller = new ListVersionsByFunctionRequestMarshaller();
            var unmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListVersionsByFunctionRequest,ListVersionsByFunctionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListVersionsByFunction(ListVersionsByFunctionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVersionsByFunctionRequestMarshaller();
            var unmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return BeginInvoke<ListVersionsByFunctionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersionsByFunction.</param>
        /// 
        /// <returns>Returns a  ListVersionsByFunctionResult from Lambda.</returns>
        public  ListVersionsByFunctionResponse EndListVersionsByFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVersionsByFunctionResponse>(asyncResult);
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public PublishVersionResponse PublishVersion(PublishVersionRequest request)
        {
            var marshaller = new PublishVersionRequestMarshaller();
            var unmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return Invoke<PublishVersionRequest,PublishVersionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginPublishVersion(PublishVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PublishVersionRequestMarshaller();
            var unmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return BeginInvoke<PublishVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishVersion.</param>
        /// 
        /// <returns>Returns a  PublishVersionResult from Lambda.</returns>
        public  PublishVersionResponse EndPublishVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// You can remove individual permissions from an resource policy associated with a Lambda
        /// function by providing a statement ID that you provided when you added the permission.
        /// 
        ///  
        /// <para>
        /// If you are using versioning, the permissions you remove are specific to the Lambda
        /// function version or alias you specify in the <code>AddPermission</code> request via
        /// the <code>Qualifier</code> parameter. For more information about versioning, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
        /// Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// Note that removal of a permission will cause an active event source to lose permission
        /// to the function.
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke<RemovePermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from Lambda.</returns>
        public  RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from Lambda.</returns>
        public  UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventSourceMapping

        /// <summary>
        /// You can update an event source mapping. This is useful if you want to change the parameters
        /// of the existing mapping without losing your position in the stream. You can change
        /// which function will receive the stream records, but to change the stream itself, you
        /// must create a new mapping.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can update the event source mapping to
        /// map to a specific Lambda function version or alias as described in the <code>FunctionName</code>
        /// parameter. For information about the versioning feature, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you disable the event source mapping, AWS Lambda stops polling. If you enable again,
        /// it will resume polling from the time it had stopped polling, so you don't lose processing
        /// of any records. However, if you delete event source mapping and create it again, it
        /// will reset.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:UpdateEventSourceMapping</code>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public UpdateEventSourceMappingResponse UpdateEventSourceMapping(UpdateEventSourceMappingRequest request)
        {
            var marshaller = new UpdateEventSourceMappingRequestMarshaller();
            var unmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateEventSourceMappingRequest,UpdateEventSourceMappingResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateEventSourceMapping(UpdateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateEventSourceMappingRequestMarshaller();
            var unmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEventSourceMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  UpdateEventSourceMappingResult from Lambda.</returns>
        public  UpdateEventSourceMappingResponse EndUpdateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventSourceMappingResponse>(asyncResult);
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest request)
        {
            var marshaller = new UpdateFunctionCodeRequestMarshaller();
            var unmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionCodeRequest,UpdateFunctionCodeResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateFunctionCode(UpdateFunctionCodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFunctionCodeRequestMarshaller();
            var unmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFunctionCodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionCode.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionCodeResult from Lambda.</returns>
        public  UpdateFunctionCodeResponse EndUpdateFunctionCode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionCodeResponse>(asyncResult);
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
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        public UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request)
        {
            var marshaller = new UpdateFunctionConfigurationRequestMarshaller();
            var unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionConfigurationRequest,UpdateFunctionConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateFunctionConfigurationRequestMarshaller();
            var unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFunctionConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionConfigurationResult from Lambda.</returns>
        public  UpdateFunctionConfigurationResponse EndUpdateFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}