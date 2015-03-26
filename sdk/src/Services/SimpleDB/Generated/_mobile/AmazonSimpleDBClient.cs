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

using Amazon.SimpleDB.Model;
using Amazon.SimpleDB.Model.Internal.MarshallTransformations;
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
        
        #region Constructors

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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new QueryStringSigner();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BatchDeleteAttributes

        internal BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request)
        {
            var marshaller = new BatchDeleteAttributesRequestMarshaller();
            var unmarshaller = BatchDeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteAttributesRequest,BatchDeleteAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchDeleteAttributesResponse> BatchDeleteAttributesAsync(BatchDeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteAttributesRequestMarshaller();
            var unmarshaller = BatchDeleteAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteAttributesRequest,BatchDeleteAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchPutAttributes

        internal BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request)
        {
            var marshaller = new BatchPutAttributesRequestMarshaller();
            var unmarshaller = BatchPutAttributesResponseUnmarshaller.Instance;

            return Invoke<BatchPutAttributesRequest,BatchPutAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchPutAttributesResponse> BatchPutAttributesAsync(BatchPutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchPutAttributesRequestMarshaller();
            var unmarshaller = BatchPutAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutAttributesRequest,BatchPutAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainRequest,CreateDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainRequest,CreateDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAttributes

        internal DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var marshaller = new DeleteAttributesRequestMarshaller();
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributesRequest,DeleteAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAttributesRequestMarshaller();
            var unmarshaller = DeleteAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAttributesRequest,DeleteAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DomainMetadata

        internal DomainMetadataResponse DomainMetadata(DomainMetadataRequest request)
        {
            var marshaller = new DomainMetadataRequestMarshaller();
            var unmarshaller = DomainMetadataResponseUnmarshaller.Instance;

            return Invoke<DomainMetadataRequest,DomainMetadataResponse>(request, marshaller, unmarshaller);
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
        public Task<DomainMetadataResponse> DomainMetadataAsync(DomainMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DomainMetadataRequestMarshaller();
            var unmarshaller = DomainMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DomainMetadataRequest,DomainMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAttributes

        internal GetAttributesResponse GetAttributes(GetAttributesRequest request)
        {
            var marshaller = new GetAttributesRequestMarshaller();
            var unmarshaller = GetAttributesResponseUnmarshaller.Instance;

            return Invoke<GetAttributesRequest,GetAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<GetAttributesResponse> GetAttributesAsync(GetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAttributesRequestMarshaller();
            var unmarshaller = GetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetAttributesRequest,GetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }
        internal ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsRequest,ListDomainsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsRequest,ListDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAttributes

        internal PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var marshaller = new PutAttributesRequestMarshaller();
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return Invoke<PutAttributesRequest,PutAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutAttributesRequestMarshaller();
            var unmarshaller = PutAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutAttributesRequest,PutAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Select

        internal SelectResponse Select(SelectRequest request)
        {
            var marshaller = new SelectRequestMarshaller();
            var unmarshaller = SelectResponseUnmarshaller.Instance;

            return Invoke<SelectRequest,SelectResponse>(request, marshaller, unmarshaller);
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
        public Task<SelectResponse> SelectAsync(SelectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SelectRequestMarshaller();
            var unmarshaller = SelectResponseUnmarshaller.Instance;

            return InvokeAsync<SelectRequest,SelectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}