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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about the model training data channel. A training data channel is a named
    /// data source that the training algorithms can consume.
    /// </summary>
    public partial class ModelTrainingDataChannel
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the training data channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property MlInputChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ML input channel for this model training data
        /// channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MlInputChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the MlInputChannelArn property is set.
        /// </summary>
        internal bool IsSetMlInputChannelArn() => this.MlInputChannelArn != null;

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// Specifies how the training data stored in Amazon S3 should be distributed to training
        /// instances. This parameter controls the data distribution strategy for the training
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FullyReplicated</c> - The entire dataset is replicated on each training instance.
        /// This is suitable for smaller datasets and algorithms that require access to the complete
        /// dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShardedByS3Key</c> - The dataset is distributed across training instances based
        /// on Amazon S3 key names. This is suitable for larger datasets and distributed training
        /// scenarios where each instance processes a subset of the data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3DataDistributionType S3DataDistributionType { get; set; }

        /// <summary>
        /// Checks to see if the S3DataDistributionType property is set.
        /// </summary>
        internal bool IsSetS3DataDistributionType() => this.S3DataDistributionType != null;
    }
}
