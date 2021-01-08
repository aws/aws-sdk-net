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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MarketplaceCatalog.Model;
using Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceCatalog.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MarketplaceCatalog
{
    /// <summary>
    /// Implementation for accessing MarketplaceCatalog
    ///
    /// Catalog API actions allow you to manage your entities through list, describe, and
    /// update capabilities. An entity can be a product or an offer on AWS Marketplace. 
    /// 
    ///  
    /// <para>
    /// You can automate your entity update process by integrating the AWS Marketplace Catalog
    /// API with your AWS Marketplace product build or deployment pipelines. You can also
    /// create your own applications on top of the Catalog API to manage your products on
    /// AWS Marketplace.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonMarketplaceCatalogClient : AmazonServiceClient, IAmazonMarketplaceCatalog
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceCatalogMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with the credentials loaded from the application's
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
        public AmazonMarketplaceCatalogClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceCatalogConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with the credentials loaded from the application's
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
        public AmazonMarketplaceCatalogClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceCatalogConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceCatalogClient Configuration Object</param>
        public AmazonMarketplaceCatalogClient(AmazonMarketplaceCatalogConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceCatalogClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceCatalogClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Credentials and an
        /// AmazonMarketplaceCatalogClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceCatalogClient Configuration Object</param>
        public AmazonMarketplaceCatalogClient(AWSCredentials credentials, AmazonMarketplaceCatalogConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceCatalogConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceCatalogClient Configuration Object</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceCatalogClient Configuration Object</param>
        public AmazonMarketplaceCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMarketplaceCatalogPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMarketplaceCatalogPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MarketplaceCatalogPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  CancelChangeSet

        internal virtual CancelChangeSetResponse CancelChangeSet(CancelChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelChangeSetResponseUnmarshaller.Instance;

            return Invoke<CancelChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Used to cancel an open change request. Must be sent before the status of the request
        /// changes to <code>APPLYING</code>, the final stage of completing your change request.
        /// You can describe a change during the 60-day request history retention period for API
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        public virtual Task<CancelChangeSetResponse> CancelChangeSetAsync(CancelChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CancelChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChangeSet

        internal virtual DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a given change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntity

        internal virtual DescribeEntityResponse DescribeEntity(DescribeEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityResponse>(request, options);
        }



        /// <summary>
        /// Returns the metadata and content of the entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntity service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotSupportedException">
        /// Currently, the specified resource is not supported.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        public virtual Task<DescribeEntityResponse> DescribeEntityAsync(DescribeEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangeSets

        internal virtual ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of change sets owned by the account being used to make the call.
        /// You can filter this list by providing any combination of <code>entityId</code>, <code>ChangeSetName</code>,
        /// and status. If you provide more than one filter, the API operation applies a logical
        /// AND between the filters.
        /// 
        ///  
        /// <para>
        /// You can describe a change during the 60-day request history retention period for API
        /// calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntities

        internal virtual ListEntitiesResponse ListEntities(ListEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Provides the list of entities of a given type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        public virtual Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartChangeSet

        internal virtual StartChangeSetResponse StartChangeSet(StartChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeSetResponseUnmarshaller.Instance;

            return Invoke<StartChangeSetResponse>(request, options);
        }



        /// <summary>
        /// This operation allows you to request changes for your entities. Within a single ChangeSet,
        /// you cannot start the same change type against the same entity multiple times. Additionally,
        /// when a ChangeSet is running, all the entities targeted by the different changes are
        /// locked until the ChangeSet has completed (either succeeded, cancelled, or failed).
        /// If you try to start a ChangeSet containing a change against an entity that is already
        /// locked, you will receive a <code>ResourceInUseException</code>.
        /// 
        ///  
        /// <para>
        /// For example, you cannot start the ChangeSet described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
        /// below because it contains two changes to execute the same change type (<code>AddRevisions</code>)
        /// against the same entity (<code>entity-id@1)</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ServiceQuotaExceededException">
        /// The maximum number of open requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        public virtual Task<StartChangeSetResponse> StartChangeSetAsync(StartChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<StartChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}