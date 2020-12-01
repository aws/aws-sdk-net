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
    /// Container for the parameters to the UpdateDatasetEntries operation.
    /// Adds one or more JSON Line entries to a dataset. A JSON Line includes information
    /// about an image used for training or testing an Amazon Lookout for Vision model. The
    /// following is an example JSON Line.
    /// 
    ///  
    /// <para>
    /// Updating a dataset might take a while to complete. To check the current status, call
    /// <a>DescribeDataset</a> and check the <code>Status</code> field in the response.
    /// </para>
    /// </summary>
    public partial class UpdateDatasetEntriesRequest : AmazonLookoutforVisionRequest
    {
        private MemoryStream _changes;
        private string _clientToken;
        private string _datasetType;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// The entries to add to the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10485760)]
        public MemoryStream Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <code>UpdateDatasetEntries</code>
        /// completes only once. You choose the value to pass. For example, An issue, such as
        /// an network outage, might prevent you from getting a response from <code>UpdateDatasetEntries</code>.
        /// In this case, safely retry your call to <code>UpdateDatasetEntries</code> by using
        /// the same <code>ClientToken</code> parameter value. An error occurs if the other input
        /// parameters are not the same as in the first request. Using a different value for <code>ClientToken</code>
        /// is considered a new call to <code>UpdateDatasetEntries</code>. An idempotency token
        /// is active for 8 hours. 
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
        /// The type of the dataset that you want to update. Specify <code>train</code> to update
        /// the training dataset. Specify <code>test</code> to update the test dataset. If you
        /// have a single dataset project, specify <code>train</code>.
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
        /// The name of the project that contains the dataset that you want to update.
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