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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private DataSource _dataSource;
        private string _exportId;
        private string _s3Bucket;
        private Dictionary<string, string> _schemaStorageConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The type of data collector used to gather this data (currently only offered for AGENT).
        /// </para>
        /// </summary>
        public DataSource DataSource
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
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique ID assigned to this export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the s3 bucket where the export data parquet files are stored.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SchemaStorageConfig
        {
            get { return this._schemaStorageConfig; }
            set { this._schemaStorageConfig = value; }
        }

        // Check to see if SchemaStorageConfig property is set
        internal bool IsSetSchemaStorageConfig()
        {
            return this._schemaStorageConfig != null && (this._schemaStorageConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp representing when the continuous export was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}