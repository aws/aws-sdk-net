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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Athena.Model;
using Amazon.Athena.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Athena
{
    /// <summary>
    /// Implementation for accessing Athena
    ///
    /// Amazon Athena is an interactive query service that lets you use standard SQL to analyze
    /// data directly in Amazon S3. You can point Athena at your data in Amazon S3 and run
    /// ad-hoc queries and get results in seconds. Athena is serverless, so there is no infrastructure
    /// to set up or manage. You pay only for the queries you run. Athena scales automatically—executing
    /// queries in parallel—so results are fast, even with large datasets and complex queries.
    /// For more information, see <a href="http://docs.aws.amazon.com/athena/latest/ug/what-is.html">What
    /// is Amazon Athena</a> in the <i>Amazon Athena User Guide</i>.
    /// 
    ///  
    /// <para>
    /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAthenaClient : AmazonServiceClient, IAmazonAthena
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        public AmazonAthenaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAthenaConfig()) { }

        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        public AmazonAthenaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAthenaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(AmazonAthenaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAthenaClient(AWSCredentials credentials)
            : this(credentials, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAthenaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials and an
        /// AmazonAthenaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(AWSCredentials credentials, AmazonAthenaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAthenaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAthenaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAthenaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAthenaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAthenaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAthenaConfig clientConfig)
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

        
        #region  BatchGetNamedQuery

        internal virtual BatchGetNamedQueryResponse BatchGetNamedQuery(BatchGetNamedQueryRequest request)
        {
            var marshaller = BatchGetNamedQueryRequestMarshaller.Instance;
            var unmarshaller = BatchGetNamedQueryResponseUnmarshaller.Instance;

            return Invoke<BatchGetNamedQueryRequest,BatchGetNamedQueryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetNamedQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        public virtual Task<BatchGetNamedQueryResponse> BatchGetNamedQueryAsync(BatchGetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetNamedQueryRequestMarshaller.Instance;
            var unmarshaller = BatchGetNamedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetNamedQueryRequest,BatchGetNamedQueryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetQueryExecution

        internal virtual BatchGetQueryExecutionResponse BatchGetQueryExecution(BatchGetQueryExecutionRequest request)
        {
            var marshaller = BatchGetQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = BatchGetQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<BatchGetQueryExecutionRequest,BatchGetQueryExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetQueryExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        public virtual Task<BatchGetQueryExecutionResponse> BatchGetQueryExecutionAsync(BatchGetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = BatchGetQueryExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetQueryExecutionRequest,BatchGetQueryExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNamedQuery

        internal virtual CreateNamedQueryResponse CreateNamedQuery(CreateNamedQueryRequest request)
        {
            var marshaller = CreateNamedQueryRequestMarshaller.Instance;
            var unmarshaller = CreateNamedQueryResponseUnmarshaller.Instance;

            return Invoke<CreateNamedQueryRequest,CreateNamedQueryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamedQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        public virtual Task<CreateNamedQueryResponse> CreateNamedQueryAsync(CreateNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNamedQueryRequestMarshaller.Instance;
            var unmarshaller = CreateNamedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNamedQueryRequest,CreateNamedQueryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNamedQuery

        internal virtual DeleteNamedQueryResponse DeleteNamedQuery(DeleteNamedQueryRequest request)
        {
            var marshaller = DeleteNamedQueryRequestMarshaller.Instance;
            var unmarshaller = DeleteNamedQueryResponseUnmarshaller.Instance;

            return Invoke<DeleteNamedQueryRequest,DeleteNamedQueryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamedQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        public virtual Task<DeleteNamedQueryResponse> DeleteNamedQueryAsync(DeleteNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNamedQueryRequestMarshaller.Instance;
            var unmarshaller = DeleteNamedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamedQueryRequest,DeleteNamedQueryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetNamedQuery

        internal virtual GetNamedQueryResponse GetNamedQuery(GetNamedQueryRequest request)
        {
            var marshaller = GetNamedQueryRequestMarshaller.Instance;
            var unmarshaller = GetNamedQueryResponseUnmarshaller.Instance;

            return Invoke<GetNamedQueryRequest,GetNamedQueryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamedQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        public virtual Task<GetNamedQueryResponse> GetNamedQueryAsync(GetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetNamedQueryRequestMarshaller.Instance;
            var unmarshaller = GetNamedQueryResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamedQueryRequest,GetNamedQueryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQueryExecution

        internal virtual GetQueryExecutionResponse GetQueryExecution(GetQueryExecutionRequest request)
        {
            var marshaller = GetQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = GetQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<GetQueryExecutionRequest,GetQueryExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        public virtual Task<GetQueryExecutionResponse> GetQueryExecutionAsync(GetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = GetQueryExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryExecutionRequest,GetQueryExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQueryResults

        internal virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var marshaller = GetQueryResultsRequestMarshaller.Instance;
            var unmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsRequest,GetQueryResultsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetQueryResultsRequestMarshaller.Instance;
            var unmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsRequest,GetQueryResultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListNamedQueries

        internal virtual ListNamedQueriesResponse ListNamedQueries(ListNamedQueriesRequest request)
        {
            var marshaller = ListNamedQueriesRequestMarshaller.Instance;
            var unmarshaller = ListNamedQueriesResponseUnmarshaller.Instance;

            return Invoke<ListNamedQueriesRequest,ListNamedQueriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListNamedQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamedQueries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        public virtual Task<ListNamedQueriesResponse> ListNamedQueriesAsync(ListNamedQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListNamedQueriesRequestMarshaller.Instance;
            var unmarshaller = ListNamedQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamedQueriesRequest,ListNamedQueriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListQueryExecutions

        internal virtual ListQueryExecutionsResponse ListQueryExecutions(ListQueryExecutionsRequest request)
        {
            var marshaller = ListQueryExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListQueryExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListQueryExecutionsRequest,ListQueryExecutionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListQueryExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueryExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        public virtual Task<ListQueryExecutionsResponse> ListQueryExecutionsAsync(ListQueryExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListQueryExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListQueryExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueryExecutionsRequest,ListQueryExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartQueryExecution

        internal virtual StartQueryExecutionResponse StartQueryExecution(StartQueryExecutionRequest request)
        {
            var marshaller = StartQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = StartQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<StartQueryExecutionRequest,StartQueryExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        public virtual Task<StartQueryExecutionResponse> StartQueryExecutionAsync(StartQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = StartQueryExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryExecutionRequest,StartQueryExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopQueryExecution

        internal virtual StopQueryExecutionResponse StopQueryExecution(StopQueryExecutionRequest request)
        {
            var marshaller = StopQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = StopQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<StopQueryExecutionRequest,StopQueryExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQueryExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        public virtual Task<StopQueryExecutionResponse> StopQueryExecutionAsync(StopQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopQueryExecutionRequestMarshaller.Instance;
            var unmarshaller = StopQueryExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryExecutionRequest,StopQueryExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}