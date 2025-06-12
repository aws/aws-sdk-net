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
    /// Container for the parameters to the BatchUpdateAutomationRules operation.
    /// Updates one or more automation rules based on rule Amazon Resource Names (ARNs) and
    /// input parameters.
    /// </summary>
    public partial class BatchUpdateAutomationRulesRequest : AmazonSecurityHubRequest
    {
        private List<UpdateAutomationRulesRequestItem> _updateAutomationRulesRequestItems = AWSConfigs.InitializeCollections ? new List<UpdateAutomationRulesRequestItem>() : null;

        /// <summary>
        /// Gets and sets the property UpdateAutomationRulesRequestItems. 
        /// <para>
        ///  An array of ARNs for the rules that are to be updated. Optionally, you can also include
        /// <c>RuleStatus</c> and <c>RuleOrder</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<UpdateAutomationRulesRequestItem> UpdateAutomationRulesRequestItems
        {
            get { return this._updateAutomationRulesRequestItems; }
            set { this._updateAutomationRulesRequestItems = value; }
        }

        // Check to see if UpdateAutomationRulesRequestItems property is set
        internal bool IsSetUpdateAutomationRulesRequestItems()
        {
            return this._updateAutomationRulesRequestItems != null && (this._updateAutomationRulesRequestItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}