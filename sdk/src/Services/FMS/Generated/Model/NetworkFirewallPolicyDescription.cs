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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// The definition of the Network Firewall firewall policy.
    /// </summary>
    public partial class NetworkFirewallPolicyDescription
    {
        private List<string> _statefulDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StatefulEngineOptions _statefulEngineOptions;
        private List<StatefulRuleGroup> _statefulRuleGroups = AWSConfigs.InitializeCollections ? new List<StatefulRuleGroup>() : null;
        private List<string> _statelessCustomActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statelessDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statelessFragmentDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<StatelessRuleGroup> _statelessRuleGroups = AWSConfigs.InitializeCollections ? new List<StatelessRuleGroup>() : null;

        /// <summary>
        /// Gets and sets the property StatefulDefaultActions. 
        /// <para>
        /// The default actions to take on a packet that doesn't match any stateful rules. The
        /// stateful default action is optional, and is only valid when using the strict rule
        /// order.
        /// </para>
        ///  
        /// <para>
        ///  Valid values of the stateful default action: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// aws:drop_strict
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:drop_established
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_strict
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_established
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatefulDefaultActions
        {
            get { return this._statefulDefaultActions; }
            set { this._statefulDefaultActions = value; }
        }

        // Check to see if StatefulDefaultActions property is set
        internal bool IsSetStatefulDefaultActions()
        {
            return this._statefulDefaultActions != null && (this._statefulDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatefulEngineOptions. 
        /// <para>
        /// Additional options governing how Network Firewall handles stateful rules. The stateful
        /// rule groups that you use in your policy must have stateful rule options settings that
        /// are compatible with these settings.
        /// </para>
        /// </summary>
        public StatefulEngineOptions StatefulEngineOptions
        {
            get { return this._statefulEngineOptions; }
            set { this._statefulEngineOptions = value; }
        }

        // Check to see if StatefulEngineOptions property is set
        internal bool IsSetStatefulEngineOptions()
        {
            return this._statefulEngineOptions != null;
        }

        /// <summary>
        /// Gets and sets the property StatefulRuleGroups. 
        /// <para>
        /// The stateful rule groups that are used in the Network Firewall firewall policy. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatefulRuleGroup> StatefulRuleGroups
        {
            get { return this._statefulRuleGroups; }
            set { this._statefulRuleGroups = value; }
        }

        // Check to see if StatefulRuleGroups property is set
        internal bool IsSetStatefulRuleGroups()
        {
            return this._statefulRuleGroups != null && (this._statefulRuleGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessCustomActions. 
        /// <para>
        /// Names of custom actions that are available for use in the stateless default actions
        /// settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatelessCustomActions
        {
            get { return this._statelessCustomActions; }
            set { this._statelessCustomActions = value; }
        }

        // Check to see if StatelessCustomActions property is set
        internal bool IsSetStatelessCustomActions()
        {
            return this._statelessCustomActions != null && (this._statelessCustomActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessDefaultActions. 
        /// <para>
        /// The actions to take on packets that don't match any of the stateless rule groups.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatelessDefaultActions
        {
            get { return this._statelessDefaultActions; }
            set { this._statelessDefaultActions = value; }
        }

        // Check to see if StatelessDefaultActions property is set
        internal bool IsSetStatelessDefaultActions()
        {
            return this._statelessDefaultActions != null && (this._statelessDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessFragmentDefaultActions. 
        /// <para>
        /// The actions to take on packet fragments that don't match any of the stateless rule
        /// groups. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatelessFragmentDefaultActions
        {
            get { return this._statelessFragmentDefaultActions; }
            set { this._statelessFragmentDefaultActions = value; }
        }

        // Check to see if StatelessFragmentDefaultActions property is set
        internal bool IsSetStatelessFragmentDefaultActions()
        {
            return this._statelessFragmentDefaultActions != null && (this._statelessFragmentDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessRuleGroups. 
        /// <para>
        /// The stateless rule groups that are used in the Network Firewall firewall policy. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatelessRuleGroup> StatelessRuleGroups
        {
            get { return this._statelessRuleGroups; }
            set { this._statelessRuleGroups = value; }
        }

        // Check to see if StatelessRuleGroups property is set
        internal bool IsSetStatelessRuleGroups()
        {
            return this._statelessRuleGroups != null && (this._statelessRuleGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}