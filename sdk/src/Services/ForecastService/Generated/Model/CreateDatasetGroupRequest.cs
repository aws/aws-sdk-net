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
    /// Container for the parameters to the CreateDatasetGroup operation.
    /// Creates an Amazon Forecast dataset group, which holds a collection of related datasets.
    /// You can add datasets to the dataset group when you create the dataset group, or you
    /// can add datasets later with the <a>UpdateDatasetGroup</a> operation.
    /// 
    ///  
    /// <para>
    /// After creating a dataset group and adding datasets, you use the dataset group when
    /// you create a predictor. For more information, see <a>howitworks-datasets-groups</a>.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your datasets groups, use the <a>ListDatasetGroups</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
    /// can create a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a>
    /// operation to get the status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDatasetGroupRequest : AmazonForecastServiceRequest
    {
        private List<string> _datasetArns = new List<string>();
        private string _datasetGroupName;
        private Domain _domain;

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
        /// The domain associated with the dataset group. The <code>Domain</code> and <code>DatasetType</code>
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

    }
}