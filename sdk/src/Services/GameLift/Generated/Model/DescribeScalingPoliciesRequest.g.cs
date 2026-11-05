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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingPolicies operation. <b>This API
    /// works with the following fleet types:</b> EC2, Container <para> Retrieves all scaling
    /// policies applied to a fleet. </para> <para> To get a fleet's scaling policies, specify
    /// the fleet ID. You can filter this request by policy status, such as to retrieve only
    /// active scaling policies. Use the pagination parameters to retrieve results as a set
    /// of sequential pages. If successful, set of <c>ScalingPolicy</c> objects is returned
    /// for the fleet. </para> <para> A fleet may have all of its scaling policies suspended.
    /// This operation does not affect the status of the scaling policies, which remains ACTIVE.
    /// </para>
    /// </summary>
    public partial class DescribeScalingPoliciesRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet for which to retrieve scaling policies. You can
        /// use either the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The fleet location. If you don't specify this value, the response contains the scaling
        /// policies of every location in the fleet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Scaling policy status to filter results on. A scaling policy is only in force when
        /// in an <c>ACTIVE</c> status.
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
        public ScalingStatusType StatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null;
    }
}
