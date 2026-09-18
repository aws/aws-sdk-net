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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HeadersEvent
        : IEventStreamEvent
    {
        private MemoryStream _blobHeader;
        private bool? _booleanHeader;
        private int? _byteHeader;
        private int? _intHeader;
        private long? _longHeader;
        private int? _shortHeader;
        private string _stringHeader;
        private DateTime? _timestampHeader;

        /// <summary>
        /// Gets and sets the property BlobHeader.
        /// </summary>
        public MemoryStream BlobHeader
        {
            get { return this._blobHeader; }
            set { this._blobHeader = value; }
        }

        // Check to see if BlobHeader property is set
        internal bool IsSetBlobHeader()
        {
            return this._blobHeader != null;
        }

        /// <summary>
        /// Gets and sets the property BooleanHeader.
        /// </summary>
        public bool? BooleanHeader
        {
            get { return this._booleanHeader; }
            set { this._booleanHeader = value; }
        }

        // Check to see if BooleanHeader property is set
        internal bool IsSetBooleanHeader()
        {
            return this._booleanHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByteHeader.
        /// </summary>
        public int? ByteHeader
        {
            get { return this._byteHeader; }
            set { this._byteHeader = value; }
        }

        // Check to see if ByteHeader property is set
        internal bool IsSetByteHeader()
        {
            return this._byteHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntHeader.
        /// </summary>
        public int? IntHeader
        {
            get { return this._intHeader; }
            set { this._intHeader = value; }
        }

        // Check to see if IntHeader property is set
        internal bool IsSetIntHeader()
        {
            return this._intHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongHeader.
        /// </summary>
        public long? LongHeader
        {
            get { return this._longHeader; }
            set { this._longHeader = value; }
        }

        // Check to see if LongHeader property is set
        internal bool IsSetLongHeader()
        {
            return this._longHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShortHeader.
        /// </summary>
        public int? ShortHeader
        {
            get { return this._shortHeader; }
            set { this._shortHeader = value; }
        }

        // Check to see if ShortHeader property is set
        internal bool IsSetShortHeader()
        {
            return this._shortHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringHeader.
        /// </summary>
        public string StringHeader
        {
            get { return this._stringHeader; }
            set { this._stringHeader = value; }
        }

        // Check to see if StringHeader property is set
        internal bool IsSetStringHeader()
        {
            return this._stringHeader != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampHeader.
        /// </summary>
        public DateTime? TimestampHeader
        {
            get { return this._timestampHeader; }
            set { this._timestampHeader = value; }
        }

        // Check to see if TimestampHeader property is set
        internal bool IsSetTimestampHeader()
        {
            return this._timestampHeader.HasValue; 
        }

    }
}