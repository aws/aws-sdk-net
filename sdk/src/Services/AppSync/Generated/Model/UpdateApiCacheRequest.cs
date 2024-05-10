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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
    /// Container for the parameters to the UpdateApiCache operation.
    /// Updates the cache for the GraphQL API.
    /// </summary>
    public partial class UpdateApiCacheRequest : AmazonAppSyncRequest
    {
        private ApiCachingBehavior _apiCachingBehavior;
        private string _apiId;
        private CacheHealthMetricsConfig _healthMetricsConfig;
        private long? _ttl;
        private ApiCacheType _type;

        /// <summary>
        /// Gets and sets the property ApiCachingBehavior. 
        /// <para>
        /// Caching behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>FULL_REQUEST_CACHING</b>: All requests are fully cached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PER_RESOLVER_CACHING</b>: Individual resolvers that you specify are cached.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApiCachingBehavior ApiCachingBehavior
        {
            get { return this._apiCachingBehavior; }
            set { this._apiCachingBehavior = value; }
        }

        // Check to see if ApiCachingBehavior property is set
        internal bool IsSetApiCachingBehavior()
        {
            return this._apiCachingBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The GraphQL API ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

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
        public CacheHealthMetricsConfig HealthMetricsConfig
        {
            get { return this._healthMetricsConfig; }
            set { this._healthMetricsConfig = value; }
        }

        // Check to see if HealthMetricsConfig property is set
        internal bool IsSetHealthMetricsConfig()
        {
            return this._healthMetricsConfig != null;
        }

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
        [AWSProperty(Required=true)]
        public long? Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl.HasValue; 
        }

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
        [AWSProperty(Required=true)]
        public ApiCacheType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}