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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// This is the response object from the StartContinuousExport operation.
    /// </summary>
    public partial class StartContinuousExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The type of data collector used to gather this data (currently only offered for AGENT).
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique ID assigned to this export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ExportId { get; set; }

        /// <summary>
        /// Checks to see if the ExportId property is set.
        /// </summary>
        internal bool IsSetExportId() => this.ExportId != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the s3 bucket where the export data parquet files are stored.
        /// </para>
        /// </summary>
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property SchemaStorageConfig. 
        /// <para>
        /// A dictionary which describes how the data is stored.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>databaseName</c> - the name of the Glue database used to store the schema.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SchemaStorageConfig { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SchemaStorageConfig property is set.
        /// </summary>
        internal bool IsSetSchemaStorageConfig() => this.SchemaStorageConfig != null && (this.SchemaStorageConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp representing when the continuous export was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
