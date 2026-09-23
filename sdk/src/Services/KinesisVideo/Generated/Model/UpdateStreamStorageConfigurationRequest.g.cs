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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamStorageConfiguration operation. Updates
    /// the storage configuration for an existing Kinesis video stream. <para> This operation
    /// allows you to modify the storage tier settings for a stream, enabling you to optimize
    /// storage costs and performance based on your access patterns. </para> <para> <c>UpdateStreamStorageConfiguration</c>
    /// is an asynchronous operation. </para> <para> You must have permissions for the <c>KinesisVideo:UpdateStreamStorageConfiguration</c>
    /// action. </para>
    /// </summary>
    public partial class UpdateStreamStorageConfigurationRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the stream whose storage configuration you want to change. To get the
        /// version, call either the <c>DescribeStream</c> or the <c>ListStreams</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream for which you want to update the storage
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for which you want to update the storage configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property StreamStorageConfiguration. 
        /// <para>
        /// The new storage configuration for the stream. This includes the default storage tier
        /// that determines how stream data is stored and accessed.
        /// </para>
        ///  
        /// <para>
        /// Different storage tiers offer varying levels of performance and cost optimization
        /// to match your specific use case requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamStorageConfiguration StreamStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StreamStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStreamStorageConfiguration() => this.StreamStorageConfiguration != null;
    }
}
