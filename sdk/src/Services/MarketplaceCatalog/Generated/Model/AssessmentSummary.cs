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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
    /// Summarized information about an assessment.
    /// </summary>
    public partial class AssessmentSummary
    {
        private string _assessmentArn;
        private string _assessmentId;
        private AssessmentResult _assessmentResult;
        private AssessmentTargetSummary _assessmentTargetSummary;
        private string _createdAt;
        private string _expiresAt;
        private string _frameworkId;
        private FrameworkSummary _frameworkSummary;

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN associated with the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique ID of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentResult. 
        /// <para>
        /// The overall result of the assessment.
        /// </para>
        /// </summary>
        public AssessmentResult AssessmentResult
        {
            get { return this._assessmentResult; }
            set { this._assessmentResult = value; }
        }

        // Check to see if AssessmentResult property is set
        internal bool IsSetAssessmentResult()
        {
            return this._assessmentResult != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentTargetSummary. 
        /// <para>
        /// Identifies the entity or change set that was assessed.
        /// </para>
        /// </summary>
        public AssessmentTargetSummary AssessmentTargetSummary
        {
            get { return this._assessmentTargetSummary; }
            set { this._assessmentTargetSummary = value; }
        }

        // Check to see if AssessmentTargetSummary property is set
        internal bool IsSetAssessmentTargetSummary()
        {
            return this._assessmentTargetSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the assessment was created, in ISO 8601 format (<c>2018-02-27T13:45:22Z</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time the assessment expires, in ISO 8601 format (<c>2018-02-27T13:45:22Z</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The identifier of the framework that was evaluated by this assessment, in the format
        /// <c>frameworkId@version</c> (for example, <c>AMISecurity@1.0</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FrameworkId
        {
            get { return this._frameworkId; }
            set { this._frameworkId = value; }
        }

        // Check to see if FrameworkId property is set
        internal bool IsSetFrameworkId()
        {
            return this._frameworkId != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkSummary. 
        /// <para>
        /// The framework-specific details of the assessed resource. The set member corresponds
        /// to the framework identified by <c>FrameworkId</c>.
        /// </para>
        /// </summary>
        public FrameworkSummary FrameworkSummary
        {
            get { return this._frameworkSummary; }
            set { this._frameworkSummary = value; }
        }

        // Check to see if FrameworkSummary property is set
        internal bool IsSetFrameworkSummary()
        {
            return this._frameworkSummary != null;
        }

    }
}