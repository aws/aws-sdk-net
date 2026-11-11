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
    /// Container for the parameters to the UpdateSecurityProfile operation. Updates a security
    /// profile. <para> For information about security profiles, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/connect-security-profiles.html">Security
    /// Profiles</a> in the <i>Connect Customer Administrator Guide</i>. For a mapping of
    /// the API name and user interface name of the security profile permissions, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-list.html">List
    /// of security profile permissions</a>. </para>
    /// </summary>
    public partial class UpdateSecurityProfileRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedAIAgents. 
        /// <para>
        /// A list of AI agents that the security profile will give access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AIAgent> AllowedAIAgents { get; set; } = AWSConfigs.InitializeCollections ? new List<AIAgent>() : null;

        /// <summary>
        /// Checks to see if the AllowedAIAgents property is set.
        /// </summary>
        internal bool IsSetAllowedAIAgents() => this.AllowedAIAgents != null && (this.AllowedAIAgents.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property AllowedFlowModules. 
        /// <para>
        ///  A list of Flow Modules an AI Agent can invoke as a tool 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FlowModule> AllowedFlowModules { get; set; } = AWSConfigs.InitializeCollections ? new List<FlowModule>() : null;

        /// <summary>
        /// Checks to see if the AllowedFlowModules property is set.
        /// </summary>
        internal bool IsSetAllowedFlowModules() => this.AllowedFlowModules != null && (this.AllowedFlowModules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// A list of the third-party application's metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Application> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<Application>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to a security profile. For a list of valid permissions, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-list.html">List
        /// of security profile permissions</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityProfileId. 
        /// <para>
        /// The identifier for the security profle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityProfileId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileId property is set.
        /// </summary>
        internal bool IsSetSecurityProfileId() => this.SecurityProfileId != null;

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
    }
}
