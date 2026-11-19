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

namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Represents an individual evaluation for a single action and resource pair. This includes
    /// the context, the resulting effect, and any policies that matched.
    /// </summary>
    public partial class Evaluation
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action evaluated for this request (for example, <c>iam:PassRole</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        ///  <c>checks</c> contains the authorization checks that explain an evaluation result.
        /// Each check is one authorization requirement and reports its result and policies from
        /// the top-level <c>policies</c> list with matching statements. The output lists RCP
        /// checks from the organization root to the account, then SCP checks from the organization
        /// root to the account. It then lists VPC endpoint, resource, principal, permissions
        /// boundary, and session checks. When <c>checks</c> is present, an <c>EXPLICIT_DENY</c>
        /// evaluation includes an <c>EXPLICIT_DENY</c> check. When <c>checks</c> is present for
        /// an <c>IMPLICIT_DENY</c> evaluation, it includes an <c>IMPLICIT_DENY</c> check and
        /// no <c>EXPLICIT_DENY</c> check. For more information about how IAM evaluates policies,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic_policy-eval-denyallow.html">Policy
        /// evaluation logic</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>PRINCIPAL</c>, <c>PERMISSIONS_BOUNDARY</c>, and <c>SESSION</c> checks appear when
        /// they apply to the principal that made the request, even if none of their policies
        /// matched. A missing allow produces <c>IMPLICIT_DENY</c>, or <c>NO_IMPACT</c> when another
        /// path already allowed the request.
        /// </para>
        ///  
        /// <para>
        /// Returned when the caller is in the request principal's account or organization. The
        /// absence of <c>checks</c> does not mean no authorization checks applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Check> Checks { get; set; } = AWSConfigs.InitializeCollections ? new List<Check>() : null;

        /// <summary>
        /// Checks to see if the Checks property is set.
        /// </summary>
        internal bool IsSetChecks() => this.Checks != null && (this.Checks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context keys and values specific to this evaluation. These are applied on top
        /// of the request context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Context { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null && (this.Context.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatedEffect. 
        /// <para>
        /// The result of the evaluation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - The action was allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPLICIT_DENY</c> - The action was explicitly denied by a policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPLICIT_DENY</c> - The action was denied because at least one required authorization
        /// check had no matching allow statement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvaluatedEffect EvaluatedEffect { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedEffect property is set.
        /// </summary>
        internal bool IsSetEvaluatedEffect() => this.EvaluatedEffect != null;

        /// <summary>
        /// Gets and sets the property MatchedPolicies. 
        /// <para>
        ///  <c>matchedPolicies</c> is deprecated. Use <c>checks</c> instead. This value contains
        /// the policies that matched during evaluation of this action and resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use checks, which group matched policies by the requirement they apply to.")]
        public List<MatchedPolicy> MatchedPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<MatchedPolicy>() : null;

        /// <summary>
        /// Checks to see if the MatchedPolicies property is set.
        /// </summary>
        internal bool IsSetMatchedPolicies() => this.MatchedPolicies != null && (this.MatchedPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the action targeted. This is typically a resource ARN, but can be
        /// a wildcard ARN that matches multiple resources, or empty for actions that are not
        /// resource-specific.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
