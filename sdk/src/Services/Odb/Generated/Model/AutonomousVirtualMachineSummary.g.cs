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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of an Autonomous Virtual Machine (VM) within an Autonomous VM cluster.
    /// </summary>
    public partial class AutonomousVirtualMachineSummary
    {
        /// <summary>
        /// Gets and sets the property AutonomousVirtualMachineId. 
        /// <para>
        /// The unique identifier of the Autonomous VM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string AutonomousVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetAutonomousVirtualMachineId() => this.AutonomousVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property ClientIpAddress. 
        /// <para>
        /// The IP address used by clients to connect to this Autonomous VM.
        /// </para>
        /// </summary>
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the ClientIpAddress property is set.
        /// </summary>
        internal bool IsSetClientIpAddress() => this.ClientIpAddress != null;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster containing this Autonomous VM.
        /// </para>
        /// </summary>
        public string CloudAutonomousVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CloudAutonomousVmClusterId property is set.
        /// </summary>
        internal bool IsSetCloudAutonomousVmClusterId() => this.CloudAutonomousVmClusterId != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores allocated to this Autonomous VM.
        /// </para>
        /// </summary>
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of storage allocated to this Autonomous Virtual Machine, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServerDisplayName. 
        /// <para>
        /// The display name of the database server hosting this Autonomous VM.
        /// </para>
        /// </summary>
        public string DbServerDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DbServerDisplayName property is set.
        /// </summary>
        internal bool IsSetDbServerDisplayName() => this.DbServerDisplayName != null;

        /// <summary>
        /// Gets and sets the property DbServerId. 
        /// <para>
        /// The unique identifier of the database server hosting this Autonomous VM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string DbServerId { get; set; }

        /// <summary>
        /// Checks to see if the DbServerId property is set.
        /// </summary>
        internal bool IsSetDbServerId() => this.DbServerId != null;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory allocated to this Autonomous VM, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the Oracle Cloud Infrastructure (OCI) resource anchor associated with
        /// this Autonomous VM.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous VM.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous VM.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous VM, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the Autonomous VM.
        /// </para>
        /// </summary>
        public string VmName { get; set; }

        /// <summary>
        /// Checks to see if the VmName property is set.
        /// </summary>
        internal bool IsSetVmName() => this.VmName != null;
    }
}
