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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies data stores to crawl.
    /// </summary>
    public partial class CrawlerTargets
    {
        private List<CatalogTarget> _catalogTargets = AWSConfigs.InitializeCollections ? new List<CatalogTarget>() : null;
        private List<DeltaTarget> _deltaTargets = AWSConfigs.InitializeCollections ? new List<DeltaTarget>() : null;
        private List<DynamoDBTarget> _dynamoDBTargets = AWSConfigs.InitializeCollections ? new List<DynamoDBTarget>() : null;
        private List<HudiTarget> _hudiTargets = AWSConfigs.InitializeCollections ? new List<HudiTarget>() : null;
        private List<IcebergTarget> _icebergTargets = AWSConfigs.InitializeCollections ? new List<IcebergTarget>() : null;
        private List<JdbcTarget> _jdbcTargets = AWSConfigs.InitializeCollections ? new List<JdbcTarget>() : null;
        private List<MongoDBTarget> _mongoDBTargets = AWSConfigs.InitializeCollections ? new List<MongoDBTarget>() : null;
        private List<S3Target> _s3Targets = AWSConfigs.InitializeCollections ? new List<S3Target>() : null;

        /// <summary>
        /// Gets and sets the property CatalogTargets. 
        /// <para>
        /// Specifies Glue Data Catalog targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CatalogTarget> CatalogTargets
        {
            get { return this._catalogTargets; }
            set { this._catalogTargets = value; }
        }

        // Check to see if CatalogTargets property is set
        internal bool IsSetCatalogTargets()
        {
            return this._catalogTargets != null && (this._catalogTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeltaTargets. 
        /// <para>
        /// Specifies Delta data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeltaTarget> DeltaTargets
        {
            get { return this._deltaTargets; }
            set { this._deltaTargets = value; }
        }

        // Check to see if DeltaTargets property is set
        internal bool IsSetDeltaTargets()
        {
            return this._deltaTargets != null && (this._deltaTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DynamoDBTargets. 
        /// <para>
        /// Specifies Amazon DynamoDB targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DynamoDBTarget> DynamoDBTargets
        {
            get { return this._dynamoDBTargets; }
            set { this._dynamoDBTargets = value; }
        }

        // Check to see if DynamoDBTargets property is set
        internal bool IsSetDynamoDBTargets()
        {
            return this._dynamoDBTargets != null && (this._dynamoDBTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HudiTargets. 
        /// <para>
        /// Specifies Apache Hudi data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HudiTarget> HudiTargets
        {
            get { return this._hudiTargets; }
            set { this._hudiTargets = value; }
        }

        // Check to see if HudiTargets property is set
        internal bool IsSetHudiTargets()
        {
            return this._hudiTargets != null && (this._hudiTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IcebergTargets. 
        /// <para>
        /// Specifies Apache Iceberg data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergTarget> IcebergTargets
        {
            get { return this._icebergTargets; }
            set { this._icebergTargets = value; }
        }

        // Check to see if IcebergTargets property is set
        internal bool IsSetIcebergTargets()
        {
            return this._icebergTargets != null && (this._icebergTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JdbcTargets. 
        /// <para>
        /// Specifies JDBC targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JdbcTarget> JdbcTargets
        {
            get { return this._jdbcTargets; }
            set { this._jdbcTargets = value; }
        }

        // Check to see if JdbcTargets property is set
        internal bool IsSetJdbcTargets()
        {
            return this._jdbcTargets != null && (this._jdbcTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MongoDBTargets. 
        /// <para>
        /// Specifies Amazon DocumentDB or MongoDB targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MongoDBTarget> MongoDBTargets
        {
            get { return this._mongoDBTargets; }
            set { this._mongoDBTargets = value; }
        }

        // Check to see if MongoDBTargets property is set
        internal bool IsSetMongoDBTargets()
        {
            return this._mongoDBTargets != null && (this._mongoDBTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Targets. 
        /// <para>
        /// Specifies Amazon Simple Storage Service (Amazon S3) targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Target> S3Targets
        {
            get { return this._s3Targets; }
            set { this._s3Targets = value; }
        }

        // Check to see if S3Targets property is set
        internal bool IsSetS3Targets()
        {
            return this._s3Targets != null && (this._s3Targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}