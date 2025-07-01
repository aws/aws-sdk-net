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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Defines an incremental training data channel that references a previously trained
    /// model. Incremental training allows you to update an existing trained model with new
    /// data, building upon the knowledge from a base model rather than training from scratch.
    /// This can significantly reduce training time and computational costs while improving
    /// model performance with additional data.
    /// </summary>
    public partial class IncrementalTrainingDataChannel
    {
        private string _channelName;
        private string _trainedModelArn;
        private string _versionIdentifier;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the incremental training data channel. This name is used to identify the
        /// channel during the training process and must be unique within the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the base trained model to use for incremental training.
        /// This model serves as the starting point for the incremental training process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the base trained model to use for incremental training.
        /// If not specified, the latest version of the trained model is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string VersionIdentifier
        {
            get { return this._versionIdentifier; }
            set { this._versionIdentifier = value; }
        }

        // Check to see if VersionIdentifier property is set
        internal bool IsSetVersionIdentifier()
        {
            return this._versionIdentifier != null;
        }

    }
}