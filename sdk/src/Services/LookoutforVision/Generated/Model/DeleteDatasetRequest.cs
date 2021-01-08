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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataset operation.
    /// Deletes an existing Amazon Lookout for Vision <code>dataset</code>. 
    /// 
    ///  
    /// <para>
    /// If your the project has a single dataset, you must create a new dataset before you
    /// can create a model.
    /// </para>
    ///  
    /// <para>
    /// If you project has a training dataset and a test dataset consider the following. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you delete the test dataset, your project reverts to a single dataset project.
    /// If you then train the model, Amazon Lookout for Vision internally splits the remaining
    /// dataset into a training and test dataset.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you delete the training dataset, you must create a training dataset before you
    /// can create a model.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// It might take a while to delete the dataset. To check the current status, check the
    /// <code>Status</code> field in the response from a call to <a>DescribeDataset</a>. 
    /// </para>
    /// </summary>
    public partial class DeleteDatasetRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private string _datasetType;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <code>DeleteDataset</code>
        /// completes only once. You choose the value to pass. For example, An issue, such as
        /// an network outage, might prevent you from getting a response from <code>DeleteDataset</code>.
        /// In this case, safely retry your call to <code>DeleteDataset</code> by using the same
        /// <code>ClientToken</code> parameter value. An error occurs if the other input parameters
        /// are not the same as in the first request. Using a different value for <code>ClientToken</code>
        /// is considered a new call to <code>DeleteDataset</code>. An idempotency token is active
        /// for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of the dataset to delete. Specify <code>train</code> to delete the training
        /// dataset. Specify <code>test</code> to delete the test dataset. To delete the dataset
        /// in a single dataset project, specify <code>train</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string DatasetType
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the dataset that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}