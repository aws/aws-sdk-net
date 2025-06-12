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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a reviewer's response to a document review request.
    /// </summary>
    public partial class DocumentReviewerResponseSource
    {
        private List<DocumentReviewCommentSource> _comment = AWSConfigs.InitializeCollections ? new List<DocumentReviewCommentSource>() : null;
        private DateTime? _createTime;
        private string _reviewer;
        private ReviewStatus _reviewStatus;
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment entered by a reviewer as part of their document review response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<DocumentReviewCommentSource> Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null && (this._comment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time that a reviewer entered a response to a document review request.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reviewer. 
        /// <para>
        /// The user in your organization assigned to review a document request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string Reviewer
        {
            get { return this._reviewer; }
            set { this._reviewer = value; }
        }

        // Check to see if Reviewer property is set
        internal bool IsSetReviewer()
        {
            return this._reviewer != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current review status of a new custom SSM document created by a member of your
        /// organization, or of the latest version of an existing SSM document.
        /// </para>
        ///  
        /// <para>
        /// Only one version of a document can be in the APPROVED state at a time. When a new
        /// version is approved, the status of the previous version changes to REJECTED.
        /// </para>
        ///  
        /// <para>
        /// Only one version of a document can be in review, or PENDING, at a time.
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus
        {
            get { return this._reviewStatus; }
            set { this._reviewStatus = value; }
        }

        // Check to see if ReviewStatus property is set
        internal bool IsSetReviewStatus()
        {
            return this._reviewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The date and time that a reviewer last updated a response to a document review request.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime
        {
            get { return this._updatedTime; }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}