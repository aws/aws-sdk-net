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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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
        public virtual CreateBillOfMaterialsImportJobResponse CreateBillOfMaterialsImportJob(CreateBillOfMaterialsImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateBillOfMaterialsImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillOfMaterialsImportJob operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillOfMaterialsImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateBillOfMaterialsImportJob(CreateBillOfMaterialsImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillOfMaterialsImportJob.</param>
        /// 
        /// <returns>Returns a  CreateBillOfMaterialsImportJobResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        public virtual CreateBillOfMaterialsImportJobResponse EndCreateBillOfMaterialsImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBillOfMaterialsImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataIntegrationFlow

        /// <summary>
        /// Enables you to programmatically create a data pipeline to ingest data from source
        /// systems such as Amazon S3 buckets, to a predefined Amazon Web Services Supply Chain
        /// dataset (product, inbound_order) or a temporary dataset along with the data transformation
        /// query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationFlow service method.</param>
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
        public virtual CreateDataIntegrationFlowResponse CreateDataIntegrationFlow(CreateDataIntegrationFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<CreateDataIntegrationFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        public virtual IAsyncResult BeginCreateDataIntegrationFlow(CreateDataIntegrationFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  CreateDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        public virtual CreateDataIntegrationFlowResponse EndCreateDataIntegrationFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataIntegrationFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataLakeDataset

        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can create the datasets using their pre-defined or custom schema
        /// for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeDataset service method.</param>
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
        public virtual CreateDataLakeDatasetResponse CreateDataLakeDataset(CreateDataLakeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataLakeDataset(CreateDataLakeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        public virtual CreateDataLakeDatasetResponse EndCreateDataLakeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataLakeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataLakeNamespace

        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can create the namespaces for a given instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        public virtual CreateDataLakeNamespaceResponse CreateDataLakeNamespace(CreateDataLakeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateDataLakeNamespace(CreateDataLakeNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        public virtual CreateDataLakeNamespaceResponse EndCreateDataLakeNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataLakeNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstance

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
        public virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataIntegrationFlow

        /// <summary>
        /// Enable you to programmatically delete an existing data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegrationFlow service method.</param>
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
        public virtual DeleteDataIntegrationFlowResponse DeleteDataIntegrationFlow(DeleteDataIntegrationFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteDataIntegrationFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataIntegrationFlow(DeleteDataIntegrationFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  DeleteDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        public virtual DeleteDataIntegrationFlowResponse EndDeleteDataIntegrationFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataIntegrationFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataLakeDataset

        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can delete the existing datasets for a given instance ID, namespace,
        /// and instance name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeDataset service method.</param>
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
        public virtual DeleteDataLakeDatasetResponse DeleteDataLakeDataset(DeleteDataLakeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataLakeDataset(DeleteDataLakeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        public virtual DeleteDataLakeDatasetResponse EndDeleteDataLakeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataLakeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataLakeNamespace

        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
        /// namespace and its underling datasets. Developers can delete the existing namespaces
        /// for a given instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        public virtual DeleteDataLakeNamespaceResponse DeleteDataLakeNamespace(DeleteDataLakeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataLakeNamespace(DeleteDataLakeNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        public virtual DeleteDataLakeNamespaceResponse EndDeleteDataLakeNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataLakeNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstance

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
        public virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBillOfMaterialsImportJob

        /// <summary>
        /// Get status and details of a BillOfMaterialsImportJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillOfMaterialsImportJob service method.</param>
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
        public virtual GetBillOfMaterialsImportJobResponse GetBillOfMaterialsImportJob(GetBillOfMaterialsImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return Invoke<GetBillOfMaterialsImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillOfMaterialsImportJob operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillOfMaterialsImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetBillOfMaterialsImportJob(GetBillOfMaterialsImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillOfMaterialsImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillOfMaterialsImportJob.</param>
        /// 
        /// <returns>Returns a  GetBillOfMaterialsImportJobResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        public virtual GetBillOfMaterialsImportJobResponse EndGetBillOfMaterialsImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBillOfMaterialsImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataIntegrationEvent

        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain Data Integration
        /// Event. Developers can view the eventType, eventGroupId, eventTimestamp, datasetTarget,
        /// datasetLoadExecution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationEvent service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegrationEvent service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        public virtual GetDataIntegrationEventResponse GetDataIntegrationEvent(GetDataIntegrationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationEventResponseUnmarshaller.Instance;

            return Invoke<GetDataIntegrationEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationEvent operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        public virtual IAsyncResult BeginGetDataIntegrationEvent(GetDataIntegrationEventRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationEvent.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationEventResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        public virtual GetDataIntegrationEventResponse EndGetDataIntegrationEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataIntegrationEventResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataIntegrationFlow

        /// <summary>
        /// Enables you to programmatically view a specific data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlow service method.</param>
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
        public virtual GetDataIntegrationFlowResponse GetDataIntegrationFlow(GetDataIntegrationFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<GetDataIntegrationFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        public virtual IAsyncResult BeginGetDataIntegrationFlow(GetDataIntegrationFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        public virtual GetDataIntegrationFlowResponse EndGetDataIntegrationFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataIntegrationFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataIntegrationFlowExecution

        /// <summary>
        /// Get the flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlowExecution service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegrationFlowExecution service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        public virtual GetDataIntegrationFlowExecutionResponse GetDataIntegrationFlowExecution(GetDataIntegrationFlowExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowExecutionResponseUnmarshaller.Instance;

            return Invoke<GetDataIntegrationFlowExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationFlowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlowExecution operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationFlowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        public virtual IAsyncResult BeginGetDataIntegrationFlowExecution(GetDataIntegrationFlowExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationFlowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationFlowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationFlowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationFlowExecution.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationFlowExecutionResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        public virtual GetDataIntegrationFlowExecutionResponse EndGetDataIntegrationFlowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataIntegrationFlowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeDataset

        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can view the data lake dataset information such as namespace,
        /// schema, and so on for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeDataset service method.</param>
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
        public virtual GetDataLakeDatasetResponse GetDataLakeDataset(GetDataLakeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeDataset(GetDataLakeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  GetDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        public virtual GetDataLakeDatasetResponse EndGetDataLakeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeNamespace

        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can view the data lake namespace information such as description
        /// for a given instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        public virtual GetDataLakeNamespaceResponse GetDataLakeNamespace(GetDataLakeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeNamespace(GetDataLakeNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  GetDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        public virtual GetDataLakeNamespaceResponse EndGetDataLakeNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstance

        /// <summary>
        /// Enables you to programmatically retrieve the information related to an Amazon Web
        /// Services Supply Chain instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
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
        public virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual GetInstanceResponse EndGetInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataIntegrationEvents

        /// <summary>
        /// Enables you to programmatically list all data integration events for the provided
        /// Amazon Web Services Supply Chain instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationEvents service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationEvents service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        public virtual ListDataIntegrationEventsResponse ListDataIntegrationEvents(ListDataIntegrationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationEventsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationEvents operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        public virtual IAsyncResult BeginListDataIntegrationEvents(ListDataIntegrationEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationEvents.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationEventsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        public virtual ListDataIntegrationEventsResponse EndListDataIntegrationEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataIntegrationEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataIntegrationFlowExecutions

        /// <summary>
        /// List flow executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationFlowExecutions service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        public virtual ListDataIntegrationFlowExecutionsResponse ListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationFlowExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlowExecutions operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationFlowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        public virtual IAsyncResult BeginListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationFlowExecutions.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationFlowExecutionsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        public virtual ListDataIntegrationFlowExecutionsResponse EndListDataIntegrationFlowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataIntegrationFlowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataIntegrationFlows

        /// <summary>
        /// Enables you to programmatically list all data pipelines for the provided Amazon Web
        /// Services Supply Chain instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlows service method.</param>
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
        public virtual ListDataIntegrationFlowsResponse ListDataIntegrationFlows(ListDataIntegrationFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlows operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        public virtual IAsyncResult BeginListDataIntegrationFlows(ListDataIntegrationFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationFlows.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationFlowsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        public virtual ListDataIntegrationFlowsResponse EndListDataIntegrationFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataIntegrationFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataLakeDatasets

        /// <summary>
        /// Enables you to programmatically view the list of Amazon Web Services Supply Chain
        /// data lake datasets. Developers can view the datasets and the corresponding information
        /// such as namespace, schema, and so on for a given instance ID and namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeDatasets service method.</param>
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
        public virtual ListDataLakeDatasetsResponse ListDataLakeDatasets(ListDataLakeDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDataLakeDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakeDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeDatasets operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakeDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDataLakeDatasets(ListDataLakeDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakeDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakeDatasets.</param>
        /// 
        /// <returns>Returns a  ListDataLakeDatasetsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        public virtual ListDataLakeDatasetsResponse EndListDataLakeDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataLakeDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataLakeNamespaces

        /// <summary>
        /// Enables you to programmatically view the list of Amazon Web Services Supply Chain
        /// data lake namespaces. Developers can view the namespaces and the corresponding information
        /// such as description for a given instance ID. Note that this API only return custom
        /// namespaces, instance pre-defined namespaces are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListDataLakeNamespaces service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        public virtual ListDataLakeNamespacesResponse ListDataLakeNamespaces(ListDataLakeNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListDataLakeNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakeNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeNamespaces operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakeNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListDataLakeNamespaces(ListDataLakeNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakeNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakeNamespaces.</param>
        /// 
        /// <returns>Returns a  ListDataLakeNamespacesResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        public virtual ListDataLakeNamespacesResponse EndListDataLakeNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataLakeNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// List all Amazon Web Services Supply Chain instances for a specific account. Enables
        /// you to programmatically list all Amazon Web Services Supply Chain instances based
        /// on their account ID, instance name, and state of the instance (active or delete).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
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
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all the tags for an Amazon Web ServicesSupply Chain resource. You can list all
        /// the tags added to a resource. By listing the tags, developers can view the tag level
        /// information on a resource and perform actions such as, deleting a resource associated
        /// with a particular tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  SendDataIntegrationEvent

        /// <summary>
        /// Send the data payload for the event with real-time data for analysis or monitoring.
        /// The real-time data events are stored in an Amazon Web Services service before being
        /// processed and stored in data lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataIntegrationEvent service method.</param>
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
        public virtual SendDataIntegrationEventResponse SendDataIntegrationEvent(SendDataIntegrationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataIntegrationEventResponseUnmarshaller.Instance;

            return Invoke<SendDataIntegrationEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataIntegrationEvent operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataIntegrationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        public virtual IAsyncResult BeginSendDataIntegrationEvent(SendDataIntegrationEventRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendDataIntegrationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataIntegrationEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataIntegrationEvent.</param>
        /// 
        /// <returns>Returns a  SendDataIntegrationEventResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        public virtual SendDataIntegrationEventResponse EndSendDataIntegrationEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<SendDataIntegrationEventResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// You can create tags during or after creating a resource such as instance, data flow,
        /// or dataset in AWS Supply chain. During the data ingestion process, you can add tags
        /// such as dev, test, or prod to data flows created during the data ingestion process
        /// in the AWS Supply Chain datasets. You can use these tags to identify a group of resources
        /// or a single resource used by the developer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// You can delete tags for an Amazon Web Services Supply chain resource such as instance,
        /// data flow, or dataset in AWS Supply Chain. During the data ingestion process, you
        /// can delete tags such as dev, test, or prod to data flows created during the data ingestion
        /// process in the AWS Supply Chain datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataIntegrationFlow

        /// <summary>
        /// Enables you to programmatically update an existing data pipeline to ingest data from
        /// the source systems such as, Amazon S3 buckets, to a predefined Amazon Web Services
        /// Supply Chain dataset (product, inbound_order) or a temporary dataset along with the
        /// data transformation query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationFlow service method.</param>
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
        public virtual UpdateDataIntegrationFlowResponse UpdateDataIntegrationFlow(UpdateDataIntegrationFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateDataIntegrationFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataIntegrationFlow(UpdateDataIntegrationFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  UpdateDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        public virtual UpdateDataIntegrationFlowResponse EndUpdateDataIntegrationFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataIntegrationFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataLakeDataset

        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can update the description of a data lake dataset for a given
        /// instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeDataset service method.</param>
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
        public virtual UpdateDataLakeDatasetResponse UpdateDataLakeDataset(UpdateDataLakeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataLakeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataLakeDataset(UpdateDataLakeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        public virtual UpdateDataLakeDatasetResponse EndUpdateDataLakeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataLakeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataLakeNamespace

        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can update the description of a data lake namespace for a given
        /// instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        public virtual UpdateDataLakeNamespaceResponse UpdateDataLakeNamespace(UpdateDataLakeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataLakeNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataLakeNamespace(UpdateDataLakeNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        public virtual UpdateDataLakeNamespaceResponse EndUpdateDataLakeNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataLakeNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstance

        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain instance
        /// description by providing all the relevant information such as account ID, instance
        /// ID and so on without using the AWS console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
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
        public virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceResponse>(asyncResult);
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