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
    /// Container for the parameters to the CreateDataSource operation.
    /// Creates a <c>DataSource</c> object.
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private string _description;
        private DynamodbDataSourceConfig _dynamodbConfig;
        private ElasticsearchDataSourceConfig _elasticsearchConfig;
        private EventBridgeDataSourceConfig _eventBridgeConfig;
        private HttpDataSourceConfig _httpConfig;
        private LambdaDataSourceConfig _lambdaConfig;
        private DataSourceLevelMetricsConfig _metricsConfig;
        private string _name;
        private OpenSearchServiceDataSourceConfig _openSearchServiceConfig;
        private RelationalDatabaseDataSourceConfig _relationalDatabaseConfig;
        private string _serviceRoleArn;
        private DataSourceType _type;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID for the GraphQL API for the <c>DataSource</c>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the <c>DataSource</c>.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DynamodbConfig. 
        /// <para>
        /// Amazon DynamoDB settings.
        /// </para>
        /// </summary>
        public DynamodbDataSourceConfig DynamodbConfig
        {
            get { return this._dynamodbConfig; }
            set { this._dynamodbConfig = value; }
        }

        // Check to see if DynamodbConfig property is set
        internal bool IsSetDynamodbConfig()
        {
            return this._dynamodbConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchConfig. 
        /// <para>
        /// Amazon OpenSearch Service settings.
        /// </para>
        ///  
        /// <para>
        /// As of September 2021, Amazon Elasticsearch service is Amazon OpenSearch Service. This
        /// configuration is deprecated. For new data sources, use <a>CreateDataSourceRequest$openSearchServiceConfig</a>
        /// to create an OpenSearch data source.
        /// </para>
        /// </summary>
        public ElasticsearchDataSourceConfig ElasticsearchConfig
        {
            get { return this._elasticsearchConfig; }
            set { this._elasticsearchConfig = value; }
        }

        // Check to see if ElasticsearchConfig property is set
        internal bool IsSetElasticsearchConfig()
        {
            return this._elasticsearchConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeConfig. 
        /// <para>
        /// Amazon EventBridge settings.
        /// </para>
        /// </summary>
        public EventBridgeDataSourceConfig EventBridgeConfig
        {
            get { return this._eventBridgeConfig; }
            set { this._eventBridgeConfig = value; }
        }

        // Check to see if EventBridgeConfig property is set
        internal bool IsSetEventBridgeConfig()
        {
            return this._eventBridgeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HttpConfig. 
        /// <para>
        /// HTTP endpoint settings.
        /// </para>
        /// </summary>
        public HttpDataSourceConfig HttpConfig
        {
            get { return this._httpConfig; }
            set { this._httpConfig = value; }
        }

        // Check to see if HttpConfig property is set
        internal bool IsSetHttpConfig()
        {
            return this._httpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// Lambda settings.
        /// </para>
        /// </summary>
        public LambdaDataSourceConfig LambdaConfig
        {
            get { return this._lambdaConfig; }
            set { this._lambdaConfig = value; }
        }

        // Check to see if LambdaConfig property is set
        internal bool IsSetLambdaConfig()
        {
            return this._lambdaConfig != null;
        }

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
        public DataSourceLevelMetricsConfig MetricsConfig
        {
            get { return this._metricsConfig; }
            set { this._metricsConfig = value; }
        }

        // Check to see if MetricsConfig property is set
        internal bool IsSetMetricsConfig()
        {
            return this._metricsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name for the <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OpenSearchServiceConfig. 
        /// <para>
        /// Amazon OpenSearch Service settings.
        /// </para>
        /// </summary>
        public OpenSearchServiceDataSourceConfig OpenSearchServiceConfig
        {
            get { return this._openSearchServiceConfig; }
            set { this._openSearchServiceConfig = value; }
        }

        // Check to see if OpenSearchServiceConfig property is set
        internal bool IsSetOpenSearchServiceConfig()
        {
            return this._openSearchServiceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseConfig. 
        /// <para>
        /// Relational database settings.
        /// </para>
        /// </summary>
        public RelationalDatabaseDataSourceConfig RelationalDatabaseConfig
        {
            get { return this._relationalDatabaseConfig; }
            set { this._relationalDatabaseConfig = value; }
        }

        // Check to see if RelationalDatabaseConfig property is set
        internal bool IsSetRelationalDatabaseConfig()
        {
            return this._relationalDatabaseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Identity and Access Management (IAM) service role Amazon Resource Name (ARN) for
        /// the data source. The system assumes this role when accessing the data source.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType Type
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