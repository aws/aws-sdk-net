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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ARCRegionswitch.Model;
using Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations;
using Amazon.ARCRegionswitch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ARCRegionswitch
{
    /// <summary>
    /// <para>Implementation for accessing ARCRegionswitch</para>
    ///
    /// Amazon Application Recovery Controller (ARC) Region switch helps you to quickly and
    /// reliably shift traffic away from an impaired Amazon Web Services Region to a healthy
    /// Region. With Region switch, you can create plans that define the steps to shift traffic
    /// for your application from one Amazon Web Services Region to another. You can test
    /// your plans in practice mode before using them in a real recovery scenario.
    /// 
    ///  
    /// <para>
    /// Region switch provides a structured approach to multi-Region failover, helping you
    /// to meet your recovery time objectives (RTOs) and maintain business continuity during
    /// regional disruptions.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/region-switch.html">Region
    /// switch in ARC</a> in the <i>Amazon Application Recovery Controller User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonARCRegionswitchClient : AmazonServiceClient, IAmazonARCRegionswitch
    {
        private static IServiceMetadata serviceMetadata = new AmazonARCRegionswitchMetadata();
        private IARCRegionswitchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IARCRegionswitchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ARCRegionswitchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        public AmazonARCRegionswitchClient()
            : base(new AmazonARCRegionswitchConfig()) { }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        public AmazonARCRegionswitchClient(RegionEndpoint region)
            : base(new AmazonARCRegionswitchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(AmazonARCRegionswitchConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials)
            : this(credentials, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonARCRegionswitchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Credentials and an
        /// AmazonARCRegionswitchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(AWSCredentials credentials, AmazonARCRegionswitchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonARCRegionswitchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCRegionswitchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonARCRegionswitchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCRegionswitchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonARCRegionswitchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonARCRegionswitchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonARCRegionswitchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonARCRegionswitchClient Configuration Object</param>
        public AmazonARCRegionswitchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonARCRegionswitchConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCRegionswitchEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonARCRegionswitchAuthSchemeHandler());
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


        #region  ApprovePlanExecutionStep


        /// <summary>
        /// Approves a step in a plan execution that requires manual approval. When you create
        /// a plan, you can include approval steps that require manual intervention before the
        /// execution can proceed. This operation allows you to provide that approval.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN, execution ID, step name, and approval status. You can
        /// also provide an optional comment explaining the approval decision.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApprovePlanExecutionStep service method.</param>
        /// 
        /// <returns>The response from the ApprovePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ApprovePlanExecutionStep">REST API Reference for ApprovePlanExecutionStep Operation</seealso>
        public virtual ApprovePlanExecutionStepResponse ApprovePlanExecutionStep(ApprovePlanExecutionStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApprovePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePlanExecutionStepResponseUnmarshaller.Instance;

            return Invoke<ApprovePlanExecutionStepResponse>(request, options);
        }


        /// <summary>
        /// Approves a step in a plan execution that requires manual approval. When you create
        /// a plan, you can include approval steps that require manual intervention before the
        /// execution can proceed. This operation allows you to provide that approval.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN, execution ID, step name, and approval status. You can
        /// also provide an optional comment explaining the approval decision.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApprovePlanExecutionStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApprovePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ApprovePlanExecutionStep">REST API Reference for ApprovePlanExecutionStep Operation</seealso>
        public virtual Task<ApprovePlanExecutionStepResponse> ApprovePlanExecutionStepAsync(ApprovePlanExecutionStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApprovePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePlanExecutionStepResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApprovePlanExecutionStepResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelPlanExecution


        /// <summary>
        /// Cancels an in-progress plan execution. This operation stops the execution of the plan
        /// and prevents any further steps from being processed.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN and execution ID. You can also provide an optional comment
        /// explaining why the execution was canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPlanExecution service method.</param>
        /// 
        /// <returns>The response from the CancelPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CancelPlanExecution">REST API Reference for CancelPlanExecution Operation</seealso>
        public virtual CancelPlanExecutionResponse CancelPlanExecution(CancelPlanExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelPlanExecutionResponse>(request, options);
        }


        /// <summary>
        /// Cancels an in-progress plan execution. This operation stops the execution of the plan
        /// and prevents any further steps from being processed.
        /// 
        ///  
        /// <para>
        /// You must specify the plan ARN and execution ID. You can also provide an optional comment
        /// explaining why the execution was canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPlanExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CancelPlanExecution">REST API Reference for CancelPlanExecution Operation</seealso>
        public virtual Task<CancelPlanExecutionResponse> CancelPlanExecutionAsync(CancelPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPlanExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelPlanExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlan


        /// <summary>
        /// Creates a new Region switch plan. A plan defines the steps required to shift traffic
        /// from one Amazon Web Services Region to another.
        /// 
        ///  
        /// <para>
        /// You must specify a name for the plan, the primary Region, and at least one additional
        /// Region. You can also provide a description, execution role, recovery time objective,
        /// associated alarms, triggers, and workflows that define the steps to execute during
        /// a Region switch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlan service method.</param>
        /// 
        /// <returns>The response from the CreatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        public virtual CreatePlanResponse CreatePlan(CreatePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlanResponseUnmarshaller.Instance;

            return Invoke<CreatePlanResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Region switch plan. A plan defines the steps required to shift traffic
        /// from one Amazon Web Services Region to another.
        /// 
        ///  
        /// <para>
        /// You must specify a name for the plan, the primary Region, and at least one additional
        /// Region. You can also provide a description, execution role, recovery time objective,
        /// associated alarms, triggers, and workflows that define the steps to execute during
        /// a Region switch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        public virtual Task<CreatePlanResponse> CreatePlanAsync(CreatePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlan


        /// <summary>
        /// Deletes a Region switch plan. You must specify the ARN of the plan to delete.
        /// 
        ///  
        /// <para>
        /// You cannot delete a plan that has an active execution in progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlan service method.</param>
        /// 
        /// <returns>The response from the DeletePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/DeletePlan">REST API Reference for DeletePlan Operation</seealso>
        public virtual DeletePlanResponse DeletePlan(DeletePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlanResponseUnmarshaller.Instance;

            return Invoke<DeletePlanResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Region switch plan. You must specify the ARN of the plan to delete.
        /// 
        ///  
        /// <para>
        /// You cannot delete a plan that has an active execution in progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/DeletePlan">REST API Reference for DeletePlan Operation</seealso>
        public virtual Task<DeletePlanResponse> DeletePlanAsync(DeletePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlan


        /// <summary>
        /// Retrieves detailed information about a Region switch plan. You must specify the ARN
        /// of the plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a Region switch plan. You must specify the ARN
        /// of the plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlanEvaluationStatus


        /// <summary>
        /// Retrieves the evaluation status of a Region switch plan. The evaluation status provides
        /// information about the last time the plan was evaluated and any warnings or issues
        /// detected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the GetPlanEvaluationStatus service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanEvaluationStatus">REST API Reference for GetPlanEvaluationStatus Operation</seealso>
        public virtual GetPlanEvaluationStatusResponse GetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<GetPlanEvaluationStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the evaluation status of a Region switch plan. The evaluation status provides
        /// information about the last time the plan was evaluated and any warnings or issues
        /// detected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanEvaluationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlanEvaluationStatus service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanEvaluationStatus">REST API Reference for GetPlanEvaluationStatus Operation</seealso>
        public virtual Task<GetPlanEvaluationStatusResponse> GetPlanEvaluationStatusAsync(GetPlanEvaluationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanEvaluationStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPlanEvaluationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlanExecution


        /// <summary>
        /// Retrieves detailed information about a specific plan execution. You must specify the
        /// plan ARN and execution ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanExecution service method.</param>
        /// 
        /// <returns>The response from the GetPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanExecution">REST API Reference for GetPlanExecution Operation</seealso>
        public virtual GetPlanExecutionResponse GetPlanExecution(GetPlanExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPlanExecutionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific plan execution. You must specify the
        /// plan ARN and execution ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanExecution">REST API Reference for GetPlanExecution Operation</seealso>
        public virtual Task<GetPlanExecutionResponse> GetPlanExecutionAsync(GetPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPlanExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlanInRegion


        /// <summary>
        /// Retrieves information about a Region switch plan in a specific Amazon Web Services
        /// Region. This operation is useful for getting Region-specific information about a plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanInRegion service method.</param>
        /// 
        /// <returns>The response from the GetPlanInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanInRegion">REST API Reference for GetPlanInRegion Operation</seealso>
        public virtual GetPlanInRegionResponse GetPlanInRegion(GetPlanInRegionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanInRegionResponseUnmarshaller.Instance;

            return Invoke<GetPlanInRegionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a Region switch plan in a specific Amazon Web Services
        /// Region. This operation is useful for getting Region-specific information about a plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlanInRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlanInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/GetPlanInRegion">REST API Reference for GetPlanInRegion Operation</seealso>
        public virtual Task<GetPlanInRegionResponse> GetPlanInRegionAsync(GetPlanInRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlanInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanInRegionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPlanInRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlanExecutionEvents


        /// <summary>
        /// Lists the events that occurred during a plan execution. These events provide a detailed
        /// timeline of the execution process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutionEvents service method.</param>
        /// 
        /// <returns>The response from the ListPlanExecutionEvents service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutionEvents">REST API Reference for ListPlanExecutionEvents Operation</seealso>
        public virtual ListPlanExecutionEventsResponse ListPlanExecutionEvents(ListPlanExecutionEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionEventsResponseUnmarshaller.Instance;

            return Invoke<ListPlanExecutionEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists the events that occurred during a plan execution. These events provide a detailed
        /// timeline of the execution process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutionEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlanExecutionEvents service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutionEvents">REST API Reference for ListPlanExecutionEvents Operation</seealso>
        public virtual Task<ListPlanExecutionEventsResponse> ListPlanExecutionEventsAsync(ListPlanExecutionEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlanExecutionEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlanExecutions


        /// <summary>
        /// Lists the executions of a Region switch plan. This operation returns information about
        /// both current and historical executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutions service method.</param>
        /// 
        /// <returns>The response from the ListPlanExecutions service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutions">REST API Reference for ListPlanExecutions Operation</seealso>
        public virtual ListPlanExecutionsResponse ListPlanExecutions(ListPlanExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPlanExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the executions of a Region switch plan. This operation returns information about
        /// both current and historical executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlanExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlanExecutions service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlanExecutions">REST API Reference for ListPlanExecutions Operation</seealso>
        public virtual Task<ListPlanExecutionsResponse> ListPlanExecutionsAsync(ListPlanExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlanExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlanExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlanExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlans


        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlans service method.</param>
        /// 
        /// <returns>The response from the ListPlans service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlans">REST API Reference for ListPlans Operation</seealso>
        public virtual ListPlansResponse ListPlans(ListPlansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansResponseUnmarshaller.Instance;

            return Invoke<ListPlansResponse>(request, options);
        }


        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlans service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlans">REST API Reference for ListPlans Operation</seealso>
        public virtual Task<ListPlansResponse> ListPlansAsync(ListPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlansInRegion


        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account that are available
        /// in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlansInRegion service method.</param>
        /// 
        /// <returns>The response from the ListPlansInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlansInRegion">REST API Reference for ListPlansInRegion Operation</seealso>
        public virtual ListPlansInRegionResponse ListPlansInRegion(ListPlansInRegionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlansInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansInRegionResponseUnmarshaller.Instance;

            return Invoke<ListPlansInRegionResponse>(request, options);
        }


        /// <summary>
        /// Lists all Region switch plans in your Amazon Web Services account that are available
        /// in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlansInRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlansInRegion service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListPlansInRegion">REST API Reference for ListPlansInRegion Operation</seealso>
        public virtual Task<ListPlansInRegionResponse> ListPlansInRegionAsync(ListPlansInRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlansInRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlansInRegionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlansInRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoute53HealthChecks


        /// <summary>
        /// List the Amazon Route 53 health checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoute53HealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListRoute53HealthChecks service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListRoute53HealthChecks">REST API Reference for ListRoute53HealthChecks Operation</seealso>
        public virtual ListRoute53HealthChecksResponse ListRoute53HealthChecks(ListRoute53HealthChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoute53HealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListRoute53HealthChecksResponse>(request, options);
        }


        /// <summary>
        /// List the Amazon Route 53 health checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoute53HealthChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoute53HealthChecks service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListRoute53HealthChecks">REST API Reference for ListRoute53HealthChecks Operation</seealso>
        public virtual Task<ListRoute53HealthChecksResponse> ListRoute53HealthChecksAsync(ListRoute53HealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoute53HealthChecksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRoute53HealthChecksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags attached to a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags attached to a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPlanExecution


        /// <summary>
        /// Starts the execution of a Region switch plan. You can execute a plan in either PRACTICE
        /// or RECOVERY mode.
        /// 
        ///  
        /// <para>
        /// In PRACTICE mode, the execution simulates the steps without making actual changes
        /// to your application's traffic routing. In RECOVERY mode, the execution performs actual
        /// changes to shift traffic between Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPlanExecution service method.</param>
        /// 
        /// <returns>The response from the StartPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalArgumentException">
        /// The request processing has an invalid argument.
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/StartPlanExecution">REST API Reference for StartPlanExecution Operation</seealso>
        public virtual StartPlanExecutionResponse StartPlanExecution(StartPlanExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPlanExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPlanExecutionResponse>(request, options);
        }


        /// <summary>
        /// Starts the execution of a Region switch plan. You can execute a plan in either PRACTICE
        /// or RECOVERY mode.
        /// 
        ///  
        /// <para>
        /// In PRACTICE mode, the execution simulates the steps without making actual changes
        /// to your application's traffic routing. In RECOVERY mode, the execution performs actual
        /// changes to shift traffic between Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPlanExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalArgumentException">
        /// The request processing has an invalid argument.
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/StartPlanExecution">REST API Reference for StartPlanExecution Operation</seealso>
        public virtual Task<StartPlanExecutionResponse> StartPlanExecutionAsync(StartPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPlanExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPlanExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a Region switch resource. You can assign metadata to your
        /// resources in the form of tags, which are key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates tags for a Region switch resource. You can assign metadata to your
        /// resources in the form of tags, which are key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a Region switch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlan


        /// <summary>
        /// Updates an existing Region switch plan. You can modify the plan's description, workflows,
        /// execution role, recovery time objective, associated alarms, and triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlan service method.</param>
        /// 
        /// <returns>The response from the UpdatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlan">REST API Reference for UpdatePlan Operation</seealso>
        public virtual UpdatePlanResponse UpdatePlan(UpdatePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing Region switch plan. You can modify the plan's description, workflows,
        /// execution role, recovery time objective, associated alarms, and triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlan">REST API Reference for UpdatePlan Operation</seealso>
        public virtual Task<UpdatePlanResponse> UpdatePlanAsync(UpdatePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlanExecution


        /// <summary>
        /// Updates an in-progress plan execution. This operation allows you to modify certain
        /// aspects of the execution, such as adding a comment or changing the action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecution service method.</param>
        /// 
        /// <returns>The response from the UpdatePlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecution">REST API Reference for UpdatePlanExecution Operation</seealso>
        public virtual UpdatePlanExecutionResponse UpdatePlanExecution(UpdatePlanExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanExecutionResponse>(request, options);
        }


        /// <summary>
        /// Updates an in-progress plan execution. This operation allows you to modify certain
        /// aspects of the execution, such as adding a comment or changing the action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlanExecution service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.IllegalStateException">
        /// The operation failed because the current state of the resource doesn't allow the operation
        /// to proceed.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecution">REST API Reference for UpdatePlanExecution Operation</seealso>
        public virtual Task<UpdatePlanExecutionResponse> UpdatePlanExecutionAsync(UpdatePlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePlanExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlanExecutionStep


        /// <summary>
        /// Updates a specific step in an in-progress plan execution. This operation allows you
        /// to modify the step's comment or action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecutionStep service method.</param>
        /// 
        /// <returns>The response from the UpdatePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecutionStep">REST API Reference for UpdatePlanExecutionStep Operation</seealso>
        public virtual UpdatePlanExecutionStepResponse UpdatePlanExecutionStep(UpdatePlanExecutionStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionStepResponseUnmarshaller.Instance;

            return Invoke<UpdatePlanExecutionStepResponse>(request, options);
        }


        /// <summary>
        /// Updates a specific step in an in-progress plan execution. This operation allows you
        /// to modify the step's comment or action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlanExecutionStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlanExecutionStep service method, as returned by ARCRegionswitch.</returns>
        /// <exception cref="Amazon.ARCRegionswitch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ARCRegionswitch.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 404
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/UpdatePlanExecutionStep">REST API Reference for UpdatePlanExecutionStep Operation</seealso>
        public virtual Task<UpdatePlanExecutionStepResponse> UpdatePlanExecutionStepAsync(UpdatePlanExecutionStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlanExecutionStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlanExecutionStepResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePlanExecutionStepResponse>(request, options, cancellationToken);
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