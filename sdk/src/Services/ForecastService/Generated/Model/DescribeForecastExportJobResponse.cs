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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeForecastExportJob operation.
    /// </summary>
    public partial class DescribeForecastExportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DataDestination _destination;
        private string _forecastArn;
        private string _forecastExportJobArn;
        private string _forecastExportJobName;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the forecast export job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The path to the Amazon Simple Storage Service (Amazon S3) bucket where the forecast
        /// is exported.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of the exported forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property ForecastExportJobArn. 
        /// <para>
        /// The ARN of the forecast export job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ForecastExportJobArn
        {
            get { return this._forecastExportJobArn; }
            set { this._forecastExportJobArn = value; }
        }

        // Check to see if ForecastExportJobArn property is set
        internal bool IsSetForecastExportJobArn()
        {
            return this._forecastExportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastExportJobName. 
        /// <para>
        /// The name of the forecast export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// When the last successful export job finished.
        /// </para>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the forecast export job. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your S3 bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}