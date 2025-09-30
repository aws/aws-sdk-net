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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockAgentCore.Model;
using Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations;
using Amazon.BedrockAgentCore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentCore
{
    /// <summary>
    /// <para>Implementation for accessing BedrockAgentCore</para>
    ///
    /// <note> 
    /// <para>
    /// Amazon Bedrock AgentCore is in preview release and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon Bedrock AgentCore Data Plane API reference. Data Plane actions
    /// process and handle data or workloads within Amazon Web Services services. 
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonBedrockAgentCoreClient : AmazonServiceClient, IAmazonBedrockAgentCore
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockAgentCoreMetadata();
        private IBedrockAgentCorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockAgentCorePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockAgentCorePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentCoreClient()
            : base(new AmazonBedrockAgentCoreConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with the credentials loaded from the application's
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
        public AmazonBedrockAgentCoreClient(RegionEndpoint region)
            : base(new AmazonBedrockAgentCoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockAgentCoreClient Configuration Object</param>
        public AmazonBedrockAgentCoreClient(AmazonBedrockAgentCoreConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockAgentCoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockAgentCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockAgentCoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Credentials and an
        /// AmazonBedrockAgentCoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreClient Configuration Object</param>
        public AmazonBedrockAgentCoreClient(AWSCredentials credentials, AmazonBedrockAgentCoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockAgentCoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentCoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreClient Configuration Object</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockAgentCoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentCoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockAgentCoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockAgentCoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockAgentCoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockAgentCoreClient Configuration Object</param>
        public AmazonBedrockAgentCoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockAgentCoreConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentCoreEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAgentCoreAuthSchemeHandler());
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


        #region  CreateEvent


        /// <summary>
        /// Creates an event in an AgentCore Memory resource. Events represent interactions or
        /// activities that occur within a session and are associated with specific actors.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:CreateEvent</c> permission.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent service method.</param>
        /// 
        /// <returns>The response from the CreateEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        public virtual CreateEventResponse CreateEvent(CreateEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventResponseUnmarshaller.Instance;

            return Invoke<CreateEventResponse>(request, options);
        }


        /// <summary>
        /// Creates an event in an AgentCore Memory resource. Events represent interactions or
        /// activities that occur within a session and are associated with specific actors.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:CreateEvent</c> permission.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        public virtual Task<CreateEventResponse> CreateEventAsync(CreateEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEvent


        /// <summary>
        /// Deletes an event from an AgentCore Memory resource. When you delete an event, it is
        /// permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual DeleteEventResponse DeleteEvent(DeleteEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;

            return Invoke<DeleteEventResponse>(request, options);
        }


        /// <summary>
        /// Deletes an event from an AgentCore Memory resource. When you delete an event, it is
        /// permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMemoryRecord


        /// <summary>
        /// Deletes a memory record from an AgentCore Memory resource. When you delete a memory
        /// record, it is permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemoryRecord service method.</param>
        /// 
        /// <returns>The response from the DeleteMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteMemoryRecord">REST API Reference for DeleteMemoryRecord Operation</seealso>
        public virtual DeleteMemoryRecordResponse DeleteMemoryRecord(DeleteMemoryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemoryRecordResponseUnmarshaller.Instance;

            return Invoke<DeleteMemoryRecordResponse>(request, options);
        }


        /// <summary>
        /// Deletes a memory record from an AgentCore Memory resource. When you delete a memory
        /// record, it is permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemoryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteMemoryRecord">REST API Reference for DeleteMemoryRecord Operation</seealso>
        public virtual Task<DeleteMemoryRecordResponse> DeleteMemoryRecordAsync(DeleteMemoryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMemoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMemoryRecordResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMemoryRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBrowserSession


        /// <summary>
        /// Retrieves detailed information about a specific browser session in Amazon Bedrock.
        /// This operation returns the session's configuration, current status, associated streams,
        /// and metadata.
        /// 
        ///  
        /// <para>
        /// To get a browser session, you must specify both the browser identifier and the session
        /// ID. The response includes information about the session's viewport configuration,
        /// timeout settings, and stream endpoints.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListBrowserSessions.html">ListBrowserSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSession service method.</param>
        /// 
        /// <returns>The response from the GetBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetBrowserSession">REST API Reference for GetBrowserSession Operation</seealso>
        public virtual GetBrowserSessionResponse GetBrowserSession(GetBrowserSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSessionResponseUnmarshaller.Instance;

            return Invoke<GetBrowserSessionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific browser session in Amazon Bedrock.
        /// This operation returns the session's configuration, current status, associated streams,
        /// and metadata.
        /// 
        ///  
        /// <para>
        /// To get a browser session, you must specify both the browser identifier and the session
        /// ID. The response includes information about the session's viewport configuration,
        /// timeout settings, and stream endpoints.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListBrowserSessions.html">ListBrowserSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetBrowserSession">REST API Reference for GetBrowserSession Operation</seealso>
        public virtual Task<GetBrowserSessionResponse> GetBrowserSessionAsync(GetBrowserSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBrowserSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCodeInterpreterSession


        /// <summary>
        /// Retrieves detailed information about a specific code interpreter session in Amazon
        /// Bedrock. This operation returns the session's configuration, current status, and metadata.
        /// 
        ///  
        /// <para>
        /// To get a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. The response includes information about the session's timeout
        /// settings and current status.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListCodeInterpreterSessions.html">ListCodeInterpreterSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the GetCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetCodeInterpreterSession">REST API Reference for GetCodeInterpreterSession Operation</seealso>
        public virtual GetCodeInterpreterSessionResponse GetCodeInterpreterSession(GetCodeInterpreterSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeInterpreterSessionResponseUnmarshaller.Instance;

            return Invoke<GetCodeInterpreterSessionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific code interpreter session in Amazon
        /// Bedrock. This operation returns the session's configuration, current status, and metadata.
        /// 
        ///  
        /// <para>
        /// To get a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. The response includes information about the session's timeout
        /// settings and current status.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListCodeInterpreterSessions.html">ListCodeInterpreterSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreterSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetCodeInterpreterSession">REST API Reference for GetCodeInterpreterSession Operation</seealso>
        public virtual Task<GetCodeInterpreterSessionResponse> GetCodeInterpreterSessionAsync(GetCodeInterpreterSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeInterpreterSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCodeInterpreterSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvent


        /// <summary>
        /// Retrieves information about a specific event in an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// 
        /// <returns>The response from the GetEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetEvent">REST API Reference for GetEvent Operation</seealso>
        public virtual GetEventResponse GetEvent(GetEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventResponseUnmarshaller.Instance;

            return Invoke<GetEventResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a specific event in an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetEvent">REST API Reference for GetEvent Operation</seealso>
        public virtual Task<GetEventResponse> GetEventAsync(GetEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMemoryRecord


        /// <summary>
        /// Retrieves a specific memory record from an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemoryRecord service method.</param>
        /// 
        /// <returns>The response from the GetMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetMemoryRecord">REST API Reference for GetMemoryRecord Operation</seealso>
        public virtual GetMemoryRecordResponse GetMemoryRecord(GetMemoryRecordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemoryRecordResponseUnmarshaller.Instance;

            return Invoke<GetMemoryRecordResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a specific memory record from an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemoryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetMemoryRecord">REST API Reference for GetMemoryRecord Operation</seealso>
        public virtual Task<GetMemoryRecordResponse> GetMemoryRecordAsync(GetMemoryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemoryRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemoryRecordResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMemoryRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceApiKey


        /// <summary>
        /// Retrieves an API Key associated with an API Key Credential Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceApiKey service method.</param>
        /// 
        /// <returns>The response from the GetResourceApiKey service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceApiKey">REST API Reference for GetResourceApiKey Operation</seealso>
        public virtual GetResourceApiKeyResponse GetResourceApiKey(GetResourceApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceApiKeyResponseUnmarshaller.Instance;

            return Invoke<GetResourceApiKeyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an API Key associated with an API Key Credential Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceApiKey service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceApiKey">REST API Reference for GetResourceApiKey Operation</seealso>
        public virtual Task<GetResourceApiKeyResponse> GetResourceApiKeyAsync(GetResourceApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceApiKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourceApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceOauth2Token


        /// <summary>
        /// Returns the OAuth 2.0 token of the provided resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceOauth2Token service method.</param>
        /// 
        /// <returns>The response from the GetResourceOauth2Token service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceOauth2Token">REST API Reference for GetResourceOauth2Token Operation</seealso>
        public virtual GetResourceOauth2TokenResponse GetResourceOauth2Token(GetResourceOauth2TokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceOauth2TokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceOauth2TokenResponseUnmarshaller.Instance;

            return Invoke<GetResourceOauth2TokenResponse>(request, options);
        }


        /// <summary>
        /// Returns the OAuth 2.0 token of the provided resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceOauth2Token service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceOauth2Token service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceOauth2Token">REST API Reference for GetResourceOauth2Token Operation</seealso>
        public virtual Task<GetResourceOauth2TokenResponse> GetResourceOauth2TokenAsync(GetResourceOauth2TokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceOauth2TokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceOauth2TokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourceOauth2TokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkloadAccessToken


        /// <summary>
        /// Obtains an Workload access token for agentic workloads not acting on behalf of user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessToken service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessToken service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessToken">REST API Reference for GetWorkloadAccessToken Operation</seealso>
        public virtual GetWorkloadAccessTokenResponse GetWorkloadAccessToken(GetWorkloadAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadAccessTokenResponse>(request, options);
        }


        /// <summary>
        /// Obtains an Workload access token for agentic workloads not acting on behalf of user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadAccessToken service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessToken">REST API Reference for GetWorkloadAccessToken Operation</seealso>
        public virtual Task<GetWorkloadAccessTokenResponse> GetWorkloadAccessTokenAsync(GetWorkloadAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkloadAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkloadAccessTokenForJWT


        /// <summary>
        /// Obtains an Workload access token for agentic workloads acting on behalf of user with
        /// JWT token
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForJWT service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForJWT service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForJWT">REST API Reference for GetWorkloadAccessTokenForJWT Operation</seealso>
        public virtual GetWorkloadAccessTokenForJWTResponse GetWorkloadAccessTokenForJWT(GetWorkloadAccessTokenForJWTRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenForJWTRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenForJWTResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadAccessTokenForJWTResponse>(request, options);
        }


        /// <summary>
        /// Obtains an Workload access token for agentic workloads acting on behalf of user with
        /// JWT token
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForJWT service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForJWT service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForJWT">REST API Reference for GetWorkloadAccessTokenForJWT Operation</seealso>
        public virtual Task<GetWorkloadAccessTokenForJWTResponse> GetWorkloadAccessTokenForJWTAsync(GetWorkloadAccessTokenForJWTRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenForJWTRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenForJWTResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkloadAccessTokenForJWTResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkloadAccessTokenForUserId


        /// <summary>
        /// Obtains an Workload access token for agentic workloads acting on behalf of user with
        /// User Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForUserId service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForUserId service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForUserId">REST API Reference for GetWorkloadAccessTokenForUserId Operation</seealso>
        public virtual GetWorkloadAccessTokenForUserIdResponse GetWorkloadAccessTokenForUserId(GetWorkloadAccessTokenForUserIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenForUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenForUserIdResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadAccessTokenForUserIdResponse>(request, options);
        }


        /// <summary>
        /// Obtains an Workload access token for agentic workloads acting on behalf of user with
        /// User Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForUserId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForUserId service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForUserId">REST API Reference for GetWorkloadAccessTokenForUserId Operation</seealso>
        public virtual Task<GetWorkloadAccessTokenForUserIdResponse> GetWorkloadAccessTokenForUserIdAsync(GetWorkloadAccessTokenForUserIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadAccessTokenForUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadAccessTokenForUserIdResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkloadAccessTokenForUserIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeAgentRuntime


        /// <summary>
        /// Sends a request to an agent or tool hosted in an Amazon Bedrock AgentCore Runtime
        /// and receives responses in real-time. 
        /// 
        ///  
        /// <para>
        /// To invoke an agent you must specify the AgentCore Runtime ARN and provide a payload
        /// containing your request. You can optionally specify a qualifier to target a specific
        /// version or endpoint of the agent.
        /// </para>
        ///  
        /// <para>
        /// This operation supports streaming responses, allowing you to receive partial responses
        /// as they become available. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully when processing large responses.
        /// </para>
        ///  
        /// <para>
        /// For example code, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-invoke-agent.html">Invoke
        /// an AgentCore Runtime agent</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're integrating your agent with OAuth, you can't use the Amazon Web Services
        /// SDK to call <c>InvokeAgentRuntime</c>. Instead, make a HTTPS request to <c>InvokeAgentRuntime</c>.
        /// For an example, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-oauth.html">Authenticate
        /// and authorize with Inbound Auth and Outbound Auth</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntime</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the InvokeAgentRuntime service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.RuntimeClientErrorException">
        /// The exception that occurs when there is an error in the runtime client. This can happen
        /// due to network issues, invalid configuration, or other client-side problems. Check
        /// the error message for specific details about the error.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeAgentRuntime">REST API Reference for InvokeAgentRuntime Operation</seealso>
        public virtual InvokeAgentRuntimeResponse InvokeAgentRuntime(InvokeAgentRuntimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAgentRuntimeResponseUnmarshaller.Instance;

            return Invoke<InvokeAgentRuntimeResponse>(request, options);
        }


        /// <summary>
        /// Sends a request to an agent or tool hosted in an Amazon Bedrock AgentCore Runtime
        /// and receives responses in real-time. 
        /// 
        ///  
        /// <para>
        /// To invoke an agent you must specify the AgentCore Runtime ARN and provide a payload
        /// containing your request. You can optionally specify a qualifier to target a specific
        /// version or endpoint of the agent.
        /// </para>
        ///  
        /// <para>
        /// This operation supports streaming responses, allowing you to receive partial responses
        /// as they become available. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully when processing large responses.
        /// </para>
        ///  
        /// <para>
        /// For example code, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-invoke-agent.html">Invoke
        /// an AgentCore Runtime agent</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're integrating your agent with OAuth, you can't use the Amazon Web Services
        /// SDK to call <c>InvokeAgentRuntime</c>. Instead, make a HTTPS request to <c>InvokeAgentRuntime</c>.
        /// For an example, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-oauth.html">Authenticate
        /// and authorize with Inbound Auth and Outbound Auth</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntime</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgentRuntime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeAgentRuntime service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.RuntimeClientErrorException">
        /// The exception that occurs when there is an error in the runtime client. This can happen
        /// due to network issues, invalid configuration, or other client-side problems. Check
        /// the error message for specific details about the error.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeAgentRuntime">REST API Reference for InvokeAgentRuntime Operation</seealso>
        public virtual Task<InvokeAgentRuntimeResponse> InvokeAgentRuntimeAsync(InvokeAgentRuntimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeAgentRuntimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAgentRuntimeResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeAgentRuntimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeCodeInterpreter


        /// <summary>
        /// Executes code within an active code interpreter session in Amazon Bedrock. This operation
        /// processes the provided code, runs it in a secure environment, and returns the execution
        /// results including output, errors, and generated visualizations.
        /// 
        ///  
        /// <para>
        /// To execute code, you must specify the code interpreter identifier, session ID, and
        /// the code to run in the arguments parameter. The operation returns a stream containing
        /// the execution results, which can include text output, error messages, and data visualizations.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting based on your account's service
        /// quotas.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>InvokeCodeInterpreter</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the InvokeCodeInterpreter service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeCodeInterpreter">REST API Reference for InvokeCodeInterpreter Operation</seealso>
        public virtual InvokeCodeInterpreterResponse InvokeCodeInterpreter(InvokeCodeInterpreterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeCodeInterpreterResponseUnmarshaller.Instance;

            return Invoke<InvokeCodeInterpreterResponse>(request, options);
        }


        /// <summary>
        /// Executes code within an active code interpreter session in Amazon Bedrock. This operation
        /// processes the provided code, runs it in a secure environment, and returns the execution
        /// results including output, errors, and generated visualizations.
        /// 
        ///  
        /// <para>
        /// To execute code, you must specify the code interpreter identifier, session ID, and
        /// the code to run in the arguments parameter. The operation returns a stream containing
        /// the execution results, which can include text output, error messages, and data visualizations.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting based on your account's service
        /// quotas.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>InvokeCodeInterpreter</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeCodeInterpreter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeCodeInterpreter service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeCodeInterpreter">REST API Reference for InvokeCodeInterpreter Operation</seealso>
        public virtual Task<InvokeCodeInterpreterResponse> InvokeCodeInterpreterAsync(InvokeCodeInterpreterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeCodeInterpreterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeCodeInterpreterResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeCodeInterpreterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActors


        /// <summary>
        /// Lists all actors in an AgentCore Memory resource. We recommend using pagination to
        /// ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListActors</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActors service method.</param>
        /// 
        /// <returns>The response from the ListActors service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListActors">REST API Reference for ListActors Operation</seealso>
        public virtual ListActorsResponse ListActors(ListActorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActorsResponseUnmarshaller.Instance;

            return Invoke<ListActorsResponse>(request, options);
        }


        /// <summary>
        /// Lists all actors in an AgentCore Memory resource. We recommend using pagination to
        /// ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListActors</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActors service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListActors">REST API Reference for ListActors Operation</seealso>
        public virtual Task<ListActorsResponse> ListActorsAsync(ListActorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBrowserSessions


        /// <summary>
        /// Retrieves a list of browser sessions in Amazon Bedrock that match the specified criteria.
        /// This operation returns summary information about each session, including identifiers,
        /// status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by browser identifier and session status. The operation
        /// supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListBrowserSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSessions service method.</param>
        /// 
        /// <returns>The response from the ListBrowserSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListBrowserSessions">REST API Reference for ListBrowserSessions Operation</seealso>
        public virtual ListBrowserSessionsResponse ListBrowserSessions(ListBrowserSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowserSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSessionsResponseUnmarshaller.Instance;

            return Invoke<ListBrowserSessionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of browser sessions in Amazon Bedrock that match the specified criteria.
        /// This operation returns summary information about each session, including identifiers,
        /// status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by browser identifier and session status. The operation
        /// supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListBrowserSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrowserSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListBrowserSessions">REST API Reference for ListBrowserSessions Operation</seealso>
        public virtual Task<ListBrowserSessionsResponse> ListBrowserSessionsAsync(ListBrowserSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowserSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBrowserSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeInterpreterSessions


        /// <summary>
        /// Retrieves a list of code interpreter sessions in Amazon Bedrock that match the specified
        /// criteria. This operation returns summary information about each session, including
        /// identifiers, status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by code interpreter identifier and session status. The
        /// operation supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListCodeInterpreterSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreterSessions service method.</param>
        /// 
        /// <returns>The response from the ListCodeInterpreterSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListCodeInterpreterSessions">REST API Reference for ListCodeInterpreterSessions Operation</seealso>
        public virtual ListCodeInterpreterSessionsResponse ListCodeInterpreterSessions(ListCodeInterpreterSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeInterpreterSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeInterpreterSessionsResponseUnmarshaller.Instance;

            return Invoke<ListCodeInterpreterSessionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of code interpreter sessions in Amazon Bedrock that match the specified
        /// criteria. This operation returns summary information about each session, including
        /// identifiers, status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by code interpreter identifier and session status. The
        /// operation supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListCodeInterpreterSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreterSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeInterpreterSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListCodeInterpreterSessions">REST API Reference for ListCodeInterpreterSessions Operation</seealso>
        public virtual Task<ListCodeInterpreterSessionsResponse> ListCodeInterpreterSessionsAsync(ListCodeInterpreterSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeInterpreterSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeInterpreterSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCodeInterpreterSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEvents


        /// <summary>
        /// Lists events in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListEvents</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// 
        /// <returns>The response from the ListEvents service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListEvents">REST API Reference for ListEvents Operation</seealso>
        public virtual ListEventsResponse ListEvents(ListEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;

            return Invoke<ListEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists events in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListEvents</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEvents service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListEvents">REST API Reference for ListEvents Operation</seealso>
        public virtual Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMemoryRecords


        /// <summary>
        /// Lists memory records in an AgentCore Memory resource based on specified criteria.
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the ListMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListMemoryRecords">REST API Reference for ListMemoryRecords Operation</seealso>
        public virtual ListMemoryRecordsResponse ListMemoryRecords(ListMemoryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemoryRecordsResponseUnmarshaller.Instance;

            return Invoke<ListMemoryRecordsResponse>(request, options);
        }


        /// <summary>
        /// Lists memory records in an AgentCore Memory resource based on specified criteria.
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemoryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListMemoryRecords">REST API Reference for ListMemoryRecords Operation</seealso>
        public virtual Task<ListMemoryRecordsResponse> ListMemoryRecordsAsync(ListMemoryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemoryRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMemoryRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists sessions in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListSessions</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }


        /// <summary>
        /// Lists sessions in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListSessions</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveMemoryRecords


        /// <summary>
        /// Searches for and retrieves memory records from an AgentCore Memory resource based
        /// on specified search criteria. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:RetrieveMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the RetrieveMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/RetrieveMemoryRecords">REST API Reference for RetrieveMemoryRecords Operation</seealso>
        public virtual RetrieveMemoryRecordsResponse RetrieveMemoryRecords(RetrieveMemoryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveMemoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveMemoryRecordsResponseUnmarshaller.Instance;

            return Invoke<RetrieveMemoryRecordsResponse>(request, options);
        }


        /// <summary>
        /// Searches for and retrieves memory records from an AgentCore Memory resource based
        /// on specified search criteria. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:RetrieveMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveMemoryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/RetrieveMemoryRecords">REST API Reference for RetrieveMemoryRecords Operation</seealso>
        public virtual Task<RetrieveMemoryRecordsResponse> RetrieveMemoryRecordsAsync(RetrieveMemoryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveMemoryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveMemoryRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetrieveMemoryRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBrowserSession


        /// <summary>
        /// Creates and initializes a browser session in Amazon Bedrock. The session enables agents
        /// to navigate and interact with web content, extract information from websites, and
        /// perform web-based tasks as part of their response generation.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a browser identifier and a name. You can also
        /// configure the viewport dimensions to control the visible area of web content. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopBrowserSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_UpdateBrowserStream.html">UpdateBrowserStream</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBrowserSession service method.</param>
        /// 
        /// <returns>The response from the StartBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartBrowserSession">REST API Reference for StartBrowserSession Operation</seealso>
        public virtual StartBrowserSessionResponse StartBrowserSession(StartBrowserSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBrowserSessionResponseUnmarshaller.Instance;

            return Invoke<StartBrowserSessionResponse>(request, options);
        }


        /// <summary>
        /// Creates and initializes a browser session in Amazon Bedrock. The session enables agents
        /// to navigate and interact with web content, extract information from websites, and
        /// perform web-based tasks as part of their response generation.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a browser identifier and a name. You can also
        /// configure the viewport dimensions to control the visible area of web content. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopBrowserSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_UpdateBrowserStream.html">UpdateBrowserStream</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBrowserSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartBrowserSession">REST API Reference for StartBrowserSession Operation</seealso>
        public virtual Task<StartBrowserSessionResponse> StartBrowserSessionAsync(StartBrowserSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBrowserSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartBrowserSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCodeInterpreterSession


        /// <summary>
        /// Creates and initializes a code interpreter session in Amazon Bedrock. The session
        /// enables agents to execute code as part of their response generation, supporting programming
        /// languages such as Python for data analysis, visualization, and computation tasks.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a code interpreter identifier and a name. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopCodeInterpreterSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_InvokeCodeInterpreter.html">InvokeCodeInterpreter</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the StartCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartCodeInterpreterSession">REST API Reference for StartCodeInterpreterSession Operation</seealso>
        public virtual StartCodeInterpreterSessionResponse StartCodeInterpreterSession(StartCodeInterpreterSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeInterpreterSessionResponseUnmarshaller.Instance;

            return Invoke<StartCodeInterpreterSessionResponse>(request, options);
        }


        /// <summary>
        /// Creates and initializes a code interpreter session in Amazon Bedrock. The session
        /// enables agents to execute code as part of their response generation, supporting programming
        /// languages such as Python for data analysis, visualization, and computation tasks.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a code interpreter identifier and a name. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopCodeInterpreterSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_InvokeCodeInterpreter.html">InvokeCodeInterpreter</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeInterpreterSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartCodeInterpreterSession">REST API Reference for StartCodeInterpreterSession Operation</seealso>
        public virtual Task<StartCodeInterpreterSessionResponse> StartCodeInterpreterSessionAsync(StartCodeInterpreterSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeInterpreterSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCodeInterpreterSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopBrowserSession


        /// <summary>
        /// Terminates an active browser session in Amazon Bedrock. This operation stops the session,
        /// releases associated resources, and makes the session unavailable for further use.
        /// 
        ///  
        /// <para>
        /// To stop a browser session, you must specify both the browser identifier and the session
        /// ID. Once stopped, a session cannot be restarted; you must create a new session using
        /// <c>StartBrowserSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBrowserSession service method.</param>
        /// 
        /// <returns>The response from the StopBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopBrowserSession">REST API Reference for StopBrowserSession Operation</seealso>
        public virtual StopBrowserSessionResponse StopBrowserSession(StopBrowserSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBrowserSessionResponseUnmarshaller.Instance;

            return Invoke<StopBrowserSessionResponse>(request, options);
        }


        /// <summary>
        /// Terminates an active browser session in Amazon Bedrock. This operation stops the session,
        /// releases associated resources, and makes the session unavailable for further use.
        /// 
        ///  
        /// <para>
        /// To stop a browser session, you must specify both the browser identifier and the session
        /// ID. Once stopped, a session cannot be restarted; you must create a new session using
        /// <c>StartBrowserSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBrowserSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopBrowserSession">REST API Reference for StopBrowserSession Operation</seealso>
        public virtual Task<StopBrowserSessionResponse> StopBrowserSessionAsync(StopBrowserSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBrowserSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBrowserSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopBrowserSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCodeInterpreterSession


        /// <summary>
        /// Terminates an active code interpreter session in Amazon Bedrock. This operation stops
        /// the session, releases associated resources, and makes the session unavailable for
        /// further use.
        /// 
        ///  
        /// <para>
        /// To stop a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. Once stopped, a session cannot be restarted; you must create a
        /// new session using <c>StartCodeInterpreterSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the StopCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopCodeInterpreterSession">REST API Reference for StopCodeInterpreterSession Operation</seealso>
        public virtual StopCodeInterpreterSessionResponse StopCodeInterpreterSession(StopCodeInterpreterSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCodeInterpreterSessionResponseUnmarshaller.Instance;

            return Invoke<StopCodeInterpreterSessionResponse>(request, options);
        }


        /// <summary>
        /// Terminates an active code interpreter session in Amazon Bedrock. This operation stops
        /// the session, releases associated resources, and makes the session unavailable for
        /// further use.
        /// 
        ///  
        /// <para>
        /// To stop a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. Once stopped, a session cannot be restarted; you must create a
        /// new session using <c>StartCodeInterpreterSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCodeInterpreterSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopCodeInterpreterSession">REST API Reference for StopCodeInterpreterSession Operation</seealso>
        public virtual Task<StopCodeInterpreterSessionResponse> StopCodeInterpreterSessionAsync(StopCodeInterpreterSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCodeInterpreterSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCodeInterpreterSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopCodeInterpreterSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBrowserStream


        /// <summary>
        /// Updates a browser stream. To use this operation, you must have permissions to perform
        /// the bedrock:UpdateBrowserStream action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserStream service method.</param>
        /// 
        /// <returns>The response from the UpdateBrowserStream service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/UpdateBrowserStream">REST API Reference for UpdateBrowserStream Operation</seealso>
        public virtual UpdateBrowserStreamResponse UpdateBrowserStream(UpdateBrowserStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrowserStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateBrowserStreamResponse>(request, options);
        }


        /// <summary>
        /// Updates a browser stream. To use this operation, you must have permissions to perform
        /// the bedrock:UpdateBrowserStream action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrowserStream service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/UpdateBrowserStream">REST API Reference for UpdateBrowserStream Operation</seealso>
        public virtual Task<UpdateBrowserStreamResponse> UpdateBrowserStreamAsync(UpdateBrowserStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrowserStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBrowserStreamResponse>(request, options, cancellationToken);
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