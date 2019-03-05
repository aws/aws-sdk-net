/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeCache operation.
    /// </summary>
    public partial class DescribeCacheResponse : AmazonWebServiceResponse
    {
        private long? _cacheAllocatedInBytes;
        private double? _cacheDirtyPercentage;
        private double? _cacheHitPercentage;
        private double? _cacheMissPercentage;
        private double? _cacheUsedPercentage;
        private List<string> _diskIds = new List<string>();
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property CacheAllocatedInBytes. 
        /// <para>
        /// The amount of cache in bytes allocated to the a gateway.
        /// </para>
        /// </summary>
        public long CacheAllocatedInBytes
        {
            get { return this._cacheAllocatedInBytes.GetValueOrDefault(); }
            set { this._cacheAllocatedInBytes = value; }
        }

        // Check to see if CacheAllocatedInBytes property is set
        internal bool IsSetCacheAllocatedInBytes()
        {
            return this._cacheAllocatedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheDirtyPercentage. 
        /// <para>
        /// The file share's contribution to the overall percentage of the gateway's cache that
        /// has not been persisted to AWS. The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double CacheDirtyPercentage
        {
            get { return this._cacheDirtyPercentage.GetValueOrDefault(); }
            set { this._cacheDirtyPercentage = value; }
        }

        // Check to see if CacheDirtyPercentage property is set
        internal bool IsSetCacheDirtyPercentage()
        {
            return this._cacheDirtyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheHitPercentage. 
        /// <para>
        /// Percent of application read operations from the file shares that are served from cache.
        /// The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double CacheHitPercentage
        {
            get { return this._cacheHitPercentage.GetValueOrDefault(); }
            set { this._cacheHitPercentage = value; }
        }

        // Check to see if CacheHitPercentage property is set
        internal bool IsSetCacheHitPercentage()
        {
            return this._cacheHitPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheMissPercentage.
        /// </summary>
        public double CacheMissPercentage
        {
            get { return this._cacheMissPercentage.GetValueOrDefault(); }
            set { this._cacheMissPercentage = value; }
        }

        // Check to see if CacheMissPercentage property is set
        internal bool IsSetCacheMissPercentage()
        {
            return this._cacheMissPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheUsedPercentage. 
        /// <para>
        /// Percent use of the gateway's cache storage. This metric applies only to the gateway-cached
        /// volume setup. The sample is taken at the end of the reporting period.
        /// </para>
        /// </summary>
        public double CacheUsedPercentage
        {
            get { return this._cacheUsedPercentage.GetValueOrDefault(); }
            set { this._cacheUsedPercentage = value; }
        }

        // Check to see if CacheUsedPercentage property is set
        internal bool IsSetCacheUsedPercentage()
        {
            return this._cacheUsedPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskIds. 
        /// <para>
        /// An array of strings that identify disks that are to be configured as working storage.
        /// Each string have a minimum length of 1 and maximum length of 300. You can get the
        /// disk IDs from the <a>ListLocalDisks</a> API.
        /// </para>
        /// </summary>
        public List<string> DiskIds
        {
            get { return this._diskIds; }
            set { this._diskIds = value; }
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this._diskIds != null && this._diskIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}