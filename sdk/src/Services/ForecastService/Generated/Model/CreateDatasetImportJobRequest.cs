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
    /// Two properties of the training data are optionally specified:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The delimiter that separates the data fields.
    /// </para>
    ///  
    /// <para>
    /// The default delimiter is a comma (,), which is the only supported delimiter in this
    /// release.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The format of timestamps.
    /// </para>
    ///  
    /// <para>
    /// If the format is not specified, Amazon Forecast expects the format to be "yyyy-MM-dd
    /// HH:mm:ss".
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When Amazon Forecast uploads your training data, it verifies that the data was collected
    /// at the <code>DataFrequency</code> specified when the target dataset was created. For
    /// more information, see <a>CreateDataset</a> and <a>howitworks-datasets-groups</a>.
    /// Amazon Forecast also verifies the delimiter and timestamp format.
    /// </para>
    ///  
    /// <para>
    /// You can use the <a>ListDatasetImportJobs</a> operation to get a list of all your dataset
    /// import jobs, filtered by specified criteria.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your dataset import jobs, filtered by the specified criteria,
    /// use the <a>ListDatasetGroups</a> operation.
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
        /// The name for the dataset import job. It is recommended to include the current timestamp
        /// in the name to guard against getting a <code>ResourceAlreadyExistsException</code>
        /// exception, for example, <code>20190721DatasetImport</code>.
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
        /// (IAM) role that Amazon Forecast can assume to access the data.
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
        /// The format of timestamps in the dataset. Two formats are supported, dependent on the
        /// <code>DataFrequency</code> specified when the dataset was created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "yyyy-MM-dd"
        /// </para>
        ///  
        /// <para>
        /// For data frequencies: Y, M, W, and D
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "yyyy-MM-dd HH:mm:ss"
        /// </para>
        ///  
        /// <para>
        /// For data frequencies: H, 30min, 15min, and 1min; and optionally, for: Y, M, W, and
        /// D
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

    }
}