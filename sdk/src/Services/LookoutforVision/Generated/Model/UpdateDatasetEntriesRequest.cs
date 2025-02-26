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
    /// Container for the parameters to the UpdateDatasetEntries operation.
    /// Adds or updates one or more JSON Line entries in a dataset. A JSON Line includes information
    /// about an image used for training or testing an Amazon Lookout for Vision model.
    /// 
    ///  
    /// <para>
    /// To update an existing JSON Line, use the <c>source-ref</c> field to identify the JSON
    /// Line. The JSON line that you supply replaces the existing JSON line. Any existing
    /// annotations that are not in the new JSON line are removed from the dataset. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <i>Defining JSON lines for anomaly classification</i> in
    /// the Amazon Lookout for Vision Developer Guide. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The images you reference in the <c>source-ref</c> field of a JSON line, must be in
    /// the same S3 bucket as the existing images in the dataset. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Updating a dataset might take a while to complete. To check the current status, call
    /// <a>DescribeDataset</a> and check the <c>Status</c> field in the response.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:UpdateDatasetEntries</c>
    /// operation.
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
        /// ClientToken is an idempotency token that ensures a call to <c>UpdateDatasetEntries</c>
        /// completes only once. You choose the value to pass. For example, An issue might prevent
        /// you from getting a response from <c>UpdateDatasetEntries</c>. In this case, safely
        /// retry your call to <c>UpdateDatasetEntries</c> by using the same <c>ClientToken</c>
        /// parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <c>ClientToken</c>, the AWS SDK you are using inserts
        /// a value for you. This prevents retries after a network error from making multiple
        /// updates with the same dataset entries. You'll need to provide your own value for other
        /// use cases. 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <c>ClientToken</c> is considered a new call to <c>UpdateDatasetEntries</c>.
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
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of the dataset that you want to update. Specify <c>train</c> to update the
        /// training dataset. Specify <c>test</c> to update the test dataset. If you have a single
        /// dataset project, specify <c>train</c>.
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