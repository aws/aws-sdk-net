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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes a forward action. You can use forward actions to route requests to one or
    /// more target groups.
    /// </summary>
    public partial class ForwardAction
    {
        private List<WeightedTargetGroup> _targetGroups = new List<WeightedTargetGroup>();

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// The target groups. Traffic matching the rule is forwarded to the specified target
        /// groups. With forward actions, you can assign a weight that controls the prioritization
        /// and selection of each target group. This means that requests are distributed to individual
        /// target groups based on their weights. For example, if two target groups have the same
        /// weight, each target group receives half of the traffic.
        /// </para>
        ///  
        /// <para>
        /// The default value is 1. This means that if only one target group is provided, there
        /// is no need to set the weight; 100% of traffic will go to that target group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<WeightedTargetGroup> TargetGroups
        {
            get { return this._targetGroups; }
            set { this._targetGroups = value; }
        }

        // Check to see if TargetGroups property is set
        internal bool IsSetTargetGroups()
        {
            return this._targetGroups != null && this._targetGroups.Count > 0; 
        }

    }
}