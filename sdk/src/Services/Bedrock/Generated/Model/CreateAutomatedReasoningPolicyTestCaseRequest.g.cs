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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutomatedReasoningPolicyTestCase operation.
    /// Creates a test for an Automated Reasoning policy. Tests validate that your policy
    /// works as expected by providing sample inputs and expected outcomes. Use tests to verify
    /// policy behavior before deploying to production.
    /// </summary>
    public partial class CreateAutomatedReasoningPolicyTestCaseRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The minimum confidence level for logic validation. Content that meets the threshold
        /// is considered a high-confidence finding that can be validated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetConfidenceThreshold() => this.ConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedAggregatedFindingsResult. 
        /// <para>
        /// The expected result of the Automated Reasoning check. Valid values include: , TOO_COMPLEX,
        /// and NO_TRANSLATIONS.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VALID</c> - The claims are true. The claims are implied by the premises and the
        /// Automated Reasoning policy. Given the Automated Reasoning policy and premises, it
        /// is not possible for these claims to be false. In other words, there are no alternative
        /// answers that are true that contradict the claims.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID</c> - The claims are false. The claims are not implied by the premises
        /// and Automated Reasoning policy. Furthermore, there exists different claims that are
        /// consistent with the premises and Automated Reasoning policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SATISFIABLE</c> - The claims can be true or false. It depends on what assumptions
        /// are made for the claim to be implied from the premises and Automated Reasoning policy
        /// rules. In this situation, different assumptions can make input claims false and alternative
        /// claims true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPOSSIBLE</c> - Automated Reasoning can’t make a statement about the claims.
        /// This can happen if the premises are logically incorrect, or if there is a conflict
        /// within the Automated Reasoning policy itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSLATION_AMBIGUOUS</c> - Detected an ambiguity in the translation meant it
        /// would be unsound to continue with validity checking. Additional context or follow-up
        /// questions might be needed to get translation to succeed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOO_COMPLEX</c> - The input contains too much information for Automated Reasoning
        /// to process within its latency limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_TRANSLATIONS</c> - Identifies that some or all of the input prompt wasn't translated
        /// into logic. This can happen if the input isn't relevant to the Automated Reasoning
        /// policy, or if the policy doesn't have variables to model relevant input. If Automated
        /// Reasoning can't translate anything, you get a single <c>NO_TRANSLATIONS</c> finding.
        /// You might also see a <c>NO_TRANSLATIONS</c> (along with other findings) if some part
        /// of the validation isn't translated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningCheckResult ExpectedAggregatedFindingsResult { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedAggregatedFindingsResult property is set.
        /// </summary>
        internal bool IsSetExpectedAggregatedFindingsResult() => this.ExpectedAggregatedFindingsResult != null;

        /// <summary>
        /// Gets and sets the property GuardContent. 
        /// <para>
        /// The output content that's validated by the Automated Reasoning policy. This represents
        /// the foundation model response that will be checked for accuracy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 2048)]
        public string GuardContent { get; set; }

        /// <summary>
        /// Checks to see if the GuardContent property is set.
        /// </summary>
        internal bool IsSetGuardContent() => this.GuardContent != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy for which to create
        /// the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property QueryContent. 
        /// <para>
        /// The input query or prompt that generated the content. This provides context for the
        /// validation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string QueryContent { get; set; }

        /// <summary>
        /// Checks to see if the QueryContent property is set.
        /// </summary>
        internal bool IsSetQueryContent() => this.QueryContent != null;
    }
}
