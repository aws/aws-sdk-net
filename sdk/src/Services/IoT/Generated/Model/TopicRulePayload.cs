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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a rule.
    /// </summary>
    public partial class TopicRulePayload
    {
        private List<Action> _actions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private string _awsIotSqlVersion;
        private string _description;
        private Action _errorAction;
        private bool? _ruleDisabled;
        private string _sql;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions associated with the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<Action> Actions
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
        /// Gets and sets the property AwsIotSqlVersion. 
        /// <para>
        /// The version of the SQL rules engine to use when evaluating the rule.
        /// </para>
        /// </summary>
        public string AwsIotSqlVersion
        {
            get { return this._awsIotSqlVersion; }
            set { this._awsIotSqlVersion = value; }
        }

        // Check to see if AwsIotSqlVersion property is set
        internal bool IsSetAwsIotSqlVersion()
        {
            return this._awsIotSqlVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorAction. 
        /// <para>
        /// The action to take when an error occurs.
        /// </para>
        /// </summary>
        public Action ErrorAction
        {
            get { return this._errorAction; }
            set { this._errorAction = value; }
        }

        // Check to see if ErrorAction property is set
        internal bool IsSetErrorAction()
        {
            return this._errorAction != null;
        }

        /// <summary>
        /// Gets and sets the property RuleDisabled. 
        /// <para>
        /// Specifies whether the rule is disabled.
        /// </para>
        /// </summary>
        public bool? RuleDisabled
        {
            get { return this._ruleDisabled; }
            set { this._ruleDisabled = value; }
        }

        // Check to see if RuleDisabled property is set
        internal bool IsSetRuleDisabled()
        {
            return this._ruleDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sql. 
        /// <para>
        /// The SQL statement used to query the topic. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-sql-reference.html">IoT
        /// SQL Reference</a> in the <i>IoT Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Sql
        {
            get { return this._sql; }
            set { this._sql = value; }
        }

        // Check to see if Sql property is set
        internal bool IsSetSql()
        {
            return this._sql != null;
        }

    }
}