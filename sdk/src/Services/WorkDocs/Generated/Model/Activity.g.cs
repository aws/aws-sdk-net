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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the activity information.
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Gets and sets the property CommentMetadata. 
        /// <para>
        /// Metadata of the commenting activity. This is an optional field and is filled for commenting
        /// activities.
        /// </para>
        /// </summary>
        public CommentMetadata CommentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the CommentMetadata property is set.
        /// </summary>
        internal bool IsSetCommentMetadata() => this.CommentMetadata != null;

        /// <summary>
        /// Gets and sets the property Initiator. 
        /// <para>
        /// The user who performed the action.
        /// </para>
        /// </summary>
        public UserMetadata Initiator { get; set; }

        /// <summary>
        /// Checks to see if the Initiator property is set.
        /// </summary>
        internal bool IsSetInitiator() => this.Initiator != null;

        /// <summary>
        /// Gets and sets the property IsIndirectActivity. 
        /// <para>
        /// Indicates whether an activity is indirect or direct. An indirect activity results
        /// from a direct activity performed on a parent resource. For example, sharing a parent
        /// folder (the direct activity) shares all of the subfolders and documents within the
        /// parent folder (the indirect activity).
        /// </para>
        /// </summary>
        public bool? IsIndirectActivity { get; set; }

        /// <summary>
        /// Checks to see if the IsIndirectActivity property is set.
        /// </summary>
        internal bool IsSetIsIndirectActivity() => this.IsIndirectActivity.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property OriginalParent. 
        /// <para>
        /// The original parent of the resource. This is an optional field and is filled for move
        /// activities.
        /// </para>
        /// </summary>
        public ResourceMetadata OriginalParent { get; set; }

        /// <summary>
        /// Checks to see if the OriginalParent property is set.
        /// </summary>
        internal bool IsSetOriginalParent() => this.OriginalParent != null;

        /// <summary>
        /// Gets and sets the property Participants. 
        /// <para>
        /// The list of users or groups impacted by this action. This is an optional field and
        /// is filled for the following sharing activities: DOCUMENT_SHARED, DOCUMENT_SHARED,
        /// DOCUMENT_UNSHARED, FOLDER_SHARED, FOLDER_UNSHARED.
        /// </para>
        /// </summary>
        public Participants Participants { get; set; }

        /// <summary>
        /// Checks to see if the Participants property is set.
        /// </summary>
        internal bool IsSetParticipants() => this.Participants != null;

        /// <summary>
        /// Gets and sets the property ResourceMetadata. 
        /// <para>
        /// The metadata of the resource involved in the user action.
        /// </para>
        /// </summary>
        public ResourceMetadata ResourceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ResourceMetadata property is set.
        /// </summary>
        internal bool IsSetResourceMetadata() => this.ResourceMetadata != null;

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// The timestamp when the action was performed.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the TimeStamp property is set.
        /// </summary>
        internal bool IsSetTimeStamp() => this.TimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The activity type.
        /// </para>
        /// </summary>
        public ActivityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
