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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MailManager.Model;
using Amazon.MailManager.Model.Internal.MarshallTransformations;
using Amazon.MailManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MailManager
{
    /// <summary>
    /// <para>Implementation for accessing MailManager</para>
    ///
    /// Amazon SES Mail Manager API 
    /// <para>
    /// The Amazon SES Mail Manager API contains operations and data types that comprise the
    /// Mail Manager feature of <a href="http://aws.amazon.com/ses">Amazon Simple Email Service
    /// (SES)</a>.
    /// 
    ///  
    /// <para>
    /// Mail Manager is a set of Amazon SES email gateway features designed to help you strengthen
    /// your organization's email infrastructure, simplify email workflow management, and
    /// streamline email compliance control. To learn more, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/eb.html">Mail
    /// Manager chapter</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonMailManagerClient : AmazonServiceClient, IAmazonMailManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonMailManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        public AmazonMailManagerClient()
            : base(new AmazonMailManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        public AmazonMailManagerClient(RegionEndpoint region)
            : base(new AmazonMailManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(AmazonMailManagerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMailManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMailManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials and an
        /// AmazonMailManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(AWSCredentials credentials, AmazonMailManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMailManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMailManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMailManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMailManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMailManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMailManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMailManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMailManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MailManagerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMailManagerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMailManagerAuthSchemeHandler());
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


        #region  CreateAddonInstance

        internal virtual CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateAddonInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates an Add On instance for the subscription indicated in the request. The resulting
        /// Amazon Resource Name (ARN) can be used in a conditional statement for a rule set or
        /// traffic policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        public virtual Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddonInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAddonSubscription

        internal virtual CreateAddonSubscriptionResponse CreateAddonSubscription(CreateAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateAddonSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscription for an Add On representing the acceptance of its terms of use
        /// and additional pricing. The subscription can then be used to create an instance for
        /// use in rule sets or traffic policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        public virtual Task<CreateAddonSubscriptionResponse> CreateAddonSubscriptionAsync(CreateAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddonSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAddressList

        internal virtual CreateAddressListResponse CreateAddressList(CreateAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListResponseUnmarshaller.Instance;

            return Invoke<CreateAddressListResponse>(request, options);
        }



        /// <summary>
        /// Creates a new address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressList">REST API Reference for CreateAddressList Operation</seealso>
        public virtual Task<CreateAddressListResponse> CreateAddressListAsync(CreateAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAddressListImportJob

        internal virtual CreateAddressListImportJobResponse CreateAddressListImportJob(CreateAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateAddressListImportJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressListImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressListImportJob">REST API Reference for CreateAddressListImportJob Operation</seealso>
        public virtual Task<CreateAddressListImportJobResponse> CreateAddressListImportJobAsync(CreateAddressListImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressListImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateArchive

        internal virtual CreateArchiveResponse CreateArchive(CreateArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return Invoke<CreateArchiveResponse>(request, options);
        }



        /// <summary>
        /// Creates a new email archive resource for storing and retaining emails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        public virtual Task<CreateArchiveResponse> CreateArchiveAsync(CreateArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<CreateArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIngressPoint

        internal virtual CreateIngressPointResponse CreateIngressPoint(CreateIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngressPointResponseUnmarshaller.Instance;

            return Invoke<CreateIngressPointResponse>(request, options);
        }



        /// <summary>
        /// Provision a new ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        public virtual Task<CreateIngressPointResponse> CreateIngressPointAsync(CreateIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngressPointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIngressPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRelay

        internal virtual CreateRelayResponse CreateRelay(CreateRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelayResponseUnmarshaller.Instance;

            return Invoke<CreateRelayResponse>(request, options);
        }



        /// <summary>
        /// Creates a relay resource which can be used in rules to relay incoming emails to defined
        /// relay destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        public virtual Task<CreateRelayResponse> CreateRelayAsync(CreateRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRelayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRuleSet

        internal virtual CreateRuleSetResponse CreateRuleSet(CreateRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Provision a new rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        public virtual Task<CreateRuleSetResponse> CreateRuleSetAsync(CreateRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTrafficPolicy

        internal virtual CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyResponse>(request, options);
        }



        /// <summary>
        /// Provision a new traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        public virtual Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAddonInstance

        internal virtual DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonInstanceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        public virtual Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddonInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAddonSubscription

        internal virtual DeleteAddonSubscriptionResponse DeleteAddonSubscription(DeleteAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        public virtual Task<DeleteAddonSubscriptionResponse> DeleteAddonSubscriptionAsync(DeleteAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddonSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAddressList

        internal virtual DeleteAddressListResponse DeleteAddressList(DeleteAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressListResponseUnmarshaller.Instance;

            return Invoke<DeleteAddressListResponse>(request, options);
        }



        /// <summary>
        /// Deletes an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddressList">REST API Reference for DeleteAddressList Operation</seealso>
        public virtual Task<DeleteAddressListResponse> DeleteAddressListAsync(DeleteAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteArchive

        internal virtual DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveResponse>(request, options);
        }



        /// <summary>
        /// Initiates deletion of an email archive. This changes the archive state to pending
        /// deletion. In this state, no new emails can be added, and existing archived emails
        /// become inaccessible (search, export, download). The archive and all of its contents
        /// will be permanently deleted 30 days after entering the pending deletion state, regardless
        /// of the configured retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIngressPoint

        internal virtual DeleteIngressPointResponse DeleteIngressPoint(DeleteIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngressPointResponseUnmarshaller.Instance;

            return Invoke<DeleteIngressPointResponse>(request, options);
        }



        /// <summary>
        /// Delete an ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        public virtual Task<DeleteIngressPointResponse> DeleteIngressPointAsync(DeleteIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngressPointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIngressPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRelay

        internal virtual DeleteRelayResponse DeleteRelay(DeleteRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelayResponseUnmarshaller.Instance;

            return Invoke<DeleteRelayResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        public virtual Task<DeleteRelayResponse> DeleteRelayAsync(DeleteRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRelayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRuleSet

        internal virtual DeleteRuleSetResponse DeleteRuleSet(DeleteRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Delete a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        public virtual Task<DeleteRuleSetResponse> DeleteRuleSetAsync(DeleteRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTrafficPolicy

        internal virtual DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyResponse>(request, options);
        }



        /// <summary>
        /// Delete a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        public virtual Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterMemberFromAddressList

        internal virtual DeregisterMemberFromAddressListResponse DeregisterMemberFromAddressList(DeregisterMemberFromAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMemberFromAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMemberFromAddressListResponseUnmarshaller.Instance;

            return Invoke<DeregisterMemberFromAddressListResponse>(request, options);
        }



        /// <summary>
        /// Removes a member from an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMemberFromAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterMemberFromAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeregisterMemberFromAddressList">REST API Reference for DeregisterMemberFromAddressList Operation</seealso>
        public virtual Task<DeregisterMemberFromAddressListResponse> DeregisterMemberFromAddressListAsync(DeregisterMemberFromAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMemberFromAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMemberFromAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterMemberFromAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAddonInstance

        internal virtual GetAddonInstanceResponse GetAddonInstance(GetAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<GetAddonInstanceResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        public virtual Task<GetAddonInstanceResponse> GetAddonInstanceAsync(GetAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddonInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAddonSubscription

        internal virtual GetAddonSubscriptionResponse GetAddonSubscription(GetAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetAddonSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        public virtual Task<GetAddonSubscriptionResponse> GetAddonSubscriptionAsync(GetAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddonSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAddressList

        internal virtual GetAddressListResponse GetAddressList(GetAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListResponseUnmarshaller.Instance;

            return Invoke<GetAddressListResponse>(request, options);
        }



        /// <summary>
        /// Fetch attributes of an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressList">REST API Reference for GetAddressList Operation</seealso>
        public virtual Task<GetAddressListResponse> GetAddressListAsync(GetAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAddressListImportJob

        internal virtual GetAddressListImportJobResponse GetAddressListImportJob(GetAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<GetAddressListImportJobResponse>(request, options);
        }



        /// <summary>
        /// Fetch attributes of an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressListImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressListImportJob">REST API Reference for GetAddressListImportJob Operation</seealso>
        public virtual Task<GetAddressListImportJobResponse> GetAddressListImportJobAsync(GetAddressListImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddressListImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchive

        internal virtual GetArchiveResponse GetArchive(GetArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveResponseUnmarshaller.Instance;

            return Invoke<GetArchiveResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the full details and current state of a specified email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        public virtual Task<GetArchiveResponse> GetArchiveAsync(GetArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchiveExport

        internal virtual GetArchiveExportResponse GetArchiveExport(GetArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveExportResponseUnmarshaller.Instance;

            return Invoke<GetArchiveExportResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details and current status of a specific email archive export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        public virtual Task<GetArchiveExportResponse> GetArchiveExportAsync(GetArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchiveMessage

        internal virtual GetArchiveMessageResponse GetArchiveMessage(GetArchiveMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageResponseUnmarshaller.Instance;

            return Invoke<GetArchiveMessageResponse>(request, options);
        }



        /// <summary>
        /// Returns a pre-signed URL that provides temporary download access to the specific email
        /// message stored in the archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveMessage service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        public virtual Task<GetArchiveMessageResponse> GetArchiveMessageAsync(GetArchiveMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchiveMessageContent

        internal virtual GetArchiveMessageContentResponse GetArchiveMessageContent(GetArchiveMessageContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageContentResponseUnmarshaller.Instance;

            return Invoke<GetArchiveMessageContentResponse>(request, options);
        }



        /// <summary>
        /// Returns the textual content of a specific email message stored in the archive. Attachments
        /// are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveMessageContent service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        public virtual Task<GetArchiveMessageContentResponse> GetArchiveMessageContentAsync(GetArchiveMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveMessageContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchiveSearch

        internal virtual GetArchiveSearchResponse GetArchiveSearch(GetArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<GetArchiveSearchResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details and current status of a specific email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        public virtual Task<GetArchiveSearchResponse> GetArchiveSearchAsync(GetArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArchiveSearchResults

        internal virtual GetArchiveSearchResultsResponse GetArchiveSearchResults(GetArchiveSearchResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResultsResponseUnmarshaller.Instance;

            return Invoke<GetArchiveSearchResultsResponse>(request, options);
        }



        /// <summary>
        /// Returns the results of a completed email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveSearchResults service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        public virtual Task<GetArchiveSearchResultsResponse> GetArchiveSearchResultsAsync(GetArchiveSearchResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveSearchResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIngressPoint

        internal virtual GetIngressPointResponse GetIngressPoint(GetIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngressPointResponseUnmarshaller.Instance;

            return Invoke<GetIngressPointResponse>(request, options);
        }



        /// <summary>
        /// Fetch ingress endpoint resource attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        public virtual Task<GetIngressPointResponse> GetIngressPointAsync(GetIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngressPointResponseUnmarshaller.Instance;

            return InvokeAsync<GetIngressPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMemberOfAddressList

        internal virtual GetMemberOfAddressListResponse GetMemberOfAddressList(GetMemberOfAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberOfAddressListResponseUnmarshaller.Instance;

            return Invoke<GetMemberOfAddressListResponse>(request, options);
        }



        /// <summary>
        /// Fetch attributes of a member in an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemberOfAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMemberOfAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetMemberOfAddressList">REST API Reference for GetMemberOfAddressList Operation</seealso>
        public virtual Task<GetMemberOfAddressListResponse> GetMemberOfAddressListAsync(GetMemberOfAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberOfAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<GetMemberOfAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRelay

        internal virtual GetRelayResponse GetRelay(GetRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelayResponseUnmarshaller.Instance;

            return Invoke<GetRelayResponse>(request, options);
        }



        /// <summary>
        /// Fetch the relay resource and it's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        public virtual Task<GetRelayResponse> GetRelayAsync(GetRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelayResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRuleSet

        internal virtual GetRuleSetResponse GetRuleSet(GetRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleSetResponseUnmarshaller.Instance;

            return Invoke<GetRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Fetch attributes of a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        public virtual Task<GetRuleSetResponse> GetRuleSetAsync(GetRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrafficPolicy

        internal virtual GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyResponse>(request, options);
        }



        /// <summary>
        /// Fetch attributes of a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        public virtual Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAddonInstances

        internal virtual ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonInstancesResponseUnmarshaller.Instance;

            return Invoke<ListAddonInstancesResponse>(request, options);
        }



        /// <summary>
        /// Lists all Add On instances in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddonInstances service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        public virtual Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAddonInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAddonSubscriptions

        internal virtual ListAddonSubscriptionsResponse ListAddonSubscriptions(ListAddonSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListAddonSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all Add On subscriptions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddonSubscriptions service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        public virtual Task<ListAddonSubscriptionsResponse> ListAddonSubscriptionsAsync(ListAddonSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAddonSubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAddressListImportJobs

        internal virtual ListAddressListImportJobsResponse ListAddressListImportJobs(ListAddressListImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAddressListImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists jobs for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddressListImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddressListImportJobs service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressListImportJobs">REST API Reference for ListAddressListImportJobs Operation</seealso>
        public virtual Task<ListAddressListImportJobsResponse> ListAddressListImportJobsAsync(ListAddressListImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAddressListImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAddressLists

        internal virtual ListAddressListsResponse ListAddressLists(ListAddressListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListsResponseUnmarshaller.Instance;

            return Invoke<ListAddressListsResponse>(request, options);
        }



        /// <summary>
        /// Lists address lists for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddressLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddressLists service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressLists">REST API Reference for ListAddressLists Operation</seealso>
        public virtual Task<ListAddressListsResponse> ListAddressListsAsync(ListAddressListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAddressListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListArchiveExports

        internal virtual ListArchiveExportsResponse ListArchiveExports(ListArchiveExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveExportsResponseUnmarshaller.Instance;

            return Invoke<ListArchiveExportsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of email archive export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchiveExports service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        public virtual Task<ListArchiveExportsResponse> ListArchiveExportsAsync(ListArchiveExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListArchiveExportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListArchives

        internal virtual ListArchivesResponse ListArchives(ListArchivesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return Invoke<ListArchivesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all email archives in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        public virtual Task<ListArchivesResponse> ListArchivesAsync(ListArchivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return InvokeAsync<ListArchivesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListArchiveSearches

        internal virtual ListArchiveSearchesResponse ListArchiveSearches(ListArchiveSearchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveSearchesResponseUnmarshaller.Instance;

            return Invoke<ListArchiveSearchesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of email archive search jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchiveSearches service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        public virtual Task<ListArchiveSearchesResponse> ListArchiveSearchesAsync(ListArchiveSearchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveSearchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListArchiveSearchesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIngressPoints

        internal virtual ListIngressPointsResponse ListIngressPoints(ListIngressPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngressPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngressPointsResponseUnmarshaller.Instance;

            return Invoke<ListIngressPointsResponse>(request, options);
        }



        /// <summary>
        /// List all ingress endpoint resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngressPoints service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        public virtual Task<ListIngressPointsResponse> ListIngressPointsAsync(ListIngressPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngressPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngressPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIngressPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMembersOfAddressList

        internal virtual ListMembersOfAddressListResponse ListMembersOfAddressList(ListMembersOfAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersOfAddressListResponseUnmarshaller.Instance;

            return Invoke<ListMembersOfAddressListResponse>(request, options);
        }



        /// <summary>
        /// Lists members of an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembersOfAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembersOfAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListMembersOfAddressList">REST API Reference for ListMembersOfAddressList Operation</seealso>
        public virtual Task<ListMembersOfAddressListResponse> ListMembersOfAddressListAsync(ListMembersOfAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersOfAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersOfAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRelays

        internal virtual ListRelaysResponse ListRelays(ListRelaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelaysResponseUnmarshaller.Instance;

            return Invoke<ListRelaysResponse>(request, options);
        }



        /// <summary>
        /// Lists all the existing relay resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelays service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRelays service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        public virtual Task<ListRelaysResponse> ListRelaysAsync(ListRelaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListRelaysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuleSets

        internal virtual ListRuleSetsResponse ListRuleSets(ListRuleSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListRuleSetsResponse>(request, options);
        }



        /// <summary>
        /// List rule sets for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleSets service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        public virtual Task<ListRuleSetsResponse> ListRuleSetsAsync(ListRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleSetsResponse>(request, options, cancellationToken);
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
        /// Retrieves the list of tags (keys and values) assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTrafficPolicies

        internal virtual ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesResponse>(request, options);
        }



        /// <summary>
        /// List traffic policy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public virtual Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterMemberToAddressList

        internal virtual RegisterMemberToAddressListResponse RegisterMemberToAddressList(RegisterMemberToAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMemberToAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMemberToAddressListResponseUnmarshaller.Instance;

            return Invoke<RegisterMemberToAddressListResponse>(request, options);
        }



        /// <summary>
        /// Adds a member to an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMemberToAddressList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterMemberToAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/RegisterMemberToAddressList">REST API Reference for RegisterMemberToAddressList Operation</seealso>
        public virtual Task<RegisterMemberToAddressListResponse> RegisterMemberToAddressListAsync(RegisterMemberToAddressListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMemberToAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMemberToAddressListResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterMemberToAddressListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAddressListImportJob

        internal virtual StartAddressListImportJobResponse StartAddressListImportJob(StartAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<StartAddressListImportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAddressListImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartAddressListImportJob">REST API Reference for StartAddressListImportJob Operation</seealso>
        public virtual Task<StartAddressListImportJobResponse> StartAddressListImportJobAsync(StartAddressListImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAddressListImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAddressListImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartArchiveExport

        internal virtual StartArchiveExportResponse StartArchiveExport(StartArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveExportResponseUnmarshaller.Instance;

            return Invoke<StartArchiveExportResponse>(request, options);
        }



        /// <summary>
        /// Initiates an export of emails from the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        public virtual Task<StartArchiveExportResponse> StartArchiveExportAsync(StartArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveExportResponseUnmarshaller.Instance;

            return InvokeAsync<StartArchiveExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartArchiveSearch

        internal virtual StartArchiveSearchResponse StartArchiveSearch(StartArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<StartArchiveSearchResponse>(request, options);
        }



        /// <summary>
        /// Initiates a search across emails in the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        public virtual Task<StartArchiveSearchResponse> StartArchiveSearchAsync(StartArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StartArchiveSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopAddressListImportJob

        internal virtual StopAddressListImportJobResponse StopAddressListImportJob(StopAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<StopAddressListImportJobResponse>(request, options);
        }



        /// <summary>
        /// Stops an ongoing import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAddressListImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopAddressListImportJob">REST API Reference for StopAddressListImportJob Operation</seealso>
        public virtual Task<StopAddressListImportJobResponse> StopAddressListImportJobAsync(StopAddressListImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAddressListImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopAddressListImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopArchiveExport

        internal virtual StopArchiveExportResponse StopArchiveExport(StopArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveExportResponseUnmarshaller.Instance;

            return Invoke<StopArchiveExportResponse>(request, options);
        }



        /// <summary>
        /// Stops an in-progress export of emails from an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        public virtual Task<StopArchiveExportResponse> StopArchiveExportAsync(StopArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveExportResponseUnmarshaller.Instance;

            return InvokeAsync<StopArchiveExportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopArchiveSearch

        internal virtual StopArchiveSearchResponse StopArchiveSearch(StopArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<StopArchiveSearchResponse>(request, options);
        }



        /// <summary>
        /// Stops an in-progress archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        public virtual Task<StopArchiveSearchResponse> StopArchiveSearchAsync(StopArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StopArchiveSearchResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags (keys and values) to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// <returns>The response from the UntagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateArchive

        internal virtual UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return Invoke<UpdateArchiveResponse>(request, options);
        }



        /// <summary>
        /// Updates the attributes of an existing email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        public virtual Task<UpdateArchiveResponse> UpdateArchiveAsync(UpdateArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateArchiveResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIngressPoint

        internal virtual UpdateIngressPointResponse UpdateIngressPoint(UpdateIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngressPointResponseUnmarshaller.Instance;

            return Invoke<UpdateIngressPointResponse>(request, options);
        }



        /// <summary>
        /// Update attributes of a provisioned ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        public virtual Task<UpdateIngressPointResponse> UpdateIngressPointAsync(UpdateIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngressPointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIngressPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRelay

        internal virtual UpdateRelayResponse UpdateRelay(UpdateRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelayResponseUnmarshaller.Instance;

            return Invoke<UpdateRelayResponse>(request, options);
        }



        /// <summary>
        /// Updates the attributes of an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        public virtual Task<UpdateRelayResponse> UpdateRelayAsync(UpdateRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelayResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRelayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRuleSet

        internal virtual UpdateRuleSetResponse UpdateRuleSet(UpdateRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Update attributes of an already provisioned rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        public virtual Task<UpdateRuleSetResponse> UpdateRuleSetAsync(UpdateRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTrafficPolicy

        internal virtual UpdateTrafficPolicyResponse UpdateTrafficPolicy(UpdateTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyResponse>(request, options);
        }



        /// <summary>
        /// Update attributes of an already provisioned traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        public virtual Task<UpdateTrafficPolicyResponse> UpdateTrafficPolicyAsync(UpdateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyResponse>(request, options, cancellationToken);
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