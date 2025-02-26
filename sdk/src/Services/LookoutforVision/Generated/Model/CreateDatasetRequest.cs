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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// Creates a new dataset in an Amazon Lookout for Vision project. <c>CreateDataset</c>
    /// can create a training or a test dataset from a valid dataset source (<c>DatasetSource</c>).
    /// 
    ///  
    /// <para>
    /// If you want a single dataset project, specify <c>train</c> for the value of <c>DatasetType</c>.
    /// </para>
    ///  
    /// <para>
    /// To have a project with separate training and test datasets, call <c>CreateDataset</c>
    /// twice. On the first call, specify <c>train</c> for the value of <c>DatasetType</c>.
    /// On the second call, specify <c>test</c> for the value of <c>DatasetType</c>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:CreateDataset</c>
    /// operation.
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
        /// ClientToken is an idempotency token that ensures a call to <c>CreateDataset</c> completes
        /// only once. You choose the value to pass. For example, An issue might prevent you from
        /// getting a response from <c>CreateDataset</c>. In this case, safely retry your call
        /// to <c>CreateDataset</c> by using the same <c>ClientToken</c> parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <c>ClientToken</c>, the AWS SDK you are using inserts
        /// a value for you. This prevents retries after a network error from making multiple
        /// dataset creation requests. You'll need to provide your own value for other use cases.
        /// 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <c>ClientToken</c> is considered a new call to <c>CreateDataset</c>.
        /// An idempotency token is active for 8 hours. 
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
        /// If you don't specify <c>DatasetSource</c>, an empty dataset is created and the operation
        /// synchronously returns. Later, you can add JSON Lines by calling <a>UpdateDatasetEntries</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for <c>DataSource</c>, the manifest at the S3 location is validated
        /// and used to create the dataset. The call to <c>CreateDataset</c> is asynchronous and
        /// might take a while to complete. To find out the current status, Check the value of
        /// <c>Status</c> returned in a call to <a>DescribeDataset</a>.
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
        /// The type of the dataset. Specify <c>train</c> for a training dataset. Specify <c>test</c>
        /// for a test dataset.
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