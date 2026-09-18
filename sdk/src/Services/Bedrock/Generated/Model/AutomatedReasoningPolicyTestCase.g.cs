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
    /// Represents a test for validating an Automated Reasoning policy. tests contain sample
    /// inputs and expected outcomes to verify policy behavior.
    /// </summary>
    public partial class AutomatedReasoningPolicyTestCase
    {
        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The minimum confidence level for logic validation. Content meeting this threshold
        /// is considered high-confidence and can be validated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetConfidenceThreshold() => this.ConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedAggregatedFindingsResult. 
        /// <para>
        /// The expected result of the Automated Reasoning check for this test.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckResult ExpectedAggregatedFindingsResult { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedAggregatedFindingsResult property is set.
        /// </summary>
        internal bool IsSetExpectedAggregatedFindingsResult() => this.ExpectedAggregatedFindingsResult != null;

        /// <summary>
        /// Gets and sets the property GuardContent. 
        /// <para>
        /// The output content to be validated by the policy, typically representing a foundation
        /// model response.
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
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string QueryContent { get; set; }

        /// <summary>
        /// Checks to see if the QueryContent property is set.
        /// </summary>
        internal bool IsSetQueryContent() => this.QueryContent != null;

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The unique identifier of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 12)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseId property is set.
        /// </summary>
        internal bool IsSetTestCaseId() => this.TestCaseId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the test was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
