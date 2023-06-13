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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateAutomationRules operation.
    /// </summary>
    public partial class BatchUpdateAutomationRulesResponse : AmazonWebServiceResponse
    {
        private List<string> _processedAutomationRules = new List<string>();
        private List<UnprocessedAutomationRule> _unprocessedAutomationRules = new List<UnprocessedAutomationRule>();

        /// <summary>
        /// Gets and sets the property ProcessedAutomationRules. 
        /// <para>
        ///  A list of properly processed rule ARNs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ProcessedAutomationRules
        {
            get { return this._processedAutomationRules; }
            set { this._processedAutomationRules = value; }
        }

        // Check to see if ProcessedAutomationRules property is set
        internal bool IsSetProcessedAutomationRules()
        {
            return this._processedAutomationRules != null && this._processedAutomationRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAutomationRules. 
        /// <para>
        ///  A list of objects containing <code>RuleArn</code>, <code>ErrorCode</code>, and <code>ErrorMessage</code>.
        /// This parameter tells you which automation rules the request didn't update and why.
        /// 
        /// </para>
        /// </summary>
        public List<UnprocessedAutomationRule> UnprocessedAutomationRules
        {
            get { return this._unprocessedAutomationRules; }
            set { this._unprocessedAutomationRules = value; }
        }

        // Check to see if UnprocessedAutomationRules property is set
        internal bool IsSetUnprocessedAutomationRules()
        {
            return this._unprocessedAutomationRules != null && this._unprocessedAutomationRules.Count > 0; 
        }

    }
}