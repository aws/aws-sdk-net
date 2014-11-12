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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch_2011_02_01
{
    /// <summary>
    /// Implementation for accessing CloudSearch
    ///
    /// Amazon CloudSearch Configuration Service 
    /// <para>
    /// You use the configuration service to create, configure, and manage search domains.
    /// Configuration service requests are submitted using the AWS Query protocol. AWS Query
    /// requests are HTTP or HTTPS requests submitted via HTTP GET or POST with a query parameter
    /// named Action.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: cloudsearch.<i>region</i>.amazonaws.com.
    /// For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported
    /// regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region">Regions
    /// and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudSearchClient : AmazonServiceClient, IAmazonCloudSearch
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        public AmazonCloudSearchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        public AmazonCloudSearchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudSearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(AmazonCloudSearchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudSearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Credentials and an
        /// AmazonCloudSearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(AWSCredentials credentials, AmazonCloudSearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudSearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudSearchClient Configuration Object</param>
        public AmazonCloudSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateDomain

        /// <summary>
        /// Creates a new search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainRequest,CreateDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        public IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CloudSearch.</returns>
        public  CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineIndexField

        /// <summary>
        /// Configures an <code>IndexField</code> for the search domain. Used to create new fields
        /// and modify existing ones. If the field exists, the new configuration replaces the
        /// old one. You can configure a maximum of 200 index fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request)
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DefineIndexFieldRequest,DefineIndexFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return BeginInvoke<DefineIndexFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a  DefineIndexFieldResult from CloudSearch.</returns>
        public  DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineIndexFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  DefineRankExpression

        /// <summary>
        /// Configures a <code>RankExpression</code> for the search domain. Used to create new
        /// rank expressions and modify existing ones. If the expression exists, the new configuration
        /// replaces the old one. You can configure a maximum of 50 rank expressions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression service method.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DefineRankExpressionResponse DefineRankExpression(DefineRankExpressionRequest request)
        {
            var marshaller = new DefineRankExpressionRequestMarshaller();
            var unmarshaller = DefineRankExpressionResponseUnmarshaller.Instance;

            return Invoke<DefineRankExpressionRequest,DefineRankExpressionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineRankExpression
        ///         operation.</returns>
        public IAsyncResult BeginDefineRankExpression(DefineRankExpressionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DefineRankExpressionRequestMarshaller();
            var unmarshaller = DefineRankExpressionResponseUnmarshaller.Instance;

            return BeginInvoke<DefineRankExpressionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineRankExpression.</param>
        /// 
        /// <returns>Returns a  DefineRankExpressionResult from CloudSearch.</returns>
        public  DefineRankExpressionResponse EndDefineRankExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<DefineRankExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Permanently deletes a search domain and all of its data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CloudSearch.</returns>
        public  DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIndexField

        /// <summary>
        /// Removes an <code>IndexField</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request)
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexFieldRequest,DeleteIndexFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        public IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIndexFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a  DeleteIndexFieldResult from CloudSearch.</returns>
        public  DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIndexFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRankExpression

        /// <summary>
        /// Removes a <code>RankExpression</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression service method.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DeleteRankExpressionResponse DeleteRankExpression(DeleteRankExpressionRequest request)
        {
            var marshaller = new DeleteRankExpressionRequestMarshaller();
            var unmarshaller = DeleteRankExpressionResponseUnmarshaller.Instance;

            return Invoke<DeleteRankExpressionRequest,DeleteRankExpressionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRankExpression
        ///         operation.</returns>
        public IAsyncResult BeginDeleteRankExpression(DeleteRankExpressionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRankExpressionRequestMarshaller();
            var unmarshaller = DeleteRankExpressionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRankExpressionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRankExpression.</param>
        /// 
        /// <returns>Returns a  DeleteRankExpressionResult from CloudSearch.</returns>
        public  DeleteRankExpressionResponse EndDeleteRankExpression(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRankExpressionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAvailabilityOptions

        /// <summary>
        /// Gets the availability options configured for a domain. By default, shows the configuration
        /// with any pending changes. Set the <code>Deployed</code> option to <code>true</code>
        /// to show the active configuration and exclude pending changes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request)
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityOptionsRequest,DescribeAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAvailabilityOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityOptionsResult from CloudSearch.</returns>
        public  DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAvailabilityOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDefaultSearchField

        /// <summary>
        /// Gets the default search field configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeDefaultSearchFieldResponse DescribeDefaultSearchField(DescribeDefaultSearchFieldRequest request)
        {
            var marshaller = new DescribeDefaultSearchFieldRequestMarshaller();
            var unmarshaller = DescribeDefaultSearchFieldResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultSearchFieldRequest,DescribeDefaultSearchFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultSearchField
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDefaultSearchField(DescribeDefaultSearchFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDefaultSearchFieldRequestMarshaller();
            var unmarshaller = DescribeDefaultSearchFieldResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDefaultSearchFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultSearchField.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultSearchFieldResult from CloudSearch.</returns>
        public  DescribeDefaultSearchFieldResponse EndDescribeDefaultSearchField(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDefaultSearchFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomains

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        public DescribeDomainsResponse DescribeDomains()
        {
            return DescribeDomains(new DescribeDomainsRequest());
        }

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsRequest,DescribeDomainsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDomains(DescribeDomainsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDomainsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a  DescribeDomainsResult from CloudSearch.</returns>
        public  DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIndexFields

        /// <summary>
        /// Gets information about the index fields configured for the search domain. Can be limited
        /// to specific fields by name. Shows all fields by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request)
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return Invoke<DescribeIndexFieldsRequest,DescribeIndexFieldsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndexFields
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIndexFieldsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a  DescribeIndexFieldsResult from CloudSearch.</returns>
        public  DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIndexFieldsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRankExpressions

        /// <summary>
        /// Gets the rank expressions configured for the search domain. Can be limited to specific
        /// rank expressions by name. Shows all rank expressions by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions service method.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeRankExpressionsResponse DescribeRankExpressions(DescribeRankExpressionsRequest request)
        {
            var marshaller = new DescribeRankExpressionsRequestMarshaller();
            var unmarshaller = DescribeRankExpressionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRankExpressionsRequest,DescribeRankExpressionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRankExpressions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRankExpressions(DescribeRankExpressionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRankExpressionsRequestMarshaller();
            var unmarshaller = DescribeRankExpressionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRankExpressionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRankExpressions.</param>
        /// 
        /// <returns>Returns a  DescribeRankExpressionsResult from CloudSearch.</returns>
        public  DescribeRankExpressionsResponse EndDescribeRankExpressions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRankExpressionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServiceAccessPolicies

        /// <summary>
        /// Gets information about the resource-based policies that control access to the domain's
        /// document and search services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request)
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceAccessPoliciesRequest,DescribeServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceAccessPolicies
        ///         operation.</returns>
        public IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeServiceAccessPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeServiceAccessPoliciesResult from CloudSearch.</returns>
        public  DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServiceAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStemmingOptions

        /// <summary>
        /// Gets the stemming dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeStemmingOptionsResponse DescribeStemmingOptions(DescribeStemmingOptionsRequest request)
        {
            var marshaller = new DescribeStemmingOptionsRequestMarshaller();
            var unmarshaller = DescribeStemmingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeStemmingOptionsRequest,DescribeStemmingOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStemmingOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStemmingOptions(DescribeStemmingOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStemmingOptionsRequestMarshaller();
            var unmarshaller = DescribeStemmingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStemmingOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStemmingOptions.</param>
        /// 
        /// <returns>Returns a  DescribeStemmingOptionsResult from CloudSearch.</returns>
        public  DescribeStemmingOptionsResponse EndDescribeStemmingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStemmingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStopwordOptions

        /// <summary>
        /// Gets the stopwords configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeStopwordOptionsResponse DescribeStopwordOptions(DescribeStopwordOptionsRequest request)
        {
            var marshaller = new DescribeStopwordOptionsRequestMarshaller();
            var unmarshaller = DescribeStopwordOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeStopwordOptionsRequest,DescribeStopwordOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStopwordOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStopwordOptions(DescribeStopwordOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStopwordOptionsRequestMarshaller();
            var unmarshaller = DescribeStopwordOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStopwordOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStopwordOptions.</param>
        /// 
        /// <returns>Returns a  DescribeStopwordOptionsResult from CloudSearch.</returns>
        public  DescribeStopwordOptionsResponse EndDescribeStopwordOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStopwordOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSynonymOptions

        /// <summary>
        /// Gets the synonym dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public DescribeSynonymOptionsResponse DescribeSynonymOptions(DescribeSynonymOptionsRequest request)
        {
            var marshaller = new DescribeSynonymOptionsRequestMarshaller();
            var unmarshaller = DescribeSynonymOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSynonymOptionsRequest,DescribeSynonymOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSynonymOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSynonymOptions(DescribeSynonymOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSynonymOptionsRequestMarshaller();
            var unmarshaller = DescribeSynonymOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSynonymOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSynonymOptions.</param>
        /// 
        /// <returns>Returns a  DescribeSynonymOptionsResult from CloudSearch.</returns>
        public  DescribeSynonymOptionsResponse EndDescribeSynonymOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSynonymOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  IndexDocuments

        /// <summary>
        /// Tells the search domain to start indexing its documents using the latest text processing
        /// options and <code>IndexFields</code>. This operation must be invoked to make options
        /// whose <a>OptionStatus</a> has <code>OptionState</code> of <code>RequiresIndexDocuments</code>
        /// visible in search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request)
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return Invoke<IndexDocumentsRequest,IndexDocumentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        public IAsyncResult BeginIndexDocuments(IndexDocumentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke<IndexDocumentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a  IndexDocumentsResult from CloudSearch.</returns>
        public  IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<IndexDocumentsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAvailabilityOptions

        /// <summary>
        /// Configures the availability options for a domain. Enabling the Multi-AZ option expands
        /// an Amazon CloudSearch domain to an additional Availability Zone in the same Region
        /// to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ
        /// option can take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request)
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityOptionsRequest,UpdateAvailabilityOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityOptions
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAvailabilityOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityOptionsResult from CloudSearch.</returns>
        public  UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAvailabilityOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDefaultSearchField

        /// <summary>
        /// Configures the default search field for the search domain. The default search field
        /// is the text field that is searched when a search request does not specify which fields
        /// to search. By default, it is configured to include the contents of all of the domain's
        /// text fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateDefaultSearchFieldResponse UpdateDefaultSearchField(UpdateDefaultSearchFieldRequest request)
        {
            var marshaller = new UpdateDefaultSearchFieldRequestMarshaller();
            var unmarshaller = UpdateDefaultSearchFieldResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultSearchFieldRequest,UpdateDefaultSearchFieldResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultSearchField
        ///         operation.</returns>
        public IAsyncResult BeginUpdateDefaultSearchField(UpdateDefaultSearchFieldRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDefaultSearchFieldRequestMarshaller();
            var unmarshaller = UpdateDefaultSearchFieldResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDefaultSearchFieldRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultSearchField.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultSearchFieldResult from CloudSearch.</returns>
        public  UpdateDefaultSearchFieldResponse EndUpdateDefaultSearchField(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDefaultSearchFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceAccessPolicies

        /// <summary>
        /// Configures the policies that control access to the domain's document and search services.
        /// The maximum size of an access policy document is 100 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request)
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceAccessPoliciesRequest,UpdateServiceAccessPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceAccessPolicies
        ///         operation.</returns>
        public IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServiceAccessPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  UpdateServiceAccessPoliciesResult from CloudSearch.</returns>
        public  UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStemmingOptions

        /// <summary>
        /// Configures a stemming dictionary for the search domain. The stemming dictionary is
        /// used during indexing and when processing search requests. The maximum size of the
        /// stemming dictionary is 500 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateStemmingOptionsResponse UpdateStemmingOptions(UpdateStemmingOptionsRequest request)
        {
            var marshaller = new UpdateStemmingOptionsRequestMarshaller();
            var unmarshaller = UpdateStemmingOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateStemmingOptionsRequest,UpdateStemmingOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStemmingOptions
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStemmingOptions(UpdateStemmingOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateStemmingOptionsRequestMarshaller();
            var unmarshaller = UpdateStemmingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStemmingOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStemmingOptions.</param>
        /// 
        /// <returns>Returns a  UpdateStemmingOptionsResult from CloudSearch.</returns>
        public  UpdateStemmingOptionsResponse EndUpdateStemmingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStemmingOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStopwordOptions

        /// <summary>
        /// Configures stopwords for the search domain. Stopwords are used during indexing and
        /// when processing search requests. The maximum size of the stopwords dictionary is 10
        /// KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateStopwordOptionsResponse UpdateStopwordOptions(UpdateStopwordOptionsRequest request)
        {
            var marshaller = new UpdateStopwordOptionsRequestMarshaller();
            var unmarshaller = UpdateStopwordOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateStopwordOptionsRequest,UpdateStopwordOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStopwordOptions
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStopwordOptions(UpdateStopwordOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateStopwordOptionsRequestMarshaller();
            var unmarshaller = UpdateStopwordOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStopwordOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStopwordOptions.</param>
        /// 
        /// <returns>Returns a  UpdateStopwordOptionsResult from CloudSearch.</returns>
        public  UpdateStopwordOptionsResponse EndUpdateStopwordOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStopwordOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSynonymOptions

        /// <summary>
        /// Configures a synonym dictionary for the search domain. The synonym dictionary is used
        /// during indexing to configure mappings for terms that occur in text fields. The maximum
        /// size of the synonym dictionary is 100 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        public UpdateSynonymOptionsResponse UpdateSynonymOptions(UpdateSynonymOptionsRequest request)
        {
            var marshaller = new UpdateSynonymOptionsRequestMarshaller();
            var unmarshaller = UpdateSynonymOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateSynonymOptionsRequest,UpdateSynonymOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSynonymOptions
        ///         operation.</returns>
        public IAsyncResult BeginUpdateSynonymOptions(UpdateSynonymOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSynonymOptionsRequestMarshaller();
            var unmarshaller = UpdateSynonymOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSynonymOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch_2011_02_01.IAmazonCloudSearch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSynonymOptions.</param>
        /// 
        /// <returns>Returns a  UpdateSynonymOptionsResult from CloudSearch.</returns>
        public  UpdateSynonymOptionsResponse EndUpdateSynonymOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSynonymOptionsResponse>(asyncResult);
        }

        #endregion
        
    }
}