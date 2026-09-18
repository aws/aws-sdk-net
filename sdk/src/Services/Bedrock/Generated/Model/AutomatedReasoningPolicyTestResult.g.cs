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
    /// Contains the results of testing an Automated Reasoning policy against various scenarios
    /// and validation checks.
    /// </summary>
    public partial class AutomatedReasoningPolicyTestResult
    {
        /// <summary>
        /// Gets and sets the property AggregatedTestFindingsResult. 
        /// <para>
        /// A summary of all test findings, aggregated to provide an overall assessment of policy
        /// quality and correctness.
        /// </para>
        /// </summary>
        public AutomatedReasoningCheckResult AggregatedTestFindingsResult { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedTestFindingsResult property is set.
        /// </summary>
        internal bool IsSetAggregatedTestFindingsResult() => this.AggregatedTestFindingsResult != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy that was tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property TestCase. 
        /// <para>
        /// The test case that was executed, including the input content, expected results, and
        /// configuration parameters used during validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyTestCase TestCase { get; set; }

        /// <summary>
        /// Checks to see if the TestCase property is set.
        /// </summary>
        internal bool IsSetTestCase() => this.TestCase != null;

        /// <summary>
        /// Gets and sets the property TestFindings. 
        /// <para>
        /// Detailed findings from the test run, including any issues, violations, or unexpected
        /// behaviors discovered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<AutomatedReasoningCheckFinding> TestFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningCheckFinding>() : null;

        /// <summary>
        /// Checks to see if the TestFindings property is set.
        /// </summary>
        internal bool IsSetTestFindings() => this.TestFindings != null && (this.TestFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TestRunResult. 
        /// <para>
        /// The overall result of the test run, indicating whether the policy passed or failed
        /// validation.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyTestRunResult TestRunResult { get; set; }

        /// <summary>
        /// Checks to see if the TestRunResult property is set.
        /// </summary>
        internal bool IsSetTestRunResult() => this.TestRunResult != null;

        /// <summary>
        /// Gets and sets the property TestRunStatus. 
        /// <para>
        /// The overall status of the test run (e.g., COMPLETED, FAILED, IN_PROGRESS).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyTestRunStatus TestRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TestRunStatus property is set.
        /// </summary>
        internal bool IsSetTestRunStatus() => this.TestRunStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the test results were last updated.
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
