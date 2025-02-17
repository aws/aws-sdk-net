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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Summary information of this case rule. In the Amazon Connect admin website, case rules
    /// are known as <i>case field conditions</i>. For more information about case field conditions,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class CaseRuleSummary
    {
        private string _caseRuleArn;
        private string _caseRuleId;
        private string _description;
        private string _name;
        private RuleType _ruleType;

        /// <summary>
        /// Gets and sets the property CaseRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the case rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseRuleArn
        {
            get { return this._caseRuleArn; }
            set { this._caseRuleArn = value; }
        }

        // Check to see if CaseRuleArn property is set
        internal bool IsSetCaseRuleArn()
        {
            return this._caseRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CaseRuleId. 
        /// <para>
        /// Unique identifier of a case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseRuleId
        {
            get { return this._caseRuleId; }
            set { this._caseRuleId = value; }
        }

        // Check to see if CaseRuleId property is set
        internal bool IsSetCaseRuleId()
        {
            return this._caseRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of a case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property RuleType. 
        /// <para>
        /// Possible types for a rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleType RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

    }
}