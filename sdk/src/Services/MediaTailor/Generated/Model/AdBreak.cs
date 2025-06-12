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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Ad break configuration parameters.
    /// </summary>
    public partial class AdBreak
    {
        private List<KeyValuePair> _adBreakMetadata = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private MessageType _messageType;
        private long? _offsetMillis;
        private SlateSource _slate;
        private SpliceInsertMessage _spliceInsertMessage;
        private TimeSignalMessage _timeSignalMessage;

        /// <summary>
        /// Gets and sets the property AdBreakMetadata. 
        /// <para>
        /// Defines a list of key/value pairs that MediaTailor generates within the <c>EXT-X-ASSET</c>tag
        /// for <c>SCTE35_ENHANCED</c> output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> AdBreakMetadata
        {
            get { return this._adBreakMetadata; }
            set { this._adBreakMetadata = value; }
        }

        // Check to see if AdBreakMetadata property is set
        internal bool IsSetAdBreakMetadata()
        {
            return this._adBreakMetadata != null && (this._adBreakMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The SCTE-35 ad insertion type. Accepted value: <c>SPLICE_INSERT</c>, <c>TIME_SIGNAL</c>.
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
        [AWSProperty(Required=true)]
        public long? OffsetMillis
        {
            get { return this._offsetMillis; }
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
        /// This defines the SCTE-35 <c>splice_insert()</c> message inserted around the ad. For
        /// information about using <c>splice_insert()</c>, see the SCTE-35 specficiaiton, section
        /// 9.7.3.1.
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

        /// <summary>
        /// Gets and sets the property TimeSignalMessage. 
        /// <para>
        /// Defines the SCTE-35 <c>time_signal</c> message inserted around the ad.
        /// </para>
        ///  
        /// <para>
        /// Programs on a channel's schedule can be configured with one or more ad breaks. You
        /// can attach a <c>splice_insert</c> SCTE-35 message to the ad break. This message provides
        /// basic metadata about the ad break.
        /// </para>
        ///  
        /// <para>
        /// See section 9.7.4 of the 2022 SCTE-35 specification for more information.
        /// </para>
        /// </summary>
        public TimeSignalMessage TimeSignalMessage
        {
            get { return this._timeSignalMessage; }
            set { this._timeSignalMessage = value; }
        }

        // Check to see if TimeSignalMessage property is set
        internal bool IsSetTimeSignalMessage()
        {
            return this._timeSignalMessage != null;
        }

    }
}