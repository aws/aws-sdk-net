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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The <c>ApiCache</c> object.
    /// </summary>
    public partial class ApiCache
    {
        /// <summary>
        /// Gets and sets the property ApiCachingBehavior. 
        /// <para>
        /// Caching behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>FULL_REQUEST_CACHING</b>: All requests from the same user are cached. Individual
        /// resolvers are automatically cached. All API calls will try to return responses from
        /// the cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PER_RESOLVER_CACHING</b>: Individual resolvers that you specify are cached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OPERATION_LEVEL_CACHING</b>: Full requests are cached together and returned without
        /// executing resolvers.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApiCachingBehavior ApiCachingBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ApiCachingBehavior property is set.
        /// </summary>
        internal bool IsSetApiCachingBehavior() => this.ApiCachingBehavior != null;

        /// <summary>
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// At-rest encryption flag for cache. You cannot update this setting after creation.
        /// </para>
        /// </summary>
        public bool? AtRestEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AtRestEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetAtRestEncryptionEnabled() => this.AtRestEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HealthMetricsConfig. 
        /// <para>
        /// Controls how cache health metrics will be emitted to CloudWatch. Cache health metrics
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// NetworkBandwidthOutAllowanceExceeded: The network packets dropped because the throughput
        /// exceeded the aggregated bandwidth limit. This is useful for diagnosing bottlenecks
        /// in a cache configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EngineCPUUtilization: The CPU utilization (percentage) allocated to the Redis process.
        /// This is useful for diagnosing bottlenecks in a cache configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Metrics will be recorded by API ID. You can set the value to <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public CacheHealthMetricsConfig HealthMetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthMetricsConfig property is set.
        /// </summary>
        internal bool IsSetHealthMetricsConfig() => this.HealthMetricsConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The cache instance status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AVAILABLE</b>: The instance is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CREATING</b>: The instance is currently creating.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b>: The instance is currently deleting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MODIFYING</b>: The instance is currently modifying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>: The instance has failed creation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApiCacheStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// Transit encryption flag when connecting to cache. You cannot update this setting after
        /// creation.
        /// </para>
        /// </summary>
        public bool? TransitEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionEnabled() => this.TransitEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// TTL in seconds for cache entries.
        /// </para>
        ///  
        /// <para>
        /// Valid values are 1–3,600 seconds.
        /// </para>
        /// </summary>
        public long? Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The cache instance type. Valid values are 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SMALL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XLARGE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE_2X</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE_4X</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE_8X</c> (not available in all regions)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE_12X</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Historically, instance types were identified by an EC2-style value. As of July 2020,
        /// this is deprecated, and the generic identifiers above should be used.
        /// </para>
        ///  
        /// <para>
        /// The following legacy instance types are available, but their use is discouraged:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>T2_SMALL</b>: A t2.small instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>T2_MEDIUM</b>: A t2.medium instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>R4_LARGE</b>: A r4.large instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>R4_XLARGE</b>: A r4.xlarge instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>R4_2XLARGE</b>: A r4.2xlarge instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>R4_4XLARGE</b>: A r4.4xlarge instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>R4_8XLARGE</b>: A r4.8xlarge instance type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApiCacheType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
