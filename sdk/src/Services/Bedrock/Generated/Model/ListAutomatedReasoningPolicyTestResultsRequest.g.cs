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
    /// Container for the parameters to the ListAutomatedReasoningPolicyTestResults operation.
    /// Lists test results for an Automated Reasoning policy, showing how the policy performed
    /// against various test scenarios and validation checks.
    /// </summary>
    public partial class ListAutomatedReasoningPolicyTestResultsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow whose test results you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string BuildWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowId property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowId() => this.BuildWorkflowId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of test results to return in a single response. Valid range is
        /// 1-100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token from a previous request to continue listing test results from where
        /// the previous request left off.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose test results
        /// you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;
    }
}
