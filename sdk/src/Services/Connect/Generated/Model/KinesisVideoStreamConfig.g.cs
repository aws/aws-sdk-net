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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration information of a Kinesis video stream.
    /// </summary>
    public partial class KinesisVideoStreamConfig
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the video stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The number of hours data is retained in the stream. Kinesis Video Streams retains
        /// the data in a data store that is associated with the stream.
        /// </para>
        ///  
        /// <para>
        /// The default value is 0, indicating that the stream does not persist data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 87600)]
        public int? RetentionPeriodHours { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriodHours property is set.
        /// </summary>
        internal bool IsSetRetentionPeriodHours() => this.RetentionPeriodHours.HasValue;
    }
}
