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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Defines configuration details about the data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property CsvConfiguration.
        /// </summary>
        public CsvConfiguration CsvConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CsvConfiguration property is set.
        /// </summary>
        internal bool IsSetCsvConfiguration() => this.CsvConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// This is currently CSV.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchLoadDataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property DataSourceS3Configuration. 
        /// <para>
        /// Configuration of an S3 location for a file which contains data to load.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceS3Configuration DataSourceS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceS3Configuration property is set.
        /// </summary>
        internal bool IsSetDataSourceS3Configuration() => this.DataSourceS3Configuration != null;
    }
}
