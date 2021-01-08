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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property SamplingRule. 
        /// <para>
        /// The rule definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains one or more tag keys and tag values to attach to an X-Ray sampling
        /// rule. For more information about ways to use tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS resources</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of user-applied tags per resource: 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum tag key length: 128 Unicode characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum tag value length: 256 Unicode characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for key and value: a-z, A-Z, 0-9, space, and the following characters:
        /// _ . : / = + - and @
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't use <code>aws:</code> as a prefix for keys; it's reserved for AWS use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}