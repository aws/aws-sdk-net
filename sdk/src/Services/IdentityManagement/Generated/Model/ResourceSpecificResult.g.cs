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
    /// Contains the result of the simulation of a single API operation call on a single resource.
    /// 
    ///  
    /// <para>
    /// This data type is used by a member of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_EvaluationResult.html">EvaluationResult</a>
    /// data type.
    /// </para>
    /// </summary>
    public partial class ResourceSpecificResult
    {
        /// <summary>
        /// Gets and sets the property EvalDecisionDetails. 
        /// <para>
        /// Additional details about the results of the evaluation decision on a single resource.
        /// This parameter is returned only for cross-account simulations. This parameter explains
        /// how each policy type contributes to the resource-specific evaluation decision.
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
        /// Gets and sets the property EvalResourceDecision. 
        /// <para>
        /// The result of the simulation of the simulated API operation on the resource specified
        /// in <c>EvalResourceName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyEvaluationDecisionType EvalResourceDecision { get; set; }

        /// <summary>
        /// Checks to see if the EvalResourceDecision property is set.
        /// </summary>
        internal bool IsSetEvalResourceDecision() => this.EvalResourceDecision != null;

        /// <summary>
        /// Gets and sets the property EvalResourceName. 
        /// <para>
        /// The name of the simulated resource, in Amazon Resource Name (ARN) format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EvalResourceName { get; set; }

        /// <summary>
        /// Checks to see if the EvalResourceName property is set.
        /// </summary>
        internal bool IsSetEvalResourceName() => this.EvalResourceName != null;

        /// <summary>
        /// Gets and sets the property MatchedStatements. 
        /// <para>
        /// A list of the statements in the input policies that determine the result for this
        /// part of the simulation. Remember that even if multiple statements allow the operation
        /// on the resource, if <i>any</i> statement denies that operation, then the explicit
        /// deny overrides any allow. In addition, the deny statement is the only entry included
        /// in the result.
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
        /// not provided by one of the input parameters. This list is used when a list of ARNs
        /// is included in the <c>ResourceArns</c> parameter instead of "*". If you do not specify
        /// individual resources, by setting <c>ResourceArns</c> to "*" or by not including the
        /// <c>ResourceArns</c> parameter, then any missing context values are instead included
        /// under the <c>EvaluationResults</c> section. To discover the context keys used by a
        /// set of policies, you can call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
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
        /// Gets and sets the property PermissionsBoundaryDecisionDetail. 
        /// <para>
        /// Contains information about the effect that a permissions boundary has on a policy
        /// simulation when that boundary is applied to an IAM entity.
        /// </para>
        /// </summary>
        public PermissionsBoundaryDecisionDetail PermissionsBoundaryDecisionDetail { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsBoundaryDecisionDetail property is set.
        /// </summary>
        internal bool IsSetPermissionsBoundaryDecisionDetail() => this.PermissionsBoundaryDecisionDetail != null;
    }
}
