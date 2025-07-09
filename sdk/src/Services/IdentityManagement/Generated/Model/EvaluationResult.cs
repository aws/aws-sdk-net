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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the results of a simulation.
    /// 
    ///  
    /// <para>
    /// This data type is used by the return parameter of <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
    /// </c> and <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class EvaluationResult
    {
        private string _evalActionName;
        private PolicyEvaluationDecisionType _evalDecision;
        private Dictionary<string, string> _evalDecisionDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _evalResourceName;
        private List<Statement> _matchedStatements = AWSConfigs.InitializeCollections ? new List<Statement>() : null;
        private List<string> _missingContextValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OrganizationsDecisionDetail _organizationsDecisionDetail;
        private PermissionsBoundaryDecisionDetail _permissionsBoundaryDecisionDetail;
        private List<ResourceSpecificResult> _resourceSpecificResults = AWSConfigs.InitializeCollections ? new List<ResourceSpecificResult>() : null;

        /// <summary>
        /// Gets and sets the property EvalActionName. 
        /// <para>
        /// The name of the API operation tested on the indicated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        [AWSProperty(Required=true)]
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
        /// Additional details about the results of the cross-account evaluation decision. This
        /// parameter is populated for only cross-account simulations. It contains a brief summary
        /// of how each policy type contributes to the final evaluation decision.
        /// </para>
        ///  
        /// <para>
        /// If the simulation evaluates policies within the same account and includes a resource
        /// ARN, then the parameter is present but the response is empty. If the simulation evaluates
        /// policies within the same account and specifies all resources (<c>*</c>), then the
        /// parameter is not returned.
        /// </para>
        ///  
        /// <para>
        /// When you make a cross-account request, Amazon Web Services evaluates the request in
        /// the trusting account and the trusted account. The request is allowed only if both
        /// evaluations return <c>true</c>. For more information about how policies are evaluated,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// policies within a single account</a>.
        /// </para>
        ///  
        /// <para>
        /// If an Organizations SCP included in the evaluation denies access, the simulation ends.
        /// In this case, policy evaluation does not proceed any further and this parameter is
        /// not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EvalDecisionDetails
        {
            get { return this._evalDecisionDetails; }
            set { this._evalDecisionDetails = value; }
        }

        // Check to see if EvalDecisionDetails property is set
        internal bool IsSetEvalDecisionDetails()
        {
            return this._evalDecisionDetails != null && (this._evalDecisionDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvalResourceName. 
        /// <para>
        /// The ARN of the resource that the indicated API operation was tested on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// scenario. Remember that even if multiple statements allow the operation on the resource,
        /// if only one statement denies that operation, then the explicit deny overrides any
        /// allow. In addition, the deny statement is the only entry included in the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Statement> MatchedStatements
        {
            get { return this._matchedStatements; }
            set { this._matchedStatements = value; }
        }

        // Check to see if MatchedStatements property is set
        internal bool IsSetMatchedStatements()
        {
            return this._matchedStatements != null && (this._matchedStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MissingContextValues. 
        /// <para>
        /// A list of context keys that are required by the included input policies but that were
        /// not provided by one of the input parameters. This list is used when the resource in
        /// a simulation is "*", either explicitly, or when the <c>ResourceArns</c> parameter
        /// blank. If you include a list of resources, then any missing context values are instead
        /// included under the <c>ResourceSpecificResults</c> section. To discover the context
        /// keys used by a set of policies, you can call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MissingContextValues
        {
            get { return this._missingContextValues; }
            set { this._missingContextValues = value; }
        }

        // Check to see if MissingContextValues property is set
        internal bool IsSetMissingContextValues()
        {
            return this._missingContextValues != null && (this._missingContextValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationsDecisionDetail. 
        /// <para>
        /// A structure that details how Organizations and its service control policies affect
        /// the results of the simulation. Only applies if the simulated user's account is part
        /// of an organization.
        /// </para>
        /// </summary>
        public OrganizationsDecisionDetail OrganizationsDecisionDetail
        {
            get { return this._organizationsDecisionDetail; }
            set { this._organizationsDecisionDetail = value; }
        }

        // Check to see if OrganizationsDecisionDetail property is set
        internal bool IsSetOrganizationsDecisionDetail()
        {
            return this._organizationsDecisionDetail != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryDecisionDetail. 
        /// <para>
        /// Contains information about the effect that a permissions boundary has on a policy
        /// simulation when the boundary is applied to an IAM entity.
        /// </para>
        /// </summary>
        public PermissionsBoundaryDecisionDetail PermissionsBoundaryDecisionDetail
        {
            get { return this._permissionsBoundaryDecisionDetail; }
            set { this._permissionsBoundaryDecisionDetail = value; }
        }

        // Check to see if PermissionsBoundaryDecisionDetail property is set
        internal bool IsSetPermissionsBoundaryDecisionDetail()
        {
            return this._permissionsBoundaryDecisionDetail != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecificResults. 
        /// <para>
        /// The individual results of the simulation of the API operation specified in EvalActionName
        /// on each resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceSpecificResult> ResourceSpecificResults
        {
            get { return this._resourceSpecificResults; }
            set { this._resourceSpecificResults = value; }
        }

        // Check to see if ResourceSpecificResults property is set
        internal bool IsSetResourceSpecificResults()
        {
            return this._resourceSpecificResults != null && (this._resourceSpecificResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}