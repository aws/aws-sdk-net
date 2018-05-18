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
    ///  This document contains reference information for the <a href="https://aws.amazon.com/ses/">Amazon
    /// Simple Email Service</a> (Amazon SES) API, version 2010-12-01. This document is best
    /// used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  For a list of Amazon SES endpoints to use in service requests, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions
    /// and Amazon SES</a> in the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        public virtual void CloneReceiptRuleSetAsync(CloneReceiptRuleSetRequest request, AmazonServiceCallback<CloneReceiptRuleSetRequest, CloneReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
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
        
        #region  CreateConfigurationSet

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual void CreateConfigurationSetAsync(CreateConfigurationSetRequest request, AmazonServiceCallback<CreateConfigurationSetRequest, CreateConfigurationSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateConfigurationSetRequest,CreateConfigurationSetResponse> responseObject 
                            = new AmazonServiceResult<CreateConfigurationSetRequest,CreateConfigurationSetResponse>((CreateConfigurationSetRequest)req, (CreateConfigurationSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateConfigurationSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual void CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, AmazonServiceCallback<CreateConfigurationSetEventDestinationRequest, CreateConfigurationSetEventDestinationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse> responseObject 
                            = new AmazonServiceResult<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>((CreateConfigurationSetEventDestinationRequest)req, (CreateConfigurationSetEventDestinationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateConfigurationSetTrackingOptions

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        public virtual void CreateConfigurationSetTrackingOptionsAsync(CreateConfigurationSetTrackingOptionsRequest request, AmazonServiceCallback<CreateConfigurationSetTrackingOptionsRequest, CreateConfigurationSetTrackingOptionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateConfigurationSetTrackingOptionsRequest,CreateConfigurationSetTrackingOptionsResponse> responseObject 
                            = new AmazonServiceResult<CreateConfigurationSetTrackingOptionsRequest,CreateConfigurationSetTrackingOptionsResponse>((CreateConfigurationSetTrackingOptionsRequest)req, (CreateConfigurationSetTrackingOptionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual void CreateCustomVerificationEmailTemplateAsync(CreateCustomVerificationEmailTemplateRequest request, AmazonServiceCallback<CreateCustomVerificationEmailTemplateRequest, CreateCustomVerificationEmailTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateCustomVerificationEmailTemplateRequest,CreateCustomVerificationEmailTemplateResponse> responseObject 
                            = new AmazonServiceResult<CreateCustomVerificationEmailTemplateRequest,CreateCustomVerificationEmailTemplateResponse>((CreateCustomVerificationEmailTemplateRequest)req, (CreateCustomVerificationEmailTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        public virtual void CreateReceiptFilterAsync(CreateReceiptFilterRequest request, AmazonServiceCallback<CreateReceiptFilterRequest, CreateReceiptFilterResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateReceiptFilterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        public virtual void CreateReceiptRuleAsync(CreateReceiptRuleRequest request, AmazonServiceCallback<CreateReceiptRuleRequest, CreateReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateReceiptRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        public virtual void CreateReceiptRuleSetAsync(CreateReceiptRuleSetRequest request, AmazonServiceCallback<CreateReceiptRuleSetRequest, CreateReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
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
        
        #region  CreateTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual void CreateTemplateAsync(CreateTemplateRequest request, AmazonServiceCallback<CreateTemplateRequest, CreateTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateTemplateRequest,CreateTemplateResponse> responseObject 
                            = new AmazonServiceResult<CreateTemplateRequest,CreateTemplateResponse>((CreateTemplateRequest)req, (CreateTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual void DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, AmazonServiceCallback<DeleteConfigurationSetRequest, DeleteConfigurationSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse> responseObject 
                            = new AmazonServiceResult<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>((DeleteConfigurationSetRequest)req, (DeleteConfigurationSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteConfigurationSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual void DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, AmazonServiceCallback<DeleteConfigurationSetEventDestinationRequest, DeleteConfigurationSetEventDestinationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse> responseObject 
                            = new AmazonServiceResult<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>((DeleteConfigurationSetEventDestinationRequest)req, (DeleteConfigurationSetEventDestinationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteConfigurationSetTrackingOptions

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        public virtual void DeleteConfigurationSetTrackingOptionsAsync(DeleteConfigurationSetTrackingOptionsRequest request, AmazonServiceCallback<DeleteConfigurationSetTrackingOptionsRequest, DeleteConfigurationSetTrackingOptionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteConfigurationSetTrackingOptionsRequest,DeleteConfigurationSetTrackingOptionsResponse> responseObject 
                            = new AmazonServiceResult<DeleteConfigurationSetTrackingOptionsRequest,DeleteConfigurationSetTrackingOptionsResponse>((DeleteConfigurationSetTrackingOptionsRequest)req, (DeleteConfigurationSetTrackingOptionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        public virtual void DeleteCustomVerificationEmailTemplateAsync(DeleteCustomVerificationEmailTemplateRequest request, AmazonServiceCallback<DeleteCustomVerificationEmailTemplateRequest, DeleteCustomVerificationEmailTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteCustomVerificationEmailTemplateRequest,DeleteCustomVerificationEmailTemplateResponse> responseObject 
                            = new AmazonServiceResult<DeleteCustomVerificationEmailTemplateRequest,DeleteCustomVerificationEmailTemplateResponse>((DeleteCustomVerificationEmailTemplateRequest)req, (DeleteCustomVerificationEmailTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        public virtual void DeleteIdentityAsync(DeleteIdentityRequest request, AmazonServiceCallback<DeleteIdentityRequest, DeleteIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteIdentityRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        public virtual void DeleteIdentityPolicyAsync(DeleteIdentityPolicyRequest request, AmazonServiceCallback<DeleteIdentityPolicyRequest, DeleteIdentityPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        public virtual void DeleteReceiptFilterAsync(DeleteReceiptFilterRequest request, AmazonServiceCallback<DeleteReceiptFilterRequest, DeleteReceiptFilterResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteReceiptFilterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        public virtual void DeleteReceiptRuleAsync(DeleteReceiptRuleRequest request, AmazonServiceCallback<DeleteReceiptRuleRequest, DeleteReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteReceiptRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        public virtual void DeleteReceiptRuleSetAsync(DeleteReceiptRuleSetRequest request, AmazonServiceCallback<DeleteReceiptRuleSetRequest, DeleteReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
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
        
        #region  DeleteTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual void DeleteTemplateAsync(DeleteTemplateRequest request, AmazonServiceCallback<DeleteTemplateRequest, DeleteTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteTemplateRequest,DeleteTemplateResponse> responseObject 
                            = new AmazonServiceResult<DeleteTemplateRequest,DeleteTemplateResponse>((DeleteTemplateRequest)req, (DeleteTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        public virtual void DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest request, AmazonServiceCallback<DeleteVerifiedEmailAddressRequest, DeleteVerifiedEmailAddressResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        public virtual void DescribeActiveReceiptRuleSetAsync(DescribeActiveReceiptRuleSetRequest request, AmazonServiceCallback<DescribeActiveReceiptRuleSetRequest, DescribeActiveReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
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
        
        #region  DescribeConfigurationSet

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSet operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        public virtual void DescribeConfigurationSetAsync(DescribeConfigurationSetRequest request, AmazonServiceCallback<DescribeConfigurationSetRequest, DescribeConfigurationSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeConfigurationSetRequest,DescribeConfigurationSetResponse> responseObject 
                            = new AmazonServiceResult<DescribeConfigurationSetRequest,DescribeConfigurationSetResponse>((DescribeConfigurationSetRequest)req, (DescribeConfigurationSetResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeConfigurationSetRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        public virtual void DescribeReceiptRuleAsync(DescribeReceiptRuleRequest request, AmazonServiceCallback<DescribeReceiptRuleRequest, DescribeReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeReceiptRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        public virtual void DescribeReceiptRuleSetAsync(DescribeReceiptRuleSetRequest request, AmazonServiceCallback<DescribeReceiptRuleSetRequest, DescribeReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
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
        
        #region  GetAccountSendingEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        public virtual void GetAccountSendingEnabledAsync(GetAccountSendingEnabledRequest request, AmazonServiceCallback<GetAccountSendingEnabledRequest, GetAccountSendingEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccountSendingEnabledRequest,GetAccountSendingEnabledResponse> responseObject 
                            = new AmazonServiceResult<GetAccountSendingEnabledRequest,GetAccountSendingEnabledResponse>((GetAccountSendingEnabledRequest)req, (GetAccountSendingEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetAccountSendingEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetCustomVerificationEmailTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        public virtual void GetCustomVerificationEmailTemplateAsync(GetCustomVerificationEmailTemplateRequest request, AmazonServiceCallback<GetCustomVerificationEmailTemplateRequest, GetCustomVerificationEmailTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCustomVerificationEmailTemplateRequest,GetCustomVerificationEmailTemplateResponse> responseObject 
                            = new AmazonServiceResult<GetCustomVerificationEmailTemplateRequest,GetCustomVerificationEmailTemplateResponse>((GetCustomVerificationEmailTemplateRequest)req, (GetCustomVerificationEmailTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        public virtual void GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest request, AmazonServiceCallback<GetIdentityDkimAttributesRequest, GetIdentityDkimAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        public virtual void GetIdentityMailFromDomainAttributesAsync(GetIdentityMailFromDomainAttributesRequest request, AmazonServiceCallback<GetIdentityMailFromDomainAttributesRequest, GetIdentityMailFromDomainAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        public virtual void GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest request, AmazonServiceCallback<GetIdentityNotificationAttributesRequest, GetIdentityNotificationAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        public virtual void GetIdentityPoliciesAsync(GetIdentityPoliciesRequest request, AmazonServiceCallback<GetIdentityPoliciesRequest, GetIdentityPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityPoliciesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        public virtual void GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest request, AmazonServiceCallback<GetIdentityVerificationAttributesRequest, GetIdentityVerificationAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
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
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual void GetSendQuotaAsync(AmazonServiceCallback<GetSendQuotaRequest, GetSendQuotaResponse> callback, AsyncOptions options = null)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual void GetSendQuotaAsync(GetSendQuotaRequest request, AmazonServiceCallback<GetSendQuotaRequest, GetSendQuotaResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetSendQuotaRequestMarshaller.Instance;
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
        /// Provides sending statistics for the current AWS Region. The result is a list of data
        /// points, representing the last two weeks of sending activity. Each data point in the
        /// list contains statistics for a 15-minute period of time.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual void GetSendStatisticsAsync(AmazonServiceCallback<GetSendStatisticsRequest, GetSendStatisticsResponse> callback, AsyncOptions options = null)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual void GetSendStatisticsAsync(GetSendStatisticsRequest request, AmazonServiceCallback<GetSendStatisticsRequest, GetSendStatisticsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetSendStatisticsRequestMarshaller.Instance;
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
        
        #region  GetTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual void GetTemplateAsync(GetTemplateRequest request, AmazonServiceCallback<GetTemplateRequest, GetTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = GetTemplateRequestMarshaller.Instance;
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetTemplateRequest,GetTemplateResponse> responseObject 
                            = new AmazonServiceResult<GetTemplateRequest,GetTemplateResponse>((GetTemplateRequest)req, (GetTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListConfigurationSets

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual void ListConfigurationSetsAsync(ListConfigurationSetsRequest request, AmazonServiceCallback<ListConfigurationSetsRequest, ListConfigurationSetsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListConfigurationSetsRequest,ListConfigurationSetsResponse> responseObject 
                            = new AmazonServiceResult<ListConfigurationSetsRequest,ListConfigurationSetsResponse>((ListConfigurationSetsRequest)req, (ListConfigurationSetsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListConfigurationSetsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListCustomVerificationEmailTemplates

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        public virtual void ListCustomVerificationEmailTemplatesAsync(ListCustomVerificationEmailTemplatesRequest request, AmazonServiceCallback<ListCustomVerificationEmailTemplatesRequest, ListCustomVerificationEmailTemplatesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListCustomVerificationEmailTemplatesRequest,ListCustomVerificationEmailTemplatesResponse> responseObject 
                            = new AmazonServiceResult<ListCustomVerificationEmailTemplatesRequest,ListCustomVerificationEmailTemplatesResponse>((ListCustomVerificationEmailTemplatesRequest)req, (ListCustomVerificationEmailTemplatesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListCustomVerificationEmailTemplatesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your AWS account in the current AWS Region, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual void ListIdentitiesAsync(AmazonServiceCallback<ListIdentitiesRequest, ListIdentitiesResponse> callback, AsyncOptions options = null)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual void ListIdentitiesAsync(ListIdentitiesRequest request, AmazonServiceCallback<ListIdentitiesRequest, ListIdentitiesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        public virtual void ListIdentityPoliciesAsync(ListIdentityPoliciesRequest request, AmazonServiceCallback<ListIdentityPoliciesRequest, ListIdentityPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListIdentityPoliciesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        public virtual void ListReceiptFiltersAsync(ListReceiptFiltersRequest request, AmazonServiceCallback<ListReceiptFiltersRequest, ListReceiptFiltersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListReceiptFiltersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        public virtual void ListReceiptRuleSetsAsync(ListReceiptRuleSetsRequest request, AmazonServiceCallback<ListReceiptRuleSetsRequest, ListReceiptRuleSetsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
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
        
        #region  ListTemplates

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual void ListTemplatesAsync(ListTemplatesRequest request, AmazonServiceCallback<ListTemplatesRequest, ListTemplatesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListTemplatesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListTemplatesRequest,ListTemplatesResponse> responseObject 
                            = new AmazonServiceResult<ListTemplatesRequest,ListTemplatesResponse>((ListTemplatesRequest)req, (ListTemplatesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListTemplatesRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        /// <summary>
        /// Deprecated. Use the <code>ListIdentities</code> operation to list the email addresses
        /// and domains associated with your account.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual void ListVerifiedEmailAddressesAsync(AmazonServiceCallback<ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse> callback, AsyncOptions options = null)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual void ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest request, AmazonServiceCallback<ListVerifiedEmailAddressesRequest, ListVerifiedEmailAddressesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        public virtual void PutIdentityPolicyAsync(PutIdentityPolicyRequest request, AmazonServiceCallback<PutIdentityPolicyRequest, PutIdentityPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = PutIdentityPolicyRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        public virtual void ReorderReceiptRuleSetAsync(ReorderReceiptRuleSetRequest request, AmazonServiceCallback<ReorderReceiptRuleSetRequest, ReorderReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        public virtual void SendBounceAsync(SendBounceRequest request, AmazonServiceCallback<SendBounceRequest, SendBounceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendBounceRequestMarshaller.Instance;
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
        
        #region  SendBulkTemplatedEmail

        /// <summary>
        /// Initiates the asynchronous execution of the SendBulkTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBulkTemplatedEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        public virtual void SendBulkTemplatedEmailAsync(SendBulkTemplatedEmailRequest request, AmazonServiceCallback<SendBulkTemplatedEmailRequest, SendBulkTemplatedEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendBulkTemplatedEmailRequest,SendBulkTemplatedEmailResponse> responseObject 
                            = new AmazonServiceResult<SendBulkTemplatedEmailRequest,SendBulkTemplatedEmailResponse>((SendBulkTemplatedEmailRequest)req, (SendBulkTemplatedEmailResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendBulkTemplatedEmailRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  SendCustomVerificationEmail

        /// <summary>
        /// Initiates the asynchronous execution of the SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        public virtual void SendCustomVerificationEmailAsync(SendCustomVerificationEmailRequest request, AmazonServiceCallback<SendCustomVerificationEmailRequest, SendCustomVerificationEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            var unmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendCustomVerificationEmailRequest,SendCustomVerificationEmailResponse> responseObject 
                            = new AmazonServiceResult<SendCustomVerificationEmailRequest,SendCustomVerificationEmailResponse>((SendCustomVerificationEmailRequest)req, (SendCustomVerificationEmailResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendCustomVerificationEmailRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual void SendEmailAsync(SendEmailRequest request, AmazonServiceCallback<SendEmailRequest, SendEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendEmailRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        public virtual void SendRawEmailAsync(SendRawEmailRequest request, AmazonServiceCallback<SendRawEmailRequest, SendRawEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendRawEmailRequestMarshaller.Instance;
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
        
        #region  SendTemplatedEmail

        /// <summary>
        /// Initiates the asynchronous execution of the SendTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTemplatedEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        public virtual void SendTemplatedEmailAsync(SendTemplatedEmailRequest request, AmazonServiceCallback<SendTemplatedEmailRequest, SendTemplatedEmailResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SendTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SendTemplatedEmailRequest,SendTemplatedEmailResponse> responseObject 
                            = new AmazonServiceResult<SendTemplatedEmailRequest,SendTemplatedEmailResponse>((SendTemplatedEmailRequest)req, (SendTemplatedEmailResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<SendTemplatedEmailRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        public virtual void SetActiveReceiptRuleSetAsync(SetActiveReceiptRuleSetRequest request, AmazonServiceCallback<SetActiveReceiptRuleSetRequest, SetActiveReceiptRuleSetResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        public virtual void SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest request, AmazonServiceCallback<SetIdentityDkimEnabledRequest, SetIdentityDkimEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        public virtual void SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest request, AmazonServiceCallback<SetIdentityFeedbackForwardingEnabledRequest, SetIdentityFeedbackForwardingEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        public virtual void SetIdentityHeadersInNotificationsEnabledAsync(SetIdentityHeadersInNotificationsEnabledRequest request, AmazonServiceCallback<SetIdentityHeadersInNotificationsEnabledRequest, SetIdentityHeadersInNotificationsEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        public virtual void SetIdentityMailFromDomainAsync(SetIdentityMailFromDomainRequest request, AmazonServiceCallback<SetIdentityMailFromDomainRequest, SetIdentityMailFromDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        public virtual void SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest request, AmazonServiceCallback<SetIdentityNotificationTopicRequest, SetIdentityNotificationTopicResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        public virtual void SetReceiptRulePositionAsync(SetReceiptRulePositionRequest request, AmazonServiceCallback<SetReceiptRulePositionRequest, SetReceiptRulePositionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = SetReceiptRulePositionRequestMarshaller.Instance;
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
        
        #region  TestRenderTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the TestRenderTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRenderTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        public virtual void TestRenderTemplateAsync(TestRenderTemplateRequest request, AmazonServiceCallback<TestRenderTemplateRequest, TestRenderTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = TestRenderTemplateRequestMarshaller.Instance;
            var unmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TestRenderTemplateRequest,TestRenderTemplateResponse> responseObject 
                            = new AmazonServiceResult<TestRenderTemplateRequest,TestRenderTemplateResponse>((TestRenderTemplateRequest)req, (TestRenderTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<TestRenderTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAccountSendingEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        public virtual void UpdateAccountSendingEnabledAsync(UpdateAccountSendingEnabledRequest request, AmazonServiceCallback<UpdateAccountSendingEnabledRequest, UpdateAccountSendingEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAccountSendingEnabledRequest,UpdateAccountSendingEnabledResponse> responseObject 
                            = new AmazonServiceResult<UpdateAccountSendingEnabledRequest,UpdateAccountSendingEnabledResponse>((UpdateAccountSendingEnabledRequest)req, (UpdateAccountSendingEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateAccountSendingEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual void UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, AmazonServiceCallback<UpdateConfigurationSetEventDestinationRequest, UpdateConfigurationSetEventDestinationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse> responseObject 
                            = new AmazonServiceResult<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>((UpdateConfigurationSetEventDestinationRequest)req, (UpdateConfigurationSetEventDestinationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateConfigurationSetEventDestinationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateConfigurationSetReputationMetricsEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetReputationMetricsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetReputationMetricsEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        public virtual void UpdateConfigurationSetReputationMetricsEnabledAsync(UpdateConfigurationSetReputationMetricsEnabledRequest request, AmazonServiceCallback<UpdateConfigurationSetReputationMetricsEnabledRequest, UpdateConfigurationSetReputationMetricsEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateConfigurationSetReputationMetricsEnabledRequest,UpdateConfigurationSetReputationMetricsEnabledResponse> responseObject 
                            = new AmazonServiceResult<UpdateConfigurationSetReputationMetricsEnabledRequest,UpdateConfigurationSetReputationMetricsEnabledResponse>((UpdateConfigurationSetReputationMetricsEnabledRequest)req, (UpdateConfigurationSetReputationMetricsEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateConfigurationSetReputationMetricsEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateConfigurationSetSendingEnabled

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetSendingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        public virtual void UpdateConfigurationSetSendingEnabledAsync(UpdateConfigurationSetSendingEnabledRequest request, AmazonServiceCallback<UpdateConfigurationSetSendingEnabledRequest, UpdateConfigurationSetSendingEnabledResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateConfigurationSetSendingEnabledRequest,UpdateConfigurationSetSendingEnabledResponse> responseObject 
                            = new AmazonServiceResult<UpdateConfigurationSetSendingEnabledRequest,UpdateConfigurationSetSendingEnabledResponse>((UpdateConfigurationSetSendingEnabledRequest)req, (UpdateConfigurationSetSendingEnabledResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateConfigurationSetSendingEnabledRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateConfigurationSetTrackingOptions

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        public virtual void UpdateConfigurationSetTrackingOptionsAsync(UpdateConfigurationSetTrackingOptionsRequest request, AmazonServiceCallback<UpdateConfigurationSetTrackingOptionsRequest, UpdateConfigurationSetTrackingOptionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateConfigurationSetTrackingOptionsRequest,UpdateConfigurationSetTrackingOptionsResponse> responseObject 
                            = new AmazonServiceResult<UpdateConfigurationSetTrackingOptionsRequest,UpdateConfigurationSetTrackingOptionsResponse>((UpdateConfigurationSetTrackingOptionsRequest)req, (UpdateConfigurationSetTrackingOptionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateConfigurationSetTrackingOptionsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        public virtual void UpdateCustomVerificationEmailTemplateAsync(UpdateCustomVerificationEmailTemplateRequest request, AmazonServiceCallback<UpdateCustomVerificationEmailTemplateRequest, UpdateCustomVerificationEmailTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateCustomVerificationEmailTemplateRequest,UpdateCustomVerificationEmailTemplateResponse> responseObject 
                            = new AmazonServiceResult<UpdateCustomVerificationEmailTemplateRequest,UpdateCustomVerificationEmailTemplateResponse>((UpdateCustomVerificationEmailTemplateRequest)req, (UpdateCustomVerificationEmailTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateCustomVerificationEmailTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        public virtual void UpdateReceiptRuleAsync(UpdateReceiptRuleRequest request, AmazonServiceCallback<UpdateReceiptRuleRequest, UpdateReceiptRuleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateReceiptRuleRequestMarshaller.Instance;
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
        
        #region  UpdateTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual void UpdateTemplateAsync(UpdateTemplateRequest request, AmazonServiceCallback<UpdateTemplateRequest, UpdateTemplateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateTemplateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateTemplateRequest,UpdateTemplateResponse> responseObject 
                            = new AmazonServiceResult<UpdateTemplateRequest,UpdateTemplateResponse>((UpdateTemplateRequest)req, (UpdateTemplateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateTemplateRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        public virtual void VerifyDomainDkimAsync(VerifyDomainDkimRequest request, AmazonServiceCallback<VerifyDomainDkimRequest, VerifyDomainDkimResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifyDomainDkimRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        public virtual void VerifyDomainIdentityAsync(VerifyDomainIdentityRequest request, AmazonServiceCallback<VerifyDomainIdentityRequest, VerifyDomainIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifyDomainIdentityRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        public virtual void VerifyEmailAddressAsync(VerifyEmailAddressRequest request, AmazonServiceCallback<VerifyEmailAddressRequest, VerifyEmailAddressResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifyEmailAddressRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        public virtual void VerifyEmailIdentityAsync(VerifyEmailIdentityRequest request, AmazonServiceCallback<VerifyEmailIdentityRequest, VerifyEmailIdentityResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = VerifyEmailIdentityRequestMarshaller.Instance;
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