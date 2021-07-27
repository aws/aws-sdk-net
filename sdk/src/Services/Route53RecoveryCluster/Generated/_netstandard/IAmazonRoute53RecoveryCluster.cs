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

namespace Amazon.Route53RecoveryCluster
{
    /// <summary>
    /// Interface for accessing Route53RecoveryCluster
    ///
    /// Welcome to the Amazon Route 53 Application Recovery Controller API Reference Guide
    /// for Recovery Control Data Plane .
    /// 
    ///  
    /// <para>
    /// Recovery control in Route 53 Application Recovery Controller includes extremely reliable
    /// routing controls that enable you to recover applications by rerouting traffic, for
    /// example, across Availability Zones or AWS Regions. Routing controls are simple on/off
    /// switches hosted on a cluster. A cluster is a set of five redundant regional endpoints
    /// against which you can execute API calls to update or get the state of routing controls.
    /// You use routing controls to failover traffic to recover your application across Availability
    /// Zones or Regions.
    /// </para>
    ///  
    /// <para>
    /// This API guide includes information about how to get and update routing control states
    /// in Route 53 Application Recovery Controller.
    /// </para>
    ///  
    /// <para>
    /// For more information about Route 53 Application Recovery Controller, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can create clusters, routing controls, and control panels by using the control
    /// plane API for Recovery Control. For more information, see <a href="https://docs.aws.amazon.com/recovery-cluster/latest/api/">Amazon
    /// Route 53 Application Recovery Controller Recovery Control API Reference</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Route 53 Application Recovery Controller also provides continuous readiness checks
    /// to ensure that your applications are scaled to handle failover traffic. For more information
    /// about the related API actions, see <a href="https://docs.aws.amazon.com/recovery-readiness/latest/api/">Amazon
    /// Route 53 Application Recovery Controller Recovery Readiness API Reference</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about creating resilient applications and preparing for recovery
    /// readiness with Route 53 Application Recovery Controller, see the <a href="r53recovery/latest/dg/">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonRoute53RecoveryCluster : IAmazonService, IDisposable
    {
                
        #region  GetRoutingControlState



        /// <summary>
        /// Get the state for a routing control. A routing control is a simple on/off switch that
        /// you can use to route traffic to cells. When the state is On, traffic flows to a cell.
        /// When it's off, traffic does not flow. 
        /// 
        ///  
        /// <para>
        /// Before you can create a routing control, you first must create a cluster to host the
        /// control. For more information, see <a href="https://docs.aws.amazon.com/recovery-cluster/latest/api/cluster.html">CreateCluster</a>.
        /// Access one of the endpoints for the cluster to get or update the routing control state
        /// to redirect traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with routing controls, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Routing
        /// control</a> in the Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingControlState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.EndpointTemporarilyUnavailableException">
        /// The cluster endpoint isn't available. Try another cluster endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.InternalServerException">
        /// There was an unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ResourceNotFoundException">
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/GetRoutingControlState">REST API Reference for GetRoutingControlState Operation</seealso>
        Task<GetRoutingControlStateResponse> GetRoutingControlStateAsync(GetRoutingControlStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingControlState



        /// <summary>
        /// Set the state of the routing control to reroute traffic. You can set the value to
        /// be On or Off. When the state is On, traffic flows to a cell. When it's off, traffic
        /// does not flow.
        /// 
        ///  
        /// <para>
        /// For more information about working with routing controls, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Routing
        /// control</a> in the Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControlState service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
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
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlState">REST API Reference for UpdateRoutingControlState Operation</seealso>
        Task<UpdateRoutingControlStateResponse> UpdateRoutingControlStateAsync(UpdateRoutingControlStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoutingControlStates



        /// <summary>
        /// Set multiple routing control states. You can set the value for each state to be On
        /// or Off. When the state is On, traffic flows to a cell. When it's off, traffic does
        /// not flow.
        /// 
        ///  
        /// <para>
        /// For more information about working with routing controls, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Routing
        /// control</a> in the Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControlStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControlStates service method, as returned by Route53RecoveryCluster.</returns>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.AccessDeniedException">
        /// You don't have sufficient permissions to query the routing control state.
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
        /// The request references a routing control that was not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryCluster.Model.ValidationException">
        /// There was a validation error on the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-cluster-2019-12-02/UpdateRoutingControlStates">REST API Reference for UpdateRoutingControlStates Operation</seealso>
        Task<UpdateRoutingControlStatesResponse> UpdateRoutingControlStatesAsync(UpdateRoutingControlStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}