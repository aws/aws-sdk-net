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
    /// Enables and controls the enhanced metrics feature. Enhanced metrics emit granular
    /// data on API usage and performance such as AppSync request and error counts, latency,
    /// and cache hits/misses. All enhanced metric data is sent to your CloudWatch account,
    /// and you can configure the types of data that will be sent. 
    /// 
    ///  
    /// <para>
    /// Enhanced metrics can be configured at the resolver, data source, and operation levels.
    /// <c>EnhancedMetricsConfig</c> contains three required parameters, each controlling
    /// one of these categories:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <c>resolverLevelMetricsBehavior</c>: Controls how resolver metrics will be emitted
    /// to CloudWatch. Resolver metrics include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// GraphQL errors: The number of GraphQL errors that occurred.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Requests: The number of invocations that occurred during a request. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Latency: The time to complete a resolver invocation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache hits: The number of cache hits during a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache misses: The number of cache misses during a request.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// These metrics can be emitted to CloudWatch per resolver or for all resolvers in the
    /// request. Metrics will be recorded by API ID and resolver name. <c>resolverLevelMetricsBehavior</c>
    /// accepts one of these values at a time:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>FULL_REQUEST_RESOLVER_METRICS</c>: Records and emits metric data for all resolvers
    /// in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PER_RESOLVER_METRICS</c>: Records and emits metric data for resolvers that have
    /// the <c>metricsConfig</c> value set to <c>ENABLED</c>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>dataSourceLevelMetricsBehavior</c>: Controls how data source metrics will be emitted
    /// to CloudWatch. Data source metrics include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Requests: The number of invocations that occured during a request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Latency: The time to complete a data source invocation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Errors: The number of errors that occurred during a data source invocation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// These metrics can be emitted to CloudWatch per data source or for all data sources
    /// in the request. Metrics will be recorded by API ID and data source name. <c>dataSourceLevelMetricsBehavior</c>
    /// accepts one of these values at a time:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>FULL_REQUEST_DATA_SOURCE_METRICS</c>: Records and emits metric data for all data
    /// sources in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PER_DATA_SOURCE_METRICS</c>: Records and emits metric data for data sources that
    /// have the <c>metricsConfig</c> value set to <c>ENABLED</c>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>operationLevelMetricsConfig</c>: Controls how operation metrics will be emitted
    /// to CloudWatch. Operation metrics include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Requests: The number of times a specified GraphQL operation was called.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GraphQL errors: The number of GraphQL errors that occurred during a specified GraphQL
    /// operation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Metrics will be recorded by API ID and operation name. You can set the value to <c>ENABLED</c>
    /// or <c>DISABLED</c>.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class EnhancedMetricsConfig
    {
        private DataSourceLevelMetricsBehavior _dataSourceLevelMetricsBehavior;
        private OperationLevelMetricsConfig _operationLevelMetricsConfig;
        private ResolverLevelMetricsBehavior _resolverLevelMetricsBehavior;

        /// <summary>
        /// Gets and sets the property DataSourceLevelMetricsBehavior. 
        /// <para>
        /// Controls how data source metrics will be emitted to CloudWatch. Data source metrics
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Requests: The number of invocations that occured during a request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latency: The time to complete a data source invocation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Errors: The number of errors that occurred during a data source invocation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// These metrics can be emitted to CloudWatch per data source or for all data sources
        /// in the request. Metrics will be recorded by API ID and data source name. <c>dataSourceLevelMetricsBehavior</c>
        /// accepts one of these values at a time:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULL_REQUEST_DATA_SOURCE_METRICS</c>: Records and emits metric data for all data
        /// sources in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PER_DATA_SOURCE_METRICS</c>: Records and emits metric data for data sources that
        /// have the <c>metricsConfig</c> value set to <c>ENABLED</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceLevelMetricsBehavior DataSourceLevelMetricsBehavior
        {
            get { return this._dataSourceLevelMetricsBehavior; }
            set { this._dataSourceLevelMetricsBehavior = value; }
        }

        // Check to see if DataSourceLevelMetricsBehavior property is set
        internal bool IsSetDataSourceLevelMetricsBehavior()
        {
            return this._dataSourceLevelMetricsBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property OperationLevelMetricsConfig. 
        /// <para>
        ///  Controls how operation metrics will be emitted to CloudWatch. Operation metrics include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Requests: The number of times a specified GraphQL operation was called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GraphQL errors: The number of GraphQL errors that occurred during a specified GraphQL
        /// operation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Metrics will be recorded by API ID and operation name. You can set the value to <c>ENABLED</c>
        /// or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationLevelMetricsConfig OperationLevelMetricsConfig
        {
            get { return this._operationLevelMetricsConfig; }
            set { this._operationLevelMetricsConfig = value; }
        }

        // Check to see if OperationLevelMetricsConfig property is set
        internal bool IsSetOperationLevelMetricsConfig()
        {
            return this._operationLevelMetricsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverLevelMetricsBehavior. 
        /// <para>
        /// Controls how resolver metrics will be emitted to CloudWatch. Resolver metrics include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// GraphQL errors: The number of GraphQL errors that occurred.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Requests: The number of invocations that occurred during a request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latency: The time to complete a resolver invocation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cache hits: The number of cache hits during a request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cache misses: The number of cache misses during a request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// These metrics can be emitted to CloudWatch per resolver or for all resolvers in the
        /// request. Metrics will be recorded by API ID and resolver name. <c>resolverLevelMetricsBehavior</c>
        /// accepts one of these values at a time:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULL_REQUEST_RESOLVER_METRICS</c>: Records and emits metric data for all resolvers
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PER_RESOLVER_METRICS</c>: Records and emits metric data for resolvers that have
        /// the <c>metricsConfig</c> value set to <c>ENABLED</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResolverLevelMetricsBehavior ResolverLevelMetricsBehavior
        {
            get { return this._resolverLevelMetricsBehavior; }
            set { this._resolverLevelMetricsBehavior = value; }
        }

        // Check to see if ResolverLevelMetricsBehavior property is set
        internal bool IsSetResolverLevelMetricsBehavior()
        {
            return this._resolverLevelMetricsBehavior != null;
        }

    }
}