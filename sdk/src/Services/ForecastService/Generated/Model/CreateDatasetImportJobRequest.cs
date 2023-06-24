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
    /// Container for the parameters to the CreateDatasetImportJob operation.
    /// Imports your training data to an Amazon Forecast dataset. You provide the location
    /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
    /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
    /// 
    ///  
    /// <para>
    /// You must specify a <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DataSource.html">DataSource</a>
    /// object that includes an Identity and Access Management (IAM) role that Amazon Forecast
    /// can assume to access the data, as Amazon Forecast makes a copy of your data and processes
    /// it in an internal Amazon Web Services system. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/aws-forecast-iam-roles.html">Set
    /// up permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// The training data must be in CSV or Parquet format. The delimiter must be a comma
    /// (,).
    /// </para>
    ///  
    /// <para>
    /// You can specify the path to a specific file, the S3 bucket, or to a folder in the
    /// S3 bucket. For the latter two cases, Amazon Forecast imports all files up to the limit
    /// of 10,000 files.
    /// </para>
    ///  
    /// <para>
    /// Because dataset imports are not aggregated, your most recent dataset import is the
    /// one that is used when training a predictor or generating a forecast. Make sure that
    /// your most recent dataset import contains all of the data you want to model off of,
    /// and not just the new data collected since the previous import.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your dataset import jobs, filtered by specified criteria, use
    /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetImportJobs.html">ListDatasetImportJobs</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class CreateDatasetImportJobRequest : AmazonForecastServiceRequest
    {
        private string _datasetArn;
        private string _datasetImportJobName;
        private DataSource _dataSource;
        private string _format;
        private string _geolocationFormat;
        private ImportMode _importMode;
        private List<Tag> _tags = new List<Tag>();
        private string _timestampFormat;
        private string _timeZone;
        private bool? _useGeolocationForTimeZone;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Forecast dataset that you want to import
        /// data to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property DatasetImportJobName. 
        /// <para>
        /// The name for the dataset import job. We recommend including the current timestamp
        /// in the name, for example, <code>20190721DatasetImport</code>. This can help you avoid
        /// getting a <code>ResourceAlreadyExistsException</code> exception.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the training data to import and an Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the data. The training data must
        /// be stored in an Amazon S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <code>DataSource</code> must include an Key Management Service
        /// (KMS) key and the IAM role must allow Amazon Forecast permission to access the key.
        /// The KMS key and IAM role must match those specified in the <code>EncryptionConfig</code>
        /// parameter of the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the imported data, CSV or PARQUET. The default value is CSV.
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
        /// The format of the geolocation attribute. The geolocation attribute can be formatted
        /// in one of two ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LAT_LONG</code> - the latitude and longitude in decimal format (Example: 47.61_-122.33).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CC_POSTALCODE</code> (US Only) - the country code (US), followed by the 5-digit
        /// ZIP code (Example: US_98121).
        /// </para>
        ///  </li> </ul>
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
        /// Specifies whether the dataset import job is a <code>FULL</code> or <code>INCREMENTAL</code>
        /// import. A <code>FULL</code> dataset import replaces all of the existing data with
        /// the newly imported data. An <code>INCREMENTAL</code> import appends the imported data
        /// to the existing data.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the dataset import job to help you categorize
        /// and organize them. Each tag consists of a key and an optional value, both of which
        /// you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for keys as it is reserved for Amazon Web Services use. You cannot
        /// edit or delete tag keys with this prefix. Values can have this prefix. If a tag value
        /// has <code>aws</code> as its prefix but the key does not, then Forecast considers it
        /// to be a user tag and will count against the limit of 50 tags. Tags with only the key
        /// prefix of <code>aws</code> do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        /// If the format isn't specified, Amazon Forecast expects the format to be "yyyy-MM-dd
        /// HH:mm:ss".
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

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// A single time zone for every item in your dataset. This option is ideal for datasets
        /// with all timestamps within a single time zone, or if all timestamps are normalized
        /// to a single time zone. 
        /// </para>
        ///  
        /// <para>
        /// Refer to the <a href="http://joda-time.sourceforge.net/timezones.html">Joda-Time API</a>
        /// for a complete list of valid time zone names.
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
        /// Automatically derive time zone information from the geolocation attribute. This option
        /// is ideal for datasets that contain timestamps in multiple time zones and those timestamps
        /// are expressed in local time.
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