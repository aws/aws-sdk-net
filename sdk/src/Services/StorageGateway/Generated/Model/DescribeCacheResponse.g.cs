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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeCache operation.
    /// </summary>
    public partial class DescribeCacheResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CacheAllocatedInBytes. 
        /// <para>
        /// The amount of cache in bytes allocated to a gateway.
        /// </para>
        /// </summary>
        public long? CacheAllocatedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the CacheAllocatedInBytes property is set.
        /// </summary>
        internal bool IsSetCacheAllocatedInBytes() => this.CacheAllocatedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property CacheDirtyPercentage. 
        /// <para>
        /// The file share's contribution to the overall percentage of the gateway's cache that
        /// has not been persisted to Amazon Web Services. The sample is taken at the end of the
        /// reporting period.
        /// </para>
        /// </summary>
        public double? CacheDirtyPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CacheDirtyPercentage property is set.
        /// </summary>
        internal bool IsSetCacheDirtyPercentage() => this.CacheDirtyPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property CacheHitPercentage. 
        /// <para>
        /// Percent of application read operations from the file shares that are served from cache.
        /// The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double? CacheHitPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CacheHitPercentage property is set.
        /// </summary>
        internal bool IsSetCacheHitPercentage() => this.CacheHitPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property CacheMissPercentage. 
        /// <para>
        /// Percent of application read operations from the file shares that are not served from
        /// cache. The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double? CacheMissPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CacheMissPercentage property is set.
        /// </summary>
        internal bool IsSetCacheMissPercentage() => this.CacheMissPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property CacheUsedPercentage. 
        /// <para>
        /// Percent use of the gateway's cache storage. This metric applies only to the gateway-cached
        /// volume setup. The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double? CacheUsedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CacheUsedPercentage property is set.
        /// </summary>
        internal bool IsSetCacheUsedPercentage() => this.CacheUsedPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property DiskIds. 
        /// <para>
        /// An array of strings that identify disks that are to be configured as working storage.
        /// Each string has a minimum length of 1 and maximum length of 300. You can get the disk
        /// IDs from the <a>ListLocalDisks</a> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DiskIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DiskIds property is set.
        /// </summary>
        internal bool IsSetDiskIds() => this.DiskIds != null && (this.DiskIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;
    }
}
