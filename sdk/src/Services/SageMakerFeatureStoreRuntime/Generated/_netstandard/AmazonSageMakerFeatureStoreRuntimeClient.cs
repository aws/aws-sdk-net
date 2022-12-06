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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerFeatureStoreRuntime.Model;
using Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations;
using Amazon.SageMakerFeatureStoreRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMakerFeatureStoreRuntime
{
    /// <summary>
    /// Implementation for accessing SageMakerFeatureStoreRuntime
    ///
    /// Contains all data plane API operations and data types for the Amazon SageMaker Feature
    /// Store. Use this API to put, delete, and retrieve (get) features from a feature store.
    /// 
    ///  
    /// <para>
    /// Use the following operations to configure your <code>OnlineStore</code> and <code>OfflineStore</code>
    /// features, and to create and manage feature groups:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateFeatureGroup.html">CreateFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteFeatureGroup.html">DeleteFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeFeatureGroup.html">DescribeFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListFeatureGroups.html">ListFeatureGroups</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSageMakerFeatureStoreRuntimeClient : AmazonServiceClient, IAmazonSageMakerFeatureStoreRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerFeatureStoreRuntimeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerFeatureStoreRuntimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerFeatureStoreRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerFeatureStoreRuntimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerFeatureStoreRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerFeatureStoreRuntimeClient Configuration Object</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(AmazonSageMakerFeatureStoreRuntimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerFeatureStoreRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerFeatureStoreRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Credentials and an
        /// AmazonSageMakerFeatureStoreRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerFeatureStoreRuntimeClient Configuration Object</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(AWSCredentials credentials, AmazonSageMakerFeatureStoreRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerFeatureStoreRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerFeatureStoreRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerFeatureStoreRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerFeatureStoreRuntimeClient Configuration Object</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerFeatureStoreRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerFeatureStoreRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerFeatureStoreRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerFeatureStoreRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerFeatureStoreRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerFeatureStoreRuntimeClient Configuration Object</param>
        public AmazonSageMakerFeatureStoreRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerFeatureStoreRuntimeConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerFeatureStoreRuntimeEndpointResolver());
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


        #region  BatchGetRecord

        internal virtual BatchGetRecordResponse BatchGetRecord(BatchGetRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRecordResponseUnmarshaller.Instance;

            return Invoke<BatchGetRecordResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a batch of <code>Records</code> from a <code>FeatureGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/BatchGetRecord">REST API Reference for BatchGetRecord Operation</seealso>
        public virtual Task<BatchGetRecordResponse> BatchGetRecordAsync(BatchGetRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRecordResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRecord

        internal virtual DeleteRecordResponse DeleteRecord(DeleteRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordResponseUnmarshaller.Instance;

            return Invoke<DeleteRecordResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <code>Record</code> from a <code>FeatureGroup</code>. When the <code>DeleteRecord</code>
        /// API is called a new record will be added to the <code>OfflineStore</code> and the
        /// <code>Record</code> will be removed from the <code>OnlineStore</code>. This record
        /// will have a value of <code>True</code> in the <code>is_deleted</code> column.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/DeleteRecord">REST API Reference for DeleteRecord Operation</seealso>
        public virtual Task<DeleteRecordResponse> DeleteRecordAsync(DeleteRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecord

        internal virtual GetRecordResponse GetRecord(GetRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordResponseUnmarshaller.Instance;

            return Invoke<GetRecordResponse>(request, options);
        }



        /// <summary>
        /// Use for <code>OnlineStore</code> serving from a <code>FeatureStore</code>. Only the
        /// latest records stored in the <code>OnlineStore</code> can be retrieved. If no Record
        /// with <code>RecordIdentifierValue</code> is found, then an empty result is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ResourceNotFoundException">
        /// A resource that is required to perform an action was not found.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/GetRecord">REST API Reference for GetRecord Operation</seealso>
        public virtual Task<GetRecordResponse> GetRecordAsync(GetRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecord

        internal virtual PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordResponse>(request, options);
        }



        /// <summary>
        /// Used for data ingestion into the <code>FeatureStore</code>. The <code>PutRecord</code>
        /// API writes to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
        /// the record is the latest record for the <code>recordIdentifier</code>, the record
        /// is written to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
        /// the record is a historic record, it is written only to the <code>OfflineStore</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return InvokeAsync<PutRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}