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
        private static IServiceMetadata serviceMetadata = new AmazonServiceCatalogMetadata();
        
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

        internal virtual AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<AcceptPortfolioShareResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociatePrincipalWithPortfolio

        internal virtual AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociatePrincipalWithPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<AssociatePrincipalWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio

        internal virtual AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociateProductWithPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateProductWithPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateServiceActionWithProvisioningArtifact

        internal virtual AssociateServiceActionWithProvisioningArtifactResponse AssociateServiceActionWithProvisioningArtifact(AssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateTagOptionWithResourceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTagOptionWithResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateServiceActionWithProvisioningArtifact

        internal virtual BatchAssociateServiceActionWithProvisioningArtifactResponse BatchAssociateServiceActionWithProvisioningArtifact(BatchAssociateServiceActionWithProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateServiceActionWithProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateServiceActionWithProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateServiceActionWithProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual BatchDisassociateServiceActionFromProvisioningArtifactResponse BatchDisassociateServiceActionFromProvisioningArtifact(BatchDisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual CopyProductResponse CopyProduct(CopyProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;

            return Invoke<CopyProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyProductResponseUnmarshaller.Instance;

            return InvokeAsync<CopyProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConstraint

        internal virtual CreateConstraintResponse CreateConstraint(CreateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return Invoke<CreateConstraintResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolio

        internal virtual CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePortfolioShare

        internal virtual CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioShareResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProduct

        internal virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisionedProductPlan

        internal virtual CreateProvisionedProductPlanResponse CreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedProductPlanResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisioningArtifact

        internal virtual CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningArtifactResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceAction

        internal virtual CreateServiceActionResponse CreateServiceAction(CreateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceActionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return Invoke<CreateTagOptionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConstraint

        internal virtual DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return Invoke<DeleteConstraintResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolio

        internal virtual DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePortfolioShare

        internal virtual DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioShareResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProduct

        internal virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisionedProductPlan

        internal virtual DeleteProvisionedProductPlanResponse DeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedProductPlanResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisioningArtifact

        internal virtual DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningArtifactResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceAction

        internal virtual DeleteServiceActionResponse DeleteServiceAction(DeleteServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceActionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTagOptionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConstraint

        internal virtual DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return Invoke<DescribeConstraintResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCopyProductStatus

        internal virtual DescribeCopyProductStatusResponse DescribeCopyProductStatus(DescribeCopyProductStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyProductStatusResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCopyProductStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolio

        internal virtual DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePortfolioShareStatus

        internal virtual DescribePortfolioShareStatusResponse DescribePortfolioShareStatus(DescribePortfolioShareStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePortfolioShareStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortfolioShareStatusResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioShareStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolioShareStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductAsAdmin

        internal virtual DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeProductAsAdminResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProductView

        internal virtual DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return Invoke<DescribeProductViewResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProduct

        internal virtual DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisionedProductPlan

        internal virtual DescribeProvisionedProductPlanResponse DescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductPlanResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningArtifact

        internal virtual DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningArtifactResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProvisioningParameters

        internal virtual DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningParametersResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProvisioningParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecord

        internal virtual DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return Invoke<DescribeRecordResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceAction

        internal virtual DescribeServiceActionResponse DescribeServiceAction(DescribeServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        public virtual Task<DescribeServiceActionResponse> DescribeServiceActionAsync(DescribeServiceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceActionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTagOption

        internal virtual DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return Invoke<DescribeTagOptionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAWSOrganizationsAccess

        internal virtual DisableAWSOrganizationsAccessResponse DisableAWSOrganizationsAccess(DisableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<DisableAWSOrganizationsAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        public virtual Task<DisableAWSOrganizationsAccessResponse> DisableAWSOrganizationsAccessAsync(DisableAWSOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAWSOrganizationsAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio

        internal virtual DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociatePrincipalFromPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociatePrincipalFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateProductFromPortfolio

        internal virtual DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociateProductFromPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateProductFromPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceActionFromProvisioningArtifact

        internal virtual DisassociateServiceActionFromProvisioningArtifactResponse DisassociateServiceActionFromProvisioningArtifact(DisassociateServiceActionFromProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceActionFromProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceActionFromProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceActionFromProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateTagOptionFromResourceResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTagOptionFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAWSOrganizationsAccess

        internal virtual EnableAWSOrganizationsAccessResponse EnableAWSOrganizationsAccess(EnableAWSOrganizationsAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<EnableAWSOrganizationsAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ExecuteProvisionedProductPlanResponse ExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductPlanResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteProvisionedProductPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteProvisionedProductServiceAction

        internal virtual ExecuteProvisionedProductServiceActionResponse ExecuteProvisionedProductServiceAction(ExecuteProvisionedProductServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteProvisionedProductServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteProvisionedProductServiceActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual GetAWSOrganizationsAccessStatusResponse GetAWSOrganizationsAccessStatus(GetAWSOrganizationsAccessStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;

            return Invoke<GetAWSOrganizationsAccessStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAWSOrganizationsAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        public virtual Task<GetAWSOrganizationsAccessStatusResponse> GetAWSOrganizationsAccessStatusAsync(GetAWSOrganizationsAccessStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSOrganizationsAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSOrganizationsAccessStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetAWSOrganizationsAccessStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares

        internal virtual ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<ListAcceptedPortfolioSharesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcceptedPortfolioSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConstraintsForPortfolio

        internal virtual ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListConstraintsForPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<ListConstraintsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLaunchPaths

        internal virtual ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return Invoke<ListLaunchPathsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLaunchPathsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLaunchPathsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationPortfolioAccess

        internal virtual ListOrganizationPortfolioAccessResponse ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationPortfolioAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListPortfolioAccessResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfolioAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfolioAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfolios

        internal virtual ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfoliosResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPortfoliosForProduct

        internal virtual ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosForProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortfoliosForProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrincipalsForPortfolio

        internal virtual ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsForPortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrincipalsForPortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedProductPlans

        internal virtual ListProvisionedProductPlansResponse ListProvisionedProductPlans(ListProvisionedProductPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedProductPlansResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisionedProductPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifacts

        internal virtual ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisioningArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisioningArtifactsForServiceAction

        internal virtual ListProvisioningArtifactsForServiceActionResponse ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisioningArtifactsForServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisioningArtifactsForServiceActionResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsForServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifactsForServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRecordHistoryResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecordHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForTagOption

        internal virtual ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForTagOptionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesForTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceActions

        internal virtual ListServiceActionsResponse ListServiceActions(ListServiceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ListServiceActionsForProvisioningArtifactResponse ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<ListServiceActionsForProvisioningArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActionsForProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        public virtual Task<ListServiceActionsForProvisioningArtifactResponse> ListServiceActionsForProvisioningArtifactAsync(ListServiceActionsForProvisioningArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceActionsForProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceActionsForProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceActionsForProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagOptions

        internal virtual ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return Invoke<ListTagOptionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionProduct

        internal virtual ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return Invoke<ProvisionProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectPortfolioShare

        internal virtual RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<RejectPortfolioShareResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectPortfolioShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return InvokeAsync<RejectPortfolioShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScanProvisionedProducts

        internal virtual ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<ScanProvisionedProductsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return InvokeAsync<ScanProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProducts

        internal virtual SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProductsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProductsAsAdmin

        internal virtual SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return Invoke<SearchProductsAsAdminResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProductsAsAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProvisionedProducts

        internal virtual SearchProvisionedProductsResponse SearchProvisionedProducts(SearchProvisionedProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProvisionedProductsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProvisionedProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateProvisionedProduct

        internal virtual TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<TerminateProvisionedProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConstraint

        internal virtual UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return Invoke<UpdateConstraintResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConstraintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConstraintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePortfolio

        internal virtual UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePortfolioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortfolioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProduct

        internal virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedProduct

        internal virtual UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProvisionedProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisioningArtifact

        internal virtual UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningArtifactResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProvisioningArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceAction

        internal virtual UpdateServiceActionResponse UpdateServiceAction(UpdateServiceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceActionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return Invoke<UpdateTagOptionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}