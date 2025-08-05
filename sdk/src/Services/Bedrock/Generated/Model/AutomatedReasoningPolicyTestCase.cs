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
    /// Represents a test for validating an Automated Reasoning policy. tests contain sample
    /// inputs and expected outcomes to verify policy behavior.
    /// </summary>
    public partial class AutomatedReasoningPolicyTestCase
    {
        private double? _confidenceThreshold;
        private DateTime? _createdAt;
        private AutomatedReasoningCheckResult _expectedAggregatedFindingsResult;
        private string _guardContent;
        private string _queryContent;
        private string _testCaseId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The minimum confidence level for logic validation. Content meeting this threshold
        /// is considered high-confidence and can be validated.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedAggregatedFindingsResult. 
        /// <para>
        /// The expected result of the Automated Reasoning check for this test.
        /// </para>
        /// </summary>
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
        /// The output content to be validated by the policy, typically representing a foundation
        /// model response.
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
        /// Gets and sets the property QueryContent. 
        /// <para>
        /// The input query or prompt that generated the content. This provides context for the
        /// validation.
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
        /// The unique identifier of the test.
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the test was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}