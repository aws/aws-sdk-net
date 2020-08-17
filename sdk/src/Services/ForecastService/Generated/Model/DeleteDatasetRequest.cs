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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataset operation.
    /// Deletes an Amazon Forecast dataset that was created using the <a>CreateDataset</a>
    /// operation. You can only delete datasets that have a status of <code>ACTIVE</code>
    /// or <code>CREATE_FAILED</code>. To get the status use the <a>DescribeDataset</a> operation.
    /// 
    ///  <note> 
    /// <para>
    /// Forecast does not automatically update any dataset groups that contain the deleted
    /// dataset. In order to update the dataset group, use the operation, omitting the deleted
    /// dataset's ARN.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDatasetRequest : AmazonForecastServiceRequest
    {
        private string _datasetArn;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset to delete.
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

    }
}