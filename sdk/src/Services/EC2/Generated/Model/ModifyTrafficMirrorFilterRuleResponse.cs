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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyTrafficMirrorFilterRule operation.
    /// </summary>
    public partial class ModifyTrafficMirrorFilterRuleResponse : AmazonWebServiceResponse
    {
        private TrafficMirrorFilterRule _trafficMirrorFilterRule;

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterRule. <note> 
        /// <para>
        /// Tags are not returned for ModifyTrafficMirrorFilterRule.
        /// </para>
        ///  </note> 
        /// <para>
        /// A Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorFilterRule TrafficMirrorFilterRule
        {
            get { return this._trafficMirrorFilterRule; }
            set { this._trafficMirrorFilterRule = value; }
        }

        // Check to see if TrafficMirrorFilterRule property is set
        internal bool IsSetTrafficMirrorFilterRule()
        {
            return this._trafficMirrorFilterRule != null;
        }

    }
}