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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a test scenario used to validate an Automated Reasoning policy, including
    /// the test conditions and expected outcomes.
    /// </summary>
    public partial class AutomatedReasoningPolicyScenario
    {
        private string _alternateExpression;
        private AutomatedReasoningCheckResult _expectedResult;
        private string _expression;
        private List<string> _ruleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AlternateExpression. 
        /// <para>
        /// An alternative way to express the same test scenario, used for validation and comparison
        /// purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1024)]
        public string AlternateExpression
        {
            get { return this._alternateExpression; }
            set { this._alternateExpression = value; }
        }

        // Check to see if AlternateExpression property is set
        internal bool IsSetAlternateExpression()
        {
            return this._alternateExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedResult. 
        /// <para>
        /// The expected outcome when this scenario is evaluated against the policy (e.g., PASS,
        /// FAIL, VIOLATION).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningCheckResult ExpectedResult
        {
            get { return this._expectedResult; }
            set { this._expectedResult = value; }
        }

        // Check to see if ExpectedResult property is set
        internal bool IsSetExpectedResult()
        {
            return this._expectedResult != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The logical expression or condition that defines this test scenario.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1024)]
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
        /// Gets and sets the property RuleIds. 
        /// <para>
        /// The list of rule identifiers that are expected to be triggered or evaluated by this
        /// test scenario.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> RuleIds
        {
            get { return this._ruleIds; }
            set { this._ruleIds = value; }
        }

        // Check to see if RuleIds property is set
        internal bool IsSetRuleIds()
        {
            return this._ruleIds != null && (this._ruleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}