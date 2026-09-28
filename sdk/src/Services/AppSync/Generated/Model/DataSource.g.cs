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
    /// Describes a data source.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The data source Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DynamodbConfig. 
        /// <para>
        /// DynamoDB settings.
        /// </para>
        /// </summary>
        public DynamodbDataSourceConfig DynamodbConfig { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbConfig property is set.
        /// </summary>
        internal bool IsSetDynamodbConfig() => this.DynamodbConfig != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchConfig. 
        /// <para>
        /// Amazon OpenSearch Service settings.
        /// </para>
        /// </summary>
        public ElasticsearchDataSourceConfig ElasticsearchConfig { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchConfig property is set.
        /// </summary>
        internal bool IsSetElasticsearchConfig() => this.ElasticsearchConfig != null;

        /// <summary>
        /// Gets and sets the property EventBridgeConfig. 
        /// <para>
        /// Amazon EventBridge settings.
        /// </para>
        /// </summary>
        public EventBridgeDataSourceConfig EventBridgeConfig { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeConfig property is set.
        /// </summary>
        internal bool IsSetEventBridgeConfig() => this.EventBridgeConfig != null;

        /// <summary>
        /// Gets and sets the property HttpConfig. 
        /// <para>
        /// HTTP endpoint settings.
        /// </para>
        /// </summary>
        public HttpDataSourceConfig HttpConfig { get; set; }

        /// <summary>
        /// Checks to see if the HttpConfig property is set.
        /// </summary>
        internal bool IsSetHttpConfig() => this.HttpConfig != null;

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// Lambda settings.
        /// </para>
        /// </summary>
        public LambdaDataSourceConfig LambdaConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaConfig property is set.
        /// </summary>
        internal bool IsSetLambdaConfig() => this.LambdaConfig != null;

        /// <summary>
        /// Gets and sets the property MetricsConfig. 
        /// <para>
        /// Enables or disables enhanced data source metrics for specified data sources. Note
        /// that <c>metricsConfig</c> won't be used unless the <c>dataSourceLevelMetricsBehavior</c>
        /// value is set to <c>PER_DATA_SOURCE_METRICS</c>. If the <c>dataSourceLevelMetricsBehavior</c>
        /// is set to <c>FULL_REQUEST_DATA_SOURCE_METRICS</c> instead, <c>metricsConfig</c> will
        /// be ignored. However, you can still set its value.
        /// </para>
        ///  
        /// <para>
        ///  <c>metricsConfig</c> can be <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public DataSourceLevelMetricsConfig MetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsConfig property is set.
        /// </summary>
        internal bool IsSetMetricsConfig() => this.MetricsConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenSearchServiceConfig. 
        /// <para>
        /// Amazon OpenSearch Service settings.
        /// </para>
        /// </summary>
        public OpenSearchServiceDataSourceConfig OpenSearchServiceConfig { get; set; }

        /// <summary>
        /// Checks to see if the OpenSearchServiceConfig property is set.
        /// </summary>
        internal bool IsSetOpenSearchServiceConfig() => this.OpenSearchServiceConfig != null;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseConfig. 
        /// <para>
        /// Relational database settings.
        /// </para>
        /// </summary>
        public RelationalDatabaseDataSourceConfig RelationalDatabaseConfig { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseConfig property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseConfig() => this.RelationalDatabaseConfig != null;

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Identity and Access Management (IAM) service role Amazon Resource Name (ARN) for
        /// the data source. The system assumes this role when accessing the data source.
        /// </para>
        /// </summary>
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AWS_LAMBDA</b>: The data source is an Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AMAZON_DYNAMODB</b>: The data source is an Amazon DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AMAZON_ELASTICSEARCH</b>: The data source is an Amazon OpenSearch Service domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AMAZON_OPENSEARCH_SERVICE</b>: The data source is an Amazon OpenSearch Service
        /// domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AMAZON_EVENTBRIDGE</b>: The data source is an Amazon EventBridge configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AMAZON_BEDROCK_RUNTIME</b>: The data source is the Amazon Bedrock runtime.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NONE</b>: There is no data source. Use this type when you want to invoke a GraphQL
        /// operation without connecting to a data source, such as when you're performing data
        /// transformation with resolvers or invoking a subscription from a mutation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HTTP</b>: The data source is an HTTP endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RELATIONAL_DATABASE</b>: The data source is a relational database.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
