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
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://aws.amazon.com/servicecatalog/">AWS Service Catalog</a> allows organizations
    /// to create and manage catalogs of IT services that are approved for use on AWS. This
    /// documentation provides reference material for the AWS Service Catalog end user API.
    /// To get the most out of this documentation, be familiar with the terminology discussed
    /// in <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/what-is_concepts.html">AWS
    /// Service Catalog Concepts</a>.
    /// </para>
    ///  
    /// <para>
    ///  <i>Additional Resources</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">AWS
    /// Service Catalog Administrator Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/servicecatalog/latest/userguide/introduction.html">AWS
    /// Service Catalog User Guide</a> 
    /// </para>
    ///  </li> </ul>
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
        /// Accepts an offer to share a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        public AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request)
        {
            var marshaller = new AcceptPortfolioShareRequestMarshaller();
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
        public IAsyncResult BeginAcceptPortfolioShare(AcceptPortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AcceptPortfolioShareRequestMarshaller();
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
        public  AcceptPortfolioShareResponse EndAcceptPortfolioShare(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        public AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request)
        {
            var marshaller = new AssociatePrincipalWithPortfolioRequestMarshaller();
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
        public IAsyncResult BeginAssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociatePrincipalWithPortfolioRequestMarshaller();
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
        public  AssociatePrincipalWithPortfolioResponse EndAssociatePrincipalWithPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePrincipalWithPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateProductWithPortfolio

        /// <summary>
        /// Associates a product with a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        public AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request)
        {
            var marshaller = new AssociateProductWithPortfolioRequestMarshaller();
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
        public IAsyncResult BeginAssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateProductWithPortfolioRequestMarshaller();
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
        public  AssociateProductWithPortfolioResponse EndAssociateProductWithPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateProductWithPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateTagOptionWithResource

        /// <summary>
        /// Associate a TagOption identifier with a resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateTagOptionWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in an invalid state. Inspect the
        /// resource you are using for this operation to ensure that all resource states are valid
        /// before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
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
        public AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request)
        {
            var marshaller = new AssociateTagOptionWithResourceRequestMarshaller();
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
        public IAsyncResult BeginAssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateTagOptionWithResourceRequestMarshaller();
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
        public  AssociateTagOptionWithResourceResponse EndAssociateTagOptionWithResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTagOptionWithResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConstraint

        /// <summary>
        /// Creates a new constraint. For more information, see <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/constraints.html">Using
        /// Constraints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        public CreateConstraintResponse CreateConstraint(CreateConstraintRequest request)
        {
            var marshaller = new CreateConstraintRequestMarshaller();
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
        public IAsyncResult BeginCreateConstraint(CreateConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateConstraintRequestMarshaller();
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
        public  CreateConstraintResponse EndCreateConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConstraintResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortfolio

        /// <summary>
        /// Creates a new portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        public CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request)
        {
            var marshaller = new CreatePortfolioRequestMarshaller();
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
        public IAsyncResult BeginCreatePortfolio(CreatePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePortfolioRequestMarshaller();
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
        public  CreatePortfolioResponse EndCreatePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePortfolioShare

        /// <summary>
        /// Creates a new portfolio share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        public CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request)
        {
            var marshaller = new CreatePortfolioShareRequestMarshaller();
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
        public IAsyncResult BeginCreatePortfolioShare(CreatePortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePortfolioShareRequestMarshaller();
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
        public  CreatePortfolioShareResponse EndCreatePortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePortfolioShareResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProduct

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var marshaller = new CreateProductRequestMarshaller();
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
        public IAsyncResult BeginCreateProduct(CreateProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateProductRequestMarshaller();
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
        public  CreateProductResponse EndCreateProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProductResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProvisioningArtifact

        /// <summary>
        /// Create a new provisioning artifact for the specified product. This operation does
        /// not work with a product that has been shared with you.
        /// 
        ///  
        /// <para>
        /// See the bottom of this topic for an example JSON request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        public CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request)
        {
            var marshaller = new CreateProvisioningArtifactRequestMarshaller();
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
        public IAsyncResult BeginCreateProvisioningArtifact(CreateProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateProvisioningArtifactRequestMarshaller();
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
        public  CreateProvisioningArtifactResponse EndCreateProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProvisioningArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTagOption

        /// <summary>
        /// Create a new TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption service method.</param>
        /// 
        /// <returns>The response from the CreateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        public CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request)
        {
            var marshaller = new CreateTagOptionRequestMarshaller();
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
        public IAsyncResult BeginCreateTagOption(CreateTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTagOptionRequestMarshaller();
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
        public  CreateTagOptionResponse EndCreateTagOption(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        public DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request)
        {
            var marshaller = new DeleteConstraintRequestMarshaller();
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
        public IAsyncResult BeginDeleteConstraint(DeleteConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteConstraintRequestMarshaller();
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
        public  DeleteConstraintResponse EndDeleteConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConstraintResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePortfolio

        /// <summary>
        /// Deletes the specified portfolio. This operation does not work with a portfolio that
        /// has been shared with you or if it has products, users, constraints, or shared accounts
        /// associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
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
        public DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request)
        {
            var marshaller = new DeletePortfolioRequestMarshaller();
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
        public IAsyncResult BeginDeletePortfolio(DeletePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePortfolioRequestMarshaller();
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
        public  DeletePortfolioResponse EndDeletePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePortfolioShare

        /// <summary>
        /// Deletes the specified portfolio share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        public DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request)
        {
            var marshaller = new DeletePortfolioShareRequestMarshaller();
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
        public IAsyncResult BeginDeletePortfolioShare(DeletePortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePortfolioShareRequestMarshaller();
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
        public  DeletePortfolioShareResponse EndDeletePortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePortfolioShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProduct

        /// <summary>
        /// Deletes the specified product. This operation does not work with a product that has
        /// been shared with you or is associated with a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
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
        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var marshaller = new DeleteProductRequestMarshaller();
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
        public IAsyncResult BeginDeleteProduct(DeleteProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteProductRequestMarshaller();
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
        public  DeleteProductResponse EndDeleteProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProductResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProvisioningArtifact

        /// <summary>
        /// Deletes the specified provisioning artifact. This operation does not work on a provisioning
        /// artifact associated with a product that has been shared with you, or on the last provisioning
        /// artifact associated with a product (a product must have at least one provisioning
        /// artifact).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        public DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request)
        {
            var marshaller = new DeleteProvisioningArtifactRequestMarshaller();
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
        public IAsyncResult BeginDeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteProvisioningArtifactRequestMarshaller();
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
        public  DeleteProvisioningArtifactResponse EndDeleteProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisioningArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConstraint

        /// <summary>
        /// Retrieves detailed information for a specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        public DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request)
        {
            var marshaller = new DescribeConstraintRequestMarshaller();
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
        public IAsyncResult BeginDescribeConstraint(DescribeConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConstraintRequestMarshaller();
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
        public  DescribeConstraintResponse EndDescribeConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConstraintResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePortfolio

        /// <summary>
        /// Retrieves detailed information and any tags associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        public DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request)
        {
            var marshaller = new DescribePortfolioRequestMarshaller();
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
        public IAsyncResult BeginDescribePortfolio(DescribePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePortfolioRequestMarshaller();
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
        public  DescribePortfolioResponse EndDescribePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProduct

        /// <summary>
        /// Retrieves information about a specified product.
        /// 
        ///  
        /// <para>
        /// This operation is functionally identical to <a>DescribeProductView</a> except that
        /// it takes as input <code>ProductId</code> instead of <code>ProductViewId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        public DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            var marshaller = new DescribeProductRequestMarshaller();
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
        public IAsyncResult BeginDescribeProduct(DescribeProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProductRequestMarshaller();
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
        public  DescribeProductResponse EndDescribeProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProductAsAdmin

        /// <summary>
        /// Retrieves information about a specified product, run with administrator access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        public DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request)
        {
            var marshaller = new DescribeProductAsAdminRequestMarshaller();
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
        public IAsyncResult BeginDescribeProductAsAdmin(DescribeProductAsAdminRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProductAsAdminRequestMarshaller();
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
        public  DescribeProductAsAdminResponse EndDescribeProductAsAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductAsAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProductView

        /// <summary>
        /// Retrieves information about a specified product.
        /// 
        ///  
        /// <para>
        /// This operation is functionally identical to <a>DescribeProduct</a> except that it
        /// takes as input <code>ProductViewId</code> instead of <code>ProductId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        public DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request)
        {
            var marshaller = new DescribeProductViewRequestMarshaller();
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
        public IAsyncResult BeginDescribeProductView(DescribeProductViewRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProductViewRequestMarshaller();
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
        public  DescribeProductViewResponse EndDescribeProductView(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProvisionedProduct

        /// <summary>
        /// Retrieve detailed information about the provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        public DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request)
        {
            var marshaller = new DescribeProvisionedProductRequestMarshaller();
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
        public IAsyncResult BeginDescribeProvisionedProduct(DescribeProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProvisionedProductRequestMarshaller();
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
        public  DescribeProvisionedProductResponse EndDescribeProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisionedProductResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProvisioningArtifact

        /// <summary>
        /// Retrieves detailed information about the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        public DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request)
        {
            var marshaller = new DescribeProvisioningArtifactRequestMarshaller();
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
        public IAsyncResult BeginDescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProvisioningArtifactRequestMarshaller();
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
        public  DescribeProvisioningArtifactResponse EndDescribeProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisioningArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProvisioningParameters

        /// <summary>
        /// Provides information about parameters required to provision a specified product in
        /// a specified manner. Use this operation to obtain the list of <code>ProvisioningArtifactParameters</code>
        /// parameters available to call the <a>ProvisionProduct</a> operation for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// If the output contains a TagOption key with an empty list of values, there is a TagOption
        /// conflict for that key. The end user cannot take action to fix the conflict, and launch
        /// is not blocked. In subsequent calls to the <code>ProvisionProduct</code> operation,
        /// do not include conflicted TagOption keys as tags. Calls to <code>ProvisionProduct</code>
        /// with empty TagOption values cause the error "Parameter validation failed: Missing
        /// required parameter in Tags[<i>N</i>]:<i>Value</i> ". Calls to <code>ProvisionProduct</code>
        /// with conflicted TagOption keys automatically tag the provisioned product with the
        /// conflicted keys with the value "<code>sc-tagoption-conflict-portfolioId-productId</code>".
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        public DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request)
        {
            var marshaller = new DescribeProvisioningParametersRequestMarshaller();
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
        public IAsyncResult BeginDescribeProvisioningParameters(DescribeProvisioningParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProvisioningParametersRequestMarshaller();
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
        public  DescribeProvisioningParametersResponse EndDescribeProvisioningParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProvisioningParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecord

        /// <summary>
        /// Retrieves a paginated list of the full details of a specific request. Use this operation
        /// after calling a request operation (<a>ProvisionProduct</a>, <a>TerminateProvisionedProduct</a>,
        /// or <a>UpdateProvisionedProduct</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        public DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            var marshaller = new DescribeRecordRequestMarshaller();
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
        public IAsyncResult BeginDescribeRecord(DescribeRecordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRecordRequestMarshaller();
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
        public  DescribeRecordResponse EndDescribeRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecordResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTagOption

        /// <summary>
        /// Describes a TagOption.
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
        public DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request)
        {
            var marshaller = new DescribeTagOptionRequestMarshaller();
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
        public IAsyncResult BeginDescribeTagOption(DescribeTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTagOptionRequestMarshaller();
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
        public  DescribeTagOptionResponse EndDescribeTagOption(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        public DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request)
        {
            var marshaller = new DisassociatePrincipalFromPortfolioRequestMarshaller();
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
        public IAsyncResult BeginDisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociatePrincipalFromPortfolioRequestMarshaller();
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
        public  DisassociatePrincipalFromPortfolioResponse EndDisassociatePrincipalFromPortfolio(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        public DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request)
        {
            var marshaller = new DisassociateProductFromPortfolioRequestMarshaller();
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
        public IAsyncResult BeginDisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateProductFromPortfolioRequestMarshaller();
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
        public  DisassociateProductFromPortfolioResponse EndDisassociateProductFromPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateProductFromPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTagOptionFromResource

        /// <summary>
        /// Disassociates a TagOption from a resource.
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
        public DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request)
        {
            var marshaller = new DisassociateTagOptionFromResourceRequestMarshaller();
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
        public IAsyncResult BeginDisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateTagOptionFromResourceRequestMarshaller();
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
        public  DisassociateTagOptionFromResourceResponse EndDisassociateTagOptionFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTagOptionFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAcceptedPortfolioShares

        /// <summary>
        /// Lists details of all portfolios for which sharing was accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        public ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request)
        {
            var marshaller = new ListAcceptedPortfolioSharesRequestMarshaller();
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
        public IAsyncResult BeginListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAcceptedPortfolioSharesRequestMarshaller();
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
        public  ListAcceptedPortfolioSharesResponse EndListAcceptedPortfolioShares(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAcceptedPortfolioSharesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConstraintsForPortfolio

        /// <summary>
        /// Retrieves detailed constraint information for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        public ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request)
        {
            var marshaller = new ListConstraintsForPortfolioRequestMarshaller();
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
        public IAsyncResult BeginListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListConstraintsForPortfolioRequestMarshaller();
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
        public  ListConstraintsForPortfolioResponse EndListConstraintsForPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConstraintsForPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLaunchPaths

        /// <summary>
        /// Returns a paginated list of all paths to a specified product. A path is how the user
        /// has access to a specified product, and is necessary when provisioning a product. A
        /// path also determines the constraints put on the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        public ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request)
        {
            var marshaller = new ListLaunchPathsRequestMarshaller();
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
        public IAsyncResult BeginListLaunchPaths(ListLaunchPathsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListLaunchPathsRequestMarshaller();
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
        public  ListLaunchPathsResponse EndListLaunchPaths(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLaunchPathsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPortfolioAccess

        /// <summary>
        /// Lists the account IDs that have been authorized sharing of the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        public ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request)
        {
            var marshaller = new ListPortfolioAccessRequestMarshaller();
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
        public IAsyncResult BeginListPortfolioAccess(ListPortfolioAccessRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPortfolioAccessRequestMarshaller();
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
        public  ListPortfolioAccessResponse EndListPortfolioAccess(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        public ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request)
        {
            var marshaller = new ListPortfoliosRequestMarshaller();
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
        public IAsyncResult BeginListPortfolios(ListPortfoliosRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPortfoliosRequestMarshaller();
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
        public  ListPortfoliosResponse EndListPortfolios(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        public ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request)
        {
            var marshaller = new ListPortfoliosForProductRequestMarshaller();
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
        public IAsyncResult BeginListPortfoliosForProduct(ListPortfoliosForProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPortfoliosForProductRequestMarshaller();
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
        public  ListPortfoliosForProductResponse EndListPortfoliosForProduct(IAsyncResult asyncResult)
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
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        public ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request)
        {
            var marshaller = new ListPrincipalsForPortfolioRequestMarshaller();
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
        public IAsyncResult BeginListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPrincipalsForPortfolioRequestMarshaller();
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
        public  ListPrincipalsForPortfolioResponse EndListPrincipalsForPortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrincipalsForPortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProvisioningArtifacts

        /// <summary>
        /// Lists all provisioning artifacts associated with the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        public ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request)
        {
            var marshaller = new ListProvisioningArtifactsRequestMarshaller();
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
        public IAsyncResult BeginListProvisioningArtifacts(ListProvisioningArtifactsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListProvisioningArtifactsRequestMarshaller();
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
        public  ListProvisioningArtifactsResponse EndListProvisioningArtifacts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisioningArtifactsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecordHistory

        /// <summary>
        /// Returns a paginated list of all performed requests, in the form of RecordDetails objects
        /// that are filtered as specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        public ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request)
        {
            var marshaller = new ListRecordHistoryRequestMarshaller();
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
        public IAsyncResult BeginListRecordHistory(ListRecordHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRecordHistoryRequestMarshaller();
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
        public  ListRecordHistoryResponse EndListRecordHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecordHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourcesForTagOption

        /// <summary>
        /// Lists resources associated with a TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
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
        public ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request)
        {
            var marshaller = new ListResourcesForTagOptionRequestMarshaller();
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
        public IAsyncResult BeginListResourcesForTagOption(ListResourcesForTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListResourcesForTagOptionRequestMarshaller();
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
        public  ListResourcesForTagOptionResponse EndListResourcesForTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesForTagOptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagOptions

        /// <summary>
        /// Lists detailed TagOptions information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions service method.</param>
        /// 
        /// <returns>The response from the ListTagOptions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Please use the AWS console to perform the
        /// migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        public ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request)
        {
            var marshaller = new ListTagOptionsRequestMarshaller();
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
        public IAsyncResult BeginListTagOptions(ListTagOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagOptionsRequestMarshaller();
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
        public  ListTagOptionsResponse EndListTagOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ProvisionProduct

        /// <summary>
        /// Requests a <i>provision</i> of a specified product. A <i>provisioned product</i> is
        /// a resourced instance for a product. For example, provisioning a CloudFormation-template-backed
        /// product results in launching a CloudFormation stack and all the underlying resources
        /// that come with it. 
        /// 
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// The error "Parameter validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>"
        /// indicates that your request contains a tag which has a tag key but no corresponding
        /// tag value (value is empty or null). Your call may have included values returned from
        /// a <code>DescribeProvisioningParameters</code> call that resulted in a TagOption key
        /// with an empty list. This happens when TagOption keys are in conflict. For more information,
        /// see <a>DescribeProvisioningParameters</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        public ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request)
        {
            var marshaller = new ProvisionProductRequestMarshaller();
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
        public IAsyncResult BeginProvisionProduct(ProvisionProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ProvisionProductRequestMarshaller();
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
        public  ProvisionProductResponse EndProvisionProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<ProvisionProductResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectPortfolioShare

        /// <summary>
        /// Rejects an offer to share a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        public RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request)
        {
            var marshaller = new RejectPortfolioShareRequestMarshaller();
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
        public IAsyncResult BeginRejectPortfolioShare(RejectPortfolioShareRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RejectPortfolioShareRequestMarshaller();
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
        public  RejectPortfolioShareResponse EndRejectPortfolioShare(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectPortfolioShareResponse>(asyncResult);
        }

        #endregion
        
        #region  ScanProvisionedProducts

        /// <summary>
        /// Returns a paginated list of all the ProvisionedProduct objects that are currently
        /// available (not terminated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        public ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request)
        {
            var marshaller = new ScanProvisionedProductsRequestMarshaller();
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
        public IAsyncResult BeginScanProvisionedProducts(ScanProvisionedProductsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ScanProvisionedProductsRequestMarshaller();
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
        public  ScanProvisionedProductsResponse EndScanProvisionedProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<ScanProvisionedProductsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchProducts

        /// <summary>
        /// Returns a paginated list all of the <code>Products</code> objects to which the caller
        /// has access. 
        /// 
        ///  
        /// <para>
        /// The output of this operation can be used as input for other operations, such as <a>DescribeProductView</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        public SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            var marshaller = new SearchProductsRequestMarshaller();
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
        public IAsyncResult BeginSearchProducts(SearchProductsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchProductsRequestMarshaller();
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
        public  SearchProductsResponse EndSearchProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProductsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchProductsAsAdmin

        /// <summary>
        /// Retrieves summary and status information about all products created within the caller's
        /// account. If a portfolio ID is provided, this operation retrieves information for only
        /// those products that are associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        public SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request)
        {
            var marshaller = new SearchProductsAsAdminRequestMarshaller();
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
        public IAsyncResult BeginSearchProductsAsAdmin(SearchProductsAsAdminRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchProductsAsAdminRequestMarshaller();
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
        public  SearchProductsAsAdminResponse EndSearchProductsAsAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProductsAsAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateProvisionedProduct

        /// <summary>
        /// Requests termination of an existing ProvisionedProduct object. If there are <code>Tags</code>
        /// associated with the object, they are terminated when the ProvisionedProduct object
        /// is terminated. 
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the ProvisionedProduct
        /// object.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        public TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request)
        {
            var marshaller = new TerminateProvisionedProductRequestMarshaller();
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
        public IAsyncResult BeginTerminateProvisionedProduct(TerminateProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateProvisionedProductRequestMarshaller();
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
        public  TerminateProvisionedProductResponse EndTerminateProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateProvisionedProductResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConstraint

        /// <summary>
        /// Updates an existing constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        public UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request)
        {
            var marshaller = new UpdateConstraintRequestMarshaller();
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
        public IAsyncResult BeginUpdateConstraint(UpdateConstraintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateConstraintRequestMarshaller();
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
        public  UpdateConstraintResponse EndUpdateConstraint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConstraintResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePortfolio

        /// <summary>
        /// Updates the specified portfolio's details. This operation does not work with a product
        /// that has been shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
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
        public UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request)
        {
            var marshaller = new UpdatePortfolioRequestMarshaller();
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
        public IAsyncResult BeginUpdatePortfolio(UpdatePortfolioRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdatePortfolioRequestMarshaller();
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
        public  UpdatePortfolioResponse EndUpdatePortfolio(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePortfolioResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProduct

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
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
        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var marshaller = new UpdateProductRequestMarshaller();
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
        public IAsyncResult BeginUpdateProduct(UpdateProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProductRequestMarshaller();
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
        public  UpdateProductResponse EndUpdateProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProductResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProvisionedProduct

        /// <summary>
        /// Requests updates to the configuration of an existing ProvisionedProduct object. If
        /// there are tags associated with the object, they cannot be updated or added with this
        /// operation. Depending on the specific updates requested, this operation may update
        /// with no interruption, with some interruption, or replace the ProvisionedProduct object
        /// entirely. 
        /// 
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        public UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request)
        {
            var marshaller = new UpdateProvisionedProductRequestMarshaller();
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
        public IAsyncResult BeginUpdateProvisionedProduct(UpdateProvisionedProductRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProvisionedProductRequestMarshaller();
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
        public  UpdateProvisionedProductResponse EndUpdateProvisionedProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProvisionedProductResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProvisioningArtifact

        /// <summary>
        /// Updates an existing provisioning artifact's information. This operation does not work
        /// on a provisioning artifact associated with a product that has been shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        public UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request)
        {
            var marshaller = new UpdateProvisioningArtifactRequestMarshaller();
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
        public IAsyncResult BeginUpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProvisioningArtifactRequestMarshaller();
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
        public  UpdateProvisioningArtifactResponse EndUpdateProvisioningArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProvisioningArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTagOption

        /// <summary>
        /// Updates an existing TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption service method.</param>
        /// 
        /// <returns>The response from the UpdateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
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
        public UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request)
        {
            var marshaller = new UpdateTagOptionRequestMarshaller();
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
        public IAsyncResult BeginUpdateTagOption(UpdateTagOptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateTagOptionRequestMarshaller();
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
        public  UpdateTagOptionResponse EndUpdateTagOption(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTagOptionResponse>(asyncResult);
        }

        #endregion
        
    }
}