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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        internal virtual CloneReceiptRuleSetResponse CloneReceiptRuleSet(CloneReceiptRuleSetRequest request)
        {
            var marshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CloneReceiptRuleSetRequest,CloneReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CloneReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CloneReceiptRuleSet">REST API Reference for CloneReceiptRuleSet Operation</seealso>
        public virtual Task<CloneReceiptRuleSetResponse> CloneReceiptRuleSetAsync(CloneReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CloneReceiptRuleSetRequest,CloneReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSet

        internal virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetRequest,CreateConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination

        internal virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationRequest,CreateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetTrackingOptions

        internal virtual CreateConfigurationSetTrackingOptionsResponse CreateConfigurationSetTrackingOptions(CreateConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetTrackingOptionsRequest,CreateConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetTrackingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateConfigurationSetTrackingOptions">REST API Reference for CreateConfigurationSetTrackingOptions Operation</seealso>
        public virtual Task<CreateConfigurationSetTrackingOptionsResponse> CreateConfigurationSetTrackingOptionsAsync(CreateConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetTrackingOptionsRequest,CreateConfigurationSetTrackingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate

        internal virtual CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateCustomVerificationEmailTemplateRequest,CreateCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<CreateCustomVerificationEmailTemplateResponse> CreateCustomVerificationEmailTemplateAsync(CreateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomVerificationEmailTemplateRequest,CreateCustomVerificationEmailTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptFilter

        internal virtual CreateReceiptFilterResponse CreateReceiptFilter(CreateReceiptFilterRequest request)
        {
            var marshaller = CreateReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptFilterRequest,CreateReceiptFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptFilter">REST API Reference for CreateReceiptFilter Operation</seealso>
        public virtual Task<CreateReceiptFilterResponse> CreateReceiptFilterAsync(CreateReceiptFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptFilterRequest,CreateReceiptFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptRule

        internal virtual CreateReceiptRuleResponse CreateReceiptRule(CreateReceiptRuleRequest request)
        {
            var marshaller = CreateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleRequest,CreateReceiptRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRule">REST API Reference for CreateReceiptRule Operation</seealso>
        public virtual Task<CreateReceiptRuleResponse> CreateReceiptRuleAsync(CreateReceiptRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptRuleRequest,CreateReceiptRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptRuleSet

        internal virtual CreateReceiptRuleSetResponse CreateReceiptRuleSet(CreateReceiptRuleSetRequest request)
        {
            var marshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleSetRequest,CreateReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateReceiptRuleSet">REST API Reference for CreateReceiptRuleSet Operation</seealso>
        public virtual Task<CreateReceiptRuleSetResponse> CreateReceiptRuleSetAsync(CreateReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptRuleSetRequest,CreateReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTemplate

        internal virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var marshaller = CreateTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateRequest,CreateTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateRequest,CreateTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetRequest,DeleteConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        internal virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationRequest,DeleteConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetTrackingOptions

        internal virtual DeleteConfigurationSetTrackingOptionsResponse DeleteConfigurationSetTrackingOptions(DeleteConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetTrackingOptionsRequest,DeleteConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetTrackingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteConfigurationSetTrackingOptions">REST API Reference for DeleteConfigurationSetTrackingOptions Operation</seealso>
        public virtual Task<DeleteConfigurationSetTrackingOptionsResponse> DeleteConfigurationSetTrackingOptionsAsync(DeleteConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetTrackingOptionsRequest,DeleteConfigurationSetTrackingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate

        internal virtual DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomVerificationEmailTemplateRequest,DeleteCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<DeleteCustomVerificationEmailTemplateResponse> DeleteCustomVerificationEmailTemplateAsync(DeleteCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomVerificationEmailTemplateRequest,DeleteCustomVerificationEmailTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentity

        internal virtual DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request)
        {
            var marshaller = DeleteIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityRequest,DeleteIdentityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentity">REST API Reference for DeleteIdentity Operation</seealso>
        public virtual Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIdentityRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityRequest,DeleteIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentityPolicy

        internal virtual DeleteIdentityPolicyResponse DeleteIdentityPolicy(DeleteIdentityPolicyRequest request)
        {
            var marshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPolicyRequest,DeleteIdentityPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteIdentityPolicy">REST API Reference for DeleteIdentityPolicy Operation</seealso>
        public virtual Task<DeleteIdentityPolicyResponse> DeleteIdentityPolicyAsync(DeleteIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityPolicyRequest,DeleteIdentityPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptFilter

        internal virtual DeleteReceiptFilterResponse DeleteReceiptFilter(DeleteReceiptFilterRequest request)
        {
            var marshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptFilterRequest,DeleteReceiptFilterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptFilter">REST API Reference for DeleteReceiptFilter Operation</seealso>
        public virtual Task<DeleteReceiptFilterResponse> DeleteReceiptFilterAsync(DeleteReceiptFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptFilterRequest,DeleteReceiptFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptRule

        internal virtual DeleteReceiptRuleResponse DeleteReceiptRule(DeleteReceiptRuleRequest request)
        {
            var marshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleRequest,DeleteReceiptRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRule">REST API Reference for DeleteReceiptRule Operation</seealso>
        public virtual Task<DeleteReceiptRuleResponse> DeleteReceiptRuleAsync(DeleteReceiptRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptRuleRequest,DeleteReceiptRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptRuleSet

        internal virtual DeleteReceiptRuleSetResponse DeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request)
        {
            var marshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleSetRequest,DeleteReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteReceiptRuleSet">REST API Reference for DeleteReceiptRuleSet Operation</seealso>
        public virtual Task<DeleteReceiptRuleSetResponse> DeleteReceiptRuleSetAsync(DeleteReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptRuleSetRequest,DeleteReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTemplate

        internal virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var marshaller = DeleteTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateRequest,DeleteTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateRequest,DeleteTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        internal virtual DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request)
        {
            var marshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return Invoke<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DeleteVerifiedEmailAddress">REST API Reference for DeleteVerifiedEmailAddress Operation</seealso>
        public virtual Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActiveReceiptRuleSet

        internal virtual DescribeActiveReceiptRuleSetResponse DescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request)
        {
            var marshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeActiveReceiptRuleSetRequest,DescribeActiveReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActiveReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeActiveReceiptRuleSet">REST API Reference for DescribeActiveReceiptRuleSet Operation</seealso>
        public virtual Task<DescribeActiveReceiptRuleSetResponse> DescribeActiveReceiptRuleSetAsync(DescribeActiveReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActiveReceiptRuleSetRequest,DescribeActiveReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationSet

        internal virtual DescribeConfigurationSetResponse DescribeConfigurationSet(DescribeConfigurationSetRequest request)
        {
            var marshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSetRequest,DescribeConfigurationSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeConfigurationSet">REST API Reference for DescribeConfigurationSet Operation</seealso>
        public virtual Task<DescribeConfigurationSetResponse> DescribeConfigurationSetAsync(DescribeConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationSetRequest,DescribeConfigurationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReceiptRule

        internal virtual DescribeReceiptRuleResponse DescribeReceiptRule(DescribeReceiptRuleRequest request)
        {
            var marshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleRequest,DescribeReceiptRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRule">REST API Reference for DescribeReceiptRule Operation</seealso>
        public virtual Task<DescribeReceiptRuleResponse> DescribeReceiptRuleAsync(DescribeReceiptRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReceiptRuleRequest,DescribeReceiptRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReceiptRuleSet

        internal virtual DescribeReceiptRuleSetResponse DescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request)
        {
            var marshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleSetRequest,DescribeReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/DescribeReceiptRuleSet">REST API Reference for DescribeReceiptRuleSet Operation</seealso>
        public virtual Task<DescribeReceiptRuleSetResponse> DescribeReceiptRuleSetAsync(DescribeReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReceiptRuleSetRequest,DescribeReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSendingEnabled

        internal virtual GetAccountSendingEnabledResponse GetAccountSendingEnabled(GetAccountSendingEnabledRequest request)
        {
            var marshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<GetAccountSendingEnabledRequest,GetAccountSendingEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSendingEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetAccountSendingEnabled">REST API Reference for GetAccountSendingEnabled Operation</seealso>
        public virtual Task<GetAccountSendingEnabledResponse> GetAccountSendingEnabledAsync(GetAccountSendingEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSendingEnabledRequest,GetAccountSendingEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCustomVerificationEmailTemplate

        internal virtual GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCustomVerificationEmailTemplateRequest,GetCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<GetCustomVerificationEmailTemplateResponse> GetCustomVerificationEmailTemplateAsync(GetCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCustomVerificationEmailTemplateRequest,GetCustomVerificationEmailTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityDkimAttributes

        internal virtual GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request)
        {
            var marshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityDkimAttributes">REST API Reference for GetIdentityDkimAttributes Operation</seealso>
        public virtual Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityMailFromDomainAttributes

        internal virtual GetIdentityMailFromDomainAttributesResponse GetIdentityMailFromDomainAttributes(GetIdentityMailFromDomainAttributesRequest request)
        {
            var marshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityMailFromDomainAttributesRequest,GetIdentityMailFromDomainAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityMailFromDomainAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityMailFromDomainAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityMailFromDomainAttributes">REST API Reference for GetIdentityMailFromDomainAttributes Operation</seealso>
        public virtual Task<GetIdentityMailFromDomainAttributesResponse> GetIdentityMailFromDomainAttributesAsync(GetIdentityMailFromDomainAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityMailFromDomainAttributesRequest,GetIdentityMailFromDomainAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityNotificationAttributes

        internal virtual GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request)
        {
            var marshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityNotificationAttributes">REST API Reference for GetIdentityNotificationAttributes Operation</seealso>
        public virtual Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityPolicies

        internal virtual GetIdentityPoliciesResponse GetIdentityPolicies(GetIdentityPoliciesRequest request)
        {
            var marshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoliciesRequest,GetIdentityPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityPolicies">REST API Reference for GetIdentityPolicies Operation</seealso>
        public virtual Task<GetIdentityPoliciesResponse> GetIdentityPoliciesAsync(GetIdentityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityPoliciesRequest,GetIdentityPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityVerificationAttributes

        internal virtual GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request)
        {
            var marshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetIdentityVerificationAttributes">REST API Reference for GetIdentityVerificationAttributes Operation</seealso>
        public virtual Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSendQuota

        internal virtual GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }
        internal virtual GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request)
        {
            var marshaller = GetSendQuotaRequestMarshaller.Instance;
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return Invoke<GetSendQuotaRequest,GetSendQuotaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides the sending limits for the Amazon SES account. 
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual Task<GetSendQuotaResponse> GetSendQuotaAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetSendQuotaAsync(new GetSendQuotaRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendQuota">REST API Reference for GetSendQuota Operation</seealso>
        public virtual Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSendQuotaRequestMarshaller.Instance;
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<GetSendQuotaRequest,GetSendQuotaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSendStatistics

        internal virtual GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }
        internal virtual GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request)
        {
            var marshaller = GetSendStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetSendStatisticsRequest,GetSendStatisticsResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual Task<GetSendStatisticsResponse> GetSendStatisticsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetSendStatisticsAsync(new GetSendStatisticsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetSendStatistics">REST API Reference for GetSendStatistics Operation</seealso>
        public virtual Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSendStatisticsRequestMarshaller.Instance;
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSendStatisticsRequest,GetSendStatisticsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var marshaller = GetTemplateRequestMarshaller.Instance;
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateRequest,GetTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTemplateRequestMarshaller.Instance;
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateRequest,GetTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationSets

        internal virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsRequest,ListConfigurationSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListConfigurationSetsRequestMarshaller.Instance;
            var unmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationSetsRequest,ListConfigurationSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCustomVerificationEmailTemplates

        internal virtual ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request)
        {
            var marshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCustomVerificationEmailTemplatesRequest,ListCustomVerificationEmailTemplatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        public virtual Task<ListCustomVerificationEmailTemplatesResponse> ListCustomVerificationEmailTemplatesAsync(ListCustomVerificationEmailTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomVerificationEmailTemplatesRequest,ListCustomVerificationEmailTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIdentities

        internal virtual ListIdentitiesResponse ListIdentities()
        {
            return ListIdentities(new ListIdentitiesRequest());
        }
        internal virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        /// your AWS account in the current AWS Region, regardless of verification status.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListIdentitiesAsync(new ListIdentitiesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIdentitiesRequestMarshaller.Instance;
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityPolicies

        internal virtual ListIdentityPoliciesResponse ListIdentityPolicies(ListIdentityPoliciesRequest request)
        {
            var marshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoliciesRequest,ListIdentityPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListIdentityPolicies">REST API Reference for ListIdentityPolicies Operation</seealso>
        public virtual Task<ListIdentityPoliciesResponse> ListIdentityPoliciesAsync(ListIdentityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityPoliciesRequest,ListIdentityPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReceiptFilters

        internal virtual ListReceiptFiltersResponse ListReceiptFilters(ListReceiptFiltersRequest request)
        {
            var marshaller = ListReceiptFiltersRequestMarshaller.Instance;
            var unmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return Invoke<ListReceiptFiltersRequest,ListReceiptFiltersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptFilters">REST API Reference for ListReceiptFilters Operation</seealso>
        public virtual Task<ListReceiptFiltersResponse> ListReceiptFiltersAsync(ListReceiptFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListReceiptFiltersRequestMarshaller.Instance;
            var unmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceiptFiltersRequest,ListReceiptFiltersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReceiptRuleSets

        internal virtual ListReceiptRuleSetsResponse ListReceiptRuleSets(ListReceiptRuleSetsRequest request)
        {
            var marshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            var unmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListReceiptRuleSetsRequest,ListReceiptRuleSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListReceiptRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceiptRuleSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListReceiptRuleSets">REST API Reference for ListReceiptRuleSets Operation</seealso>
        public virtual Task<ListReceiptRuleSetsResponse> ListReceiptRuleSetsAsync(ListReceiptRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            var unmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceiptRuleSetsRequest,ListReceiptRuleSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTemplates

        internal virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var marshaller = ListTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesRequest,ListTemplatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplatesRequest,ListTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        internal virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }
        internal virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request)
        {
            var marshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return Invoke<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deprecated. Use the <code>ListIdentities</code> operation to list the email addresses
        /// and domains associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListVerifiedEmailAddressesAsync(new ListVerifiedEmailAddressesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ListVerifiedEmailAddresses">REST API Reference for ListVerifiedEmailAddresses Operation</seealso>
        public virtual Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIdentityPolicy

        internal virtual PutIdentityPolicyResponse PutIdentityPolicy(PutIdentityPolicyRequest request)
        {
            var marshaller = PutIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<PutIdentityPolicyRequest,PutIdentityPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/PutIdentityPolicy">REST API Reference for PutIdentityPolicy Operation</seealso>
        public virtual Task<PutIdentityPolicyResponse> PutIdentityPolicyAsync(PutIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutIdentityPolicyRequestMarshaller.Instance;
            var unmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutIdentityPolicyRequest,PutIdentityPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReorderReceiptRuleSet

        internal virtual ReorderReceiptRuleSetResponse ReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request)
        {
            var marshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<ReorderReceiptRuleSetRequest,ReorderReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReorderReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReorderReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/ReorderReceiptRuleSet">REST API Reference for ReorderReceiptRuleSet Operation</seealso>
        public virtual Task<ReorderReceiptRuleSetResponse> ReorderReceiptRuleSetAsync(ReorderReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ReorderReceiptRuleSetRequest,ReorderReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendBounce

        internal virtual SendBounceResponse SendBounce(SendBounceRequest request)
        {
            var marshaller = SendBounceRequestMarshaller.Instance;
            var unmarshaller = SendBounceResponseUnmarshaller.Instance;

            return Invoke<SendBounceRequest,SendBounceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendBounce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBounce operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBounce">REST API Reference for SendBounce Operation</seealso>
        public virtual Task<SendBounceResponse> SendBounceAsync(SendBounceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendBounceRequestMarshaller.Instance;
            var unmarshaller = SendBounceResponseUnmarshaller.Instance;

            return InvokeAsync<SendBounceRequest,SendBounceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendBulkTemplatedEmail

        internal virtual SendBulkTemplatedEmailResponse SendBulkTemplatedEmail(SendBulkTemplatedEmailRequest request)
        {
            var marshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendBulkTemplatedEmailRequest,SendBulkTemplatedEmailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendBulkTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBulkTemplatedEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendBulkTemplatedEmail">REST API Reference for SendBulkTemplatedEmail Operation</seealso>
        public virtual Task<SendBulkTemplatedEmailResponse> SendBulkTemplatedEmailAsync(SendBulkTemplatedEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendBulkTemplatedEmailRequest,SendBulkTemplatedEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendCustomVerificationEmail

        internal virtual SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request)
        {
            var marshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            var unmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return Invoke<SendCustomVerificationEmailRequest,SendCustomVerificationEmailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        public virtual Task<SendCustomVerificationEmailResponse> SendCustomVerificationEmailAsync(SendCustomVerificationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            var unmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendCustomVerificationEmailRequest,SendCustomVerificationEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendEmail

        internal virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailRequest,SendEmailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendEmailRequestMarshaller.Instance;
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailRequest,SendEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendRawEmail

        internal virtual SendRawEmailResponse SendRawEmail(SendRawEmailRequest request)
        {
            var marshaller = SendRawEmailRequestMarshaller.Instance;
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return Invoke<SendRawEmailRequest,SendRawEmailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendRawEmail">REST API Reference for SendRawEmail Operation</seealso>
        public virtual Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendRawEmailRequestMarshaller.Instance;
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendRawEmailRequest,SendRawEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendTemplatedEmail

        internal virtual SendTemplatedEmailResponse SendTemplatedEmail(SendTemplatedEmailRequest request)
        {
            var marshaller = SendTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendTemplatedEmailRequest,SendTemplatedEmailResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendTemplatedEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTemplatedEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SendTemplatedEmail">REST API Reference for SendTemplatedEmail Operation</seealso>
        public virtual Task<SendTemplatedEmailResponse> SendTemplatedEmailAsync(SendTemplatedEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendTemplatedEmailRequestMarshaller.Instance;
            var unmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendTemplatedEmailRequest,SendTemplatedEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetActiveReceiptRuleSet

        internal virtual SetActiveReceiptRuleSetResponse SetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request)
        {
            var marshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<SetActiveReceiptRuleSetRequest,SetActiveReceiptRuleSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetActiveReceiptRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetActiveReceiptRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetActiveReceiptRuleSet">REST API Reference for SetActiveReceiptRuleSet Operation</seealso>
        public virtual Task<SetActiveReceiptRuleSetResponse> SetActiveReceiptRuleSetAsync(SetActiveReceiptRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            var unmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<SetActiveReceiptRuleSetRequest,SetActiveReceiptRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityDkimEnabled

        internal virtual SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request)
        {
            var marshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityDkimEnabled">REST API Reference for SetIdentityDkimEnabled Operation</seealso>
        public virtual Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled

        internal virtual SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request)
        {
            var marshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityFeedbackForwardingEnabled">REST API Reference for SetIdentityFeedbackForwardingEnabled Operation</seealso>
        public virtual Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityHeadersInNotificationsEnabled

        internal virtual SetIdentityHeadersInNotificationsEnabledResponse SetIdentityHeadersInNotificationsEnabled(SetIdentityHeadersInNotificationsEnabledRequest request)
        {
            var marshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityHeadersInNotificationsEnabledRequest,SetIdentityHeadersInNotificationsEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityHeadersInNotificationsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityHeadersInNotificationsEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityHeadersInNotificationsEnabled">REST API Reference for SetIdentityHeadersInNotificationsEnabled Operation</seealso>
        public virtual Task<SetIdentityHeadersInNotificationsEnabledResponse> SetIdentityHeadersInNotificationsEnabledAsync(SetIdentityHeadersInNotificationsEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            var unmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityHeadersInNotificationsEnabledRequest,SetIdentityHeadersInNotificationsEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityMailFromDomain

        internal virtual SetIdentityMailFromDomainResponse SetIdentityMailFromDomain(SetIdentityMailFromDomainRequest request)
        {
            var marshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            var unmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return Invoke<SetIdentityMailFromDomainRequest,SetIdentityMailFromDomainResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityMailFromDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityMailFromDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityMailFromDomain">REST API Reference for SetIdentityMailFromDomain Operation</seealso>
        public virtual Task<SetIdentityMailFromDomainResponse> SetIdentityMailFromDomainAsync(SetIdentityMailFromDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            var unmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityMailFromDomainRequest,SetIdentityMailFromDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityNotificationTopic

        internal virtual SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request)
        {
            var marshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return Invoke<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetIdentityNotificationTopic">REST API Reference for SetIdentityNotificationTopic Operation</seealso>
        public virtual Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetReceiptRulePosition

        internal virtual SetReceiptRulePositionResponse SetReceiptRulePosition(SetReceiptRulePositionRequest request)
        {
            var marshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            var unmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return Invoke<SetReceiptRulePositionRequest,SetReceiptRulePositionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetReceiptRulePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetReceiptRulePosition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/SetReceiptRulePosition">REST API Reference for SetReceiptRulePosition Operation</seealso>
        public virtual Task<SetReceiptRulePositionResponse> SetReceiptRulePositionAsync(SetReceiptRulePositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            var unmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return InvokeAsync<SetReceiptRulePositionRequest,SetReceiptRulePositionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestRenderTemplate

        internal virtual TestRenderTemplateResponse TestRenderTemplate(TestRenderTemplateRequest request)
        {
            var marshaller = TestRenderTemplateRequestMarshaller.Instance;
            var unmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return Invoke<TestRenderTemplateRequest,TestRenderTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestRenderTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRenderTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/TestRenderTemplate">REST API Reference for TestRenderTemplate Operation</seealso>
        public virtual Task<TestRenderTemplateResponse> TestRenderTemplateAsync(TestRenderTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TestRenderTemplateRequestMarshaller.Instance;
            var unmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<TestRenderTemplateRequest,TestRenderTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountSendingEnabled

        internal virtual UpdateAccountSendingEnabledResponse UpdateAccountSendingEnabled(UpdateAccountSendingEnabledRequest request)
        {
            var marshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSendingEnabledRequest,UpdateAccountSendingEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSendingEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateAccountSendingEnabled">REST API Reference for UpdateAccountSendingEnabled Operation</seealso>
        public virtual Task<UpdateAccountSendingEnabledResponse> UpdateAccountSendingEnabledAsync(UpdateAccountSendingEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSendingEnabledRequest,UpdateAccountSendingEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        internal virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationRequest,UpdateConfigurationSetEventDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetReputationMetricsEnabled

        internal virtual UpdateConfigurationSetReputationMetricsEnabledResponse UpdateConfigurationSetReputationMetricsEnabled(UpdateConfigurationSetReputationMetricsEnabledRequest request)
        {
            var marshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetReputationMetricsEnabledRequest,UpdateConfigurationSetReputationMetricsEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetReputationMetricsEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetReputationMetricsEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetReputationMetricsEnabled">REST API Reference for UpdateConfigurationSetReputationMetricsEnabled Operation</seealso>
        public virtual Task<UpdateConfigurationSetReputationMetricsEnabledResponse> UpdateConfigurationSetReputationMetricsEnabledAsync(UpdateConfigurationSetReputationMetricsEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetReputationMetricsEnabledRequest,UpdateConfigurationSetReputationMetricsEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetSendingEnabled

        internal virtual UpdateConfigurationSetSendingEnabledResponse UpdateConfigurationSetSendingEnabled(UpdateConfigurationSetSendingEnabledRequest request)
        {
            var marshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetSendingEnabledRequest,UpdateConfigurationSetSendingEnabledResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetSendingEnabled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetSendingEnabled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetSendingEnabled">REST API Reference for UpdateConfigurationSetSendingEnabled Operation</seealso>
        public virtual Task<UpdateConfigurationSetSendingEnabledResponse> UpdateConfigurationSetSendingEnabledAsync(UpdateConfigurationSetSendingEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetSendingEnabledRequest,UpdateConfigurationSetSendingEnabledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetTrackingOptions

        internal virtual UpdateConfigurationSetTrackingOptionsResponse UpdateConfigurationSetTrackingOptions(UpdateConfigurationSetTrackingOptionsRequest request)
        {
            var marshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetTrackingOptionsRequest,UpdateConfigurationSetTrackingOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetTrackingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateConfigurationSetTrackingOptions">REST API Reference for UpdateConfigurationSetTrackingOptions Operation</seealso>
        public virtual Task<UpdateConfigurationSetTrackingOptionsResponse> UpdateConfigurationSetTrackingOptionsAsync(UpdateConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetTrackingOptionsRequest,UpdateConfigurationSetTrackingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate

        internal virtual UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request)
        {
            var marshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomVerificationEmailTemplateRequest,UpdateCustomVerificationEmailTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<UpdateCustomVerificationEmailTemplateResponse> UpdateCustomVerificationEmailTemplateAsync(UpdateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomVerificationEmailTemplateRequest,UpdateCustomVerificationEmailTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateReceiptRule

        internal virtual UpdateReceiptRuleResponse UpdateReceiptRule(UpdateReceiptRuleRequest request)
        {
            var marshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateReceiptRuleRequest,UpdateReceiptRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReceiptRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReceiptRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateReceiptRule">REST API Reference for UpdateReceiptRule Operation</seealso>
        public virtual Task<UpdateReceiptRuleResponse> UpdateReceiptRuleAsync(UpdateReceiptRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReceiptRuleRequest,UpdateReceiptRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTemplate

        internal virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var marshaller = UpdateTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateRequest,UpdateTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateRequest,UpdateTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyDomainDkim

        internal virtual VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request)
        {
            var marshaller = VerifyDomainDkimRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainDkimRequest,VerifyDomainDkimResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainDkim">REST API Reference for VerifyDomainDkim Operation</seealso>
        public virtual Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = VerifyDomainDkimRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDomainDkimRequest,VerifyDomainDkimResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyDomainIdentity

        internal virtual VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request)
        {
            var marshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyDomainIdentity">REST API Reference for VerifyDomainIdentity Operation</seealso>
        public virtual Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyEmailAddress

        internal virtual VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request)
        {
            var marshaller = VerifyEmailAddressRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailAddressRequest,VerifyEmailAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailAddress">REST API Reference for VerifyEmailAddress Operation</seealso>
        public virtual Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = VerifyEmailAddressRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyEmailAddressRequest,VerifyEmailAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyEmailIdentity

        internal virtual VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request)
        {
            var marshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/email-2010-12-01/VerifyEmailIdentity">REST API Reference for VerifyEmailIdentity Operation</seealso>
        public virtual Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}