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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartConfigRulesEvaluation operation.
    /// Evaluates your resources against the specified Config rules. You can specify up to
    /// 25 Config rules per request.
    /// 
    ///  
    /// <para>
    /// An existing <a>StartConfigRulesEvaluation</a> call must complete for the specified
    /// rules before you can call the API again. If you chose to have AWS Config stream to
    /// an Amazon SNS topic, you will receive a <code>ConfigRuleEvaluationStarted</code> notification
    /// when the evaluation starts.
    /// </para>
    ///  <note> 
    /// <para>
    /// You don't need to call the <code>StartConfigRulesEvaluation</code> API to run an evaluation
    /// for a new rule. When you create a new rule, AWS Config automatically evaluates your
    /// resources against the rule. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>StartConfigRulesEvaluation</code> API is useful if you want to run on-demand
    /// evaluations, such as the following example:
    /// </para>
    ///  <ol> <li>
    /// <para>
    /// You have a custom rule that evaluates your IAM resources every 24 hours.
    /// </para>
    /// </li> <li>
    /// <para>
    /// You update your Lambda function to add additional conditions to your rule.
    /// </para>
    /// </li> <li>
    /// <para>
    /// Instead of waiting for the next periodic evaluation, you call the <code>StartConfigRulesEvaluation</code>
    /// API.
    /// </para>
    /// </li> <li>
    /// <para>
    /// AWS Config invokes your Lambda function and evaluates your IAM resources.
    /// </para>
    /// </li> <li>
    /// <para>
    /// Your custom rule will still run periodic evaluations every 24 hours.
    /// </para>
    /// </li> </ol>
    /// </summary>
    public partial class StartConfigRulesEvaluationRequest : AmazonConfigServiceRequest
    {
        private List<string> _configRuleNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// The list of names of Config rules that you want to run evaluations for.
        /// </para>
        /// </summary>
        public List<string> ConfigRuleNames
        {
            get { return this._configRuleNames; }
            set { this._configRuleNames = value; }
        }

        // Check to see if ConfigRuleNames property is set
        internal bool IsSetConfigRuleNames()
        {
            return this._configRuleNames != null && this._configRuleNames.Count > 0; 
        }

    }
}