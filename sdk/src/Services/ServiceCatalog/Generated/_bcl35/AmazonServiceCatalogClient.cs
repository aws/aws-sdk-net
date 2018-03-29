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
            var marshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<AcceptPortfolioShareRequest,AcceptPortfolioShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptPortfolioShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual IAsyncResult BeginAcceptPortfolioShare(AcceptPortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AcceptPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = AcceptPortfolioShareResponseUnmarshaller.Instance;

            return BeginInvoke<AcceptPortfolioShareRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPortfolioShare.</param>
        /// 
        /// <returns>Returns a  AcceptPortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public virtual AcceptPortfolioShareResponse EndAcceptPortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptPortfolioShareResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePrincipalWithPortfolio

        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
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
            var marshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociatePrincipalWithPortfolioRequest,AssociatePrincipalWithPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePrincipalWithPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual IAsyncResult BeginAssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociatePrincipalWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociatePrincipalWithPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<AssociatePrincipalWithPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePrincipalWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociatePrincipalWithPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public virtual AssociatePrincipalWithPortfolioResponse EndAssociatePrincipalWithPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePrincipalWithPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio

        /// <summary>
        /// Associates the specified product with the specified portfolio.
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
            var marshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return Invoke<AssociateProductWithPortfolioRequest,AssociateProductWithPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateProductWithPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual IAsyncResult BeginAssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateProductWithPortfolioRequestMarshaller.Instance;
            var unmarshaller = AssociateProductWithPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateProductWithPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateProductWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociateProductWithPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public virtual AssociateProductWithPortfolioResponse EndAssociateProductWithPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateProductWithPortfolioResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var marshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateTagOptionWithResourceRequest,AssociateTagOptionWithResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTagOptionWithResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateTagOptionWithResourceRequestMarshaller.Instance;
            var unmarshaller = AssociateTagOptionWithResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateTagOptionWithResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTagOptionWithResource.</param>
        /// 
        /// <returns>Returns a  AssociateTagOptionWithResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        public virtual AssociateTagOptionWithResourceResponse EndAssociateTagOptionWithResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTagOptionWithResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyProduct

        /// <summary>
        /// Copies the specified source product to the specified target product or a new product.
        /// 
        ///  
        /// <para>
        /// You can copy a product to the same account or another account. You can copy a product
        /// to the same region or another region.
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
            var marshaller = CopyProductRequestMarshaller.Instance;
            var unmarshaller = CopyProductResponseUnmarshaller.Instance;

            return Invoke<CopyProductRequest,CopyProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual IAsyncResult BeginCopyProduct(CopyProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CopyProductRequestMarshaller.Instance;
            var unmarshaller = CopyProductResponseUnmarshaller.Instance;

            return BeginInvoke<CopyProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyProduct.</param>
        /// 
        /// <returns>Returns a  CopyProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        public virtual CopyProductResponse EndCopyProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyProductResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConstraint

        /// <summary>
        /// Creates a constraint.
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
            var marshaller = CreateConstraintRequestMarshaller.Instance;
            var unmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return Invoke<CreateConstraintRequest,CreateConstraintResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConstraint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual IAsyncResult BeginCreateConstraint(CreateConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConstraintRequestMarshaller.Instance;
            var unmarshaller = CreateConstraintResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConstraintRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConstraint.</param>
        /// 
        /// <returns>Returns a  CreateConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public virtual CreateConstraintResponse EndCreateConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConstraintResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortfolio

        /// <summary>
        /// Creates a portfolio.
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var marshaller = CreatePortfolioRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioRequest,CreatePortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual IAsyncResult BeginCreatePortfolio(CreatePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePortfolioRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolio.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public virtual CreatePortfolioResponse EndCreatePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortfolioShare

        /// <summary>
        /// Shares the specified portfolio with the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var marshaller = CreatePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<CreatePortfolioShareRequest,CreatePortfolioShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortfolioShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual IAsyncResult BeginCreatePortfolioShare(CreatePortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = CreatePortfolioShareResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePortfolioShareRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolioShare.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public virtual CreatePortfolioShareResponse EndCreatePortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortfolioShareResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProduct

        /// <summary>
        /// Creates a product.
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var marshaller = CreateProductRequestMarshaller.Instance;
            var unmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductRequest,CreateProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual IAsyncResult BeginCreateProduct(CreateProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateProductRequestMarshaller.Instance;
            var unmarshaller = CreateProductResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProduct.</param>
        /// 
        /// <returns>Returns a  CreateProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual CreateProductResponse EndCreateProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProductResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProvisionedProductPlan

        /// <summary>
        /// Creates a plan. A plan includes the list of resources to be created (when provisioning
        /// a new product) or modified (when updating a provisioned product) when the plan is
        /// executed.
        /// 
        ///  
        /// <para>
        /// You can create one plan per provisioned product. To create a plan for an existing
        /// provisioned product, the product status must be AVAILBLE or TAINTED.
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
            var marshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedProductPlanRequest,CreateProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = CreateProvisionedProductPlanResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProvisionedProductPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  CreateProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        public virtual CreateProvisionedProductPlanResponse EndCreateProvisionedProductPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProvisionedProductPlanResponse>(asyncResult);
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
            var marshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<CreateProvisioningArtifactRequest,CreateProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual IAsyncResult BeginCreateProvisioningArtifact(CreateProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = CreateProvisioningArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProvisioningArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public virtual CreateProvisioningArtifactResponse EndCreateProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProvisioningArtifactResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var marshaller = CreateTagOptionRequestMarshaller.Instance;
            var unmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return Invoke<CreateTagOptionRequest,CreateTagOptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual IAsyncResult BeginCreateTagOption(CreateTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateTagOptionRequestMarshaller.Instance;
            var unmarshaller = CreateTagOptionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTagOptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTagOption.</param>
        /// 
        /// <returns>Returns a  CreateTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public virtual CreateTagOptionResponse EndCreateTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagOptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConstraint

        /// <summary>
        /// Deletes the specified constraint.
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
            var marshaller = DeleteConstraintRequestMarshaller.Instance;
            var unmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return Invoke<DeleteConstraintRequest,DeleteConstraintResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConstraint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual IAsyncResult BeginDeleteConstraint(DeleteConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConstraintRequestMarshaller.Instance;
            var unmarshaller = DeleteConstraintResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConstraintRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConstraint.</param>
        /// 
        /// <returns>Returns a  DeleteConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public virtual DeleteConstraintResponse EndDeleteConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConstraintResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var marshaller = DeletePortfolioRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioRequest,DeletePortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual IAsyncResult BeginDeletePortfolio(DeletePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePortfolioRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolio.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        public virtual DeletePortfolioResponse EndDeletePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePortfolioShare

        /// <summary>
        /// Stops sharing the specified portfolio with the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var marshaller = DeletePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return Invoke<DeletePortfolioShareRequest,DeletePortfolioShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortfolioShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual IAsyncResult BeginDeletePortfolioShare(DeletePortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePortfolioShareRequestMarshaller.Instance;
            var unmarshaller = DeletePortfolioShareResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePortfolioShareRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolioShare.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public virtual DeletePortfolioShareResponse EndDeletePortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortfolioShareResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var marshaller = DeleteProductRequestMarshaller.Instance;
            var unmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductRequest,DeleteProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual IAsyncResult BeginDeleteProduct(DeleteProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteProductRequestMarshaller.Instance;
            var unmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProduct.</param>
        /// 
        /// <returns>Returns a  DeleteProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual DeleteProductResponse EndDeleteProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProductResponse>(asyncResult);
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
            var marshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedProductPlanRequest,DeleteProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisionedProductPlanResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProvisionedProductPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  DeleteProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        public virtual DeleteProvisionedProductPlanResponse EndDeleteProvisionedProductPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisionedProductPlanResponse>(asyncResult);
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
            var marshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisioningArtifactRequest,DeleteProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual IAsyncResult BeginDeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DeleteProvisioningArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProvisioningArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public virtual DeleteProvisioningArtifactResponse EndDeleteProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisioningArtifactResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request)
        {
            var marshaller = DeleteTagOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteTagOptionRequest,DeleteTagOptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual IAsyncResult BeginDeleteTagOption(DeleteTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteTagOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteTagOptionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTagOptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTagOption.</param>
        /// 
        /// <returns>Returns a  DeleteTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        public virtual DeleteTagOptionResponse EndDeleteTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagOptionResponse>(asyncResult);
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
            var marshaller = DescribeConstraintRequestMarshaller.Instance;
            var unmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return Invoke<DescribeConstraintRequest,DescribeConstraintResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConstraint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual IAsyncResult BeginDescribeConstraint(DescribeConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeConstraintRequestMarshaller.Instance;
            var unmarshaller = DescribeConstraintResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConstraintRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConstraint.</param>
        /// 
        /// <returns>Returns a  DescribeConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public virtual DescribeConstraintResponse EndDescribeConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConstraintResponse>(asyncResult);
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
            var marshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyProductStatusRequest,DescribeCopyProductStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCopyProductStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeCopyProductStatus(DescribeCopyProductStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeCopyProductStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCopyProductStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCopyProductStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCopyProductStatus.</param>
        /// 
        /// <returns>Returns a  DescribeCopyProductStatusResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        public virtual DescribeCopyProductStatusResponse EndDescribeCopyProductStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCopyProductStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePortfolio

        /// <summary>
        /// Gets information about the specified portfolio.
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
            var marshaller = DescribePortfolioRequestMarshaller.Instance;
            var unmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return Invoke<DescribePortfolioRequest,DescribePortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual IAsyncResult BeginDescribePortfolio(DescribePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribePortfolioRequestMarshaller.Instance;
            var unmarshaller = DescribePortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortfolio.</param>
        /// 
        /// <returns>Returns a  DescribePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public virtual DescribePortfolioResponse EndDescribePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProduct

        /// <summary>
        /// Gets information about the specified product.
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
            var marshaller = DescribeProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProductRequest,DescribeProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual IAsyncResult BeginDescribeProduct(DescribeProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProductResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProduct.</param>
        /// 
        /// <returns>Returns a  DescribeProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public virtual DescribeProductResponse EndDescribeProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductResponse>(asyncResult);
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
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var marshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            var unmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeProductAsAdminRequest,DescribeProductAsAdminResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProductAsAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual IAsyncResult BeginDescribeProductAsAdmin(DescribeProductAsAdminRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProductAsAdminRequestMarshaller.Instance;
            var unmarshaller = DescribeProductAsAdminResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProductAsAdminRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductAsAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeProductAsAdminResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public virtual DescribeProductAsAdminResponse EndDescribeProductAsAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductAsAdminResponse>(asyncResult);
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
            var marshaller = DescribeProductViewRequestMarshaller.Instance;
            var unmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return Invoke<DescribeProductViewRequest,DescribeProductViewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProductView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual IAsyncResult BeginDescribeProductView(DescribeProductViewRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProductViewRequestMarshaller.Instance;
            var unmarshaller = DescribeProductViewResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProductViewRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductView.</param>
        /// 
        /// <returns>Returns a  DescribeProductViewResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public virtual DescribeProductViewResponse EndDescribeProductView(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProvisionedProduct

        /// <summary>
        /// Gets information about the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var marshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductRequest,DescribeProvisionedProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual IAsyncResult BeginDescribeProvisionedProduct(DescribeProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProvisionedProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  DescribeProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public virtual DescribeProvisionedProductResponse EndDescribeProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisionedProductResponse>(asyncResult);
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
            var marshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisionedProductPlanRequest,DescribeProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual IAsyncResult BeginDescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisionedProductPlanResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProvisionedProductPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  DescribeProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        public virtual DescribeProvisionedProductPlanResponse EndDescribeProvisionedProductPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisionedProductPlanResponse>(asyncResult);
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
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var marshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningArtifactRequest,DescribeProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual IAsyncResult BeginDescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProvisioningArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public virtual DescribeProvisioningArtifactResponse EndDescribeProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisioningArtifactResponse>(asyncResult);
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
            var marshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeProvisioningParametersRequest,DescribeProvisioningParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeProvisioningParameters(DescribeProvisioningParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeProvisioningParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeProvisioningParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProvisioningParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningParameters.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningParametersResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public virtual DescribeProvisioningParametersResponse EndDescribeProvisioningParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisioningParametersResponse>(asyncResult);
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
            var marshaller = DescribeRecordRequestMarshaller.Instance;
            var unmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return Invoke<DescribeRecordRequest,DescribeRecordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecord(DescribeRecordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeRecordRequestMarshaller.Instance;
            var unmarshaller = DescribeRecordResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRecordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecord.</param>
        /// 
        /// <returns>Returns a  DescribeRecordResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public virtual DescribeRecordResponse EndDescribeRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecordResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var marshaller = DescribeTagOptionRequestMarshaller.Instance;
            var unmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return Invoke<DescribeTagOptionRequest,DescribeTagOptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual IAsyncResult BeginDescribeTagOption(DescribeTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeTagOptionRequestMarshaller.Instance;
            var unmarshaller = DescribeTagOptionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTagOptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTagOption.</param>
        /// 
        /// <returns>Returns a  DescribeTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        public virtual DescribeTagOptionResponse EndDescribeTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagOptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio

        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
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
            var marshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociatePrincipalFromPortfolioRequest,DisassociatePrincipalFromPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePrincipalFromPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociatePrincipalFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociatePrincipalFromPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociatePrincipalFromPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePrincipalFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociatePrincipalFromPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public virtual DisassociatePrincipalFromPortfolioResponse EndDisassociatePrincipalFromPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePrincipalFromPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateProductFromPortfolio

        /// <summary>
        /// Disassociates the specified product from the specified portfolio.
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
            var marshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return Invoke<DisassociateProductFromPortfolioRequest,DisassociateProductFromPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateProductFromPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual IAsyncResult BeginDisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateProductFromPortfolioRequestMarshaller.Instance;
            var unmarshaller = DisassociateProductFromPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateProductFromPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateProductFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociateProductFromPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public virtual DisassociateProductFromPortfolioResponse EndDisassociateProductFromPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateProductFromPortfolioResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var marshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateTagOptionFromResourceRequest,DisassociateTagOptionFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTagOptionFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateTagOptionFromResourceRequestMarshaller.Instance;
            var unmarshaller = DisassociateTagOptionFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateTagOptionFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTagOptionFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateTagOptionFromResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        public virtual DisassociateTagOptionFromResourceResponse EndDisassociateTagOptionFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTagOptionFromResourceResponse>(asyncResult);
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
            var marshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return Invoke<ExecuteProvisionedProductPlanRequest,ExecuteProvisionedProductPlanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual IAsyncResult BeginExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ExecuteProvisionedProductPlanRequestMarshaller.Instance;
            var unmarshaller = ExecuteProvisionedProductPlanResponseUnmarshaller.Instance;

            return BeginInvoke<ExecuteProvisionedProductPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  ExecuteProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        public virtual ExecuteProvisionedProductPlanResponse EndExecuteProvisionedProductPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteProvisionedProductPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares

        /// <summary>
        /// Lists all portfolios for which sharing was accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var marshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            var unmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return Invoke<ListAcceptedPortfolioSharesRequest,ListAcceptedPortfolioSharesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAcceptedPortfolioShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual IAsyncResult BeginListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAcceptedPortfolioSharesRequestMarshaller.Instance;
            var unmarshaller = ListAcceptedPortfolioSharesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAcceptedPortfolioSharesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAcceptedPortfolioShares.</param>
        /// 
        /// <returns>Returns a  ListAcceptedPortfolioSharesResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public virtual ListAcceptedPortfolioSharesResponse EndListAcceptedPortfolioShares(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAcceptedPortfolioSharesResponse>(asyncResult);
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
            var marshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListConstraintsForPortfolioRequest,ListConstraintsForPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConstraintsForPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual IAsyncResult BeginListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListConstraintsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListConstraintsForPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<ListConstraintsForPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConstraintsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListConstraintsForPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public virtual ListConstraintsForPortfolioResponse EndListConstraintsForPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConstraintsForPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLaunchPaths

        /// <summary>
        /// Lists the paths to the specified product. A path is how the user has access to a specified
        /// product, and is necessary when provisioning a product. A path also determines the
        /// constraints put on the product.
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
            var marshaller = ListLaunchPathsRequestMarshaller.Instance;
            var unmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return Invoke<ListLaunchPathsRequest,ListLaunchPathsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLaunchPaths
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual IAsyncResult BeginListLaunchPaths(ListLaunchPathsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListLaunchPathsRequestMarshaller.Instance;
            var unmarshaller = ListLaunchPathsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLaunchPathsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunchPaths.</param>
        /// 
        /// <returns>Returns a  ListLaunchPathsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public virtual ListLaunchPathsResponse EndListLaunchPaths(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLaunchPathsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPortfolioAccess

        /// <summary>
        /// Lists the account IDs that have access to the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var marshaller = ListPortfolioAccessRequestMarshaller.Instance;
            var unmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return Invoke<ListPortfolioAccessRequest,ListPortfolioAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfolioAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual IAsyncResult BeginListPortfolioAccess(ListPortfolioAccessRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPortfolioAccessRequestMarshaller.Instance;
            var unmarshaller = ListPortfolioAccessResponseUnmarshaller.Instance;

            return BeginInvoke<ListPortfolioAccessRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolioAccess.</param>
        /// 
        /// <returns>Returns a  ListPortfolioAccessResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public virtual ListPortfolioAccessResponse EndListPortfolioAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPortfolioAccessResponse>(asyncResult);
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
            var marshaller = ListPortfoliosRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosRequest,ListPortfoliosResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfolios
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual IAsyncResult BeginListPortfolios(ListPortfoliosRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPortfoliosRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosResponseUnmarshaller.Instance;

            return BeginInvoke<ListPortfoliosRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolios.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public virtual ListPortfoliosResponse EndListPortfolios(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPortfoliosResponse>(asyncResult);
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
            var marshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return Invoke<ListPortfoliosForProductRequest,ListPortfoliosForProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfoliosForProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual IAsyncResult BeginListPortfoliosForProduct(ListPortfoliosForProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPortfoliosForProductRequestMarshaller.Instance;
            var unmarshaller = ListPortfoliosForProductResponseUnmarshaller.Instance;

            return BeginInvoke<ListPortfoliosForProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfoliosForProduct.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosForProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public virtual ListPortfoliosForProductResponse EndListPortfoliosForProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPortfoliosForProductResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrincipalsForPortfolio

        /// <summary>
        /// Lists all principal ARNs associated with the specified portfolio.
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
            var marshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return Invoke<ListPrincipalsForPortfolioRequest,ListPrincipalsForPortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipalsForPortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual IAsyncResult BeginListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPrincipalsForPortfolioRequestMarshaller.Instance;
            var unmarshaller = ListPrincipalsForPortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<ListPrincipalsForPortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipalsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListPrincipalsForPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public virtual ListPrincipalsForPortfolioResponse EndListPrincipalsForPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrincipalsForPortfolioResponse>(asyncResult);
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
            var marshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            var unmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedProductPlansRequest,ListProvisionedProductPlansResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisionedProductPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual IAsyncResult BeginListProvisionedProductPlans(ListProvisionedProductPlansRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListProvisionedProductPlansRequestMarshaller.Instance;
            var unmarshaller = ListProvisionedProductPlansResponseUnmarshaller.Instance;

            return BeginInvoke<ListProvisionedProductPlansRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisionedProductPlans.</param>
        /// 
        /// <returns>Returns a  ListProvisionedProductPlansResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        public virtual ListProvisionedProductPlansResponse EndListProvisionedProductPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisionedProductPlansResponse>(asyncResult);
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
            var marshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListProvisioningArtifactsRequest,ListProvisioningArtifactsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual IAsyncResult BeginListProvisioningArtifacts(ListProvisioningArtifactsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListProvisioningArtifactsRequestMarshaller.Instance;
            var unmarshaller = ListProvisioningArtifactsResponseUnmarshaller.Instance;

            return BeginInvoke<ListProvisioningArtifactsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningArtifacts.</param>
        /// 
        /// <returns>Returns a  ListProvisioningArtifactsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public virtual ListProvisioningArtifactsResponse EndListProvisioningArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisioningArtifactsResponse>(asyncResult);
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
            var marshaller = ListRecordHistoryRequestMarshaller.Instance;
            var unmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRecordHistoryRequest,ListRecordHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecordHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual IAsyncResult BeginListRecordHistory(ListRecordHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListRecordHistoryRequestMarshaller.Instance;
            var unmarshaller = ListRecordHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<ListRecordHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecordHistory.</param>
        /// 
        /// <returns>Returns a  ListRecordHistoryResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public virtual ListRecordHistoryResponse EndListRecordHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecordHistoryResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var marshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForTagOptionRequest,ListResourcesForTagOptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesForTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual IAsyncResult BeginListResourcesForTagOption(ListResourcesForTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResourcesForTagOptionRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForTagOptionResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourcesForTagOptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesForTagOption.</param>
        /// 
        /// <returns>Returns a  ListResourcesForTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        public virtual ListResourcesForTagOptionResponse EndListResourcesForTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesForTagOptionResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var marshaller = ListTagOptionsRequestMarshaller.Instance;
            var unmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return Invoke<ListTagOptionsRequest,ListTagOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual IAsyncResult BeginListTagOptions(ListTagOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagOptionsRequestMarshaller.Instance;
            var unmarshaller = ListTagOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagOptions.</param>
        /// 
        /// <returns>Returns a  ListTagOptionsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public virtual ListTagOptionsResponse EndListTagOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ProvisionProduct

        /// <summary>
        /// Provisions the specified product.
        /// 
        ///  
        /// <para>
        /// A provisioned product is a resourced instance of a product. For example, provisioning
        /// a product based on a CloudFormation template launches a CloudFormation stack and its
        /// underlying resources. You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        ///  
        /// <para>
        /// If the request contains a tag key with an empty list of values, there is a tag conflict
        /// for that key. Do not include conflicted keys as tags, or this causes the error "Parameter
        /// validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>".
        /// </para>
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
            var marshaller = ProvisionProductRequestMarshaller.Instance;
            var unmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return Invoke<ProvisionProductRequest,ProvisionProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual IAsyncResult BeginProvisionProduct(ProvisionProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ProvisionProductRequestMarshaller.Instance;
            var unmarshaller = ProvisionProductResponseUnmarshaller.Instance;

            return BeginInvoke<ProvisionProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionProduct.</param>
        /// 
        /// <returns>Returns a  ProvisionProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public virtual ProvisionProductResponse EndProvisionProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<ProvisionProductResponse>(asyncResult);
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
            var marshaller = RejectPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return Invoke<RejectPortfolioShareRequest,RejectPortfolioShareResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectPortfolioShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual IAsyncResult BeginRejectPortfolioShare(RejectPortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RejectPortfolioShareRequestMarshaller.Instance;
            var unmarshaller = RejectPortfolioShareResponseUnmarshaller.Instance;

            return BeginInvoke<RejectPortfolioShareRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectPortfolioShare.</param>
        /// 
        /// <returns>Returns a  RejectPortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public virtual RejectPortfolioShareResponse EndRejectPortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectPortfolioShareResponse>(asyncResult);
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
            var marshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<ScanProvisionedProductsRequest,ScanProvisionedProductsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScanProvisionedProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual IAsyncResult BeginScanProvisionedProducts(ScanProvisionedProductsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ScanProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = ScanProvisionedProductsResponseUnmarshaller.Instance;

            return BeginInvoke<ScanProvisionedProductsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScanProvisionedProducts.</param>
        /// 
        /// <returns>Returns a  ScanProvisionedProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public virtual ScanProvisionedProductsResponse EndScanProvisionedProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<ScanProvisionedProductsResponse>(asyncResult);
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
            var marshaller = SearchProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProductsRequest,SearchProductsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual IAsyncResult BeginSearchProducts(SearchProductsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SearchProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProductsResponseUnmarshaller.Instance;

            return BeginInvoke<SearchProductsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProducts.</param>
        /// 
        /// <returns>Returns a  SearchProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public virtual SearchProductsResponse EndSearchProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProductsResponse>(asyncResult);
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
            var marshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            var unmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return Invoke<SearchProductsAsAdminRequest,SearchProductsAsAdminResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProductsAsAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual IAsyncResult BeginSearchProductsAsAdmin(SearchProductsAsAdminRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SearchProductsAsAdminRequestMarshaller.Instance;
            var unmarshaller = SearchProductsAsAdminResponseUnmarshaller.Instance;

            return BeginInvoke<SearchProductsAsAdminRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProductsAsAdmin.</param>
        /// 
        /// <returns>Returns a  SearchProductsAsAdminResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public virtual SearchProductsAsAdminResponse EndSearchProductsAsAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProductsAsAdminResponse>(asyncResult);
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
            var marshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return Invoke<SearchProvisionedProductsRequest,SearchProvisionedProductsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProvisionedProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual IAsyncResult BeginSearchProvisionedProducts(SearchProvisionedProductsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SearchProvisionedProductsRequestMarshaller.Instance;
            var unmarshaller = SearchProvisionedProductsResponseUnmarshaller.Instance;

            return BeginInvoke<SearchProvisionedProductsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProvisionedProducts.</param>
        /// 
        /// <returns>Returns a  SearchProvisionedProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        public virtual SearchProvisionedProductsResponse EndSearchProvisionedProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProvisionedProductsResponse>(asyncResult);
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
            var marshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<TerminateProvisionedProductRequest,TerminateProvisionedProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual IAsyncResult BeginTerminateProvisionedProduct(TerminateProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TerminateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = TerminateProvisionedProductResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateProvisionedProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  TerminateProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public virtual TerminateProvisionedProductResponse EndTerminateProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateProvisionedProductResponse>(asyncResult);
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
            var marshaller = UpdateConstraintRequestMarshaller.Instance;
            var unmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return Invoke<UpdateConstraintRequest,UpdateConstraintResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConstraint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual IAsyncResult BeginUpdateConstraint(UpdateConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConstraintRequestMarshaller.Instance;
            var unmarshaller = UpdateConstraintResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConstraintRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConstraint.</param>
        /// 
        /// <returns>Returns a  UpdateConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public virtual UpdateConstraintResponse EndUpdateConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConstraintResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var marshaller = UpdatePortfolioRequestMarshaller.Instance;
            var unmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return Invoke<UpdatePortfolioRequest,UpdatePortfolioResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortfolio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual IAsyncResult BeginUpdatePortfolio(UpdatePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdatePortfolioRequestMarshaller.Instance;
            var unmarshaller = UpdatePortfolioResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePortfolioRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortfolio.</param>
        /// 
        /// <returns>Returns a  UpdatePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        public virtual UpdatePortfolioResponse EndUpdatePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePortfolioResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var marshaller = UpdateProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductRequest,UpdateProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual IAsyncResult BeginUpdateProduct(UpdateProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual UpdateProductResponse EndUpdateProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProductResponse>(asyncResult);
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
            var marshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedProductRequest,UpdateProvisionedProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual IAsyncResult BeginUpdateProvisionedProduct(UpdateProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateProvisionedProductRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisionedProductResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProvisionedProductRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public virtual UpdateProvisionedProductResponse EndUpdateProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProvisionedProductResponse>(asyncResult);
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
            var marshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisioningArtifactRequest,UpdateProvisioningArtifactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual IAsyncResult BeginUpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateProvisioningArtifactRequestMarshaller.Instance;
            var unmarshaller = UpdateProvisioningArtifactResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProvisioningArtifactRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  UpdateProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public virtual UpdateProvisioningArtifactResponse EndUpdateProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProvisioningArtifactResponse>(asyncResult);
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
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var marshaller = UpdateTagOptionRequestMarshaller.Instance;
            var unmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return Invoke<UpdateTagOptionRequest,UpdateTagOptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual IAsyncResult BeginUpdateTagOption(UpdateTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTagOptionRequestMarshaller.Instance;
            var unmarshaller = UpdateTagOptionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTagOptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTagOption.</param>
        /// 
        /// <returns>Returns a  UpdateTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        public virtual UpdateTagOptionResponse EndUpdateTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTagOptionResponse>(asyncResult);
        }

        #endregion
        
    }
}