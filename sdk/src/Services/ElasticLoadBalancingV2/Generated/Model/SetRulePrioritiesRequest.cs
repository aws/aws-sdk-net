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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the SetRulePriorities operation.
    /// Sets the priorities of the specified rules.
    /// 
    ///  
    /// <para>
    /// You can reorder the rules as long as there are no priority conflicts in the new order.
    /// Any existing rules that you do not specify retain their current priority.
    /// </para>
    /// </summary>
    public partial class SetRulePrioritiesRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<RulePriorityPair> _rulePriorities = new List<RulePriorityPair>();

        /// <summary>
        /// Gets and sets the property RulePriorities. 
        /// <para>
        /// The rule priorities.
        /// </para>
        /// </summary>
        public List<RulePriorityPair> RulePriorities
        {
            get { return this._rulePriorities; }
            set { this._rulePriorities = value; }
        }

        // Check to see if RulePriorities property is set
        internal bool IsSetRulePriorities()
        {
            return this._rulePriorities != null && this._rulePriorities.Count > 0; 
        }

    }
}