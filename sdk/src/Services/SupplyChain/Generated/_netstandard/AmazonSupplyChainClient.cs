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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SupplyChain.Model;
using Amazon.SupplyChain.Model.Internal.MarshallTransformations;
using Amazon.SupplyChain.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SupplyChain
{
    /// <summary>
    /// <para>Implementation for accessing SupplyChain</para>
    ///
    /// AWS Supply Chain is a cloud-based application that works with your enterprise resource
    /// planning (ERP) and supply chain management systems. Using AWS Supply Chain, you can
    /// connect and extract your inventory, supply, and demand related data from existing
    /// ERP or supply chain systems into a single data model. 
    /// 
    ///  
    /// <para>
    /// The AWS Supply Chain API supports configuration data import for Supply Planning.
    /// </para>
    ///  
    /// <para>
    ///  All AWS Supply chain API operations are Amazon-authenticated and certificate-signed.
    /// They not only require the use of the AWS SDK, but also allow for the exclusive use
    /// of AWS Identity and Access Management users and roles to help facilitate access, trust,
    /// and permission policies. 
    /// </para>
    /// </summary>
    public partial class AmazonSupplyChainClient : AmazonServiceClient, IAmazonSupplyChain
    {
        private static IServiceMetadata serviceMetadata = new AmazonSupplyChainMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSupplyChainClient with the credentials loaded from the application's
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
        public AmazonSupplyChainClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSupplyChainConfig()) { }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with the credentials loaded from the application's
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
        public AmazonSupplyChainClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSupplyChainConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSupplyChainClient Configuration Object</param>
        public AmazonSupplyChainClient(AmazonSupplyChainConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSupplyChainClient(AWSCredentials credentials)
            : this(credentials, new AmazonSupplyChainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupplyChainClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSupplyChainConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Credentials and an
        /// AmazonSupplyChainClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSupplyChainClient Configuration Object</param>
        public AmazonSupplyChainClient(AWSCredentials credentials, AmazonSupplyChainConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupplyChainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupplyChainConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupplyChainClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSupplyChainClient Configuration Object</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSupplyChainConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupplyChainConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupplyChainConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupplyChainClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupplyChainClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSupplyChainClient Configuration Object</param>
        public AmazonSupplyChainClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSupplyChainConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISupplyChainPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISupplyChainPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SupplyChainPaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSupplyChainEndpointResolver());
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


        #region  CreateBillOfMaterialsImportJob

        internal virtual CreateBillOfMaterialsImportJobResponse CreateBillOfMaterialsImportJob(CreateBillOfMaterialsImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateBillOfMaterialsImportJobResponse>(request, options);
        }



        /// <summary>
        /// CreateBillOfMaterialsImportJob creates an import job for the Product Bill Of Materials
        /// (BOM) entity. For information on the product_bom entity, see the AWS Supply Chain
        /// User Guide.
        /// 
        ///  
        /// <para>
        /// The CSV file must be located in an Amazon S3 location accessible to AWS Supply Chain.
        /// It is recommended to use the same Amazon S3 bucket created during your AWS Supply
        /// Chain instance creation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillOfMaterialsImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBillOfMaterialsImportJob service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        public virtual Task<CreateBillOfMaterialsImportJobResponse> CreateBillOfMaterialsImportJobAsync(CreateBillOfMaterialsImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBillOfMaterialsImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataIntegrationFlow

        internal virtual CreateDataIntegrationFlowResponse CreateDataIntegrationFlow(CreateDataIntegrationFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<CreateDataIntegrationFlowResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically create a data pipeline to ingest data from source
        /// systems such as Amazon S3 buckets, to a predefined Amazon Web Services Supply Chain
        /// dataset (product, inbound_order) or a temporary dataset along with the data transformation
        /// query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataIntegrationFlow service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        public virtual Task<CreateDataIntegrationFlowResponse> CreateDataIntegrationFlowAsync(CreateDataIntegrationFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationFlowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataIntegrationFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataLakeDataset

        internal virtual CreateDataLakeDatasetResponse CreateDataLakeDataset(CreateDataLakeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can create the datasets using their pre-defined or custom schema
        /// for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataLakeDataset service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        public virtual Task<CreateDataLakeDatasetResponse> CreateDataLakeDatasetAsync(CreateDataLakeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataLakeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstance

        internal virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain instance
        /// by applying KMS keys and relevant information associated with the API without using
        /// the Amazon Web Services console.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. Upon receiving a CreateInstance request, Amazon
        /// Web Services Supply Chain immediately returns the instance resource, instance ID,
        /// and the initializing state while simultaneously creating all required Amazon Web Services
        /// resources for an instance creation. You can use GetInstance to check the status of
        /// the instance. If the instance results in an unhealthy state, you need to check the
        /// error message, delete the current instance, and recreate a new one based on the mitigation
        /// from the error message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataIntegrationFlow

        internal virtual DeleteDataIntegrationFlowResponse DeleteDataIntegrationFlow(DeleteDataIntegrationFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteDataIntegrationFlowResponse>(request, options);
        }



        /// <summary>
        /// Enable you to programmatically delete an existing data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegrationFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataIntegrationFlow service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        public virtual Task<DeleteDataIntegrationFlowResponse> DeleteDataIntegrationFlowAsync(DeleteDataIntegrationFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataIntegrationFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataLakeDataset

        internal virtual DeleteDataLakeDatasetResponse DeleteDataLakeDataset(DeleteDataLakeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can delete the existing datasets for a given instance ID, namespace,
        /// and instance name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataLakeDataset service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        public virtual Task<DeleteDataLakeDatasetResponse> DeleteDataLakeDatasetAsync(DeleteDataLakeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataLakeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain instance
        /// by deleting the KMS keys and relevant information associated with the API without
        /// using the Amazon Web Services console.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. Upon receiving a DeleteInstance request, Amazon
        /// Web Services Supply Chain immediately returns a response with the instance resource,
        /// delete state while cleaning up all Amazon Web Services resources created during the
        /// instance creation process. You can use the GetInstance action to check the instance
        /// status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBillOfMaterialsImportJob

        internal virtual GetBillOfMaterialsImportJobResponse GetBillOfMaterialsImportJob(GetBillOfMaterialsImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return Invoke<GetBillOfMaterialsImportJobResponse>(request, options);
        }



        /// <summary>
        /// Get status and details of a BillOfMaterialsImportJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillOfMaterialsImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillOfMaterialsImportJob service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        public virtual Task<GetBillOfMaterialsImportJobResponse> GetBillOfMaterialsImportJobAsync(GetBillOfMaterialsImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetBillOfMaterialsImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataIntegrationFlow

        internal virtual GetDataIntegrationFlowResponse GetDataIntegrationFlow(GetDataIntegrationFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<GetDataIntegrationFlowResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically view a specific data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataIntegrationFlow service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        public virtual Task<GetDataIntegrationFlowResponse> GetDataIntegrationFlowAsync(GetDataIntegrationFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataIntegrationFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataLakeDataset

        internal virtual GetDataLakeDatasetResponse GetDataLakeDataset(GetDataLakeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can view the data lake dataset information such as namespace,
        /// schema, and so on for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataLakeDataset service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        public virtual Task<GetDataLakeDatasetResponse> GetDataLakeDatasetAsync(GetDataLakeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataLakeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstance

        internal virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically retrieve the information related to an Amazon Web
        /// Services Supply Chain instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataIntegrationFlows

        internal virtual ListDataIntegrationFlowsResponse ListDataIntegrationFlows(ListDataIntegrationFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationFlowsResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically list all data pipelines for the provided Amazon Web
        /// Services Supply Chain instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIntegrationFlows service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        public virtual Task<ListDataIntegrationFlowsResponse> ListDataIntegrationFlowsAsync(ListDataIntegrationFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataIntegrationFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataLakeDatasets

        internal virtual ListDataLakeDatasetsResponse ListDataLakeDatasets(ListDataLakeDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataLakeDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDataLakeDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically view the list of Amazon Web Services Supply Chain
        /// data lake datasets. Developers can view the datasets and the corresponding information
        /// such as namespace, schema, and so on for a given instance ID and namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataLakeDatasets service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        public virtual Task<ListDataLakeDatasetsResponse> ListDataLakeDatasetsAsync(ListDataLakeDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataLakeDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataLakeDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }



        /// <summary>
        /// List all Amazon Web Services Supply Chain instances for a specific account. Enables
        /// you to programmatically list all Amazon Web Services Supply Chain instances based
        /// on their account ID, instance name, and state of the instance (active or delete).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all the tags for an Amazon Web ServicesSupply Chain resource. You can list all
        /// the tags added to a resource. By listing the tags, developers can view the tag level
        /// information on a resource and perform actions such as, deleting a resource associated
        /// with a particular tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendDataIntegrationEvent

        internal virtual SendDataIntegrationEventResponse SendDataIntegrationEvent(SendDataIntegrationEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataIntegrationEventResponseUnmarshaller.Instance;

            return Invoke<SendDataIntegrationEventResponse>(request, options);
        }



        /// <summary>
        /// Send the transactional data payload for the event with real-time data for analysis
        /// or monitoring. The real-time data events are stored in an Amazon Web Services service
        /// before being processed and stored in data lake. New data events are synced with data
        /// lake at 5 PM GMT everyday. The updated transactional data is available in data lake
        /// after ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataIntegrationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDataIntegrationEvent service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        public virtual Task<SendDataIntegrationEventResponse> SendDataIntegrationEventAsync(SendDataIntegrationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataIntegrationEventResponseUnmarshaller.Instance;

            return InvokeAsync<SendDataIntegrationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// You can create tags during or after creating a resource such as instance, data flow,
        /// or dataset in AWS Supply chain. During the data ingestion process, you can add tags
        /// such as dev, test, or prod to data flows created during the data ingestion process
        /// in the AWS Supply Chain datasets. You can use these tags to identify a group of resources
        /// or a single resource used by the developer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// You can delete tags for an Amazon Web Services Supply chain resource such as instance,
        /// data flow, or dataset in AWS Supply Chain. During the data ingestion process, you
        /// can delete tags such as dev, test, or prod to data flows created during the data ingestion
        /// process in the AWS Supply Chain datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataIntegrationFlow

        internal virtual UpdateDataIntegrationFlowResponse UpdateDataIntegrationFlow(UpdateDataIntegrationFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateDataIntegrationFlowResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically update an existing data pipeline to ingest data from
        /// the source systems such as, Amazon S3 buckets, to a predefined Amazon Web Services
        /// Supply Chain dataset (product, inbound_order) or a temporary dataset along with the
        /// data transformation query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataIntegrationFlow service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        public virtual Task<UpdateDataIntegrationFlowResponse> UpdateDataIntegrationFlowAsync(UpdateDataIntegrationFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationFlowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataIntegrationFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataLakeDataset

        internal virtual UpdateDataLakeDatasetResponse UpdateDataLakeDataset(UpdateDataLakeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataLakeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can update the description of a data lake dataset for a given
        /// instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataLakeDataset service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        public virtual Task<UpdateDataLakeDatasetResponse> UpdateDataLakeDatasetAsync(UpdateDataLakeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataLakeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstance

        internal virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceResponse>(request, options);
        }



        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain instance
        /// description by providing all the relevant information such as account ID, instance
        /// ID and so on without using the AWS console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSupplyChainEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}