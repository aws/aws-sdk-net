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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53RecoveryControlConfig.Model;

namespace Amazon.Route53RecoveryControlConfig
{
    /// <summary>
    /// Interface for accessing Route53RecoveryControlConfig
    ///
    /// Recovery Control Configuration API Reference for Amazon Route 53 Application Recovery
    /// Controller
    /// </summary>
    public partial interface IAmazonRoute53RecoveryControlConfig : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53RecoveryControlConfigPaginatorFactory Paginators { get; }

        
        #region  CreateCluster


        /// <summary>
        /// Create a new cluster. A cluster is a set of redundant Regional endpoints against which
        /// you can run API calls to update or get the state of one or more routing controls.
        /// Each cluster has a name, status, Amazon Resource Name (ARN), and an array of the five
        /// cluster endpoints (one for each supported Amazon Web Services Region) that you can
        /// use with API calls to the cluster data plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);



        /// <summary>
        /// Create a new cluster. A cluster is a set of redundant Regional endpoints against which
        /// you can run API calls to update or get the state of one or more routing controls.
        /// Each cluster has a name, status, Amazon Resource Name (ARN), and an array of the five
        /// cluster endpoints (one for each supported Amazon Web Services Region) that you can
        /// use with API calls to the cluster data plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateControlPanel


        /// <summary>
        /// Creates a new control panel. A control panel represents a group of routing controls
        /// that can be changed together in a single transaction. You can use a control panel
        /// to centrally view the operational status of applications across your organization,
        /// and trigger multi-app failovers in a single transaction, for example, to fail over
        /// an Availability Zone or Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControlPanel service method.</param>
        /// 
        /// <returns>The response from the CreateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateControlPanel">REST API Reference for CreateControlPanel Operation</seealso>
        CreateControlPanelResponse CreateControlPanel(CreateControlPanelRequest request);



        /// <summary>
        /// Creates a new control panel. A control panel represents a group of routing controls
        /// that can be changed together in a single transaction. You can use a control panel
        /// to centrally view the operational status of applications across your organization,
        /// and trigger multi-app failovers in a single transaction, for example, to fail over
        /// an Availability Zone or Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateControlPanel">REST API Reference for CreateControlPanel Operation</seealso>
        Task<CreateControlPanelResponse> CreateControlPanelAsync(CreateControlPanelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRoutingControl


        /// <summary>
        /// Creates a new routing control.
        /// 
        ///  
        /// <para>
        /// A routing control has one of two states: ON and OFF. You can map the routing control
        /// state to the state of an Amazon Route 53 health check, which can be used to control
        /// traffic routing.
        /// </para>
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingControl service method.</param>
        /// 
        /// <returns>The response from the CreateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateRoutingControl">REST API Reference for CreateRoutingControl Operation</seealso>
        CreateRoutingControlResponse CreateRoutingControl(CreateRoutingControlRequest request);



        /// <summary>
        /// Creates a new routing control.
        /// 
        ///  
        /// <para>
        /// A routing control has one of two states: ON and OFF. You can map the routing control
        /// state to the state of an Amazon Route 53 health check, which can be used to control
        /// traffic routing.
        /// </para>
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateRoutingControl">REST API Reference for CreateRoutingControl Operation</seealso>
        Task<CreateRoutingControlResponse> CreateRoutingControlAsync(CreateRoutingControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSafetyRule


        /// <summary>
        /// Creates a safety rule in a control panel. Safety rules let you add safeguards around
        /// changing routing control states, and for enabling and disabling routing controls,
        /// to help prevent unexpected outcomes.
        /// 
        ///  
        /// <para>
        /// There are two types of safety rules: assertion rules and gating rules.
        /// </para>
        ///  
        /// <para>
        /// Assertion rule: An assertion rule enforces that, when you change a routing control
        /// state, that a certain criteria is met. For example, the criteria might be that at
        /// least one routing control state is On after the transaction so that traffic continues
        /// to flow to at least one cell for the application. This ensures that you avoid a fail-open
        /// scenario.
        /// </para>
        ///  
        /// <para>
        /// Gating rule: A gating rule lets you configure a gating routing control as an overall
        /// "on/off" switch for a group of routing controls. Or, you can configure more complex
        /// gating scenarios, for example by configuring multiple gating routing controls.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.safety-rules.html">Safety
        /// rules</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSafetyRule service method.</param>
        /// 
        /// <returns>The response from the CreateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateSafetyRule">REST API Reference for CreateSafetyRule Operation</seealso>
        CreateSafetyRuleResponse CreateSafetyRule(CreateSafetyRuleRequest request);



        /// <summary>
        /// Creates a safety rule in a control panel. Safety rules let you add safeguards around
        /// changing routing control states, and for enabling and disabling routing controls,
        /// to help prevent unexpected outcomes.
        /// 
        ///  
        /// <para>
        /// There are two types of safety rules: assertion rules and gating rules.
        /// </para>
        ///  
        /// <para>
        /// Assertion rule: An assertion rule enforces that, when you change a routing control
        /// state, that a certain criteria is met. For example, the criteria might be that at
        /// least one routing control state is On after the transaction so that traffic continues
        /// to flow to at least one cell for the application. This ensures that you avoid a fail-open
        /// scenario.
        /// </para>
        ///  
        /// <para>
        /// Gating rule: A gating rule lets you configure a gating routing control as an overall
        /// "on/off" switch for a group of routing controls. Or, you can configure more complex
        /// gating scenarios, for example by configuring multiple gating routing controls.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.safety-rules.html">Safety
        /// rules</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateSafetyRule">REST API Reference for CreateSafetyRule Operation</seealso>
        Task<CreateSafetyRuleResponse> CreateSafetyRuleAsync(CreateSafetyRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Delete a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);



        /// <summary>
        /// Delete a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteControlPanel


        /// <summary>
        /// Deletes a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControlPanel service method.</param>
        /// 
        /// <returns>The response from the DeleteControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteControlPanel">REST API Reference for DeleteControlPanel Operation</seealso>
        DeleteControlPanelResponse DeleteControlPanel(DeleteControlPanelRequest request);



        /// <summary>
        /// Deletes a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteControlPanel">REST API Reference for DeleteControlPanel Operation</seealso>
        Task<DeleteControlPanelResponse> DeleteControlPanelAsync(DeleteControlPanelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRoutingControl


        /// <summary>
        /// Deletes a routing control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingControl service method.</param>
        /// 
        /// <returns>The response from the DeleteRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteRoutingControl">REST API Reference for DeleteRoutingControl Operation</seealso>
        DeleteRoutingControlResponse DeleteRoutingControl(DeleteRoutingControlRequest request);



        /// <summary>
        /// Deletes a routing control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteRoutingControl">REST API Reference for DeleteRoutingControl Operation</seealso>
        Task<DeleteRoutingControlResponse> DeleteRoutingControlAsync(DeleteRoutingControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSafetyRule


        /// <summary>
        /// Deletes a safety rule.
        /// 
        /// /&gt;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSafetyRule service method.</param>
        /// 
        /// <returns>The response from the DeleteSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteSafetyRule">REST API Reference for DeleteSafetyRule Operation</seealso>
        DeleteSafetyRuleResponse DeleteSafetyRule(DeleteSafetyRuleRequest request);



        /// <summary>
        /// Deletes a safety rule.
        /// 
        /// /&gt;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteSafetyRule">REST API Reference for DeleteSafetyRule Operation</seealso>
        Task<DeleteSafetyRuleResponse> DeleteSafetyRuleAsync(DeleteSafetyRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCluster


        /// <summary>
        /// Display the details about a cluster. The response includes the cluster name, endpoints,
        /// status, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster(DescribeClusterRequest request);



        /// <summary>
        /// Display the details about a cluster. The response includes the cluster name, endpoints,
        /// status, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeControlPanel


        /// <summary>
        /// Displays details about a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeControlPanel service method.</param>
        /// 
        /// <returns>The response from the DescribeControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeControlPanel">REST API Reference for DescribeControlPanel Operation</seealso>
        DescribeControlPanelResponse DescribeControlPanel(DescribeControlPanelRequest request);



        /// <summary>
        /// Displays details about a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeControlPanel">REST API Reference for DescribeControlPanel Operation</seealso>
        Task<DescribeControlPanelResponse> DescribeControlPanelAsync(DescribeControlPanelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRoutingControl


        /// <summary>
        /// Displays details about a routing control. A routing control has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// 
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingControl service method.</param>
        /// 
        /// <returns>The response from the DescribeRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeRoutingControl">REST API Reference for DescribeRoutingControl Operation</seealso>
        DescribeRoutingControlResponse DescribeRoutingControl(DescribeRoutingControlRequest request);



        /// <summary>
        /// Displays details about a routing control. A routing control has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// 
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeRoutingControl">REST API Reference for DescribeRoutingControl Operation</seealso>
        Task<DescribeRoutingControlResponse> DescribeRoutingControlAsync(DescribeRoutingControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSafetyRule


        /// <summary>
        /// Returns information about a safety rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSafetyRule service method.</param>
        /// 
        /// <returns>The response from the DescribeSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeSafetyRule">REST API Reference for DescribeSafetyRule Operation</seealso>
        DescribeSafetyRuleResponse DescribeSafetyRule(DescribeSafetyRuleRequest request);



        /// <summary>
        /// Returns information about a safety rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeSafetyRule">REST API Reference for DescribeSafetyRule Operation</seealso>
        Task<DescribeSafetyRuleResponse> DescribeSafetyRuleAsync(DescribeSafetyRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociatedRoute53HealthChecks


        /// <summary>
        /// Returns an array of all Amazon Route 53 health checks associated with a specific routing
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedRoute53HealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedRoute53HealthChecks service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListAssociatedRoute53HealthChecks">REST API Reference for ListAssociatedRoute53HealthChecks Operation</seealso>
        ListAssociatedRoute53HealthChecksResponse ListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request);



        /// <summary>
        /// Returns an array of all Amazon Route 53 health checks associated with a specific routing
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedRoute53HealthChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedRoute53HealthChecks service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListAssociatedRoute53HealthChecks">REST API Reference for ListAssociatedRoute53HealthChecks Operation</seealso>
        Task<ListAssociatedRoute53HealthChecksResponse> ListAssociatedRoute53HealthChecksAsync(ListAssociatedRoute53HealthChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns an array of all the clusters in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);



        /// <summary>
        /// Returns an array of all the clusters in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListControlPanels


        /// <summary>
        /// Returns an array of control panels in an account or in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlPanels service method.</param>
        /// 
        /// <returns>The response from the ListControlPanels service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListControlPanels">REST API Reference for ListControlPanels Operation</seealso>
        ListControlPanelsResponse ListControlPanels(ListControlPanelsRequest request);



        /// <summary>
        /// Returns an array of control panels in an account or in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlPanels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControlPanels service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListControlPanels">REST API Reference for ListControlPanels Operation</seealso>
        Task<ListControlPanelsResponse> ListControlPanelsAsync(ListControlPanelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRoutingControls


        /// <summary>
        /// Returns an array of routing controls for a control panel. A routing control is an
        /// Amazon Route 53 Application Recovery Controller construct that has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
        /// 
        /// <returns>The response from the ListRoutingControls service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        ListRoutingControlsResponse ListRoutingControls(ListRoutingControlsRequest request);



        /// <summary>
        /// Returns an array of routing controls for a control panel. A routing control is an
        /// Amazon Route 53 Application Recovery Controller construct that has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingControls service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        Task<ListRoutingControlsResponse> ListRoutingControlsAsync(ListRoutingControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSafetyRules


        /// <summary>
        /// List the safety rules (the assertion rules and gating rules) that you've defined for
        /// the routing controls in a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSafetyRules service method.</param>
        /// 
        /// <returns>The response from the ListSafetyRules service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListSafetyRules">REST API Reference for ListSafetyRules Operation</seealso>
        ListSafetyRulesResponse ListSafetyRules(ListSafetyRulesRequest request);



        /// <summary>
        /// List the safety rules (the assertion rules and gating rules) that you've defined for
        /// the routing controls in a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSafetyRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSafetyRules service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListSafetyRules">REST API Reference for ListSafetyRules Operation</seealso>
        Task<ListSafetyRulesResponse> ListSafetyRulesAsync(ListSafetyRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateControlPanel


        /// <summary>
        /// Updates a control panel. The only update you can make to a control panel is to change
        /// the name of the control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControlPanel service method.</param>
        /// 
        /// <returns>The response from the UpdateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateControlPanel">REST API Reference for UpdateControlPanel Operation</seealso>
        UpdateControlPanelResponse UpdateControlPanel(UpdateControlPanelRequest request);



        /// <summary>
        /// Updates a control panel. The only update you can make to a control panel is to change
        /// the name of the control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateControlPanel">REST API Reference for UpdateControlPanel Operation</seealso>
        Task<UpdateControlPanelResponse> UpdateControlPanelAsync(UpdateControlPanelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoutingControl


        /// <summary>
        /// Updates a routing control. You can only update the name of the routing control. To
        /// get or update the routing control state, see the Recovery Cluster (data plane) API
        /// actions for Amazon Route 53 Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControl service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateRoutingControl">REST API Reference for UpdateRoutingControl Operation</seealso>
        UpdateRoutingControlResponse UpdateRoutingControl(UpdateRoutingControlRequest request);



        /// <summary>
        /// Updates a routing control. You can only update the name of the routing control. To
        /// get or update the routing control state, see the Recovery Cluster (data plane) API
        /// actions for Amazon Route 53 Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateRoutingControl">REST API Reference for UpdateRoutingControl Operation</seealso>
        Task<UpdateRoutingControlResponse> UpdateRoutingControlAsync(UpdateRoutingControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSafetyRule


        /// <summary>
        /// Update a safety rule (an assertion rule or gating rule). You can only update the name
        /// and the waiting period for a safety rule. To make other updates, delete the safety
        /// rule and create a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyRule service method.</param>
        /// 
        /// <returns>The response from the UpdateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateSafetyRule">REST API Reference for UpdateSafetyRule Operation</seealso>
        UpdateSafetyRuleResponse UpdateSafetyRule(UpdateSafetyRuleRequest request);



        /// <summary>
        /// Update a safety rule (an assertion rule or gating rule). You can only update the name
        /// and the waiting period for a safety rule. To make other updates, delete the safety
        /// rule and create a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateSafetyRule">REST API Reference for UpdateSafetyRule Operation</seealso>
        Task<UpdateSafetyRuleResponse> UpdateSafetyRuleAsync(UpdateSafetyRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}