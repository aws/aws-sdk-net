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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing SimpleEmailService
    ///
    /// Amazon Simple Email Service 
    /// <para>
    ///  This is the API Reference for Amazon Simple Email Service (Amazon SES). This documentation
    /// is intended to be used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions
    /// and Amazon SES</a> in the Amazon SES Developer Guide. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonSimpleEmailServiceClient : AmazonServiceClient, IAmazonSimpleEmailService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleEmailServiceConfig clientConfig)
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

        
        #region  CloneReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the CloneReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CloneReceiptRuleSetAsync(CloneReceiptRuleSetRequest request, AmazonServiceCallback<CloneReceiptRuleSetRequest, CloneReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new CloneReceiptRuleSetRequestMarshaller();
            var unmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CloneReceiptRuleSetRequest,CloneReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<CloneReceiptRuleSetRequest,CloneReceiptRuleSetResponse>((CloneReceiptRuleSetRequest)req, (CloneReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CloneReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateReceiptFilter

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CreateReceiptFilterAsync(CreateReceiptFilterRequest request, AmazonServiceCallback<CreateReceiptFilterRequest, CreateReceiptFilterResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new CreateReceiptFilterRequestMarshaller();
            var unmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateReceiptFilterRequest,CreateReceiptFilterResponse> responseObject 
                            = new AmazonServiceResult<CreateReceiptFilterRequest,CreateReceiptFilterResponse>((CreateReceiptFilterRequest)req, (CreateReceiptFilterResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateReceiptFilterRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateReceiptRule

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CreateReceiptRuleAsync(CreateReceiptRuleRequest request, AmazonServiceCallback<CreateReceiptRuleRequest, CreateReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new CreateReceiptRuleRequestMarshaller();
            var unmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateReceiptRuleRequest,CreateReceiptRuleResponse> responseObject 
                            = new AmazonServiceResult<CreateReceiptRuleRequest,CreateReceiptRuleResponse>((CreateReceiptRuleRequest)req, (CreateReceiptRuleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateReceiptRuleRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CreateReceiptRuleSetAsync(CreateReceiptRuleSetRequest request, AmazonServiceCallback<CreateReceiptRuleSetRequest, CreateReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new CreateReceiptRuleSetRequestMarshaller();
            var unmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateReceiptRuleSetRequest,CreateReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<CreateReceiptRuleSetRequest,CreateReceiptRuleSetResponse>((CreateReceiptRuleSetRequest)req, (CreateReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteIdentityAsync(DeleteIdentityRequest request, AmazonServiceCallback<DeleteIdentityRequest, DeleteIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteIdentityRequestMarshaller();
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteIdentityRequest,DeleteIdentityResponse> responseObject 
                            = new AmazonServiceResult<DeleteIdentityRequest,DeleteIdentityResponse>((DeleteIdentityRequest)req, (DeleteIdentityResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteIdentityRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteIdentityPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteIdentityPolicyAsync(DeleteIdentityPolicyRequest request, AmazonServiceCallback<DeleteIdentityPolicyRequest, DeleteIdentityPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteIdentityPolicyRequestMarshaller();
            var unmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteIdentityPolicyRequest,DeleteIdentityPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteIdentityPolicyRequest,DeleteIdentityPolicyResponse>((DeleteIdentityPolicyRequest)req, (DeleteIdentityPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteIdentityPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteReceiptFilter

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteReceiptFilterAsync(DeleteReceiptFilterRequest request, AmazonServiceCallback<DeleteReceiptFilterRequest, DeleteReceiptFilterResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteReceiptFilterRequestMarshaller();
            var unmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteReceiptFilterRequest,DeleteReceiptFilterResponse> responseObject 
                            = new AmazonServiceResult<DeleteReceiptFilterRequest,DeleteReceiptFilterResponse>((DeleteReceiptFilterRequest)req, (DeleteReceiptFilterResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteReceiptFilterRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteReceiptRule

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteReceiptRuleAsync(DeleteReceiptRuleRequest request, AmazonServiceCallback<DeleteReceiptRuleRequest, DeleteReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteReceiptRuleRequestMarshaller();
            var unmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteReceiptRuleRequest,DeleteReceiptRuleResponse> responseObject 
                            = new AmazonServiceResult<DeleteReceiptRuleRequest,DeleteReceiptRuleResponse>((DeleteReceiptRuleRequest)req, (DeleteReceiptRuleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteReceiptRuleRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteReceiptRuleSetAsync(DeleteReceiptRuleSetRequest request, AmazonServiceCallback<DeleteReceiptRuleSetRequest, DeleteReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteReceiptRuleSetRequestMarshaller();
            var unmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteReceiptRuleSetRequest,DeleteReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<DeleteReceiptRuleSetRequest,DeleteReceiptRuleSetResponse>((DeleteReceiptRuleSetRequest)req, (DeleteReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest request, AmazonServiceCallback<DeleteVerifiedEmailAddressRequest, DeleteVerifiedEmailAddressResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteVerifiedEmailAddressRequestMarshaller();
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse> responseObject 
                            = new AmazonServiceResult<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse>((DeleteVerifiedEmailAddressRequest)req, (DeleteVerifiedEmailAddressResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteVerifiedEmailAddressRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeActiveReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DescribeActiveReceiptRuleSetAsync(DescribeActiveReceiptRuleSetRequest request, AmazonServiceCallback<DescribeActiveReceiptRuleSetRequest, DescribeActiveReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DescribeActiveReceiptRuleSetRequestMarshaller();
            var unmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeActiveReceiptRuleSetRequest,DescribeActiveReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<DescribeActiveReceiptRuleSetRequest,DescribeActiveReceiptRuleSetResponse>((DescribeActiveReceiptRuleSetRequest)req, (DescribeActiveReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeActiveReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeReceiptRule

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DescribeReceiptRuleAsync(DescribeReceiptRuleRequest request, AmazonServiceCallback<DescribeReceiptRuleRequest, DescribeReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DescribeReceiptRuleRequestMarshaller();
            var unmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeReceiptRuleRequest,DescribeReceiptRuleResponse> responseObject 
                            = new AmazonServiceResult<DescribeReceiptRuleRequest,DescribeReceiptRuleResponse>((DescribeReceiptRuleRequest)req, (DescribeReceiptRuleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeReceiptRuleRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DescribeReceiptRuleSetAsync(DescribeReceiptRuleSetRequest request, AmazonServiceCallback<DescribeReceiptRuleSetRequest, DescribeReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DescribeReceiptRuleSetRequestMarshaller();
            var unmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeReceiptRuleSetRequest,DescribeReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<DescribeReceiptRuleSetRequest,DescribeReceiptRuleSetResponse>((DescribeReceiptRuleSetRequest)req, (DescribeReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityDkimAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest request, AmazonServiceCallback<GetIdentityDkimAttributesRequest, GetIdentityDkimAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetIdentityDkimAttributesRequestMarshaller();
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse>((GetIdentityDkimAttributesRequest)req, (GetIdentityDkimAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityDkimAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityMailFromDomainAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityMailFromDomainAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityMailFromDomainAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetIdentityMailFromDomainAttributesAsync(GetIdentityMailFromDomainAttributesRequest request, AmazonServiceCallback<GetIdentityMailFromDomainAttributesRequest, GetIdentityMailFromDomainAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetIdentityMailFromDomainAttributesRequestMarshaller();
            var unmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityMailFromDomainAttributesRequest,GetIdentityMailFromDomainAttributesResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityMailFromDomainAttributesRequest,GetIdentityMailFromDomainAttributesResponse>((GetIdentityMailFromDomainAttributesRequest)req, (GetIdentityMailFromDomainAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityMailFromDomainAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityNotificationAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest request, AmazonServiceCallback<GetIdentityNotificationAttributesRequest, GetIdentityNotificationAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetIdentityNotificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse>((GetIdentityNotificationAttributesRequest)req, (GetIdentityNotificationAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityNotificationAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetIdentityPoliciesAsync(GetIdentityPoliciesRequest request, AmazonServiceCallback<GetIdentityPoliciesRequest, GetIdentityPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetIdentityPoliciesRequestMarshaller();
            var unmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityPoliciesRequest,GetIdentityPoliciesResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityPoliciesRequest,GetIdentityPoliciesResponse>((GetIdentityPoliciesRequest)req, (GetIdentityPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityPoliciesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityVerificationAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest request, AmazonServiceCallback<GetIdentityVerificationAttributesRequest, GetIdentityVerificationAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetIdentityVerificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse>((GetIdentityVerificationAttributesRequest)req, (GetIdentityVerificationAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetIdentityVerificationAttributesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetSendQuota

        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        public void GetSendQuotaAsync(AmazonServiceCallback<GetSendQuotaRequest, GetSendQuotaResponse> callback, AsyncOptions options = null)
        {
            GetSendQuotaAsync(new GetSendQuotaRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetSendQuotaAsync(GetSendQuotaRequest request, AmazonServiceCallback<GetSendQuotaRequest, GetSendQuotaResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetSendQuotaRequestMarshaller();
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSendQuotaRequest,GetSendQuotaResponse> responseObject 
                            = new AmazonServiceResult<GetSendQuotaRequest,GetSendQuotaResponse>((GetSendQuotaRequest)req, (GetSendQuotaResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetSendQuotaRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetSendStatistics

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of sending activity.
        /// 
        ///  
        /// <para>
        /// Each data point in the list contains statistics for a 15-minute interval.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        public void GetSendStatisticsAsync(AmazonServiceCallback<GetSendStatisticsRequest, GetSendStatisticsResponse> callback, AsyncOptions options = null)
        {
            GetSendStatisticsAsync(new GetSendStatisticsRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetSendStatisticsAsync(GetSendStatisticsRequest request, AmazonServiceCallback<GetSendStatisticsRequest, GetSendStatisticsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetSendStatisticsRequestMarshaller();
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSendStatisticsRequest,GetSendStatisticsResponse> responseObject 
                            = new AmazonServiceResult<GetSendStatisticsRequest,GetSendStatisticsResponse>((GetSendStatisticsRequest)req, (GetSendStatisticsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetSendStatisticsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your AWS account, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        public void ListIdentitiesAsync(AmazonServiceCallback<ListIdentitiesRequest, ListIdentitiesResponse> callback, AsyncOptions options = null)
        {
            ListIdentitiesAsync(new ListIdentitiesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListIdentitiesAsync(ListIdentitiesRequest request, AmazonServiceCallback<ListIdentitiesRequest, ListIdentitiesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListIdentitiesRequest,ListIdentitiesResponse> responseObject 
                            = new AmazonServiceResult<ListIdentitiesRequest,ListIdentitiesResponse>((ListIdentitiesRequest)req, (ListIdentitiesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListIdentitiesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListIdentityPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListIdentityPoliciesAsync(ListIdentityPoliciesRequest request, AmazonServiceCallback<ListIdentityPoliciesRequest, ListIdentityPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListIdentityPoliciesRequestMarshaller();
            var unmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListIdentityPoliciesRequest,ListIdentityPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListIdentityPoliciesRequest,ListIdentityPoliciesResponse>((ListIdentityPoliciesRequest)req, (ListIdentityPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListIdentityPoliciesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListReceiptFilters

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListReceiptFiltersAsync(ListReceiptFiltersRequest request, AmazonServiceCallback<ListReceiptFiltersRequest, ListReceiptFiltersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListReceiptFiltersRequestMarshaller();
            var unmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListReceiptFiltersRequest,ListReceiptFiltersResponse> responseObject 
                            = new AmazonServiceResult<ListReceiptFiltersRequest,ListReceiptFiltersResponse>((ListReceiptFiltersRequest)req, (ListReceiptFiltersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListReceiptFiltersRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListReceiptRuleSets

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListReceiptRuleSetsAsync(ListReceiptRuleSetsRequest request, AmazonServiceCallback<ListReceiptRuleSetsRequest, ListReceiptRuleSetsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListReceiptRuleSetsRequestMarshaller();
            var unmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListReceiptRuleSetsRequest,ListReceiptRuleSetsResponse> responseObject 
                            = new AmazonServiceResult<ListReceiptRuleSetsRequest,ListReceiptRuleSetsResponse>((ListReceiptRuleSetsRequest)req, (ListReceiptRuleSetsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListReceiptRuleSetsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        ///  <important> 
        /// <para>
        /// The ListVerifiedEmailAddresses action is deprecated as of the May 15, 2012 release
        /// of Domain Verification. The ListIdentities action is now preferred.
        /// </para>
        ///  </important> 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        public void ListVerifiedEmailAddressesAsync(AmazonServiceCallback<ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse> callback, AsyncOptions options = null)
        {
            ListVerifiedEmailAddressesAsync(new ListVerifiedEmailAddressesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest request, AmazonServiceCallback<ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListVerifiedEmailAddressesRequestMarshaller();
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse> responseObject 
                            = new AmazonServiceResult<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse>((ListVerifiedEmailAddressesRequest)req, (ListVerifiedEmailAddressesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListVerifiedEmailAddressesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutIdentityPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutIdentityPolicyAsync(PutIdentityPolicyRequest request, AmazonServiceCallback<PutIdentityPolicyRequest, PutIdentityPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutIdentityPolicyRequestMarshaller();
            var unmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutIdentityPolicyRequest,PutIdentityPolicyResponse> responseObject 
                            = new AmazonServiceResult<PutIdentityPolicyRequest,PutIdentityPolicyResponse>((PutIdentityPolicyRequest)req, (PutIdentityPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutIdentityPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ReorderReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the ReorderReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ReorderReceiptRuleSetAsync(ReorderReceiptRuleSetRequest request, AmazonServiceCallback<ReorderReceiptRuleSetRequest, ReorderReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ReorderReceiptRuleSetRequestMarshaller();
            var unmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ReorderReceiptRuleSetRequest,ReorderReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<ReorderReceiptRuleSetRequest,ReorderReceiptRuleSetResponse>((ReorderReceiptRuleSetRequest)req, (ReorderReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ReorderReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SendBounce

        /// <summary>
        /// Initiates the asynchronous execution of the SendBounce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBounce operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SendBounceAsync(SendBounceRequest request, AmazonServiceCallback<SendBounceRequest, SendBounceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SendBounceRequestMarshaller();
            var unmarshaller = SendBounceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendBounceRequest,SendBounceResponse> responseObject 
                            = new AmazonServiceResult<SendBounceRequest,SendBounceResponse>((SendBounceRequest)req, (SendBounceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendBounceRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SendEmail

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SendEmailAsync(SendEmailRequest request, AmazonServiceCallback<SendEmailRequest, SendEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SendEmailRequestMarshaller();
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendEmailRequest,SendEmailResponse> responseObject 
                            = new AmazonServiceResult<SendEmailRequest,SendEmailResponse>((SendEmailRequest)req, (SendEmailResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendEmailRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SendRawEmail

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SendRawEmailAsync(SendRawEmailRequest request, AmazonServiceCallback<SendRawEmailRequest, SendRawEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SendRawEmailRequestMarshaller();
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendRawEmailRequest,SendRawEmailResponse> responseObject 
                            = new AmazonServiceResult<SendRawEmailRequest,SendRawEmailResponse>((SendRawEmailRequest)req, (SendRawEmailResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendRawEmailRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetActiveReceiptRuleSet

        /// <summary>
        /// Initiates the asynchronous execution of the SetActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetActiveReceiptRuleSetAsync(SetActiveReceiptRuleSetRequest request, AmazonServiceCallback<SetActiveReceiptRuleSetRequest, SetActiveReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetActiveReceiptRuleSetRequestMarshaller();
            var unmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetActiveReceiptRuleSetRequest,SetActiveReceiptRuleSetResponse> responseObject 
                            = new AmazonServiceResult<SetActiveReceiptRuleSetRequest,SetActiveReceiptRuleSetResponse>((SetActiveReceiptRuleSetRequest)req, (SetActiveReceiptRuleSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetActiveReceiptRuleSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetIdentityDkimEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest request, AmazonServiceCallback<SetIdentityDkimEnabledRequest, SetIdentityDkimEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetIdentityDkimEnabledRequestMarshaller();
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse> responseObject 
                            = new AmazonServiceResult<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse>((SetIdentityDkimEnabledRequest)req, (SetIdentityDkimEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetIdentityDkimEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest request, AmazonServiceCallback<SetIdentityFeedbackForwardingEnabledRequest, SetIdentityFeedbackForwardingEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetIdentityFeedbackForwardingEnabledRequestMarshaller();
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse> responseObject 
                            = new AmazonServiceResult<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse>((SetIdentityFeedbackForwardingEnabledRequest)req, (SetIdentityFeedbackForwardingEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetIdentityFeedbackForwardingEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetIdentityHeadersInNotificationsEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityHeadersInNotificationsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetIdentityHeadersInNotificationsEnabledAsync(SetIdentityHeadersInNotificationsEnabledRequest request, AmazonServiceCallback<SetIdentityHeadersInNotificationsEnabledRequest, SetIdentityHeadersInNotificationsEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetIdentityHeadersInNotificationsEnabledRequestMarshaller();
            var unmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetIdentityHeadersInNotificationsEnabledRequest,SetIdentityHeadersInNotificationsEnabledResponse> responseObject 
                            = new AmazonServiceResult<SetIdentityHeadersInNotificationsEnabledRequest,SetIdentityHeadersInNotificationsEnabledResponse>((SetIdentityHeadersInNotificationsEnabledRequest)req, (SetIdentityHeadersInNotificationsEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetIdentityHeadersInNotificationsEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetIdentityMailFromDomain

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityMailFromDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityMailFromDomain operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetIdentityMailFromDomainAsync(SetIdentityMailFromDomainRequest request, AmazonServiceCallback<SetIdentityMailFromDomainRequest, SetIdentityMailFromDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetIdentityMailFromDomainRequestMarshaller();
            var unmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetIdentityMailFromDomainRequest,SetIdentityMailFromDomainResponse> responseObject 
                            = new AmazonServiceResult<SetIdentityMailFromDomainRequest,SetIdentityMailFromDomainResponse>((SetIdentityMailFromDomainRequest)req, (SetIdentityMailFromDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetIdentityMailFromDomainRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetIdentityNotificationTopic

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest request, AmazonServiceCallback<SetIdentityNotificationTopicRequest, SetIdentityNotificationTopicResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetIdentityNotificationTopicRequestMarshaller();
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse> responseObject 
                            = new AmazonServiceResult<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse>((SetIdentityNotificationTopicRequest)req, (SetIdentityNotificationTopicResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetIdentityNotificationTopicRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SetReceiptRulePosition

        /// <summary>
        /// Initiates the asynchronous execution of the SetReceiptRulePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void SetReceiptRulePositionAsync(SetReceiptRulePositionRequest request, AmazonServiceCallback<SetReceiptRulePositionRequest, SetReceiptRulePositionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new SetReceiptRulePositionRequestMarshaller();
            var unmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetReceiptRulePositionRequest,SetReceiptRulePositionResponse> responseObject 
                            = new AmazonServiceResult<SetReceiptRulePositionRequest,SetReceiptRulePositionResponse>((SetReceiptRulePositionRequest)req, (SetReceiptRulePositionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SetReceiptRulePositionRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateReceiptRule

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void UpdateReceiptRuleAsync(UpdateReceiptRuleRequest request, AmazonServiceCallback<UpdateReceiptRuleRequest, UpdateReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new UpdateReceiptRuleRequestMarshaller();
            var unmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateReceiptRuleRequest,UpdateReceiptRuleResponse> responseObject 
                            = new AmazonServiceResult<UpdateReceiptRuleRequest,UpdateReceiptRuleResponse>((UpdateReceiptRuleRequest)req, (UpdateReceiptRuleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateReceiptRuleRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyDomainDkim

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void VerifyDomainDkimAsync(VerifyDomainDkimRequest request, AmazonServiceCallback<VerifyDomainDkimRequest, VerifyDomainDkimResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new VerifyDomainDkimRequestMarshaller();
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyDomainDkimRequest,VerifyDomainDkimResponse> responseObject 
                            = new AmazonServiceResult<VerifyDomainDkimRequest,VerifyDomainDkimResponse>((VerifyDomainDkimRequest)req, (VerifyDomainDkimResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifyDomainDkimRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyDomainIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void VerifyDomainIdentityAsync(VerifyDomainIdentityRequest request, AmazonServiceCallback<VerifyDomainIdentityRequest, VerifyDomainIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new VerifyDomainIdentityRequestMarshaller();
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse> responseObject 
                            = new AmazonServiceResult<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse>((VerifyDomainIdentityRequest)req, (VerifyDomainIdentityResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifyDomainIdentityRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyEmailAddress

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void VerifyEmailAddressAsync(VerifyEmailAddressRequest request, AmazonServiceCallback<VerifyEmailAddressRequest, VerifyEmailAddressResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new VerifyEmailAddressRequestMarshaller();
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyEmailAddressRequest,VerifyEmailAddressResponse> responseObject 
                            = new AmazonServiceResult<VerifyEmailAddressRequest,VerifyEmailAddressResponse>((VerifyEmailAddressRequest)req, (VerifyEmailAddressResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifyEmailAddressRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyEmailIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void VerifyEmailIdentityAsync(VerifyEmailIdentityRequest request, AmazonServiceCallback<VerifyEmailIdentityRequest, VerifyEmailIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new VerifyEmailIdentityRequestMarshaller();
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse> responseObject 
                            = new AmazonServiceResult<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse>((VerifyEmailIdentityRequest)req, (VerifyEmailIdentityResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<VerifyEmailIdentityRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
    }
}