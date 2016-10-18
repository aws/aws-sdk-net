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
    /// Container for the parameters to the DescribeConfigRuleEvaluationStatus operation.
    /// Returns status information for each of your AWS managed Config rules. The status includes
    /// information such as the last time AWS Config invoked the rule, the last time AWS Config
    /// failed to invoke the rule, and the related error for the last failure.
    /// </summary>
    public partial class DescribeConfigRuleEvaluationStatusRequest : AmazonConfigServiceRequest
    {
        private List<string> _configRuleNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// The name of the AWS managed Config rules for which you want status information. If
        /// you do not specify any names, AWS Config returns status information for all AWS managed
        /// Config rules that you use.
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