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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Defines configuration details about the data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        private CsvConfiguration _csvConfiguration;
        private BatchLoadDataFormat _dataFormat;
        private DataSourceS3Configuration _dataSourceS3Configuration;

        /// <summary>
        /// Gets and sets the property CsvConfiguration.
        /// </summary>
        public CsvConfiguration CsvConfiguration
        {
            get { return this._csvConfiguration; }
            set { this._csvConfiguration = value; }
        }

        // Check to see if CsvConfiguration property is set
        internal bool IsSetCsvConfiguration()
        {
            return this._csvConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// This is currently CSV.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchLoadDataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceS3Configuration. 
        /// <para>
        /// Configuration of an S3 location for a file which contains data to load.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceS3Configuration DataSourceS3Configuration
        {
            get { return this._dataSourceS3Configuration; }
            set { this._dataSourceS3Configuration = value; }
        }

        // Check to see if DataSourceS3Configuration property is set
        internal bool IsSetDataSourceS3Configuration()
        {
            return this._dataSourceS3Configuration != null;
        }

    }
}