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
    /// Container for the parameters to the DeleteStream operation. Deletes a Kinesis video
    /// stream and the data contained in the stream. <para> This method marks the stream for
    /// deletion, and makes the data in the stream inaccessible immediately. </para> <para>
    /// </para> <para> To ensure that you have the latest version of the stream before deleting
    /// it, you can specify the stream version. Kinesis Video Streams assigns a version to
    /// each stream. When you update a stream, Kinesis Video Streams assigns a new version
    /// number. To get the latest stream version, use the <c>DescribeStream</c> API. </para>
    /// <para> This operation requires permission for the <c>KinesisVideo:DeleteStream</c>
    /// action. </para>
    /// </summary>
    public partial class DeleteStreamRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// Optional: The version of the stream that you want to delete. 
        /// </para>
        ///  
        /// <para>
        /// Specify the version as a safeguard to ensure that your are deleting the correct stream.
        /// To get the stream version, use the <c>DescribeStream</c> API.
        /// </para>
        ///  
        /// <para>
        /// If not specified, only the <c>CreationTime</c> is checked before deleting the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream that you want to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;
    }
}
