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
    /// Defines the basic information about a patch baseline override.
    /// </summary>
    public partial class BaselineOverride
    {
        private PatchRuleGroup _approvalRules;
        private List<string> _approvedPatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PatchComplianceLevel _approvedPatchesComplianceLevel;
        private bool? _approvedPatchesEnableNonSecurity;
        private PatchComplianceStatus _availableSecurityUpdatesComplianceStatus;
        private PatchFilterGroup _globalFilters;
        private OperatingSystem _operatingSystem;
        private List<string> _rejectedPatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PatchAction _rejectedPatchesAction;
        private List<PatchSource> _sources = AWSConfigs.InitializeCollections ? new List<PatchSource>() : null;

        /// <summary>
        /// Gets and sets the property ApprovalRules.
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
        /// as missing, this value describes the severity of the compliance violation.
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
        /// Indicates whether managed nodes for which there are available security-related patches
        /// that have not been approved by the baseline are being defined as <c>COMPLIANT</c>
        /// or <c>NON_COMPLIANT</c>. This option is specified when the <c>CreatePatchBaseline</c>
        /// or <c>UpdatePatchBaseline</c> commands are run.
        /// </para>
        ///  
        /// <para>
        /// Applies to Windows Server managed nodes only.
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
        /// Gets and sets the property GlobalFilters.
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system rule used by the patch baseline override.
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
        /// list. A patch can be allowed only if it is a dependency of another package, or blocked
        /// entirely along with packages that include it as a dependency.
        /// </para>
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

    }
}