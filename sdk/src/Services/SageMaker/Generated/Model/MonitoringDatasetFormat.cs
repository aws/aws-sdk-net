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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Represents the dataset format used when running a monitoring job.
    /// </summary>
    public partial class MonitoringDatasetFormat
    {
        private MonitoringCsvDatasetFormat _csv;
        private MonitoringJsonDatasetFormat _json;
        private MonitoringParquetDatasetFormat _parquet;

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        /// The CSV dataset used in the monitoring job.
        /// </para>
        /// </summary>
        public MonitoringCsvDatasetFormat Csv
        {
            get { return this._csv; }
            set { this._csv = value; }
        }

        // Check to see if Csv property is set
        internal bool IsSetCsv()
        {
            return this._csv != null;
        }

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// The JSON dataset used in the monitoring job
        /// </para>
        /// </summary>
        public MonitoringJsonDatasetFormat Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return this._json != null;
        }

        /// <summary>
        /// Gets and sets the property Parquet. 
        /// <para>
        /// The Parquet dataset used in the monitoring job
        /// </para>
        /// </summary>
        public MonitoringParquetDatasetFormat Parquet
        {
            get { return this._parquet; }
            set { this._parquet = value; }
        }

        // Check to see if Parquet property is set
        internal bool IsSetParquet()
        {
            return this._parquet != null;
        }

    }
}