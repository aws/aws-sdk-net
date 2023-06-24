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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Your <code>VirtualMachine</code> objects, ordered by their Amazon Resource Names (ARNs).
    /// </summary>
    public partial class VirtualMachineDetails
    {
        private string _hostName;
        private string _hypervisorId;
        private DateTime? _lastBackupDate;
        private string _name;
        private string _path;
        private string _resourceArn;
        private List<VmwareTag> _vmwareTags = new List<VmwareTag>();

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The host name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property HypervisorId. 
        /// <para>
        /// The ID of the virtual machine's hypervisor.
        /// </para>
        /// </summary>
        public string HypervisorId
        {
            get { return this._hypervisorId; }
            set { this._hypervisorId = value; }
        }

        // Check to see if HypervisorId property is set
        internal bool IsSetHypervisorId()
        {
            return this._hypervisorId != null;
        }

        /// <summary>
        /// Gets and sets the property LastBackupDate. 
        /// <para>
        /// The most recent date a virtual machine was backed up, in Unix format and UTC time.
        /// </para>
        /// </summary>
        public DateTime LastBackupDate
        {
            get { return this._lastBackupDate.GetValueOrDefault(); }
            set { this._lastBackupDate = value; }
        }

        // Check to see if LastBackupDate property is set
        internal bool IsSetLastBackupDate()
        {
            return this._lastBackupDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual machine. For example, <code>arn:aws:backup-gateway:us-west-1:0000000000000:vm/vm-0000ABCDEFGIJKL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property VmwareTags. 
        /// <para>
        /// These are the details of the VMware tags associated with the specified virtual machine.
        /// </para>
        /// </summary>
        public List<VmwareTag> VmwareTags
        {
            get { return this._vmwareTags; }
            set { this._vmwareTags = value; }
        }

        // Check to see if VmwareTags property is set
        internal bool IsSetVmwareTags()
        {
            return this._vmwareTags != null && this._vmwareTags.Count > 0; 
        }

    }
}