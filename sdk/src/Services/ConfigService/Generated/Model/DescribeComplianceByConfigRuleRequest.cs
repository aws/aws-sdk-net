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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeComplianceByConfigRule operation.
    /// Indicates whether the specified Config rules are compliant. If a rule is noncompliant,
    /// this action returns the number of Amazon Web Services resources that do not comply
    /// with the rule.
    /// 
    ///  
    /// <para>
    /// A rule is compliant if all of the evaluated resources comply with it. It is noncompliant
    /// if any of these resources do not comply.
    /// </para>
    ///  
    /// <para>
    /// If Config has no current evaluation results for the rule, it returns <code>INSUFFICIENT_DATA</code>.
    /// This result might indicate one of the following conditions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Config has never invoked an evaluation for the rule. To check whether it has, use
    /// the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
    /// and <code>LastFailedInvocationTime</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The rule's Lambda function is failing to send evaluation results to Config. Verify
    /// that the role you assigned to your configuration recorder includes the <code>config:PutEvaluations</code>
    /// permission. If the rule is a custom rule, verify that the Lambda execution role includes
    /// the <code>config:PutEvaluations</code> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The rule's Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
    /// results. This can occur if the resources were deleted or removed from the rule's scope.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeComplianceByConfigRuleRequest : AmazonConfigServiceRequest
    {
        private List<string> _complianceTypes = new List<string>();
        private List<string> _configRuleNames = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComplianceTypes. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> ComplianceTypes
        {
            get { return this._complianceTypes; }
            set { this._complianceTypes = value; }
        }

        // Check to see if ComplianceTypes property is set
        internal bool IsSetComplianceTypes()
        {
            return this._complianceTypes != null && this._complianceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// Specify one or more Config rule names to filter the results by rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> ConfigRuleNames
        {
            get { return this._configRuleNames; }
            set { this._configRuleNames = value; }
        }

        // Check to see if ConfigRuleNames property is set
        internal bool IsSetConfigRuleNames()
        {
            return this._configRuleNames != null && this._configRuleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}