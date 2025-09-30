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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CustomerProfiles.Model;
using Amazon.CustomerProfiles.Model.Internal.MarshallTransformations;
using Amazon.CustomerProfiles.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CustomerProfiles
{
    /// <summary>
    /// <para>Implementation for accessing CustomerProfiles</para>
    ///
    /// Amazon Connect Customer Profiles <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Connect_Customer_Profiles.html">Customer
    /// Profiles actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Connect_Customer_Profiles.html">Customer
    /// Profiles data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Connect Customer Profiles is a unified customer profile for your contact center
    /// that has pre-built connectors powered by AppFlow that make it easy to combine customer
    /// information from third party applications, such as Salesforce (CRM), ServiceNow (ITSM),
    /// and your enterprise resource planning (ERP), with contact history from your Amazon
    /// Connect contact center. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the Amazon Connect Customer Profiles feature, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/customer-profiles.html">Use
    /// Customer Profiles</a> in the <i>Amazon Connect Administrator's Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AmazonCustomerProfilesClient : AmazonServiceClient, IAmazonCustomerProfiles
    {
        private static IServiceMetadata serviceMetadata = new AmazonCustomerProfilesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with the credentials loaded from the application's
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
        public AmazonCustomerProfilesClient()
            : base(new AmazonCustomerProfilesConfig()) { }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with the credentials loaded from the application's
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
        public AmazonCustomerProfilesClient(RegionEndpoint region)
            : base(new AmazonCustomerProfilesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCustomerProfilesClient Configuration Object</param>
        public AmazonCustomerProfilesClient(AmazonCustomerProfilesConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCustomerProfilesClient(AWSCredentials credentials)
            : this(credentials, new AmazonCustomerProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCustomerProfilesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCustomerProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Credentials and an
        /// AmazonCustomerProfilesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCustomerProfilesClient Configuration Object</param>
        public AmazonCustomerProfilesClient(AWSCredentials credentials, AmazonCustomerProfilesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCustomerProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCustomerProfilesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCustomerProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCustomerProfilesClient Configuration Object</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCustomerProfilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCustomerProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCustomerProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCustomerProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCustomerProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCustomerProfilesClient Configuration Object</param>
        public AmazonCustomerProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCustomerProfilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICustomerProfilesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICustomerProfilesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CustomerProfilesPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCustomerProfilesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCustomerProfilesAuthSchemeHandler());
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


        #region  AddProfileKey

        internal virtual AddProfileKeyResponse AddProfileKey(AddProfileKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddProfileKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddProfileKeyResponseUnmarshaller.Instance;

            return Invoke<AddProfileKeyResponse>(request, options);
        }



        /// <summary>
        /// Associates a new key value with a specific profile, such as a Contact Record ContactId.
        /// 
        ///  
        /// <para>
        /// A profile object can have a single unique key and any number of additional keys that
        /// can be used to identify the profile that it belongs to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddProfileKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddProfileKey service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AddProfileKey">REST API Reference for AddProfileKey Operation</seealso>
        public virtual Task<AddProfileKeyResponse> AddProfileKeyAsync(AddProfileKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddProfileKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddProfileKeyResponseUnmarshaller.Instance;

            return InvokeAsync<AddProfileKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetCalculatedAttributeForProfile

        internal virtual BatchGetCalculatedAttributeForProfileResponse BatchGetCalculatedAttributeForProfile(BatchGetCalculatedAttributeForProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCalculatedAttributeForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCalculatedAttributeForProfileResponseUnmarshaller.Instance;

            return Invoke<BatchGetCalculatedAttributeForProfileResponse>(request, options);
        }



        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCalculatedAttributeForProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetCalculatedAttributeForProfile">REST API Reference for BatchGetCalculatedAttributeForProfile Operation</seealso>
        public virtual Task<BatchGetCalculatedAttributeForProfileResponse> BatchGetCalculatedAttributeForProfileAsync(BatchGetCalculatedAttributeForProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCalculatedAttributeForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCalculatedAttributeForProfileResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCalculatedAttributeForProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetProfile

        internal virtual BatchGetProfileResponse BatchGetProfile(BatchGetProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetProfileResponseUnmarshaller.Instance;

            return Invoke<BatchGetProfileResponse>(request, options);
        }



        /// <summary>
        /// Get a batch of profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetProfile">REST API Reference for BatchGetProfile Operation</seealso>
        public virtual Task<BatchGetProfileResponse> BatchGetProfileAsync(BatchGetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCalculatedAttributeDefinition

        internal virtual CreateCalculatedAttributeDefinitionResponse CreateCalculatedAttributeDefinition(CreateCalculatedAttributeDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateCalculatedAttributeDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new calculated attribute definition. After creation, new object data ingested
        /// into Customer Profiles will be included in the calculated attribute, which can be
        /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
        /// API. Defining a calculated attribute makes it available for all profiles within a
        /// domain. Each calculated attribute can only reference one <c>ObjectType</c> and at
        /// most, two fields from that <c>ObjectType</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateCalculatedAttributeDefinition">REST API Reference for CreateCalculatedAttributeDefinition Operation</seealso>
        public virtual Task<CreateCalculatedAttributeDefinitionResponse> CreateCalculatedAttributeDefinitionAsync(CreateCalculatedAttributeDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCalculatedAttributeDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates a domain, which is a container for all customer data, such as customer profile
        /// attributes, object types, profile keys, and encryption keys. You can create multiple
        /// domains, and each domain can have multiple third-party integrations.
        /// 
        ///  
        /// <para>
        /// Each Amazon Connect instance can be associated with only one domain. Multiple Amazon
        /// Connect instances can be associated with one domain.
        /// </para>
        ///  
        /// <para>
        /// Use this API or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UpdateDomain.html">UpdateDomain</a>
        /// to enable <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">identity
        /// resolution</a>: set <c>Matching</c> to true.
        /// </para>
        ///  
        /// <para>
        /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
        /// confused deputy prevention</a> for sample policies that you should apply. 
        /// </para>
        ///  <note> 
        /// <para>
        /// It is not possible to associate a Customer Profiles domain with an Amazon Connect
        /// Instance directly from the API. If you would like to create a domain and associate
        /// a Customer Profiles domain, use the Amazon Connect admin website. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-customer-profiles.html#enable-customer-profiles-step1">Enable
        /// Customer Profiles</a>.
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Connect instance can be associated with only one domain. Multiple Amazon
        /// Connect instances can be associated with one domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomainLayout

        internal virtual CreateDomainLayoutResponse CreateDomainLayout(CreateDomainLayoutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainLayoutResponseUnmarshaller.Instance;

            return Invoke<CreateDomainLayoutResponse>(request, options);
        }



        /// <summary>
        /// Creates the layout to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainLayout service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomainLayout">REST API Reference for CreateDomainLayout Operation</seealso>
        public virtual Task<CreateDomainLayoutResponse> CreateDomainLayoutAsync(CreateDomainLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainLayoutResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainLayoutResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventStream

        internal virtual CreateEventStreamResponse CreateEventStream(CreateEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventStreamResponseUnmarshaller.Instance;

            return Invoke<CreateEventStreamResponse>(request, options);
        }



        /// <summary>
        /// Creates an event stream, which is a subscription to real-time events, such as when
        /// profiles are created and updated through Amazon Connect Customer Profiles.
        /// 
        ///  
        /// <para>
        /// Each event stream can be associated with only one Kinesis Data Stream destination
        /// in the same region and Amazon Web Services account as the customer profiles domain
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventStream">REST API Reference for CreateEventStream Operation</seealso>
        public virtual Task<CreateEventStreamResponse> CreateEventStreamAsync(CreateEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventTrigger

        internal virtual CreateEventTriggerResponse CreateEventTrigger(CreateEventTriggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTriggerResponseUnmarshaller.Instance;

            return Invoke<CreateEventTriggerResponse>(request, options);
        }



        /// <summary>
        /// Creates an event trigger, which specifies the rules when to perform action based on
        /// customer's ingested data.
        /// 
        ///  
        /// <para>
        /// Each event stream can be associated with only one integration in the same region and
        /// AWS account as the event stream. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventTrigger service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventTrigger">REST API Reference for CreateEventTrigger Operation</seealso>
        public virtual Task<CreateEventTriggerResponse> CreateEventTriggerAsync(CreateEventTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventTriggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIntegrationWorkflow

        internal virtual CreateIntegrationWorkflowResponse CreateIntegrationWorkflow(CreateIntegrationWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Creates an integration workflow. An integration workflow is an async process which
        /// ingests historic data and sets up an integration for ongoing updates. The supported
        /// Amazon AppFlow sources are Salesforce, ServiceNow, and Marketo.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegrationWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateIntegrationWorkflow">REST API Reference for CreateIntegrationWorkflow Operation</seealso>
        public virtual Task<CreateIntegrationWorkflowResponse> CreateIntegrationWorkflowAsync(CreateIntegrationWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProfile

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a standard profile.
        /// 
        ///  
        /// <para>
        /// A standard profile represents the following attributes for a customer profile in a
        /// domain.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSegmentDefinition

        internal virtual CreateSegmentDefinitionResponse CreateSegmentDefinition(CreateSegmentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a segment definition associated to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSegmentDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentDefinition">REST API Reference for CreateSegmentDefinition Operation</seealso>
        public virtual Task<CreateSegmentDefinitionResponse> CreateSegmentDefinitionAsync(CreateSegmentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSegmentDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSegmentEstimate

        internal virtual CreateSegmentEstimateResponse CreateSegmentEstimate(CreateSegmentEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentEstimateResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentEstimateResponse>(request, options);
        }



        /// <summary>
        /// Creates a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSegmentEstimate service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentEstimate">REST API Reference for CreateSegmentEstimate Operation</seealso>
        public virtual Task<CreateSegmentEstimateResponse> CreateSegmentEstimateAsync(CreateSegmentEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSegmentEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSegmentSnapshot

        internal virtual CreateSegmentSnapshotResponse CreateSegmentSnapshot(CreateSegmentSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Triggers a job to export a segment to a specified destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSegmentSnapshot service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentSnapshot">REST API Reference for CreateSegmentSnapshot Operation</seealso>
        public virtual Task<CreateSegmentSnapshotResponse> CreateSegmentSnapshotAsync(CreateSegmentSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSegmentSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUploadJob

        internal virtual CreateUploadJobResponse CreateUploadJob(CreateUploadJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadJobResponseUnmarshaller.Instance;

            return Invoke<CreateUploadJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an Upload job to ingest data for segment imports. The metadata is created
        /// for the job with the provided field mapping and unique key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUploadJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateUploadJob">REST API Reference for CreateUploadJob Operation</seealso>
        public virtual Task<CreateUploadJobResponse> CreateUploadJobAsync(CreateUploadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUploadJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUploadJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCalculatedAttributeDefinition

        internal virtual DeleteCalculatedAttributeDefinitionResponse DeleteCalculatedAttributeDefinition(DeleteCalculatedAttributeDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteCalculatedAttributeDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing calculated attribute definition. Note that deleting a default
        /// calculated attribute is possible, however once deleted, you will be unable to undo
        /// that action and will need to recreate it on your own using the CreateCalculatedAttributeDefinition
        /// API if you want it back.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteCalculatedAttributeDefinition">REST API Reference for DeleteCalculatedAttributeDefinition Operation</seealso>
        public virtual Task<DeleteCalculatedAttributeDefinitionResponse> DeleteCalculatedAttributeDefinitionAsync(DeleteCalculatedAttributeDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCalculatedAttributeDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specific domain and all of its customer data, such as customer profile attributes
        /// and their related objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomainLayout

        internal virtual DeleteDomainLayoutResponse DeleteDomainLayout(DeleteDomainLayoutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainLayoutResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainLayoutResponse>(request, options);
        }



        /// <summary>
        /// Deletes the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainLayout service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainLayout">REST API Reference for DeleteDomainLayout Operation</seealso>
        public virtual Task<DeleteDomainLayoutResponse> DeleteDomainLayoutAsync(DeleteDomainLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainLayoutResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainLayoutResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventStream

        internal virtual DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamResponse>(request, options);
        }



        /// <summary>
        /// Disables and deletes the specified event stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        public virtual Task<DeleteEventStreamResponse> DeleteEventStreamAsync(DeleteEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventTrigger

        internal virtual DeleteEventTriggerResponse DeleteEventTrigger(DeleteEventTriggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTriggerResponseUnmarshaller.Instance;

            return Invoke<DeleteEventTriggerResponse>(request, options);
        }



        /// <summary>
        /// Disable and deletes the Event Trigger.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an Event Trigger with an active Integration associated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventTrigger service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventTrigger">REST API Reference for DeleteEventTrigger Operation</seealso>
        public virtual Task<DeleteEventTriggerResponse> DeleteEventTriggerAsync(DeleteEventTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventTriggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIntegration

        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Removes an integration from a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfile

        internal virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes the standard customer profile and all data pertaining to the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfileKey

        internal virtual DeleteProfileKeyResponse DeleteProfileKey(DeleteProfileKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileKeyResponse>(request, options);
        }



        /// <summary>
        /// Removes a searchable key from a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfileKey service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileKey">REST API Reference for DeleteProfileKey Operation</seealso>
        public virtual Task<DeleteProfileKeyResponse> DeleteProfileKeyAsync(DeleteProfileKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfileObject

        internal virtual DeleteProfileObjectResponse DeleteProfileObject(DeleteProfileObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileObjectResponse>(request, options);
        }



        /// <summary>
        /// Removes an object associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObject">REST API Reference for DeleteProfileObject Operation</seealso>
        public virtual Task<DeleteProfileObjectResponse> DeleteProfileObjectAsync(DeleteProfileObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfileObjectType

        internal virtual DeleteProfileObjectTypeResponse DeleteProfileObjectType(DeleteProfileObjectTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileObjectTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileObjectTypeResponse>(request, options);
        }



        /// <summary>
        /// Removes a ProfileObjectType from a specific domain as well as removes all the ProfileObjects
        /// of that type. It also disables integrations from this specific ProfileObjectType.
        /// In addition, it scrubs all of the fields of the standard profile that were populated
        /// from this ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObjectType">REST API Reference for DeleteProfileObjectType Operation</seealso>
        public virtual Task<DeleteProfileObjectTypeResponse> DeleteProfileObjectTypeAsync(DeleteProfileObjectTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileObjectTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileObjectTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSegmentDefinition

        internal virtual DeleteSegmentDefinitionResponse DeleteSegmentDefinition(DeleteSegmentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSegmentDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentDefinition">REST API Reference for DeleteSegmentDefinition Operation</seealso>
        public virtual Task<DeleteSegmentDefinitionResponse> DeleteSegmentDefinitionAsync(DeleteSegmentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSegmentDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflow

        internal virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified workflow and all its corresponding resources. This is an async
        /// process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectProfileObjectType

        internal virtual DetectProfileObjectTypeResponse DetectProfileObjectType(DetectProfileObjectTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProfileObjectTypeResponseUnmarshaller.Instance;

            return Invoke<DetectProfileObjectTypeResponse>(request, options);
        }



        /// <summary>
        /// The process of detecting profile object type mapping by using given objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DetectProfileObjectType">REST API Reference for DetectProfileObjectType Operation</seealso>
        public virtual Task<DetectProfileObjectTypeResponse> DetectProfileObjectTypeAsync(DetectProfileObjectTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProfileObjectTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DetectProfileObjectTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAutoMergingPreview

        internal virtual GetAutoMergingPreviewResponse GetAutoMergingPreview(GetAutoMergingPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoMergingPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoMergingPreviewResponseUnmarshaller.Instance;

            return Invoke<GetAutoMergingPreviewResponse>(request, options);
        }



        /// <summary>
        /// Tests the auto-merging settings of your Identity Resolution Job without merging your
        /// data. It randomly selects a sample of matching groups from the existing matching results,
        /// and applies the automerging settings that you provided. You can then view the number
        /// of profiles in the sample, the number of matches, and the number of profiles identified
        /// to be merged. This enables you to evaluate the accuracy of the attributes in your
        /// matching list. 
        /// 
        ///  
        /// <para>
        /// You can't view which profiles are matched and would be merged.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend you use this API to do a dry run of the automerging process
        /// before running the Identity Resolution Job. Include <b>at least</b> two matching attributes.
        /// If your matching list includes too few attributes (such as only <c>FirstName</c> or
        /// only <c>LastName</c>), there may be a large number of matches. This increases the
        /// chances of erroneous merges.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoMergingPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoMergingPreview service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetAutoMergingPreview">REST API Reference for GetAutoMergingPreview Operation</seealso>
        public virtual Task<GetAutoMergingPreviewResponse> GetAutoMergingPreviewAsync(GetAutoMergingPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutoMergingPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoMergingPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoMergingPreviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCalculatedAttributeDefinition

        internal virtual GetCalculatedAttributeDefinitionResponse GetCalculatedAttributeDefinition(GetCalculatedAttributeDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetCalculatedAttributeDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Provides more information on a calculated attribute definition for Customer Profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeDefinition">REST API Reference for GetCalculatedAttributeDefinition Operation</seealso>
        public virtual Task<GetCalculatedAttributeDefinitionResponse> GetCalculatedAttributeDefinitionAsync(GetCalculatedAttributeDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCalculatedAttributeDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCalculatedAttributeForProfile

        internal virtual GetCalculatedAttributeForProfileResponse GetCalculatedAttributeForProfile(GetCalculatedAttributeForProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCalculatedAttributeForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculatedAttributeForProfileResponseUnmarshaller.Instance;

            return Invoke<GetCalculatedAttributeForProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a calculated attribute for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculatedAttributeForProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeForProfile">REST API Reference for GetCalculatedAttributeForProfile Operation</seealso>
        public virtual Task<GetCalculatedAttributeForProfileResponse> GetCalculatedAttributeForProfileAsync(GetCalculatedAttributeForProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCalculatedAttributeForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculatedAttributeForProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetCalculatedAttributeForProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomain

        internal virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomainLayout

        internal virtual GetDomainLayoutResponse GetDomainLayout(GetDomainLayoutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainLayoutResponseUnmarshaller.Instance;

            return Invoke<GetDomainLayoutResponse>(request, options);
        }



        /// <summary>
        /// Gets the layout to view data for a specific domain. This API can only be invoked from
        /// the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainLayout service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainLayout">REST API Reference for GetDomainLayout Operation</seealso>
        public virtual Task<GetDomainLayoutResponse> GetDomainLayoutAsync(GetDomainLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainLayoutResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainLayoutResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEventStream

        internal virtual GetEventStreamResponse GetEventStream(GetEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified event stream in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        public virtual Task<GetEventStreamResponse> GetEventStreamAsync(GetEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEventTrigger

        internal virtual GetEventTriggerResponse GetEventTrigger(GetEventTriggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTriggerResponseUnmarshaller.Instance;

            return Invoke<GetEventTriggerResponse>(request, options);
        }



        /// <summary>
        /// Get a specific Event Trigger from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventTrigger service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventTrigger">REST API Reference for GetEventTrigger Operation</seealso>
        public virtual Task<GetEventTriggerResponse> GetEventTriggerAsync(GetEventTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventTriggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdentityResolutionJob

        internal virtual GetIdentityResolutionJobResponse GetIdentityResolutionJob(GetIdentityResolutionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityResolutionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityResolutionJobResponseUnmarshaller.Instance;

            return Invoke<GetIdentityResolutionJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an Identity Resolution Job in a specific domain. 
        /// 
        ///  
        /// <para>
        /// Identity Resolution Jobs are set up using the Amazon Connect admin console. For more
        /// information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/use-identity-resolution.html">Use
        /// Identity Resolution to consolidate similar profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityResolutionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityResolutionJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIdentityResolutionJob">REST API Reference for GetIdentityResolutionJob Operation</seealso>
        public virtual Task<GetIdentityResolutionJobResponse> GetIdentityResolutionJobAsync(GetIdentityResolutionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityResolutionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityResolutionJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityResolutionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIntegration

        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Returns an integration for a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMatches

        internal virtual GetMatchesResponse GetMatches(GetMatchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchesResponseUnmarshaller.Instance;

            return Invoke<GetMatchesResponse>(request, options);
        }



        /// <summary>
        /// Before calling this API, use <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
        /// or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UpdateDomain.html">UpdateDomain</a>
        /// to enable identity resolution: set <c>Matching</c> to true.
        /// 
        ///  
        /// <para>
        /// GetMatches returns potentially matching profiles, based on the results of the latest
        /// run of a machine learning process. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The process of matching duplicate profiles. If <c>Matching</c> = <c>true</c>, Amazon
        /// Connect Customer Profiles starts a weekly batch process called Identity Resolution
        /// Job. If you do not specify a date and time for Identity Resolution Job to run, by
        /// default it runs every Saturday at 12AM UTC to detect duplicate profiles in your domains.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After the Identity Resolution Job completes, use the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>
        /// API to return and review the results. Or, if you have configured <c>ExportingConfig</c>
        /// in the <c>MatchingRequest</c>, you can download the results from S3.
        /// </para>
        ///  </important> 
        /// <para>
        /// Amazon Connect uses the following profile attributes to identify matches:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HomePhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BusinessPhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MobilePhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PersonalEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BusinessEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FullName
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, two or more profiles—with spelling mistakes such as <b>John Doe</b> and
        /// <b>Jhn Doe</b>, or different casing email addresses such as <b>JOHN_DOE@ANYCOMPANY.COM</b>
        /// and <b>johndoe@anycompany.com</b>, or different phone number formats such as <b>555-010-0000</b>
        /// and <b>+1-555-010-0000</b>—can be detected as belonging to the same customer <b>John
        /// Doe</b> and merged into a unified profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMatches service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetMatches">REST API Reference for GetMatches Operation</seealso>
        public virtual Task<GetMatchesResponse> GetMatchesAsync(GetMatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMatchesResponseUnmarshaller.Instance;

            return InvokeAsync<GetMatchesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfileHistoryRecord

        internal virtual GetProfileHistoryRecordResponse GetProfileHistoryRecord(GetProfileHistoryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileHistoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileHistoryRecordResponseUnmarshaller.Instance;

            return Invoke<GetProfileHistoryRecordResponse>(request, options);
        }



        /// <summary>
        /// Returns a history record for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileHistoryRecord service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileHistoryRecord">REST API Reference for GetProfileHistoryRecord Operation</seealso>
        public virtual Task<GetProfileHistoryRecordResponse> GetProfileHistoryRecordAsync(GetProfileHistoryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileHistoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileHistoryRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileHistoryRecordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfileObjectType

        internal virtual GetProfileObjectTypeResponse GetProfileObjectType(GetProfileObjectTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileObjectTypeResponseUnmarshaller.Instance;

            return Invoke<GetProfileObjectTypeResponse>(request, options);
        }



        /// <summary>
        /// Returns the object types for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectType">REST API Reference for GetProfileObjectType Operation</seealso>
        public virtual Task<GetProfileObjectTypeResponse> GetProfileObjectTypeAsync(GetProfileObjectTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileObjectTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileObjectTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfileObjectTypeTemplate

        internal virtual GetProfileObjectTypeTemplateResponse GetProfileObjectTypeTemplate(GetProfileObjectTypeTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileObjectTypeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileObjectTypeTemplateResponseUnmarshaller.Instance;

            return Invoke<GetProfileObjectTypeTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns the template information for a specific object type.
        /// 
        ///  
        /// <para>
        /// A template is a predefined ProfileObjectType, such as “Salesforce-Account” or “Salesforce-Contact.”
        /// When a user sends a ProfileObject, using the PutProfileObject API, with an ObjectTypeName
        /// that matches one of the TemplateIds, it uses the mappings from the template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectTypeTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileObjectTypeTemplate service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectTypeTemplate">REST API Reference for GetProfileObjectTypeTemplate Operation</seealso>
        public virtual Task<GetProfileObjectTypeTemplateResponse> GetProfileObjectTypeTemplateAsync(GetProfileObjectTypeTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileObjectTypeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileObjectTypeTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileObjectTypeTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSegmentDefinition

        internal virtual GetSegmentDefinitionResponse GetSegmentDefinition(GetSegmentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Gets a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentDefinition">REST API Reference for GetSegmentDefinition Operation</seealso>
        public virtual Task<GetSegmentDefinitionResponse> GetSegmentDefinitionAsync(GetSegmentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSegmentEstimate

        internal virtual GetSegmentEstimateResponse GetSegmentEstimate(GetSegmentEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentEstimateResponseUnmarshaller.Instance;

            return Invoke<GetSegmentEstimateResponse>(request, options);
        }



        /// <summary>
        /// Gets the result of a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentEstimate service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentEstimate">REST API Reference for GetSegmentEstimate Operation</seealso>
        public virtual Task<GetSegmentEstimateResponse> GetSegmentEstimateAsync(GetSegmentEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSegmentMembership

        internal virtual GetSegmentMembershipResponse GetSegmentMembership(GetSegmentMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentMembershipResponseUnmarshaller.Instance;

            return Invoke<GetSegmentMembershipResponse>(request, options);
        }



        /// <summary>
        /// Determines if the given profiles are within a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentMembership service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentMembership">REST API Reference for GetSegmentMembership Operation</seealso>
        public virtual Task<GetSegmentMembershipResponse> GetSegmentMembershipAsync(GetSegmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSegmentSnapshot

        internal virtual GetSegmentSnapshotResponse GetSegmentSnapshot(GetSegmentSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSegmentSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the latest status of a segment snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentSnapshot service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSnapshot">REST API Reference for GetSegmentSnapshot Operation</seealso>
        public virtual Task<GetSegmentSnapshotResponse> GetSegmentSnapshotAsync(GetSegmentSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetSegmentSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSimilarProfiles

        internal virtual GetSimilarProfilesResponse GetSimilarProfiles(GetSimilarProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSimilarProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSimilarProfilesResponseUnmarshaller.Instance;

            return Invoke<GetSimilarProfilesResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
        /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
        /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSimilarProfiles service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSimilarProfiles">REST API Reference for GetSimilarProfiles Operation</seealso>
        public virtual Task<GetSimilarProfilesResponse> GetSimilarProfilesAsync(GetSimilarProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSimilarProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSimilarProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSimilarProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUploadJob

        internal virtual GetUploadJobResponse GetUploadJob(GetUploadJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadJobResponseUnmarshaller.Instance;

            return Invoke<GetUploadJobResponse>(request, options);
        }



        /// <summary>
        /// This API retrieves the details of a specific upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUploadJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJob">REST API Reference for GetUploadJob Operation</seealso>
        public virtual Task<GetUploadJobResponse> GetUploadJobAsync(GetUploadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUploadJobPath

        internal virtual GetUploadJobPathResponse GetUploadJobPath(GetUploadJobPathRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadJobPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadJobPathResponseUnmarshaller.Instance;

            return Invoke<GetUploadJobPathResponse>(request, options);
        }



        /// <summary>
        /// This API retrieves the pre-signed URL and client token for uploading the file associated
        /// with the upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUploadJobPath service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJobPath">REST API Reference for GetUploadJobPath Operation</seealso>
        public virtual Task<GetUploadJobPathResponse> GetUploadJobPathAsync(GetUploadJobPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadJobPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadJobPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadJobPathResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflow

        internal virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Get details of specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowSteps

        internal virtual GetWorkflowStepsResponse GetWorkflowSteps(GetWorkflowStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepsResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowStepsResponse>(request, options);
        }



        /// <summary>
        /// Get granular list of steps in workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowSteps service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflowSteps">REST API Reference for GetWorkflowSteps Operation</seealso>
        public virtual Task<GetWorkflowStepsResponse> GetWorkflowStepsAsync(GetWorkflowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAccountIntegrations

        internal virtual ListAccountIntegrationsResponse ListAccountIntegrations(ListAccountIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListAccountIntegrationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the integrations associated to a specific URI in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountIntegrations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListAccountIntegrations">REST API Reference for ListAccountIntegrations Operation</seealso>
        public virtual Task<ListAccountIntegrationsResponse> ListAccountIntegrationsAsync(ListAccountIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountIntegrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCalculatedAttributeDefinitions

        internal virtual ListCalculatedAttributeDefinitionsResponse ListCalculatedAttributeDefinitions(ListCalculatedAttributeDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCalculatedAttributeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculatedAttributeDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListCalculatedAttributeDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists calculated attribute definitions for Customer Profiles
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCalculatedAttributeDefinitions service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributeDefinitions">REST API Reference for ListCalculatedAttributeDefinitions Operation</seealso>
        public virtual Task<ListCalculatedAttributeDefinitionsResponse> ListCalculatedAttributeDefinitionsAsync(ListCalculatedAttributeDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCalculatedAttributeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculatedAttributeDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCalculatedAttributeDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCalculatedAttributesForProfile

        internal virtual ListCalculatedAttributesForProfileResponse ListCalculatedAttributesForProfile(ListCalculatedAttributesForProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCalculatedAttributesForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculatedAttributesForProfileResponseUnmarshaller.Instance;

            return Invoke<ListCalculatedAttributesForProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieve a list of calculated attributes for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCalculatedAttributesForProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributesForProfile">REST API Reference for ListCalculatedAttributesForProfile Operation</seealso>
        public virtual Task<ListCalculatedAttributesForProfileResponse> ListCalculatedAttributesForProfileAsync(ListCalculatedAttributesForProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCalculatedAttributesForProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculatedAttributesForProfileResponseUnmarshaller.Instance;

            return InvokeAsync<ListCalculatedAttributesForProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainLayouts

        internal virtual ListDomainLayoutsResponse ListDomainLayouts(ListDomainLayoutsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainLayoutsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainLayoutsResponseUnmarshaller.Instance;

            return Invoke<ListDomainLayoutsResponse>(request, options);
        }



        /// <summary>
        /// Lists the existing layouts that can be used to view data for a specific domain. This
        /// API can only be invoked from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainLayouts service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainLayouts">REST API Reference for ListDomainLayouts Operation</seealso>
        public virtual Task<ListDomainLayoutsResponse> ListDomainLayoutsAsync(ListDomainLayoutsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainLayoutsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainLayoutsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainLayoutsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the domains for an AWS account that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventStreams

        internal virtual ListEventStreamsResponse ListEventStreams(ListEventStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventStreamsResponseUnmarshaller.Instance;

            return Invoke<ListEventStreamsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the event streams in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventStreams service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventStreams">REST API Reference for ListEventStreams Operation</seealso>
        public virtual Task<ListEventStreamsResponse> ListEventStreamsAsync(ListEventStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventStreamsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventTriggers

        internal virtual ListEventTriggersResponse ListEventTriggers(ListEventTriggersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTriggersResponseUnmarshaller.Instance;

            return Invoke<ListEventTriggersResponse>(request, options);
        }



        /// <summary>
        /// List all Event Triggers under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventTriggers service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventTriggers">REST API Reference for ListEventTriggers Operation</seealso>
        public virtual Task<ListEventTriggersResponse> ListEventTriggersAsync(ListEventTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventTriggersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdentityResolutionJobs

        internal virtual ListIdentityResolutionJobsResponse ListIdentityResolutionJobs(ListIdentityResolutionJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityResolutionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityResolutionJobsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityResolutionJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <c>JobStartTime</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityResolutionJobs service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIdentityResolutionJobs">REST API Reference for ListIdentityResolutionJobs Operation</seealso>
        public virtual Task<ListIdentityResolutionJobsResponse> ListIdentityResolutionJobsAsync(ListIdentityResolutionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityResolutionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityResolutionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityResolutionJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIntegrations

        internal virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the integrations in your domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIntegrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListObjectTypeAttributes

        internal virtual ListObjectTypeAttributesResponse ListObjectTypeAttributes(ListObjectTypeAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectTypeAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectTypeAttributesResponseUnmarshaller.Instance;

            return Invoke<ListObjectTypeAttributesResponse>(request, options);
        }



        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectTypeAttributes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributes">REST API Reference for ListObjectTypeAttributes Operation</seealso>
        public virtual Task<ListObjectTypeAttributesResponse> ListObjectTypeAttributesAsync(ListObjectTypeAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectTypeAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectTypeAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectTypeAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileAttributeValues

        internal virtual ListProfileAttributeValuesResponse ListProfileAttributeValues(ListProfileAttributeValuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileAttributeValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAttributeValuesResponseUnmarshaller.Instance;

            return Invoke<ListProfileAttributeValuesResponse>(request, options);
        }



        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileAttributeValues service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileAttributeValues">REST API Reference for ListProfileAttributeValues Operation</seealso>
        public virtual Task<ListProfileAttributeValuesResponse> ListProfileAttributeValuesAsync(ListProfileAttributeValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileAttributeValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAttributeValuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileAttributeValuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileHistoryRecords

        internal virtual ListProfileHistoryRecordsResponse ListProfileHistoryRecords(ListProfileHistoryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileHistoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileHistoryRecordsResponseUnmarshaller.Instance;

            return Invoke<ListProfileHistoryRecordsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of history records for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileHistoryRecords service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileHistoryRecords">REST API Reference for ListProfileHistoryRecords Operation</seealso>
        public virtual Task<ListProfileHistoryRecordsResponse> ListProfileHistoryRecordsAsync(ListProfileHistoryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileHistoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileHistoryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileHistoryRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileObjects

        internal virtual ListProfileObjectsResponse ListProfileObjects(ListProfileObjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectsResponseUnmarshaller.Instance;

            return Invoke<ListProfileObjectsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of objects associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileObjects service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjects">REST API Reference for ListProfileObjects Operation</seealso>
        public virtual Task<ListProfileObjectsResponse> ListProfileObjectsAsync(ListProfileObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileObjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileObjectTypes

        internal virtual ListProfileObjectTypesResponse ListProfileObjectTypes(ListProfileObjectTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectTypesResponseUnmarshaller.Instance;

            return Invoke<ListProfileObjectTypesResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the templates available within the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileObjectTypes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypes">REST API Reference for ListProfileObjectTypes Operation</seealso>
        public virtual Task<ListProfileObjectTypesResponse> ListProfileObjectTypesAsync(ListProfileObjectTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileObjectTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileObjectTypeTemplates

        internal virtual ListProfileObjectTypeTemplatesResponse ListProfileObjectTypeTemplates(ListProfileObjectTypeTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectTypeTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectTypeTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListProfileObjectTypeTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the template information for object types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileObjectTypeTemplates service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypeTemplates">REST API Reference for ListProfileObjectTypeTemplates Operation</seealso>
        public virtual Task<ListProfileObjectTypeTemplatesResponse> ListProfileObjectTypeTemplatesAsync(ListProfileObjectTypeTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileObjectTypeTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileObjectTypeTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileObjectTypeTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuleBasedMatches

        internal virtual ListRuleBasedMatchesResponse ListRuleBasedMatches(ListRuleBasedMatchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleBasedMatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleBasedMatchesResponseUnmarshaller.Instance;

            return Invoke<ListRuleBasedMatchesResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of <c>MatchIds</c> that belong to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleBasedMatches service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRuleBasedMatches">REST API Reference for ListRuleBasedMatches Operation</seealso>
        public virtual Task<ListRuleBasedMatchesResponse> ListRuleBasedMatchesAsync(ListRuleBasedMatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleBasedMatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleBasedMatchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleBasedMatchesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSegmentDefinitions

        internal virtual ListSegmentDefinitionsResponse ListSegmentDefinitions(ListSegmentDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSegmentDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSegmentDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all segment definitions under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSegmentDefinitions service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentDefinitions">REST API Reference for ListSegmentDefinitions Operation</seealso>
        public virtual Task<ListSegmentDefinitionsResponse> ListSegmentDefinitionsAsync(ListSegmentDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSegmentDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSegmentDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSegmentDefinitionsResponse>(request, options, cancellationToken);
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
        /// Displays the tags associated with an Amazon Connect Customer Profiles resource. In
        /// Connect Customer Profiles, domains, profile object types, and integrations can be
        /// tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUploadJobs

        internal virtual ListUploadJobsResponse ListUploadJobs(ListUploadJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUploadJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadJobsResponseUnmarshaller.Instance;

            return Invoke<ListUploadJobsResponse>(request, options);
        }



        /// <summary>
        /// This API retrieves a list of upload jobs for the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUploadJobs service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListUploadJobs">REST API Reference for ListUploadJobs Operation</seealso>
        public virtual Task<ListUploadJobsResponse> ListUploadJobsAsync(ListUploadJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUploadJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUploadJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUploadJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflows

        internal virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Query to list all workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  MergeProfiles

        internal virtual MergeProfilesResponse MergeProfiles(MergeProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeProfilesResponseUnmarshaller.Instance;

            return Invoke<MergeProfilesResponse>(request, options);
        }



        /// <summary>
        /// Runs an AWS Lambda job that does the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// All the profileKeys in the <c>ProfileToBeMerged</c> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the objects in the <c>ProfileToBeMerged</c> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the <c>ProfileToBeMerged</c> will be deleted at the end.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the profileKeys in the <c>ProfileIdsToBeMerged</c> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Standard fields are merged as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Fields are always "union"-ed if there are no conflicts in standard fields or attributeKeys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When there are conflicting fields:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// If no <c>SourceProfileIds</c> entry is specified, the main Profile value is always
        /// taken. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a <c>SourceProfileIds</c> entry is specified, the specified profileId is always
        /// taken, even if it is a NULL value.
        /// </para>
        ///  </li> </ol> </li> </ol> </li> </ol> 
        /// <para>
        /// You can use MergeProfiles together with <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>,
        /// which returns potentially matching profiles, or use it with the results of another
        /// matching system. After profiles have been merged, they cannot be separated (unmerged).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergeProfiles service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/MergeProfiles">REST API Reference for MergeProfiles Operation</seealso>
        public virtual Task<MergeProfilesResponse> MergeProfilesAsync(MergeProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<MergeProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutIntegration

        internal virtual PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Adds an integration between the service and a third-party service, which includes
        /// Amazon AppFlow and Amazon Connect.
        /// 
        ///  
        /// <para>
        /// An integration can belong to only one domain.
        /// </para>
        ///  
        /// <para>
        /// To add or remove tags on an existing Integration, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
        /// TagResource </a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">
        /// UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        public virtual Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutProfileObject

        internal virtual PutProfileObjectResponse PutProfileObject(PutProfileObjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileObjectResponseUnmarshaller.Instance;

            return Invoke<PutProfileObjectResponse>(request, options);
        }



        /// <summary>
        /// Adds additional objects to customer profiles of a given ObjectType.
        /// 
        ///  
        /// <para>
        /// When adding a specific profile object, like a Contact Record, an inferred profile
        /// can get created if it is not mapped to an existing profile. The resulting profile
        /// will only have a phone number populated in the standard ProfileObject. Any additional
        /// Contact Records with the same phone number will be mapped to the same inferred profile.
        /// </para>
        ///  
        /// <para>
        /// When a ProfileObject is created and if a ProfileObjectType already exists for the
        /// ProfileObject, it will provide data to a standard profile depending on the ProfileObjectType
        /// definition.
        /// </para>
        ///  
        /// <para>
        /// PutProfileObject needs an ObjectType, which can be created using PutProfileObjectType.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObject">REST API Reference for PutProfileObject Operation</seealso>
        public virtual Task<PutProfileObjectResponse> PutProfileObjectAsync(PutProfileObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutProfileObjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutProfileObjectType

        internal virtual PutProfileObjectTypeResponse PutProfileObjectType(PutProfileObjectTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileObjectTypeResponseUnmarshaller.Instance;

            return Invoke<PutProfileObjectTypeResponse>(request, options);
        }



        /// <summary>
        /// Defines a ProfileObjectType.
        /// 
        ///  
        /// <para>
        /// To add or remove tags on an existing ObjectType, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
        /// TagResource</a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObjectType">REST API Reference for PutProfileObjectType Operation</seealso>
        public virtual Task<PutProfileObjectTypeResponse> PutProfileObjectTypeAsync(PutProfileObjectTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileObjectTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileObjectTypeResponseUnmarshaller.Instance;

            return InvokeAsync<PutProfileObjectTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchProfiles

        internal virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchProfilesResponse>(request, options);
        }



        /// <summary>
        /// Searches for profiles within a specific domain using one or more predefined search
        /// keys (e.g., _fullName, _phone, _email, _account, etc.) and/or custom-defined search
        /// keys. A search key is a data type pair that consists of a <c>KeyName</c> and <c>Values</c>
        /// list.
        /// 
        ///  
        /// <para>
        /// This operation supports searching for profiles with a minimum of 1 key-value(s) pair
        /// and up to 5 key-value(s) pairs using either <c>AND</c> or <c>OR</c> logic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchProfiles service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartUploadJob

        internal virtual StartUploadJobResponse StartUploadJob(StartUploadJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUploadJobResponseUnmarshaller.Instance;

            return Invoke<StartUploadJobResponse>(request, options);
        }



        /// <summary>
        /// This API starts the processing of an upload job to ingest profile data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartUploadJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartUploadJob">REST API Reference for StartUploadJob Operation</seealso>
        public virtual Task<StartUploadJobResponse> StartUploadJobAsync(StartUploadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUploadJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartUploadJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopUploadJob

        internal virtual StopUploadJobResponse StopUploadJob(StopUploadJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUploadJobResponseUnmarshaller.Instance;

            return Invoke<StopUploadJobResponse>(request, options);
        }



        /// <summary>
        /// This API stops the processing of an upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopUploadJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopUploadJob">REST API Reference for StopUploadJob Operation</seealso>
        public virtual Task<StopUploadJobResponse> StopUploadJobAsync(StopUploadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopUploadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUploadJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopUploadJobResponse>(request, options, cancellationToken);
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
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Connect Customer
        /// Profiles resource. Tags can help you organize and categorize your resources. You can
        /// also use them to scope user permissions by granting a user permission to access or
        /// change only resources with certain tag values. In Connect Customer Profiles, domains,
        /// profile object types, and integrations can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the TagResource action with a resource that already has tags. If you specify
        /// a new tag key, this tag is appended to the list of tags associated with the resource.
        /// If you specify a tag key that is already associated with the resource, the new tag
        /// value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified Amazon Connect Customer Profiles resource.
        /// In Connect Customer Profiles, domains, profile object types, and integrations can
        /// be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCalculatedAttributeDefinition

        internal virtual UpdateCalculatedAttributeDefinitionResponse UpdateCalculatedAttributeDefinition(UpdateCalculatedAttributeDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateCalculatedAttributeDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing calculated attribute definition. When updating the Conditions,
        /// note that increasing the date range of a calculated attribute will not trigger inclusion
        /// of historical data greater than the current date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateCalculatedAttributeDefinition">REST API Reference for UpdateCalculatedAttributeDefinition Operation</seealso>
        public virtual Task<UpdateCalculatedAttributeDefinitionResponse> UpdateCalculatedAttributeDefinitionAsync(UpdateCalculatedAttributeDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCalculatedAttributeDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCalculatedAttributeDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCalculatedAttributeDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomain

        internal virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a domain, including creating or selecting a dead letter
        /// queue or an encryption key.
        /// 
        ///  
        /// <para>
        /// After a domain is created, the name can’t be changed.
        /// </para>
        ///  
        /// <para>
        /// Use this API or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
        /// to enable <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">identity
        /// resolution</a>: set <c>Matching</c> to true.
        /// </para>
        ///  
        /// <para>
        /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
        /// confused deputy prevention</a> for sample policies that you should apply. 
        /// </para>
        ///  
        /// <para>
        /// To add or remove tags on an existing Domain, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">TagResource</a>/<a
        /// href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomainLayout

        internal virtual UpdateDomainLayoutResponse UpdateDomainLayout(UpdateDomainLayoutRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainLayoutResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainLayoutResponse>(request, options);
        }



        /// <summary>
        /// Updates the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainLayout service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomainLayout">REST API Reference for UpdateDomainLayout Operation</seealso>
        public virtual Task<UpdateDomainLayoutResponse> UpdateDomainLayoutAsync(UpdateDomainLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainLayoutResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainLayoutResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEventTrigger

        internal virtual UpdateEventTriggerResponse UpdateEventTrigger(UpdateEventTriggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventTriggerResponseUnmarshaller.Instance;

            return Invoke<UpdateEventTriggerResponse>(request, options);
        }



        /// <summary>
        /// Update the properties of an Event Trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventTrigger service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateEventTrigger">REST API Reference for UpdateEventTrigger Operation</seealso>
        public virtual Task<UpdateEventTriggerResponse> UpdateEventTriggerAsync(UpdateEventTriggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventTriggerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventTriggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProfile

        internal virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a profile. The ProfileId is required for updating a customer
        /// profile.
        /// 
        ///  
        /// <para>
        /// When calling the UpdateProfile API, specifying an empty string value means that any
        /// existing value will be removed. Not specifying a string value means that any value
        /// already there will be kept.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileResponse>(request, options, cancellationToken);
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