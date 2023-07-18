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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkLink.Model;
using Amazon.WorkLink.Model.Internal.MarshallTransformations;
using Amazon.WorkLink.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkLink
{
    /// <summary>
    /// Implementation for accessing WorkLink
    ///
    /// Amazon WorkLink is a cloud-based service that provides secure access to internal websites
    /// and web apps from iOS and Android phones. In a single step, your users, such as employees,
    /// can access internal websites as efficiently as they access any other public website.
    /// They enter a URL in their web browser, or choose a link to an internal website in
    /// an email. Amazon WorkLink authenticates the user's access and securely renders authorized
    /// internal web content in a secure rendering service in the AWS cloud. Amazon WorkLink
    /// doesn't download or store any internal web content on mobile devices.
    /// </summary>
    public partial class AmazonWorkLinkClient : AmazonServiceClient, IAmazonWorkLink
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkLinkMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IWorkLinkPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkLinkPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkLinkPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AmazonWorkLinkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkLinkClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials and an
        /// AmazonWorkLinkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, AmazonWorkLinkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkLinkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkLinkConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkLinkEndpointResolver());
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


        #region  AssociateDomain

        /// <summary>
        /// Specifies a domain to be associated to Amazon WorkLink.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDomain service method.</param>
        /// 
        /// <returns>The response from the AssociateDomain service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateDomain">REST API Reference for AssociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateDomainResponse AssociateDomain(AssociateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDomainResponseUnmarshaller.Instance;

            return Invoke<AssociateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDomain operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateDomain">REST API Reference for AssociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginAssociateDomain(AssociateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDomain.</param>
        /// 
        /// <returns>Returns a  AssociateDomainResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateDomain">REST API Reference for AssociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateDomainResponse EndAssociateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWebsiteAuthorizationProvider

        /// <summary>
        /// Associates a website authorization provider with a specified fleet. This is used to
        /// authorize users against associated websites in the company network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteAuthorizationProvider service method.</param>
        /// 
        /// <returns>The response from the AssociateWebsiteAuthorizationProvider service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteAuthorizationProvider">REST API Reference for AssociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateWebsiteAuthorizationProviderResponse AssociateWebsiteAuthorizationProvider(AssociateWebsiteAuthorizationProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteAuthorizationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteAuthorizationProviderResponseUnmarshaller.Instance;

            return Invoke<AssociateWebsiteAuthorizationProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebsiteAuthorizationProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteAuthorizationProvider operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebsiteAuthorizationProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteAuthorizationProvider">REST API Reference for AssociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginAssociateWebsiteAuthorizationProvider(AssociateWebsiteAuthorizationProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteAuthorizationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteAuthorizationProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebsiteAuthorizationProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebsiteAuthorizationProvider.</param>
        /// 
        /// <returns>Returns a  AssociateWebsiteAuthorizationProviderResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteAuthorizationProvider">REST API Reference for AssociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateWebsiteAuthorizationProviderResponse EndAssociateWebsiteAuthorizationProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWebsiteAuthorizationProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWebsiteCertificateAuthority

        /// <summary>
        /// Imports the root certificate of a certificate authority (CA) used to obtain TLS certificates
        /// used by associated websites within the company network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the AssociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateWebsiteCertificateAuthorityResponse AssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<AssociateWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginAssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  AssociateWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual AssociateWebsiteCertificateAuthorityResponse EndAssociateWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleet

        /// <summary>
        /// Creates a fleet. A fleet consists of resources and the configuration that delivers
        /// associated websites to authorized users who download and set up the Amazon WorkLink
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleet

        /// <summary>
        /// Deletes a fleet. Prevents users from accessing previously associated websites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAuditStreamConfiguration

        /// <summary>
        /// Describes the configuration for delivering audit streams to the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeAuditStreamConfigurationResponse DescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditStreamConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditStreamConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditStreamConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAuditStreamConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeAuditStreamConfigurationResponse EndDescribeAuditStreamConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAuditStreamConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCompanyNetworkConfiguration

        /// <summary>
        /// Describes the networking configuration to access the internal websites associated
        /// with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeCompanyNetworkConfigurationResponse DescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeCompanyNetworkConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCompanyNetworkConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCompanyNetworkConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeCompanyNetworkConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeCompanyNetworkConfigurationResponse EndDescribeCompanyNetworkConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCompanyNetworkConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDevice

        /// <summary>
        /// Provides information about a user's device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDevicePolicyConfiguration

        /// <summary>
        /// Describes the device policy configuration for the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDevicePolicyConfigurationResponse DescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDevicePolicyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevicePolicyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevicePolicyConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeDevicePolicyConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDevicePolicyConfigurationResponse EndDescribeDevicePolicyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDevicePolicyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomain

        /// <summary>
        /// Provides information about the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetMetadata

        /// <summary>
        /// Provides basic information for the specified fleet, excluding identity provider, networking,
        /// and device configuration details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeFleetMetadataResponse DescribeFleetMetadata(DescribeFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeFleetMetadata(DescribeFleetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeFleetMetadataResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeFleetMetadataResponse EndDescribeFleetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityProviderConfiguration

        /// <summary>
        /// Describes the identity provider configuration of the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeIdentityProviderConfigurationResponse DescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeIdentityProviderConfigurationResponse EndDescribeIdentityProviderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityProviderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWebsiteCertificateAuthority

        /// <summary>
        /// Provides information about the certificate authority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DescribeWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeWebsiteCertificateAuthorityResponse DescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DescribeWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DescribeWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DescribeWebsiteCertificateAuthorityResponse EndDescribeWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDomain

        /// <summary>
        /// Disassociates a domain from Amazon WorkLink. End users lose the ability to access
        /// the domain with Amazon WorkLink.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDomain service method.</param>
        /// 
        /// <returns>The response from the DisassociateDomain service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateDomain">REST API Reference for DisassociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateDomainResponse DisassociateDomain(DisassociateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDomainResponseUnmarshaller.Instance;

            return Invoke<DisassociateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDomain operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateDomain">REST API Reference for DisassociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDisassociateDomain(DisassociateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDomain.</param>
        /// 
        /// <returns>Returns a  DisassociateDomainResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateDomain">REST API Reference for DisassociateDomain Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateDomainResponse EndDisassociateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWebsiteAuthorizationProvider

        /// <summary>
        /// Disassociates a website authorization provider from a specified fleet. After the disassociation,
        /// users can't load any associated websites that require this authorization provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteAuthorizationProvider service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebsiteAuthorizationProvider service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteAuthorizationProvider">REST API Reference for DisassociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateWebsiteAuthorizationProviderResponse DisassociateWebsiteAuthorizationProvider(DisassociateWebsiteAuthorizationProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteAuthorizationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteAuthorizationProviderResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebsiteAuthorizationProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebsiteAuthorizationProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteAuthorizationProvider operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebsiteAuthorizationProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteAuthorizationProvider">REST API Reference for DisassociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDisassociateWebsiteAuthorizationProvider(DisassociateWebsiteAuthorizationProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteAuthorizationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteAuthorizationProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebsiteAuthorizationProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebsiteAuthorizationProvider.</param>
        /// 
        /// <returns>Returns a  DisassociateWebsiteAuthorizationProviderResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteAuthorizationProvider">REST API Reference for DisassociateWebsiteAuthorizationProvider Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateWebsiteAuthorizationProviderResponse EndDisassociateWebsiteAuthorizationProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWebsiteAuthorizationProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWebsiteCertificateAuthority

        /// <summary>
        /// Removes a certificate authority (CA).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebsiteCertificateAuthority service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateWebsiteCertificateAuthorityResponse DisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebsiteCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebsiteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginDisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebsiteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DisassociateWebsiteCertificateAuthorityResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual DisassociateWebsiteCertificateAuthorityResponse EndDisassociateWebsiteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWebsiteCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Retrieves a list of devices registered with the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Retrieves a list of domains associated to a specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFleets

        /// <summary>
        /// Retrieves a list of fleets for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves a list of tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebsiteAuthorizationProviders

        /// <summary>
        /// Retrieves a list of website authorization providers associated with a specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteAuthorizationProviders service method.</param>
        /// 
        /// <returns>The response from the ListWebsiteAuthorizationProviders service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteAuthorizationProviders">REST API Reference for ListWebsiteAuthorizationProviders Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListWebsiteAuthorizationProvidersResponse ListWebsiteAuthorizationProviders(ListWebsiteAuthorizationProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteAuthorizationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteAuthorizationProvidersResponseUnmarshaller.Instance;

            return Invoke<ListWebsiteAuthorizationProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebsiteAuthorizationProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteAuthorizationProviders operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebsiteAuthorizationProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteAuthorizationProviders">REST API Reference for ListWebsiteAuthorizationProviders Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListWebsiteAuthorizationProviders(ListWebsiteAuthorizationProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteAuthorizationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteAuthorizationProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebsiteAuthorizationProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebsiteAuthorizationProviders.</param>
        /// 
        /// <returns>Returns a  ListWebsiteAuthorizationProvidersResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteAuthorizationProviders">REST API Reference for ListWebsiteAuthorizationProviders Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListWebsiteAuthorizationProvidersResponse EndListWebsiteAuthorizationProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebsiteAuthorizationProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebsiteCertificateAuthorities

        /// <summary>
        /// Retrieves a list of certificate authorities added for the current account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListWebsiteCertificateAuthorities service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListWebsiteCertificateAuthoritiesResponse ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListWebsiteCertificateAuthoritiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebsiteCertificateAuthorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebsiteCertificateAuthorities.</param>
        /// 
        /// <returns>Returns a  ListWebsiteCertificateAuthoritiesResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual ListWebsiteCertificateAuthoritiesResponse EndListWebsiteCertificateAuthorities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebsiteCertificateAuthoritiesResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDomainAccess

        /// <summary>
        /// Moves a domain to ACTIVE status if it was in the INACTIVE status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDomainAccess service method.</param>
        /// 
        /// <returns>The response from the RestoreDomainAccess service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RestoreDomainAccess">REST API Reference for RestoreDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual RestoreDomainAccessResponse RestoreDomainAccess(RestoreDomainAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDomainAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDomainAccessResponseUnmarshaller.Instance;

            return Invoke<RestoreDomainAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDomainAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDomainAccess operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDomainAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RestoreDomainAccess">REST API Reference for RestoreDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginRestoreDomainAccess(RestoreDomainAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDomainAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDomainAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDomainAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDomainAccess.</param>
        /// 
        /// <returns>Returns a  RestoreDomainAccessResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RestoreDomainAccess">REST API Reference for RestoreDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual RestoreDomainAccessResponse EndRestoreDomainAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDomainAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeDomainAccess

        /// <summary>
        /// Moves a domain to INACTIVE status if it was in the ACTIVE status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeDomainAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeDomainAccess service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RevokeDomainAccess">REST API Reference for RevokeDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual RevokeDomainAccessResponse RevokeDomainAccess(RevokeDomainAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDomainAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDomainAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeDomainAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDomainAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDomainAccess operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeDomainAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RevokeDomainAccess">REST API Reference for RevokeDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginRevokeDomainAccess(RevokeDomainAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDomainAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDomainAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeDomainAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeDomainAccess.</param>
        /// 
        /// <returns>Returns a  RevokeDomainAccessResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/RevokeDomainAccess">REST API Reference for RevokeDomainAccess Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual RevokeDomainAccessResponse EndRevokeDomainAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeDomainAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  SignOutUser

        /// <summary>
        /// Signs the user out from all of their devices. The user can sign in again if they have
        /// valid credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser service method.</param>
        /// 
        /// <returns>The response from the SignOutUser service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual SignOutUserResponse SignOutUser(SignOutUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return Invoke<SignOutUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignOutUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginSignOutUser(SignOutUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignOutUser.</param>
        /// 
        /// <returns>Returns a  SignOutUserResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual SignOutUserResponse EndSignOutUser(IAsyncResult asyncResult)
        {
            return EndInvoke<SignOutUserResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource, such as a fleet. Each
        /// tag consists of a key and an optional value. If a resource already has a tag with
        /// the same key, this operation updates its value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
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
        /// <returns>Returns a  TagResourceResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
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
        /// <returns>Returns a  UntagResourceResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuditStreamConfiguration

        /// <summary>
        /// Updates the audit stream configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAuditStreamConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateAuditStreamConfigurationResponse UpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAuditStreamConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuditStreamConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuditStreamConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAuditStreamConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateAuditStreamConfigurationResponse EndUpdateAuditStreamConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuditStreamConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCompanyNetworkConfiguration

        /// <summary>
        /// Updates the company network configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCompanyNetworkConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateCompanyNetworkConfigurationResponse UpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateCompanyNetworkConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCompanyNetworkConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCompanyNetworkConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateCompanyNetworkConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateCompanyNetworkConfigurationResponse EndUpdateCompanyNetworkConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCompanyNetworkConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevicePolicyConfiguration

        /// <summary>
        /// Updates the device policy configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDevicePolicyConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateDevicePolicyConfigurationResponse UpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePolicyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevicePolicyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevicePolicyConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateDevicePolicyConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateDevicePolicyConfigurationResponse EndUpdateDevicePolicyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevicePolicyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainMetadata

        /// <summary>
        /// Updates domain metadata, such as DisplayName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDomainMetadata">REST API Reference for UpdateDomainMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateDomainMetadataResponse UpdateDomainMetadata(UpdateDomainMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainMetadata operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDomainMetadata">REST API Reference for UpdateDomainMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateDomainMetadata(UpdateDomainMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDomainMetadataResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDomainMetadata">REST API Reference for UpdateDomainMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateDomainMetadataResponse EndUpdateDomainMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFleetMetadata

        /// <summary>
        /// Updates fleet metadata, such as DisplayName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetMetadata service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateFleetMetadataResponse UpdateFleetMetadata(UpdateFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateFleetMetadata(UpdateFleetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateFleetMetadataResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateFleetMetadataResponse EndUpdateFleetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityProviderConfiguration

        /// <summary>
        /// Updates the identity provider configuration for the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderConfiguration service method, as returned by WorkLink.</returns>
        /// <exception cref="Amazon.WorkLink.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.WorkLink.Model.UnauthorizedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateIdentityProviderConfigurationResponse UpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration operation on AmazonWorkLinkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual IAsyncResult BeginUpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderConfigurationResult from WorkLink.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        [Obsolete("Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.")]
        public virtual UpdateIdentityProviderConfigurationResponse EndUpdateIdentityProviderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityProviderConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}