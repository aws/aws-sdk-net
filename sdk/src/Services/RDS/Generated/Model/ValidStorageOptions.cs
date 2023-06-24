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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about valid modifications that you can make to your DB instance. Contains
    /// the result of a successful call to the <code>DescribeValidDBInstanceModifications</code>
    /// action.
    /// </summary>
    public partial class ValidStorageOptions
    {
        private List<DoubleRange> _iopsToStorageRatio = new List<DoubleRange>();
        private List<Range> _provisionedIops = new List<Range>();
        private List<Range> _provisionedStorageThroughput = new List<Range>();
        private List<Range> _storageSize = new List<Range>();
        private List<DoubleRange> _storageThroughputToIopsRatio = new List<DoubleRange>();
        private string _storageType;
        private bool? _supportsStorageAutoscaling;

        /// <summary>
        /// Gets and sets the property IopsToStorageRatio. 
        /// <para>
        /// The valid range of Provisioned IOPS to gibibytes of storage multiplier. For example,
        /// 3-10, which means that provisioned IOPS can be between 3 and 10 times storage.
        /// </para>
        /// </summary>
        public List<DoubleRange> IopsToStorageRatio
        {
            get { return this._iopsToStorageRatio; }
            set { this._iopsToStorageRatio = value; }
        }

        // Check to see if IopsToStorageRatio property is set
        internal bool IsSetIopsToStorageRatio()
        {
            return this._iopsToStorageRatio != null && this._iopsToStorageRatio.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedIops. 
        /// <para>
        /// The valid range of provisioned IOPS. For example, 1000-256,000.
        /// </para>
        /// </summary>
        public List<Range> ProvisionedIops
        {
            get { return this._provisionedIops; }
            set { this._provisionedIops = value; }
        }

        // Check to see if ProvisionedIops property is set
        internal bool IsSetProvisionedIops()
        {
            return this._provisionedIops != null && this._provisionedIops.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedStorageThroughput. 
        /// <para>
        /// The valid range of provisioned storage throughput. For example, 500-4,000 mebibytes
        /// per second (MiBps).
        /// </para>
        /// </summary>
        public List<Range> ProvisionedStorageThroughput
        {
            get { return this._provisionedStorageThroughput; }
            set { this._provisionedStorageThroughput = value; }
        }

        // Check to see if ProvisionedStorageThroughput property is set
        internal bool IsSetProvisionedStorageThroughput()
        {
            return this._provisionedStorageThroughput != null && this._provisionedStorageThroughput.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The valid range of storage in gibibytes (GiB). For example, 100 to 16,384.
        /// </para>
        /// </summary>
        public List<Range> StorageSize
        {
            get { return this._storageSize; }
            set { this._storageSize = value; }
        }

        // Check to see if StorageSize property is set
        internal bool IsSetStorageSize()
        {
            return this._storageSize != null && this._storageSize.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageThroughputToIopsRatio. 
        /// <para>
        /// The valid range of storage throughput to provisioned IOPS ratios. For example, 0-0.25.
        /// </para>
        /// </summary>
        public List<DoubleRange> StorageThroughputToIopsRatio
        {
            get { return this._storageThroughputToIopsRatio; }
            set { this._storageThroughputToIopsRatio = value; }
        }

        // Check to see if StorageThroughputToIopsRatio property is set
        internal bool IsSetStorageThroughputToIopsRatio()
        {
            return this._storageThroughputToIopsRatio != null && this._storageThroughputToIopsRatio.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The valid storage types for your DB instance. For example: gp2, gp3, io1.
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageAutoscaling. 
        /// <para>
        /// Whether or not Amazon RDS can automatically scale storage for DB instances that use
        /// the new instance class.
        /// </para>
        /// </summary>
        public bool SupportsStorageAutoscaling
        {
            get { return this._supportsStorageAutoscaling.GetValueOrDefault(); }
            set { this._supportsStorageAutoscaling = value; }
        }

        // Check to see if SupportsStorageAutoscaling property is set
        internal bool IsSetSupportsStorageAutoscaling()
        {
            return this._supportsStorageAutoscaling.HasValue; 
        }

    }
}