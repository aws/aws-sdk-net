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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The details of the rule used for evaluating variable values.
    /// </summary>
    public partial class EvaluatedRule
    {
        /// <summary>
        /// Gets and sets the property Evaluated. 
        /// <para>
        ///  Indicates whether the rule was evaluated. 
        /// </para>
        /// </summary>
        public bool? Evaluated { get; set; }

        /// <summary>
        /// Checks to see if the Evaluated property is set.
        /// </summary>
        internal bool IsSetEvaluated() => this.Evaluated.HasValue;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        ///  The rule expression. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property ExpressionWithValues. 
        /// <para>
        ///  The rule expression value. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ExpressionWithValues { get; set; }

        /// <summary>
        /// Checks to see if the ExpressionWithValues property is set.
        /// </summary>
        internal bool IsSetExpressionWithValues() => this.ExpressionWithValues != null;

        /// <summary>
        /// Gets and sets the property Matched. 
        /// <para>
        ///  Indicates whether the rule matched. 
        /// </para>
        /// </summary>
        public bool? Matched { get; set; }

        /// <summary>
        /// Checks to see if the Matched property is set.
        /// </summary>
        internal bool IsSetMatched() => this.Matched.HasValue;

        /// <summary>
        /// Gets and sets the property Outcomes. 
        /// <para>
        ///  The rule outcome. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Outcomes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Outcomes property is set.
        /// </summary>
        internal bool IsSetOutcomes() => this.Outcomes != null && (this.Outcomes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        ///  The rule ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;

        /// <summary>
        /// Gets and sets the property RuleVersion. 
        /// <para>
        ///  The rule version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string RuleVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuleVersion property is set.
        /// </summary>
        internal bool IsSetRuleVersion() => this.RuleVersion != null;
    }
}
