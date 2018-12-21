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
using System.Net;

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.SimpleEmail.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonSimpleEmailServiceMetadata();
        
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


        #region  CloneReceiptRuleSet

        internal virtual CloneReceiptRuleSetResponse CloneReceiptRuleSet(CloneReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CloneReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CloneReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSet

        internal virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetEventDestination

        internal virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationSetTrackingOptions

        internal virtual CreateConfigurationSetTrackingOptionsResponse CreateConfigurationSetTrackingOptions(CreateConfigurationSetTrackingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetTrackingOptionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate

        internal virtual CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateCustomVerificationEmailTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptFilter

        internal virtual CreateReceiptFilterResponse CreateReceiptFilter(CreateReceiptFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptFilterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptRule

        internal virtual CreateReceiptRuleResponse CreateReceiptRule(CreateReceiptRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReceiptRuleSet

        internal virtual CreateReceiptRuleSetResponse CreateReceiptRuleSet(CreateReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTemplate

        internal virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        internal virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationSetTrackingOptions

        internal virtual DeleteConfigurationSetTrackingOptionsResponse DeleteConfigurationSetTrackingOptions(DeleteConfigurationSetTrackingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetTrackingOptionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate

        internal virtual DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomVerificationEmailTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentity

        internal virtual DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentityPolicy

        internal virtual DeleteIdentityPolicyResponse DeleteIdentityPolicy(DeleteIdentityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPolicyResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptFilter

        internal virtual DeleteReceiptFilterResponse DeleteReceiptFilter(DeleteReceiptFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptFilterResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptRule

        internal virtual DeleteReceiptRuleResponse DeleteReceiptRule(DeleteReceiptRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReceiptRuleSet

        internal virtual DeleteReceiptRuleSetResponse DeleteReceiptRuleSet(DeleteReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTemplate

        internal virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        internal virtual DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return Invoke<DeleteVerifiedEmailAddressResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVerifiedEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVerifiedEmailAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActiveReceiptRuleSet

        internal virtual DescribeActiveReceiptRuleSetResponse DescribeActiveReceiptRuleSet(DescribeActiveReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeActiveReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActiveReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActiveReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationSet

        internal virtual DescribeConfigurationSetResponse DescribeConfigurationSet(DescribeConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReceiptRule

        internal virtual DescribeReceiptRuleResponse DescribeReceiptRule(DescribeReceiptRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReceiptRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReceiptRuleSet

        internal virtual DescribeReceiptRuleSetResponse DescribeReceiptRuleSet(DescribeReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<DescribeReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSendingEnabled

        internal virtual GetAccountSendingEnabledResponse GetAccountSendingEnabled(GetAccountSendingEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<GetAccountSendingEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSendingEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomVerificationEmailTemplate

        internal virtual GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCustomVerificationEmailTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityDkimAttributes

        internal virtual GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityDkimAttributesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityDkimAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityMailFromDomainAttributes

        internal virtual GetIdentityMailFromDomainAttributesResponse GetIdentityMailFromDomainAttributes(GetIdentityMailFromDomainAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityMailFromDomainAttributesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityMailFromDomainAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityMailFromDomainAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityNotificationAttributes

        internal virtual GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityNotificationAttributesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityNotificationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityNotificationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityPolicies

        internal virtual GetIdentityPoliciesResponse GetIdentityPolicies(GetIdentityPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoliciesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityVerificationAttributes

        internal virtual GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityVerificationAttributesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityVerificationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityVerificationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSendQuota

        internal virtual GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }
        internal virtual GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSendQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return Invoke<GetSendQuotaResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSendQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<GetSendQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSendStatistics

        internal virtual GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }
        internal virtual GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSendStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetSendStatisticsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSendStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSendStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfigurationSets

        internal virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomVerificationEmailTemplates

        internal virtual ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCustomVerificationEmailTemplatesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomVerificationEmailTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentities

        internal virtual ListIdentitiesResponse ListIdentities()
        {
            return ListIdentities(new ListIdentitiesRequest());
        }
        internal virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityPolicies

        internal virtual ListIdentityPoliciesResponse ListIdentityPolicies(ListIdentityPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoliciesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceiptFilters

        internal virtual ListReceiptFiltersResponse ListReceiptFilters(ListReceiptFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceiptFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return Invoke<ListReceiptFiltersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceiptFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceiptFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceiptFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReceiptRuleSets

        internal virtual ListReceiptRuleSetsResponse ListReceiptRuleSets(ListReceiptRuleSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListReceiptRuleSetsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReceiptRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReceiptRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReceiptRuleSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTemplates

        internal virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        internal virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }
        internal virtual ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return Invoke<ListVerifiedEmailAddressesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVerifiedEmailAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVerifiedEmailAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutIdentityPolicy

        internal virtual PutIdentityPolicyResponse PutIdentityPolicy(PutIdentityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<PutIdentityPolicyResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutIdentityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReorderReceiptRuleSet

        internal virtual ReorderReceiptRuleSetResponse ReorderReceiptRuleSet(ReorderReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<ReorderReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ReorderReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReorderReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ReorderReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendBounce

        internal virtual SendBounceResponse SendBounce(SendBounceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBounceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBounceResponseUnmarshaller.Instance;

            return Invoke<SendBounceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBounceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBounceResponseUnmarshaller.Instance;

            return InvokeAsync<SendBounceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendBulkTemplatedEmail

        internal virtual SendBulkTemplatedEmailResponse SendBulkTemplatedEmail(SendBulkTemplatedEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendBulkTemplatedEmailResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendBulkTemplatedEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBulkTemplatedEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendBulkTemplatedEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendCustomVerificationEmail

        internal virtual SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return Invoke<SendCustomVerificationEmailResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendCustomVerificationEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEmail

        internal virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendRawEmail

        internal virtual SendRawEmailResponse SendRawEmail(SendRawEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendRawEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return Invoke<SendRawEmailResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendRawEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendRawEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendTemplatedEmail

        internal virtual SendTemplatedEmailResponse SendTemplatedEmail(SendTemplatedEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTemplatedEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return Invoke<SendTemplatedEmailResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTemplatedEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTemplatedEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendTemplatedEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetActiveReceiptRuleSet

        internal virtual SetActiveReceiptRuleSetResponse SetActiveReceiptRuleSet(SetActiveReceiptRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return Invoke<SetActiveReceiptRuleSetResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetActiveReceiptRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetActiveReceiptRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<SetActiveReceiptRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityDkimEnabled

        internal virtual SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityDkimEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityDkimEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityDkimEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled

        internal virtual SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityFeedbackForwardingEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityFeedbackForwardingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityFeedbackForwardingEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityHeadersInNotificationsEnabled

        internal virtual SetIdentityHeadersInNotificationsEnabledResponse SetIdentityHeadersInNotificationsEnabled(SetIdentityHeadersInNotificationsEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityHeadersInNotificationsEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityHeadersInNotificationsEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityHeadersInNotificationsEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityMailFromDomain

        internal virtual SetIdentityMailFromDomainResponse SetIdentityMailFromDomain(SetIdentityMailFromDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return Invoke<SetIdentityMailFromDomainResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityMailFromDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityMailFromDomainResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityMailFromDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityNotificationTopic

        internal virtual SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return Invoke<SetIdentityNotificationTopicResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityNotificationTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityNotificationTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetReceiptRulePosition

        internal virtual SetReceiptRulePositionResponse SetReceiptRulePosition(SetReceiptRulePositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return Invoke<SetReceiptRulePositionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SetReceiptRulePositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetReceiptRulePositionResponseUnmarshaller.Instance;

            return InvokeAsync<SetReceiptRulePositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestRenderTemplate

        internal virtual TestRenderTemplateResponse TestRenderTemplate(TestRenderTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestRenderTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return Invoke<TestRenderTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TestRenderTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRenderTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<TestRenderTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountSendingEnabled

        internal virtual UpdateAccountSendingEnabledResponse UpdateAccountSendingEnabled(UpdateAccountSendingEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSendingEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSendingEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        internal virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetReputationMetricsEnabled

        internal virtual UpdateConfigurationSetReputationMetricsEnabledResponse UpdateConfigurationSetReputationMetricsEnabled(UpdateConfigurationSetReputationMetricsEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetReputationMetricsEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetReputationMetricsEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetReputationMetricsEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetSendingEnabled

        internal virtual UpdateConfigurationSetSendingEnabledResponse UpdateConfigurationSetSendingEnabled(UpdateConfigurationSetSendingEnabledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetSendingEnabledResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetSendingEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetSendingEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetSendingEnabledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationSetTrackingOptions

        internal virtual UpdateConfigurationSetTrackingOptionsResponse UpdateConfigurationSetTrackingOptions(UpdateConfigurationSetTrackingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetTrackingOptionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate

        internal virtual UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomVerificationEmailTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReceiptRule

        internal virtual UpdateReceiptRuleResponse UpdateReceiptRule(UpdateReceiptRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateReceiptRuleResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReceiptRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReceiptRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReceiptRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTemplate

        internal virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyDomainDkim

        internal virtual VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyDomainDkimRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainDkimResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyDomainDkimRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDomainDkimResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyDomainIdentity

        internal virtual VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainIdentityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyDomainIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDomainIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyEmailAddress

        internal virtual VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailAddressResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyEmailAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyEmailAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyEmailIdentity

        internal virtual VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailIdentityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyEmailIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}