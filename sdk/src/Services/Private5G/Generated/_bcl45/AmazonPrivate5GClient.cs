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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Private5G.Model;
using Amazon.Private5G.Model.Internal.MarshallTransformations;
using Amazon.Private5G.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Private5G
{
    /// <summary>
    /// Implementation for accessing Private5G
    ///
    /// Amazon Web Services Private 5G is a managed service that makes it easy to deploy,
    /// operate, and scale your own private mobile network at your on-premises location. Private
    /// 5G provides the pre-configured hardware and software for mobile networks, helps automate
    /// setup, and scales capacity on demand to support additional devices as needed.
    /// </summary>
    public partial class AmazonPrivate5GClient : AmazonServiceClient, IAmazonPrivate5G
    {
        private static IServiceMetadata serviceMetadata = new AmazonPrivate5GMetadata();
        private IPrivate5GPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPrivate5GPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Private5GPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPrivate5GClient with the credentials loaded from the application's
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
        public AmazonPrivate5GClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPrivate5GConfig()) { }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with the credentials loaded from the application's
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
        public AmazonPrivate5GClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPrivate5GConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPrivate5GClient Configuration Object</param>
        public AmazonPrivate5GClient(AmazonPrivate5GConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPrivate5GClient(AWSCredentials credentials)
            : this(credentials, new AmazonPrivate5GConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrivate5GClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPrivate5GConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Credentials and an
        /// AmazonPrivate5GClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPrivate5GClient Configuration Object</param>
        public AmazonPrivate5GClient(AWSCredentials credentials, AmazonPrivate5GConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPrivate5GConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPrivate5GConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPrivate5GClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPrivate5GClient Configuration Object</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPrivate5GConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPrivate5GConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPrivate5GConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrivate5GClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPrivate5GClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPrivate5GClient Configuration Object</param>
        public AmazonPrivate5GClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPrivate5GConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPrivate5GEndpointResolver());
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


        #region  AcknowledgeOrderReceipt


        /// <summary>
        /// Acknowledges that the specified network order was received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeOrderReceipt service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        public virtual AcknowledgeOrderReceiptResponse AcknowledgeOrderReceipt(AcknowledgeOrderReceiptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeOrderReceiptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeOrderReceiptResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeOrderReceiptResponse>(request, options);
        }


        /// <summary>
        /// Acknowledges that the specified network order was received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeOrderReceipt service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        public virtual Task<AcknowledgeOrderReceiptResponse> AcknowledgeOrderReceiptAsync(AcknowledgeOrderReceiptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeOrderReceiptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeOrderReceiptResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcknowledgeOrderReceiptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ActivateDeviceIdentifier


        /// <summary>
        /// Activates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the ActivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        public virtual ActivateDeviceIdentifierResponse ActivateDeviceIdentifier(ActivateDeviceIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateDeviceIdentifierResponseUnmarshaller.Instance;

            return Invoke<ActivateDeviceIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Activates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        public virtual Task<ActivateDeviceIdentifierResponse> ActivateDeviceIdentifierAsync(ActivateDeviceIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateDeviceIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<ActivateDeviceIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ActivateNetworkSite


        /// <summary>
        /// Activates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the ActivateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        public virtual ActivateNetworkSiteResponse ActivateNetworkSite(ActivateNetworkSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateNetworkSiteResponseUnmarshaller.Instance;

            return Invoke<ActivateNetworkSiteResponse>(request, options);
        }


        /// <summary>
        /// Activates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        public virtual Task<ActivateNetworkSiteResponse> ActivateNetworkSiteAsync(ActivateNetworkSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateNetworkSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<ActivateNetworkSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfigureAccessPoint


        /// <summary>
        /// Configures the specified network resource. 
        /// 
        ///  
        /// <para>
        ///  Use this action to specify the geographic position of the hardware. You must provide
        /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
        /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
        /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint service method.</param>
        /// 
        /// <returns>The response from the ConfigureAccessPoint service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        public virtual ConfigureAccessPointResponse ConfigureAccessPoint(ConfigureAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAccessPointResponseUnmarshaller.Instance;

            return Invoke<ConfigureAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Configures the specified network resource. 
        /// 
        ///  
        /// <para>
        ///  Use this action to specify the geographic position of the hardware. You must provide
        /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
        /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
        /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureAccessPoint service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        public virtual Task<ConfigureAccessPointResponse> ConfigureAccessPointAsync(ConfigureAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConfigureAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetwork


        /// <summary>
        /// Creates a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.LimitExceededException">
        /// The limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual CreateNetworkResponse CreateNetwork(CreateNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkResponse>(request, options);
        }


        /// <summary>
        /// Creates a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.LimitExceededException">
        /// The limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        public virtual Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkSite


        /// <summary>
        /// Creates a network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        public virtual CreateNetworkSiteResponse CreateNetworkSite(CreateNetworkSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSiteResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkSiteResponse>(request, options);
        }


        /// <summary>
        /// Creates a network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        public virtual Task<CreateNetworkSiteResponse> CreateNetworkSiteAsync(CreateNetworkSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNetworkSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeactivateDeviceIdentifier


        /// <summary>
        /// Deactivates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the DeactivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        public virtual DeactivateDeviceIdentifierResponse DeactivateDeviceIdentifier(DeactivateDeviceIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateDeviceIdentifierResponseUnmarshaller.Instance;

            return Invoke<DeactivateDeviceIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Deactivates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        public virtual Task<DeactivateDeviceIdentifierResponse> DeactivateDeviceIdentifierAsync(DeactivateDeviceIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateDeviceIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeactivateDeviceIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetwork


        /// <summary>
        /// Deletes the specified network. You must delete network sites before you delete the
        /// network. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_DeleteNetworkSite.html">DeleteNetworkSite</a>
        /// in the <i>API Reference for Amazon Web Services Private 5G</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        public virtual DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified network. You must delete network sites before you delete the
        /// network. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_DeleteNetworkSite.html">DeleteNetworkSite</a>
        /// in the <i>API Reference for Amazon Web Services Private 5G</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        public virtual Task<DeleteNetworkResponse> DeleteNetworkAsync(DeleteNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkSite


        /// <summary>
        /// Deletes the specified network site. Return the hardware after you delete the network
        /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
        /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        public virtual DeleteNetworkSiteResponse DeleteNetworkSite(DeleteNetworkSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSiteResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkSiteResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified network site. Return the hardware after you delete the network
        /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
        /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        public virtual Task<DeleteNetworkSiteResponse> DeleteNetworkSiteAsync(DeleteNetworkSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNetworkSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceIdentifier


        /// <summary>
        /// Gets the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        public virtual GetDeviceIdentifierResponse GetDeviceIdentifier(GetDeviceIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetDeviceIdentifierResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        public virtual Task<GetDeviceIdentifierResponse> GetDeviceIdentifierAsync(GetDeviceIdentifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceIdentifierResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeviceIdentifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetwork


        /// <summary>
        /// Gets the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual GetNetworkResponse GetNetwork(GetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        public virtual Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkResource


        /// <summary>
        /// Gets the specified network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        public virtual GetNetworkResourceResponse GetNetworkResource(GetNetworkResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourceResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        public virtual Task<GetNetworkResourceResponse> GetNetworkResourceAsync(GetNetworkResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNetworkResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkSite


        /// <summary>
        /// Gets the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        public virtual GetNetworkSiteResponse GetNetworkSite(GetNetworkSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSiteResponseUnmarshaller.Instance;

            return Invoke<GetNetworkSiteResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        public virtual Task<GetNetworkSiteResponse> GetNetworkSiteAsync(GetNetworkSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNetworkSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOrder


        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        public virtual GetOrderResponse GetOrder(GetOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrderResponseUnmarshaller.Instance;

            return Invoke<GetOrderResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        public virtual Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrderResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceIdentifiers


        /// <summary>
        /// Lists device identifiers. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order, the status
        /// of device identifiers, or the ARN of the traffic group.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListDeviceIdentifiers service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        public virtual ListDeviceIdentifiersResponse ListDeviceIdentifiers(ListDeviceIdentifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceIdentifiersResponseUnmarshaller.Instance;

            return Invoke<ListDeviceIdentifiersResponse>(request, options);
        }


        /// <summary>
        /// Lists device identifiers. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order, the status
        /// of device identifiers, or the ARN of the traffic group.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceIdentifiers service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        public virtual Task<ListDeviceIdentifiersResponse> ListDeviceIdentifiersAsync(ListDeviceIdentifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceIdentifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceIdentifiersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeviceIdentifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNetworkResources


        /// <summary>
        /// Lists network resources. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order or the
        /// status of network resources.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources service method.</param>
        /// 
        /// <returns>The response from the ListNetworkResources service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        public virtual ListNetworkResourcesResponse ListNetworkResources(ListNetworkResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkResourcesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkResourcesResponse>(request, options);
        }


        /// <summary>
        /// Lists network resources. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order or the
        /// status of network resources.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkResources service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        public virtual Task<ListNetworkResourcesResponse> ListNetworkResourcesAsync(ListNetworkResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNetworkResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNetworks


        /// <summary>
        /// Lists networks. Add filters to your request to return a more specific list of results.
        /// Use filters to match the status of the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual ListNetworksResponse ListNetworks(ListNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;

            return Invoke<ListNetworksResponse>(request, options);
        }


        /// <summary>
        /// Lists networks. Add filters to your request to return a more specific list of results.
        /// Use filters to match the status of the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        public virtual Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNetworkSites


        /// <summary>
        /// Lists network sites. Add filters to your request to return a more specific list of
        /// results. Use filters to match the status of the network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSites service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        public virtual ListNetworkSitesResponse ListNetworkSites(ListNetworkSitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSitesResponseUnmarshaller.Instance;

            return Invoke<ListNetworkSitesResponse>(request, options);
        }


        /// <summary>
        /// Lists network sites. Add filters to your request to return a more specific list of
        /// results. Use filters to match the status of the network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkSites service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        public virtual Task<ListNetworkSitesResponse> ListNetworkSitesAsync(ListNetworkSitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNetworkSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSitesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNetworkSitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrders


        /// <summary>
        /// Lists orders. Add filters to your request to return a more specific list of results.
        /// Use filters to match the Amazon Resource Name (ARN) of the network site or the status
        /// of the order.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        public virtual ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrdersResponseUnmarshaller.Instance;

            return Invoke<ListOrdersResponse>(request, options);
        }


        /// <summary>
        /// Lists orders. Add filters to your request to return a more specific list of results.
        /// Use filters to match the Amazon Resource Name (ARN) of the network site or the status
        /// of the order.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        public virtual Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrdersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrdersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Ping


        /// <summary>
        /// Checks the health of the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Ping service method.</param>
        /// 
        /// <returns>The response from the Ping service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        public virtual PingResponse Ping(PingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PingResponseUnmarshaller.Instance;

            return Invoke<PingResponse>(request, options);
        }


        /// <summary>
        /// Checks the health of the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Ping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Ping service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        public virtual Task<PingResponse> PingAsync(PingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartNetworkResourceUpdate


        /// <summary>
        /// Starts an update of the specified network resource.
        /// 
        ///  
        /// <para>
        /// After you submit a request to replace or return a network resource, the status of
        /// the network resource is <code>CREATING_SHIPPING_LABEL</code>. The shipping label is
        /// available when the status of the network resource is <code>PENDING_RETURN</code>.
        /// After the network resource is successfully returned, its status is <code>DELETED</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate service method.</param>
        /// 
        /// <returns>The response from the StartNetworkResourceUpdate service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        public virtual StartNetworkResourceUpdateResponse StartNetworkResourceUpdate(StartNetworkResourceUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNetworkResourceUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNetworkResourceUpdateResponseUnmarshaller.Instance;

            return Invoke<StartNetworkResourceUpdateResponse>(request, options);
        }


        /// <summary>
        /// Starts an update of the specified network resource.
        /// 
        ///  
        /// <para>
        /// After you submit a request to replace or return a network resource, the status of
        /// the network resource is <code>CREATING_SHIPPING_LABEL</code>. The shipping label is
        /// available when the status of the network resource is <code>PENDING_RETURN</code>.
        /// After the network resource is successfully returned, its status is <code>DELETED</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNetworkResourceUpdate service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        public virtual Task<StartNetworkResourceUpdateResponse> StartNetworkResourceUpdateAsync(StartNetworkResourceUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNetworkResourceUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNetworkResourceUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartNetworkResourceUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkSite


        /// <summary>
        /// Updates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        public virtual UpdateNetworkSiteResponse UpdateNetworkSite(UpdateNetworkSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSiteResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkSiteResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        public virtual Task<UpdateNetworkSiteResponse> UpdateNetworkSiteAsync(UpdateNetworkSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSiteResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNetworkSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkSitePlan


        /// <summary>
        /// Updates the specified network site plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSitePlan service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        public virtual UpdateNetworkSitePlanResponse UpdateNetworkSitePlan(UpdateNetworkSitePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSitePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSitePlanResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkSitePlanResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified network site plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSitePlan service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        public virtual Task<UpdateNetworkSitePlanResponse> UpdateNetworkSitePlanAsync(UpdateNetworkSitePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSitePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSitePlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNetworkSitePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}