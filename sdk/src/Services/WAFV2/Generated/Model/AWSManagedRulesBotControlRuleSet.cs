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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Details for your use of the Bot Control managed rule group, <code>AWSManagedRulesBotControlRuleSet</code>.
    /// This configuration is used in <code>ManagedRuleGroupConfig</code>.
    /// </summary>
    public partial class AWSManagedRulesBotControlRuleSet
    {
        private InspectionLevel _inspectionLevel;

        /// <summary>
        /// Gets and sets the property InspectionLevel. 
        /// <para>
        /// The inspection level to use for the Bot Control rule group. The common level is the
        /// least expensive. The targeted level includes all common level rules and adds rules
        /// with more advanced inspection criteria. For details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-bot.html">WAF
        /// Bot Control rule group</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InspectionLevel InspectionLevel
        {
            get { return this._inspectionLevel; }
            set { this._inspectionLevel = value; }
        }

        // Check to see if InspectionLevel property is set
        internal bool IsSetInspectionLevel()
        {
            return this._inspectionLevel != null;
        }

    }
}