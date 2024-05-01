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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// A replacement dataset is a modified version of the baseline related time series that
    /// contains only the values that you want to include in a what-if forecast. The replacement
    /// dataset must contain the forecast dimensions and item identifiers in the baseline
    /// related time series as well as at least 1 changed time series. This dataset is merged
    /// with the baseline related time series to create a transformed dataset that is used
    /// for the what-if forecast.
    /// </summary>
    public partial class TimeSeriesReplacementsDataSource
    {
        private string _format;
        private S3Config _s3Config;
        private Schema _schema;
        private string _timestampFormat;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the replacement data, CSV or PARQUET.
        /// </para>
        /// </summary>
        [AWSProperty(Max=7)]
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property S3Config.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property Schema.
        /// </summary>
        [AWSProperty(Required=true)]
        public Schema Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The timestamp format of the replacement data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TimestampFormat
        {
            get { return this._timestampFormat; }
            set { this._timestampFormat = value; }
        }

        // Check to see if TimestampFormat property is set
        internal bool IsSetTimestampFormat()
        {
            return this._timestampFormat != null;
        }

    }
}