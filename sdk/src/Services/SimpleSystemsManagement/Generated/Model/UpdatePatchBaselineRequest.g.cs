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
    /// Container for the parameters to the UpdatePatchBaseline operation. Modifies an existing
    /// patch baseline. Fields not specified in the request are left unchanged. <note> <para>
    /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
    /// operating system type, see <a>PatchFilter</a>. </para> </note>
    /// </summary>
    public partial class UpdatePatchBaselineRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalRules. 
        /// <para>
        /// A set of rules used to include patches in the baseline.
        /// </para>
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
        /// Assigns a new compliance severity level to an existing patch baseline.
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
        /// Indicates the status to be assigned to security patches that are available but not
        /// approved because they don't meet the installation criteria specified in the patch
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
        public PatchComplianceStatus AvailableSecurityUpdatesComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSecurityUpdatesComplianceStatus property is set.
        /// </summary>
        internal bool IsSetAvailableSecurityUpdatesComplianceStatus() => this.AvailableSecurityUpdatesComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 128)]
        public string BaselineId { get; set; }

        /// <summary>
        /// Checks to see if the BaselineId property is set.
        /// </summary>
        internal bool IsSetBaselineId() => this.BaselineId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public PatchFilterGroup GlobalFilters { get; set; }

        /// <summary>
        /// Checks to see if the GlobalFilters property is set.
        /// </summary>
        internal bool IsSetGlobalFilters() => this.GlobalFilters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public PatchAction RejectedPatchesAction { get; set; }

        /// <summary>
        /// Checks to see if the RejectedPatchesAction property is set.
        /// </summary>
        internal bool IsSetRejectedPatchesAction() => this.RejectedPatchesAction != null;

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// If True, then all fields that are required by the <a>CreatePatchBaseline</a> operation
        /// are also required for this API request. Optional fields that aren't specified are
        /// set to null.
        /// </para>
        /// </summary>
        public bool? Replace { get; set; }

        /// <summary>
        /// Checks to see if the Replace property is set.
        /// </summary>
        internal bool IsSetReplace() => this.Replace.HasValue;

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
