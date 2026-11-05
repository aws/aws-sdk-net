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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEngineDefaultParameters operation. Returns
    /// the default engine and system parameter information for the specified cache engine.
    /// </summary>
    public partial class DescribeEngineDefaultParametersRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEngineDefaultParametersRequest() { }

        /// <summary>
        /// Instantiates DescribeEngineDefaultParametersRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheParameterGroupFamily">The name of the cache parameter group family.   Valid values are: <c>memcached1.4</c> | <c>memcached1.5</c> |    <c>memcached1.6</c> | <c>redis2.6</c> | <c>redis2.8</c> |    <c>redis3.2</c> | <c>redis4.0</c> | <c>redis5.0</c> |    <c>redis6.x</c> | <c>redis6.2</c> | <c>redis7</c>   </param>
        public DescribeEngineDefaultParametersRequest(string cacheParameterGroupFamily)
        {
            this.CacheParameterGroupFamily = cacheParameterGroupFamily;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// The name of the cache parameter group family.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <c>memcached1.4</c> | <c>memcached1.5</c> | <c>memcached1.6</c>
        /// | <c>redis2.6</c> | <c>redis2.8</c> | <c>redis3.2</c> | <c>redis4.0</c> | <c>redis5.0</c>
        /// | <c>redis6.x</c> | <c>redis6.2</c> | <c>redis7</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CacheParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupFamily() => this.CacheParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a marker is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;
    }
}
