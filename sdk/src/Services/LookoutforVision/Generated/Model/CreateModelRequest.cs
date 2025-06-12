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
    /// Container for the parameters to the CreateModel operation.
    /// Creates a new version of a model within an an Amazon Lookout for Vision project. <c>CreateModel</c>
    /// is an asynchronous operation in which Amazon Lookout for Vision trains, tests, and
    /// evaluates a new version of a model. 
    /// 
    ///  
    /// <para>
    /// To get the current status, check the <c>Status</c> field returned in the response
    /// from <a>DescribeModel</a>.
    /// </para>
    ///  
    /// <para>
    /// If the project has a single dataset, Amazon Lookout for Vision internally splits the
    /// dataset to create a training and a test dataset. If the project has a training and
    /// a test dataset, Lookout for Vision uses the respective datasets to train and test
    /// the model. 
    /// </para>
    ///  
    /// <para>
    /// After training completes, the evaluation metrics are stored at the location specified
    /// in <c>OutputConfig</c>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:CreateModel</c>
    /// operation. If you want to tag your model, you also require permission to the <c>lookoutvision:TagResource</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class CreateModelRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private string _description;
        private string _kmsKeyId;
        private OutputConfig _outputConfig;
        private string _projectName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <c>CreateModel</c> completes
        /// only once. You choose the value to pass. For example, An issue might prevent you from
        /// getting a response from <c>CreateModel</c>. In this case, safely retry your call to
        /// <c>CreateModel</c> by using the same <c>ClientToken</c> parameter value. 
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <c>ClientToken</c>, the AWS SDK you are using inserts
        /// a value for you. This prevents retries after a network error from starting multiple
        /// training jobs. You'll need to provide your own value for other use cases. 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <c>ClientToken</c> is considered a new call to <c>CreateModel</c>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier for your AWS KMS key. The key is used to encrypt training and test
        /// images copied into the service for model training. Your source images are unaffected.
        /// If this parameter is not specified, the copied images are encrypted by a key that
        /// AWS owns and manages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location where Amazon Lookout for Vision saves the training results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in which you want to create a model version.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that you want to attach to the model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}