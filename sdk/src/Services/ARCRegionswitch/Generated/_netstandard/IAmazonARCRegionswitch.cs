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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ARCRegionswitch.Model;

#pragma warning disable CS1570
namespace Amazon.ARCRegionswitch
{
    /// <summary>
    /// <para>Interface for accessing ARCRegionswitch</para>
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
    public partial interface IAmazonARCRegionswitch : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IARCRegionswitchPaginatorFactory Paginators { get; }
#endif
                
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
        Task<ApprovePlanExecutionStepResponse> ApprovePlanExecutionStepAsync(ApprovePlanExecutionStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CancelPlanExecutionResponse> CancelPlanExecutionAsync(CancelPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlan service method, as returned by ARCRegionswitch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-region-switch-2022-07-26/CreatePlan">REST API Reference for CreatePlan Operation</seealso>
        Task<CreatePlanResponse> CreatePlanAsync(CreatePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeletePlanResponse> DeletePlanAsync(DeletePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlan



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
        Task<GetPlanResponse> GetPlanAsync(GetPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlanEvaluationStatus



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
        Task<GetPlanEvaluationStatusResponse> GetPlanEvaluationStatusAsync(GetPlanEvaluationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlanExecution



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
        Task<GetPlanExecutionResponse> GetPlanExecutionAsync(GetPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlanInRegion



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
        Task<GetPlanInRegionResponse> GetPlanInRegionAsync(GetPlanInRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPlanExecutionEvents



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
        Task<ListPlanExecutionEventsResponse> ListPlanExecutionEventsAsync(ListPlanExecutionEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPlanExecutions



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
        Task<ListPlanExecutionsResponse> ListPlanExecutionsAsync(ListPlanExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPlans



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
        Task<ListPlansResponse> ListPlansAsync(ListPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPlansInRegion



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
        Task<ListPlansInRegionResponse> ListPlansInRegionAsync(ListPlansInRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoute53HealthChecks



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
        Task<ListRoute53HealthChecksResponse> ListRoute53HealthChecksAsync(ListRoute53HealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<StartPlanExecutionResponse> StartPlanExecutionAsync(StartPlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePlan



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
        Task<UpdatePlanResponse> UpdatePlanAsync(UpdatePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePlanExecution



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
        Task<UpdatePlanExecutionResponse> UpdatePlanExecutionAsync(UpdatePlanExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePlanExecutionStep



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
        Task<UpdatePlanExecutionStepResponse> UpdatePlanExecutionStepAsync(UpdatePlanExecutionStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonARCRegionswitchConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonARCRegionswitchConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonARCRegionswitchConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonARCRegionswitchConfig to create AmazonARCRegionswitchClient");
            }

            return awsCredentials == null ? 
                    new AmazonARCRegionswitchClient(serviceClientConfig) :
                    new AmazonARCRegionswitchClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}