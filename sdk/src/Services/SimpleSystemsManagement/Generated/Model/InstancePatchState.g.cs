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
    /// Defines the high-level patch compliance state for a managed node, providing information
    /// about the number of installed, missing, not applicable, and failed patches along with
    /// metadata about the operation when this information was gathered for the managed node.
    /// </summary>
    public partial class InstancePatchState
    {
        /// <summary>
        /// Gets and sets the property AvailableSecurityUpdateCount. 
        /// <para>
        /// The number of security-related patches that are available but not approved because
        /// they didn't meet the patch baseline requirements. For example, an updated version
        /// of a patch might have been released before the specified auto-approval period was
        /// over.
        /// </para>
        ///  
        /// <para>
        /// Applies to Windows Server managed nodes only.
        /// </para>
        /// </summary>
        public int? AvailableSecurityUpdateCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSecurityUpdateCount property is set.
        /// </summary>
        internal bool IsSetAvailableSecurityUpdateCount() => this.AvailableSecurityUpdateCount.HasValue;

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline used to patch the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 128)]
        public string BaselineId { get; set; }

        /// <summary>
        /// Checks to see if the BaselineId property is set.
        /// </summary>
        internal bool IsSetBaselineId() => this.BaselineId != null;

        /// <summary>
        /// Gets and sets the property CriticalNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as <c>Critical</c> for compliance
        /// reporting in the patch baseline aren't installed. These patches might be missing,
        /// have failed installation, were rejected, or were installed but awaiting a required
        /// managed node reboot. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? CriticalNonCompliantCount { get; set; }

        /// <summary>
        /// Checks to see if the CriticalNonCompliantCount property is set.
        /// </summary>
        internal bool IsSetCriticalNonCompliantCount() => this.CriticalNonCompliantCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of patches from the patch baseline that were attempted to be installed
        /// during the last patching operation, but failed to install.
        /// </para>
        /// </summary>
        public int? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstallOverrideList. 
        /// <para>
        /// An https URL or an Amazon Simple Storage Service (Amazon S3) path-style URL to a list
        /// of patches to be installed. This patch installation list, which you maintain in an
        /// S3 bucket in YAML format and specify in the SSM document <c>AWS-RunPatchBaseline</c>,
        /// overrides the patches specified by the default patch baseline.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>InstallOverrideList</c> parameter, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-about-aws-runpatchbaseline.html">SSM
        /// Command document for patching: <c>AWS-RunPatchBaseline</c> </a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstallOverrideList { get; set; }

        /// <summary>
        /// Checks to see if the InstallOverrideList property is set.
        /// </summary>
        internal bool IsSetInstallOverrideList() => this.InstallOverrideList != null;

        /// <summary>
        /// Gets and sets the property InstalledCount. 
        /// <para>
        /// The number of patches from the patch baseline that are installed on the managed node.
        /// </para>
        /// </summary>
        public int? InstalledCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledCount property is set.
        /// </summary>
        internal bool IsSetInstalledCount() => this.InstalledCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledOtherCount. 
        /// <para>
        /// The number of patches not specified in the patch baseline that are installed on the
        /// managed node.
        /// </para>
        /// </summary>
        public int? InstalledOtherCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledOtherCount property is set.
        /// </summary>
        internal bool IsSetInstalledOtherCount() => this.InstalledOtherCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledPendingRebootCount. 
        /// <para>
        /// The number of patches installed by Patch Manager since the last time the managed node
        /// was rebooted.
        /// </para>
        /// </summary>
        public int? InstalledPendingRebootCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledPendingRebootCount property is set.
        /// </summary>
        internal bool IsSetInstalledPendingRebootCount() => this.InstalledPendingRebootCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledRejectedCount. 
        /// <para>
        /// The number of patches installed on a managed node that are specified in a <c>RejectedPatches</c>
        /// list. Patches with a status of <c>InstalledRejected</c> were typically installed before
        /// they were added to a <c>RejectedPatches</c> list.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>ALLOW_AS_DEPENDENCY</c> is the specified option for <c>RejectedPatchesAction</c>,
        /// the value of <c>InstalledRejectedCount</c> will always be <c>0</c> (zero).
        /// </para>
        ///  </note>
        /// </summary>
        public int? InstalledRejectedCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledRejectedCount property is set.
        /// </summary>
        internal bool IsSetInstalledRejectedCount() => this.InstalledRejectedCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node the high-level patch compliance information was collected
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LastNoRebootInstallOperationTime. 
        /// <para>
        /// The time of the last attempt to patch the managed node with <c>NoReboot</c> specified
        /// as the reboot option.
        /// </para>
        /// </summary>
        public DateTime? LastNoRebootInstallOperationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastNoRebootInstallOperationTime property is set.
        /// </summary>
        internal bool IsSetLastNoRebootInstallOperationTime() => this.LastNoRebootInstallOperationTime.HasValue;

        /// <summary>
        /// Gets and sets the property MissingCount. 
        /// <para>
        /// The number of patches from the patch baseline that are applicable for the managed
        /// node but aren't currently installed.
        /// </para>
        /// </summary>
        public int? MissingCount { get; set; }

        /// <summary>
        /// Checks to see if the MissingCount property is set.
        /// </summary>
        internal bool IsSetMissingCount() => this.MissingCount.HasValue;

        /// <summary>
        /// Gets and sets the property NotApplicableCount. 
        /// <para>
        /// The number of patches from the patch baseline that aren't applicable for the managed
        /// node and therefore aren't installed on the node. This number may be truncated if the
        /// list of patch names is very large. The number of patches beyond this limit are reported
        /// in <c>UnreportedNotApplicableCount</c>.
        /// </para>
        /// </summary>
        public int? NotApplicableCount { get; set; }

        /// <summary>
        /// Checks to see if the NotApplicableCount property is set.
        /// </summary>
        internal bool IsSetNotApplicableCount() => this.NotApplicableCount.HasValue;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of patching operation that was performed: or 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SCAN</c> assesses the patch compliance state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTALL</c> installs missing patches.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PatchOperationType Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property OperationEndTime. 
        /// <para>
        /// The time the most recent patching operation completed on the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OperationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the OperationEndTime property is set.
        /// </summary>
        internal bool IsSetOperationEndTime() => this.OperationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property OperationStartTime. 
        /// <para>
        /// The time the most recent patching operation was started on the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OperationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the OperationStartTime property is set.
        /// </summary>
        internal bool IsSetOperationStartTime() => this.OperationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property OtherNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as other than <c>Critical</c> or
        /// <c>Security</c> but aren't compliant with the patch baseline. The status of these
        /// managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? OtherNonCompliantCount { get; set; }

        /// <summary>
        /// Checks to see if the OtherNonCompliantCount property is set.
        /// </summary>
        internal bool IsSetOtherNonCompliantCount() => this.OtherNonCompliantCount.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// Placeholder information. This field will always be empty in the current release of
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string OwnerInformation { get; set; }

        /// <summary>
        /// Checks to see if the OwnerInformation property is set.
        /// </summary>
        internal bool IsSetOwnerInformation() => this.OwnerInformation != null;

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group the managed node belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PatchGroup { get; set; }

        /// <summary>
        /// Checks to see if the PatchGroup property is set.
        /// </summary>
        internal bool IsSetPatchGroup() => this.PatchGroup != null;

        /// <summary>
        /// Gets and sets the property RebootOption. 
        /// <para>
        /// Indicates the reboot option specified in the patch baseline.
        /// </para>
        ///  <note> 
        /// <para>
        /// Reboot options apply to <c>Install</c> operations only. Reboots aren't attempted for
        /// Patch Manager <c>Scan</c> operations.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>RebootIfNeeded</c>: Patch Manager tries to reboot the managed node if it installed
        /// any patches, or if any patches are detected with a status of <c>InstalledPendingReboot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoReboot</c>: Patch Manager attempts to install missing packages without trying
        /// to reboot the system. Patches installed with this option are assigned a status of
        /// <c>InstalledPendingReboot</c>. These patches might not be in effect until a reboot
        /// is performed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RebootOption RebootOption { get; set; }

        /// <summary>
        /// Checks to see if the RebootOption property is set.
        /// </summary>
        internal bool IsSetRebootOption() => this.RebootOption != null;

        /// <summary>
        /// Gets and sets the property SecurityNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as <c>Security</c> in a patch advisory
        /// aren't installed. These patches might be missing, have failed installation, were rejected,
        /// or were installed but awaiting a required managed node reboot. The status of these
        /// managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? SecurityNonCompliantCount { get; set; }

        /// <summary>
        /// Checks to see if the SecurityNonCompliantCount property is set.
        /// </summary>
        internal bool IsSetSecurityNonCompliantCount() => this.SecurityNonCompliantCount.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the patch baseline snapshot used during the patching operation when this
        /// compliance data was collected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property UnreportedNotApplicableCount. 
        /// <para>
        /// The number of patches beyond the supported limit of <c>NotApplicableCount</c> that
        /// aren't reported by name to Inventory. Inventory is a tool in Amazon Web Services Systems
        /// Manager.
        /// </para>
        /// </summary>
        public int? UnreportedNotApplicableCount { get; set; }

        /// <summary>
        /// Checks to see if the UnreportedNotApplicableCount property is set.
        /// </summary>
        internal bool IsSetUnreportedNotApplicableCount() => this.UnreportedNotApplicableCount.HasValue;
    }
}
