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
    ///  <important> 
    /// <para>
    /// The simulator now returns a single <c>EvaluationResult</c> per action, regardless
    /// of how many resource ARNs are provided. Previously, simulating one action against
    /// N resources returned N evaluation results, each containing the same aggregate decision.
    /// The top-level fields (<c>EvalDecision</c>, <c>MatchedStatements</c>, <c>MissingContextValues</c>,
    /// <c>EvalDecisionDetails</c>) now represent the <i>aggregate</i> decision across all
    /// requested resources. The top-level <c>EvalDecision</c> reflects the most restrictive
    /// decision across all resources (for example, if any resource produces <c>explicitDeny</c>,
    /// the top-level decision is <c>explicitDeny</c>).
    /// </para>
    ///  
    /// <para>
    /// To see the decision for each individual resource, use <c>ResourceSpecificResults</c>.
    /// If your application parses evaluation results per resource ARN, update your code to
    /// read per-resource decisions from <c>ResourceSpecificResults</c> rather than from the
    /// top-level result.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class EvaluationResult
    {
        /// <summary>
        /// Gets and sets the property EvalActionName. 
        /// <para>
        /// The name of the API operation tested on the indicated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 128)]
        public string EvalActionName { get; set; }

        /// <summary>
        /// Checks to see if the EvalActionName property is set.
        /// </summary>
        internal bool IsSetEvalActionName() => this.EvalActionName != null;

        /// <summary>
        /// Gets and sets the property EvalDecision. 
        /// <para>
        /// The result of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyEvaluationDecisionType EvalDecision { get; set; }

        /// <summary>
        /// Checks to see if the EvalDecision property is set.
        /// </summary>
        internal bool IsSetEvalDecision() => this.EvalDecision != null;

        /// <summary>
        /// Gets and sets the property EvalDecisionDetails. 
        /// <para>
        /// Additional details about the results of the cross-account evaluation decision. This
        /// parameter is populated for only cross-account simulations. It contains a brief summary
        /// of how each policy type contributes to the final evaluation decision.
        /// </para>
        ///  
        /// <para>
        /// In the top-level result, this map reports the most restrictive decision per policy
        /// type across all requested resources.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EvalDecisionDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EvalDecisionDetails property is set.
        /// </summary>
        internal bool IsSetEvalDecisionDetails() => this.EvalDecisionDetails != null && (this.EvalDecisionDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvalResourceName. 
        /// <para>
        /// The ARN template for the simulated resource type (for example, <c>arn:${Partition}:s3:::${BucketName}/${KeyName}</c>),
        /// or <c>*</c> if no ARN format is defined for the action. This is not a specific customer-provided
        /// resource ARN. To find the decision for a specific resource, use <c>ResourceSpecificResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you previously relied on <c>EvalResourceName</c> to identify which specific resource
        /// a result applies to, you must now use the <c>EvalResourceName</c> field within individual
        /// entries in <c>ResourceSpecificResults</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EvalResourceName { get; set; }

        /// <summary>
        /// Checks to see if the EvalResourceName property is set.
        /// </summary>
        internal bool IsSetEvalResourceName() => this.EvalResourceName != null;

        /// <summary>
        /// Gets and sets the property MatchedStatements. 
        /// <para>
        /// A list of the statements in the input policies that determine the result for this
        /// scenario. Remember that even if multiple statements allow the operation on the resource,
        /// if only one statement denies that operation, then the explicit deny overrides any
        /// allow. In addition, the deny statement is the only entry included in the result.
        /// </para>
        ///  
        /// <para>
        /// In the top-level result, this field contains the union of matched statements across
        /// all requested resources. Only statements that contributed to the reported decision
        /// are included. For per-resource matched statements, see <c>ResourceSpecificResults</c>.
        /// This field doesn't include statements from service control policies (SCPs). Only statements
        /// from identity-based and resource-based policies appear here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Statement> MatchedStatements { get; set; } = AWSConfigs.InitializeCollections ? new List<Statement>() : null;

        /// <summary>
        /// Checks to see if the MatchedStatements property is set.
        /// </summary>
        internal bool IsSetMatchedStatements() => this.MatchedStatements != null && (this.MatchedStatements.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  
        /// <para>
        /// In the top-level result, this field contains the deduplicated set of missing context
        /// values across all requested resources. This field doesn't include context keys referenced
        /// by service control policies (SCPs). Only context keys referenced by identity-based
        /// and resource-based policies appear here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MissingContextValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MissingContextValues property is set.
        /// </summary>
        internal bool IsSetMissingContextValues() => this.MissingContextValues != null && (this.MissingContextValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationsDecisionDetail. 
        /// <para>
        /// A structure that details how Organizations and its service control policies affect
        /// the results of the simulation. Only applies if the simulated user's account is part
        /// of an organization.
        /// </para>
        ///  
        /// <para>
        /// For resources that don't support organization-level evaluation, this field is omitted
        /// from the top-level result. For per-resource details, see <c>ResourceSpecificResults</c>.
        /// </para>
        /// </summary>
        public OrganizationsDecisionDetail OrganizationsDecisionDetail { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationsDecisionDetail property is set.
        /// </summary>
        internal bool IsSetOrganizationsDecisionDetail() => this.OrganizationsDecisionDetail != null;

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryDecisionDetail. 
        /// <para>
        /// Contains information about the effect that a permissions boundary has on a policy
        /// simulation when the boundary is applied to an IAM entity.
        /// </para>
        /// </summary>
        public PermissionsBoundaryDecisionDetail PermissionsBoundaryDecisionDetail { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundaryDecisionDetail property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundaryDecisionDetail() => this.PermissionsBoundaryDecisionDetail != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecificResults. 
        /// <para>
        /// The individual results of the simulation of the API operation specified in EvalActionName
        /// on each resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceSpecificResult> ResourceSpecificResults { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceSpecificResult>() : null;

        /// <summary>
        /// Checks to see if the ResourceSpecificResults property is set.
        /// </summary>
        internal bool IsSetResourceSpecificResults() => this.ResourceSpecificResults != null && (this.ResourceSpecificResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
