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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSamplingRule operation.
    /// Creates a rule to control sampling behavior for instrumented applications. Services
    /// retrieve rules with <a>GetSamplingRules</a>, and evaluate each rule in ascending order
    /// of <i>priority</i> for each request. If a rule matches, the service records a trace,
    /// borrowing it from the reservoir size. After 10 seconds, the service reports back to
    /// X-Ray with <a>GetSamplingTargets</a> to get updated versions of each in-use rule.
    /// The updated rule contains a trace quota that the service can use instead of borrowing
    /// from the reservoir.
    /// </summary>
    public partial class CreateSamplingRuleRequest : AmazonXRayRequest
    {
        private SamplingRule _samplingRule;

        /// <summary>
        /// Gets and sets the property SamplingRule. 
        /// <para>
        /// The rule definition.
        /// </para>
        /// </summary>
        public SamplingRule SamplingRule
        {
            get { return this._samplingRule; }
            set { this._samplingRule = value; }
        }

        // Check to see if SamplingRule property is set
        internal bool IsSetSamplingRule()
        {
            return this._samplingRule != null;
        }

    }
}