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
    /// Information about the state of a patch on a particular managed node as it relates
    /// to the patch baseline used to patch the node.
    /// </summary>
    public partial class PatchComplianceData
    {
        private string _classification;
        private string _cveIds;
        private DateTime? _installedTime;
        private string _kbId;
        private string _severity;
        private PatchComplianceDataState _state;
        private string _title;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the patch, such as <c>SecurityUpdates</c>, <c>Updates</c>, and
        /// <c>CriticalUpdates</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

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
        public string CVEIds
        {
            get { return this._cveIds; }
            set { this._cveIds = value; }
        }

        // Check to see if CVEIds property is set
        internal bool IsSetCVEIds()
        {
            return this._cveIds != null;
        }

        /// <summary>
        /// Gets and sets the property InstalledTime. 
        /// <para>
        /// The date/time the patch was installed on the managed node. Not all operating systems
        /// provide this level of information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? InstalledTime
        {
            get { return this._installedTime; }
            set { this._installedTime = value; }
        }

        // Check to see if InstalledTime property is set
        internal bool IsSetInstalledTime()
        {
            return this._installedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KBId. 
        /// <para>
        /// The operating system-specific ID of the patch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KBId
        {
            get { return this._kbId; }
            set { this._kbId = value; }
        }

        // Check to see if KBId property is set
        internal bool IsSetKBId()
        {
            return this._kbId != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the patch such as <c>Critical</c>, <c>Important</c>, and <c>Moderate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

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
        [AWSProperty(Required=true)]
        public PatchComplianceDataState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the patch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}