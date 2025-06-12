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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as a request parameter in the <a>ListFindings</a> action.
    /// </summary>
    public partial class FindingFilter
    {
        private List<string> _agentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private List<string> _autoScalingGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TimestampRange _creationTimeRange;
        private List<string> _ruleNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _rulesPackageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _severities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Attribute> _userAttributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>agentId</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=99)]
        public List<string> AgentIds
        {
            get { return this._agentIds; }
            set { this._agentIds = value; }
        }

        // Check to see if AgentIds property is set
        internal bool IsSetAgentIds()
        {
            return this._agentIds != null && (this._agentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// For a record to match a filter, the list of values that are specified for this data
        /// type property must be contained in the list of values of the <b>attributes</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>autoScalingGroup</b>
        /// property of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && (this._autoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeRange. 
        /// <para>
        /// The time range during which the finding is generated.
        /// </para>
        /// </summary>
        public TimestampRange CreationTimeRange
        {
            get { return this._creationTimeRange; }
            set { this._creationTimeRange = value; }
        }

        // Check to see if CreationTimeRange property is set
        internal bool IsSetCreationTimeRange()
        {
            return this._creationTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNames. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>ruleName</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RuleNames
        {
            get { return this._ruleNames; }
            set { this._ruleNames = value; }
        }

        // Check to see if RuleNames property is set
        internal bool IsSetRuleNames()
        {
            return this._ruleNames != null && (this._ruleNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>rulesPackageArn</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && (this._rulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>severity</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Severities
        {
            get { return this._severities; }
            set { this._severities = value; }
        }

        // Check to see if Severities property is set
        internal bool IsSetSeverities()
        {
            return this._severities != null && (this._severities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must be contained in the list of values of the <b>userAttributes</b> property of the
        /// <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Attribute> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && (this._userAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}