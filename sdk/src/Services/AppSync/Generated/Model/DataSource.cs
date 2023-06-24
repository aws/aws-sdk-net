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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a data source.
    /// </summary>
    public partial class DataSource
    {
        private string _dataSourceArn;
        private string _description;
        private DynamodbDataSourceConfig _dynamodbConfig;
        private ElasticsearchDataSourceConfig _elasticsearchConfig;
        private EventBridgeDataSourceConfig _eventBridgeConfig;
        private HttpDataSourceConfig _httpConfig;
        private LambdaDataSourceConfig _lambdaConfig;
        private string _name;
        private OpenSearchServiceDataSourceConfig _openSearchServiceConfig;
        private RelationalDatabaseDataSourceConfig _relationalDatabaseConfig;
        private string _serviceRoleArn;
        private DataSourceType _type;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The data source Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source.
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
        /// DynamoDB settings.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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