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
    /// This is the response object from the DescribeDatasetImportJob operation.
    /// </summary>
    public partial class DescribeDatasetImportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _datasetArn;
        private string _datasetImportJobArn;
        private string _datasetImportJobName;
        private double? _dataSize;
        private DataSource _dataSource;
        private long? _estimatedTimeRemainingInMinutes;
        private Dictionary<string, Statistics> _fieldStatistics = new Dictionary<string, Statistics>();
        private string _format;
        private string _geolocationFormat;
        private ImportMode _importMode;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;
        private string _timestampFormat;
        private string _timeZone;
        private bool? _useGeolocationForTimeZone;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset import job was created.
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
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset that the training data was imported
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The ARN of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetImportJobArn
        {
            get { return this._datasetImportJobArn; }
            set { this._datasetImportJobArn = value; }
        }

        // Check to see if DatasetImportJobArn property is set
        internal bool IsSetDatasetImportJobArn()
        {
            return this._datasetImportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobName. 
        /// <para>
        /// The name of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DatasetImportJobName
        {
            get { return this._datasetImportJobName; }
            set { this._datasetImportJobName = value; }
        }

        // Check to see if DatasetImportJobName property is set
        internal bool IsSetDatasetImportJobName()
        {
            return this._datasetImportJobName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSize. 
        /// <para>
        /// The size of the dataset in gigabytes (GB) after the import job has finished.
        /// </para>
        /// </summary>
        public double DataSize
        {
            get { return this._dataSize.GetValueOrDefault(); }
            set { this._dataSize = value; }
        }

        // Check to see if DataSize property is set
        internal bool IsSetDataSize()
        {
            return this._dataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the training data to import and an Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the data.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <code>DataSource</code> includes an Key Management Service
        /// (KMS) key.
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
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the dataset import job to complete.
        /// </para>
        /// </summary>
        public long EstimatedTimeRemainingInMinutes
        {
            get { return this._estimatedTimeRemainingInMinutes.GetValueOrDefault(); }
            set { this._estimatedTimeRemainingInMinutes = value; }
        }

        // Check to see if EstimatedTimeRemainingInMinutes property is set
        internal bool IsSetEstimatedTimeRemainingInMinutes()
        {
            return this._estimatedTimeRemainingInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FieldStatistics. 
        /// <para>
        /// Statistical information about each field in the input data.
        /// </para>
        /// </summary>
        public Dictionary<string, Statistics> FieldStatistics
        {
            get { return this._fieldStatistics; }
            set { this._fieldStatistics = value; }
        }

        // Check to see if FieldStatistics property is set
        internal bool IsSetFieldStatistics()
        {
            return this._fieldStatistics != null && this._fieldStatistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the imported data, CSV or PARQUET.
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
        /// Gets and sets the property GeolocationFormat. 
        /// <para>
        /// The format of the geolocation attribute. Valid Values:<code>"LAT_LONG"</code> and
        /// <code>"CC_POSTALCODE"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string GeolocationFormat
        {
            get { return this._geolocationFormat; }
            set { this._geolocationFormat = value; }
        }

        // Check to see if GeolocationFormat property is set
        internal bool IsSetGeolocationFormat()
        {
            return this._geolocationFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// The import mode of the dataset import job, FULL or INCREMENTAL.
        /// </para>
        /// </summary>
        public ImportMode ImportMode
        {
            get { return this._importMode; }
            set { this._importMode = value; }
        }

        // Check to see if ImportMode property is set
        internal bool IsSetImportMode()
        {
            return this._importMode != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code> - The <code>CreationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_IN_PROGRESS</code> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPING</code> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPED</code> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> or <code>CREATE_FAILED</code> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
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
        /// The status of the dataset import job. States include:
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
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPING</code>, <code>CREATE_STOPPED</code> 
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format of timestamps in the dataset. The format that you specify depends on the
        /// <code>DataFrequency</code> specified when the dataset was created. The following formats
        /// are supported
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "yyyy-MM-dd"
        /// </para>
        ///  
        /// <para>
        /// For the following data frequencies: Y, M, W, and D
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "yyyy-MM-dd HH:mm:ss"
        /// </para>
        ///  
        /// <para>
        /// For the following data frequencies: H, 30min, 15min, and 1min; and optionally, for:
        /// Y, M, W, and D
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The single time zone applied to every item in the dataset
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

        /// <summary>
        /// Gets and sets the property UseGeolocationForTimeZone. 
        /// <para>
        /// Whether <code>TimeZone</code> is automatically derived from the geolocation attribute.
        /// </para>
        /// </summary>
        public bool UseGeolocationForTimeZone
        {
            get { return this._useGeolocationForTimeZone.GetValueOrDefault(); }
            set { this._useGeolocationForTimeZone = value; }
        }

        // Check to see if UseGeolocationForTimeZone property is set
        internal bool IsSetUseGeolocationForTimeZone()
        {
            return this._useGeolocationForTimeZone.HasValue; 
        }

    }
}