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
    /// The definition of the stateless rule.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleDefinition
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RuleGroupSourceStatelessRuleMatchAttributes _matchAttributes;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to take on a packet that matches one of the stateless rule definition's
        /// match attributes. You must specify a standard action (<c>aws:pass</c>, <c>aws:drop</c>,
        /// or <c>aws:forward_to_sfe</c>). You can then add custom actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchAttributes. 
        /// <para>
        /// The criteria for Network Firewall to use to inspect an individual packet in a stateless
        /// rule inspection.
        /// </para>
        /// </summary>
        public RuleGroupSourceStatelessRuleMatchAttributes MatchAttributes
        {
            get { return this._matchAttributes; }
            set { this._matchAttributes = value; }
        }

        // Check to see if MatchAttributes property is set
        internal bool IsSetMatchAttributes()
        {
            return this._matchAttributes != null;
        }

    }
}