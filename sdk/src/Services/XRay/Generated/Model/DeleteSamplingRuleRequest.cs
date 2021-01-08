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
    /// Container for the parameters to the DeleteSamplingRule operation.
    /// Deletes a sampling rule.
    /// </summary>
    public partial class DeleteSamplingRuleRequest : AmazonXRayRequest
    {
        private string _ruleARN;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property RuleARN. 
        /// <para>
        /// The ARN of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        public string RuleARN
        {
            get { return this._ruleARN; }
            set { this._ruleARN = value; }
        }

        // Check to see if RuleARN property is set
        internal bool IsSetRuleARN()
        {
            return this._ruleARN != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

    }
}