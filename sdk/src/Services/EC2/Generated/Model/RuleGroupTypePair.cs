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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the type of a stateful rule group.
    /// </summary>
    public partial class RuleGroupTypePair
    {
        private string _ruleGroupArn;
        private string _ruleGroupType;

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The ARN of the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string RuleGroupArn
        {
            get { return this._ruleGroupArn; }
            set { this._ruleGroupArn = value; }
        }

        // Check to see if RuleGroupArn property is set
        internal bool IsSetRuleGroupArn()
        {
            return this._ruleGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupType. 
        /// <para>
        /// The rule group type. The possible values are <code>Domain List</code> and <code>Suricata</code>.
        /// </para>
        /// </summary>
        public string RuleGroupType
        {
            get { return this._ruleGroupType; }
            set { this._ruleGroupType = value; }
        }

        // Check to see if RuleGroupType property is set
        internal bool IsSetRuleGroupType()
        {
            return this._ruleGroupType != null;
        }

    }
}