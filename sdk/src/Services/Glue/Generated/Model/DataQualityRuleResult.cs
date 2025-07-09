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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the result of the evaluation of a data quality rule.
    /// </summary>
    public partial class DataQualityRuleResult
    {
        private string _description;
        private Dictionary<string, double> _evaluatedMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private string _evaluatedRule;
        private string _evaluationMessage;
        private string _name;
        private DataQualityRuleResultStatus _result;
        private Dictionary<string, double> _ruleMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property EvaluatedMetrics. 
        /// <para>
        /// A map of metrics associated with the evaluation of the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, double> EvaluatedMetrics
        {
            get { return this._evaluatedMetrics; }
            set { this._evaluatedMetrics = value; }
        }

        // Check to see if EvaluatedMetrics property is set
        internal bool IsSetEvaluatedMetrics()
        {
            return this._evaluatedMetrics != null && (this._evaluatedMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluatedRule. 
        /// <para>
        /// The evaluated rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string EvaluatedRule
        {
            get { return this._evaluatedRule; }
            set { this._evaluatedRule = value; }
        }

        // Check to see if EvaluatedRule property is set
        internal bool IsSetEvaluatedRule()
        {
            return this._evaluatedRule != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMessage. 
        /// <para>
        /// An evaluation message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string EvaluationMessage
        {
            get { return this._evaluationMessage; }
            set { this._evaluationMessage = value; }
        }

        // Check to see if EvaluationMessage property is set
        internal bool IsSetEvaluationMessage()
        {
            return this._evaluationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// A pass or fail status for the rule.
        /// </para>
        /// </summary>
        public DataQualityRuleResultStatus Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property RuleMetrics. 
        /// <para>
        /// A map containing metrics associated with the evaluation of the rule based on row-level
        /// results. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, double> RuleMetrics
        {
            get { return this._ruleMetrics; }
            set { this._ruleMetrics = value; }
        }

        // Check to see if RuleMetrics property is set
        internal bool IsSetRuleMetrics()
        {
            return this._ruleMetrics != null && (this._ruleMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}