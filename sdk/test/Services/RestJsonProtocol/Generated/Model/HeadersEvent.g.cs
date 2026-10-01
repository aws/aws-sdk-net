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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// </summary>
    public partial class HeadersEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property BlobHeader.
        /// </summary>
        public MemoryStream BlobHeader { get; set; }

        /// <summary>
        /// Checks to see if the BlobHeader property is set.
        /// </summary>
        internal bool IsSetBlobHeader() => this.BlobHeader != null;

        /// <summary>
        /// Gets and sets the property BooleanHeader.
        /// </summary>
        public bool? BooleanHeader { get; set; }

        /// <summary>
        /// Checks to see if the BooleanHeader property is set.
        /// </summary>
        internal bool IsSetBooleanHeader() => this.BooleanHeader.HasValue;

        /// <summary>
        /// Gets and sets the property ByteHeader.
        /// </summary>
        public int? ByteHeader { get; set; }

        /// <summary>
        /// Checks to see if the ByteHeader property is set.
        /// </summary>
        internal bool IsSetByteHeader() => this.ByteHeader.HasValue;

        /// <summary>
        /// Gets and sets the property IntHeader.
        /// </summary>
        public int? IntHeader { get; set; }

        /// <summary>
        /// Checks to see if the IntHeader property is set.
        /// </summary>
        internal bool IsSetIntHeader() => this.IntHeader.HasValue;

        /// <summary>
        /// Gets and sets the property LongHeader.
        /// </summary>
        public long? LongHeader { get; set; }

        /// <summary>
        /// Checks to see if the LongHeader property is set.
        /// </summary>
        internal bool IsSetLongHeader() => this.LongHeader.HasValue;

        /// <summary>
        /// Gets and sets the property ShortHeader.
        /// </summary>
        public int? ShortHeader { get; set; }

        /// <summary>
        /// Checks to see if the ShortHeader property is set.
        /// </summary>
        internal bool IsSetShortHeader() => this.ShortHeader.HasValue;

        /// <summary>
        /// Gets and sets the property StringHeader.
        /// </summary>
        public string StringHeader { get; set; }

        /// <summary>
        /// Checks to see if the StringHeader property is set.
        /// </summary>
        internal bool IsSetStringHeader() => this.StringHeader != null;

        /// <summary>
        /// Gets and sets the property TimestampHeader.
        /// </summary>
        public DateTime? TimestampHeader { get; set; }

        /// <summary>
        /// Checks to see if the TimestampHeader property is set.
        /// </summary>
        internal bool IsSetTimestampHeader() => this.TimestampHeader.HasValue;
    }
}
