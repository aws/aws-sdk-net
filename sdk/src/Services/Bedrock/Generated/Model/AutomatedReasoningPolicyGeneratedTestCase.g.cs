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
    /// Represents a generated test case, consisting of query content, guard content, and
    /// expected results.
    /// </summary>
    public partial class AutomatedReasoningPolicyGeneratedTestCase
    {
        /// <summary>
        /// Gets and sets the property ExpectedAggregatedFindingsResult. 
        /// <para>
        /// The expected results of the generated test case. Possible values include:
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
        /// Gets and sets the property QueryContent. 
        /// <para>
        /// The input query or prompt that generated the content. This provides context for the
        /// validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 1024)]
        public string QueryContent { get; set; }

        /// <summary>
        /// Checks to see if the QueryContent property is set.
        /// </summary>
        internal bool IsSetQueryContent() => this.QueryContent != null;
    }
}
