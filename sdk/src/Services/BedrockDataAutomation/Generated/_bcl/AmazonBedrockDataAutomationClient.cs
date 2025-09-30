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
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonBedrockDataAutomationConfig()) { }

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
            : base(new AmazonBedrockDataAutomationConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationAuthSchemeHandler());
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


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
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
        public virtual CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBlueprintVersion


        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
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
        public virtual CreateBlueprintVersionResponse CreateBlueprintVersion(CreateBlueprintVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueprintVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBlueprintVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataAutomationProject


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
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
        public virtual CreateDataAutomationProjectResponse CreateDataAutomationProject(CreateDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataAutomationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBlueprint


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
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
        public virtual DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataAutomationProject


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
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
        public virtual DeleteDataAutomationProjectResponse DeleteDataAutomationProject(DeleteDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataAutomationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlueprint


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
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
        public virtual GetBlueprintResponse GetBlueprint(GetBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataAutomationProject


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
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
        public virtual GetDataAutomationProjectResponse GetDataAutomationProject(GetDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataAutomationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataAutomationProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBlueprints


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
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
        public virtual ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBlueprintsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataAutomationProjects


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
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
        public virtual ListDataAutomationProjectsResponse ListDataAutomationProjects(ListDataAutomationProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataAutomationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataAutomationProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataAutomationProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBlueprint


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
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
        public virtual UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBlueprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataAutomationProject


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
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
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        public virtual UpdateDataAutomationProjectResponse UpdateDataAutomationProject(UpdateDataAutomationProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}