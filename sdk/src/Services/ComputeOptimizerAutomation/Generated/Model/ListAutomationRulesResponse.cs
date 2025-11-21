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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// This is the response object from the ListAutomationRules operation.
    /// </summary>
    public partial class ListAutomationRulesResponse : AmazonWebServiceResponse
    {
        private List<AutomationRule> _automationRules = AWSConfigs.InitializeCollections ? new List<AutomationRule>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutomationRules. 
        /// <para>
        ///  The list of automation rules that match the specified criteria. 
        /// </para>
        /// </summary>
        public List<AutomationRule> AutomationRules
        {
            get { return this._automationRules; }
            set { this._automationRules = value; }
        }

        // Check to see if AutomationRules property is set
        internal bool IsSetAutomationRules()
        {
            return this._automationRules != null && (this._automationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination. If present, indicates there are more results available
        /// and can be used in subsequent requests.
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