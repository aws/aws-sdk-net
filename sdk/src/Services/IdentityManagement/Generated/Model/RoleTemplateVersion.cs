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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
        private string _assumeRolePolicyDocumentTemplate;
        private DateTime? _createTimestamp;
        private int? _defaultMinorVersion;
        private string _description;
        private bool? _enabled;
        private List<InlinePolicy> _inlinePolicyTemplates = AWSConfigs.InitializeCollections ? new List<InlinePolicy>() : null;
        private int? _majorVersion;
        private ManagedByTypeType _managedByType;
        private string _managedByValue;
        private List<string> _managedPolicyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxSessionDuration;
        private int? _minorVersion;
        private List<ParameterDefinition> _parametersDefinition = AWSConfigs.InitializeCollections ? new List<ParameterDefinition>() : null;
        private string _permissionBoundaryArn;
        private string _roleDescriptionPattern;
        private string _roleNamePattern;
        private string _rolePathPattern;
        private List<TagTemplate> _roleTagsTemplate = AWSConfigs.InitializeCollections ? new List<TagTemplate>() : null;
        private string _templateArn;
        private string _templateName;
        private string _templateVersionId;
        private DateTime? _updateTimestamp;
        private bool? _versionEnabled;

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocumentTemplate. 
        /// <para>
        /// The trust policy template that grants an entity permission to assume roles that you
        /// create from this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string AssumeRolePolicyDocumentTemplate
        {
            get { return this._assumeRolePolicyDocumentTemplate; }
            set { this._assumeRolePolicyDocumentTemplate = value; }
        }

        // Check to see if AssumeRolePolicyDocumentTemplate property is set
        internal bool IsSetAssumeRolePolicyDocumentTemplate()
        {
            return this._assumeRolePolicyDocumentTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the role template version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMinorVersion. 
        /// <para>
        /// The minor version that the service uses by default when you create a role from this
        /// template without specifying a minor version.
        /// </para>
        /// </summary>
        public int? DefaultMinorVersion
        {
            get { return this._defaultMinorVersion; }
            set { this._defaultMinorVersion = value; }
        }

        // Check to see if DefaultMinorVersion property is set
        internal bool IsSetDefaultMinorVersion()
        {
            return this._defaultMinorVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the role template is enabled. When a template is disabled, you cannot
        /// create roles from it.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InlinePolicyTemplates. 
        /// <para>
        /// A list of inline policy templates that the service embeds in roles that you create
        /// from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InlinePolicy> InlinePolicyTemplates
        {
            get { return this._inlinePolicyTemplates; }
            set { this._inlinePolicyTemplates = value; }
        }

        // Check to see if InlinePolicyTemplates property is set
        internal bool IsSetInlinePolicyTemplates()
        {
            return this._inlinePolicyTemplates != null && (this._inlinePolicyTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The major version number of the role template.
        /// </para>
        /// </summary>
        public int? MajorVersion
        {
            get { return this._majorVersion; }
            set { this._majorVersion = value; }
        }

        // Check to see if MajorVersion property is set
        internal bool IsSetMajorVersion()
        {
            return this._majorVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedByType. 
        /// <para>
        /// Indicates that the role template is managed by an Amazon Web Services service.
        /// </para>
        /// </summary>
        public ManagedByTypeType ManagedByType
        {
            get { return this._managedByType; }
            set { this._managedByType = value; }
        }

        // Check to see if ManagedByType property is set
        internal bool IsSetManagedByType()
        {
            return this._managedByType != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedByValue. 
        /// <para>
        /// The identifier of the Amazon Web Services service that manages the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ManagedByValue
        {
            get { return this._managedByValue; }
            set { this._managedByValue = value; }
        }

        // Check to see if ManagedByValue property is set
        internal bool IsSetManagedByValue()
        {
            return this._managedByValue != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedPolicyArns. 
        /// <para>
        /// A list of the ARNs of the managed policies that the service attaches to roles that
        /// you create from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ManagedPolicyArns
        {
            get { return this._managedPolicyArns; }
            set { this._managedPolicyArns = value; }
        }

        // Check to see if ManagedPolicyArns property is set
        internal bool IsSetManagedPolicyArns()
        {
            return this._managedPolicyArns != null && (this._managedPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) for roles that are created from this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3600, Max=43200)]
        public int? MaxSessionDuration
        {
            get { return this._maxSessionDuration; }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// The minor version number of this role template version.
        /// </para>
        /// </summary>
        public int? MinorVersion
        {
            get { return this._minorVersion; }
            set { this._minorVersion = value; }
        }

        // Check to see if MinorVersion property is set
        internal bool IsSetMinorVersion()
        {
            return this._minorVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParametersDefinition. 
        /// <para>
        /// A list of the parameters that are defined for this role template version. You supply
        /// values for these parameters when you create a role with <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterDefinition> ParametersDefinition
        {
            get { return this._parametersDefinition; }
            set { this._parametersDefinition = value; }
        }

        // Check to see if ParametersDefinition property is set
        internal bool IsSetParametersDefinition()
        {
            return this._parametersDefinition != null && (this._parametersDefinition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=20, Max=2048)]
        public string PermissionBoundaryArn
        {
            get { return this._permissionBoundaryArn; }
            set { this._permissionBoundaryArn = value; }
        }

        // Check to see if PermissionBoundaryArn property is set
        internal bool IsSetPermissionBoundaryArn()
        {
            return this._permissionBoundaryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleDescriptionPattern. 
        /// <para>
        /// The pattern that is used to generate the description of a role that is created from
        /// this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleDescriptionPattern
        {
            get { return this._roleDescriptionPattern; }
            set { this._roleDescriptionPattern = value; }
        }

        // Check to see if RoleDescriptionPattern property is set
        internal bool IsSetRoleDescriptionPattern()
        {
            return this._roleDescriptionPattern != null;
        }

        /// <summary>
        /// Gets and sets the property RoleNamePattern. 
        /// <para>
        /// The pattern that is used to generate the name of a role that is created from this
        /// template. The pattern can include <c>@{parameter}</c> placeholders that are replaced
        /// with the values you supply in the <c>ReplacementValues</c> parameter of <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RoleNamePattern
        {
            get { return this._roleNamePattern; }
            set { this._roleNamePattern = value; }
        }

        // Check to see if RoleNamePattern property is set
        internal bool IsSetRoleNamePattern()
        {
            return this._roleNamePattern != null;
        }

        /// <summary>
        /// Gets and sets the property RolePathPattern. 
        /// <para>
        /// The pattern that is used to generate the path of a role that is created from this
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RolePathPattern
        {
            get { return this._rolePathPattern; }
            set { this._rolePathPattern = value; }
        }

        // Check to see if RolePathPattern property is set
        internal bool IsSetRolePathPattern()
        {
            return this._rolePathPattern != null;
        }

        /// <summary>
        /// Gets and sets the property RoleTagsTemplate. 
        /// <para>
        /// A list of tag templates that are applied to roles that are created from this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<TagTemplate> RoleTagsTemplate
        {
            get { return this._roleTagsTemplate; }
            set { this._roleTagsTemplate = value; }
        }

        // Check to see if RoleTagsTemplate property is set
        internal bool IsSetRoleTagsTemplate()
        {
            return this._roleTagsTemplate != null && (this._roleTagsTemplate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=20, Max=2048)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The friendly name that identifies the role template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersionId. 
        /// <para>
        /// The identifier of the role template version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=128)]
        public string TemplateVersionId
        {
            get { return this._templateVersionId; }
            set { this._templateVersionId = value; }
        }

        // Check to see if TemplateVersionId property is set
        internal bool IsSetTemplateVersionId()
        {
            return this._templateVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTimestamp. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the role template version was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTimestamp
        {
            get { return this._updateTimestamp; }
            set { this._updateTimestamp = value; }
        }

        // Check to see if UpdateTimestamp property is set
        internal bool IsSetUpdateTimestamp()
        {
            return this._updateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionEnabled. 
        /// <para>
        /// Specifies whether this specific minor version of the role template is enabled.
        /// </para>
        /// </summary>
        public bool? VersionEnabled
        {
            get { return this._versionEnabled; }
            set { this._versionEnabled = value; }
        }

        // Check to see if VersionEnabled property is set
        internal bool IsSetVersionEnabled()
        {
            return this._versionEnabled.HasValue; 
        }

    }
}