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
    /// Container for the parameters to the UpdateSecurityProfile operation.
    /// Updates a security profile.
    /// 
    ///  
    /// <para>
    /// For information about security profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/connect-security-profiles.html">Security
    /// Profiles</a> in the <i>Amazon Connect Administrator Guide</i>. For a mapping of the
    /// API name and user interface name of the security profile permissions, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-list.html">List
    /// of security profile permissions</a>. 
    /// </para>
    /// </summary>
    public partial class UpdateSecurityProfileRequest : AmazonConnectRequest
    {
        private string _allowedAccessControlHierarchyGroupId;
        private Dictionary<string, string> _allowedAccessControlTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Application> _applications = AWSConfigs.InitializeCollections ? new List<Application>() : null;
        private string _description;
        private List<string> _hierarchyRestrictedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceId;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _securityProfileId;
        private List<string> _tagRestrictedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property Applications. 
        /// <para>
        /// A list of the third-party application's metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to a security profile. For a list of valid permissions, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-list.html">List
        /// of security profile permissions</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=500)]
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileId. 
        /// <para>
        /// The identifier for the security profle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityProfileId
        {
            get { return this._securityProfileId; }
            set { this._securityProfileId = value; }
        }

        // Check to see if SecurityProfileId property is set
        internal bool IsSetSecurityProfileId()
        {
            return this._securityProfileId != null;
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

    }
}