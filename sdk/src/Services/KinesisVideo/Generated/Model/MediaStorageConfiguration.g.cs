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
    /// A structure that encapsulates, or contains, the media storage configuration properties.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If <c>StorageStatus</c> is enabled, the data will be stored in the <c>StreamARN</c>
    /// provided. In order for WebRTC Ingestion to work, the stream must have data retention
    /// enabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>StorageStatus</c> is disabled, no data will be stored, and the <c>StreamARN</c>
    /// parameter will not be needed. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MediaStorageConfiguration
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the media storage configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaStorageConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;
    }
}
