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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A configured table analysis rule, which limits how data for this table can be used.
    /// </summary>
    public partial class ConfiguredTableAnalysisRule
    {
        private string _configuredTableArn;
        private string _configuredTableId;
        private DateTime? _createTime;
        private ConfiguredTableAnalysisRulePolicy _policy;
        private ConfiguredTableAnalysisRuleType _type;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property ConfiguredTableArn. 
        /// <para>
        /// The unique ARN for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string ConfiguredTableArn
        {
            get { return this._configuredTableArn; }
            set { this._configuredTableArn = value; }
        }

        // Check to see if ConfiguredTableArn property is set
        internal bool IsSetConfiguredTableArn()
        {
            return this._configuredTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredTableId. 
        /// <para>
        /// The unique ID for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConfiguredTableId
        {
            get { return this._configuredTableId; }
            set { this._configuredTableId = value; }
        }

        // Check to see if ConfiguredTableId property is set
        internal bool IsSetConfiguredTableId()
        {
            return this._configuredTableId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the configured table analysis rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy that controls SQL query rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAnalysisRulePolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of configured table analysis rule. Valid values are `AGGREGATION` and `LIST`.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAnalysisRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the configured table analysis rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}