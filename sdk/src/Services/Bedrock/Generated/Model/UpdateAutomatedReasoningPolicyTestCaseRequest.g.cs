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
    /// Container for the parameters to the UpdateAutomatedReasoningPolicyTestCase operation.
    /// Updates an existing Automated Reasoning policy test. You can modify the content, query,
    /// expected result, and confidence threshold.
    /// </summary>
    public partial class UpdateAutomatedReasoningPolicyTestCaseRequest : AmazonBedrockRequest
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
        /// The updated minimum confidence level for logic validation. If null is provided, the
        /// threshold will be removed.
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
        /// The updated expected result of the Automated Reasoning check.
        /// </para>
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
        /// The updated content to be validated by the Automated Reasoning policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 2048)]
        public string GuardContent { get; set; }

        /// <summary>
        /// Checks to see if the GuardContent property is set.
        /// </summary>
        internal bool IsSetGuardContent() => this.GuardContent != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the test was last updated. This is used as a concurrency token
        /// to prevent conflicting modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy that contains the
        /// test.
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
        /// The updated input query or prompt that generated the content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string QueryContent { get; set; }

        /// <summary>
        /// Checks to see if the QueryContent property is set.
        /// </summary>
        internal bool IsSetQueryContent() => this.QueryContent != null;

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The unique identifier of the test to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 12)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseId property is set.
        /// </summary>
        internal bool IsSetTestCaseId() => this.TestCaseId != null;
    }
}
