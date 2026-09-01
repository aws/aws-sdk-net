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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomDetectionRuleOrgConfiguration operation.
    /// Updates the organization-level configuration for a custom detection rule, including
    /// the mode and include/exclude account lists.
    /// </summary>
    public partial class UpdateCustomDetectionRuleOrgConfigurationRequest : AmazonGuardDutyRequest
    {
        private List<string> _excludeAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssociationMode _mode;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property ExcludeAccountIds. 
        /// <para>
        /// The account IDs to exclude from the organization configuration. Mutually exclusive
        /// with <c>IncludeAccountIds</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public List<string> ExcludeAccountIds
        {
            get { return this._excludeAccountIds; }
            set { this._excludeAccountIds = value; }
        }

        // Check to see if ExcludeAccountIds property is set
        internal bool IsSetExcludeAccountIds()
        {
            return this._excludeAccountIds != null && (this._excludeAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeAccountIds. 
        /// <para>
        /// The account IDs to include in the organization configuration. Mutually exclusive with
        /// <c>ExcludeAccountIds</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50000)]
        public List<string> IncludeAccountIds
        {
            get { return this._includeAccountIds; }
            set { this._includeAccountIds = value; }
        }

        // Check to see if IncludeAccountIds property is set
        internal bool IsSetIncludeAccountIds()
        {
            return this._includeAccountIds != null && (this._includeAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The execution mode of the organization configuration. Valid values: <c>LIVE</c> |
        /// <c>DRY_RUN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The unique identifier for the custom detection rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}