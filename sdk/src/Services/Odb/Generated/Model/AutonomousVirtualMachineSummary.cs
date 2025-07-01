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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of an Autonomous Virtual Machine (VM) within an Autonomous VM cluster.
    /// </summary>
    public partial class AutonomousVirtualMachineSummary
    {
        private string _autonomousVirtualMachineId;
        private string _clientIpAddress;
        private string _cloudAutonomousVmClusterId;
        private int? _cpuCoreCount;
        private int? _dbNodeStorageSizeInGBs;
        private string _dbServerDisplayName;
        private string _dbServerId;
        private int? _memorySizeInGBs;
        private string _ocid;
        private string _ociResourceAnchorName;
        private ResourceStatus _status;
        private string _statusReason;
        private string _vmName;

        /// <summary>
        /// Gets and sets the property AutonomousVirtualMachineId. 
        /// <para>
        /// The unique identifier of the Autonomous VM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string AutonomousVirtualMachineId
        {
            get { return this._autonomousVirtualMachineId; }
            set { this._autonomousVirtualMachineId = value; }
        }

        // Check to see if AutonomousVirtualMachineId property is set
        internal bool IsSetAutonomousVirtualMachineId()
        {
            return this._autonomousVirtualMachineId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientIpAddress. 
        /// <para>
        /// The IP address used by clients to connect to this Autonomous VM.
        /// </para>
        /// </summary>
        public string ClientIpAddress
        {
            get { return this._clientIpAddress; }
            set { this._clientIpAddress = value; }
        }

        // Check to see if ClientIpAddress property is set
        internal bool IsSetClientIpAddress()
        {
            return this._clientIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster containing this Autonomous VM.
        /// </para>
        /// </summary>
        public string CloudAutonomousVmClusterId
        {
            get { return this._cloudAutonomousVmClusterId; }
            set { this._cloudAutonomousVmClusterId = value; }
        }

        // Check to see if CloudAutonomousVmClusterId property is set
        internal bool IsSetCloudAutonomousVmClusterId()
        {
            return this._cloudAutonomousVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores allocated to this Autonomous VM.
        /// </para>
        /// </summary>
        public int? CpuCoreCount
        {
            get { return this._cpuCoreCount; }
            set { this._cpuCoreCount = value; }
        }

        // Check to see if CpuCoreCount property is set
        internal bool IsSetCpuCoreCount()
        {
            return this._cpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of storage allocated to this Autonomous Virtual Machine, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs
        {
            get { return this._dbNodeStorageSizeInGBs; }
            set { this._dbNodeStorageSizeInGBs = value; }
        }

        // Check to see if DbNodeStorageSizeInGBs property is set
        internal bool IsSetDbNodeStorageSizeInGBs()
        {
            return this._dbNodeStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbServerDisplayName. 
        /// <para>
        /// The display name of the database server hosting this Autonomous VM.
        /// </para>
        /// </summary>
        public string DbServerDisplayName
        {
            get { return this._dbServerDisplayName; }
            set { this._dbServerDisplayName = value; }
        }

        // Check to see if DbServerDisplayName property is set
        internal bool IsSetDbServerDisplayName()
        {
            return this._dbServerDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier of the database server hosting this Autonomous VM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string DbServerId
        {
            get { return this._dbServerId; }
            set { this._dbServerId = value; }
        }

        // Check to see if DbServerId property is set
        internal bool IsSetDbServerId()
        {
            return this._dbServerId != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory allocated to this Autonomous VM, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs
        {
            get { return this._memorySizeInGBs; }
            set { this._memorySizeInGBs = value; }
        }

        // Check to see if MemorySizeInGBs property is set
        internal bool IsSetMemorySizeInGBs()
        {
            return this._memorySizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous VM.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the Oracle Cloud Infrastructure (OCI) resource anchor associated with
        /// this Autonomous VM.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous VM.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous VM, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the Autonomous VM.
        /// </para>
        /// </summary>
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }

        // Check to see if VmName property is set
        internal bool IsSetVmName()
        {
            return this._vmName != null;
        }

    }
}