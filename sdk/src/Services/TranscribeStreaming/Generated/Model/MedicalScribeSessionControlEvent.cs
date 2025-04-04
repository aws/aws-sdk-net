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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Specify the lifecycle of your streaming session.
    /// </summary>
    public partial class MedicalScribeSessionControlEvent
        : IEventStreamEvent
    {
        private MedicalScribeSessionControlEventType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of <c>MedicalScribeSessionControlEvent</c>. 
        /// </para>
        ///  
        /// <para>
        /// Possible Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>END_OF_SESSION</c> - Indicates the audio streaming is complete. After you send
        /// an END_OF_SESSION event, Amazon Web Services HealthScribe starts the post-stream analytics.
        /// The session can't be resumed after this event is sent. After Amazon Web Services HealthScribe
        /// processes the event, the real-time <c>StreamStatus</c> is <c>COMPLETED</c>. You get
        /// the <c>StreamStatus</c> and other stream details with the <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/API_streaming_GetMedicalScribeStream.html">GetMedicalScribeStream</a>
        /// API operation. For more information about different streaming statuses, see the <c>StreamStatus</c>
        /// description in the <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/API_streaming_MedicalScribeStreamDetails.html">MedicalScribeStreamDetails</a>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeSessionControlEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}