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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a forward action.
    /// </summary>
    public partial class ForwardActionConfig
    {
        private List<TargetGroupTuple> _targetGroups = new List<TargetGroupTuple>();
        private TargetGroupStickinessConfig _targetGroupStickinessConfig;

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// One or more target groups. For Network Load Balancers, you can specify a single target
        /// group.
        /// </para>
        /// </summary>
        public List<TargetGroupTuple> TargetGroups
        {
            get { return this._targetGroups; }
            set { this._targetGroups = value; }
        }

        // Check to see if TargetGroups property is set
        internal bool IsSetTargetGroups()
        {
            return this._targetGroups != null && this._targetGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupStickinessConfig. 
        /// <para>
        /// The target group stickiness for the rule.
        /// </para>
        /// </summary>
        public TargetGroupStickinessConfig TargetGroupStickinessConfig
        {
            get { return this._targetGroupStickinessConfig; }
            set { this._targetGroupStickinessConfig = value; }
        }

        // Check to see if TargetGroupStickinessConfig property is set
        internal bool IsSetTargetGroupStickinessConfig()
        {
            return this._targetGroupStickinessConfig != null;
        }

    }
}