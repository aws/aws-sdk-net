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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An instance type that the specified Amazon EMR release supports.
    /// </summary>
    public partial class SupportedInstanceType
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture, for example <c>X86_64</c> or <c>AARCH64</c>.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property EbsOptimizedAvailable. 
        /// <para>
        /// Indicates whether the <c>SupportedInstanceType</c> supports Amazon EBS optimization.
        /// </para>
        /// </summary>
        public bool? EbsOptimizedAvailable { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimizedAvailable property is set.
        /// </summary>
        internal bool IsSetEbsOptimizedAvailable() => this.EbsOptimizedAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimizedByDefault. 
        /// <para>
        /// Indicates whether the <c>SupportedInstanceType</c> uses Amazon EBS optimization by
        /// default.
        /// </para>
        /// </summary>
        public bool? EbsOptimizedByDefault { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimizedByDefault property is set.
        /// </summary>
        internal bool IsSetEbsOptimizedByDefault() => this.EbsOptimizedByDefault.HasValue;

        /// <summary>
        /// Gets and sets the property EbsStorageOnly. 
        /// <para>
        /// Indicates whether the <c>SupportedInstanceType</c> only supports Amazon EBS.
        /// </para>
        /// </summary>
        public bool? EbsStorageOnly { get; set; }

        /// <summary>
        /// Checks to see if the EbsStorageOnly property is set.
        /// </summary>
        internal bool IsSetEbsStorageOnly() => this.EbsStorageOnly.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceFamilyId. 
        /// <para>
        /// The Amazon EC2 family and generation for the <c>SupportedInstanceType</c>.
        /// </para>
        /// </summary>
        public string InstanceFamilyId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamilyId property is set.
        /// </summary>
        internal bool IsSetInstanceFamilyId() => this.InstanceFamilyId != null;

        /// <summary>
        /// Gets and sets the property Is64BitsOnly. 
        /// <para>
        /// Indicates whether the <c>SupportedInstanceType</c> only supports 64-bit architecture.
        /// </para>
        /// </summary>
        public bool? Is64BitsOnly { get; set; }

        /// <summary>
        /// Checks to see if the Is64BitsOnly property is set.
        /// </summary>
        internal bool IsSetIs64BitsOnly() => this.Is64BitsOnly.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryGB. 
        /// <para>
        /// The amount of memory that is available to Amazon EMR from the <c>SupportedInstanceType</c>.
        /// The kernel and hypervisor software consume some memory, so this value might be lower
        /// than the overall memory for the instance type.
        /// </para>
        /// </summary>
        public float? MemoryGB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryGB property is set.
        /// </summary>
        internal bool IsSetMemoryGB() => this.MemoryGB.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDisks. 
        /// <para>
        /// Number of disks for the <c>SupportedInstanceType</c>. This value is <c>0</c> for Amazon
        /// EBS-only instance types.
        /// </para>
        /// </summary>
        public int? NumberOfDisks { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDisks property is set.
        /// </summary>
        internal bool IsSetNumberOfDisks() => this.NumberOfDisks.HasValue;

        /// <summary>
        /// Gets and sets the property StorageGB. 
        /// <para>
        ///  <c>StorageGB</c> represents the storage capacity of the <c>SupportedInstanceType</c>.
        /// This value is <c>0</c> for Amazon EBS-only instance types.
        /// </para>
        /// </summary>
        public int? StorageGB { get; set; }

        /// <summary>
        /// Checks to see if the StorageGB property is set.
        /// </summary>
        internal bool IsSetStorageGB() => this.StorageGB.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 instance type</a>,
        /// for example <c>m5.xlarge</c>, of the <c>SupportedInstanceType</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VCPU. 
        /// <para>
        /// The number of vCPUs available for the <c>SupportedInstanceType</c>.
        /// </para>
        /// </summary>
        public int? VCPU { get; set; }

        /// <summary>
        /// Checks to see if the VCPU property is set.
        /// </summary>
        internal bool IsSetVCPU() => this.VCPU.HasValue;
    }
}
