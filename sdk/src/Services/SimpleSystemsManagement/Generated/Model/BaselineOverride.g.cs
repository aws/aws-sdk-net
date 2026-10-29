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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines the basic information about a patch baseline override.
    /// </summary>
    public partial class BaselineOverride
    {
        /// <summary>
        /// Gets and sets the property ApprovalRules.
        /// </summary>
        public PatchRuleGroup ApprovalRules { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRules property is set.
        /// </summary>
        internal bool IsSetApprovalRules() => this.ApprovalRules != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> ApprovedPatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApprovedPatches property is set.
        /// </summary>
        internal bool IsSetApprovedPatches() => this.ApprovedPatches != null && (this.ApprovedPatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovedPatchesComplianceLevel. 
        /// <para>
        /// Defines the compliance level for approved patches. When an approved patch is reported
        /// as missing, this value describes the severity of the compliance violation.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ApprovedPatchesComplianceLevel { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedPatchesComplianceLevel property is set.
        /// </summary>
        internal bool IsSetApprovedPatchesComplianceLevel() => this.ApprovedPatchesComplianceLevel != null;

        /// <summary>
        /// Gets and sets the property ApprovedPatchesEnableNonSecurity. 
        /// <para>
        /// Indicates whether the list of approved patches includes non-security updates that
        /// should be applied to the managed nodes. The default value is <c>false</c>. Applies
        /// to Linux managed nodes only.
        /// </para>
        /// </summary>
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedPatchesEnableNonSecurity property is set.
        /// </summary>
        internal bool IsSetApprovedPatchesEnableNonSecurity() => this.ApprovedPatchesEnableNonSecurity.HasValue;

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
        public PatchComplianceStatus AvailableSecurityUpdatesComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSecurityUpdatesComplianceStatus property is set.
        /// </summary>
        internal bool IsSetAvailableSecurityUpdatesComplianceStatus() => this.AvailableSecurityUpdatesComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property GlobalFilters.
        /// </summary>
        public PatchFilterGroup GlobalFilters { get; set; }

        /// <summary>
        /// Checks to see if the GlobalFilters property is set.
        /// </summary>
        internal bool IsSetGlobalFilters() => this.GlobalFilters != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system rule used by the patch baseline override.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RejectedPatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RejectedPatches property is set.
        /// </summary>
        internal bool IsSetRejectedPatches() => this.RejectedPatches != null && (this.RejectedPatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RejectedPatchesAction. 
        /// <para>
        /// The action for Patch Manager to take on patches included in the <c>RejectedPackages</c>
        /// list. A patch can be allowed only if it is a dependency of another package, or blocked
        /// entirely along with packages that include it as a dependency.
        /// </para>
        /// </summary>
        public PatchAction RejectedPatchesAction { get; set; }

        /// <summary>
        /// Checks to see if the RejectedPatchesAction property is set.
        /// </summary>
        internal bool IsSetRejectedPatchesAction() => this.RejectedPatchesAction != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Information about the patches to use to update the managed nodes, including target
        /// operating systems and source repositories. Applies to Linux managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<PatchSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<PatchSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
