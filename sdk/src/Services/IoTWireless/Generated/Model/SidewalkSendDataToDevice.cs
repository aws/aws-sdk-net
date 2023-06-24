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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Information about a Sidewalk router.
    /// </summary>
    public partial class SidewalkSendDataToDevice
    {
        private int? _ackModeRetryDurationSecs;
        private MessageType _messageType;
        private int? _seq;

        /// <summary>
        /// Gets and sets the property AckModeRetryDurationSecs. 
        /// <para>
        /// The duration of time in seconds to retry sending the ACK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=604800)]
        public int AckModeRetryDurationSecs
        {
            get { return this._ackModeRetryDurationSecs.GetValueOrDefault(); }
            set { this._ackModeRetryDurationSecs = value; }
        }

        // Check to see if AckModeRetryDurationSecs property is set
        internal bool IsSetAckModeRetryDurationSecs()
        {
            return this._ackModeRetryDurationSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageType.
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property Seq. 
        /// <para>
        /// The sequence number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16383)]
        public int Seq
        {
            get { return this._seq.GetValueOrDefault(); }
            set { this._seq = value; }
        }

        // Check to see if Seq property is set
        internal bool IsSetSeq()
        {
            return this._seq.HasValue; 
        }

    }
}