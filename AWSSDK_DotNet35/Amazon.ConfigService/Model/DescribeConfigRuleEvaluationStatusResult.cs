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
    /// 
    /// </summary>
    public partial class DescribeConfigRuleEvaluationStatusResult : AmazonWebServiceResponse
    {
        private List<ConfigRuleEvaluationStatus> _configRulesEvaluationStatus = new List<ConfigRuleEvaluationStatus>();

        /// <summary>
        /// Gets and sets the property ConfigRulesEvaluationStatus. 
        /// <para>
        /// Status information about your AWS managed Config rules.
        /// </para>
        /// </summary>
        public List<ConfigRuleEvaluationStatus> ConfigRulesEvaluationStatus
        {
            get { return this._configRulesEvaluationStatus; }
            set { this._configRulesEvaluationStatus = value; }
        }

        // Check to see if ConfigRulesEvaluationStatus property is set
        internal bool IsSetConfigRulesEvaluationStatus()
        {
            return this._configRulesEvaluationStatus != null && this._configRulesEvaluationStatus.Count > 0; 
        }

    }
}