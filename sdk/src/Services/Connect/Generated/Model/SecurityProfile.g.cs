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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a security profile.
    /// </summary>
    public partial class SecurityProfile
    {
        /// <summary>
        /// Gets and sets the property AllowedAccessControlHierarchyGroupId. 
        /// <para>
        /// The identifier of the hierarchy group that a security profile uses to restrict access
        /// to resources in Connect Customer.
        /// </para>
        /// </summary>
        public string AllowedAccessControlHierarchyGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AllowedAccessControlHierarchyGroupId property is set.
        /// </summary>
        internal bool IsSetAllowedAccessControlHierarchyGroupId() => this.AllowedAccessControlHierarchyGroupId != null;

        /// <summary>
        /// Gets and sets the property AllowedAccessControlTags. 
        /// <para>
        /// The list of tags that a security profile uses to restrict access to resources in Connect
        /// Customer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public Dictionary<string, string> AllowedAccessControlTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAccessControlTags property is set.
        /// </summary>
        internal bool IsSetAllowedAccessControlTags() => this.AllowedAccessControlTags != null && (this.AllowedAccessControlTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the security profile.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GranularAccessControlConfiguration. 
        /// <para>
        /// The granular access control configuration for the security profile, including data
        /// table permissions.
        /// </para>
        /// </summary>
        public GranularAccessControlConfiguration GranularAccessControlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GranularAccessControlConfiguration property is set.
        /// </summary>
        internal bool IsSetGranularAccessControlConfiguration() => this.GranularAccessControlConfiguration != null;

        /// <summary>
        /// Gets and sets the property HierarchyRestrictedResources. 
        /// <para>
        /// The list of resources that a security profile applies hierarchy restrictions to in
        /// Connect Customer. Following are acceptable ResourceNames: <c>User</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HierarchyRestrictedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HierarchyRestrictedResources property is set.
        /// </summary>
        internal bool IsSetHierarchyRestrictedResources() => this.HierarchyRestrictedResources != null && (this.HierarchyRestrictedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the security profile.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationResourceId. 
        /// <para>
        /// The organization resource identifier for the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string OrganizationResourceId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationResourceId property is set.
        /// </summary>
        internal bool IsSetOrganizationResourceId() => this.OrganizationResourceId != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name for the security profile.
        /// </para>
        /// </summary>
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;

        /// <summary>
        /// Gets and sets the property TagRestrictedResources. 
        /// <para>
        /// The list of resources that a security profile applies tag restrictions to in Connect
        /// Customer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> TagRestrictedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagRestrictedResources property is set.
        /// </summary>
        internal bool IsSetTagRestrictedResources() => this.TagRestrictedResources != null && (this.TagRestrictedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the security profile: <c>AWS_MANAGED</c> or <c>CUSTOMER_MANAGED</c>.
        /// </para>
        /// </summary>
        public SecurityProfileType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
