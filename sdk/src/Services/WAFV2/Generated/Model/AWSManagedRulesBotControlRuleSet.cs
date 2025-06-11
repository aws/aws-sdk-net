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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Details for your use of the Bot Control managed rule group, <c>AWSManagedRulesBotControlRuleSet</c>.
    /// This configuration is used in <c>ManagedRuleGroupConfig</c>. 
    /// 
    ///  
    /// <para>
    /// For additional information about this and the other intelligent threat mitigation
    /// rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-managed-protections">Intelligent
    /// threat mitigation in WAF</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-list">Amazon
    /// Web Services Managed Rules rule groups list</a> in the <i>WAF Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class AWSManagedRulesBotControlRuleSet
    {
        private bool? _enableMachineLearning;
        private InspectionLevel _inspectionLevel;

        /// <summary>
        /// Gets and sets the property EnableMachineLearning. 
        /// <para>
        /// Applies only to the targeted inspection level. 
        /// </para>
        ///  
        /// <para>
        /// Determines whether to use machine learning (ML) to analyze your web traffic for bot-related
        /// activity. Machine learning is required for the Bot Control rules <c>TGT_ML_CoordinatedActivityLow</c>
        /// and <c>TGT_ML_CoordinatedActivityMedium</c>, which inspect for anomalous behavior
        /// that might indicate distributed, coordinated bot activity.
        /// </para>
        ///  
        /// <para>
        /// For more information about this choice, see the listing for these rules in the table
        /// at <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-bot.html#aws-managed-rule-groups-bot-rules">Bot
        /// Control rules listing</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>TRUE</c> 
        /// </para>
        /// </summary>
        public bool? EnableMachineLearning
        {
            get { return this._enableMachineLearning; }
            set { this._enableMachineLearning = value; }
        }

        // Check to see if EnableMachineLearning property is set
        internal bool IsSetEnableMachineLearning()
        {
            return this._enableMachineLearning.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InspectionLevel. 
        /// <para>
        /// The inspection level to use for the Bot Control rule group. The common level is the
        /// least expensive. The targeted level includes all common level rules and adds rules
        /// with more advanced inspection criteria. For details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-bot.html">WAF
        /// Bot Control rule group</a> in the <i>WAF Developer Guide</i>.
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