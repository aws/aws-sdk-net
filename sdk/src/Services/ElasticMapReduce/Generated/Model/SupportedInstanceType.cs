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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An instance type that the specified Amazon EMR release supports.
    /// </summary>
    public partial class SupportedInstanceType
    {
        private string _architecture;
        private bool? _ebsOptimizedAvailable;
        private bool? _ebsOptimizedByDefault;
        private bool? _ebsStorageOnly;
        private string _instanceFamilyId;
        private bool? _is64BitsOnly;
        private float? _memoryGB;
        private int? _numberOfDisks;
        private int? _storageGB;
        private string _type;
        private int? _vcpu;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture, for example <code>X86_64</code> or <code>AARCH64</code>.
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimizedAvailable. 
        /// <para>
        /// Indicates whether the <code>SupportedInstanceType</code> supports Amazon EBS optimization.
        /// </para>
        /// </summary>
        public bool EbsOptimizedAvailable
        {
            get { return this._ebsOptimizedAvailable.GetValueOrDefault(); }
            set { this._ebsOptimizedAvailable = value; }
        }

        // Check to see if EbsOptimizedAvailable property is set
        internal bool IsSetEbsOptimizedAvailable()
        {
            return this._ebsOptimizedAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimizedByDefault. 
        /// <para>
        /// Indicates whether the <code>SupportedInstanceType</code> uses Amazon EBS optimization
        /// by default.
        /// </para>
        /// </summary>
        public bool EbsOptimizedByDefault
        {
            get { return this._ebsOptimizedByDefault.GetValueOrDefault(); }
            set { this._ebsOptimizedByDefault = value; }
        }

        // Check to see if EbsOptimizedByDefault property is set
        internal bool IsSetEbsOptimizedByDefault()
        {
            return this._ebsOptimizedByDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsStorageOnly. 
        /// <para>
        /// Indicates whether the <code>SupportedInstanceType</code> only supports Amazon EBS.
        /// </para>
        /// </summary>
        public bool EbsStorageOnly
        {
            get { return this._ebsStorageOnly.GetValueOrDefault(); }
            set { this._ebsStorageOnly = value; }
        }

        // Check to see if EbsStorageOnly property is set
        internal bool IsSetEbsStorageOnly()
        {
            return this._ebsStorageOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceFamilyId. 
        /// <para>
        /// The Amazon EC2 family and generation for the <code>SupportedInstanceType</code>.
        /// </para>
        /// </summary>
        public string InstanceFamilyId
        {
            get { return this._instanceFamilyId; }
            set { this._instanceFamilyId = value; }
        }

        // Check to see if InstanceFamilyId property is set
        internal bool IsSetInstanceFamilyId()
        {
            return this._instanceFamilyId != null;
        }

        /// <summary>
        /// Gets and sets the property Is64BitsOnly. 
        /// <para>
        /// Indicates whether the <code>SupportedInstanceType</code> only supports 64-bit architecture.
        /// </para>
        /// </summary>
        public bool Is64BitsOnly
        {
            get { return this._is64BitsOnly.GetValueOrDefault(); }
            set { this._is64BitsOnly = value; }
        }

        // Check to see if Is64BitsOnly property is set
        internal bool IsSetIs64BitsOnly()
        {
            return this._is64BitsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryGB. 
        /// <para>
        /// The amount of memory that is available to Amazon EMR from the <code>SupportedInstanceType</code>.
        /// The kernel and hypervisor software consume some memory, so this value might be lower
        /// than the overall memory for the instance type.
        /// </para>
        /// </summary>
        public float MemoryGB
        {
            get { return this._memoryGB.GetValueOrDefault(); }
            set { this._memoryGB = value; }
        }

        // Check to see if MemoryGB property is set
        internal bool IsSetMemoryGB()
        {
            return this._memoryGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDisks. 
        /// <para>
        /// Number of disks for the <code>SupportedInstanceType</code>. This value is <code>0</code>
        /// for Amazon EBS-only instance types.
        /// </para>
        /// </summary>
        public int NumberOfDisks
        {
            get { return this._numberOfDisks.GetValueOrDefault(); }
            set { this._numberOfDisks = value; }
        }

        // Check to see if NumberOfDisks property is set
        internal bool IsSetNumberOfDisks()
        {
            return this._numberOfDisks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageGB. 
        /// <para>
        ///  <code>StorageGB</code> represents the storage capacity of the <code>SupportedInstanceType</code>.
        /// This value is <code>0</code> for Amazon EBS-only instance types.
        /// </para>
        /// </summary>
        public int StorageGB
        {
            get { return this._storageGB.GetValueOrDefault(); }
            set { this._storageGB = value; }
        }

        // Check to see if StorageGB property is set
        internal bool IsSetStorageGB()
        {
            return this._storageGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 instance type</a>,
        /// for example <code>m5.xlarge</code>, of the <code>SupportedInstanceType</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VCPU. 
        /// <para>
        /// The number of vCPUs available for the <code>SupportedInstanceType</code>.
        /// </para>
        /// </summary>
        public int VCPU
        {
            get { return this._vcpu.GetValueOrDefault(); }
            set { this._vcpu = value; }
        }

        // Check to see if VCPU property is set
        internal bool IsSetVCPU()
        {
            return this._vcpu.HasValue; 
        }

    }
}