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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
using Amazon.ConnectHealth.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// An event containing transcript data from the Medical Scribe stream
    /// </summary>
    public partial class MedicalScribeTranscriptEvent
        : IEventStreamEvent
    {
        private MedicalScribeTranscriptSegment _transcriptSegment;

        /// <summary>
        /// Gets and sets the property TranscriptSegment. 
        /// <para>
        /// A segment of the transcript
        /// </para>
        /// </summary>
        public MedicalScribeTranscriptSegment TranscriptSegment
        {
            get { return this._transcriptSegment; }
            set { this._transcriptSegment = value; }
        }

        // Check to see if TranscriptSegment property is set
        internal bool IsSetTranscriptSegment()
        {
            return this._transcriptSegment != null;
        }

    }
}