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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
        private CommentMetadata _commentMetadata;
        private UserMetadata _initiator;
        private bool? _isIndirectActivity;
        private string _organizationId;
        private ResourceMetadata _originalParent;
        private Participants _participants;
        private ResourceMetadata _resourceMetadata;
        private DateTime? _timeStamp;
        private ActivityType _type;

        /// <summary>
        /// Gets and sets the property CommentMetadata. 
        /// <para>
        /// Metadata of the commenting activity. This is an optional field and is filled for commenting
        /// activities.
        /// </para>
        /// </summary>
        public CommentMetadata CommentMetadata
        {
            get { return this._commentMetadata; }
            set { this._commentMetadata = value; }
        }

        // Check to see if CommentMetadata property is set
        internal bool IsSetCommentMetadata()
        {
            return this._commentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Initiator. 
        /// <para>
        /// The user who performed the action.
        /// </para>
        /// </summary>
        public UserMetadata Initiator
        {
            get { return this._initiator; }
            set { this._initiator = value; }
        }

        // Check to see if Initiator property is set
        internal bool IsSetInitiator()
        {
            return this._initiator != null;
        }

        /// <summary>
        /// Gets and sets the property IsIndirectActivity. 
        /// <para>
        /// Indicates whether an activity is indirect or direct. An indirect activity results
        /// from a direct activity performed on a parent resource. For example, sharing a parent
        /// folder (the direct activity) shares all of the subfolders and documents within the
        /// parent folder (the indirect activity).
        /// </para>
        /// </summary>
        public bool? IsIndirectActivity
        {
            get { return this._isIndirectActivity; }
            set { this._isIndirectActivity = value; }
        }

        // Check to see if IsIndirectActivity property is set
        internal bool IsSetIsIndirectActivity()
        {
            return this._isIndirectActivity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalParent. 
        /// <para>
        /// The original parent of the resource. This is an optional field and is filled for move
        /// activities.
        /// </para>
        /// </summary>
        public ResourceMetadata OriginalParent
        {
            get { return this._originalParent; }
            set { this._originalParent = value; }
        }

        // Check to see if OriginalParent property is set
        internal bool IsSetOriginalParent()
        {
            return this._originalParent != null;
        }

        /// <summary>
        /// Gets and sets the property Participants. 
        /// <para>
        /// The list of users or groups impacted by this action. This is an optional field and
        /// is filled for the following sharing activities: DOCUMENT_SHARED, DOCUMENT_SHARED,
        /// DOCUMENT_UNSHARED, FOLDER_SHARED, FOLDER_UNSHARED.
        /// </para>
        /// </summary>
        public Participants Participants
        {
            get { return this._participants; }
            set { this._participants = value; }
        }

        // Check to see if Participants property is set
        internal bool IsSetParticipants()
        {
            return this._participants != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMetadata. 
        /// <para>
        /// The metadata of the resource involved in the user action.
        /// </para>
        /// </summary>
        public ResourceMetadata ResourceMetadata
        {
            get { return this._resourceMetadata; }
            set { this._resourceMetadata = value; }
        }

        // Check to see if ResourceMetadata property is set
        internal bool IsSetResourceMetadata()
        {
            return this._resourceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// The timestamp when the action was performed.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }

        // Check to see if TimeStamp property is set
        internal bool IsSetTimeStamp()
        {
            return this._timeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The activity type.
        /// </para>
        /// </summary>
        public ActivityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}