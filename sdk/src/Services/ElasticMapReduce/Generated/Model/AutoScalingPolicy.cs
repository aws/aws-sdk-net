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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An automatic scaling policy for a core instance group or task instance group in an
    /// Amazon EMR cluster. An automatic scaling policy defines how an instance group dynamically
    /// adds and terminates EC2 instances in response to the value of a CloudWatch metric.
    /// See <a>PutAutoScalingPolicy</a>.
    /// </summary>
    public partial class AutoScalingPolicy
    {
        private ScalingConstraints _constraints;
        private List<ScalingRule> _rules = new List<ScalingRule>();

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// The upper and lower EC2 instance limits for an automatic scaling policy. Automatic
        /// scaling activity will not cause an instance group to grow above or below these limits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingConstraints Constraints
        {
            get { return this._constraints; }
            set { this._constraints = value; }
        }

        // Check to see if Constraints property is set
        internal bool IsSetConstraints()
        {
            return this._constraints != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The scale-in and scale-out rules that comprise the automatic scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ScalingRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}