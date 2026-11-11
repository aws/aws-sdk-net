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
    /// Information about a voice recording, chat transcript, or screen recording.
    /// </summary>
    public partial class RecordingInfo
    {
        /// <summary>
        /// Gets and sets the property DeletionReason. 
        /// <para>
        /// If the recording/transcript was deleted, this is the reason entered for the deletion.
        /// </para>
        /// </summary>
        public string DeletionReason { get; set; }

        /// <summary>
        /// Checks to see if the DeletionReason property is set.
        /// </summary>
        internal bool IsSetDeletionReason() => this.DeletionReason != null;

        /// <summary>
        /// Gets and sets the property FragmentStartNumber. 
        /// <para>
        /// The number that identifies the Kinesis Video Streams fragment where the customer audio
        /// stream started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FragmentStartNumber { get; set; }

        /// <summary>
        /// Checks to see if the FragmentStartNumber property is set.
        /// </summary>
        internal bool IsSetFragmentStartNumber() => this.FragmentStartNumber != null;

        /// <summary>
        /// Gets and sets the property FragmentStopNumber. 
        /// <para>
        /// The number that identifies the Kinesis Video Streams fragment where the customer audio
        /// stream stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FragmentStopNumber { get; set; }

        /// <summary>
        /// Checks to see if the FragmentStopNumber property is set.
        /// </summary>
        internal bool IsSetFragmentStopNumber() => this.FragmentStopNumber != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location, in Amazon S3, for the recording/transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// Information about the media stream used during the conversation.
        /// </para>
        /// </summary>
        public MediaStreamType MediaStreamType { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamType property is set.
        /// </summary>
        internal bool IsSetMediaStreamType() => this.MediaStreamType != null;

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Information about the conversation participant, whether they are an agent or contact.
        /// The participant types are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manager
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Thirdparty
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supervisor
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ParticipantType ParticipantType { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantType property is set.
        /// </summary>
        internal bool IsSetParticipantType() => this.ParticipantType != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// When the conversation of the last leg of the recording started in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recording/transcript.
        /// </para>
        /// </summary>
        public RecordingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StopTimestamp. 
        /// <para>
        /// When the conversation of the last leg of recording stopped in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StopTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StopTimestamp property is set.
        /// </summary>
        internal bool IsSetStopTimestamp() => this.StopTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Where the recording/transcript is stored.
        /// </para>
        /// </summary>
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property UnprocessedTranscriptLocation. 
        /// <para>
        ///  The location, in Amazon S3, for the unprocessed transcript if any media processing
        /// was performed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UnprocessedTranscriptLocation { get; set; }

        /// <summary>
        /// Checks to see if the UnprocessedTranscriptLocation property is set.
        /// </summary>
        internal bool IsSetUnprocessedTranscriptLocation() => this.UnprocessedTranscriptLocation != null;
    }
}
