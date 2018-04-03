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
    /// additional information. For the service overview, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the <b>AWS Lambda Developer Guide</b>.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        #region Constructors

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
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual void AddPermissionAsync(AddPermissionRequest request, AmazonServiceCallback<AddPermissionRequest, AddPermissionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = AddPermissionRequestMarshaller.Instance;
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddPermissionRequest,AddPermissionResponse> responseObject 
                            = new AmazonServiceResult<AddPermissionRequest,AddPermissionResponse>((AddPermissionRequest)req, (AddPermissionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AddPermissionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual void CreateAliasAsync(CreateAliasRequest request, AmazonServiceCallback<CreateAliasRequest, CreateAliasResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateAliasRequest,CreateAliasResponse> responseObject 
                            = new AmazonServiceResult<CreateAliasRequest,CreateAliasResponse>((CreateAliasRequest)req, (CreateAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateAliasRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateEventSourceMapping

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual void CreateEventSourceMappingAsync(CreateEventSourceMappingRequest request, AmazonServiceCallback<CreateEventSourceMappingRequest, CreateEventSourceMappingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            var unmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateEventSourceMappingRequest,CreateEventSourceMappingResponse> responseObject 
                            = new AmazonServiceResult<CreateEventSourceMappingRequest,CreateEventSourceMappingResponse>((CreateEventSourceMappingRequest)req, (CreateEventSourceMappingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateEventSourceMappingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateFunction

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual void CreateFunctionAsync(CreateFunctionRequest request, AmazonServiceCallback<CreateFunctionRequest, CreateFunctionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateFunctionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateFunctionRequest,CreateFunctionResponse> responseObject 
                            = new AmazonServiceResult<CreateFunctionRequest,CreateFunctionResponse>((CreateFunctionRequest)req, (CreateFunctionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateFunctionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual void DeleteAliasAsync(DeleteAliasRequest request, AmazonServiceCallback<DeleteAliasRequest, DeleteAliasResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteAlias is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteAliasRequestMarshaller.Instance;
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteAliasRequest,DeleteAliasResponse> responseObject 
                            = new AmazonServiceResult<DeleteAliasRequest,DeleteAliasResponse>((DeleteAliasRequest)req, (DeleteAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteAliasRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteEventSourceMapping

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSourceMapping operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual void DeleteEventSourceMappingAsync(DeleteEventSourceMappingRequest request, AmazonServiceCallback<DeleteEventSourceMappingRequest, DeleteEventSourceMappingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteEventSourceMapping is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteEventSourceMappingRequest,DeleteEventSourceMappingResponse> responseObject 
                            = new AmazonServiceResult<DeleteEventSourceMappingRequest,DeleteEventSourceMappingResponse>((DeleteEventSourceMappingRequest)req, (DeleteEventSourceMappingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteEventSourceMappingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="functionName">The Lambda function to delete.  You can specify the function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). If you are using versioning, you can also provide a qualified function ARN (ARN that is qualified with function version or alias name as suffix). AWS Lambda also allows you to specify only the function name with the account ID qualifier (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual void DeleteFunctionAsync(string functionName,  AmazonServiceCallback<DeleteFunctionRequest, DeleteFunctionResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            DeleteFunctionAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual void DeleteFunctionAsync(DeleteFunctionRequest request, AmazonServiceCallback<DeleteFunctionRequest, DeleteFunctionResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteFunction is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteFunctionRequestMarshaller.Instance;
            var unmarshaller = DeleteFunctionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteFunctionRequest,DeleteFunctionResponse> responseObject 
                            = new AmazonServiceResult<DeleteFunctionRequest,DeleteFunctionResponse>((DeleteFunctionRequest)req, (DeleteFunctionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteFunctionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteFunctionConcurrency

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionConcurrency operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual void DeleteFunctionConcurrencyAsync(DeleteFunctionConcurrencyRequest request, AmazonServiceCallback<DeleteFunctionConcurrencyRequest, DeleteFunctionConcurrencyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteFunctionConcurrency is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            var unmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteFunctionConcurrencyRequest,DeleteFunctionConcurrencyResponse> responseObject 
                            = new AmazonServiceResult<DeleteFunctionConcurrencyRequest,DeleteFunctionConcurrencyResponse>((DeleteFunctionConcurrencyRequest)req, (DeleteFunctionConcurrencyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteFunctionConcurrencyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual void GetAccountSettingsAsync(GetAccountSettingsRequest request, AmazonServiceCallback<GetAccountSettingsRequest, GetAccountSettingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetAccountSettingsRequestMarshaller.Instance;
            var unmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccountSettingsRequest,GetAccountSettingsResponse> responseObject 
                            = new AmazonServiceResult<GetAccountSettingsRequest,GetAccountSettingsResponse>((GetAccountSettingsRequest)req, (GetAccountSettingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetAccountSettingsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetAlias

        /// <summary>
        /// Initiates the asynchronous execution of the GetAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual void GetAliasAsync(GetAliasRequest request, AmazonServiceCallback<GetAliasRequest, GetAliasResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetAliasRequestMarshaller.Instance;
            var unmarshaller = GetAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAliasRequest,GetAliasResponse> responseObject 
                            = new AmazonServiceResult<GetAliasRequest,GetAliasResponse>((GetAliasRequest)req, (GetAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetAliasRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetEventSourceMapping

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual void GetEventSourceMappingAsync(GetEventSourceMappingRequest request, AmazonServiceCallback<GetEventSourceMappingRequest, GetEventSourceMappingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetEventSourceMappingRequestMarshaller.Instance;
            var unmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetEventSourceMappingRequest,GetEventSourceMappingResponse> responseObject 
                            = new AmazonServiceResult<GetEventSourceMappingRequest,GetEventSourceMappingResponse>((GetEventSourceMappingRequest)req, (GetEventSourceMappingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetEventSourceMappingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="functionName">The Lambda function name.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual void GetFunctionAsync(string functionName,  AmazonServiceCallback<GetFunctionRequest, GetFunctionResponse> callback, AsyncOptions options = null)
        {
            var request = new GetFunctionRequest();
            request.FunctionName = functionName;
            GetFunctionAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual void GetFunctionAsync(GetFunctionRequest request, AmazonServiceCallback<GetFunctionRequest, GetFunctionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetFunctionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetFunctionRequest,GetFunctionResponse> responseObject 
                            = new AmazonServiceResult<GetFunctionRequest,GetFunctionResponse>((GetFunctionRequest)req, (GetFunctionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetFunctionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="functionName">The name of the Lambda function for which you want to retrieve the configuration information.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual void GetFunctionConfigurationAsync(string functionName,  AmazonServiceCallback<GetFunctionConfigurationRequest, GetFunctionConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetFunctionConfigurationRequest();
            request.FunctionName = functionName;
            GetFunctionConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual void GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, AmazonServiceCallback<GetFunctionConfigurationRequest, GetFunctionConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetFunctionConfigurationRequest,GetFunctionConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetFunctionConfigurationRequest,GetFunctionConfigurationResponse>((GetFunctionConfigurationRequest)req, (GetFunctionConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetFunctionConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual void GetPolicyAsync(GetPolicyRequest request, AmazonServiceCallback<GetPolicyRequest, GetPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetPolicyRequestMarshaller.Instance;
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetPolicyRequest,GetPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetPolicyRequest,GetPolicyResponse>((GetPolicyRequest)req, (GetPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  Invoke

        /// <summary>
        /// Initiates the asynchronous execution of the Invoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Invoke operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual void InvokeAsync(InvokeRequest request, AmazonServiceCallback<InvokeRequest, InvokeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = InvokeRequestMarshaller.Instance;
            var unmarshaller = InvokeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InvokeRequest,InvokeResponse> responseObject 
                            = new AmazonServiceResult<InvokeRequest,InvokeResponse>((InvokeRequest)req, (InvokeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<InvokeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  InvokeAsync

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("This API is deprecated. We recommend that you use Invoke API instead.")]
        public virtual void InvokeAsyncAsync(InvokeAsyncRequest request, AmazonServiceCallback<InvokeAsyncRequest, InvokeAsyncResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = InvokeAsyncRequestMarshaller.Instance;
            var unmarshaller = InvokeAsyncResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InvokeAsyncRequest,InvokeAsyncResponse> responseObject 
                            = new AmazonServiceResult<InvokeAsyncRequest,InvokeAsyncResponse>((InvokeAsyncRequest)req, (InvokeAsyncResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<InvokeAsyncRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual void ListAliasesAsync(ListAliasesRequest request, AmazonServiceCallback<ListAliasesRequest, ListAliasesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListAliasesRequestMarshaller.Instance;
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAliasesRequest,ListAliasesResponse> responseObject 
                            = new AmazonServiceResult<ListAliasesRequest,ListAliasesResponse>((ListAliasesRequest)req, (ListAliasesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListAliasesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListEventSourceMappings

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual void ListEventSourceMappingsAsync(ListEventSourceMappingsRequest request, AmazonServiceCallback<ListEventSourceMappingsRequest, ListEventSourceMappingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            var unmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListEventSourceMappingsRequest,ListEventSourceMappingsResponse> responseObject 
                            = new AmazonServiceResult<ListEventSourceMappingsRequest,ListEventSourceMappingsResponse>((ListEventSourceMappingsRequest)req, (ListEventSourceMappingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListEventSourceMappingsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual void ListFunctionsAsync( AmazonServiceCallback<ListFunctionsRequest, ListFunctionsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListFunctionsRequest();
            ListFunctionsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual void ListFunctionsAsync(ListFunctionsRequest request, AmazonServiceCallback<ListFunctionsRequest, ListFunctionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListFunctionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListFunctionsRequest,ListFunctionsResponse> responseObject 
                            = new AmazonServiceResult<ListFunctionsRequest,ListFunctionsResponse>((ListFunctionsRequest)req, (ListFunctionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListFunctionsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual void ListTagsAsync(ListTagsRequest request, AmazonServiceCallback<ListTagsRequest, ListTagsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListTagsRequest,ListTagsResponse> responseObject 
                            = new AmazonServiceResult<ListTagsRequest,ListTagsResponse>((ListTagsRequest)req, (ListTagsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListTagsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListVersionsByFunction

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual void ListVersionsByFunctionAsync(ListVersionsByFunctionRequest request, AmazonServiceCallback<ListVersionsByFunctionRequest, ListVersionsByFunctionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            var unmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListVersionsByFunctionRequest,ListVersionsByFunctionResponse> responseObject 
                            = new AmazonServiceResult<ListVersionsByFunctionRequest,ListVersionsByFunctionResponse>((ListVersionsByFunctionRequest)req, (ListVersionsByFunctionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListVersionsByFunctionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PublishVersion

        /// <summary>
        /// Initiates the asynchronous execution of the PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual void PublishVersionAsync(PublishVersionRequest request, AmazonServiceCallback<PublishVersionRequest, PublishVersionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = PublishVersionRequestMarshaller.Instance;
            var unmarshaller = PublishVersionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PublishVersionRequest,PublishVersionResponse> responseObject 
                            = new AmazonServiceResult<PublishVersionRequest,PublishVersionResponse>((PublishVersionRequest)req, (PublishVersionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PublishVersionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutFunctionConcurrency

        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionConcurrency operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual void PutFunctionConcurrencyAsync(PutFunctionConcurrencyRequest request, AmazonServiceCallback<PutFunctionConcurrencyRequest, PutFunctionConcurrencyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutFunctionConcurrency is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            var unmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutFunctionConcurrencyRequest,PutFunctionConcurrencyResponse> responseObject 
                            = new AmazonServiceResult<PutFunctionConcurrencyRequest,PutFunctionConcurrencyResponse>((PutFunctionConcurrencyRequest)req, (PutFunctionConcurrencyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutFunctionConcurrencyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual void RemovePermissionAsync(RemovePermissionRequest request, AmazonServiceCallback<RemovePermissionRequest, RemovePermissionResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("RemovePermission is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = RemovePermissionRequestMarshaller.Instance;
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RemovePermissionRequest,RemovePermissionResponse> responseObject 
                            = new AmazonServiceResult<RemovePermissionRequest,RemovePermissionResponse>((RemovePermissionRequest)req, (RemovePermissionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<RemovePermissionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual void TagResourceAsync(TagResourceRequest request, AmazonServiceCallback<TagResourceRequest, TagResourceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TagResourceRequest,TagResourceResponse> responseObject 
                            = new AmazonServiceResult<TagResourceRequest,TagResourceResponse>((TagResourceRequest)req, (TagResourceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual void UntagResourceAsync(UntagResourceRequest request, AmazonServiceCallback<UntagResourceRequest, UntagResourceResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UntagResource is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UntagResourceRequest,UntagResourceResponse> responseObject 
                            = new AmazonServiceResult<UntagResourceRequest,UntagResourceResponse>((UntagResourceRequest)req, (UntagResourceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual void UpdateAliasAsync(UpdateAliasRequest request, AmazonServiceCallback<UpdateAliasRequest, UpdateAliasResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UpdateAlias is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateAliasRequestMarshaller.Instance;
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAliasRequest,UpdateAliasResponse> responseObject 
                            = new AmazonServiceResult<UpdateAliasRequest,UpdateAliasResponse>((UpdateAliasRequest)req, (UpdateAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateAliasRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateEventSourceMapping

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventSourceMapping operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual void UpdateEventSourceMappingAsync(UpdateEventSourceMappingRequest request, AmazonServiceCallback<UpdateEventSourceMappingRequest, UpdateEventSourceMappingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UpdateEventSourceMapping is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateEventSourceMappingRequest,UpdateEventSourceMappingResponse> responseObject 
                            = new AmazonServiceResult<UpdateEventSourceMappingRequest,UpdateEventSourceMappingResponse>((UpdateEventSourceMappingRequest)req, (UpdateEventSourceMappingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateEventSourceMappingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateFunctionCode

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionCode operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual void UpdateFunctionCodeAsync(UpdateFunctionCodeRequest request, AmazonServiceCallback<UpdateFunctionCodeRequest, UpdateFunctionCodeResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UpdateFunctionCode is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            var unmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateFunctionCodeRequest,UpdateFunctionCodeResponse> responseObject 
                            = new AmazonServiceResult<UpdateFunctionCodeRequest,UpdateFunctionCodeResponse>((UpdateFunctionCodeRequest)req, (UpdateFunctionCodeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateFunctionCodeRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateFunctionConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual void UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, AmazonServiceCallback<UpdateFunctionConfigurationRequest, UpdateFunctionConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UpdateFunctionConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateFunctionConfigurationRequest,UpdateFunctionConfigurationResponse> responseObject 
                            = new AmazonServiceResult<UpdateFunctionConfigurationRequest,UpdateFunctionConfigurationResponse>((UpdateFunctionConfigurationRequest)req, (UpdateFunctionConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateFunctionConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
    }
}