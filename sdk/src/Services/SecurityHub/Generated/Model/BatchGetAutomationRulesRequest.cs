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
    /// Container for the parameters to the BatchGetAutomationRules operation.
    /// Retrieves a list of details for automation rules based on rule Amazon Resource Names
    /// (ARNs).
    /// </summary>
    public partial class BatchGetAutomationRulesRequest : AmazonSecurityHubRequest
    {
        private List<string> _automationRulesArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutomationRulesArns. 
        /// <para>
        ///  A list of rule ARNs to get details for. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> AutomationRulesArns
        {
            get { return this._automationRulesArns; }
            set { this._automationRulesArns = value; }
        }

        // Check to see if AutomationRulesArns property is set
        internal bool IsSetAutomationRulesArns()
        {
            return this._automationRulesArns != null && (this._automationRulesArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}