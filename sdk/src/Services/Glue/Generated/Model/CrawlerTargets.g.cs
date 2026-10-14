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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies data stores to crawl.
    /// </summary>
    public partial class CrawlerTargets
    {
        /// <summary>
        /// Gets and sets the property CatalogTargets. 
        /// <para>
        /// Specifies Glue Data Catalog targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CatalogTarget> CatalogTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<CatalogTarget>() : null;

        /// <summary>
        /// Checks to see if the CatalogTargets property is set.
        /// </summary>
        internal bool IsSetCatalogTargets() => this.CatalogTargets != null && (this.CatalogTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeltaTargets. 
        /// <para>
        /// Specifies Delta data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeltaTarget> DeltaTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<DeltaTarget>() : null;

        /// <summary>
        /// Checks to see if the DeltaTargets property is set.
        /// </summary>
        internal bool IsSetDeltaTargets() => this.DeltaTargets != null && (this.DeltaTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DynamoDBTargets. 
        /// <para>
        /// Specifies Amazon DynamoDB targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DynamoDBTarget> DynamoDBTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<DynamoDBTarget>() : null;

        /// <summary>
        /// Checks to see if the DynamoDBTargets property is set.
        /// </summary>
        internal bool IsSetDynamoDBTargets() => this.DynamoDBTargets != null && (this.DynamoDBTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HudiTargets. 
        /// <para>
        /// Specifies Apache Hudi data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HudiTarget> HudiTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<HudiTarget>() : null;

        /// <summary>
        /// Checks to see if the HudiTargets property is set.
        /// </summary>
        internal bool IsSetHudiTargets() => this.HudiTargets != null && (this.HudiTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IcebergTargets. 
        /// <para>
        /// Specifies Apache Iceberg data store targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergTarget> IcebergTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergTarget>() : null;

        /// <summary>
        /// Checks to see if the IcebergTargets property is set.
        /// </summary>
        internal bool IsSetIcebergTargets() => this.IcebergTargets != null && (this.IcebergTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JdbcTargets. 
        /// <para>
        /// Specifies JDBC targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JdbcTarget> JdbcTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<JdbcTarget>() : null;

        /// <summary>
        /// Checks to see if the JdbcTargets property is set.
        /// </summary>
        internal bool IsSetJdbcTargets() => this.JdbcTargets != null && (this.JdbcTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MongoDBTargets. 
        /// <para>
        /// Specifies Amazon DocumentDB or MongoDB targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MongoDBTarget> MongoDBTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<MongoDBTarget>() : null;

        /// <summary>
        /// Checks to see if the MongoDBTargets property is set.
        /// </summary>
        internal bool IsSetMongoDBTargets() => this.MongoDBTargets != null && (this.MongoDBTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Targets. 
        /// <para>
        /// Specifies Amazon Simple Storage Service (Amazon S3) targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Target> S3Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Target>() : null;

        /// <summary>
        /// Checks to see if the S3Targets property is set.
        /// </summary>
        internal bool IsSetS3Targets() => this.S3Targets != null && (this.S3Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
