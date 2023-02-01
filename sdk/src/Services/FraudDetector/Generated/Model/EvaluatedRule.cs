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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The details of the rule used for evaluating variable values.
    /// </summary>
    public partial class EvaluatedRule
    {
        private bool? _evaluated;
        private string _expression;
        private string _expressionWithValues;
        private bool? _matched;
        private List<string> _outcomes = new List<string>();
        private string _ruleId;
        private string _ruleVersion;

        /// <summary>
        /// Gets and sets the property Evaluated. 
        /// <para>
        ///  Indicates whether the rule was evaluated. 
        /// </para>
        /// </summary>
        public bool Evaluated
        {
            get { return this._evaluated.GetValueOrDefault(); }
            set { this._evaluated = value; }
        }

        // Check to see if Evaluated property is set
        internal bool IsSetEvaluated()
        {
            return this._evaluated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        ///  The rule expression. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionWithValues. 
        /// <para>
        ///  The rule expression value. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ExpressionWithValues
        {
            get { return this._expressionWithValues; }
            set { this._expressionWithValues = value; }
        }

        // Check to see if ExpressionWithValues property is set
        internal bool IsSetExpressionWithValues()
        {
            return this._expressionWithValues != null;
        }

        /// <summary>
        /// Gets and sets the property Matched. 
        /// <para>
        ///  Indicates whether the rule matched. 
        /// </para>
        /// </summary>
        public bool Matched
        {
            get { return this._matched.GetValueOrDefault(); }
            set { this._matched = value; }
        }

        // Check to see if Matched property is set
        internal bool IsSetMatched()
        {
            return this._matched.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Outcomes. 
        /// <para>
        ///  The rule outcome. 
        /// </para>
        /// </summary>
        public List<string> Outcomes
        {
            get { return this._outcomes; }
            set { this._outcomes = value; }
        }

        // Check to see if Outcomes property is set
        internal bool IsSetOutcomes()
        {
            return this._outcomes != null && this._outcomes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        ///  The rule ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property RuleVersion. 
        /// <para>
        ///  The rule version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string RuleVersion
        {
            get { return this._ruleVersion; }
            set { this._ruleVersion = value; }
        }

        // Check to see if RuleVersion property is set
        internal bool IsSetRuleVersion()
        {
            return this._ruleVersion != null;
        }

    }
}