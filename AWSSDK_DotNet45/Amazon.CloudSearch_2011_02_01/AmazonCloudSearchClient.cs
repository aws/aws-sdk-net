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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="LimitExceededException">
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainRequest,CreateDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineIndexFieldRequestMarshaller();
            var unmarshaller = DefineIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DefineIndexFieldRequest,DefineIndexFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DefineRankExpressionResponse> DefineRankExpressionAsync(DefineRankExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DefineRankExpressionRequestMarshaller();
            var unmarshaller = DefineRankExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DefineRankExpressionRequest,DefineRankExpressionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Permanently deletes a search domain and all of its data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIndexField

        /// <summary>
        /// Removes an <code>IndexField</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIndexFieldRequestMarshaller();
            var unmarshaller = DeleteIndexFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexFieldRequest,DeleteIndexFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRankExpression

        /// <summary>
        /// Removes a <code>RankExpression</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression service method.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRankExpressionResponse> DeleteRankExpressionAsync(DeleteRankExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRankExpressionRequestMarshaller();
            var unmarshaller = DeleteRankExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRankExpressionRequest,DeleteRankExpressionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityOptionsRequestMarshaller();
            var unmarshaller = DescribeAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityOptionsRequest,DescribeAvailabilityOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultSearchField

        /// <summary>
        /// Gets the default search field configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDefaultSearchFieldResponse> DescribeDefaultSearchFieldAsync(DescribeDefaultSearchFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDefaultSearchFieldRequestMarshaller();
            var unmarshaller = DescribeDefaultSearchFieldResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultSearchFieldRequest,DescribeDefaultSearchFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomains

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDomainsRequestMarshaller();
            var unmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainsRequest,DescribeDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeIndexFieldsRequestMarshaller();
            var unmarshaller = DescribeIndexFieldsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIndexFieldsRequest,DescribeIndexFieldsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRankExpressionsResponse> DescribeRankExpressionsAsync(DescribeRankExpressionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRankExpressionsRequestMarshaller();
            var unmarshaller = DescribeRankExpressionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRankExpressionsRequest,DescribeRankExpressionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = DescribeServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceAccessPoliciesRequest,DescribeServiceAccessPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStemmingOptions

        /// <summary>
        /// Gets the stemming dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStemmingOptionsResponse> DescribeStemmingOptionsAsync(DescribeStemmingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStemmingOptionsRequestMarshaller();
            var unmarshaller = DescribeStemmingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStemmingOptionsRequest,DescribeStemmingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStopwordOptions

        /// <summary>
        /// Gets the stopwords configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStopwordOptionsResponse> DescribeStopwordOptionsAsync(DescribeStopwordOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStopwordOptionsRequestMarshaller();
            var unmarshaller = DescribeStopwordOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStopwordOptionsRequest,DescribeStopwordOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSynonymOptions

        /// <summary>
        /// Gets the synonym dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSynonymOptionsResponse> DescribeSynonymOptionsAsync(DescribeSynonymOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSynonymOptionsRequestMarshaller();
            var unmarshaller = DescribeSynonymOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSynonymOptionsRequest,DescribeSynonymOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new IndexDocumentsRequestMarshaller();
            var unmarshaller = IndexDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<IndexDocumentsRequest,IndexDocumentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAvailabilityOptionsRequestMarshaller();
            var unmarshaller = UpdateAvailabilityOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAvailabilityOptionsRequest,UpdateAvailabilityOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDefaultSearchFieldResponse> UpdateDefaultSearchFieldAsync(UpdateDefaultSearchFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDefaultSearchFieldRequestMarshaller();
            var unmarshaller = UpdateDefaultSearchFieldResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDefaultSearchFieldRequest,UpdateDefaultSearchFieldResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServiceAccessPoliciesRequestMarshaller();
            var unmarshaller = UpdateServiceAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceAccessPoliciesRequest,UpdateServiceAccessPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStemmingOptionsResponse> UpdateStemmingOptionsAsync(UpdateStemmingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStemmingOptionsRequestMarshaller();
            var unmarshaller = UpdateStemmingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStemmingOptionsRequest,UpdateStemmingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStopwordOptionsResponse> UpdateStopwordOptionsAsync(UpdateStopwordOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStopwordOptionsRequestMarshaller();
            var unmarshaller = UpdateStopwordOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStopwordOptionsRequest,UpdateStopwordOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateSynonymOptionsResponse> UpdateSynonymOptionsAsync(UpdateSynonymOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSynonymOptionsRequestMarshaller();
            var unmarshaller = UpdateSynonymOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSynonymOptionsRequest,UpdateSynonymOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}