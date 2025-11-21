/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleEmailV2.Model;
using Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations;
using Amazon.SimpleEmailV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SimpleEmailV2
{
    /// <summary>
    /// <para>Implementation for accessing SimpleEmailServiceV2</para>
    ///
    /// Amazon SES API v2 
    /// <para>
    ///  <a href="http://aws.amazon.com/ses">Amazon SES</a> is an Amazon Web Services service
    /// that you can use to send email messages to your customers.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon SES API v2, you might find it helpful to review the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/">Amazon
    /// Simple Email Service Developer Guide</a>. The <i>Amazon SES Developer Guide</i> provides
    /// information and code samples that demonstrate how to use Amazon SES API v2 features
    /// programmatically.
    /// </para>
    /// </summary>
    public partial class AmazonSimpleEmailServiceV2Client : AmazonServiceClient, IAmazonSimpleEmailServiceV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleEmailServiceV2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceV2Client()
            : base(new AmazonSimpleEmailServiceV2Config()) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceV2Client(RegionEndpoint region)
            : base(new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(AmazonSimpleEmailServiceV2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Credentials and an
        /// AmazonSimpleEmailServiceV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(AWSCredentials credentials, AmazonSimpleEmailServiceV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceV2Client Configuration Object</param>
        public AmazonSimpleEmailServiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleEmailServiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISimpleEmailV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimpleEmailV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimpleEmailV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimpleEmailServiceV2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimpleEmailServiceV2AuthSchemeHandler());
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


        #region  BatchGetMetricData

        internal virtual BatchGetMetricDataResponse BatchGetMetricData(BatchGetMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMetricDataResponseUnmarshaller.Instance;

            return Invoke<BatchGetMetricDataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves batches of metric data collected based on your sending activity.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than 16 times per second, and with at most
        /// 160 queries from the batches per second (cumulative).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMetricData service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InternalServiceErrorException">
        /// The request couldn't be processed because an error occurred with the Amazon SES API
        /// v2.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/BatchGetMetricData">REST API Reference for BatchGetMetricData Operation</seealso>
        public virtual Task<BatchGetMetricDataResponse> BatchGetMetricDataAsync(BatchGetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelExportJob

        internal virtual CancelExportJobResponse CancelExportJob(CancelExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportJobResponseUnmarshaller.Instance;

            return Invoke<CancelExportJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CancelExportJob">REST API Reference for CancelExportJob Operation</seealso>
        public virtual Task<CancelExportJobResponse> CancelExportJobAsync(CancelExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfigurationSet

        internal virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
        }



        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails that you send. You apply a configuration set to an email by
        /// specifying the name of the configuration set when you call the Amazon SES API v2.
        /// When you apply a configuration set to an email, all of the rules in that configuration
        /// set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfigurationSetEventDestination

        internal virtual CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Create an event destination. <i>Events</i> include message sends, deliveries, opens,
        /// clicks, bounces, and complaints. <i>Event destinations</i> are places that you can
        /// send information about these events to. For example, you can send event data to Amazon
        /// EventBridge and associate a rule to send the event to the specified target.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContact

        internal virtual CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return Invoke<CreateContactResponse>(request, options);
        }



        /// <summary>
        /// Creates a contact, which is an end-user who is receiving the email, and adds them
        /// to a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual Task<CreateContactResponse> CreateContactAsync(CreateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContactList

        internal virtual CreateContactListResponse CreateContactList(CreateContactListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactListResponseUnmarshaller.Instance;

            return Invoke<CreateContactListResponse>(request, options);
        }



        /// <summary>
        /// Creates a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContactList">REST API Reference for CreateContactList Operation</seealso>
        public virtual Task<CreateContactListResponse> CreateContactListAsync(CreateContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContactListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCustomVerificationEmailTemplate

        internal virtual CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateCustomVerificationEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<CreateCustomVerificationEmailTemplateResponse> CreateCustomVerificationEmailTemplateAsync(CreateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDedicatedIpPool

        internal virtual CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<CreateDedicatedIpPoolResponse>(request, options);
        }



        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your Amazon Web Services account. You can associate
        /// a pool with a configuration set. When you send an email that uses that configuration
        /// set, the message is sent from one of the addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        public virtual Task<CreateDedicatedIpPoolResponse> CreateDedicatedIpPoolAsync(CreateDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDedicatedIpPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeliverabilityTestReport

        internal virtual CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<CreateDeliverabilityTestReportResponse>(request, options);
        }



        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// SES then sends that message to special email addresses spread across several major
        /// email providers. After about 24 hours, the test is complete, and you can use the <c>GetDeliverabilityTestReport</c>
        /// operation to view the results of the test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        public virtual Task<CreateDeliverabilityTestReportResponse> CreateDeliverabilityTestReportAsync(CreateDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEmailIdentity

        internal virtual CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<CreateEmailIdentityResponse>(request, options);
        }



        /// <summary>
        /// Starts the process of verifying an email identity. An <i>identity</i> is an email
        /// address or domain that you use when you send email. Before you can use an identity
        /// to send email, you first have to verify it. By verifying an identity, you demonstrate
        /// that you're the owner of the identity, and that you've given Amazon SES API v2 permission
        /// to send email from the identity.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon SES sends an email to the address. Your email
        /// address is verified as soon as you follow the link in the verification email. 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain without specifying the <c>DkimSigningAttributes</c> object,
        /// this operation provides a set of DKIM tokens. You can convert these tokens into CNAME
        /// records, which you then add to the DNS configuration for your domain. Your domain
        /// is verified when Amazon SES detects these records in the DNS configuration for your
        /// domain. This verification method is known as <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can perform the verification process by providing your own public-private
        /// key pair. This verification method is known as Bring Your Own DKIM (BYODKIM). To use
        /// BYODKIM, your call to the <c>CreateEmailIdentity</c> operation has to include the
        /// <c>DkimSigningAttributes</c> object. When you specify this object, you provide a selector
        /// (a component of the DNS record name that identifies the public key to use for DKIM
        /// authentication) and a private key.
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain, this operation provides a set of DKIM tokens, which you
        /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
        /// for your domain. Your domain is verified when Amazon SES detects these records in
        /// the DNS configuration for your domain. For some DNS providers, it can take 72 hours
        /// or more to complete the domain verification process.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can associate an existing configuration set with the email identity
        /// that you're verifying.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        public virtual Task<CreateEmailIdentityResponse> CreateEmailIdentityAsync(CreateEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEmailIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEmailIdentityPolicy

        internal virtual CreateEmailIdentityPolicyResponse CreateEmailIdentityPolicy(CreateEmailIdentityPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateEmailIdentityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified sending authorization policy for the given identity (an email
        /// address or a domain).
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentityPolicy">REST API Reference for CreateEmailIdentityPolicy Operation</seealso>
        public virtual Task<CreateEmailIdentityPolicyResponse> CreateEmailIdentityPolicyAsync(CreateEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEmailIdentityPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEmailTemplate

        internal virtual CreateEmailTemplateResponse CreateEmailTemplate(CreateEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        public virtual Task<CreateEmailTemplateResponse> CreateEmailTemplateAsync(CreateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateExportJob

        internal virtual CreateExportJobResponse CreateExportJob(CreateExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an export job for a data source and destination.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        public virtual Task<CreateExportJobResponse> CreateExportJobAsync(CreateExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateImportJob

        internal virtual CreateImportJobResponse CreateImportJob(CreateImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an import job for a data destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        public virtual Task<CreateImportJobResponse> CreateImportJobAsync(CreateImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMultiRegionEndpoint

        internal virtual CreateMultiRegionEndpointResponse CreateMultiRegionEndpoint(CreateMultiRegionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiRegionEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateMultiRegionEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a multi-region endpoint (global-endpoint).
        /// 
        ///  
        /// <para>
        /// The primary region is going to be the AWS-Region where the operation is executed.
        /// The secondary region has to be provided in request's parameters. From the data flow
        /// standpoint there is no difference between primary and secondary regions - sending
        /// traffic will be split equally between the two. The primary region is the region where
        /// the resource has been created and where it can be managed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateMultiRegionEndpoint">REST API Reference for CreateMultiRegionEndpoint Operation</seealso>
        public virtual Task<CreateMultiRegionEndpointResponse> CreateMultiRegionEndpointAsync(CreateMultiRegionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiRegionEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMultiRegionEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTenant

        internal virtual CreateTenantResponse CreateTenant(CreateTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantResponseUnmarshaller.Instance;

            return Invoke<CreateTenantResponse>(request, options);
        }



        /// <summary>
        /// Create a tenant.
        /// 
        ///  
        /// <para>
        ///  <i>Tenants</i> are logical containers that group related SES resources together.
        /// Each tenant can have its own set of resources like email identities, configuration
        /// sets, and templates, along with reputation metrics and sending status. This helps
        /// isolate and manage email sending for different customers or business units within
        /// your Amazon SES API v2 account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenant">REST API Reference for CreateTenant Operation</seealso>
        public virtual Task<CreateTenantResponse> CreateTenantAsync(CreateTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTenantResourceAssociation

        internal virtual CreateTenantResourceAssociationResponse CreateTenantResourceAssociation(CreateTenantResourceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateTenantResourceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Associate a resource with a tenant.
        /// 
        ///  
        /// <para>
        ///  <i>Resources</i> can be email identities, configuration sets, or email templates.
        /// When you associate a resource with a tenant, you can use that resource when sending
        /// emails on behalf of that tenant.
        /// </para>
        ///  
        /// <para>
        /// A single resource can be associated with multiple tenants, allowing for resource sharing
        /// across different tenants while maintaining isolation in email sending operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenantResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTenantResourceAssociation service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenantResourceAssociation">REST API Reference for CreateTenantResourceAssociation Operation</seealso>
        public virtual Task<CreateTenantResourceAssociationResponse> CreateTenantResourceAssociationAsync(CreateTenantResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantResourceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTenantResourceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
        }



        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationSetEventDestination

        internal virtual DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        public virtual Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContact

        internal virtual DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return Invoke<DeleteContactResponse>(request, options);
        }



        /// <summary>
        /// Removes a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContactList

        internal virtual DeleteContactListResponse DeleteContactList(DeleteContactListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactListResponseUnmarshaller.Instance;

            return Invoke<DeleteContactListResponse>(request, options);
        }



        /// <summary>
        /// Deletes a contact list and all of the contacts on that list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContactList">REST API Reference for DeleteContactList Operation</seealso>
        public virtual Task<DeleteContactListResponse> DeleteContactListAsync(DeleteContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContactListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate

        internal virtual DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomVerificationEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<DeleteCustomVerificationEmailTemplateResponse> DeleteCustomVerificationEmailTemplateAsync(DeleteCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDedicatedIpPool

        internal virtual DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteDedicatedIpPoolResponse>(request, options);
        }



        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        public virtual Task<DeleteDedicatedIpPoolResponse> DeleteDedicatedIpPoolAsync(DeleteDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDedicatedIpPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEmailIdentity

        internal virtual DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailIdentityResponse>(request, options);
        }



        /// <summary>
        /// Deletes an email identity. An identity can be either an email address or a domain
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        public virtual Task<DeleteEmailIdentityResponse> DeleteEmailIdentityAsync(DeleteEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEmailIdentityPolicy

        internal virtual DeleteEmailIdentityPolicyResponse DeleteEmailIdentityPolicy(DeleteEmailIdentityPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailIdentityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (an email
        /// address or a domain). This API returns successfully even if a policy with the specified
        /// name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentityPolicy">REST API Reference for DeleteEmailIdentityPolicy Operation</seealso>
        public virtual Task<DeleteEmailIdentityPolicyResponse> DeleteEmailIdentityPolicyAsync(DeleteEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailIdentityPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEmailTemplate

        internal virtual DeleteEmailTemplateResponse DeleteEmailTemplate(DeleteEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an email template.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        public virtual Task<DeleteEmailTemplateResponse> DeleteEmailTemplateAsync(DeleteEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMultiRegionEndpoint

        internal virtual DeleteMultiRegionEndpointResponse DeleteMultiRegionEndpoint(DeleteMultiRegionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiRegionEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteMultiRegionEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a multi-region endpoint (global-endpoint).
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed can be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteMultiRegionEndpoint">REST API Reference for DeleteMultiRegionEndpoint Operation</seealso>
        public virtual Task<DeleteMultiRegionEndpointResponse> DeleteMultiRegionEndpointAsync(DeleteMultiRegionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiRegionEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMultiRegionEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSuppressedDestination

        internal virtual DeleteSuppressedDestinationResponse DeleteSuppressedDestination(DeleteSuppressedDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteSuppressedDestinationResponse>(request, options);
        }



        /// <summary>
        /// Removes an email address from the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        public virtual Task<DeleteSuppressedDestinationResponse> DeleteSuppressedDestinationAsync(DeleteSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSuppressedDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSuppressedDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTenant

        internal virtual DeleteTenantResponse DeleteTenant(DeleteTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantResponseUnmarshaller.Instance;

            return Invoke<DeleteTenantResponse>(request, options);
        }



        /// <summary>
        /// Delete an existing tenant.
        /// 
        ///  
        /// <para>
        /// When you delete a tenant, its associations with resources are removed, but the resources
        /// themselves are not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenant">REST API Reference for DeleteTenant Operation</seealso>
        public virtual Task<DeleteTenantResponse> DeleteTenantAsync(DeleteTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTenantResourceAssociation

        internal virtual DeleteTenantResourceAssociationResponse DeleteTenantResourceAssociation(DeleteTenantResourceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteTenantResourceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Delete an association between a tenant and a resource.
        /// 
        ///  
        /// <para>
        /// When you delete a tenant-resource association, the resource itself is not deleted,
        /// only its association with the specific tenant is removed. After removal, the resource
        /// will no longer be available for use with that tenant's email sending operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenantResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTenantResourceAssociation service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenantResourceAssociation">REST API Reference for DeleteTenantResourceAssociation Operation</seealso>
        public virtual Task<DeleteTenantResourceAssociationResponse> DeleteTenantResourceAssociationAsync(DeleteTenantResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantResourceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTenantResourceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccount

        internal virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountResponse>(request, options);
        }



        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// SES account in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBlacklistReports

        internal virtual GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return Invoke<GetBlacklistReportsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        public virtual Task<GetBlacklistReportsResponse> GetBlacklistReportsAsync(GetBlacklistReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlacklistReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlacklistReportsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlacklistReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationSet

        internal virtual GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetResponse>(request, options);
        }



        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        public virtual Task<GetConfigurationSetResponse> GetConfigurationSetAsync(GetConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationSetEventDestinations

        internal virtual GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationSetEventDestinationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        public virtual Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationSetEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationSetEventDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationSetEventDestinationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContact

        internal virtual GetContactResponse GetContact(GetContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return Invoke<GetContactResponse>(request, options);
        }



        /// <summary>
        /// Returns a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual Task<GetContactResponse> GetContactAsync(GetContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetContactList

        internal virtual GetContactListResponse GetContactList(GetContactListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactListResponseUnmarshaller.Instance;

            return Invoke<GetContactListResponse>(request, options);
        }



        /// <summary>
        /// Returns contact list metadata. It does not return any information about the contacts
        /// present in the list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContactList">REST API Reference for GetContactList Operation</seealso>
        public virtual Task<GetContactListResponse> GetContactListAsync(GetContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactListResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCustomVerificationEmailTemplate

        internal virtual GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCustomVerificationEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<GetCustomVerificationEmailTemplateResponse> GetCustomVerificationEmailTemplateAsync(GetCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDedicatedIp

        internal virtual GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpResponse>(request, options);
        }



        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        public virtual Task<GetDedicatedIpResponse> GetDedicatedIpAsync(GetDedicatedIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDedicatedIpPool

        internal virtual GetDedicatedIpPoolResponse GetDedicatedIpPool(GetDedicatedIpPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpPoolResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpPoolResponse>(request, options);
        }



        /// <summary>
        /// Retrieve information about the dedicated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIpPool">REST API Reference for GetDedicatedIpPool Operation</seealso>
        public virtual Task<GetDedicatedIpPoolResponse> GetDedicatedIpPoolAsync(GetDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpPoolResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDedicatedIps

        internal virtual GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return Invoke<GetDedicatedIpsResponse>(request, options);
        }



        /// <summary>
        /// List the dedicated IP addresses that are associated with your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        public virtual Task<GetDedicatedIpsResponse> GetDedicatedIpsAsync(GetDedicatedIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDedicatedIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDedicatedIpsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDedicatedIpsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeliverabilityDashboardOptions

        internal virtual GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityDashboardOptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve information about the status of the Deliverability dashboard for your account.
        /// When the Deliverability dashboard is enabled, you gain access to reputation, deliverability,
        /// and other metrics for the domains that you use to send email. You also gain the ability
        /// to perform predictive inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other Amazon
        /// Web Services services. For more information about the features and cost of a Deliverability
        /// dashboard subscription, see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES
        /// Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        public virtual Task<GetDeliverabilityDashboardOptionsResponse> GetDeliverabilityDashboardOptionsAsync(GetDeliverabilityDashboardOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityDashboardOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityDashboardOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityDashboardOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeliverabilityTestReport

        internal virtual GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return Invoke<GetDeliverabilityTestReportResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        public virtual Task<GetDeliverabilityTestReportResponse> GetDeliverabilityTestReportAsync(GetDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeliverabilityTestReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverabilityTestReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeliverabilityTestReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomainDeliverabilityCampaign

        internal virtual GetDomainDeliverabilityCampaignResponse GetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainDeliverabilityCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDeliverabilityCampaignResponseUnmarshaller.Instance;

            return Invoke<GetDomainDeliverabilityCampaignResponse>(request, options);
        }



        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainDeliverabilityCampaign service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        public virtual Task<GetDomainDeliverabilityCampaignResponse> GetDomainDeliverabilityCampaignAsync(GetDomainDeliverabilityCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainDeliverabilityCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDeliverabilityCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainDeliverabilityCampaignResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomainStatisticsReport

        internal virtual GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return Invoke<GetDomainStatisticsReportResponse>(request, options);
        }



        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        public virtual Task<GetDomainStatisticsReportResponse> GetDomainStatisticsReportAsync(GetDomainStatisticsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainStatisticsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainStatisticsReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainStatisticsReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEmailIdentity

        internal virtual GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<GetEmailIdentityResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a specific identity, including the identity's verification
        /// status, sending authorization policies, its DKIM authentication status, and its custom
        /// Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        public virtual Task<GetEmailIdentityResponse> GetEmailIdentityAsync(GetEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEmailIdentityPolicies

        internal virtual GetEmailIdentityPoliciesResponse GetEmailIdentityPolicies(GetEmailIdentityPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityPoliciesResponseUnmarshaller.Instance;

            return Invoke<GetEmailIdentityPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (an email
        /// address or a domain). The policies are returned as a map of policy names to policy
        /// contents. You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailIdentityPolicies service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentityPolicies">REST API Reference for GetEmailIdentityPolicies Operation</seealso>
        public virtual Task<GetEmailIdentityPoliciesResponse> GetEmailIdentityPoliciesAsync(GetEmailIdentityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailIdentityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailIdentityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailIdentityPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEmailTemplate

        internal virtual GetEmailTemplateResponse GetEmailTemplate(GetEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Displays the template object (which includes the subject line, HTML part and text
        /// part) for the template you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        public virtual Task<GetEmailTemplateResponse> GetEmailTemplateAsync(GetEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetExportJob

        internal virtual GetExportJobResponse GetExportJob(GetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information about an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        public virtual Task<GetExportJobResponse> GetExportJobAsync(GetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetImportJob

        internal virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information about an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMessageInsights

        internal virtual GetMessageInsightsResponse GetMessageInsights(GetMessageInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageInsightsResponseUnmarshaller.Instance;

            return Invoke<GetMessageInsightsResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a specific message, including the from address, the subject,
        /// the recipient address, email tags, as well as events associated with the message.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessageInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMessageInsights service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMessageInsights">REST API Reference for GetMessageInsights Operation</seealso>
        public virtual Task<GetMessageInsightsResponse> GetMessageInsightsAsync(GetMessageInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMessageInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessageInsightsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMessageInsightsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMultiRegionEndpoint

        internal virtual GetMultiRegionEndpointResponse GetMultiRegionEndpoint(GetMultiRegionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMultiRegionEndpointResponse>(request, options);
        }



        /// <summary>
        /// Displays the multi-region endpoint (global-endpoint) configuration.
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed can be displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMultiRegionEndpoint">REST API Reference for GetMultiRegionEndpoint Operation</seealso>
        public virtual Task<GetMultiRegionEndpointResponse> GetMultiRegionEndpointAsync(GetMultiRegionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMultiRegionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetMultiRegionEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReputationEntity

        internal virtual GetReputationEntityResponse GetReputationEntity(GetReputationEntityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReputationEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReputationEntityResponseUnmarshaller.Instance;

            return Invoke<GetReputationEntityResponse>(request, options);
        }



        /// <summary>
        /// Retrieve information about a specific reputation entity, including its reputation
        /// management policy, customer-managed status, Amazon Web Services Amazon SES-managed
        /// status, and aggregate sending status.
        /// 
        ///  
        /// <para>
        ///  <i>Reputation entities</i> represent resources in your Amazon SES account that have
        /// reputation tracking and management capabilities. The reputation impact reflects the
        /// highest impact reputation finding for the entity. Reputation findings can be retrieved
        /// using the <c>ListRecommendations</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReputationEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReputationEntity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetReputationEntity">REST API Reference for GetReputationEntity Operation</seealso>
        public virtual Task<GetReputationEntityResponse> GetReputationEntityAsync(GetReputationEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReputationEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReputationEntityResponseUnmarshaller.Instance;

            return InvokeAsync<GetReputationEntityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSuppressedDestination

        internal virtual GetSuppressedDestinationResponse GetSuppressedDestination(GetSuppressedDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<GetSuppressedDestinationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specific email address that's on the suppression list
        /// for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        public virtual Task<GetSuppressedDestinationResponse> GetSuppressedDestinationAsync(GetSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSuppressedDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSuppressedDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTenant

        internal virtual GetTenantResponse GetTenant(GetTenantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTenantResponseUnmarshaller.Instance;

            return Invoke<GetTenantResponse>(request, options);
        }



        /// <summary>
        /// Get information about a specific tenant, including the tenant's name, ID, ARN, creation
        /// timestamp, tags, and sending status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTenant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetTenant">REST API Reference for GetTenant Operation</seealso>
        public virtual Task<GetTenantResponse> GetTenantAsync(GetTenantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTenantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTenantResponseUnmarshaller.Instance;

            return InvokeAsync<GetTenantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationSets

        internal virtual ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationSetsResponse>(request, options);
        }



        /// <summary>
        /// List all of the configuration sets associated with your account in the current region.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        public virtual Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContactLists

        internal virtual ListContactListsResponse ListContactLists(ListContactListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContactListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactListsResponseUnmarshaller.Instance;

            return Invoke<ListContactListsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the contact lists available.
        /// 
        ///  
        /// <para>
        /// If your output includes a "NextToken" field with a string value, this indicates there
        /// may be additional contacts on the filtered list - regardless of the number of contacts
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactLists service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContactLists">REST API Reference for ListContactLists Operation</seealso>
        public virtual Task<ListContactListsResponse> ListContactListsAsync(ListContactListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContactListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContactListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContacts

        internal virtual ListContactsResponse ListContacts(ListContactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return Invoke<ListContactsResponse>(request, options);
        }



        /// <summary>
        /// Lists the contacts present in a specific contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContacts">REST API Reference for ListContacts Operation</seealso>
        public virtual Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContactsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCustomVerificationEmailTemplates

        internal virtual ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListCustomVerificationEmailTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomVerificationEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        public virtual Task<ListCustomVerificationEmailTemplatesResponse> ListCustomVerificationEmailTemplatesAsync(ListCustomVerificationEmailTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomVerificationEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomVerificationEmailTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDedicatedIpPools

        internal virtual ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return Invoke<ListDedicatedIpPoolsResponse>(request, options);
        }



        /// <summary>
        /// List all of the dedicated IP pools that exist in your Amazon Web Services account
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        public virtual Task<ListDedicatedIpPoolsResponse> ListDedicatedIpPoolsAsync(ListDedicatedIpPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDedicatedIpPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDedicatedIpPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDedicatedIpPoolsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeliverabilityTestReports

        internal virtual ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return Invoke<ListDeliverabilityTestReportsResponse>(request, options);
        }



        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <c>GetDeliverabilityTestReport</c> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        public virtual Task<ListDeliverabilityTestReportsResponse> ListDeliverabilityTestReportsAsync(ListDeliverabilityTestReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeliverabilityTestReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeliverabilityTestReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeliverabilityTestReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainDeliverabilityCampaigns

        internal virtual ListDomainDeliverabilityCampaignsResponse ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainDeliverabilityCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainDeliverabilityCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListDomainDeliverabilityCampaignsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainDeliverabilityCampaigns service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        public virtual Task<ListDomainDeliverabilityCampaignsResponse> ListDomainDeliverabilityCampaignsAsync(ListDomainDeliverabilityCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainDeliverabilityCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainDeliverabilityCampaignsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainDeliverabilityCampaignsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEmailIdentities

        internal virtual ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListEmailIdentitiesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all of the email identities that are associated with your Amazon
        /// Web Services account. An identity can be either an email address or a domain. This
        /// operation returns identities that are verified as well as those that aren't. This
        /// operation returns identities that are associated with Amazon SES and Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        public virtual Task<ListEmailIdentitiesResponse> ListEmailIdentitiesAsync(ListEmailIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEmailIdentitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEmailTemplates

        internal virtual ListEmailTemplatesResponse ListEmailTemplates(ListEmailTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListEmailTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailTemplates">REST API Reference for ListEmailTemplates Operation</seealso>
        public virtual Task<ListEmailTemplatesResponse> ListEmailTemplatesAsync(ListEmailTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEmailTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEmailTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEmailTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExportJobs

        internal virtual ListExportJobsResponse ListExportJobs(ListExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExportJobs service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListExportJobs">REST API Reference for ListExportJobs Operation</seealso>
        public virtual Task<ListExportJobsResponse> ListExportJobsAsync(ListExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImportJobs

        internal virtual ListImportJobsResponse ListImportJobs(ListImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        public virtual Task<ListImportJobsResponse> ListImportJobsAsync(ListImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMultiRegionEndpoints

        internal virtual ListMultiRegionEndpointsResponse ListMultiRegionEndpoints(ListMultiRegionEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultiRegionEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiRegionEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListMultiRegionEndpointsResponse>(request, options);
        }



        /// <summary>
        /// List the multi-region endpoints (global-endpoints).
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed will be listed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultiRegionEndpoints service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListMultiRegionEndpoints">REST API Reference for ListMultiRegionEndpoints Operation</seealso>
        public virtual Task<ListMultiRegionEndpointsResponse> ListMultiRegionEndpointsAsync(ListMultiRegionEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultiRegionEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiRegionEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultiRegionEndpointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommendations

        internal virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the recommendations present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReputationEntities

        internal virtual ListReputationEntitiesResponse ListReputationEntities(ListReputationEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReputationEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReputationEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListReputationEntitiesResponse>(request, options);
        }



        /// <summary>
        /// List reputation entities in your Amazon SES account in the current Amazon Web Services
        /// Region. You can filter the results by entity type, reputation impact, sending status,
        /// or entity reference prefix.
        /// 
        ///  
        /// <para>
        ///  <i>Reputation entities</i> represent resources in your account that have reputation
        /// tracking and management capabilities. Use this operation to get an overview of all
        /// entities and their current reputation status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReputationEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReputationEntities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListReputationEntities">REST API Reference for ListReputationEntities Operation</seealso>
        public virtual Task<ListReputationEntitiesResponse> ListReputationEntitiesAsync(ListReputationEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReputationEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReputationEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListReputationEntitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceTenants

        internal virtual ListResourceTenantsResponse ListResourceTenants(ListResourceTenantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTenantsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTenantsResponse>(request, options);
        }



        /// <summary>
        /// List all tenants associated with a specific resource.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of tenants that are associated with the specified resource.
        /// This is useful for understanding which tenants are currently using a particular resource
        /// such as an email identity, configuration set, or email template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTenants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTenants service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListResourceTenants">REST API Reference for ListResourceTenants Operation</seealso>
        public virtual Task<ListResourceTenantsResponse> ListResourceTenantsAsync(ListResourceTenantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTenantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTenantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSuppressedDestinations

        internal virtual ListSuppressedDestinationsResponse ListSuppressedDestinations(ListSuppressedDestinationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuppressedDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuppressedDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListSuppressedDestinationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of email addresses that are on the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuppressedDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InvalidNextTokenException">
        /// The specified request includes an invalid or expired token.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        public virtual Task<ListSuppressedDestinationsResponse> ListSuppressedDestinationsAsync(ListSuppressedDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSuppressedDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuppressedDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuppressedDestinationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// resource. A <i>tag</i> is a label that you optionally define and associate with a
        /// resource. Each tag consists of a required <i>tag key</i> and an optional associated <i>tag
        /// value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTenantResources

        internal virtual ListTenantResourcesResponse ListTenantResources(ListTenantResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTenantResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTenantResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTenantResourcesResponse>(request, options);
        }



        /// <summary>
        /// List all resources associated with a specific tenant.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of resources (email identities, configuration sets,
        /// or email templates) that are associated with the specified tenant. You can optionally
        /// filter the results by resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTenantResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTenantResources service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenantResources">REST API Reference for ListTenantResources Operation</seealso>
        public virtual Task<ListTenantResourcesResponse> ListTenantResourcesAsync(ListTenantResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTenantResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTenantResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTenantResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTenants

        internal virtual ListTenantsResponse ListTenants(ListTenantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTenantsResponseUnmarshaller.Instance;

            return Invoke<ListTenantsResponse>(request, options);
        }



        /// <summary>
        /// List all tenants associated with your account in the current Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// This operation returns basic information about each tenant, such as tenant name, ID,
        /// ARN, and creation timestamp.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTenants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTenants service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenants">REST API Reference for ListTenants Operation</seealso>
        public virtual Task<ListTenantsResponse> ListTenantsAsync(ListTenantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTenantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTenantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTenantsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes

        internal virtual PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountDedicatedIpWarmupAttributesResponse>(request, options);
        }



        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        public virtual Task<PutAccountDedicatedIpWarmupAttributesResponse> PutAccountDedicatedIpWarmupAttributesAsync(PutAccountDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountDetails

        internal virtual PutAccountDetailsResponse PutAccountDetails(PutAccountDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDetailsResponseUnmarshaller.Instance;

            return Invoke<PutAccountDetailsResponse>(request, options);
        }



        /// <summary>
        /// Update your Amazon SES account details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountDetails service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDetails">REST API Reference for PutAccountDetails Operation</seealso>
        public virtual Task<PutAccountDetailsResponse> PutAccountDetailsAsync(PutAccountDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountSendingAttributes

        internal virtual PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSendingAttributesResponse>(request, options);
        }



        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        public virtual Task<PutAccountSendingAttributesResponse> PutAccountSendingAttributesAsync(PutAccountSendingAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSendingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSendingAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountSendingAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountSuppressionAttributes

        internal virtual PutAccountSuppressionAttributesResponse PutAccountSuppressionAttributes(PutAccountSuppressionAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSuppressionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSuppressionAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountSuppressionAttributesResponse>(request, options);
        }



        /// <summary>
        /// Change the settings for the account-level suppression list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSuppressionAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        public virtual Task<PutAccountSuppressionAttributesResponse> PutAccountSuppressionAttributesAsync(PutAccountSuppressionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSuppressionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSuppressionAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountSuppressionAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountVdmAttributes

        internal virtual PutAccountVdmAttributesResponse PutAccountVdmAttributes(PutAccountVdmAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountVdmAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountVdmAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAccountVdmAttributesResponse>(request, options);
        }



        /// <summary>
        /// Update your Amazon SES account VDM attributes.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountVdmAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountVdmAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountVdmAttributes">REST API Reference for PutAccountVdmAttributes Operation</seealso>
        public virtual Task<PutAccountVdmAttributesResponse> PutAccountVdmAttributesAsync(PutAccountVdmAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountVdmAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountVdmAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountVdmAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetArchivingOptions

        internal virtual PutConfigurationSetArchivingOptionsResponse PutConfigurationSetArchivingOptions(PutConfigurationSetArchivingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetArchivingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetArchivingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetArchivingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Associate the configuration set with a MailManager archive. When you send email using
        /// the <c>SendEmail</c> or <c>SendBulkEmail</c> operations the message as it will be
        /// given to the receiving SMTP server will be archived, along with the recipient information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetArchivingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetArchivingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetArchivingOptions">REST API Reference for PutConfigurationSetArchivingOptions Operation</seealso>
        public virtual Task<PutConfigurationSetArchivingOptionsResponse> PutConfigurationSetArchivingOptionsAsync(PutConfigurationSetArchivingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetArchivingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetArchivingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetArchivingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetDeliveryOptions

        internal virtual PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetDeliveryOptionsResponse>(request, options);
        }



        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        public virtual Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetDeliveryOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetDeliveryOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetDeliveryOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetReputationOptions

        internal virtual PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetReputationOptionsResponse>(request, options);
        }



        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        public virtual Task<PutConfigurationSetReputationOptionsResponse> PutConfigurationSetReputationOptionsAsync(PutConfigurationSetReputationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetReputationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetReputationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetReputationOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetSendingOptions

        internal virtual PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSendingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        public virtual Task<PutConfigurationSetSendingOptionsResponse> PutConfigurationSetSendingOptionsAsync(PutConfigurationSetSendingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSendingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSendingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetSendingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetSuppressionOptions

        internal virtual PutConfigurationSetSuppressionOptionsResponse PutConfigurationSetSuppressionOptions(PutConfigurationSetSuppressionOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSuppressionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSuppressionOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetSuppressionOptionsResponse>(request, options);
        }



        /// <summary>
        /// Specify the account suppression list preferences for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetSuppressionOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        public virtual Task<PutConfigurationSetSuppressionOptionsResponse> PutConfigurationSetSuppressionOptionsAsync(PutConfigurationSetSuppressionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetSuppressionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetSuppressionOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetSuppressionOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetTrackingOptions

        internal virtual PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetTrackingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        public virtual Task<PutConfigurationSetTrackingOptionsResponse> PutConfigurationSetTrackingOptionsAsync(PutConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetTrackingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetTrackingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetTrackingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutConfigurationSetVdmOptions

        internal virtual PutConfigurationSetVdmOptionsResponse PutConfigurationSetVdmOptions(PutConfigurationSetVdmOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetVdmOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetVdmOptionsResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationSetVdmOptionsResponse>(request, options);
        }



        /// <summary>
        /// Specify VDM preferences for email that you send using the configuration set.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetVdmOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationSetVdmOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetVdmOptions">REST API Reference for PutConfigurationSetVdmOptions Operation</seealso>
        public virtual Task<PutConfigurationSetVdmOptionsResponse> PutConfigurationSetVdmOptionsAsync(PutConfigurationSetVdmOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutConfigurationSetVdmOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationSetVdmOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfigurationSetVdmOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDedicatedIpInPool

        internal virtual PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpInPoolResponse>(request, options);
        }



        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <c>CreateDedicatedIpPool</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        public virtual Task<PutDedicatedIpInPoolResponse> PutDedicatedIpInPoolAsync(PutDedicatedIpInPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpInPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpInPoolResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpInPoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDedicatedIpPoolScalingAttributes

        internal virtual PutDedicatedIpPoolScalingAttributesResponse PutDedicatedIpPoolScalingAttributes(PutDedicatedIpPoolScalingAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpPoolScalingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpPoolScalingAttributesResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpPoolScalingAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to convert a dedicated IP pool to a different scaling mode.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>MANAGED</c> pools cannot be converted to <c>STANDARD</c> scaling mode.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpPoolScalingAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDedicatedIpPoolScalingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpPoolScalingAttributes">REST API Reference for PutDedicatedIpPoolScalingAttributes Operation</seealso>
        public virtual Task<PutDedicatedIpPoolScalingAttributesResponse> PutDedicatedIpPoolScalingAttributesAsync(PutDedicatedIpPoolScalingAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpPoolScalingAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpPoolScalingAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpPoolScalingAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDedicatedIpWarmupAttributes

        internal virtual PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return Invoke<PutDedicatedIpWarmupAttributesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        public virtual Task<PutDedicatedIpWarmupAttributesResponse> PutDedicatedIpWarmupAttributesAsync(PutDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDedicatedIpWarmupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDedicatedIpWarmupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutDedicatedIpWarmupAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDeliverabilityDashboardOption

        internal virtual PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return Invoke<PutDeliverabilityDashboardOptionResponse>(request, options);
        }



        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation, deliverability, and other metrics for the
        /// domains that you use to send email. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other Amazon
        /// Web Services services. For more information about the features and cost of a Deliverability
        /// dashboard subscription, see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES
        /// Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        public virtual Task<PutDeliverabilityDashboardOptionResponse> PutDeliverabilityDashboardOptionAsync(PutDeliverabilityDashboardOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDeliverabilityDashboardOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverabilityDashboardOptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeliverabilityDashboardOptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEmailIdentityConfigurationSetAttributes

        internal virtual PutEmailIdentityConfigurationSetAttributesResponse PutEmailIdentityConfigurationSetAttributes(PutEmailIdentityConfigurationSetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityConfigurationSetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityConfigurationSetAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityConfigurationSetAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to associate a configuration set with an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityConfigurationSetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityConfigurationSetAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityConfigurationSetAttributes">REST API Reference for PutEmailIdentityConfigurationSetAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityConfigurationSetAttributesResponse> PutEmailIdentityConfigurationSetAttributesAsync(PutEmailIdentityConfigurationSetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityConfigurationSetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityConfigurationSetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityConfigurationSetAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEmailIdentityDkimAttributes

        internal virtual PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityDkimAttributesResponse> PutEmailIdentityDkimAttributesAsync(PutEmailIdentityDkimAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityDkimAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEmailIdentityDkimSigningAttributes

        internal virtual PutEmailIdentityDkimSigningAttributesResponse PutEmailIdentityDkimSigningAttributes(PutEmailIdentityDkimSigningAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimSigningAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimSigningAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityDkimSigningAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to configure or change the DKIM authentication settings for an email domain identity.
        /// You can use this operation to do any of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the signing attributes for an identity that uses Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the key length that should be used for Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using Easy DKIM to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using BYODKIM to using Easy DKIM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimSigningAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimSigningAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityDkimSigningAttributesResponse> PutEmailIdentityDkimSigningAttributesAsync(PutEmailIdentityDkimSigningAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityDkimSigningAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityDkimSigningAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityDkimSigningAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes

        internal virtual PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityFeedbackAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// If the value is <c>true</c>, you receive email notifications when bounce or complaint
        /// events occur. These notifications are sent to the address that you specified in the
        /// <c>Return-Path</c> header of the original email.
        /// </para>
        ///  
        /// <para>
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications (for example,
        /// by setting up an event destination), you receive an email notification when these
        /// events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityFeedbackAttributesResponse> PutEmailIdentityFeedbackAttributesAsync(PutEmailIdentityFeedbackAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityFeedbackAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityFeedbackAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityFeedbackAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEmailIdentityMailFromAttributes

        internal virtual PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return Invoke<PutEmailIdentityMailFromAttributesResponse>(request, options);
        }



        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        public virtual Task<PutEmailIdentityMailFromAttributesResponse> PutEmailIdentityMailFromAttributesAsync(PutEmailIdentityMailFromAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEmailIdentityMailFromAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEmailIdentityMailFromAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutEmailIdentityMailFromAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutSuppressedDestination

        internal virtual PutSuppressedDestinationResponse PutSuppressedDestination(PutSuppressedDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSuppressedDestinationResponseUnmarshaller.Instance;

            return Invoke<PutSuppressedDestinationResponse>(request, options);
        }



        /// <summary>
        /// Adds an email address to the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        public virtual Task<PutSuppressedDestinationResponse> PutSuppressedDestinationAsync(PutSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSuppressedDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSuppressedDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSuppressedDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendBulkEmail

        internal virtual SendBulkEmailResponse SendBulkEmail(SendBulkEmailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendBulkEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBulkEmailResponseUnmarshaller.Instance;

            return Invoke<SendBulkEmailResponse>(request, options);
        }



        /// <summary>
        /// Composes an email message to multiple destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBulkEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendBulkEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendBulkEmail">REST API Reference for SendBulkEmail Operation</seealso>
        public virtual Task<SendBulkEmailResponse> SendBulkEmailAsync(SendBulkEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendBulkEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendBulkEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendBulkEmailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendCustomVerificationEmail

        internal virtual SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return Invoke<SendCustomVerificationEmailResponse>(request, options);
        }



        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCustomVerificationEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        public virtual Task<SendCustomVerificationEmailResponse> SendCustomVerificationEmailAsync(SendCustomVerificationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCustomVerificationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCustomVerificationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendCustomVerificationEmailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendEmail

        internal virtual SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailResponse>(request, options);
        }



        /// <summary>
        /// Sends an email message. You can use the Amazon SES API v2 to send the following types
        /// of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon SES assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Templated</b> – A message that contains personalization tags. When you send this
        /// type of email, Amazon SES API v2 automatically replaces the tags with values that
        /// you specify.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        public virtual Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Add one or more tags (keys and values) to a specified resource. A <i>tag</i> is a
        /// label that you optionally define and associate with a resource. Tags can help you
        /// categorize and manage resources in different ways, such as by purpose, owner, environment,
        /// or other criteria. A resource can have as many as 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestRenderEmailTemplate

        internal virtual TestRenderEmailTemplateResponse TestRenderEmailTemplate(TestRenderEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRenderEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRenderEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<TestRenderEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a preview of the MIME content of an email when provided with a template and
        /// a set of replacement data.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRenderEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestRenderEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TestRenderEmailTemplate">REST API Reference for TestRenderEmailTemplate Operation</seealso>
        public virtual Task<TestRenderEmailTemplateResponse> TestRenderEmailTemplateAsync(TestRenderEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRenderEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRenderEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<TestRenderEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfigurationSetEventDestination

        internal virtual UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationSetEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        public virtual Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationSetEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationSetEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContact

        internal virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return Invoke<UpdateContactResponse>(request, options);
        }



        /// <summary>
        /// Updates a contact's preferences for a list.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify all existing topic preferences in the <c>TopicPreferences</c> object,
        /// not just the ones that need updating; otherwise, all your existing preferences will
        /// be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContactList

        internal virtual UpdateContactListResponse UpdateContactList(UpdateContactListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactListResponseUnmarshaller.Instance;

            return Invoke<UpdateContactListResponse>(request, options);
        }



        /// <summary>
        /// Updates contact list metadata. This operation does a complete replacement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContactList">REST API Reference for UpdateContactList Operation</seealso>
        public virtual Task<UpdateContactListResponse> UpdateContactListAsync(UpdateContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContactListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactListResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContactListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate

        internal virtual UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomVerificationEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        public virtual Task<UpdateCustomVerificationEmailTemplateResponse> UpdateCustomVerificationEmailTemplateAsync(UpdateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomVerificationEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomVerificationEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomVerificationEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEmailIdentityPolicy

        internal virtual UpdateEmailIdentityPolicyResponse UpdateEmailIdentityPolicy(UpdateEmailIdentityPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailIdentityPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailIdentityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified sending authorization policy for the given identity (an email
        /// address or a domain). This API returns successfully even if a policy with the specified
        /// name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailIdentityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailIdentityPolicy">REST API Reference for UpdateEmailIdentityPolicy Operation</seealso>
        public virtual Task<UpdateEmailIdentityPolicyResponse> UpdateEmailIdentityPolicyAsync(UpdateEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailIdentityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailIdentityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEmailIdentityPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEmailTemplate

        internal virtual UpdateEmailTemplateResponse UpdateEmailTemplate(UpdateEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        public virtual Task<UpdateEmailTemplateResponse> UpdateEmailTemplateAsync(UpdateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEmailTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateReputationEntityCustomerManagedStatus

        internal virtual UpdateReputationEntityCustomerManagedStatusResponse UpdateReputationEntityCustomerManagedStatus(UpdateReputationEntityCustomerManagedStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReputationEntityCustomerManagedStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReputationEntityCustomerManagedStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateReputationEntityCustomerManagedStatusResponse>(request, options);
        }



        /// <summary>
        /// Update the customer-managed sending status for a reputation entity. This allows you
        /// to enable, disable, or reinstate sending for the entity.
        /// 
        ///  
        /// <para>
        /// The customer-managed status works in conjunction with the Amazon Web Services Amazon
        /// SES-managed status to determine the overall sending capability. When you update the
        /// customer-managed status, the Amazon Web Services Amazon SES-managed status remains
        /// unchanged. If Amazon Web Services Amazon SES has disabled the entity, it will not
        /// be allowed to send regardless of the customer-managed status setting. When you reinstate
        /// an entity through the customer-managed status, it can continue sending only if the
        /// Amazon Web Services Amazon SES-managed status also permits sending, even if there
        /// are active reputation findings, until the findings are resolved or new violations
        /// occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityCustomerManagedStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReputationEntityCustomerManagedStatus service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityCustomerManagedStatus">REST API Reference for UpdateReputationEntityCustomerManagedStatus Operation</seealso>
        public virtual Task<UpdateReputationEntityCustomerManagedStatusResponse> UpdateReputationEntityCustomerManagedStatusAsync(UpdateReputationEntityCustomerManagedStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReputationEntityCustomerManagedStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReputationEntityCustomerManagedStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReputationEntityCustomerManagedStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateReputationEntityPolicy

        internal virtual UpdateReputationEntityPolicyResponse UpdateReputationEntityPolicy(UpdateReputationEntityPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReputationEntityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReputationEntityPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateReputationEntityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Update the reputation management policy for a reputation entity. The policy determines
        /// how the entity responds to reputation findings, such as automatically pausing sending
        /// when certain thresholds are exceeded.
        /// 
        ///  
        /// <para>
        /// Reputation management policies are Amazon Web Services Amazon SES-managed (predefined
        /// policies). You can select from none, standard, and strict policies.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReputationEntityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityPolicy">REST API Reference for UpdateReputationEntityPolicy Operation</seealso>
        public virtual Task<UpdateReputationEntityPolicyResponse> UpdateReputationEntityPolicyAsync(UpdateReputationEntityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReputationEntityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReputationEntityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReputationEntityPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}