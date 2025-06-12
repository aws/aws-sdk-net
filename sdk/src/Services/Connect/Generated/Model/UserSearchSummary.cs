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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the returned users.
    /// </summary>
    public partial class UserSearchSummary
    {
        private string _arn;
        private string _directoryUserId;
        private string _hierarchyGroupId;
        private string _id;
        private UserIdentityInfoLite _identityInfo;
        private UserPhoneConfig _phoneConfig;
        private string _routingProfileId;
        private List<string> _securityProfileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DirectoryUserId. 
        /// <para>
        /// The directory identifier of the user.
        /// </para>
        /// </summary>
        public string DirectoryUserId
        {
            get { return this._directoryUserId; }
            set { this._directoryUserId = value; }
        }

        // Check to see if DirectoryUserId property is set
        internal bool IsSetDirectoryUserId()
        {
            return this._directoryUserId != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyGroupId. 
        /// <para>
        /// The identifier of the user's hierarchy group.
        /// </para>
        /// </summary>
        public string HierarchyGroupId
        {
            get { return this._hierarchyGroupId; }
            set { this._hierarchyGroupId = value; }
        }

        // Check to see if HierarchyGroupId property is set
        internal bool IsSetHierarchyGroupId()
        {
            return this._hierarchyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the user's summary.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IdentityInfo. 
        /// <para>
        /// The user's first name and last name.
        /// </para>
        /// </summary>
        public UserIdentityInfoLite IdentityInfo
        {
            get { return this._identityInfo; }
            set { this._identityInfo = value; }
        }

        // Check to see if IdentityInfo property is set
        internal bool IsSetIdentityInfo()
        {
            return this._identityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneConfig.
        /// </summary>
        public UserPhoneConfig PhoneConfig
        {
            get { return this._phoneConfig; }
            set { this._phoneConfig = value; }
        }

        // Check to see if PhoneConfig property is set
        internal bool IsSetPhoneConfig()
        {
            return this._phoneConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the user's routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileId
        {
            get { return this._routingProfileId; }
            set { this._routingProfileId = value; }
        }

        // Check to see if RoutingProfileId property is set
        internal bool IsSetRoutingProfileId()
        {
            return this._routingProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileIds. 
        /// <para>
        /// The identifiers of the user's security profiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SecurityProfileIds
        {
            get { return this._securityProfileIds; }
            set { this._securityProfileIds = value; }
        }

        // Check to see if SecurityProfileIds property is set
        internal bool IsSetSecurityProfileIds()
        {
            return this._securityProfileIds != null && (this._securityProfileIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}