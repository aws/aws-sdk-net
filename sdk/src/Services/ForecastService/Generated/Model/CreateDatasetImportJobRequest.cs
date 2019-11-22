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
    /// Container for the parameters to the CreateDatasetImportJob operation.
    /// Imports your training data to an Amazon Forecast dataset. You provide the location
    /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
    /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
    /// 
    ///  
    /// <para>
    /// You must specify a <a>DataSource</a> object that includes an AWS Identity and Access
    /// Management (IAM) role that Amazon Forecast can assume to access the data. For more
    /// information, see <a>aws-forecast-iam-roles</a>.
    /// </para>
    ///  
    /// <para>
    /// The training data must be in CSV format. The delimiter must be a comma (,).
    /// </para>
    ///  
    /// <para>
    /// You can specify the path to a specific CSV file, the S3 bucket, or to a folder in
    /// the S3 bucket. For the latter two cases, Amazon Forecast imports all files up to the
    /// limit of 10,000 files.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your dataset import jobs, filtered by specified criteria, use
    /// the <a>ListDatasetImportJobs</a> operation.
    /// </para>
    /// </summary>
    public partial class CreateDatasetImportJobRequest : AmazonForecastServiceRequest
    {
        private string _datasetArn;
        private string _datasetImportJobName;
        private DataSource _dataSource;
        private string _timestampFormat;

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
        /// The location of the training data to import and an AWS Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the data. The training data must
        /// be stored in an Amazon S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If encryption is used, <code>DataSource</code> must include an AWS Key Management
        /// Service (KMS) key and the IAM role must allow Amazon Forecast permission to access
        /// the key. The KMS key and IAM role must match those specified in the <code>EncryptionConfig</code>
        /// parameter of the <a>CreateDataset</a> operation.
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

    }
}