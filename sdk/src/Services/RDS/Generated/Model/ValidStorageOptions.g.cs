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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about valid modifications that you can make to your DB instance. Contains
    /// the result of a successful call to the <c>DescribeValidDBInstanceModifications</c>
    /// action.
    /// </summary>
    public partial class ValidStorageOptions
    {
        /// <summary>
        /// Gets and sets the property IopsToStorageRatio. 
        /// <para>
        /// The valid range of Provisioned IOPS to gibibytes of storage multiplier. For example,
        /// 3-10, which means that provisioned IOPS can be between 3 and 10 times storage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DoubleRange> IopsToStorageRatio { get; set; } = AWSConfigs.InitializeCollections ? new List<DoubleRange>() : null;

        /// <summary>
        /// Checks to see if the IopsToStorageRatio property is set.
        /// </summary>
        internal bool IsSetIopsToStorageRatio() => this.IopsToStorageRatio != null && (this.IopsToStorageRatio.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionedIops. 
        /// <para>
        /// The valid range of provisioned IOPS. For example, 1000-256,000.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> ProvisionedIops { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the ProvisionedIops property is set.
        /// </summary>
        internal bool IsSetProvisionedIops() => this.ProvisionedIops != null && (this.ProvisionedIops.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionedStorageThroughput. 
        /// <para>
        /// The valid range of provisioned storage throughput. For example, 500-4,000 mebibytes
        /// per second (MiBps).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> ProvisionedStorageThroughput { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the ProvisionedStorageThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedStorageThroughput() => this.ProvisionedStorageThroughput != null && (this.ProvisionedStorageThroughput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The valid range of storage in gibibytes (GiB). For example, 100 to 16,384.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> StorageSize { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the StorageSize property is set.
        /// </summary>
        internal bool IsSetStorageSize() => this.StorageSize != null && (this.StorageSize.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageThroughputToIopsRatio. 
        /// <para>
        /// The valid range of storage throughput to provisioned IOPS ratios. For example, 0-0.25.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DoubleRange> StorageThroughputToIopsRatio { get; set; } = AWSConfigs.InitializeCollections ? new List<DoubleRange>() : null;

        /// <summary>
        /// Checks to see if the StorageThroughputToIopsRatio property is set.
        /// </summary>
        internal bool IsSetStorageThroughputToIopsRatio() => this.StorageThroughputToIopsRatio != null && (this.StorageThroughputToIopsRatio.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The valid storage types for your DB instance. For example: gp2, gp3, io1, io2.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SupportsStorageAutoscaling. 
        /// <para>
        /// Indicates whether or not Amazon RDS can automatically scale storage for DB instances
        /// that use the new instance class.
        /// </para>
        /// </summary>
        public bool? SupportsStorageAutoscaling { get; set; }

        /// <summary>
        /// Checks to see if the SupportsStorageAutoscaling property is set.
        /// </summary>
        internal bool IsSetSupportsStorageAutoscaling() => this.SupportsStorageAutoscaling.HasValue;
    }
}
