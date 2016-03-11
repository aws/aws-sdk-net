/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of the simulation of a single API action call on a single resource.
    /// 
    ///  
    /// <para>
    /// This data type is used by a member of the <a>EvaluationResult</a> data type.
    /// </para>
    /// </summary>
    public partial class ResourceSpecificResult
    {
        private Dictionary<string, string> _evalDecisionDetails = new Dictionary<string, string>();
        private PolicyEvaluationDecisionType _evalResourceDecision;
        private string _evalResourceName;
        private List<Statement> _matchedStatements = new List<Statement>();
        private List<string> _missingContextValues = new List<string>();

        /// <summary>
        /// Gets and sets the property EvalDecisionDetails. 
        /// <para>
        /// Additional details about the results of the evaluation decision. When there are both
        /// IAM policies and resource policies, this parameter explains how each set of policies
        /// contributes to the final evaluation decision. When simulating cross-account access
        /// to a resource, both the resource-based policy and the caller's IAM policy must grant
        /// access.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EvalDecisionDetails
        {
            get { return this._evalDecisionDetails; }
            set { this._evalDecisionDetails = value; }
        }

        // Check to see if EvalDecisionDetails property is set
        internal bool IsSetEvalDecisionDetails()
        {
            return this._evalDecisionDetails != null && this._evalDecisionDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvalResourceDecision. 
        /// <para>
        /// The result of the simulation of the simulated API action on the resource specified
        /// in <code>EvalResourceName</code>.
        /// </para>
        /// </summary>
        public PolicyEvaluationDecisionType EvalResourceDecision
        {
            get { return this._evalResourceDecision; }
            set { this._evalResourceDecision = value; }
        }

        // Check to see if EvalResourceDecision property is set
        internal bool IsSetEvalResourceDecision()
        {
            return this._evalResourceDecision != null;
        }

        /// <summary>
        /// Gets and sets the property EvalResourceName. 
        /// <para>
        /// The name of the simulated resource, in Amazon Resource Name (ARN) format.
        /// </para>
        /// </summary>
        public string EvalResourceName
        {
            get { return this._evalResourceName; }
            set { this._evalResourceName = value; }
        }

        // Check to see if EvalResourceName property is set
        internal bool IsSetEvalResourceName()
        {
            return this._evalResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property MatchedStatements. 
        /// <para>
        /// A list of the statements in the input policies that determine the result for this
        /// part of the simulation. Remember that even if multiple statements allow the action
        /// on the resource, if <i>any</i> statement denies that action, then the explicit deny
        /// overrides any allow, and the deny statement is the only entry included in the result.
        /// </para>
        /// </summary>
        public List<Statement> MatchedStatements
        {
            get { return this._matchedStatements; }
            set { this._matchedStatements = value; }
        }

        // Check to see if MatchedStatements property is set
        internal bool IsSetMatchedStatements()
        {
            return this._matchedStatements != null && this._matchedStatements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MissingContextValues. 
        /// <para>
        /// A list of context keys that are required by the included input policies but that were
        /// not provided by one of the input parameters. This list is used when a list of ARNs
        /// is included in the <code>ResourceArns</code> parameter instead of "*". If you do not
        /// specify individual resources, by setting <code>ResourceArns</code> to "*" or by not
        /// including the <code>ResourceArns</code> parameter, then any missing context values
        /// are instead included under the <code>EvaluationResults</code> section. To discover
        /// the context keys used by a set of policies, you can call <a>GetContextKeysForCustomPolicy</a>
        /// or <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        /// </summary>
        public List<string> MissingContextValues
        {
            get { return this._missingContextValues; }
            set { this._missingContextValues = value; }
        }

        // Check to see if MissingContextValues property is set
        internal bool IsSetMissingContextValues()
        {
            return this._missingContextValues != null && this._missingContextValues.Count > 0; 
        }

    }
}