/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateForecastExportJob operation.
    /// Exports a forecast created by the <a>CreateForecast</a> operation to your Amazon Simple
    /// Storage Service (Amazon S3) bucket. The forecast file name will match the following
    /// conventions:
    /// 
    ///  
    /// <para>
    /// &lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PageNumber&gt;
    /// </para>
    ///  
    /// <para>
    /// where the &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
    /// </para>
    ///  
    /// <para>
    /// You must specify a <a>DataDestination</a> object that includes an AWS Identity and
    /// Access Management (IAM) role that Amazon Forecast can assume to access the Amazon
    /// S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a>howitworks-forecast</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your forecast export jobs, use the <a>ListForecastExportJobs</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
    /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeForecastExportJob</a>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateForecastExportJobRequest : AmazonForecastServiceRequest
    {
        private DataDestination _destination;
        private string _forecastArn;
        private string _forecastExportJobName;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location where you want to save the forecast and an AWS Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the location. The forecast must
        /// be exported to an Amazon S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <code>Destination</code> must include an AWS Key Management
        /// Service (KMS) key. The IAM role must allow Amazon Forecast permission to access the
        /// key.
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
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast that you want to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ForecastArn
        {
            get { return this._forecastArn; }
            set { this._forecastArn = value; }
        }

        // Check to see if ForecastArn property is set
        internal bool IsSetForecastArn()
        {
            return this._forecastArn != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastExportJobName. 
        /// <para>
        /// The name for the forecast export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ForecastExportJobName
        {
            get { return this._forecastExportJobName; }
            set { this._forecastExportJobName = value; }
        }

        // Check to see if ForecastExportJobName property is set
        internal bool IsSetForecastExportJobName()
        {
            return this._forecastExportJobName != null;
        }

    }
}