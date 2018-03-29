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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ServiceCatalog.Model;
using Amazon.ServiceCatalog.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServiceCatalog
{
    /// <summary>
    /// Implementation for accessing ServiceCatalog
    ///
    /// AWS Service Catalog 
    /// <para>
    ///  <a href="https://aws.amazon.com/servicecatalog/">AWS Service Catalog</a> enables
    /// organizations to create and manage catalogs of IT services that are approved for use
    /// on AWS. To get the most out of this documentation, you should be familiar with the
    /// terminology discussed in <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/what-is_concepts.html">AWS
    /// Service Catalog Concepts</a>.
    /// </para>
    /// </summary>
    public partial class AmazonServiceCatalogClient : AmazonServiceClient, IAmazonServiceCatalog
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request)
        {
            var marshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<AcceptPortfolioShareRequest,AcceptPortfolioShareResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual Task<AcceptPortfolioShareResponse> AcceptPortfolioShareAsync(AcceptPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptPortfolioShareRequest,AcceptPortfolioShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociatePrincipalWithPortfolio

        internal virtual AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request)
        {
            var marshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociatePrincipalWithPortfolioRequest,AssociatePrincipalWithPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual Task<AssociatePrincipalWithPortfolioResponse> AssociatePrincipalWithPortfolioAsync(AssociatePrincipalWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<AssociatePrincipalWithPortfolioRequest,AssociatePrincipalWithPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio

        internal virtual AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request)
        {
            var marshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociateProductWithPortfolioRequest,AssociateProductWithPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual Task<AssociateProductWithPortfolioResponse> AssociateProductWithPortfolioAsync(AssociateProductWithPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateProductWithPortfolioRequest,AssociateProductWithPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateTagOptionWithResource

        internal virtual AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var marshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateTagOptionWithResourceRequest,AssociateTagOptionWithResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual Task<AssociateTagOptionWithResourceResponse> AssociateTagOptionWithResourceAsync(AssociateTagOptionWithResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTagOptionWithResourceRequest,AssociateTagOptionWithResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyProduct

        internal virtual CopyProductResponse CopyProduct(CopyProductRequest request)
        {
            var marshaller = CopyProductRequestMarshaller.Instance;
            var unmarshaller = CopyProductResponseUnmarshaller.Instance;

            return Invoke<CopyProductRequest,CopyProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual Task<CopyProductResponse> CopyProductAsync(CopyProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyProductRequestMarshaller.Instance;
            var unmarshaller = CopyProductResponseUnmarshaller.Instance;

            return InvokeAsync<CopyProductRequest,CopyProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConstraint

        internal virtual CreateConstraintResponse CreateConstraint(CreateConstraintRequest request)
        {
            var marshaller = CreateConstraintRequestMarshaller.Instance;
            var unmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return Invoke<CreateConstraintRequest,CreateConstraintResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual Task<CreateConstraintResponse> CreateConstraintAsync(CreateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConstraintRequestMarshaller.Instance;
            var unmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConstraintRequest,CreateConstraintResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolio

        internal virtual CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var marshaller = CreatePortfolioRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioRequest,CreatePortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual Task<CreatePortfolioResponse> CreatePortfolioAsync(CreatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePortfolioRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortfolioRequest,CreatePortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolioShare

        internal virtual CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var marshaller = CreatePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioShareRequest,CreatePortfolioShareResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual Task<CreatePortfolioShareResponse> CreatePortfolioShareAsync(CreatePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortfolioShareRequest,CreatePortfolioShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProduct

        internal virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var marshaller = CreateProductRequestMarshaller.Instance;
            var unmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductRequest,CreateProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProductRequestMarshaller.Instance;
            var unmarshaller = CreateProductResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductRequest,CreateProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisionedProductPlan

        internal virtual CreateProvisionedProductPlanResponse CreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request)
        {
            var marshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedProductPlanRequest,CreateProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual Task<CreateProvisionedProductPlanResponse> CreateProvisionedProductPlanAsync(CreateProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisionedProductPlanRequest,CreateProvisionedProductPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningArtifact

        internal virtual CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request)
        {
            var marshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningArtifactRequest,CreateProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual Task<CreateProvisioningArtifactResponse> CreateProvisioningArtifactAsync(CreateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisioningArtifactRequest,CreateProvisioningArtifactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTagOption

        internal virtual CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var marshaller = CreateTagOptionRequestMarshaller.Instance;
            var unmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return Invoke<CreateTagOptionRequest,CreateTagOptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual Task<CreateTagOptionResponse> CreateTagOptionAsync(CreateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTagOptionRequestMarshaller.Instance;
            var unmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagOptionRequest,CreateTagOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConstraint

        internal virtual DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request)
        {
            var marshaller = DeleteConstraintRequestMarshaller.Instance;
            var unmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return Invoke<DeleteConstraintRequest,DeleteConstraintResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual Task<DeleteConstraintResponse> DeleteConstraintAsync(DeleteConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConstraintRequestMarshaller.Instance;
            var unmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConstraintRequest,DeleteConstraintResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolio

        internal virtual DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var marshaller = DeletePortfolioRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioRequest,DeletePortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual Task<DeletePortfolioResponse> DeletePortfolioAsync(DeletePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePortfolioRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortfolioRequest,DeletePortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolioShare

        internal virtual DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var marshaller = DeletePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioShareRequest,DeletePortfolioShareResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual Task<DeletePortfolioShareResponse> DeletePortfolioShareAsync(DeletePortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortfolioShareRequest,DeletePortfolioShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProduct

        internal virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var marshaller = DeleteProductRequestMarshaller.Instance;
            var unmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductRequest,DeleteProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProductRequestMarshaller.Instance;
            var unmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductRequest,DeleteProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisionedProductPlan

        internal virtual DeleteProvisionedProductPlanResponse DeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request)
        {
            var marshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedProductPlanRequest,DeleteProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual Task<DeleteProvisionedProductPlanResponse> DeleteProvisionedProductPlanAsync(DeleteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisionedProductPlanRequest,DeleteProvisionedProductPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningArtifact

        internal virtual DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request)
        {
            var marshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningArtifactRequest,DeleteProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual Task<DeleteProvisioningArtifactResponse> DeleteProvisioningArtifactAsync(DeleteProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisioningArtifactRequest,DeleteProvisioningArtifactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagOption

        internal virtual DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request)
        {
            var marshaller = DeleteTagOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTagOptionRequest,DeleteTagOptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual Task<DeleteTagOptionResponse> DeleteTagOptionAsync(DeleteTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTagOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagOptionRequest,DeleteTagOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConstraint

        internal virtual DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request)
        {
            var marshaller = DescribeConstraintRequestMarshaller.Instance;
            var unmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return Invoke<DescribeConstraintRequest,DescribeConstraintResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual Task<DescribeConstraintResponse> DescribeConstraintAsync(DescribeConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeConstraintRequestMarshaller.Instance;
            var unmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConstraintRequest,DescribeConstraintResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCopyProductStatus

        internal virtual DescribeCopyProductStatusResponse DescribeCopyProductStatus(DescribeCopyProductStatusRequest request)
        {
            var marshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyProductStatusRequest,DescribeCopyProductStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual Task<DescribeCopyProductStatusResponse> DescribeCopyProductStatusAsync(DescribeCopyProductStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCopyProductStatusRequest,DescribeCopyProductStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolio

        internal virtual DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request)
        {
            var marshaller = DescribePortfolioRequestMarshaller.Instance;
            var unmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioRequest,DescribePortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual Task<DescribePortfolioResponse> DescribePortfolioAsync(DescribePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePortfolioRequestMarshaller.Instance;
            var unmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePortfolioRequest,DescribePortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProduct

        internal virtual DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            var marshaller = DescribeProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProductRequest,DescribeProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductRequest,DescribeProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductAsAdmin

        internal virtual DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var marshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            var unmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeProductAsAdminRequest,DescribeProductAsAdminResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual Task<DescribeProductAsAdminResponse> DescribeProductAsAdminAsync(DescribeProductAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            var unmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductAsAdminRequest,DescribeProductAsAdminResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductView

        internal virtual DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request)
        {
            var marshaller = DescribeProductViewRequestMarshaller.Instance;
            var unmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return Invoke<DescribeProductViewRequest,DescribeProductViewResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual Task<DescribeProductViewResponse> DescribeProductViewAsync(DescribeProductViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProductViewRequestMarshaller.Instance;
            var unmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductViewRequest,DescribeProductViewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProduct

        internal virtual DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var marshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductRequest,DescribeProvisionedProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual Task<DescribeProvisionedProductResponse> DescribeProvisionedProductAsync(DescribeProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisionedProductRequest,DescribeProvisionedProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProductPlan

        internal virtual DescribeProvisionedProductPlanResponse DescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request)
        {
            var marshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductPlanRequest,DescribeProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual Task<DescribeProvisionedProductPlanResponse> DescribeProvisionedProductPlanAsync(DescribeProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisionedProductPlanRequest,DescribeProvisionedProductPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningArtifact

        internal virtual DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var marshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningArtifactRequest,DescribeProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual Task<DescribeProvisioningArtifactResponse> DescribeProvisioningArtifactAsync(DescribeProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningArtifactRequest,DescribeProvisioningArtifactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningParameters

        internal virtual DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request)
        {
            var marshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningParametersRequest,DescribeProvisioningParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual Task<DescribeProvisioningParametersResponse> DescribeProvisioningParametersAsync(DescribeProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningParametersRequest,DescribeProvisioningParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecord

        internal virtual DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            var marshaller = DescribeRecordRequestMarshaller.Instance;
            var unmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return Invoke<DescribeRecordRequest,DescribeRecordResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual Task<DescribeRecordResponse> DescribeRecordAsync(DescribeRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRecordRequestMarshaller.Instance;
            var unmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecordRequest,DescribeRecordResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTagOption

        internal virtual DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var marshaller = DescribeTagOptionRequestMarshaller.Instance;
            var unmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return Invoke<DescribeTagOptionRequest,DescribeTagOptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual Task<DescribeTagOptionResponse> DescribeTagOptionAsync(DescribeTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTagOptionRequestMarshaller.Instance;
            var unmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagOptionRequest,DescribeTagOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio

        internal virtual DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request)
        {
            var marshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociatePrincipalFromPortfolioRequest,DisassociatePrincipalFromPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual Task<DisassociatePrincipalFromPortfolioResponse> DisassociatePrincipalFromPortfolioAsync(DisassociatePrincipalFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociatePrincipalFromPortfolioRequest,DisassociatePrincipalFromPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateProductFromPortfolio

        internal virtual DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request)
        {
            var marshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociateProductFromPortfolioRequest,DisassociateProductFromPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual Task<DisassociateProductFromPortfolioResponse> DisassociateProductFromPortfolioAsync(DisassociateProductFromPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateProductFromPortfolioRequest,DisassociateProductFromPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTagOptionFromResource

        internal virtual DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var marshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateTagOptionFromResourceRequest,DisassociateTagOptionFromResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual Task<DisassociateTagOptionFromResourceResponse> DisassociateTagOptionFromResourceAsync(DisassociateTagOptionFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTagOptionFromResourceRequest,DisassociateTagOptionFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductPlan

        internal virtual ExecuteProvisionedProductPlanResponse ExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request)
        {
            var marshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductPlanRequest,ExecuteProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual Task<ExecuteProvisionedProductPlanResponse> ExecuteProvisionedProductPlanAsync(ExecuteProvisionedProductPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteProvisionedProductPlanRequest,ExecuteProvisionedProductPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares

        internal virtual ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var marshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            var unmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<ListAcceptedPortfolioSharesRequest,ListAcceptedPortfolioSharesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual Task<ListAcceptedPortfolioSharesResponse> ListAcceptedPortfolioSharesAsync(ListAcceptedPortfolioSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            var unmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcceptedPortfolioSharesRequest,ListAcceptedPortfolioSharesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConstraintsForPortfolio

        internal virtual ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request)
        {
            var marshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListConstraintsForPortfolioRequest,ListConstraintsForPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual Task<ListConstraintsForPortfolioResponse> ListConstraintsForPortfolioAsync(ListConstraintsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<ListConstraintsForPortfolioRequest,ListConstraintsForPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLaunchPaths

        internal virtual ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request)
        {
            var marshaller = ListLaunchPathsRequestMarshaller.Instance;
            var unmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return Invoke<ListLaunchPathsRequest,ListLaunchPathsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual Task<ListLaunchPathsResponse> ListLaunchPathsAsync(ListLaunchPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLaunchPathsRequestMarshaller.Instance;
            var unmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLaunchPathsRequest,ListLaunchPathsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolioAccess

        internal virtual ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var marshaller = ListPortfolioAccessRequestMarshaller.Instance;
            var unmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListPortfolioAccessRequest,ListPortfolioAccessResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual Task<ListPortfolioAccessResponse> ListPortfolioAccessAsync(ListPortfolioAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPortfolioAccessRequestMarshaller.Instance;
            var unmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfolioAccessRequest,ListPortfolioAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolios

        internal virtual ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request)
        {
            var marshaller = ListPortfoliosRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosRequest,ListPortfoliosResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual Task<ListPortfoliosResponse> ListPortfoliosAsync(ListPortfoliosRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPortfoliosRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfoliosRequest,ListPortfoliosResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPortfoliosForProduct

        internal virtual ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request)
        {
            var marshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosForProductRequest,ListPortfoliosForProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual Task<ListPortfoliosForProductResponse> ListPortfoliosForProductAsync(ListPortfoliosForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfoliosForProductRequest,ListPortfoliosForProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalsForPortfolio

        internal virtual ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request)
        {
            var marshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsForPortfolioRequest,ListPrincipalsForPortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual Task<ListPrincipalsForPortfolioResponse> ListPrincipalsForPortfolioAsync(ListPrincipalsForPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalsForPortfolioRequest,ListPrincipalsForPortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedProductPlans

        internal virtual ListProvisionedProductPlansResponse ListProvisionedProductPlans(ListProvisionedProductPlansRequest request)
        {
            var marshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            var unmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedProductPlansRequest,ListProvisionedProductPlansResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual Task<ListProvisionedProductPlansResponse> ListProvisionedProductPlansAsync(ListProvisionedProductPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            var unmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisionedProductPlansRequest,ListProvisionedProductPlansResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifacts

        internal virtual ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request)
        {
            var marshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsRequest,ListProvisioningArtifactsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual Task<ListProvisioningArtifactsResponse> ListProvisioningArtifactsAsync(ListProvisioningArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisioningArtifactsRequest,ListProvisioningArtifactsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRecordHistory

        internal virtual ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request)
        {
            var marshaller = ListRecordHistoryRequestMarshaller.Instance;
            var unmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRecordHistoryRequest,ListRecordHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual Task<ListRecordHistoryResponse> ListRecordHistoryAsync(ListRecordHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRecordHistoryRequestMarshaller.Instance;
            var unmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecordHistoryRequest,ListRecordHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForTagOption

        internal virtual ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var marshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForTagOptionRequest,ListResourcesForTagOptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual Task<ListResourcesForTagOptionResponse> ListResourcesForTagOptionAsync(ListResourcesForTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesForTagOptionRequest,ListResourcesForTagOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagOptions

        internal virtual ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var marshaller = ListTagOptionsRequestMarshaller.Instance;
            var unmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return Invoke<ListTagOptionsRequest,ListTagOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual Task<ListTagOptionsResponse> ListTagOptionsAsync(ListTagOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagOptionsRequestMarshaller.Instance;
            var unmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagOptionsRequest,ListTagOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ProvisionProduct

        internal virtual ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request)
        {
            var marshaller = ProvisionProductRequestMarshaller.Instance;
            var unmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return Invoke<ProvisionProductRequest,ProvisionProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual Task<ProvisionProductResponse> ProvisionProductAsync(ProvisionProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ProvisionProductRequestMarshaller.Instance;
            var unmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionProductRequest,ProvisionProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectPortfolioShare

        internal virtual RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request)
        {
            var marshaller = RejectPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<RejectPortfolioShareRequest,RejectPortfolioShareResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual Task<RejectPortfolioShareResponse> RejectPortfolioShareAsync(RejectPortfolioShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RejectPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<RejectPortfolioShareRequest,RejectPortfolioShareResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ScanProvisionedProducts

        internal virtual ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request)
        {
            var marshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<ScanProvisionedProductsRequest,ScanProvisionedProductsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual Task<ScanProvisionedProductsResponse> ScanProvisionedProductsAsync(ScanProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return InvokeAsync<ScanProvisionedProductsRequest,ScanProvisionedProductsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchProducts

        internal virtual SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            var marshaller = SearchProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProductsRequest,SearchProductsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual Task<SearchProductsResponse> SearchProductsAsync(SearchProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProductsRequest,SearchProductsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchProductsAsAdmin

        internal virtual SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request)
        {
            var marshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            var unmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return Invoke<SearchProductsAsAdminRequest,SearchProductsAsAdminResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual Task<SearchProductsAsAdminResponse> SearchProductsAsAdminAsync(SearchProductsAsAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            var unmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProductsAsAdminRequest,SearchProductsAsAdminResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchProvisionedProducts

        internal virtual SearchProvisionedProductsResponse SearchProvisionedProducts(SearchProvisionedProductsRequest request)
        {
            var marshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProvisionedProductsRequest,SearchProvisionedProductsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual Task<SearchProvisionedProductsResponse> SearchProvisionedProductsAsync(SearchProvisionedProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProvisionedProductsRequest,SearchProvisionedProductsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateProvisionedProduct

        internal virtual TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request)
        {
            var marshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<TerminateProvisionedProductRequest,TerminateProvisionedProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual Task<TerminateProvisionedProductResponse> TerminateProvisionedProductAsync(TerminateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateProvisionedProductRequest,TerminateProvisionedProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConstraint

        internal virtual UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request)
        {
            var marshaller = UpdateConstraintRequestMarshaller.Instance;
            var unmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return Invoke<UpdateConstraintRequest,UpdateConstraintResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual Task<UpdateConstraintResponse> UpdateConstraintAsync(UpdateConstraintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConstraintRequestMarshaller.Instance;
            var unmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConstraintRequest,UpdateConstraintResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePortfolio

        internal virtual UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var marshaller = UpdatePortfolioRequestMarshaller.Instance;
            var unmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioRequest,UpdatePortfolioResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual Task<UpdatePortfolioResponse> UpdatePortfolioAsync(UpdatePortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePortfolioRequestMarshaller.Instance;
            var unmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortfolioRequest,UpdatePortfolioResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProduct

        internal virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var marshaller = UpdateProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductRequest,UpdateProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductRequest,UpdateProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedProduct

        internal virtual UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request)
        {
            var marshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductRequest,UpdateProvisionedProductResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual Task<UpdateProvisionedProductResponse> UpdateProvisionedProductAsync(UpdateProvisionedProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProvisionedProductRequest,UpdateProvisionedProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisioningArtifact

        internal virtual UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request)
        {
            var marshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningArtifactRequest,UpdateProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual Task<UpdateProvisioningArtifactResponse> UpdateProvisioningArtifactAsync(UpdateProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProvisioningArtifactRequest,UpdateProvisioningArtifactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagOption

        internal virtual UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var marshaller = UpdateTagOptionRequestMarshaller.Instance;
            var unmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return Invoke<UpdateTagOptionRequest,UpdateTagOptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual Task<UpdateTagOptionResponse> UpdateTagOptionAsync(UpdateTagOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTagOptionRequestMarshaller.Instance;
            var unmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagOptionRequest,UpdateTagOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}