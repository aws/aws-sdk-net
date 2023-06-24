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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The multi-party data share environment. The collaboration contains metadata about
    /// its purpose and participants.
    /// </summary>
    public partial class Collaboration
    {
        private string _arn;
        private DateTime? _createTime;
        private string _creatorAccountId;
        private string _creatorDisplayName;
        private DataEncryptionMetadata _dataEncryptionMetadata;
        private string _description;
        private string _id;
        private string _membershipArn;
        private string _membershipId;
        private MemberStatus _memberStatus;
        private string _name;
        private CollaborationQueryLogStatus _queryLogStatus;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the collaboration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorDisplayName. 
        /// <para>
        /// A display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CreatorDisplayName
        {
            get { return this._creatorDisplayName; }
            set { this._creatorDisplayName = value; }
        }

        // Check to see if CreatorDisplayName property is set
        internal bool IsSetCreatorDisplayName()
        {
            return this._creatorDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property DataEncryptionMetadata. 
        /// <para>
        /// The settings for client-side encryption for cryptographic computing.
        /// </para>
        /// </summary>
        public DataEncryptionMetadata DataEncryptionMetadata
        {
            get { return this._dataEncryptionMetadata; }
            set { this._dataEncryptionMetadata = value; }
        }

        // Check to see if DataEncryptionMetadata property is set
        internal bool IsSetDataEncryptionMetadata()
        {
            return this._dataEncryptionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collaboration provided by the collaboration owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The unique ARN for your membership within the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique ID for your membership within the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberStatus. 
        /// <para>
        /// The status of a member in a collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberStatus MemberStatus
        {
            get { return this._memberStatus; }
            set { this._memberStatus = value; }
        }

        // Check to see if MemberStatus property is set
        internal bool IsSetMemberStatus()
        {
            return this._memberStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A human-readable identifier provided by the collaboration owner. Display names are
        /// not unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QueryLogStatus. 
        /// <para>
        /// An indicator as to whether query logging has been enabled or disabled for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CollaborationQueryLogStatus QueryLogStatus
        {
            get { return this._queryLogStatus; }
            set { this._queryLogStatus = value; }
        }

        // Check to see if QueryLogStatus property is set
        internal bool IsSetQueryLogStatus()
        {
            return this._queryLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the collaboration metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}