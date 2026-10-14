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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartStreamProcessor operation. <important> <para>
    /// Service availability notice: Streaming Video and Bulk Image Analysis is no longer
    /// available to new customers. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/rekognition-availability-changes.html">Rekognition
    /// feature availability changes</a>. </para> <para> <b>This change does not impact the
    /// availability of other Amazon Rekognition features.</b> </para> </important> <para>
    /// Starts processing a stream processor. You create a stream processor by calling <a>CreateStreamProcessor</a>.
    /// To tell <c>StartStreamProcessor</c> which stream processor to start, use the value
    /// of the <c>Name</c> field specified in the call to <c>CreateStreamProcessor</c>. </para>
    /// <para> If you are using a label detection stream processor to detect labels, you need
    /// to provide a <c>Start selector</c> and a <c>Stop selector</c> to determine the length
    /// of the stream processing time. </para>
    /// </summary>
    public partial class StartStreamProcessorRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stream processor to start processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartSelector. 
        /// <para>
        ///  Specifies the starting point in the Kinesis stream to start processing. You can use
        /// the producer timestamp or the fragment number. If you use the producer timestamp,
        /// you must put the time in milliseconds. For more information about fragment numbers,
        /// see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_reader_Fragment.html">Fragment</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This is a required parameter for label detection stream processors and should not
        /// be used to start a face search stream processor.
        /// </para>
        /// </summary>
        public StreamProcessingStartSelector StartSelector { get; set; }

        /// <summary>
        /// Checks to see if the StartSelector property is set.
        /// </summary>
        internal bool IsSetStartSelector() => this.StartSelector != null;

        /// <summary>
        /// Gets and sets the property StopSelector. 
        /// <para>
        ///  Specifies when to stop processing the stream. You can specify a maximum amount of
        /// time to process the video. 
        /// </para>
        ///  
        /// <para>
        /// This is a required parameter for label detection stream processors and should not
        /// be used to start a face search stream processor.
        /// </para>
        /// </summary>
        public StreamProcessingStopSelector StopSelector { get; set; }

        /// <summary>
        /// Checks to see if the StopSelector property is set.
        /// </summary>
        internal bool IsSetStopSelector() => this.StopSelector != null;
    }
}
