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
    /// This is the response object from the ListAutomationRules operation.
    /// </summary>
    public partial class ListAutomationRulesResponse : AmazonWebServiceResponse
    {
        private List<AutomationRulesMetadata> _automationRulesMetadata = new List<AutomationRulesMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutomationRulesMetadata. 
        /// <para>
        ///  Metadata for rules in the calling account. The response includes rules with a <code>RuleStatus</code>
        /// of <code>ENABLED</code> and <code>DISABLED</code>. 
        /// </para>
        /// </summary>
        public List<AutomationRulesMetadata> AutomationRulesMetadata
        {
            get { return this._automationRulesMetadata; }
            set { this._automationRulesMetadata = value; }
        }

        // Check to see if AutomationRulesMetadata property is set
        internal bool IsSetAutomationRulesMetadata()
        {
            return this._automationRulesMetadata != null && this._automationRulesMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token for the response. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}