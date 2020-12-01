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
    /// Container for the parameters to the CreateDataset operation.
    /// Creates a new dataset in an Amazon Lookout for Vision project. <code>CreateDataset</code>
    /// can create a training or a test dataset from a valid dataset source (<code>DatasetSource</code>).
    /// 
    ///  
    /// <para>
    /// If you want a single dataset project, specify <code>train</code> for the value of
    /// <code>DatasetType</code>.
    /// </para>
    ///  
    /// <para>
    /// To have a project with separate training and test datasets, call <code>CreateDataset</code>
    /// twice. On the first call, specify <code>train</code> for the value of <code>DatasetType</code>.
    /// On the second call, specify <code>test</code> for the value of <code>DatasetType</code>.
    /// of dataset with 
    /// </para>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private DatasetSource _datasetSource;
        private string _datasetType;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <code>CreateDataset</code>
        /// completes only once. You choose the value to pass. For example, An issue, such as
        /// an network outage, might prevent you from getting a response from <code>CreateDataset</code>.
        /// In this case, safely retry your call to <code>CreateDataset</code> by using the same
        /// <code>ClientToken</code> parameter value. An error occurs if the other input parameters
        /// are not the same as in the first request. Using a different value for <code>ClientToken</code>
        /// is considered a new call to <code>CreateDataset</code>. An idempotency token is active
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
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The location of the manifest file that Amazon Lookout for Vision uses to create the
        /// dataset.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <code>DatasetSource</code>, an empty dataset is created and the
        /// operation synchronously returns. Later, you can add JSON Lines by calling <a>UpdateDatasetEntries</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for <code>DataSource</code>, the manifest at the S3 location
        /// is validated and used to create the dataset. The call to <code>CreateDataset</code>
        /// is asynchronous and might take a while to complete. To find out the current status,
        /// Check the value of <code>Status</code> returned in a call to <a>DescribeDataset</a>.
        /// </para>
        /// </summary>
        public DatasetSource DatasetSource
        {
            get { return this._datasetSource; }
            set { this._datasetSource = value; }
        }

        // Check to see if DatasetSource property is set
        internal bool IsSetDatasetSource()
        {
            return this._datasetSource != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of the dataset. Specify <code>train</code> for a training dataset. Specify
        /// <code>test</code> for a test dataset.
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
        /// The name of the project in which you want to create a dataset.
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