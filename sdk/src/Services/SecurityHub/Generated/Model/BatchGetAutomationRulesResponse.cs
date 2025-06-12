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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchGetAutomationRules operation.
    /// </summary>
    public partial class BatchGetAutomationRulesResponse : AmazonWebServiceResponse
    {
        private List<AutomationRulesConfig> _rules = AWSConfigs.InitializeCollections ? new List<AutomationRulesConfig>() : null;
        private List<UnprocessedAutomationRule> _unprocessedAutomationRules = AWSConfigs.InitializeCollections ? new List<UnprocessedAutomationRule>() : null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  A list of rule details for the provided rule ARNs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomationRulesConfig> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAutomationRules. 
        /// <para>
        ///  A list of objects containing <c>RuleArn</c>, <c>ErrorCode</c>, and <c>ErrorMessage</c>.
        /// This parameter tells you which automation rules the request didn't retrieve and why.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedAutomationRule> UnprocessedAutomationRules
        {
            get { return this._unprocessedAutomationRules; }
            set { this._unprocessedAutomationRules = value; }
        }

        // Check to see if UnprocessedAutomationRules property is set
        internal bool IsSetUnprocessedAutomationRules()
        {
            return this._unprocessedAutomationRules != null && (this._unprocessedAutomationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}