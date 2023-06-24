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
    /// Container for the parameters to the CreateDatasetGroup operation.
    /// Creates a dataset group, which holds a collection of related datasets. You can add
    /// datasets to the dataset group when you create the dataset group, or later by using
    /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_UpdateDatasetGroup.html">UpdateDatasetGroup</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// After creating a dataset group and adding datasets, you use the dataset group when
    /// you create a predictor. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Dataset
    /// groups</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your datasets groups, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetGroups.html">ListDatasetGroups</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
    /// can use the dataset group to create a predictor. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDatasetGroupRequest : AmazonForecastServiceRequest
    {
        private List<string> _datasetArns = new List<string>();
        private string _datasetGroupName;
        private Domain _domain;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DatasetArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the datasets that you want to include
        /// in the dataset group.
        /// </para>
        /// </summary>
        public List<string> DatasetArns
        {
            get { return this._datasetArns; }
            set { this._datasetArns = value; }
        }

        // Check to see if DatasetArns property is set
        internal bool IsSetDatasetArns()
        {
            return this._datasetArns != null && this._datasetArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupName. 
        /// <para>
        /// A name for the dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DatasetGroupName
        {
            get { return this._datasetGroupName; }
            set { this._datasetGroupName = value; }
        }

        // Check to see if DatasetGroupName property is set
        internal bool IsSetDatasetGroupName()
        {
            return this._datasetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the dataset group. When you add a dataset to a dataset
        /// group, this value and the value specified for the <code>Domain</code> parameter of
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation must match.
        /// </para>
        ///  
        /// <para>
        /// The <code>Domain</code> and <code>DatasetType</code> that you choose determine the
        /// fields that must be present in training data that you import to a dataset. For example,
        /// if you choose the <code>RETAIL</code> domain and <code>TARGET_TIME_SERIES</code> as
        /// the <code>DatasetType</code>, Amazon Forecast requires that <code>item_id</code>,
        /// <code>timestamp</code>, and <code>demand</code> fields are present in your data. For
        /// more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Dataset
        /// groups</a>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the dataset group to help you categorize and
        /// organize them. Each tag consists of a key and an optional value, both of which you
        /// define.
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