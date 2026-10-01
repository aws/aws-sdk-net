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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Ad break configuration parameters.
    /// </summary>
    public partial class AdBreak
    {
        /// <summary>
        /// Gets and sets the property AdBreakMetadata. 
        /// <para>
        /// Defines a list of key/value pairs that MediaTailor generates within the <c>EXT-X-ASSET</c>tag
        /// for <c>SCTE35_ENHANCED</c> output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> AdBreakMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the AdBreakMetadata property is set.
        /// </summary>
        internal bool IsSetAdBreakMetadata() => this.AdBreakMetadata != null && (this.AdBreakMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The SCTE-35 ad insertion type. Accepted value: <c>SPLICE_INSERT</c>, <c>TIME_SIGNAL</c>.
        /// </para>
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;

        /// <summary>
        /// Gets and sets the property OffsetMillis. 
        /// <para>
        /// How long (in milliseconds) after the beginning of the program that an ad starts. This
        /// value must fall within 100ms of a segment boundary, otherwise the ad break will be
        /// skipped.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? OffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the OffsetMillis property is set.
        /// </summary>
        internal bool IsSetOffsetMillis() => this.OffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Slate. 
        /// <para>
        /// Ad break slate configuration.
        /// </para>
        /// </summary>
        public SlateSource Slate { get; set; }

        /// <summary>
        /// Checks to see if the Slate property is set.
        /// </summary>
        internal bool IsSetSlate() => this.Slate != null;

        /// <summary>
        /// Gets and sets the property SpliceInsertMessage. 
        /// <para>
        /// This defines the SCTE-35 <c>splice_insert()</c> message inserted around the ad. For
        /// information about using <c>splice_insert()</c>, see the SCTE-35 specficiaiton, section
        /// 9.7.3.1.
        /// </para>
        /// </summary>
        public SpliceInsertMessage SpliceInsertMessage { get; set; }

        /// <summary>
        /// Checks to see if the SpliceInsertMessage property is set.
        /// </summary>
        internal bool IsSetSpliceInsertMessage() => this.SpliceInsertMessage != null;

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
        public TimeSignalMessage TimeSignalMessage { get; set; }

        /// <summary>
        /// Checks to see if the TimeSignalMessage property is set.
        /// </summary>
        internal bool IsSetTimeSignalMessage() => this.TimeSignalMessage != null;
    }
}
