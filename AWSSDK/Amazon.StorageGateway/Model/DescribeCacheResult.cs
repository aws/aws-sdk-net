/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Describe Cache Result
    /// </summary>
    public partial class DescribeCacheResult
    {
        
        private string gatewayARN;
        private List<string> diskIds = new List<string>();
        private long? cacheAllocatedInBytes;
        private double? cacheUsedPercentage;
        private double? cacheDirtyPercentage;
        private double? cacheHitPercentage;
        private double? cacheMissPercentage;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
        public List<string> DiskIds
        {
            get { return this.diskIds; }
            set { this.diskIds = value; }
        }
        /// <summary>
        /// Adds elements to the DiskIds collection
        /// </summary>
        /// <param name="diskIds">The values to add to the DiskIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithDiskIds(params string[] diskIds)
        {
            foreach (string element in diskIds)
            {
                this.diskIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DiskIds collection
        /// </summary>
        /// <param name="diskIds">The values to add to the DiskIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithDiskIds(IEnumerable<string> diskIds)
        {
            foreach (string element in diskIds)
            {
                this.diskIds.Add(element);
            }

            return this;
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this.diskIds.Count > 0;
        }
        public long CacheAllocatedInBytes
        {
            get { return this.cacheAllocatedInBytes ?? default(long); }
            set { this.cacheAllocatedInBytes = value; }
        }

        /// <summary>
        /// Sets the CacheAllocatedInBytes property
        /// </summary>
        /// <param name="cacheAllocatedInBytes">The value to set for the CacheAllocatedInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithCacheAllocatedInBytes(long cacheAllocatedInBytes)
        {
            this.cacheAllocatedInBytes = cacheAllocatedInBytes;
            return this;
        }
            

        // Check to see if CacheAllocatedInBytes property is set
        internal bool IsSetCacheAllocatedInBytes()
        {
            return this.cacheAllocatedInBytes.HasValue;
        }
        public double CacheUsedPercentage
        {
            get { return this.cacheUsedPercentage ?? default(double); }
            set { this.cacheUsedPercentage = value; }
        }

        /// <summary>
        /// Sets the CacheUsedPercentage property
        /// </summary>
        /// <param name="cacheUsedPercentage">The value to set for the CacheUsedPercentage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithCacheUsedPercentage(double cacheUsedPercentage)
        {
            this.cacheUsedPercentage = cacheUsedPercentage;
            return this;
        }
            

        // Check to see if CacheUsedPercentage property is set
        internal bool IsSetCacheUsedPercentage()
        {
            return this.cacheUsedPercentage.HasValue;
        }
        public double CacheDirtyPercentage
        {
            get { return this.cacheDirtyPercentage ?? default(double); }
            set { this.cacheDirtyPercentage = value; }
        }

        /// <summary>
        /// Sets the CacheDirtyPercentage property
        /// </summary>
        /// <param name="cacheDirtyPercentage">The value to set for the CacheDirtyPercentage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithCacheDirtyPercentage(double cacheDirtyPercentage)
        {
            this.cacheDirtyPercentage = cacheDirtyPercentage;
            return this;
        }
            

        // Check to see if CacheDirtyPercentage property is set
        internal bool IsSetCacheDirtyPercentage()
        {
            return this.cacheDirtyPercentage.HasValue;
        }
        public double CacheHitPercentage
        {
            get { return this.cacheHitPercentage ?? default(double); }
            set { this.cacheHitPercentage = value; }
        }

        /// <summary>
        /// Sets the CacheHitPercentage property
        /// </summary>
        /// <param name="cacheHitPercentage">The value to set for the CacheHitPercentage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithCacheHitPercentage(double cacheHitPercentage)
        {
            this.cacheHitPercentage = cacheHitPercentage;
            return this;
        }
            

        // Check to see if CacheHitPercentage property is set
        internal bool IsSetCacheHitPercentage()
        {
            return this.cacheHitPercentage.HasValue;
        }
        public double CacheMissPercentage
        {
            get { return this.cacheMissPercentage ?? default(double); }
            set { this.cacheMissPercentage = value; }
        }

        /// <summary>
        /// Sets the CacheMissPercentage property
        /// </summary>
        /// <param name="cacheMissPercentage">The value to set for the CacheMissPercentage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheResult WithCacheMissPercentage(double cacheMissPercentage)
        {
            this.cacheMissPercentage = cacheMissPercentage;
            return this;
        }
            

        // Check to see if CacheMissPercentage property is set
        internal bool IsSetCacheMissPercentage()
        {
            return this.cacheMissPercentage.HasValue;
        }
    }
}
