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
    /// Container for the parameters to the CreateDataset operation.
    /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
    /// helps Forecast understand how to consume the data for model training. This includes
    /// the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
    /// data is collected.
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
    ///  <i> <code>Schema</code> </i> - A schema specifies the fields in the dataset, including
    /// the field name and data type.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After creating a dataset, you import your training data into it and add the dataset
    /// to a dataset group. You use the dataset group to create a predictor. For more information,
    /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Importing
    /// datasets</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your datasets, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasets.html">ListDatasets</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For example Forecast datasets, see the <a href="https://github.com/aws-samples/amazon-forecast-samples">Amazon
    /// Forecast Sample GitHub repository</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
    /// training data. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
    /// operation to get the status.
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
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DataFrequency. 
        /// <para>
        /// The frequency of data collection. This parameter is required for RELATED_TIME_SERIES
        /// datasets.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are an integer followed by Y (Year), M (Month), W (Week), D (Day),
        /// H (Hour), and min (Minute). For example, "1D" indicates every day and "15min" indicates
        /// every 15 minutes. You cannot specify a value that would overlap with the next larger
        /// frequency. That means, for example, you cannot specify a frequency of 60 minutes,
        /// because that is equivalent to 1 hour. The valid values for each frequency are the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minute - 1-59
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hour - 1-23
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Day - 1-6
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Week - 1-4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Month - 1-11
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Year - 1
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Thus, if you want every other week forecasts, specify "2W". Or, if you want quarterly
        /// forecasts, you specify "3M".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// The domain associated with the dataset. When you add a dataset to a dataset group,
        /// this value and the value specified for the <code>Domain</code> parameter of the <a
        /// href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation must match.
        /// </para>
        ///  
        /// <para>
        /// The <code>Domain</code> and <code>DatasetType</code> that you choose determine the
        /// fields that must be present in the training data that you import to the dataset. For
        /// example, if you choose the <code>RETAIL</code> domain and <code>TARGET_TIME_SERIES</code>
        /// as the <code>DatasetType</code>, Amazon Forecast requires <code>item_id</code>, <code>timestamp</code>,
        /// and <code>demand</code> fields to be present in your data. For more information, see
        /// <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Importing
        /// datasets</a>.
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
        /// An Key Management Service (KMS) key and the Identity and Access Management (IAM) role
        /// that Amazon Forecast can assume to access the key.
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
        /// about the required fields for a specific dataset domain and type, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-domains-ds-types.html">Dataset
        /// Domains and Dataset Types</a>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the dataset to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
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

    }
}