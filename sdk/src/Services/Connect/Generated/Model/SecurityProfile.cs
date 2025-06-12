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
    /// Contains information about a security profile.
    /// </summary>
    public partial class SecurityProfile
    {
        private string _allowedAccessControlHierarchyGroupId;
        private Dictionary<string, string> _allowedAccessControlTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _arn;
        private string _description;
        private List<string> _hierarchyRestrictedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private string _organizationResourceId;
        private string _securityProfileName;
        private List<string> _tagRestrictedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedAccessControlHierarchyGroupId. 
        /// <para>
        /// The identifier of the hierarchy group that a security profile uses to restrict access
        /// to resources in Amazon Connect.
        /// </para>
        /// </summary>
        public string AllowedAccessControlHierarchyGroupId
        {
            get { return this._allowedAccessControlHierarchyGroupId; }
            set { this._allowedAccessControlHierarchyGroupId = value; }
        }

        // Check to see if AllowedAccessControlHierarchyGroupId property is set
        internal bool IsSetAllowedAccessControlHierarchyGroupId()
        {
            return this._allowedAccessControlHierarchyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedAccessControlTags. 
        /// <para>
        /// The list of tags that a security profile uses to restrict access to resources in Amazon
        /// Connect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=4)]
        public Dictionary<string, string> AllowedAccessControlTags
        {
            get { return this._allowedAccessControlTags; }
            set { this._allowedAccessControlTags = value; }
        }

        // Check to see if AllowedAccessControlTags property is set
        internal bool IsSetAllowedAccessControlTags()
        {
            return this._allowedAccessControlTags != null && (this._allowedAccessControlTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the security profile.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=250)]
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
        /// Gets and sets the property HierarchyRestrictedResources. 
        /// <para>
        /// The list of resources that a security profile applies hierarchy restrictions to in
        /// Amazon Connect. Following are acceptable ResourceNames: <c>User</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HierarchyRestrictedResources
        {
            get { return this._hierarchyRestrictedResources; }
            set { this._hierarchyRestrictedResources = value; }
        }

        // Check to see if HierarchyRestrictedResources property is set
        internal bool IsSetHierarchyRestrictedResources()
        {
            return this._hierarchyRestrictedResources != null && (this._hierarchyRestrictedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the security profile.
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
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationResourceId. 
        /// <para>
        /// The organization resource identifier for the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string OrganizationResourceId
        {
            get { return this._organizationResourceId; }
            set { this._organizationResourceId = value; }
        }

        // Check to see if OrganizationResourceId property is set
        internal bool IsSetOrganizationResourceId()
        {
            return this._organizationResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name for the security profile.
        /// </para>
        /// </summary>
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property TagRestrictedResources. 
        /// <para>
        /// The list of resources that a security profile applies tag restrictions to in Amazon
        /// Connect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> TagRestrictedResources
        {
            get { return this._tagRestrictedResources; }
            set { this._tagRestrictedResources = value; }
        }

        // Check to see if TagRestrictedResources property is set
        internal bool IsSetTagRestrictedResources()
        {
            return this._tagRestrictedResources != null && (this._tagRestrictedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}