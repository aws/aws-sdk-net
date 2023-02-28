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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ServiceCatalog.Model;
using Amazon.ServiceCatalog.Model.Internal.MarshallTransformations;
using Amazon.ServiceCatalog.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServiceCatalog
{
    /// <summary>
    /// Implementation for accessing ServiceCatalog
    ///
    /// Service Catalog 
    /// <para>
    ///  <a href="http://aws.amazon.com/servicecatalog">Service Catalog</a> enables organizations
    /// to create and manage catalogs of IT services that are approved for Amazon Web Services.
    /// To get the most out of this documentation, you should be familiar with the terminology
    /// discussed in <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/what-is_concepts.html">Service
    /// Catalog Concepts</a>.
    /// </para>
    /// </summary>
    public partial class AmazonServiceCatalogClient : AmazonServiceClient, IAmazonServiceCatalog
    {
        private static IServiceMetadata serviceMetadata = new AmazonServiceCatalogMetadata();
        private IServiceCatalogPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IServiceCatalogPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ServiceCatalogPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        public AmazonServiceCatalogClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceCatalogConfig()) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        public AmazonServiceCatalogClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceCatalogConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(AmazonServiceCatalogConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials)
            : this(credentials, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServiceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Credentials and an
        /// AmazonServiceCatalogClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(AWSCredentials credentials, AmazonServiceCatalogConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceCatalogConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServiceCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServiceCatalogClient Configuration Object</param>
        public AmazonServiceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServiceCatalogConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServiceCatalogEndpointResolver());
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


        #region  AcceptPortfolioShare


        /// <summary>
        /// Accepts an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<AcceptPortfolioShareResponse>(request, options);
        }


        /// <summary>
        /// Accepts an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual Task<AcceptPortfolioShareResponse> AcceptPortfolioShareAsync(AcceptPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateBudgetWithResource


        /// <summary>
        /// Associates the specified budget with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBudgetWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateBudgetWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateBudgetWithResource">REST API Reference for AssociateBudgetWithResource Operation</seealso>
        public virtual AssociateBudgetWithResourceResponse AssociateBudgetWithResource(AssociateBudgetWithResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBudgetWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBudgetWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateBudgetWithResourceResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified budget with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBudgetWithResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBudgetWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateBudgetWithResource">REST API Reference for AssociateBudgetWithResource Operation</seealso>
        public virtual Task<AssociateBudgetWithResourceResponse> AssociateBudgetWithResourceAsync(AssociateBudgetWithResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateBudgetWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBudgetWithResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateBudgetWithResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociatePrincipalWithPortfolio


        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// If you share the portfolio with principal name sharing enabled, the <code>PrincipalARN</code>
        /// association is included in the share. 
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioID</code>, <code>PrincipalARN</code>, and <code>PrincipalType</code>
        /// parameters are required. 
        /// </para>
        ///  
        /// <para>
        /// You can associate a maximum of 10 Principals with a portfolio using <code>PrincipalType</code>
        /// as <code>IAM_PATTERN</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociatePrincipalWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociatePrincipalWithPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// If you share the portfolio with principal name sharing enabled, the <code>PrincipalARN</code>
        /// association is included in the share. 
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioID</code>, <code>PrincipalARN</code>, and <code>PrincipalType</code>
        /// parameters are required. 
        /// </para>
        ///  
        /// <para>
        /// You can associate a maximum of 10 Principals with a portfolio using <code>PrincipalType</code>
        /// as <code>IAM_PATTERN</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePrincipalWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual Task<AssociatePrincipalWithPortfolioResponse> AssociatePrincipalWithPortfolioAsync(AssociatePrincipalWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociatePrincipalWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio


        /// <summary>
        /// Associates the specified product with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociateProductWithPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified product with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual Task<AssociateProductWithPortfolioResponse> AssociateProductWithPortfolioAsync(AssociateProductWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateProductWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates a self-service action with a provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual AssociateServiceActionWithProvisioningArtifactResponse AssociateServiceActionWithProvisioningArtifact(AssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Associates a self-service action with a provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual Task<AssociateServiceActionWithProvisioningArtifactResponse> AssociateServiceActionWithProvisioningArtifactAsync(AssociateServiceActionWithProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateServiceActionWithProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTagOptionWithResource


        /// <summary>
        /// Associate the specified TagOption with the specified portfolio or product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateTagOptionWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateTagOptionWithResourceResponse>(request, options);
        }


        /// <summary>
        /// Associate the specified TagOption with the specified portfolio or product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTagOptionWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual Task<AssociateTagOptionWithResourceResponse> AssociateTagOptionWithResourceAsync(AssociateTagOptionWithResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateTagOptionWithResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates multiple self-service actions with provisioning artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual BatchAssociateServiceActionWithProvisioningArtifactResponse BatchAssociateServiceActionWithProvisioningArtifact(BatchAssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Associates multiple self-service actions with provisioning artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        public virtual Task<BatchAssociateServiceActionWithProvisioningArtifactResponse> BatchAssociateServiceActionWithProvisioningArtifactAsync(BatchAssociateServiceActionWithProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateServiceActionWithProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates a batch of self-service actions from the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual BatchDisassociateServiceActionFromProvisioningArtifactResponse BatchDisassociateServiceActionFromProvisioningArtifact(BatchDisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a batch of self-service actions from the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual Task<BatchDisassociateServiceActionFromProvisioningArtifactResponse> BatchDisassociateServiceActionFromProvisioningArtifactAsync(BatchDisassociateServiceActionFromProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateServiceActionFromProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyProduct


        /// <summary>
        /// Copies the specified source product to the specified target product or a new product.
        /// 
        ///  
        /// <para>
        /// You can copy a product to the same account or another account. You can copy a product
        /// to the same Region or another Region. If you copy a product to another account, you
        /// must first share the product in a portfolio using <a>CreatePortfolioShare</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is performed asynchronously. To track the progress of the operation,
        /// use <a>DescribeCopyProductStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct service method.</param>
        /// 
        /// <returns>The response from the CopyProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual CopyProductResponse CopyProduct(CopyProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;

            return Invoke<CopyProductResponse>(request, options);
        }


        /// <summary>
        /// Copies the specified source product to the specified target product or a new product.
        /// 
        ///  
        /// <para>
        /// You can copy a product to the same account or another account. You can copy a product
        /// to the same Region or another Region. If you copy a product to another account, you
        /// must first share the product in a portfolio using <a>CreatePortfolioShare</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is performed asynchronously. To track the progress of the operation,
        /// use <a>DescribeCopyProductStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual Task<CopyProductResponse> CopyProductAsync(CopyProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConstraint


        /// <summary>
        /// Creates a constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual CreateConstraintResponse CreateConstraint(CreateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return Invoke<CreateConstraintResponse>(request, options);
        }


        /// <summary>
        /// Creates a constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual Task<CreateConstraintResponse> CreateConstraintAsync(CreateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolio


        /// <summary>
        /// Creates a portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioResponse>(request, options);
        }


        /// <summary>
        /// Creates a portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual Task<CreatePortfolioResponse> CreatePortfolioAsync(CreatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolioShare


        /// <summary>
        /// Shares the specified portfolio with the specified account or organization node. Shares
        /// to an organization node can only be created by the management account of an organization
        /// or by a delegated administrator. You can share portfolios to an organization, an organizational
        /// unit, or a specific account.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, they can no longer create portfolio
        /// shares.
        /// </para>
        ///  
        /// <para>
        ///  <code>AWSOrganizationsAccess</code> must be enabled in order to create a portfolio
        /// share to an organization node.
        /// </para>
        ///  
        /// <para>
        /// You can't share a shared resource, including portfolios that contain a shared product.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio share with the specified account or organization node already exists,
        /// this action will have no effect and will not return an error. To update an existing
        /// share, you must use the <code> UpdatePortfolioShare</code> API instead. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioShareResponse>(request, options);
        }


        /// <summary>
        /// Shares the specified portfolio with the specified account or organization node. Shares
        /// to an organization node can only be created by the management account of an organization
        /// or by a delegated administrator. You can share portfolios to an organization, an organizational
        /// unit, or a specific account.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, they can no longer create portfolio
        /// shares.
        /// </para>
        ///  
        /// <para>
        ///  <code>AWSOrganizationsAccess</code> must be enabled in order to create a portfolio
        /// share to an organization node.
        /// </para>
        ///  
        /// <para>
        /// You can't share a shared resource, including portfolios that contain a shared product.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio share with the specified account or organization node already exists,
        /// this action will have no effect and will not return an error. To update an existing
        /// share, you must use the <code> UpdatePortfolioShare</code> API instead. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual Task<CreatePortfolioShareResponse> CreatePortfolioShareAsync(CreatePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProduct


        /// <summary>
        /// Creates a product.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductResponse>(request, options);
        }


        /// <summary>
        /// Creates a product.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisionedProductPlan


        /// <summary>
        /// Creates a plan.
        /// 
        ///  
        /// <para>
        /// A plan includes the list of resources to be created (when provisioning a new product)
        /// or modified (when updating a provisioned product) when the plan is executed.
        /// </para>
        ///  
        /// <para>
        /// You can create one plan for each provisioned product. To create a plan for an existing
        /// provisioned product, the product status must be AVAILABLE or TAINTED.
        /// </para>
        ///  
        /// <para>
        /// To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
        /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual CreateProvisionedProductPlanResponse CreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedProductPlanResponse>(request, options);
        }


        /// <summary>
        /// Creates a plan.
        /// 
        ///  
        /// <para>
        /// A plan includes the list of resources to be created (when provisioning a new product)
        /// or modified (when updating a provisioned product) when the plan is executed.
        /// </para>
        ///  
        /// <para>
        /// You can create one plan for each provisioned product. To create a plan for an existing
        /// provisioned product, the product status must be AVAILABLE or TAINTED.
        /// </para>
        ///  
        /// <para>
        /// To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
        /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual Task<CreateProvisionedProductPlanResponse> CreateProvisionedProductPlanAsync(CreateProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningArtifact


        /// <summary>
        /// Creates a provisioning artifact (also known as a version) for the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot create a provisioning artifact for a product that was shared with you.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Creates a provisioning artifact (also known as a version) for the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot create a provisioning artifact for a product that was shared with you.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual Task<CreateProvisioningArtifactResponse> CreateProvisioningArtifactAsync(CreateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceAction


        /// <summary>
        /// Creates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction service method.</param>
        /// 
        /// <returns>The response from the CreateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        public virtual CreateServiceActionResponse CreateServiceAction(CreateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceActionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Creates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        public virtual Task<CreateServiceActionResponse> CreateServiceActionAsync(CreateServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTagOption


        /// <summary>
        /// Creates a TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption service method.</param>
        /// 
        /// <returns>The response from the CreateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return Invoke<CreateTagOptionResponse>(request, options);
        }


        /// <summary>
        /// Creates a TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual Task<CreateTagOptionResponse> CreateTagOptionAsync(CreateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConstraint


        /// <summary>
        /// Deletes the specified constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint service method.</param>
        /// 
        /// <returns>The response from the DeleteConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return Invoke<DeleteConstraintResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual Task<DeleteConstraintResponse> DeleteConstraintAsync(DeleteConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolio


        /// <summary>
        /// Deletes the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot delete a portfolio if it was shared with you or if it has associated products,
        /// users, constraints, or shared accounts.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot delete a portfolio if it was shared with you or if it has associated products,
        /// users, constraints, or shared accounts.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual Task<DeletePortfolioResponse> DeletePortfolioAsync(DeletePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolioShare


        /// <summary>
        /// Stops sharing the specified portfolio with the specified account or organization node.
        /// Shares to an organization node can only be deleted by the management account of an
        /// organization or by a delegated administrator.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, portfolio shares created from that
        /// account are removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioShareResponse>(request, options);
        }


        /// <summary>
        /// Stops sharing the specified portfolio with the specified account or organization node.
        /// Shares to an organization node can only be deleted by the management account of an
        /// organization or by a delegated administrator.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, portfolio shares created from that
        /// account are removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual Task<DeletePortfolioShareResponse> DeletePortfolioShareAsync(DeletePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProduct


        /// <summary>
        /// Deletes the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a product if it was shared with you or is associated with a portfolio.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a product if it was shared with you or is associated with a portfolio.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisionedProductPlan


        /// <summary>
        /// Deletes the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual DeleteProvisionedProductPlanResponse DeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedProductPlanResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual Task<DeleteProvisionedProductPlanResponse> DeleteProvisionedProductPlanAsync(DeleteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningArtifact


        /// <summary>
        /// Deletes the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a provisioning artifact associated with a product that was shared
        /// with you. You cannot delete the last provisioning artifact for a product, because
        /// a product must have at least one provisioning artifact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a provisioning artifact associated with a product that was shared
        /// with you. You cannot delete the last provisioning artifact for a product, because
        /// a product must have at least one provisioning artifact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual Task<DeleteProvisioningArtifactResponse> DeleteProvisioningArtifactAsync(DeleteProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceAction


        /// <summary>
        /// Deletes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        public virtual DeleteServiceActionResponse DeleteServiceAction(DeleteServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceActionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        public virtual Task<DeleteServiceActionResponse> DeleteServiceActionAsync(DeleteServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagOption


        /// <summary>
        /// Deletes the specified TagOption.
        /// 
        ///  
        /// <para>
        /// You cannot delete a TagOption if it is associated with a product or portfolio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption service method.</param>
        /// 
        /// <returns>The response from the DeleteTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTagOptionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified TagOption.
        /// 
        ///  
        /// <para>
        /// You cannot delete a TagOption if it is associated with a product or portfolio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual Task<DeleteTagOptionResponse> DeleteTagOptionAsync(DeleteTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConstraint


        /// <summary>
        /// Gets information about the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return Invoke<DescribeConstraintResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual Task<DescribeConstraintResponse> DescribeConstraintAsync(DescribeConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCopyProductStatus


        /// <summary>
        /// Gets the status of the specified copy product operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeCopyProductStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual DescribeCopyProductStatusResponse DescribeCopyProductStatus(DescribeCopyProductStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyProductStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the status of the specified copy product operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCopyProductStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual Task<DescribeCopyProductStatusResponse> DescribeCopyProductStatusAsync(DescribeCopyProductStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCopyProductStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolio


        /// <summary>
        /// Gets information about the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual Task<DescribePortfolioResponse> DescribePortfolioAsync(DescribePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolioShares


        /// <summary>
        /// Returns a summary of each of the portfolio shares that were created for the specified
        /// portfolio.
        /// 
        ///  
        /// <para>
        /// You can use this API to determine which accounts or organizational nodes this portfolio
        /// have been shared, whether the recipient entity has imported the share, and whether
        /// TagOptions are included with the share.
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioId</code> and <code>Type</code> parameters are both required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShares service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShares">REST API Reference for DescribePortfolioShares Operation</seealso>
        public virtual DescribePortfolioSharesResponse DescribePortfolioShares(DescribePortfolioSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioSharesResponse>(request, options);
        }


        /// <summary>
        /// Returns a summary of each of the portfolio shares that were created for the specified
        /// portfolio.
        /// 
        ///  
        /// <para>
        /// You can use this API to determine which accounts or organizational nodes this portfolio
        /// have been shared, whether the recipient entity has imported the share, and whether
        /// TagOptions are included with the share.
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioId</code> and <code>Type</code> parameters are both required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShares">REST API Reference for DescribePortfolioShares Operation</seealso>
        public virtual Task<DescribePortfolioSharesResponse> DescribePortfolioSharesAsync(DescribePortfolioSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioSharesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortfolioSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolioShareStatus


        /// <summary>
        /// Gets the status of the specified portfolio share operation. This API can only be called
        /// by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolioShareStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        public virtual DescribePortfolioShareStatusResponse DescribePortfolioShareStatus(DescribePortfolioShareStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioShareStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioShareStatusResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioShareStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the status of the specified portfolio share operation. This API can only be called
        /// by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePortfolioShareStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        public virtual Task<DescribePortfolioShareStatusResponse> DescribePortfolioShareStatusAsync(DescribePortfolioShareStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioShareStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioShareStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePortfolioShareStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProduct


        /// <summary>
        /// Gets information about the specified product.
        /// 
        ///  <note> 
        /// <para>
        ///  Running this operation with administrator access results in a failure. <a>DescribeProductAsAdmin</a>
        /// should be used instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProductResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified product.
        /// 
        ///  <note> 
        /// <para>
        ///  Running this operation with administrator access results in a failure. <a>DescribeProductAsAdmin</a>
        /// should be used instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductAsAdmin


        /// <summary>
        /// Gets information about the specified product. This operation is run with administrator
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeProductAsAdminResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified product. This operation is run with administrator
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual Task<DescribeProductAsAdminResponse> DescribeProductAsAdminAsync(DescribeProductAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductView


        /// <summary>
        /// Gets information about the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return Invoke<DescribeProductViewResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual Task<DescribeProductViewResponse> DescribeProductViewAsync(DescribeProductViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProduct


        /// <summary>
        /// Gets information about the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual Task<DescribeProvisionedProductResponse> DescribeProvisionedProductAsync(DescribeProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProductPlan


        /// <summary>
        /// Gets information about the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual DescribeProvisionedProductPlanResponse DescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductPlanResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual Task<DescribeProvisionedProductPlanResponse> DescribeProvisionedProductPlanAsync(DescribeProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningArtifact


        /// <summary>
        /// Gets information about the specified provisioning artifact (also known as a version)
        /// for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified provisioning artifact (also known as a version)
        /// for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual Task<DescribeProvisioningArtifactResponse> DescribeProvisioningArtifactAsync(DescribeProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningParameters


        /// <summary>
        /// Gets information about the configuration required to provision the specified product
        /// using the specified provisioning artifact.
        /// 
        ///  
        /// <para>
        /// If the output contains a TagOption key with an empty list of values, there is a TagOption
        /// conflict for that key. The end user cannot take action to fix the conflict, and launch
        /// is not blocked. In subsequent calls to <a>ProvisionProduct</a>, do not include conflicted
        /// TagOption keys as tags, or this causes the error "Parameter validation failed: Missing
        /// required parameter in Tags[<i>N</i>]:<i>Value</i>". Tag the provisioned product with
        /// the value <code>sc-tagoption-conflict-portfolioId-productId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningParametersResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the configuration required to provision the specified product
        /// using the specified provisioning artifact.
        /// 
        ///  
        /// <para>
        /// If the output contains a TagOption key with an empty list of values, there is a TagOption
        /// conflict for that key. The end user cannot take action to fix the conflict, and launch
        /// is not blocked. In subsequent calls to <a>ProvisionProduct</a>, do not include conflicted
        /// TagOption keys as tags, or this causes the error "Parameter validation failed: Missing
        /// required parameter in Tags[<i>N</i>]:<i>Value</i>". Tag the provisioned product with
        /// the value <code>sc-tagoption-conflict-portfolioId-productId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual Task<DescribeProvisioningParametersResponse> DescribeProvisioningParametersAsync(DescribeProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProvisioningParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecord


        /// <summary>
        /// Gets information about the specified request operation.
        /// 
        ///  
        /// <para>
        /// Use this operation after calling a request operation (for example, <a>ProvisionProduct</a>,
        /// <a>TerminateProvisionedProduct</a>, or <a>UpdateProvisionedProduct</a>). 
        /// </para>
        ///  <note> 
        /// <para>
        /// If a provisioned product was transferred to a new owner using <a>UpdateProvisionedProductProperties</a>,
        /// the new owner will be able to describe all past records for that product. The previous
        /// owner will no longer be able to describe the records, but will be able to use <a>ListRecordHistory</a>
        /// to see the product's history from when he was the owner.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return Invoke<DescribeRecordResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified request operation.
        /// 
        ///  
        /// <para>
        /// Use this operation after calling a request operation (for example, <a>ProvisionProduct</a>,
        /// <a>TerminateProvisionedProduct</a>, or <a>UpdateProvisionedProduct</a>). 
        /// </para>
        ///  <note> 
        /// <para>
        /// If a provisioned product was transferred to a new owner using <a>UpdateProvisionedProductProperties</a>,
        /// the new owner will be able to describe all past records for that product. The previous
        /// owner will no longer be able to describe the records, but will be able to use <a>ListRecordHistory</a>
        /// to see the product's history from when he was the owner.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual Task<DescribeRecordResponse> DescribeRecordAsync(DescribeRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceAction


        /// <summary>
        /// Describes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        public virtual DescribeServiceActionResponse DescribeServiceAction(DescribeServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Describes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        public virtual Task<DescribeServiceActionResponse> DescribeServiceActionAsync(DescribeServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceActionExecutionParameters


        /// <summary>
        /// Finds the default parameters for a specific self-service action on a specific provisioned
        /// product and returns a map of the results to the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceActionExecutionParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceActionExecutionParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceActionExecutionParameters">REST API Reference for DescribeServiceActionExecutionParameters Operation</seealso>
        public virtual DescribeServiceActionExecutionParametersResponse DescribeServiceActionExecutionParameters(DescribeServiceActionExecutionParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionExecutionParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionExecutionParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceActionExecutionParametersResponse>(request, options);
        }


        /// <summary>
        /// Finds the default parameters for a specific self-service action on a specific provisioned
        /// product and returns a map of the results to the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceActionExecutionParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceActionExecutionParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceActionExecutionParameters">REST API Reference for DescribeServiceActionExecutionParameters Operation</seealso>
        public virtual Task<DescribeServiceActionExecutionParametersResponse> DescribeServiceActionExecutionParametersAsync(DescribeServiceActionExecutionParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionExecutionParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionExecutionParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServiceActionExecutionParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTagOption


        /// <summary>
        /// Gets information about the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption service method.</param>
        /// 
        /// <returns>The response from the DescribeTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return Invoke<DescribeTagOptionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual Task<DescribeTagOptionResponse> DescribeTagOptionAsync(DescribeTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAWSOrganizationsAccess


        /// <summary>
        /// Disable portfolio sharing through the Organizations service. This command will not
        /// delete your current shares, but prevents you from creating new shares throughout your
        /// organization. Current shares are not kept in sync with your organization structure
        /// if the structure changes after calling this API. Only the management account in the
        /// organization can call this API.
        /// 
        ///  
        /// <para>
        /// You cannot call this API if there are active delegated administrators in the organization.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>DisableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you share an Service Catalog portfolio in an organization within Organizations,
        /// and then disable Organizations access for Service Catalog, the portfolio access permissions
        /// will not sync with the latest changes to the organization structure. Specifically,
        /// accounts that you removed from the organization after disabling Service Catalog access
        /// will retain access to the previously shared portfolio.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the DisableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        public virtual DisableAWSOrganizationsAccessResponse DisableAWSOrganizationsAccess(DisableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<DisableAWSOrganizationsAccessResponse>(request, options);
        }


        /// <summary>
        /// Disable portfolio sharing through the Organizations service. This command will not
        /// delete your current shares, but prevents you from creating new shares throughout your
        /// organization. Current shares are not kept in sync with your organization structure
        /// if the structure changes after calling this API. Only the management account in the
        /// organization can call this API.
        /// 
        ///  
        /// <para>
        /// You cannot call this API if there are active delegated administrators in the organization.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>DisableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you share an Service Catalog portfolio in an organization within Organizations,
        /// and then disable Organizations access for Service Catalog, the portfolio access permissions
        /// will not sync with the latest changes to the organization structure. Specifically,
        /// accounts that you removed from the organization after disabling Service Catalog access
        /// will retain access to the previously shared portfolio.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        public virtual Task<DisableAWSOrganizationsAccessResponse> DisableAWSOrganizationsAccessAsync(DisableAWSOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableAWSOrganizationsAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateBudgetFromResource


        /// <summary>
        /// Disassociates the specified budget from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBudgetFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateBudgetFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateBudgetFromResource">REST API Reference for DisassociateBudgetFromResource Operation</seealso>
        public virtual DisassociateBudgetFromResourceResponse DisassociateBudgetFromResource(DisassociateBudgetFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBudgetFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBudgetFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateBudgetFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified budget from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBudgetFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBudgetFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateBudgetFromResource">REST API Reference for DisassociateBudgetFromResource Operation</seealso>
        public virtual Task<DisassociateBudgetFromResourceResponse> DisassociateBudgetFromResourceAsync(DisassociateBudgetFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateBudgetFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBudgetFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateBudgetFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio


        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
        /// 
        ///  
        /// <para>
        /// The <code>PrincipalType</code> and <code>PrincipalARN</code> must match the <code>AssociatePrincipalWithPortfolio</code>
        /// call request details. For example, to disassociate an association created with a <code>PrincipalARN</code>
        /// of <code>PrincipalType</code> IAM you must use the <code>PrincipalType</code> IAM
        /// when calling <code>DisassociatePrincipalFromPortfolio</code>. 
        /// </para>
        ///  
        /// <para>
        /// For portfolios that have been shared with principal name sharing enabled: after disassociating
        /// a principal, share recipient accounts will no longer be able to provision products
        /// in this portfolio using a role matching the name of the associated principal. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociatePrincipalFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociatePrincipalFromPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
        /// 
        ///  
        /// <para>
        /// The <code>PrincipalType</code> and <code>PrincipalARN</code> must match the <code>AssociatePrincipalWithPortfolio</code>
        /// call request details. For example, to disassociate an association created with a <code>PrincipalARN</code>
        /// of <code>PrincipalType</code> IAM you must use the <code>PrincipalType</code> IAM
        /// when calling <code>DisassociatePrincipalFromPortfolio</code>. 
        /// </para>
        ///  
        /// <para>
        /// For portfolios that have been shared with principal name sharing enabled: after disassociating
        /// a principal, share recipient accounts will no longer be able to provision products
        /// in this portfolio using a role matching the name of the associated principal. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePrincipalFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual Task<DisassociatePrincipalFromPortfolioResponse> DisassociatePrincipalFromPortfolioAsync(DisassociatePrincipalFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociatePrincipalFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateProductFromPortfolio


        /// <summary>
        /// Disassociates the specified product from the specified portfolio. 
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociateProductFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociateProductFromPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified product from the specified portfolio. 
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateProductFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual Task<DisassociateProductFromPortfolioResponse> DisassociateProductFromPortfolioAsync(DisassociateProductFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateProductFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates the specified self-service action association from the specified provisioning
        /// artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual DisassociateServiceActionFromProvisioningArtifactResponse DisassociateServiceActionFromProvisioningArtifact(DisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified self-service action association from the specified provisioning
        /// artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        public virtual Task<DisassociateServiceActionFromProvisioningArtifactResponse> DisassociateServiceActionFromProvisioningArtifactAsync(DisassociateServiceActionFromProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateServiceActionFromProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTagOptionFromResource


        /// <summary>
        /// Disassociates the specified TagOption from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateTagOptionFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateTagOptionFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified TagOption from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTagOptionFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual Task<DisassociateTagOptionFromResourceResponse> DisassociateTagOptionFromResourceAsync(DisassociateTagOptionFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateTagOptionFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAWSOrganizationsAccess


        /// <summary>
        /// Enable portfolio sharing feature through Organizations. This API will allow Service
        /// Catalog to receive updates on your organization in order to sync your shares with
        /// the current structure. This API can only be called by the management account in the
        /// organization.
        /// 
        ///  
        /// <para>
        /// When you call this API, Service Catalog calls <code>organizations:EnableAWSServiceAccess</code>
        /// on your behalf so that your shares stay in sync with any changes in your Organizations
        /// structure.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>EnableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you have previously disabled Organizations access for Service Catalog, and then
        /// enable access again, the portfolio access permissions might not sync with the latest
        /// changes to the organization structure. Specifically, accounts that you removed from
        /// the organization after disabling Service Catalog access, and before you enabled access
        /// again, can retain access to the previously shared portfolio. As a result, an account
        /// that has been removed from the organization might still be able to create or manage
        /// Amazon Web Services resources when it is no longer authorized to do so. Amazon Web
        /// Services is working to resolve this issue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the EnableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        public virtual EnableAWSOrganizationsAccessResponse EnableAWSOrganizationsAccess(EnableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<EnableAWSOrganizationsAccessResponse>(request, options);
        }


        /// <summary>
        /// Enable portfolio sharing feature through Organizations. This API will allow Service
        /// Catalog to receive updates on your organization in order to sync your shares with
        /// the current structure. This API can only be called by the management account in the
        /// organization.
        /// 
        ///  
        /// <para>
        /// When you call this API, Service Catalog calls <code>organizations:EnableAWSServiceAccess</code>
        /// on your behalf so that your shares stay in sync with any changes in your Organizations
        /// structure.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>EnableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you have previously disabled Organizations access for Service Catalog, and then
        /// enable access again, the portfolio access permissions might not sync with the latest
        /// changes to the organization structure. Specifically, accounts that you removed from
        /// the organization after disabling Service Catalog access, and before you enabled access
        /// again, can retain access to the previously shared portfolio. As a result, an account
        /// that has been removed from the organization might still be able to create or manage
        /// Amazon Web Services resources when it is no longer authorized to do so. Amazon Web
        /// Services is working to resolve this issue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        public virtual Task<EnableAWSOrganizationsAccessResponse> EnableAWSOrganizationsAccessAsync(EnableAWSOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSOrganizationsAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableAWSOrganizationsAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductPlan


        /// <summary>
        /// Provisions or modifies a product based on the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual ExecuteProvisionedProductPlanResponse ExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductPlanResponse>(request, options);
        }


        /// <summary>
        /// Provisions or modifies a product based on the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual Task<ExecuteProvisionedProductPlanResponse> ExecuteProvisionedProductPlanAsync(ExecuteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductServiceAction


        /// <summary>
        /// Executes a self-service action against a provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        public virtual ExecuteProvisionedProductServiceActionResponse ExecuteProvisionedProductServiceAction(ExecuteProvisionedProductServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductServiceActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Executes a self-service action against a provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        public virtual Task<ExecuteProvisionedProductServiceActionResponse> ExecuteProvisionedProductServiceActionAsync(ExecuteProvisionedProductServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteProvisionedProductServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAWSOrganizationsAccessStatus


        /// <summary>
        /// Get the Access Status for Organizations portfolio share feature. This API can only
        /// be called by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus service method.</param>
        /// 
        /// <returns>The response from the GetAWSOrganizationsAccessStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        public virtual GetAWSOrganizationsAccessStatusResponse GetAWSOrganizationsAccessStatus(GetAWSOrganizationsAccessStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;

            return Invoke<GetAWSOrganizationsAccessStatusResponse>(request, options);
        }


        /// <summary>
        /// Get the Access Status for Organizations portfolio share feature. This API can only
        /// be called by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAWSOrganizationsAccessStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        public virtual Task<GetAWSOrganizationsAccessStatusResponse> GetAWSOrganizationsAccessStatusAsync(GetAWSOrganizationsAccessStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAWSOrganizationsAccessStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProvisionedProductOutputs


        /// <summary>
        /// This API takes either a <code>ProvisonedProductId</code> or a <code>ProvisionedProductName</code>,
        /// along with a list of one or more output keys, and responds with the key/value pairs
        /// of those outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedProductOutputs service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedProductOutputs service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetProvisionedProductOutputs">REST API Reference for GetProvisionedProductOutputs Operation</seealso>
        public virtual GetProvisionedProductOutputsResponse GetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedProductOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedProductOutputsResponseUnmarshaller.Instance;

            return Invoke<GetProvisionedProductOutputsResponse>(request, options);
        }


        /// <summary>
        /// This API takes either a <code>ProvisonedProductId</code> or a <code>ProvisionedProductName</code>,
        /// along with a list of one or more output keys, and responds with the key/value pairs
        /// of those outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedProductOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProvisionedProductOutputs service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetProvisionedProductOutputs">REST API Reference for GetProvisionedProductOutputs Operation</seealso>
        public virtual Task<GetProvisionedProductOutputsResponse> GetProvisionedProductOutputsAsync(GetProvisionedProductOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedProductOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedProductOutputsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProvisionedProductOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportAsProvisionedProduct


        /// <summary>
        /// Requests the import of a resource as an Service Catalog provisioned product that
        /// is associated to an Service Catalog product and provisioning artifact. Once imported,
        /// all supported governance actions are supported on the provisioned product. 
        /// 
        ///  
        /// <para>
        ///  Resource import only supports CloudFormation stack ARNs. CloudFormation StackSets,
        /// and non-root nested stacks are not supported. 
        /// </para>
        ///  
        /// <para>
        ///  The CloudFormation stack must have one of the following statuses to be imported:
        /// <code>CREATE_COMPLETE</code>, <code>UPDATE_COMPLETE</code>, <code>UPDATE_ROLLBACK_COMPLETE</code>,
        /// <code>IMPORT_COMPLETE</code>, and <code>IMPORT_ROLLBACK_COMPLETE</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Import of the resource requires that the CloudFormation stack template matches the
        /// associated Service Catalog product provisioning artifact. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When you import an existing CloudFormation stack into a portfolio, constraints that
        /// are associated with the product aren't applied during the import process. The constraints
        /// are applied after you call <code>UpdateProvisionedProduct</code> for the provisioned
        /// product. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// and <code>cloudformation:DescribeStacks</code> IAM policy permissions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportAsProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the ImportAsProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ImportAsProvisionedProduct">REST API Reference for ImportAsProvisionedProduct Operation</seealso>
        public virtual ImportAsProvisionedProductResponse ImportAsProvisionedProduct(ImportAsProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportAsProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportAsProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<ImportAsProvisionedProductResponse>(request, options);
        }


        /// <summary>
        /// Requests the import of a resource as an Service Catalog provisioned product that
        /// is associated to an Service Catalog product and provisioning artifact. Once imported,
        /// all supported governance actions are supported on the provisioned product. 
        /// 
        ///  
        /// <para>
        ///  Resource import only supports CloudFormation stack ARNs. CloudFormation StackSets,
        /// and non-root nested stacks are not supported. 
        /// </para>
        ///  
        /// <para>
        ///  The CloudFormation stack must have one of the following statuses to be imported:
        /// <code>CREATE_COMPLETE</code>, <code>UPDATE_COMPLETE</code>, <code>UPDATE_ROLLBACK_COMPLETE</code>,
        /// <code>IMPORT_COMPLETE</code>, and <code>IMPORT_ROLLBACK_COMPLETE</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Import of the resource requires that the CloudFormation stack template matches the
        /// associated Service Catalog product provisioning artifact. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When you import an existing CloudFormation stack into a portfolio, constraints that
        /// are associated with the product aren't applied during the import process. The constraints
        /// are applied after you call <code>UpdateProvisionedProduct</code> for the provisioned
        /// product. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// and <code>cloudformation:DescribeStacks</code> IAM policy permissions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportAsProvisionedProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportAsProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ImportAsProvisionedProduct">REST API Reference for ImportAsProvisionedProduct Operation</seealso>
        public virtual Task<ImportAsProvisionedProductResponse> ImportAsProvisionedProductAsync(ImportAsProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportAsProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportAsProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportAsProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares


        /// <summary>
        /// Lists all imported portfolios for which account-to-account shares were accepted by
        /// this account. By specifying the <code>PortfolioShareType</code>, you can list portfolios
        /// for which organizational shares were accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<ListAcceptedPortfolioSharesResponse>(request, options);
        }


        /// <summary>
        /// Lists all imported portfolios for which account-to-account shares were accepted by
        /// this account. By specifying the <code>PortfolioShareType</code>, you can list portfolios
        /// for which organizational shares were accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual Task<ListAcceptedPortfolioSharesResponse> ListAcceptedPortfolioSharesAsync(ListAcceptedPortfolioSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAcceptedPortfolioSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBudgetsForResource


        /// <summary>
        /// Lists all the budgets associated to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgetsForResource service method.</param>
        /// 
        /// <returns>The response from the ListBudgetsForResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListBudgetsForResource">REST API Reference for ListBudgetsForResource Operation</seealso>
        public virtual ListBudgetsForResourceResponse ListBudgetsForResource(ListBudgetsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBudgetsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBudgetsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListBudgetsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all the budgets associated to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgetsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBudgetsForResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListBudgetsForResource">REST API Reference for ListBudgetsForResource Operation</seealso>
        public virtual Task<ListBudgetsForResourceResponse> ListBudgetsForResourceAsync(ListBudgetsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBudgetsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBudgetsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBudgetsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConstraintsForPortfolio


        /// <summary>
        /// Lists the constraints for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListConstraintsForPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Lists the constraints for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual Task<ListConstraintsForPortfolioResponse> ListConstraintsForPortfolioAsync(ListConstraintsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConstraintsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLaunchPaths


        /// <summary>
        /// Lists the paths to the specified product. A path describes how the user gets access
        /// to a specified product and is necessary when provisioning a product. A path also determines
        /// the constraints that are put on a product. A path is dependent on a specific product,
        /// porfolio, and principal. 
        /// 
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return Invoke<ListLaunchPathsResponse>(request, options);
        }


        /// <summary>
        /// Lists the paths to the specified product. A path describes how the user gets access
        /// to a specified product and is necessary when provisioning a product. A path also determines
        /// the constraints that are put on a product. A path is dependent on a specific product,
        /// porfolio, and principal. 
        /// 
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual Task<ListLaunchPathsResponse> ListLaunchPathsAsync(ListLaunchPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLaunchPathsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationPortfolioAccess


        /// <summary>
        /// Lists the organization nodes that have access to the specified portfolio. This API
        /// can only be called by the management account in the organization or by a delegated
        /// admin.
        /// 
        ///  
        /// <para>
        /// If a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        public virtual ListOrganizationPortfolioAccessResponse ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationPortfolioAccessResponse>(request, options);
        }


        /// <summary>
        /// Lists the organization nodes that have access to the specified portfolio. This API
        /// can only be called by the management account in the organization or by a delegated
        /// admin.
        /// 
        ///  
        /// <para>
        /// If a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        public virtual Task<ListOrganizationPortfolioAccessResponse> ListOrganizationPortfolioAccessAsync(ListOrganizationPortfolioAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationPortfolioAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationPortfolioAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolioAccess


        /// <summary>
        /// Lists the account IDs that have access to the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin can list the accounts that have access to the shared portfolio.
        /// Note that if a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListPortfolioAccessResponse>(request, options);
        }


        /// <summary>
        /// Lists the account IDs that have access to the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin can list the accounts that have access to the shared portfolio.
        /// Note that if a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual Task<ListPortfolioAccessResponse> ListPortfolioAccessAsync(ListPortfolioAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfolioAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolios


        /// <summary>
        /// Lists all portfolios in the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios service method.</param>
        /// 
        /// <returns>The response from the ListPortfolios service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosResponse>(request, options);
        }


        /// <summary>
        /// Lists all portfolios in the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortfolios service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual Task<ListPortfoliosResponse> ListPortfoliosAsync(ListPortfoliosRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfoliosResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfoliosForProduct


        /// <summary>
        /// Lists all portfolios that the specified product is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct service method.</param>
        /// 
        /// <returns>The response from the ListPortfoliosForProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosForProductResponse>(request, options);
        }


        /// <summary>
        /// Lists all portfolios that the specified product is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortfoliosForProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual Task<ListPortfoliosForProductResponse> ListPortfoliosForProductAsync(ListPortfoliosForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPortfoliosForProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalsForPortfolio


        /// <summary>
        /// Lists all <code>PrincipalARN</code>s and corresponding <code>PrincipalType</code>s
        /// associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsForPortfolioResponse>(request, options);
        }


        /// <summary>
        /// Lists all <code>PrincipalARN</code>s and corresponding <code>PrincipalType</code>s
        /// associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipalsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual Task<ListPrincipalsForPortfolioResponse> ListPrincipalsForPortfolioAsync(ListPrincipalsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPrincipalsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedProductPlans


        /// <summary>
        /// Lists the plans for the specified provisioned product or all plans to which the user
        /// has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedProductPlans service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual ListProvisionedProductPlansResponse ListProvisionedProductPlans(ListProvisionedProductPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedProductPlansResponse>(request, options);
        }


        /// <summary>
        /// Lists the plans for the specified provisioned product or all plans to which the user
        /// has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisionedProductPlans service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual Task<ListProvisionedProductPlansResponse> ListProvisionedProductPlansAsync(ListProvisionedProductPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisionedProductPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifacts


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsResponse>(request, options);
        }


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual Task<ListProvisioningArtifactsResponse> ListProvisioningArtifactsAsync(ListProvisioningArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisioningArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifactsForServiceAction


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified self-service
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifactsForServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        public virtual ListProvisioningArtifactsForServiceActionResponse ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsForServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsForServiceActionResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsForServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified self-service
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisioningArtifactsForServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        public virtual Task<ListProvisioningArtifactsForServiceActionResponse> ListProvisioningArtifactsForServiceActionAsync(ListProvisioningArtifactsForServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsForServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsForServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisioningArtifactsForServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecordHistory


        /// <summary>
        /// Lists the specified requests or all performed requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRecordHistoryResponse>(request, options);
        }


        /// <summary>
        /// Lists the specified requests or all performed requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual Task<ListRecordHistoryResponse> ListRecordHistoryAsync(ListRecordHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecordHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForTagOption


        /// <summary>
        /// Lists the resources associated with the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForTagOptionResponse>(request, options);
        }


        /// <summary>
        /// Lists the resources associated with the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesForTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual Task<ListResourcesForTagOptionResponse> ListResourcesForTagOptionAsync(ListResourcesForTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesForTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceActions


        /// <summary>
        /// Lists all self-service actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions service method.</param>
        /// 
        /// <returns>The response from the ListServiceActions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        public virtual ListServiceActionsResponse ListServiceActions(ListServiceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all self-service actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceActions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        public virtual Task<ListServiceActionsResponse> ListServiceActionsAsync(ListServiceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceActionsForProvisioningArtifact


        /// <summary>
        /// Returns a paginated list of self-service actions associated with the specified Product
        /// ID and Provisioning Artifact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the ListServiceActionsForProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        public virtual ListServiceActionsForProvisioningArtifactResponse ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsForProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of self-service actions associated with the specified Product
        /// ID and Provisioning Artifact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceActionsForProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        public virtual Task<ListServiceActionsForProvisioningArtifactResponse> ListServiceActionsForProvisioningArtifactAsync(ListServiceActionsForProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceActionsForProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackInstancesForProvisionedProduct


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// <code>CFN_STACKSET</code> type provisioned product. You can filter for stack instances
        /// that are associated with a specific Amazon Web Services account name or Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstancesForProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the ListStackInstancesForProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListStackInstancesForProvisionedProduct">REST API Reference for ListStackInstancesForProvisionedProduct Operation</seealso>
        public virtual ListStackInstancesForProvisionedProductResponse ListStackInstancesForProvisionedProduct(ListStackInstancesForProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesForProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesForProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesForProvisionedProductResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// <code>CFN_STACKSET</code> type provisioned product. You can filter for stack instances
        /// that are associated with a specific Amazon Web Services account name or Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstancesForProvisionedProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstancesForProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListStackInstancesForProvisionedProduct">REST API Reference for ListStackInstancesForProvisionedProduct Operation</seealso>
        public virtual Task<ListStackInstancesForProvisionedProductResponse> ListStackInstancesForProvisionedProductAsync(ListStackInstancesForProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesForProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesForProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackInstancesForProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagOptions


        /// <summary>
        /// Lists the specified TagOptions or all TagOptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions service method.</param>
        /// 
        /// <returns>The response from the ListTagOptions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return Invoke<ListTagOptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the specified TagOptions or all TagOptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagOptions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual Task<ListTagOptionsResponse> ListTagOptionsAsync(ListTagOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionProduct


        /// <summary>
        /// Provisions the specified product. 
        /// 
        ///  
        /// <para>
        ///  A provisioned product is a resourced instance of a product. For example, provisioning
        /// a product that's based on an CloudFormation template launches an CloudFormation stack
        /// and its underlying resources. You can check the status of this request using <a>DescribeRecord</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If the request contains a tag key with an empty list of values, there's a tag conflict
        /// for that key. Don't include conflicted keys as tags, or this will cause the error
        /// "Parameter validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>".
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return Invoke<ProvisionProductResponse>(request, options);
        }


        /// <summary>
        /// Provisions the specified product. 
        /// 
        ///  
        /// <para>
        ///  A provisioned product is a resourced instance of a product. For example, provisioning
        /// a product that's based on an CloudFormation template launches an CloudFormation stack
        /// and its underlying resources. You can check the status of this request using <a>DescribeRecord</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If the request contains a tag key with an empty list of values, there's a tag conflict
        /// for that key. Don't include conflicted keys as tags, or this will cause the error
        /// "Parameter validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>".
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual Task<ProvisionProductResponse> ProvisionProductAsync(ProvisionProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<ProvisionProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectPortfolioShare


        /// <summary>
        /// Rejects an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<RejectPortfolioShareResponse>(request, options);
        }


        /// <summary>
        /// Rejects an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual Task<RejectPortfolioShareResponse> RejectPortfolioShareAsync(RejectPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScanProvisionedProducts


        /// <summary>
        /// Lists the provisioned products that are available (not terminated).
        /// 
        ///  
        /// <para>
        /// To use additional filtering, see <a>SearchProvisionedProducts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<ScanProvisionedProductsResponse>(request, options);
        }


        /// <summary>
        /// Lists the provisioned products that are available (not terminated).
        /// 
        ///  
        /// <para>
        /// To use additional filtering, see <a>SearchProvisionedProducts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual Task<ScanProvisionedProductsResponse> ScanProvisionedProductsAsync(ScanProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ScanProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProducts


        /// <summary>
        /// Gets information about the products to which the caller has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProductsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the products to which the caller has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual Task<SearchProductsResponse> SearchProductsAsync(SearchProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProductsAsAdmin


        /// <summary>
        /// Gets information about the products for the specified portfolio or all products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return Invoke<SearchProductsAsAdminResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the products for the specified portfolio or all products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual Task<SearchProductsAsAdminResponse> SearchProductsAsAdminAsync(SearchProductsAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProductsAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProvisionedProducts


        /// <summary>
        /// Gets information about the provisioned products that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual SearchProvisionedProductsResponse SearchProvisionedProducts(SearchProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProvisionedProductsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the provisioned products that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual Task<SearchProvisionedProductsResponse> SearchProvisionedProductsAsync(SearchProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateProvisionedProduct


        /// <summary>
        /// Terminates the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<TerminateProvisionedProductResponse>(request, options);
        }


        /// <summary>
        /// Terminates the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual Task<TerminateProvisionedProductResponse> TerminateProvisionedProductAsync(TerminateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConstraint


        /// <summary>
        /// Updates the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return Invoke<UpdateConstraintResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual Task<UpdateConstraintResponse> UpdateConstraintAsync(UpdateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePortfolio


        /// <summary>
        /// Updates the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot update a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot update a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual Task<UpdatePortfolioResponse> UpdatePortfolioAsync(UpdatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePortfolioShare


        /// <summary>
        /// Updates the specified portfolio share. You can use this API to enable or disable <code>TagOptions</code>
        /// sharing or Principal sharing for an existing portfolio share. 
        /// 
        ///  
        /// <para>
        /// The portfolio share cannot be updated if the <code>CreatePortfolioShare</code> operation
        /// is <code>IN_PROGRESS</code>, as the share is not available to recipient entities.
        /// In this case, you must wait for the portfolio share to be COMPLETED.
        /// </para>
        ///  
        /// <para>
        /// You must provide the <code>accountId</code> or organization node in the input, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio is shared to both an external account and an organization node, and
        /// both shares need to be updated, you must invoke <code>UpdatePortfolioShare</code>
        /// separately for each share type. 
        /// </para>
        ///  
        /// <para>
        /// This API cannot be used for removing the portfolio share. You must use <code>DeletePortfolioShare</code>
        /// API for that action. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolioShare">REST API Reference for UpdatePortfolioShare Operation</seealso>
        public virtual UpdatePortfolioShareResponse UpdatePortfolioShare(UpdatePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioShareResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified portfolio share. You can use this API to enable or disable <code>TagOptions</code>
        /// sharing or Principal sharing for an existing portfolio share. 
        /// 
        ///  
        /// <para>
        /// The portfolio share cannot be updated if the <code>CreatePortfolioShare</code> operation
        /// is <code>IN_PROGRESS</code>, as the share is not available to recipient entities.
        /// In this case, you must wait for the portfolio share to be COMPLETED.
        /// </para>
        ///  
        /// <para>
        /// You must provide the <code>accountId</code> or organization node in the input, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio is shared to both an external account and an organization node, and
        /// both shares need to be updated, you must invoke <code>UpdatePortfolioShare</code>
        /// separately for each share type. 
        /// </para>
        ///  
        /// <para>
        /// This API cannot be used for removing the portfolio share. You must use <code>DeletePortfolioShare</code>
        /// API for that action. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolioShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolioShare">REST API Reference for UpdatePortfolioShare Operation</seealso>
        public virtual Task<UpdatePortfolioShareResponse> UpdatePortfolioShareAsync(UpdatePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProduct


        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedProduct


        /// <summary>
        /// Requests updates to the configuration of the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// If there are tags associated with the object, they cannot be updated or added. Depending
        /// on the specific updates requested, this operation can update with no interruption,
        /// with some interruption, or replace the provisioned product entirely.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductResponse>(request, options);
        }


        /// <summary>
        /// Requests updates to the configuration of the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// If there are tags associated with the object, they cannot be updated or added. Depending
        /// on the specific updates requested, this operation can update with no interruption,
        /// with some interruption, or replace the provisioned product entirely.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual Task<UpdateProvisionedProductResponse> UpdateProvisionedProductAsync(UpdateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedProductProperties


        /// <summary>
        /// Requests updates to the properties of the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProductProperties service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProductProperties service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProductProperties">REST API Reference for UpdateProvisionedProductProperties Operation</seealso>
        public virtual UpdateProvisionedProductPropertiesResponse UpdateProvisionedProductProperties(UpdateProvisionedProductPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductPropertiesResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductPropertiesResponse>(request, options);
        }


        /// <summary>
        /// Requests updates to the properties of the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProductProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisionedProductProperties service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProductProperties">REST API Reference for UpdateProvisionedProductProperties Operation</seealso>
        public virtual Task<UpdateProvisionedProductPropertiesResponse> UpdateProvisionedProductPropertiesAsync(UpdateProvisionedProductPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductPropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisionedProductPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisioningArtifact


        /// <summary>
        /// Updates the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot update a provisioning artifact for a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot update a provisioning artifact for a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual Task<UpdateProvisioningArtifactResponse> UpdateProvisioningArtifactAsync(UpdateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceAction


        /// <summary>
        /// Updates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        public virtual UpdateServiceActionResponse UpdateServiceAction(UpdateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceActionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Updates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        public virtual Task<UpdateServiceActionResponse> UpdateServiceActionAsync(UpdateServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagOption


        /// <summary>
        /// Updates the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption service method.</param>
        /// 
        /// <returns>The response from the UpdateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return Invoke<UpdateTagOptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual Task<UpdateTagOptionResponse> UpdateTagOptionAsync(UpdateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}