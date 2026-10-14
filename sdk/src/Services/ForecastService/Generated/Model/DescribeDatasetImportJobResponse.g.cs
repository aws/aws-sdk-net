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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatasetImportJob operation.
    /// </summary>
    public partial class DescribeDatasetImportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset import job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSize. 
        /// <para>
        /// The size of the dataset in gigabytes (GB) after the import job has finished.
        /// </para>
        /// </summary>
        public double? DataSize { get; set; }

        /// <summary>
        /// Checks to see if the DataSize property is set.
        /// </summary>
        internal bool IsSetDataSize() => this.DataSize.HasValue;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the training data to import and an Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the data.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <c>DataSource</c> includes an Key Management Service (KMS)
        /// key.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset that the training data was imported
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The ARN of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetImportJobArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetImportJobArn property is set.
        /// </summary>
        internal bool IsSetDatasetImportJobArn() => this.DatasetImportJobArn != null;

        /// <summary>
        /// Gets and sets the property DatasetImportJobName. 
        /// <para>
        /// The name of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DatasetImportJobName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetImportJobName property is set.
        /// </summary>
        internal bool IsSetDatasetImportJobName() => this.DatasetImportJobName != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the dataset import job to complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeRemainingInMinutes() => this.EstimatedTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property FieldStatistics. 
        /// <para>
        /// Statistical information about each field in the input data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Statistics> FieldStatistics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Statistics>() : null;

        /// <summary>
        /// Checks to see if the FieldStatistics property is set.
        /// </summary>
        internal bool IsSetFieldStatistics() => this.FieldStatistics != null && (this.FieldStatistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the imported data, CSV or PARQUET.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 7)]
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property GeolocationFormat. 
        /// <para>
        /// The format of the geolocation attribute. Valid Values:<c>"LAT_LONG"</c> and <c>"CC_POSTALCODE"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string GeolocationFormat { get; set; }

        /// <summary>
        /// Checks to see if the GeolocationFormat property is set.
        /// </summary>
        internal bool IsSetGeolocationFormat() => this.GeolocationFormat != null;

        /// <summary>
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// The import mode of the dataset import job, FULL or INCREMENTAL.
        /// </para>
        /// </summary>
        public ImportMode ImportMode { get; set; }

        /// <summary>
        /// Checks to see if the ImportMode property is set.
        /// </summary>
        internal bool IsSetImportMode() => this.ImportMode != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset import job. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The single time zone applied to every item in the dataset
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format of timestamps in the dataset. The format that you specify depends on the
        /// <c>DataFrequency</c> specified when the dataset was created. The following formats
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
        [AWSProperty(Min = 0, Max = 256)]
        public string TimestampFormat { get; set; }

        /// <summary>
        /// Checks to see if the TimestampFormat property is set.
        /// </summary>
        internal bool IsSetTimestampFormat() => this.TimestampFormat != null;

        /// <summary>
        /// Gets and sets the property UseGeolocationForTimeZone. 
        /// <para>
        /// Whether <c>TimeZone</c> is automatically derived from the geolocation attribute.
        /// </para>
        /// </summary>
        public bool? UseGeolocationForTimeZone { get; set; }

        /// <summary>
        /// Checks to see if the UseGeolocationForTimeZone property is set.
        /// </summary>
        internal bool IsSetUseGeolocationForTimeZone() => this.UseGeolocationForTimeZone.HasValue;
    }
}
