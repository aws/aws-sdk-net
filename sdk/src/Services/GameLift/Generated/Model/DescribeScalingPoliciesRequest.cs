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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
    /// <code>ScalingPolicy</code> objects is returned for the fleet.
    /// </para>
    ///  
    /// <para>
    /// A fleet may have all of its scaling policies suspended. This operation does not affect
    /// the status of the scaling policies, which remains ACTIVE.
    /// </para>
    /// </summary>
    public partial class DescribeScalingPoliciesRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private int? _limit;
        private string _location;
        private string _nextToken;
        private ScalingStatusType _statusFilter;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet for which to retrieve scaling policies. You can
        /// use either the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Location. 
        /// <para>
        ///  The fleet location. If you don't specify this value, the response contains the scaling
        /// policies of every location in the fleet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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