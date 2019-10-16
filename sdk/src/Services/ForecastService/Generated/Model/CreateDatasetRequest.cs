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
    /// Container for the parameters to the CreateDataset operation.
    /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
    /// helps Forecast understand how to consume the data for model training. This includes
    /// the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
    /// data is collected. Amazon Forecast uses this information when training the model and
    /// generating a forecast.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <code>Domain</code> </i> and <i> <code>DatasetType</code> </i> - Each dataset
    /// has an associated dataset domain and a type within the domain. Amazon Forecast provides
    /// a list of predefined domains and types within each domain. For each unique dataset
    /// domain and type within the domain, Amazon Forecast requires your data to include a
    /// minimum set of predefined fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <code>Schema</code> </i> - A schema specifies the fields of the dataset, including
    /// the field name and data type.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After creating a dataset, you import your training data into the dataset and add the
    /// dataset to a dataset group. You then use the dataset group to create a predictor.
    /// For more information, see <a>howitworks-datasets-groups</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your datasets, use the <a>ListDatasets</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
    /// training data. Use the <a>DescribeDataset</a> operation to get the status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonForecastServiceRequest
    {
        private string _dataFrequency;
        private string _datasetName;
        private DatasetType _datasetType;
        private Domain _domain;
        private EncryptionConfig _encryptionConfig;
        private Schema _schema;

        /// <summary>
        /// Gets and sets the property DataFrequency. 
        /// <para>
        /// The frequency of data collection.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are Y (Year), M (Month), W (Week), D (Day), H (Hour), 30min (30 minutes),
        /// 15min (15 minutes), 10min (10 minutes), 5min (5 minutes), and 1min (1 minute). For
        /// example, "D" indicates every day and "15min" indicates every 15 minutes.
        /// </para>
        /// </summary>
        public string DataFrequency
        {
            get { return this._dataFrequency; }
            set { this._dataFrequency = value; }
        }

        // Check to see if DataFrequency property is set
        internal bool IsSetDataFrequency()
        {
            return this._dataFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// A name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The dataset type. Valid values depend on the chosen <code>Domain</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetType DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the dataset. The <code>Domain</code> and <code>DatasetType</code>
        /// that you choose determine the fields that must be present in the training data that
        /// you import to the dataset. For example, if you choose the <code>RETAIL</code> domain
        /// and <code>TARGET_TIME_SERIES</code> as the <code>DatasetType</code>, Amazon Forecast
        /// requires <code>item_id</code>, <code>timestamp</code>, and <code>demand</code> fields
        /// to be present in your data. For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// An AWS Key Management Service (KMS) key and the AWS Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the key.
        /// </para>
        /// </summary>
        public EncryptionConfig EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema for the dataset. The schema attributes and their order must match the fields
        /// in your data. The dataset <code>Domain</code> and <code>DatasetType</code> that you
        /// choose determine the minimum required fields in your training data. For information
        /// about the required fields for a specific dataset domain and type, see <a>howitworks-domains-ds-types</a>.
        /// </para>
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

    }
}