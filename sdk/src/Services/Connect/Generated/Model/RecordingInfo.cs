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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private string _deletionReason;
        private string _fragmentStartNumber;
        private string _fragmentStopNumber;
        private string _location;
        private MediaStreamType _mediaStreamType;
        private ParticipantType _participantType;
        private DateTime? _startTimestamp;
        private RecordingStatus _status;
        private DateTime? _stopTimestamp;
        private StorageType _storageType;

        /// <summary>
        /// Gets and sets the property DeletionReason. 
        /// <para>
        /// If the recording/transcript was deleted, this is the reason entered for the deletion.
        /// </para>
        /// </summary>
        public string DeletionReason
        {
            get { return this._deletionReason; }
            set { this._deletionReason = value; }
        }

        // Check to see if DeletionReason property is set
        internal bool IsSetDeletionReason()
        {
            return this._deletionReason != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentStartNumber. 
        /// <para>
        /// The number that identifies the Kinesis Video Streams fragment where the customer audio
        /// stream started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FragmentStartNumber
        {
            get { return this._fragmentStartNumber; }
            set { this._fragmentStartNumber = value; }
        }

        // Check to see if FragmentStartNumber property is set
        internal bool IsSetFragmentStartNumber()
        {
            return this._fragmentStartNumber != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentStopNumber. 
        /// <para>
        /// The number that identifies the Kinesis Video Streams fragment where the customer audio
        /// stream stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FragmentStopNumber
        {
            get { return this._fragmentStopNumber; }
            set { this._fragmentStopNumber = value; }
        }

        // Check to see if FragmentStopNumber property is set
        internal bool IsSetFragmentStopNumber()
        {
            return this._fragmentStopNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location, in Amazon S3, for the recording/transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// Information about the media stream used during the conversation.
        /// </para>
        /// </summary>
        public MediaStreamType MediaStreamType
        {
            get { return this._mediaStreamType; }
            set { this._mediaStreamType = value; }
        }

        // Check to see if MediaStreamType property is set
        internal bool IsSetMediaStreamType()
        {
            return this._mediaStreamType != null;
        }

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
        public ParticipantType ParticipantType
        {
            get { return this._participantType; }
            set { this._participantType = value; }
        }

        // Check to see if ParticipantType property is set
        internal bool IsSetParticipantType()
        {
            return this._participantType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// When the conversation of the last leg of the recording started in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recording/transcript.
        /// </para>
        /// </summary>
        public RecordingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StopTimestamp. 
        /// <para>
        /// When the conversation of the last leg of recording stopped in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StopTimestamp
        {
            get { return this._stopTimestamp; }
            set { this._stopTimestamp = value; }
        }

        // Check to see if StopTimestamp property is set
        internal bool IsSetStopTimestamp()
        {
            return this._stopTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Where the recording/transcript is stored.
        /// </para>
        /// </summary>
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}