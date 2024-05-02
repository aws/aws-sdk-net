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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
    /// Container for the parameters to the StartStreamProcessor operation.
    /// Starts processing a stream processor. You create a stream processor by calling <a>CreateStreamProcessor</a>.
    /// To tell <c>StartStreamProcessor</c> which stream processor to start, use the value
    /// of the <c>Name</c> field specified in the call to <c>CreateStreamProcessor</c>.
    /// 
    ///  
    /// <para>
    /// If you are using a label detection stream processor to detect labels, you need to
    /// provide a <c>Start selector</c> and a <c>Stop selector</c> to determine the length
    /// of the stream processing time.
    /// </para>
    /// </summary>
    public partial class StartStreamProcessorRequest : AmazonRekognitionRequest
    {
        private string _name;
        private StreamProcessingStartSelector _startSelector;
        private StreamProcessingStopSelector _stopSelector;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stream processor to start processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public StreamProcessingStartSelector StartSelector
        {
            get { return this._startSelector; }
            set { this._startSelector = value; }
        }

        // Check to see if StartSelector property is set
        internal bool IsSetStartSelector()
        {
            return this._startSelector != null;
        }

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
        public StreamProcessingStopSelector StopSelector
        {
            get { return this._stopSelector; }
            set { this._stopSelector = value; }
        }

        // Check to see if StopSelector property is set
        internal bool IsSetStopSelector()
        {
            return this._stopSelector != null;
        }

    }
}