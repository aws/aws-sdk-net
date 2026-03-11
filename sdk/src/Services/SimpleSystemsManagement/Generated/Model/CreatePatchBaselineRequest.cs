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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePatchBaseline operation.
    /// Creates a patch baseline.
    /// 
    ///  <note> 
    /// <para>
    /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
    /// operating system type, see <a>PatchFilter</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePatchBaselineRequest : AmazonSimpleSystemsManagementRequest
    {
        private PatchRuleGroup _approvalRules;
        private List<string> _approvedPatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PatchComplianceLevel _approvedPatchesComplianceLevel;
        private bool? _approvedPatchesEnableNonSecurity;
        private PatchComplianceStatus _availableSecurityUpdatesComplianceStatus;
        private string _clientToken;
        private string _description;
        private PatchFilterGroup _globalFilters;
        private string _name;
        private OperatingSystem _operatingSystem;
        private List<string> _rejectedPatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PatchAction _rejectedPatchesAction;
        private List<PatchSource> _sources = AWSConfigs.InitializeCollections ? new List<PatchSource>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ApprovalRules. 
        /// <para>
        /// A set of rules used to include patches in the baseline.
        /// </para>
        /// </summary>
        public PatchRuleGroup ApprovalRules
        {
            get { return this._approvalRules; }
            set { this._approvalRules = value; }
        }

        // Check to see if ApprovalRules property is set
        internal bool IsSetApprovalRules()
        {
            return this._approvalRules != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatches. 
        /// <para>
        /// A list of explicitly approved patches for the baseline.
        /// </para>
        ///  
        /// <para>
        /// For information about accepted formats for lists of approved patches and rejected
        /// patches, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html">Package
        /// name formats for approved and rejected patch lists</a> in the <i>Amazon Web Services
        /// Systems Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> ApprovedPatches
        {
            get { return this._approvedPatches; }
            set { this._approvedPatches = value; }
        }

        // Check to see if ApprovedPatches property is set
        internal bool IsSetApprovedPatches()
        {
            return this._approvedPatches != null && (this._approvedPatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatchesComplianceLevel. 
        /// <para>
        /// Defines the compliance level for approved patches. When an approved patch is reported
        /// as missing, this value describes the severity of the compliance violation. The default
        /// value is <c>UNSPECIFIED</c>.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ApprovedPatchesComplianceLevel
        {
            get { return this._approvedPatchesComplianceLevel; }
            set { this._approvedPatchesComplianceLevel = value; }
        }

        // Check to see if ApprovedPatchesComplianceLevel property is set
        internal bool IsSetApprovedPatchesComplianceLevel()
        {
            return this._approvedPatchesComplianceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatchesEnableNonSecurity. 
        /// <para>
        /// Indicates whether the list of approved patches includes non-security updates that
        /// should be applied to the managed nodes. The default value is <c>false</c>. Applies
        /// to Linux managed nodes only.
        /// </para>
        /// </summary>
        public bool? ApprovedPatchesEnableNonSecurity
        {
            get { return this._approvedPatchesEnableNonSecurity; }
            set { this._approvedPatchesEnableNonSecurity = value; }
        }

        // Check to see if ApprovedPatchesEnableNonSecurity property is set
        internal bool IsSetApprovedPatchesEnableNonSecurity()
        {
            return this._approvedPatchesEnableNonSecurity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableSecurityUpdatesComplianceStatus. 
        /// <para>
        /// Indicates the status you want to assign to security patches that are available but
        /// not approved because they don't meet the installation criteria specified in the patch
        /// baseline.
        /// </para>
        ///  
        /// <para>
        /// Example scenario: Security patches that you might want installed can be skipped if
        /// you have specified a long period to wait after a patch is released before installation.
        /// If an update to the patch is released during your specified waiting period, the waiting
        /// period for installing the patch starts over. If the waiting period is too long, multiple
        /// versions of the patch could be released but never installed.
        /// </para>
        ///  
        /// <para>
        /// Supported for Windows Server managed nodes only.
        /// </para>
        /// </summary>
        public PatchComplianceStatus AvailableSecurityUpdatesComplianceStatus
        {
            get { return this._availableSecurityUpdatesComplianceStatus; }
            set { this._availableSecurityUpdatesComplianceStatus = value; }
        }

        // Check to see if AvailableSecurityUpdatesComplianceStatus property is set
        internal bool IsSetAvailableSecurityUpdatesComplianceStatus()
        {
            return this._availableSecurityUpdatesComplianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property GlobalFilters. 
        /// <para>
        /// A set of global filters used to include patches in the baseline.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>GlobalFilters</c> parameter can be configured only by using the CLI or an Amazon
        /// Web Services SDK. It can't be configured from the Patch Manager console, and its value
        /// isn't displayed in the console.
        /// </para>
        ///  </important>
        /// </summary>
        public PatchFilterGroup GlobalFilters
        {
            get { return this._globalFilters; }
            set { this._globalFilters = value; }
        }

        // Check to see if GlobalFilters property is set
        internal bool IsSetGlobalFilters()
        {
            return this._globalFilters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Defines the operating system the patch baseline applies to. The default value is <c>WINDOWS</c>.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property RejectedPatches. 
        /// <para>
        /// A list of explicitly rejected patches for the baseline.
        /// </para>
        ///  
        /// <para>
        /// For information about accepted formats for lists of approved patches and rejected
        /// patches, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html">Package
        /// name formats for approved and rejected patch lists</a> in the <i>Amazon Web Services
        /// Systems Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RejectedPatches
        {
            get { return this._rejectedPatches; }
            set { this._rejectedPatches = value; }
        }

        // Check to see if RejectedPatches property is set
        internal bool IsSetRejectedPatches()
        {
            return this._rejectedPatches != null && (this._rejectedPatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RejectedPatchesAction. 
        /// <para>
        /// The action for Patch Manager to take on patches included in the <c>RejectedPackages</c>
        /// list.
        /// </para>
        ///  <dl> <dt>ALLOW_AS_DEPENDENCY</dt> <dd> 
        /// <para>
        ///  <b>Linux and macOS</b>: A package in the rejected patches list is installed only
        /// if it is a dependency of another package. It is considered compliant with the patch
        /// baseline, and its status is reported as <c>INSTALLED_OTHER</c>. This is the default
        /// action if no option is specified.
        /// </para>
        ///  
        /// <para>
        ///  <b>Windows Server</b>: Windows Server doesn't support the concept of package dependencies.
        /// If a package in the rejected patches list and already installed on the node, its status
        /// is reported as <c>INSTALLED_OTHER</c>. Any package not already installed on the node
        /// is skipped. This is the default action if no option is specified.
        /// </para>
        ///  </dd> <dt>BLOCK</dt> <dd> 
        /// <para>
        ///  <b>All OSs</b>: Packages in the rejected patches list, and packages that include
        /// them as dependencies, aren't installed by Patch Manager under any circumstances. 
        /// </para>
        ///  
        /// <para>
        /// State value assignment for patch compliance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a package was installed before it was added to the rejected patches list, or is
        /// installed outside of Patch Manager afterward, it's considered noncompliant with the
        /// patch baseline and its status is reported as <c>INSTALLED_REJECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If an update attempts to install a dependency package that is now rejected by the
        /// baseline, when previous versions of the package were not rejected, the package being
        /// updated is reported as <c>MISSING</c> for <c>SCAN</c> operations and as <c>FAILED</c>
        /// for <c>INSTALL</c> operations.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        public PatchAction RejectedPatchesAction
        {
            get { return this._rejectedPatchesAction; }
            set { this._rejectedPatchesAction = value; }
        }

        // Check to see if RejectedPatchesAction property is set
        internal bool IsSetRejectedPatchesAction()
        {
            return this._rejectedPatchesAction != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Information about the patches to use to update the managed nodes, including target
        /// operating systems and source repositories. Applies to Linux managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<PatchSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag a patch baseline to identify the severity level of patches it specifies
        /// and the operating system family it applies to. In this case, you could specify the
        /// following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=PatchSeverity,Value=Critical</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=OS,Value=Windows</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing patch baseline, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
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