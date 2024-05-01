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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// A structure that contains the name and configuration information of a late data rule.
    /// </summary>
    public partial class LateDataRule
    {
        private LateDataRuleConfiguration _ruleConfiguration;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property RuleConfiguration. 
        /// <para>
        /// The information needed to configure the late data rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LateDataRuleConfiguration RuleConfiguration
        {
            get { return this._ruleConfiguration; }
            set { this._ruleConfiguration = value; }
        }

        // Check to see if RuleConfiguration property is set
        internal bool IsSetRuleConfiguration()
        {
            return this._ruleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the late data rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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