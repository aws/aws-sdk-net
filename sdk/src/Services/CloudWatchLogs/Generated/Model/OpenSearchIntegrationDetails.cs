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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains complete information about one CloudWatch Logs integration.
    /// This structure is returned by a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetIntegration.html">GetIntegration</a>
    /// operation.
    /// </summary>
    public partial class OpenSearchIntegrationDetails
    {
        private OpenSearchDataAccessPolicy _accessPolicy;
        private OpenSearchApplication _application;
        private OpenSearchCollection _collection;
        private OpenSearchDataSource _dataSource;
        private OpenSearchEncryptionPolicy _encryptionPolicy;
        private OpenSearchLifecyclePolicy _lifecyclePolicy;
        private OpenSearchNetworkPolicy _networkPolicy;
        private OpenSearchWorkspace _workspace;

        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// This structure contains information about the OpenSearch Service data access policy
        /// used for this integration. The access policy defines the access controls for the collection.
        /// This data access policy was automatically created as part of the integration setup.
        /// For more information about OpenSearch Service data access policies, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a> in the OpenSearch Service Developer
        /// Guide.
        /// </para>
        /// </summary>
        public OpenSearchDataAccessPolicy AccessPolicy
        {
            get { return this._accessPolicy; }
            set { this._accessPolicy = value; }
        }

        // Check to see if AccessPolicy property is set
        internal bool IsSetAccessPolicy()
        {
            return this._accessPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// This structure contains information about the OpenSearch Service application used
        /// for this integration. An OpenSearch Service application is the web application that
        /// was created by the integration with CloudWatch Logs. It hosts the vended logs dashboards.
        /// </para>
        /// </summary>
        public OpenSearchApplication Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property Collection. 
        /// <para>
        /// This structure contains information about the OpenSearch Service collection used for
        /// this integration. This collection was created as part of the integration setup. An
        /// OpenSearch Service collection is a logical grouping of one or more indexes that represent
        /// an analytics workload. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-collections.html">Creating
        /// and managing OpenSearch Service Serverless collections</a>.
        /// </para>
        /// </summary>
        public OpenSearchCollection Collection
        {
            get { return this._collection; }
            set { this._collection = value; }
        }

        // Check to see if Collection property is set
        internal bool IsSetCollection()
        {
            return this._collection != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// This structure contains information about the OpenSearch Service data source used
        /// for this integration. This data source was created as part of the integration setup.
        /// An OpenSearch Service data source defines the source and destination for OpenSearch
        /// Service queries. It includes the role required to execute queries and write to collections.
        /// </para>
        ///  
        /// <para>
        /// For more information about OpenSearch Service data sources , see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Creating
        /// OpenSearch Service data source integrations with Amazon S3.</a> 
        /// </para>
        /// </summary>
        public OpenSearchDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionPolicy. 
        /// <para>
        /// This structure contains information about the OpenSearch Service encryption policy
        /// used for this integration. The encryption policy was created automatically when you
        /// created the integration. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html#serverless-encryption-policies">Encryption
        /// policies</a> in the OpenSearch Service Developer Guide. 
        /// </para>
        /// </summary>
        public OpenSearchEncryptionPolicy EncryptionPolicy
        {
            get { return this._encryptionPolicy; }
            set { this._encryptionPolicy = value; }
        }

        // Check to see if EncryptionPolicy property is set
        internal bool IsSetEncryptionPolicy()
        {
            return this._encryptionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// This structure contains information about the OpenSearch Service data lifecycle policy
        /// used for this integration. The lifecycle policy determines the lifespan of the data
        /// in the collection. It was automatically created as part of the integration setup.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-lifecycle.html">Using
        /// data lifecycle policies with OpenSearch Service Serverless</a> in the OpenSearch Service
        /// Developer Guide.
        /// </para>
        /// </summary>
        public OpenSearchLifecyclePolicy LifecyclePolicy
        {
            get { return this._lifecyclePolicy; }
            set { this._lifecyclePolicy = value; }
        }

        // Check to see if LifecyclePolicy property is set
        internal bool IsSetLifecyclePolicy()
        {
            return this._lifecyclePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkPolicy. 
        /// <para>
        /// This structure contains information about the OpenSearch Service network policy used
        /// for this integration. The network policy assigns network access settings to collections.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html#serverless-network-policies">Network
        /// policies</a> in the OpenSearch Service Developer Guide.
        /// </para>
        /// </summary>
        public OpenSearchNetworkPolicy NetworkPolicy
        {
            get { return this._networkPolicy; }
            set { this._networkPolicy = value; }
        }

        // Check to see if NetworkPolicy property is set
        internal bool IsSetNetworkPolicy()
        {
            return this._networkPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// This structure contains information about the OpenSearch Service workspace used for
        /// this integration. An OpenSearch Service workspace is the collection of dashboards
        /// along with other OpenSearch Service tools. This workspace was created automatically
        /// as part of the integration setup. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/application.html">Centralized
        /// OpenSearch user interface (Dashboards) with OpenSearch Service</a>.
        /// </para>
        /// </summary>
        public OpenSearchWorkspace Workspace
        {
            get { return this._workspace; }
            set { this._workspace = value; }
        }

        // Check to see if Workspace property is set
        internal bool IsSetWorkspace()
        {
            return this._workspace != null;
        }

    }
}