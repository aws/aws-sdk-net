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
    /// Information about the state of a patch on a particular managed node as it relates
    /// to the patch baseline used to patch the node.
    /// </summary>
    public partial class PatchComplianceData
    {
        /// <summary>
        /// Gets and sets the property CVEIds. 
        /// <para>
        /// The IDs of one or more Common Vulnerabilities and Exposure (CVE) issues that are resolved
        /// by the patch.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, CVE ID values are reported only for patches with a status of <c>Missing</c>
        /// or <c>Failed</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string CVEIds { get; set; }

        /// <summary>
        /// Checks to see if the CVEIds property is set.
        /// </summary>
        internal bool IsSetCVEIds() => this.CVEIds != null;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the patch, such as <c>SecurityUpdates</c>, <c>Updates</c>, and
        /// <c>CriticalUpdates</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property InstalledTime. 
        /// <para>
        /// The date/time the patch was installed on the managed node. Not all operating systems
        /// provide this level of information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? InstalledTime { get; set; }

        /// <summary>
        /// Checks to see if the InstalledTime property is set.
        /// </summary>
        internal bool IsSetInstalledTime() => this.InstalledTime.HasValue;

        /// <summary>
        /// Gets and sets the property KBId. 
        /// <para>
        /// The operating system-specific ID of the patch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KBId { get; set; }

        /// <summary>
        /// Checks to see if the KBId property is set.
        /// </summary>
        internal bool IsSetKBId() => this.KBId != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the patch such as <c>Critical</c>, <c>Important</c>, and <c>Moderate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the patch on the managed node, such as INSTALLED or FAILED.
        /// </para>
        ///  
        /// <para>
        /// For descriptions of each patch state, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/compliance-about.html#compliance-monitor-patch">About
        /// patch compliance</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PatchComplianceDataState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the patch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
