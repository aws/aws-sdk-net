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
    /// This is the response object from the DescribePatchGroupState operation.
    /// </summary>
    public partial class DescribePatchGroupStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The number of managed nodes in the patch group.
        /// </para>
        /// </summary>
        public int? Instances { get; set; }

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances.HasValue;

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
        public int? InstancesWithAvailableSecurityUpdates { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithAvailableSecurityUpdates property is set.
        /// </summary>
        internal bool IsSetInstancesWithAvailableSecurityUpdates() => this.InstancesWithAvailableSecurityUpdates.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithCriticalNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes where patches that are specified as <c>Critical</c> for
        /// compliance reporting in the patch baseline aren't installed. These patches might be
        /// missing, have failed installation, were rejected, or were installed but awaiting a
        /// required managed node reboot. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithCriticalNonCompliantPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithCriticalNonCompliantPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithCriticalNonCompliantPatches() => this.InstancesWithCriticalNonCompliantPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithFailedPatches. 
        /// <para>
        /// The number of managed nodes with patches from the patch baseline that failed to install.
        /// </para>
        /// </summary>
        public int? InstancesWithFailedPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithFailedPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithFailedPatches() => this.InstancesWithFailedPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledOtherPatches. 
        /// <para>
        /// The number of managed nodes with patches installed that aren't defined in the patch
        /// baseline.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledOtherPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithInstalledOtherPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithInstalledOtherPatches() => this.InstancesWithInstalledOtherPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledPatches. 
        /// <para>
        /// The number of managed nodes with installed patches.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithInstalledPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithInstalledPatches() => this.InstancesWithInstalledPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithInstalledPendingRebootPatches. 
        /// <para>
        /// The number of managed nodes with patches installed by Patch Manager that haven't been
        /// rebooted after the patch installation. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithInstalledPendingRebootPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithInstalledPendingRebootPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithInstalledPendingRebootPatches() => this.InstancesWithInstalledPendingRebootPatches.HasValue;

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
        public int? InstancesWithInstalledRejectedPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithInstalledRejectedPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithInstalledRejectedPatches() => this.InstancesWithInstalledRejectedPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithMissingPatches. 
        /// <para>
        /// The number of managed nodes with missing patches from the patch baseline.
        /// </para>
        /// </summary>
        public int? InstancesWithMissingPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithMissingPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithMissingPatches() => this.InstancesWithMissingPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithNotApplicablePatches. 
        /// <para>
        /// The number of managed nodes with patches that aren't applicable.
        /// </para>
        /// </summary>
        public int? InstancesWithNotApplicablePatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithNotApplicablePatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithNotApplicablePatches() => this.InstancesWithNotApplicablePatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithOtherNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes with patches installed that are specified as other than
        /// <c>Critical</c> or <c>Security</c> but aren't compliant with the patch baseline. The
        /// status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithOtherNonCompliantPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithOtherNonCompliantPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithOtherNonCompliantPatches() => this.InstancesWithOtherNonCompliantPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithSecurityNonCompliantPatches. 
        /// <para>
        /// The number of managed nodes where patches that are specified as <c>Security</c> in
        /// a patch advisory aren't installed. These patches might be missing, have failed installation,
        /// were rejected, or were installed but awaiting a required managed node reboot. The
        /// status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? InstancesWithSecurityNonCompliantPatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithSecurityNonCompliantPatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithSecurityNonCompliantPatches() => this.InstancesWithSecurityNonCompliantPatches.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesWithUnreportedNotApplicablePatches. 
        /// <para>
        /// The number of managed nodes with <c>NotApplicable</c> patches beyond the supported
        /// limit, which aren't reported by name to Inventory. Inventory is a tool in Amazon Web
        /// Services Systems Manager.
        /// </para>
        /// </summary>
        public int? InstancesWithUnreportedNotApplicablePatches { get; set; }

        /// <summary>
        /// Checks to see if the InstancesWithUnreportedNotApplicablePatches property is set.
        /// </summary>
        internal bool IsSetInstancesWithUnreportedNotApplicablePatches() => this.InstancesWithUnreportedNotApplicablePatches.HasValue;
    }
}
