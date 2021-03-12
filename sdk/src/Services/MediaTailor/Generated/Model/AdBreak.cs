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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Ad break configuration parameters.
    /// </summary>
    public partial class AdBreak
    {
        private MessageType _messageType;
        private long? _offsetMillis;
        private SlateSource _slate;
        private SpliceInsertMessage _spliceInsertMessage;

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The SCTE-35 ad insertion type. Accepted value: SPLICE_INSERT.
        /// </para>
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
        /// Gets and sets the property OffsetMillis. 
        /// <para>
        /// How long (in milliseconds) after the beginning of the program that an ad starts. This
        /// value must fall within 100ms of a segment boundary, otherwise the ad break will be
        /// skipped.
        /// </para>
        /// </summary>
        public long OffsetMillis
        {
            get { return this._offsetMillis.GetValueOrDefault(); }
            set { this._offsetMillis = value; }
        }

        // Check to see if OffsetMillis property is set
        internal bool IsSetOffsetMillis()
        {
            return this._offsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Slate. 
        /// <para>
        /// Ad break slate configuration.
        /// </para>
        /// </summary>
        public SlateSource Slate
        {
            get { return this._slate; }
            set { this._slate = value; }
        }

        // Check to see if Slate property is set
        internal bool IsSetSlate()
        {
            return this._slate != null;
        }

        /// <summary>
        /// Gets and sets the property SpliceInsertMessage. 
        /// <para>
        /// This defines the SCTE-35 splice_insert() message inserted around the ad. For information
        /// about using splice_insert(), see the SCTE-35 specficiaiton, section 9.7.3.1.
        /// </para>
        /// </summary>
        public SpliceInsertMessage SpliceInsertMessage
        {
            get { return this._spliceInsertMessage; }
            set { this._spliceInsertMessage = value; }
        }

        // Check to see if SpliceInsertMessage property is set
        internal bool IsSetSpliceInsertMessage()
        {
            return this._spliceInsertMessage != null;
        }

    }
}