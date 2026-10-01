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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Configuration fields for invocation logging.
    /// </summary>
    public partial class LoggingConfig
    {
        /// <summary>
        /// Gets and sets the property AudioDataDeliveryEnabled. 
        /// <para>
        /// Set to include audio data in the log delivery.
        /// </para>
        /// </summary>
        public bool? AudioDataDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AudioDataDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetAudioDataDeliveryEnabled() => this.AudioDataDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CloudWatchConfig. 
        /// <para>
        /// CloudWatch logging configuration.
        /// </para>
        /// </summary>
        public CloudWatchConfig CloudWatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchConfig property is set.
        /// </summary>
        internal bool IsSetCloudWatchConfig() => this.CloudWatchConfig != null;

        /// <summary>
        /// Gets and sets the property EmbeddingDataDeliveryEnabled. 
        /// <para>
        /// Set to include embeddings data in the log delivery.
        /// </para>
        /// </summary>
        public bool? EmbeddingDataDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingDataDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetEmbeddingDataDeliveryEnabled() => this.EmbeddingDataDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ImageDataDeliveryEnabled. 
        /// <para>
        /// Set to include image data in the log delivery.
        /// </para>
        /// </summary>
        public bool? ImageDataDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ImageDataDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetImageDataDeliveryEnabled() => this.ImageDataDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// S3 configuration for storing log data.
        /// </para>
        /// </summary>
        public S3Config S3Config { get; set; }

        /// <summary>
        /// Checks to see if the S3Config property is set.
        /// </summary>
        internal bool IsSetS3Config() => this.S3Config != null;

        /// <summary>
        /// Gets and sets the property TextDataDeliveryEnabled. 
        /// <para>
        /// Set to include text data in the log delivery.
        /// </para>
        /// </summary>
        public bool? TextDataDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TextDataDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetTextDataDeliveryEnabled() => this.TextDataDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property VideoDataDeliveryEnabled. 
        /// <para>
        /// Set to include video data in the log delivery.
        /// </para>
        /// </summary>
        public bool? VideoDataDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the VideoDataDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetVideoDataDeliveryEnabled() => this.VideoDataDeliveryEnabled.HasValue;
    }
}
