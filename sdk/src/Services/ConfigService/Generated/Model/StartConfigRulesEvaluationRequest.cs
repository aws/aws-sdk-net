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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartConfigRulesEvaluation operation.
    /// Runs an on-demand evaluation for the specified Config rules against the last known
    /// configuration state of the resources. Use <c>StartConfigRulesEvaluation</c> when you
    /// want to test that a rule you updated is working as expected. <c>StartConfigRulesEvaluation</c>
    /// does not re-record the latest configuration state for your resources. It re-runs an
    /// evaluation against the last known state of your resources. 
    /// 
    ///  
    /// <para>
    /// You can specify up to 25 Config rules per request. 
    /// </para>
    ///  
    /// <para>
    /// An existing <c>StartConfigRulesEvaluation</c> call for the specified rules must complete
    /// before you can call the API again. If you chose to have Config stream to an Amazon
    /// SNS topic, you will receive a <c>ConfigRuleEvaluationStarted</c> notification when
    /// the evaluation starts.
    /// </para>
    ///  <note> 
    /// <para>
    /// You don't need to call the <c>StartConfigRulesEvaluation</c> API to run an evaluation
    /// for a new rule. When you create a rule, Config evaluates your resources against the
    /// rule automatically. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The <c>StartConfigRulesEvaluation</c> API is useful if you want to run on-demand evaluations,
    /// such as the following example:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You have a custom rule that evaluates your IAM resources every 24 hours.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You update your Lambda function to add additional conditions to your rule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instead of waiting for the next periodic evaluation, you call the <c>StartConfigRulesEvaluation</c>
    /// API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Config invokes your Lambda function and evaluates your IAM resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your custom rule will still run periodic evaluations every 24 hours.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class StartConfigRulesEvaluationRequest : AmazonConfigServiceRequest
    {
        private List<string> _configRuleNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// The list of names of Config rules that you want to run evaluations for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> ConfigRuleNames
        {
            get { return this._configRuleNames; }
            set { this._configRuleNames = value; }
        }

        // Check to see if ConfigRuleNames property is set
        internal bool IsSetConfigRuleNames()
        {
            return this._configRuleNames != null && (this._configRuleNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}