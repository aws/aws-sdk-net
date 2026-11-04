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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a version of an IAM role template, including the configuration
    /// that is used to create roles with <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
    /// This structure is returned as a response element by the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRoleTemplateVersion.html">GetRoleTemplateVersion</a>
    /// operation.
    /// </summary>
    public partial class RoleTemplateVersion
    {
        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocumentTemplate. 
        /// <para>
        /// The trust policy template that grants an entity permission to assume roles that you
        /// create from this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string AssumeRolePolicyDocumentTemplate { get; set; }

        /// <summary>
        /// Checks to see if the AssumeRolePolicyDocumentTemplate property is set.
        /// </summary>
        internal bool IsSetAssumeRolePolicyDocumentTemplate() => this.AssumeRolePolicyDocumentTemplate != null;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the role template version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMinorVersion. 
        /// <para>
        /// The minor version that the service uses by default when you create a role from this
        /// template without specifying a minor version.
        /// </para>
        /// </summary>
        public int? DefaultMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMinorVersion property is set.
        /// </summary>
        internal bool IsSetDefaultMinorVersion() => this.DefaultMinorVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the role template is enabled. When a template is disabled, you cannot
        /// create roles from it.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property InlinePolicyTemplates. 
        /// <para>
        /// A list of inline policy templates that the service embeds in roles that you create
        /// from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InlinePolicy> InlinePolicyTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<InlinePolicy>() : null;

        /// <summary>
        /// Checks to see if the InlinePolicyTemplates property is set.
        /// </summary>
        internal bool IsSetInlinePolicyTemplates() => this.InlinePolicyTemplates != null && (this.InlinePolicyTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The major version number of the role template.
        /// </para>
        /// </summary>
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorVersion property is set.
        /// </summary>
        internal bool IsSetMajorVersion() => this.MajorVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedByType. 
        /// <para>
        /// Indicates that the role template is managed by an Amazon Web Services service.
        /// </para>
        /// </summary>
        public ManagedByTypeType ManagedByType { get; set; }

        /// <summary>
        /// Checks to see if the ManagedByType property is set.
        /// </summary>
        internal bool IsSetManagedByType() => this.ManagedByType != null;

        /// <summary>
        /// Gets and sets the property ManagedByValue. 
        /// <para>
        /// The identifier of the Amazon Web Services service that manages the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ManagedByValue { get; set; }

        /// <summary>
        /// Checks to see if the ManagedByValue property is set.
        /// </summary>
        internal bool IsSetManagedByValue() => this.ManagedByValue != null;

        /// <summary>
        /// Gets and sets the property ManagedPolicyArns. 
        /// <para>
        /// A list of the ARNs of the managed policies that the service attaches to roles that
        /// you create from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ManagedPolicyArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedPolicyArns property is set.
        /// </summary>
        internal bool IsSetManagedPolicyArns() => this.ManagedPolicyArns != null && (this.ManagedPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) for roles that are created from this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3600, Max = 43200)]
        public int? MaxSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSessionDuration() => this.MaxSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// The minor version number of this role template version.
        /// </para>
        /// </summary>
        public int? MinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinorVersion property is set.
        /// </summary>
        internal bool IsSetMinorVersion() => this.MinorVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ParametersDefinition. 
        /// <para>
        /// A list of the parameters that are defined for this role template version. You supply
        /// values for these parameters when you create a role with <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterDefinition> ParametersDefinition { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterDefinition>() : null;

        /// <summary>
        /// Checks to see if the ParametersDefinition property is set.
        /// </summary>
        internal bool IsSetParametersDefinition() => this.ParametersDefinition != null && (this.ParametersDefinition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionBoundaryArn. 
        /// <para>
        /// The ARN of the policy that sets the permissions boundary for roles that you create
        /// from this template.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PermissionBoundaryArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionBoundaryArn property is set.
        /// </summary>
        internal bool IsSetPermissionBoundaryArn() => this.PermissionBoundaryArn != null;

        /// <summary>
        /// Gets and sets the property RoleDescriptionPattern. 
        /// <para>
        /// The pattern that is used to generate the description of a role that is created from
        /// this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleDescriptionPattern { get; set; }

        /// <summary>
        /// Checks to see if the RoleDescriptionPattern property is set.
        /// </summary>
        internal bool IsSetRoleDescriptionPattern() => this.RoleDescriptionPattern != null;

        /// <summary>
        /// Gets and sets the property RoleNamePattern. 
        /// <para>
        /// The pattern that is used to generate the name of a role that is created from this
        /// template. The pattern can include <c>@{parameter}</c> placeholders that are replaced
        /// with the values you supply in the <c>ReplacementValues</c> parameter of <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RoleNamePattern { get; set; }

        /// <summary>
        /// Checks to see if the RoleNamePattern property is set.
        /// </summary>
        internal bool IsSetRoleNamePattern() => this.RoleNamePattern != null;

        /// <summary>
        /// Gets and sets the property RolePathPattern. 
        /// <para>
        /// The pattern that is used to generate the path of a role that is created from this
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RolePathPattern { get; set; }

        /// <summary>
        /// Checks to see if the RolePathPattern property is set.
        /// </summary>
        internal bool IsSetRolePathPattern() => this.RolePathPattern != null;

        /// <summary>
        /// Gets and sets the property RoleTagsTemplate. 
        /// <para>
        /// A list of tag templates that are applied to roles that are created from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TagTemplate> RoleTagsTemplate { get; set; } = AWSConfigs.InitializeCollections ? new List<TagTemplate>() : null;

        /// <summary>
        /// Checks to see if the RoleTagsTemplate property is set.
        /// </summary>
        internal bool IsSetRoleTagsTemplate() => this.RoleTagsTemplate != null && (this.RoleTagsTemplate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the role template.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The friendly name that identifies the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateVersionId. 
        /// <para>
        /// The identifier of the role template version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 128)]
        public string TemplateVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateVersionId property is set.
        /// </summary>
        internal bool IsSetTemplateVersionId() => this.TemplateVersionId != null;

        /// <summary>
        /// Gets and sets the property UpdateTimestamp. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the role template version was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdateTimestamp() => this.UpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VersionEnabled. 
        /// <para>
        /// Specifies whether this specific minor version of the role template is enabled.
        /// </para>
        /// </summary>
        public bool? VersionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the VersionEnabled property is set.
        /// </summary>
        internal bool IsSetVersionEnabled() => this.VersionEnabled.HasValue;
    }
}
