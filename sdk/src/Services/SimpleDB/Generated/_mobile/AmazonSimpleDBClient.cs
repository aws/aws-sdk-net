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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleDB.Model;
using Amazon.SimpleDB.Model.Internal.MarshallTransformations;
using Amazon.SimpleDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleDB
{
    /// <summary>
    /// Implementation for accessing SimpleDB
    ///
    /// Amazon SimpleDB is a web service providing the core database functions of data indexing
    /// and querying in the cloud. By offloading the time and effort associated with building
    /// and operating a web-scale database, SimpleDB provides developers the freedom to focus
    /// on application development. 
    /// <para>
    ///  A traditional, clustered relational database requires a sizable upfront capital outlay,
    /// is complex to design, and often requires extensive and repetitive database administration.
    /// Amazon SimpleDB is dramatically simpler, requiring no schema, automatically indexing
    /// your data and providing a simple API for storage and access. This approach eliminates
    /// the administrative burden of data modeling, index maintenance, and performance tuning.
    /// Developers gain access to this functionality within Amazon's proven computing environment,
    /// are able to scale instantly, and pay only for what they use. 
    /// </para>
    ///  
    /// <para>
    ///  Visit <a href="http://aws.amazon.com/simpledb/">http://aws.amazon.com/simpledb/</a>
    /// for more information. 
    /// </para>
    /// </summary>
    public partial class AmazonSimpleDBClient : AmazonServiceClient, IAmazonSimpleDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleDBMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
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
        public AmazonSimpleDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
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
        public AmazonSimpleDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(AmazonSimpleDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials and an
        /// AmazonSimpleDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleDBConfig clientConfig)
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
            return new QueryStringSigner();
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


        #region  BatchDeleteAttributes

        internal virtual BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<BatchDeleteAttributesResponse> BatchDeleteAttributesAsync(BatchDeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutAttributes

        internal virtual BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAttributesResponseUnmarshaller.Instance;

            return Invoke<BatchPutAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<BatchPutAttributesResponse> BatchPutAttributesAsync(BatchPutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAttributes

        internal virtual DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DomainMetadata

        internal virtual DomainMetadataResponse DomainMetadata(DomainMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DomainMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DomainMetadataResponseUnmarshaller.Instance;

            return Invoke<DomainMetadataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DomainMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DomainMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DomainMetadataResponse> DomainMetadataAsync(DomainMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DomainMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DomainMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DomainMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAttributes

        internal virtual GetAttributesResponse GetAttributes(GetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributesResponseUnmarshaller.Instance;

            return Invoke<GetAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAttributesResponse> GetAttributesAsync(GetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }
        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// The <code>ListDomains</code> operation lists all domains associated with the Access
        /// Key ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <code>MaxNumberOfDomains</code>
        /// domains. Calling <code>ListDomains</code> successive times with the <code>NextToken</code>
        /// provided by the operation returns up to <code>MaxNumberOfDomains</code> more domain
        /// names with each successive operation call.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainsAsync(new ListDomainsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAttributes

        internal virtual PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Select

        internal virtual SelectResponse Select(SelectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectResponseUnmarshaller.Instance;

            return Invoke<SelectResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Select operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Select operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SelectResponse> SelectAsync(SelectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectResponseUnmarshaller.Instance;

            return InvokeAsync<SelectResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}