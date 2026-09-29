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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssessment operation.
    /// </summary>
    public partial class DescribeAssessmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN associated with the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AssessmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentArn property is set.
        /// </summary>
        internal bool IsSetAssessmentArn() => this.AssessmentArn != null;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique ID of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property AssessmentResult. 
        /// <para>
        /// The overall result of the assessment.
        /// </para>
        /// </summary>
        public AssessmentResult AssessmentResult { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentResult property is set.
        /// </summary>
        internal bool IsSetAssessmentResult() => this.AssessmentResult != null;

        /// <summary>
        /// Gets and sets the property AssessmentTargetSummary. 
        /// <para>
        /// Identifies the entity or change set that was assessed.
        /// </para>
        /// </summary>
        public AssessmentTargetSummary AssessmentTargetSummary { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTargetSummary property is set.
        /// </summary>
        internal bool IsSetAssessmentTargetSummary() => this.AssessmentTargetSummary != null;

        /// <summary>
        /// Gets and sets the property ControlAssessments. 
        /// <para>
        /// An array of <c>ControlAssessment</c> objects, each containing the result of an individual
        /// control evaluated as part of the assessment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlAssessment> ControlAssessments { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlAssessment>() : null;

        /// <summary>
        /// Checks to see if the ControlAssessments property is set.
        /// </summary>
        internal bool IsSetControlAssessments() => this.ControlAssessments != null && (this.ControlAssessments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the assessment was created, in ISO 8601 format (<c>2018-02-27T13:45:22Z</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time the assessment expires, in ISO 8601 format (<c>2018-02-27T13:45:22Z</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt != null;

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The identifier of the framework that was evaluated by this assessment, in the format
        /// <c>frameworkId@version</c> (for example, <c>AMISecurity@1.0</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FrameworkId { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkId property is set.
        /// </summary>
        internal bool IsSetFrameworkId() => this.FrameworkId != null;

        /// <summary>
        /// Gets and sets the property FrameworkSummary. 
        /// <para>
        /// The framework-specific details of the assessed resource. The set member corresponds
        /// to the framework identified by <c>FrameworkId</c>.
        /// </para>
        /// </summary>
        public FrameworkSummary FrameworkSummary { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkSummary property is set.
        /// </summary>
        internal bool IsSetFrameworkSummary() => this.FrameworkSummary != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value of the next token, if it exists. <c>null</c> if there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
