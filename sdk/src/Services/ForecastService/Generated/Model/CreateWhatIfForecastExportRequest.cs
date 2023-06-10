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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWhatIfForecastExport operation.
    /// Exports a forecast created by the <a>CreateWhatIfForecast</a> operation to your Amazon
    /// Simple Storage Service (Amazon S3) bucket. The forecast file name will match the following
    /// conventions:
    /// 
    ///  
    /// <para>
    ///  <code>≈&lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
    /// </para>
    ///  
    /// <para>
    /// You must specify a <a>DataDestination</a> object that includes an Identity and Access
    /// Management (IAM) role that Amazon Forecast can assume to access the Amazon S3 bucket.
    /// For more information, see <a>aws-forecast-iam-roles</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a>howitworks-forecast</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your what-if forecast export jobs, use the <a>ListWhatIfForecastExports</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
    /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeWhatIfForecastExport</a>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateWhatIfForecastExportRequest : AmazonForecastServiceRequest
    {
        private DataDestination _destination;
        private string _format;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _whatIfForecastArns = new List<string>();
        private string _whatIfForecastExportName;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location where you want to save the forecast and an Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the location. The forecast must
        /// be exported to an Amazon S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <code>Destination</code> must include an Key Management Service
        /// (KMS) key. The IAM role must allow Amazon Forecast permission to access the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the exported data, CSV or PARQUET.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/forecast/latest/dg/tagging-forecast-resources.html">tags</a>
        /// to apply to the what if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastArns. 
        /// <para>
        /// The list of what-if forecast Amazon Resource Names (ARNs) to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> WhatIfForecastArns
        {
            get { return this._whatIfForecastArns; }
            set { this._whatIfForecastArns = value; }
        }

        // Check to see if WhatIfForecastArns property is set
        internal bool IsSetWhatIfForecastArns()
        {
            return this._whatIfForecastArns != null && this._whatIfForecastArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastExportName. 
        /// <para>
        /// The name of the what-if forecast to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WhatIfForecastExportName
        {
            get { return this._whatIfForecastExportName; }
            set { this._whatIfForecastExportName = value; }
        }

        // Check to see if WhatIfForecastExportName property is set
        internal bool IsSetWhatIfForecastExportName()
        {
            return this._whatIfForecastExportName != null;
        }

    }
}