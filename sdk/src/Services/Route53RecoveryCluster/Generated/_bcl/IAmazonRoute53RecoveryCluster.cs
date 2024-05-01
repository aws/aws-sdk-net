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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53RecoveryCluster.Model;

#pragma warning disable CS1570
namespace Amazon.Route53RecoveryCluster
{
    /// <summary>
    /// <para>Interface for accessing Route53RecoveryCluster</para>
    ///
    /// Welcome to the Routing Control (Recovery Cluster) API Reference Guide for Amazon Route
    /// 53 Application Recovery Controller.
    /// 
    ///  
    /// <para>
    /// With Route 53 ARC, you can use routing control with extreme reliability to recover
    /// applications by rerouting traffic across Availability Zones or Amazon Web Services
    /// Regions. Routing controls are simple on/off switches hosted on a highly available
    /// cluster in Route 53 ARC. A cluster provides a set of five redundant Regional endpoints
    /// against which you can run API calls to get or update the state of routing controls.
    /// To implement failover, you set one routing control to ON and another one to OFF, to
    /// reroute traffic from one Availability Zone or Amazon Web Services Region to another.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <i>Be aware that you must specify a Regional endpoint for a cluster when you work
    /// with API cluster operations to get or update routing control states in Route 53 ARC.</i>
    /// In addition, you must specify the US West (Oregon) Region for Route 53 ARC API calls.
    /// For example, use the parameter <c>--region us-west-2</c> with AWS CLI commands. For
    /// more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.api.html">
    /// Get and update routing control states using the API</a> in the Amazon Route 53 Application
    /// Recovery Controller Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This API guide includes information about the API operations for how to get and update
    /// routing control states in Route 53 ARC. To work with routing control in Route 53 ARC,
    /// you must first create the required components (clusters, control panels, and routing
    /// controls) using the recovery cluster configuration API.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with routing control in Route 53 ARC, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create clusters, control panels, and routing controls by using API operations. For
    /// more information, see the <a href="https://docs.aws.amazon.com/recovery-cluster/latest/api/">Recovery
    /// Control Configuration API Reference Guide for Amazon Route 53 Application Recovery
    /// Controller</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Learn about the components in recovery control, including clusters, routing controls,
    /// and control panels, and how to work with Route 53 ARC in the Amazon Web Services console.
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/introduction-components.html#introduction-components-routing">
    /// Recovery control components</a> in the Amazon Route 53 Application Recovery Controller
    /// Developer Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Route 53 ARC also provides readiness checks that continually audit resources to help
    /// make sure that your applications are scaled and ready to handle failover traffic.
    /// For more information about the related API operations, see the <a href="https://docs.aws.amazon.com/recovery-readiness/latest/api/">Recovery
    /// Readiness API Reference Guide for Amazon Route 53 Application Recovery Controller</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about creating resilient applications and preparing for recovery
    /// readiness with Route 53 ARC, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonRoute53RecoveryCluster : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53RecoveryClusterPaginatorFactory Paginators { get; }

        
        #region  GetRoutingControlState


        /// <summary>
        /// Get the state for a routing control. A routing control is a simple on/off switch that
        /// you can use to route traffic to cells. When a routing control state is set to ON,
        /// traffic flows to a cell. When the state is set to OFF, traffic does not flow. 
        /// 
        ///  
        /// <para>
        /// Before you can create a routing control, you must first create a cluster, and then
        /// host the control in a control panel on the cluster. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
        /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide. You access one of the endpoints for the cluster to get
        /// or update the routing control state to redirect traffic for your application. 
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Learn more about working with routing controls in the following topics in the Amazon
        /// Route 53 Application Recovery Controller Developer Guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls in Route 53 ARC</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingControlState service method.</param>
        /// 
        /// <returns>The response from the GetRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        GetRoutingControlStateResponse GetRoutingControlState(GetRoutingControlStateRequest request);



        /// <summary>
        /// Get the state for a routing control. A routing control is a simple on/off switch that
        /// you can use to route traffic to cells. When a routing control state is set to ON,
        /// traffic flows to a cell. When the state is set to OFF, traffic does not flow. 
        /// 
        ///  
        /// <para>
        /// Before you can create a routing control, you must first create a cluster, and then
        /// host the control in a control panel on the cluster. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
        /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide. You access one of the endpoints for the cluster to get
        /// or update the routing control state to redirect traffic for your application. 
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Learn more about working with routing controls in the following topics in the Amazon
        /// Route 53 Application Recovery Controller Developer Guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls in Route 53 ARC</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingControlState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        Task<GetRoutingControlStateResponse> GetRoutingControlStateAsync(GetRoutingControlStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRoutingControls


        /// <summary>
        /// List routing control names and Amazon Resource Names (ARNs), as well as the routing
        /// control state for each routing control, along with the control panel name and control
        /// panel ARN for the routing controls. If you specify a control panel ARN, this call
        /// lists the routing controls in the control panel. Otherwise, it lists all the routing
        /// controls in the cluster.
        /// 
        ///  
        /// <para>
        /// A routing control is a simple on/off switch in Route 53 ARC that you can use to route
        /// traffic to cells. When a routing control state is set to ON, traffic flows to a cell.
        /// When the state is set to OFF, traffic does not flow.
        /// </para>
        ///  
        /// <para>
        /// Before you can create a routing control, you must first create a cluster, and then
        /// host the control in a control panel on the cluster. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
        /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide. You access one of the endpoints for the cluster to get
        /// or update the routing control state to redirect traffic for your application. 
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to use this API operation to list routing controls in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// Learn more about working with routing controls in the following topics in the Amazon
        /// Route 53 Application Recovery Controller Developer Guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls in Route 53 ARC</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
        /// 
        /// <returns>The response from the ListRoutingControls service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        ListRoutingControlsResponse ListRoutingControls(ListRoutingControlsRequest request);



        /// <summary>
        /// List routing control names and Amazon Resource Names (ARNs), as well as the routing
        /// control state for each routing control, along with the control panel name and control
        /// panel ARN for the routing controls. If you specify a control panel ARN, this call
        /// lists the routing controls in the control panel. Otherwise, it lists all the routing
        /// controls in the cluster.
        /// 
        ///  
        /// <para>
        /// A routing control is a simple on/off switch in Route 53 ARC that you can use to route
        /// traffic to cells. When a routing control state is set to ON, traffic flows to a cell.
        /// When the state is set to OFF, traffic does not flow.
        /// </para>
        ///  
        /// <para>
        /// Before you can create a routing control, you must first create a cluster, and then
        /// host the control in a control panel on the cluster. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
        /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide. You access one of the endpoints for the cluster to get
        /// or update the routing control state to redirect traffic for your application. 
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to use this API operation to list routing controls in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// Learn more about working with routing controls in the following topics in the Amazon
        /// Route 53 Application Recovery Controller Developer Guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls in Route 53 ARC</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingControls service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        Task<ListRoutingControlsResponse> ListRoutingControlsAsync(ListRoutingControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoutingControlState


        /// <summary>
        /// Set the state of the routing control to reroute traffic. You can set the value to
        /// ON or OFF. When the state is ON, traffic flows to a cell. When the state is OFF, traffic
        /// does not flow.
        /// 
        ///  
        /// <para>
        /// With Route 53 ARC, you can add safety rules for routing controls, which are safeguards
        /// for routing control state updates that help prevent unexpected outcomes, like fail
        /// open traffic routing. However, there are scenarios when you might want to bypass the
        /// routing control safeguards that are enforced with safety rules that you've configured.
        /// For example, you might want to fail over quickly for disaster recovery, and one or
        /// more safety rules might be unexpectedly preventing you from updating a routing control
        /// state to reroute traffic. In a "break glass" scenario like this, you can override
        /// one or more safety rules to change a routing control state and fail over your application.
        /// </para>
        ///  
        /// <para>
        /// The <c>SafetyRulesToOverride</c> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlState service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        UpdateRoutingControlStateResponse UpdateRoutingControlState(UpdateRoutingControlStateRequest request);



        /// <summary>
        /// Set the state of the routing control to reroute traffic. You can set the value to
        /// ON or OFF. When the state is ON, traffic flows to a cell. When the state is OFF, traffic
        /// does not flow.
        /// 
        ///  
        /// <para>
        /// With Route 53 ARC, you can add safety rules for routing controls, which are safeguards
        /// for routing control state updates that help prevent unexpected outcomes, like fail
        /// open traffic routing. However, there are scenarios when you might want to bypass the
        /// routing control safeguards that are enforced with safety rules that you've configured.
        /// For example, you might want to fail over quickly for disaster recovery, and one or
        /// more safety rules might be unexpectedly preventing you from updating a routing control
        /// state to reroute traffic. In a "break glass" scenario like this, you can override
        /// one or more safety rules to change a routing control state and fail over your application.
        /// </para>
        ///  
        /// <para>
        /// The <c>SafetyRulesToOverride</c> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        Task<UpdateRoutingControlStateResponse> UpdateRoutingControlStateAsync(UpdateRoutingControlStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoutingControlStates


        /// <summary>
        /// Set multiple routing control states. You can set the value for each state to be ON
        /// or OFF. When the state is ON, traffic flows to a cell. When it's OFF, traffic does
        /// not flow.
        /// 
        ///  
        /// <para>
        /// With Route 53 ARC, you can add safety rules for routing controls, which are safeguards
        /// for routing control state updates that help prevent unexpected outcomes, like fail
        /// open traffic routing. However, there are scenarios when you might want to bypass the
        /// routing control safeguards that are enforced with safety rules that you've configured.
        /// For example, you might want to fail over quickly for disaster recovery, and one or
        /// more safety rules might be unexpectedly preventing you from updating a routing control
        /// state to reroute traffic. In a "break glass" scenario like this, you can override
        /// one or more safety rules to change a routing control state and fail over your application.
        /// </para>
        ///  
        /// <para>
        /// The <c>SafetyRulesToOverride</c> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlStates service method.</param>
        /// 
        /// <returns>The response from the UpdateRoutingControlStates service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ServiceLimitExceededException">
        /// The request can't update that many routing control states at the same time. Try again
        /// with fewer routing control states.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        UpdateRoutingControlStatesResponse UpdateRoutingControlStates(UpdateRoutingControlStatesRequest request);



        /// <summary>
        /// Set multiple routing control states. You can set the value for each state to be ON
        /// or OFF. When the state is ON, traffic flows to a cell. When it's OFF, traffic does
        /// not flow.
        /// 
        ///  
        /// <para>
        /// With Route 53 ARC, you can add safety rules for routing controls, which are safeguards
        /// for routing control state updates that help prevent unexpected outcomes, like fail
        /// open traffic routing. However, there are scenarios when you might want to bypass the
        /// routing control safeguards that are enforced with safety rules that you've configured.
        /// For example, you might want to fail over quickly for disaster recovery, and one or
        /// more safety rules might be unexpectedly preventing you from updating a routing control
        /// state to reroute traffic. In a "break glass" scenario like this, you can override
        /// one or more safety rules to change a routing control state and fail over your application.
        /// </para>
        ///  
        /// <para>
        /// The <c>SafetyRulesToOverride</c> property enables you override one or more safety
        /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        ///  
        /// <para>
        ///  <i>You must specify Regional endpoints when you work with API cluster operations
        /// to get or update routing control states in Route 53 ARC.</i> 
        /// </para>
        ///  
        /// <para>
        /// To see a code example for getting a routing control state, including accessing Regional
        /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
        /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
        /// Viewing and updating routing control states</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
        /// with routing controls overall</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControlStates service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ConflictException">
        /// There was a conflict with this request. Try again.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control or control panel that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ServiceLimitExceededException">
        /// The request can't update that many routing control states at the same time. Try again
        /// with fewer routing control states.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        Task<UpdateRoutingControlStatesResponse> UpdateRoutingControlStatesAsync(UpdateRoutingControlStatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}