/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines the high-level patch compliance state for a managed instance, providing information
    /// about the number of installed, missing, not applicable, and failed patches along with
    /// metadata about the operation when this information was gathered for the instance.
    /// </summary>
    public partial class InstancePatchState
    {
        private string _baselineId;
        private int? _failedCount;
        private int? _installedCount;
        private int? _installedOtherCount;
        private int? _installedPendingRebootCount;
        private int? _installedRejectedCount;
        private string _installOverrideList;
        private string _instanceId;
        private DateTime? _lastNoRebootInstallOperationTime;
        private int? _missingCount;
        private int? _notApplicableCount;
        private PatchOperationType _operation;
        private DateTime? _operationEndTime;
        private DateTime? _operationStartTime;
        private string _ownerInformation;
        private string _patchGroup;
        private RebootOption _rebootOption;
        private string _snapshotId;
        private int? _unreportedNotApplicableCount;

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline used to patch the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string BaselineId
        {
            get { return this._baselineId; }
            set { this._baselineId = value; }
        }

        // Check to see if BaselineId property is set
        internal bool IsSetBaselineId()
        {
            return this._baselineId != null;
        }

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of patches from the patch baseline that were attempted to be installed
        /// during the last patching operation, but failed to install.
        /// </para>
        /// </summary>
        public int FailedCount
        {
            get { return this._failedCount.GetValueOrDefault(); }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledCount. 
        /// <para>
        /// The number of patches from the patch baseline that are installed on the instance.
        /// </para>
        /// </summary>
        public int InstalledCount
        {
            get { return this._installedCount.GetValueOrDefault(); }
            set { this._installedCount = value; }
        }

        // Check to see if InstalledCount property is set
        internal bool IsSetInstalledCount()
        {
            return this._installedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledOtherCount. 
        /// <para>
        /// The number of patches not specified in the patch baseline that are installed on the
        /// instance.
        /// </para>
        /// </summary>
        public int InstalledOtherCount
        {
            get { return this._installedOtherCount.GetValueOrDefault(); }
            set { this._installedOtherCount = value; }
        }

        // Check to see if InstalledOtherCount property is set
        internal bool IsSetInstalledOtherCount()
        {
            return this._installedOtherCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledPendingRebootCount. 
        /// <para>
        /// The number of patches installed by Patch Manager since the last time the instance
        /// was rebooted.
        /// </para>
        /// </summary>
        public int InstalledPendingRebootCount
        {
            get { return this._installedPendingRebootCount.GetValueOrDefault(); }
            set { this._installedPendingRebootCount = value; }
        }

        // Check to see if InstalledPendingRebootCount property is set
        internal bool IsSetInstalledPendingRebootCount()
        {
            return this._installedPendingRebootCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledRejectedCount. 
        /// <para>
        /// The number of instances with patches installed that are specified in a RejectedPatches
        /// list. Patches with a status of <i>InstalledRejected</i> were typically installed before
        /// they were added to a RejectedPatches list.
        /// </para>
        ///  <note> 
        /// <para>
        /// If ALLOW_AS_DEPENDENCY is the specified option for RejectedPatchesAction, the value
        /// of InstalledRejectedCount will always be 0 (zero).
        /// </para>
        ///  </note>
        /// </summary>
        public int InstalledRejectedCount
        {
            get { return this._installedRejectedCount.GetValueOrDefault(); }
            set { this._installedRejectedCount = value; }
        }

        // Check to see if InstalledRejectedCount property is set
        internal bool IsSetInstalledRejectedCount()
        {
            return this._installedRejectedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstallOverrideList. 
        /// <para>
        /// An https URL or an Amazon S3 path-style URL to a list of patches to be installed.
        /// This patch installation list, which you maintain in an Amazon S3 bucket in YAML format
        /// and specify in the SSM document <code>AWS-RunPatchBaseline</code>, overrides the patches
        /// specified by the default patch baseline.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>InstallOverrideList</code> parameter, see <a
        /// href="http://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-about-aws-runpatchbaseline.html">About
        /// the SSM Document AWS-RunPatchBaseline</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InstallOverrideList
        {
            get { return this._installOverrideList; }
            set { this._installOverrideList = value; }
        }

        // Check to see if InstallOverrideList property is set
        internal bool IsSetInstallOverrideList()
        {
            return this._installOverrideList != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed instance the high-level patch compliance information was collected
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastNoRebootInstallOperationTime. 
        /// <para>
        /// The time of the last attempt to patch the instance with <code>NoReboot</code> specified
        /// as the reboot option.
        /// </para>
        /// </summary>
        public DateTime LastNoRebootInstallOperationTime
        {
            get { return this._lastNoRebootInstallOperationTime.GetValueOrDefault(); }
            set { this._lastNoRebootInstallOperationTime = value; }
        }

        // Check to see if LastNoRebootInstallOperationTime property is set
        internal bool IsSetLastNoRebootInstallOperationTime()
        {
            return this._lastNoRebootInstallOperationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissingCount. 
        /// <para>
        /// The number of patches from the patch baseline that are applicable for the instance
        /// but aren't currently installed.
        /// </para>
        /// </summary>
        public int MissingCount
        {
            get { return this._missingCount.GetValueOrDefault(); }
            set { this._missingCount = value; }
        }

        // Check to see if MissingCount property is set
        internal bool IsSetMissingCount()
        {
            return this._missingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotApplicableCount. 
        /// <para>
        /// The number of patches from the patch baseline that aren't applicable for the instance
        /// and therefore aren't installed on the instance. This number may be truncated if the
        /// list of patch names is very large. The number of patches beyond this limit are reported
        /// in <code>UnreportedNotApplicableCount</code>.
        /// </para>
        /// </summary>
        public int NotApplicableCount
        {
            get { return this._notApplicableCount.GetValueOrDefault(); }
            set { this._notApplicableCount = value; }
        }

        // Check to see if NotApplicableCount property is set
        internal bool IsSetNotApplicableCount()
        {
            return this._notApplicableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of patching operation that was performed: SCAN (assess patch compliance state)
        /// or INSTALL (install missing patches).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PatchOperationType Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationEndTime. 
        /// <para>
        /// The time the most recent patching operation completed on the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime OperationEndTime
        {
            get { return this._operationEndTime.GetValueOrDefault(); }
            set { this._operationEndTime = value; }
        }

        // Check to see if OperationEndTime property is set
        internal bool IsSetOperationEndTime()
        {
            return this._operationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationStartTime. 
        /// <para>
        /// The time the most recent patching operation was started on the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime OperationStartTime
        {
            get { return this._operationStartTime.GetValueOrDefault(); }
            set { this._operationStartTime = value; }
        }

        // Check to see if OperationStartTime property is set
        internal bool IsSetOperationStartTime()
        {
            return this._operationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// Placeholder information. This field will always be empty in the current release of
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OwnerInformation
        {
            get { return this._ownerInformation; }
            set { this._ownerInformation = value; }
        }

        // Check to see if OwnerInformation property is set
        internal bool IsSetOwnerInformation()
        {
            return this._ownerInformation != null;
        }

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group the managed instance belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PatchGroup
        {
            get { return this._patchGroup; }
            set { this._patchGroup = value; }
        }

        // Check to see if PatchGroup property is set
        internal bool IsSetPatchGroup()
        {
            return this._patchGroup != null;
        }

        /// <summary>
        /// Gets and sets the property RebootOption. 
        /// <para>
        /// Indicates the reboot option specified in the patch baseline.
        /// </para>
        ///  <note> 
        /// <para>
        /// Reboot options apply to <code>Install</code> operations only. Reboots are not attempted
        /// for Patch Manager <code>Scan</code> operations.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <b>RebootIfNeeded</b>: Patch Manager tries to reboot the instance if it installed
        /// any patches, or if any patches are detected with a status of <code>InstalledPendingReboot</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NoReboot</b>: Patch Manager attempts to install missing packages without trying
        /// to reboot the system. Patches installed with this option are assigned a status of
        /// <code>InstalledPendingReboot</code>. These patches might not be in effect until a
        /// reboot is performed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RebootOption RebootOption
        {
            get { return this._rebootOption; }
            set { this._rebootOption = value; }
        }

        // Check to see if RebootOption property is set
        internal bool IsSetRebootOption()
        {
            return this._rebootOption != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the patch baseline snapshot used during the patching operation when this
        /// compliance data was collected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property UnreportedNotApplicableCount. 
        /// <para>
        /// The number of patches beyond the supported limit of <code>NotApplicableCount</code>
        /// that are not reported by name to Systems Manager Inventory.
        /// </para>
        /// </summary>
        public int UnreportedNotApplicableCount
        {
            get { return this._unreportedNotApplicableCount.GetValueOrDefault(); }
            set { this._unreportedNotApplicableCount = value; }
        }

        // Check to see if UnreportedNotApplicableCount property is set
        internal bool IsSetUnreportedNotApplicableCount()
        {
            return this._unreportedNotApplicableCount.HasValue; 
        }

    }
}