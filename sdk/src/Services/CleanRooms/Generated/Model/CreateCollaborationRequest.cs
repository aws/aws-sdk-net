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
    /// Container for the parameters to the CreateCollaboration operation.
    /// Creates a new collaboration.
    /// </summary>
    public partial class CreateCollaborationRequest : AmazonCleanRoomsRequest
    {
        private string _creatorDisplayName;
        private List<string> _creatorMemberAbilities = new List<string>();
        private DataEncryptionMetadata _dataEncryptionMetadata;
        private string _description;
        private List<MemberSpecification> _members = new List<MemberSpecification>();
        private string _name;
        private CollaborationQueryLogStatus _queryLogStatus;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CreatorDisplayName. 
        /// <para>
        /// The display name of the collaboration creator.
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
        /// Gets and sets the property CreatorMemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CreatorMemberAbilities
        {
            get { return this._creatorMemberAbilities; }
            set { this._creatorMemberAbilities = value; }
        }

        // Check to see if CreatorMemberAbilities property is set
        internal bool IsSetCreatorMemberAbilities()
        {
            return this._creatorMemberAbilities != null && this._creatorMemberAbilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataEncryptionMetadata. 
        /// <para>
        /// The settings for client-side encryption with Cryptographic Computing for Clean Rooms.
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Members. 
        /// <para>
        /// A list of initial members, not including the creator. This list is immutable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=9)]
        public List<MemberSpecification> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && this._members.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for a collaboration.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}