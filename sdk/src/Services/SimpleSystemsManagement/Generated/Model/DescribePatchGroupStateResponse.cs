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
    /// This is the response object from the DescribePatchGroupState operation.
    /// </summary>
    public partial class DescribePatchGroupStateResponse : AmazonWebServiceResponse
    {
        private int? _instances;
        private int? _instancesWithAvailableSecurityUpdates;
        private int? _instancesWithCriticalNonCompliantPatches;
        private int? _instancesWithFailedPatches;
        private int? _instancesWithInstalledOtherPatches;
        private int? _instancesWithInstalledPatches;
        private int? _instancesWithInstalledPendingRebootPatches;
        private int? _instancesWithInstalledRejectedPatches;
        private int? _instancesWithMissingPatches;
        private int? _instancesWithNotApplicablePatches;
        private int? _instancesWithOtherNonCompliantPatches;
        private int? _instancesWithSecurityNonCompliantPatches;
        private int? _instancesWithUnreportedNotApplicablePatches;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The number of managed nodes in the patch group.
        /// </para>
        /// </summary>
        public int? Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithAvailableSecurityUpdates. 
        /// <para>
        /// The number of managed nodes for which security-related patches are available but not
        /// approved because because they didn't meet the patch baseline requirements. For example,
        /// an updated version of a patch might have been released before the specified auto-approval
        /// period was over.
        /// </para>
        ///  
        /// <para>
        /// Applies to Windows Server managed nodes only.
        /// </para>
        /// </summary>
        public int? InstancesWithAvailableSecurityUpdates
        {
            get { return this._instancesWithAvailableSecurityUpdates; }
            set { this._instancesWithAvailableSecurityUpdates = value; }
        }

        // Check to see if InstancesWithAvailableSecurityUpdates property is set
        internal bool IsSetInstancesWithAvailableSecurityUpdates()
        {
            return this._instancesWithAvailableSecurityUpdates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithCriticalNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes where patches that are specified as <c>Critical</c> for
        /// compliance reporting in the patch baseline aren't installed. These patches might be
        /// missing, have failed installation, were rejected, or were installed but awaiting a
        /// required managed node reboot. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithCriticalNonCompliantPatches
        {
            get { return this._instancesWithCriticalNonCompliantPatches; }
            set { this._instancesWithCriticalNonCompliantPatches = value; }
        }

        // Check to see if InstancesWithCriticalNonCompliantPatches property is set
        internal bool IsSetInstancesWithCriticalNonCompliantPatches()
        {
            return this._instancesWithCriticalNonCompliantPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithFailedPatches. 
        /// <para>
        /// The number of managed nodes with patches from the patch baseline that failed to install.
        /// </para>
        /// </summary>
        public int? InstancesWithFailedPatches
        {
            get { return this._instancesWithFailedPatches; }
            set { this._instancesWithFailedPatches = value; }
        }

        // Check to see if InstancesWithFailedPatches property is set
        internal bool IsSetInstancesWithFailedPatches()
        {
            return this._instancesWithFailedPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledOtherPatches. 
        /// <para>
        /// The number of managed nodes with patches installed that aren't defined in the patch
        /// baseline.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledOtherPatches
        {
            get { return this._instancesWithInstalledOtherPatches; }
            set { this._instancesWithInstalledOtherPatches = value; }
        }

        // Check to see if InstancesWithInstalledOtherPatches property is set
        internal bool IsSetInstancesWithInstalledOtherPatches()
        {
            return this._instancesWithInstalledOtherPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledPatches. 
        /// <para>
        /// The number of managed nodes with installed patches.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledPatches
        {
            get { return this._instancesWithInstalledPatches; }
            set { this._instancesWithInstalledPatches = value; }
        }

        // Check to see if InstancesWithInstalledPatches property is set
        internal bool IsSetInstancesWithInstalledPatches()
        {
            return this._instancesWithInstalledPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledPendingRebootPatches. 
        /// <para>
        /// The number of managed nodes with patches installed by Patch Manager that haven't been
        /// rebooted after the patch installation. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledPendingRebootPatches
        {
            get { return this._instancesWithInstalledPendingRebootPatches; }
            set { this._instancesWithInstalledPendingRebootPatches = value; }
        }

        // Check to see if InstancesWithInstalledPendingRebootPatches property is set
        internal bool IsSetInstancesWithInstalledPendingRebootPatches()
        {
            return this._instancesWithInstalledPendingRebootPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledRejectedPatches. 
        /// <para>
        /// The number of managed nodes with patches installed that are specified in a <c>RejectedPatches</c>
        /// list. Patches with a status of <c>INSTALLED_REJECTED</c> were typically installed
        /// before they were added to a <c>RejectedPatches</c> list.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>ALLOW_AS_DEPENDENCY</c> is the specified option for <c>RejectedPatchesAction</c>,
        /// the value of <c>InstancesWithInstalledRejectedPatches</c> will always be <c>0</c>
        /// (zero).
        /// </para>
        ///  </note>
        /// </summary>
        public int? InstancesWithInstalledRejectedPatches
        {
            get { return this._instancesWithInstalledRejectedPatches; }
            set { this._instancesWithInstalledRejectedPatches = value; }
        }

        // Check to see if InstancesWithInstalledRejectedPatches property is set
        internal bool IsSetInstancesWithInstalledRejectedPatches()
        {
            return this._instancesWithInstalledRejectedPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithMissingPatches. 
        /// <para>
        /// The number of managed nodes with missing patches from the patch baseline.
        /// </para>
        /// </summary>
        public int? InstancesWithMissingPatches
        {
            get { return this._instancesWithMissingPatches; }
            set { this._instancesWithMissingPatches = value; }
        }

        // Check to see if InstancesWithMissingPatches property is set
        internal bool IsSetInstancesWithMissingPatches()
        {
            return this._instancesWithMissingPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithNotApplicablePatches. 
        /// <para>
        /// The number of managed nodes with patches that aren't applicable.
        /// </para>
        /// </summary>
        public int? InstancesWithNotApplicablePatches
        {
            get { return this._instancesWithNotApplicablePatches; }
            set { this._instancesWithNotApplicablePatches = value; }
        }

        // Check to see if InstancesWithNotApplicablePatches property is set
        internal bool IsSetInstancesWithNotApplicablePatches()
        {
            return this._instancesWithNotApplicablePatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithOtherNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes with patches installed that are specified as other than
        /// <c>Critical</c> or <c>Security</c> but aren't compliant with the patch baseline. The
        /// status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithOtherNonCompliantPatches
        {
            get { return this._instancesWithOtherNonCompliantPatches; }
            set { this._instancesWithOtherNonCompliantPatches = value; }
        }

        // Check to see if InstancesWithOtherNonCompliantPatches property is set
        internal bool IsSetInstancesWithOtherNonCompliantPatches()
        {
            return this._instancesWithOtherNonCompliantPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithSecurityNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes where patches that are specified as <c>Security</c> in
        /// a patch advisory aren't installed. These patches might be missing, have failed installation,
        /// were rejected, or were installed but awaiting a required managed node reboot. The
        /// status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithSecurityNonCompliantPatches
        {
            get { return this._instancesWithSecurityNonCompliantPatches; }
            set { this._instancesWithSecurityNonCompliantPatches = value; }
        }

        // Check to see if InstancesWithSecurityNonCompliantPatches property is set
        internal bool IsSetInstancesWithSecurityNonCompliantPatches()
        {
            return this._instancesWithSecurityNonCompliantPatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstancesWithUnreportedNotApplicablePatches. 
        /// <para>
        /// The number of managed nodes with <c>NotApplicable</c> patches beyond the supported
        /// limit, which aren't reported by name to Inventory. Inventory is a tool in Amazon Web
        /// Services Systems Manager.
        /// </para>
        /// </summary>
        public int? InstancesWithUnreportedNotApplicablePatches
        {
            get { return this._instancesWithUnreportedNotApplicablePatches; }
            set { this._instancesWithUnreportedNotApplicablePatches = value; }
        }

        // Check to see if InstancesWithUnreportedNotApplicablePatches property is set
        internal bool IsSetInstancesWithUnreportedNotApplicablePatches()
        {
            return this._instancesWithUnreportedNotApplicablePatches.HasValue; 
        }

    }
}