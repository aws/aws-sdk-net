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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>agentId</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 99)]
        public List<string> AgentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentIds property is set.
        /// </summary>
        internal bool IsSetAgentIds() => this.AgentIds != null && (this.AgentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// For a record to match a filter, the list of values that are specified for this data
        /// type property must be contained in the list of values of the <b>attributes</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Attribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>autoScalingGroup</b>
        /// property of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AutoScalingGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroups() => this.AutoScalingGroups != null && (this.AutoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTimeRange. 
        /// <para>
        /// The time range during which the finding is generated.
        /// </para>
        /// </summary>
        public TimestampRange CreationTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeRange property is set.
        /// </summary>
        internal bool IsSetCreationTimeRange() => this.CreationTimeRange != null;

        /// <summary>
        /// Gets and sets the property RuleNames. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>ruleName</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RuleNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RuleNames property is set.
        /// </summary>
        internal bool IsSetRuleNames() => this.RuleNames != null && (this.RuleNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>rulesPackageArn</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RulesPackageArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RulesPackageArns property is set.
        /// </summary>
        internal bool IsSetRulesPackageArns() => this.RulesPackageArns != null && (this.RulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        /// For a record to match a filter, one of the values that is specified for this data
        /// type property must be the exact match of the value of the <b>severity</b> property
        /// of the <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Severities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Severities property is set.
        /// </summary>
        internal bool IsSetSeverities() => this.Severities != null && (this.Severities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must be contained in the list of values of the <b>userAttributes</b> property of the
        /// <a>Finding</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Attribute> UserAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the UserAttributes property is set.
        /// </summary>
        internal bool IsSetUserAttributes() => this.UserAttributes != null && (this.UserAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
