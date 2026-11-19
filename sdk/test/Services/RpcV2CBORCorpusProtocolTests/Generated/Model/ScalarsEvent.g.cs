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

namespace Amazon.RpcV2CBORCorpusProtocolTests.Model
{
    /// <summary>
    /// </summary>
    public partial class ScalarsEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property BigDecimalMember.
        /// </summary>
        public Amazon.Extensions.Numerics.BigDecimal? BigDecimalMember { get; set; }

        /// <summary>
        /// Checks to see if the BigDecimalMember property is set.
        /// </summary>
        internal bool IsSetBigDecimalMember() => this.BigDecimalMember.HasValue;

        /// <summary>
        /// Gets and sets the property BigIntegerMember.
        /// </summary>
        public System.Numerics.BigInteger? BigIntegerMember { get; set; }

        /// <summary>
        /// Checks to see if the BigIntegerMember property is set.
        /// </summary>
        internal bool IsSetBigIntegerMember() => this.BigIntegerMember.HasValue;

        /// <summary>
        /// Gets and sets the property BlobMember.
        /// </summary>
        public MemoryStream BlobMember { get; set; }

        /// <summary>
        /// Checks to see if the BlobMember property is set.
        /// </summary>
        internal bool IsSetBlobMember() => this.BlobMember != null;

        /// <summary>
        /// Gets and sets the property BooleanMember.
        /// </summary>
        public bool? BooleanMember { get; set; }

        /// <summary>
        /// Checks to see if the BooleanMember property is set.
        /// </summary>
        internal bool IsSetBooleanMember() => this.BooleanMember.HasValue;

        /// <summary>
        /// Gets and sets the property ByteMember.
        /// </summary>
        public sbyte? ByteMember { get; set; }

        /// <summary>
        /// Checks to see if the ByteMember property is set.
        /// </summary>
        internal bool IsSetByteMember() => this.ByteMember.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleMember.
        /// </summary>
        public double? DoubleMember { get; set; }

        /// <summary>
        /// Checks to see if the DoubleMember property is set.
        /// </summary>
        internal bool IsSetDoubleMember() => this.DoubleMember.HasValue;

        /// <summary>
        /// Gets and sets the property FloatMember.
        /// </summary>
        public float? FloatMember { get; set; }

        /// <summary>
        /// Checks to see if the FloatMember property is set.
        /// </summary>
        internal bool IsSetFloatMember() => this.FloatMember.HasValue;

        /// <summary>
        /// Gets and sets the property IntEnum.
        /// </summary>
        public int? IntEnum { get; set; }

        /// <summary>
        /// Checks to see if the IntEnum property is set.
        /// </summary>
        internal bool IsSetIntEnum() => this.IntEnum.HasValue;

        /// <summary>
        /// Gets and sets the property IntegerMember.
        /// </summary>
        public int? IntegerMember { get; set; }

        /// <summary>
        /// Checks to see if the IntegerMember property is set.
        /// </summary>
        internal bool IsSetIntegerMember() => this.IntegerMember.HasValue;

        /// <summary>
        /// Gets and sets the property LongMember.
        /// </summary>
        public long? LongMember { get; set; }

        /// <summary>
        /// Checks to see if the LongMember property is set.
        /// </summary>
        internal bool IsSetLongMember() => this.LongMember.HasValue;

        /// <summary>
        /// Gets and sets the property ShortMember.
        /// </summary>
        public short? ShortMember { get; set; }

        /// <summary>
        /// Checks to see if the ShortMember property is set.
        /// </summary>
        internal bool IsSetShortMember() => this.ShortMember.HasValue;

        /// <summary>
        /// Gets and sets the property StringEnum.
        /// </summary>
        public CorpusStringEnum StringEnum { get; set; }

        /// <summary>
        /// Checks to see if the StringEnum property is set.
        /// </summary>
        internal bool IsSetStringEnum() => this.StringEnum != null;

        /// <summary>
        /// Gets and sets the property StringMember.
        /// </summary>
        public string StringMember { get; set; }

        /// <summary>
        /// Checks to see if the StringMember property is set.
        /// </summary>
        internal bool IsSetStringMember() => this.StringMember != null;

        /// <summary>
        /// Gets and sets the property TimestampMember.
        /// </summary>
        public DateTime? TimestampMember { get; set; }

        /// <summary>
        /// Checks to see if the TimestampMember property is set.
        /// </summary>
        internal bool IsSetTimestampMember() => this.TimestampMember.HasValue;
    }
}
