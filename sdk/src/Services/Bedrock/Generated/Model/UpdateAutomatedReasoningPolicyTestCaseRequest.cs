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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private string _clientRequestToken;
        private double? _confidenceThreshold;
        private AutomatedReasoningCheckResult _expectedAggregatedFindingsResult;
        private string _guardContent;
        private DateTime? _lastUpdatedAt;
        private string _policyArn;
        private string _queryContent;
        private string _testCaseId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The updated minimum confidence level for logic validation. If null is provided, the
        /// threshold will be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? ConfidenceThreshold
        {
            get { return this._confidenceThreshold; }
            set { this._confidenceThreshold = value; }
        }

        // Check to see if ConfidenceThreshold property is set
        internal bool IsSetConfidenceThreshold()
        {
            return this._confidenceThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedAggregatedFindingsResult. 
        /// <para>
        /// The updated expected result of the Automated Reasoning check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningCheckResult ExpectedAggregatedFindingsResult
        {
            get { return this._expectedAggregatedFindingsResult; }
            set { this._expectedAggregatedFindingsResult = value; }
        }

        // Check to see if ExpectedAggregatedFindingsResult property is set
        internal bool IsSetExpectedAggregatedFindingsResult()
        {
            return this._expectedAggregatedFindingsResult != null;
        }

        /// <summary>
        /// Gets and sets the property GuardContent. 
        /// <para>
        /// The updated content to be validated by the Automated Reasoning policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1024)]
        public string GuardContent
        {
            get { return this._guardContent; }
            set { this._guardContent = value; }
        }

        // Check to see if GuardContent property is set
        internal bool IsSetGuardContent()
        {
            return this._guardContent != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the test was last updated. This is used as a concurrency token
        /// to prevent conflicting modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy that contains the
        /// test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property QueryContent. 
        /// <para>
        /// The updated input query or prompt that generated the content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string QueryContent
        {
            get { return this._queryContent; }
            set { this._queryContent = value; }
        }

        // Check to see if QueryContent property is set
        internal bool IsSetQueryContent()
        {
            return this._queryContent != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// The unique identifier of the test to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=12)]
        public string TestCaseId
        {
            get { return this._testCaseId; }
            set { this._testCaseId = value; }
        }

        // Check to see if TestCaseId property is set
        internal bool IsSetTestCaseId()
        {
            return this._testCaseId != null;
        }

    }
}