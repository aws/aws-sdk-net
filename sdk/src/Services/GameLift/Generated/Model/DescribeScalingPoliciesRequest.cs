/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingPolicies operation.
    /// Retrieves all scaling policies applied to a fleet.
    /// 
    ///  
    /// <para>
    /// To get a fleet's scaling policies, specify the fleet ID. You can filter this request
    /// by policy status, such as to retrieve only active scaling policies. Use the pagination
    /// parameters to retrieve results as a set of sequential pages. If successful, set of
    /// <a>ScalingPolicy</a> objects is returned for the fleet.
    /// </para>
    ///  
    /// <para>
    /// A fleet may have all of its scaling policies suspended (<a>StopFleetActions</a>).
    /// This action does not affect the status of the scaling policies, which remains ACTIVE.
    /// To see whether a fleet's scaling policies are in force or suspended, call <a>DescribeFleetAttributes</a>
    /// and check the stopped actions.
    /// </para>
    ///  
    /// <para>
    /// Operations related to fleet capacity scaling include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Manage scaling policies:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> (auto-scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> (auto-scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> (auto-scaling)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class DescribeScalingPoliciesRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private int? _limit;
        private string _nextToken;
        private ScalingStatusType _statusFilter;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to retrieve scaling policies for.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Scaling policy status to filter results on. A scaling policy is only in force when
        /// in an <code>ACTIVE</code> status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The scaling policy is currently in force.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATEREQUESTED</b> -- A request to update the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATING</b> -- A change is being made to the scaling policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETEREQUESTED</b> -- A request to delete the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b> -- The scaling policy is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETED</b> -- The scaling policy has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b> -- An error occurred in creating the policy. It should be removed and
        /// recreated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalingStatusType StatusFilter
        {
            get { return this._statusFilter; }
            set { this._statusFilter = value; }
        }

        // Check to see if StatusFilter property is set
        internal bool IsSetStatusFilter()
        {
            return this._statusFilter != null;
        }

    }
}