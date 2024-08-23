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
        
        #region  SendDataIntegrationEvent


        /// <summary>
        /// Send the transactional data payload for the event with real-time data for analysis
        /// or monitoring. The real-time data events are stored in an Amazon Web Services service
        /// before being processed and stored in data lake. New data events are synced with data
        /// lake at 5 PM GMT everyday. The updated transactional data is available in data lake
        /// after ingestion.
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