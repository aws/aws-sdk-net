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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private CloudWatchConfig _cloudWatchConfig;
        private bool? _embeddingDataDeliveryEnabled;
        private bool? _imageDataDeliveryEnabled;
        private S3Config _s3Config;
        private bool? _textDataDeliveryEnabled;
        private bool? _videoDataDeliveryEnabled;

        /// <summary>
        /// Gets and sets the property CloudWatchConfig. 
        /// <para>
        /// CloudWatch logging configuration.
        /// </para>
        /// </summary>
        public CloudWatchConfig CloudWatchConfig
        {
            get { return this._cloudWatchConfig; }
            set { this._cloudWatchConfig = value; }
        }

        // Check to see if CloudWatchConfig property is set
        internal bool IsSetCloudWatchConfig()
        {
            return this._cloudWatchConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddingDataDeliveryEnabled. 
        /// <para>
        /// Set to include embeddings data in the log delivery.
        /// </para>
        /// </summary>
        public bool? EmbeddingDataDeliveryEnabled
        {
            get { return this._embeddingDataDeliveryEnabled; }
            set { this._embeddingDataDeliveryEnabled = value; }
        }

        // Check to see if EmbeddingDataDeliveryEnabled property is set
        internal bool IsSetEmbeddingDataDeliveryEnabled()
        {
            return this._embeddingDataDeliveryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageDataDeliveryEnabled. 
        /// <para>
        /// Set to include image data in the log delivery.
        /// </para>
        /// </summary>
        public bool? ImageDataDeliveryEnabled
        {
            get { return this._imageDataDeliveryEnabled; }
            set { this._imageDataDeliveryEnabled = value; }
        }

        // Check to see if ImageDataDeliveryEnabled property is set
        internal bool IsSetImageDataDeliveryEnabled()
        {
            return this._imageDataDeliveryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// S3 configuration for storing log data.
        /// </para>
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property TextDataDeliveryEnabled. 
        /// <para>
        /// Set to include text data in the log delivery.
        /// </para>
        /// </summary>
        public bool? TextDataDeliveryEnabled
        {
            get { return this._textDataDeliveryEnabled; }
            set { this._textDataDeliveryEnabled = value; }
        }

        // Check to see if TextDataDeliveryEnabled property is set
        internal bool IsSetTextDataDeliveryEnabled()
        {
            return this._textDataDeliveryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoDataDeliveryEnabled. 
        /// <para>
        /// Set to include video data in the log delivery.
        /// </para>
        /// </summary>
        public bool? VideoDataDeliveryEnabled
        {
            get { return this._videoDataDeliveryEnabled; }
            set { this._videoDataDeliveryEnabled = value; }
        }

        // Check to see if VideoDataDeliveryEnabled property is set
        internal bool IsSetVideoDataDeliveryEnabled()
        {
            return this._videoDataDeliveryEnabled.HasValue; 
        }

    }
}