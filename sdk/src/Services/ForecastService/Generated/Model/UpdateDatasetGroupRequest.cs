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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatasetGroup operation.
    /// Replaces the datasets in a dataset group with the specified datasets.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>Status</c> of the dataset group must be <c>ACTIVE</c> before you can use the
    /// dataset group to create a predictor. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
    /// operation to get the status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateDatasetGroupRequest : AmazonForecastServiceRequest
    {
        private List<string> _datasetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _datasetGroupArn;

        /// <summary>
        /// Gets and sets the property DatasetArns. 
        /// <para>
        /// An array of the Amazon Resource Names (ARNs) of the datasets to add to the dataset
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DatasetArns
        {
            get { return this._datasetArns; }
            set { this._datasetArns = value; }
        }

        // Check to see if DatasetArns property is set
        internal bool IsSetDatasetArns()
        {
            return this._datasetArns != null && (this._datasetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The ARN of the dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

    }
}