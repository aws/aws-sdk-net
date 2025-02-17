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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockDataAutomation.Model;
using Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations;
using Amazon.BedrockDataAutomation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomation
{
    /// <summary>
    /// <para>Implementation for accessing BedrockDataAutomation</para>
    ///
    /// Amazon Bedrock Data Automation BuildTime
    /// </summary>
    public partial class AmazonBedrockDataAutomationClient : AmazonServiceClient, IAmazonBedrockDataAutomation
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockDataAutomationMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockDataAutomationConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockDataAutomationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(AmazonBedrockDataAutomationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockDataAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Credentials and an
        /// AmazonBedrockDataAutomationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(AWSCredentials credentials, AmazonBedrockDataAutomationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockDataAutomationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationClient Configuration Object</param>
        public AmazonBedrockDataAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockDataAutomationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBedrockDataAutomationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockDataAutomationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockDataAutomationPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationEndpointResolver());
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


        #region  CreateBlueprint

        internal virtual CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return Invoke<CreateBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual Task<CreateBlueprintResponse> CreateBlueprintAsync(CreateBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBlueprintVersion

        internal virtual CreateBlueprintVersionResponse CreateBlueprintVersion(CreateBlueprintVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintVersionResponseUnmarshaller.Instance;

            return Invoke<CreateBlueprintVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBlueprintVersion service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        public virtual Task<CreateBlueprintVersionResponse> CreateBlueprintVersionAsync(CreateBlueprintVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBlueprintVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataAutomationProject

        internal virtual CreateDataAutomationProjectResponse CreateDataAutomationProject(CreateDataAutomationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<CreateDataAutomationProjectResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        public virtual Task<CreateDataAutomationProjectResponse> CreateDataAutomationProjectAsync(CreateDataAutomationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAutomationProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBlueprint

        internal virtual DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return Invoke<DeleteBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual Task<DeleteBlueprintResponse> DeleteBlueprintAsync(DeleteBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataAutomationProject

        internal virtual DeleteDataAutomationProjectResponse DeleteDataAutomationProject(DeleteDataAutomationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteDataAutomationProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        public virtual Task<DeleteDataAutomationProjectResponse> DeleteDataAutomationProjectAsync(DeleteDataAutomationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAutomationProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlueprint

        internal virtual GetBlueprintResponse GetBlueprint(GetBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual Task<GetBlueprintResponse> GetBlueprintAsync(GetBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataAutomationProject

        internal virtual GetDataAutomationProjectResponse GetDataAutomationProject(GetDataAutomationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<GetDataAutomationProjectResponse>(request, options);
        }



        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        public virtual Task<GetDataAutomationProjectResponse> GetDataAutomationProjectAsync(GetDataAutomationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationProjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBlueprints

        internal virtual ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListBlueprintsResponse>(request, options);
        }



        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual Task<ListBlueprintsResponse> ListBlueprintsAsync(ListBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBlueprintsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataAutomationProjects

        internal virtual ListDataAutomationProjectsResponse ListDataAutomationProjects(ListDataAutomationProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataAutomationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAutomationProjectsResponseUnmarshaller.Instance;

            return Invoke<ListDataAutomationProjectsResponse>(request, options);
        }



        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataAutomationProjects service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        public virtual Task<ListDataAutomationProjectsResponse> ListDataAutomationProjectsAsync(ListDataAutomationProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataAutomationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAutomationProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataAutomationProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBlueprint

        internal virtual UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return Invoke<UpdateBlueprintResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual Task<UpdateBlueprintResponse> UpdateBlueprintAsync(UpdateBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataAutomationProject

        internal virtual UpdateDataAutomationProjectResponse UpdateDataAutomationProject(UpdateDataAutomationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAutomationProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateDataAutomationProjectResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        public virtual Task<UpdateDataAutomationProjectResponse> UpdateDataAutomationProjectAsync(UpdateDataAutomationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataAutomationProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataAutomationProjectResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonBedrockDataAutomationEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}