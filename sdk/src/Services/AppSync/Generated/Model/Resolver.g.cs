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
    /// Describes a resolver.
    /// </summary>
    public partial class Resolver
    {
        /// <summary>
        /// Gets and sets the property CachingConfig. 
        /// <para>
        /// The caching configuration for the resolver.
        /// </para>
        /// </summary>
        public CachingConfig CachingConfig { get; set; }

        /// <summary>
        /// Checks to see if the CachingConfig property is set.
        /// </summary>
        internal bool IsSetCachingConfig() => this.CachingConfig != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The <c>resolver</c> code that contains the request and response functions. When code
        /// is used, the <c>runtime</c> is required. The <c>runtime</c> value must be <c>APPSYNC_JS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The resolver data source name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceName property is set.
        /// </summary>
        internal bool IsSetDataSourceName() => this.DataSourceName != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The resolver field name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The resolver type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UNIT</b>: A UNIT resolver type. A UNIT resolver is the default resolver type.
        /// You can use a UNIT resolver to run a GraphQL query against a single data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PIPELINE</b>: A PIPELINE resolver type. You can use a PIPELINE resolver to invoke
        /// a series of <c>Function</c> objects in a serial manner. You can use a pipeline resolver
        /// to run a GraphQL query against multiple data sources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverKind Kind { get; set; }

        /// <summary>
        /// Checks to see if the Kind property is set.
        /// </summary>
        internal bool IsSetKind() => this.Kind != null;

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum batching size for a resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSize property is set.
        /// </summary>
        internal bool IsSetMaxBatchSize() => this.MaxBatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property MetricsConfig. 
        /// <para>
        /// Enables or disables enhanced resolver metrics for specified resolvers. Note that <c>metricsConfig</c>
        /// won't be used unless the <c>resolverLevelMetricsBehavior</c> value is set to <c>PER_RESOLVER_METRICS</c>.
        /// If the <c>resolverLevelMetricsBehavior</c> is set to <c>FULL_REQUEST_RESOLVER_METRICS</c>
        /// instead, <c>metricsConfig</c> will be ignored. However, you can still set its value.
        /// </para>
        ///  
        /// <para>
        ///  <c>metricsConfig</c> can be <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ResolverLevelMetricsConfig MetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsConfig property is set.
        /// </summary>
        internal bool IsSetMetricsConfig() => this.MetricsConfig != null;

        /// <summary>
        /// Gets and sets the property PipelineConfig. 
        /// <para>
        /// The <c>PipelineConfig</c>.
        /// </para>
        /// </summary>
        public PipelineConfig PipelineConfig { get; set; }

        /// <summary>
        /// Checks to see if the PipelineConfig property is set.
        /// </summary>
        internal bool IsSetPipelineConfig() => this.PipelineConfig != null;

        /// <summary>
        /// Gets and sets the property RequestMappingTemplate. 
        /// <para>
        /// The request mapping template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string RequestMappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the RequestMappingTemplate property is set.
        /// </summary>
        internal bool IsSetRequestMappingTemplate() => this.RequestMappingTemplate != null;

        /// <summary>
        /// Gets and sets the property ResolverArn. 
        /// <para>
        /// The resolver Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ResolverArn { get; set; }

        /// <summary>
        /// Checks to see if the ResolverArn property is set.
        /// </summary>
        internal bool IsSetResolverArn() => this.ResolverArn != null;

        /// <summary>
        /// Gets and sets the property ResponseMappingTemplate. 
        /// <para>
        /// The response mapping template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string ResponseMappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the ResponseMappingTemplate property is set.
        /// </summary>
        internal bool IsSetResponseMappingTemplate() => this.ResponseMappingTemplate != null;

        /// <summary>
        /// Gets and sets the property Runtime.
        /// </summary>
        public AppSyncRuntime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property SyncConfig. 
        /// <para>
        /// The <c>SyncConfig</c> for a resolver attached to a versioned data source.
        /// </para>
        /// </summary>
        public SyncConfig SyncConfig { get; set; }

        /// <summary>
        /// Checks to see if the SyncConfig property is set.
        /// </summary>
        internal bool IsSetSyncConfig() => this.SyncConfig != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The resolver type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
