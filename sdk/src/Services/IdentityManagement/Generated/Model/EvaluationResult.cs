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
    /// Contains the results of a simulation.
    /// 
    ///  
    /// <para>
    /// This data type is used by the return parameter of <code><a>SimulatePolicy</a></code>.
    /// </para>
    /// </summary>
    public partial class EvaluationResult
    {
        private string _evalActionName;
        private PolicyEvaluationDecisionType _evalDecision;
        private Dictionary<string, string> _evalDecisionDetails = new Dictionary<string, string>();
        private string _evalResourceName;
        private List<Statement> _matchedStatements = new List<Statement>();
        private List<string> _missingContextValues = new List<string>();
        private List<ResourceSpecificResult> _resourceSpecificResults = new List<ResourceSpecificResult>();

        /// <summary>
        /// Gets and sets the property EvalActionName. 
        /// <para>
        /// The name of the API action tested on the indicated resource.
        /// </para>
        /// </summary>
        public string EvalActionName
        {
            get { return this._evalActionName; }
            set { this._evalActionName = value; }
        }

        // Check to see if EvalActionName property is set
        internal bool IsSetEvalActionName()
        {
            return this._evalActionName != null;
        }

        /// <summary>
        /// Gets and sets the property EvalDecision. 
        /// <para>
        /// The result of the simulation.
        /// </para>
        /// </summary>
        public PolicyEvaluationDecisionType EvalDecision
        {
            get { return this._evalDecision; }
            set { this._evalDecision = value; }
        }

        // Check to see if EvalDecision property is set
        internal bool IsSetEvalDecision()
        {
            return this._evalDecision != null;
        }

        /// <summary>
        /// Gets and sets the property EvalDecisionDetails. 
        /// <para>
        /// Additional details about the results of the evaluation decision. When there are both
        /// IAM policies and resource policies, this parameter explains how each set of policies
        /// contributes to the final evaluation decision. When simulating cross-account access
        /// to a resource, both the resource-based policy and the caller's IAM policy must grant
        /// access. See <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_compare-resource-policies.html">How
        /// IAM Roles Differ from Resource-based Policies</a>
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
        /// Gets and sets the property EvalResourceName. 
        /// <para>
        /// The ARN of the resource that the indicated API action was tested on.
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
        /// scenario. Remember that even if multiple statements allow the action on the resource,
        /// if only one statement denies that action, then the explicit deny overrides any allow,
        /// and the deny statement is the only entry included in the result.
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
        /// not provided by one of the input parameters. This list is used when the resource in
        /// a simulation is "*", either explicitly, or when the <code>ResourceArns</code> parameter
        /// blank. If you include a list of resources, then any missing context values are instead
        /// included under the <code>ResourceSpecificResults</code> section. To discover the context
        /// keys used by a set of policies, you can call <a>GetContextKeysForCustomPolicy</a>
        /// or <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  <caution> 
        /// <para>
        /// If the response includes any keys in this list, then the reported results might be
        /// untrustworthy because the simulation could not completely evaluate all of the conditions
        /// specified in the policies that would occur in a real world request.
        /// </para>
        ///  </caution>
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

        /// <summary>
        /// Gets and sets the property ResourceSpecificResults. 
        /// <para>
        /// The individual results of the simulation of the API action specified in EvalActionName
        /// on each resource.
        /// </para>
        /// </summary>
        public List<ResourceSpecificResult> ResourceSpecificResults
        {
            get { return this._resourceSpecificResults; }
            set { this._resourceSpecificResults = value; }
        }

        // Check to see if ResourceSpecificResults property is set
        internal bool IsSetResourceSpecificResults()
        {
            return this._resourceSpecificResults != null && this._resourceSpecificResults.Count > 0; 
        }

    }
}