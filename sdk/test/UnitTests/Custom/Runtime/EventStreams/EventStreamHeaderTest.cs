/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Regression coverage for event-stream header length validation. These tests guard against
    /// the encoder silently truncating an oversized length into the protocol's 16-bit (value) or
    /// 8-bit (name) length field, which would let overflow bytes be reparsed as additional headers.
    /// String/byte-array values are capped at INT16_MAX (32,767) encoded bytes.
    /// </summary>
    [TestClass]
    public class EventStreamHeaderTest
    {
        private const int MaxNameLength = 255;
        private const int MaxValueLength = short.MaxValue; // 32,767

        private static byte[] WriteHeader(EventStreamHeader header)
        {
            var buffer = new byte[header.GetWireSize()];
            var offset = header.WriteToBuffer(buffer, 0);
            Assert.AreEqual(buffer.Length, offset, "WriteToBuffer should consume exactly GetWireSize() bytes.");
            return buffer;
        }

        private static EventStreamHeader RoundTrip(EventStreamHeader header)
        {
            var buffer = WriteHeader(header);
            var newOffset = 0;
            return EventStreamHeader.FromBuffer(buffer, 0, ref newOffset);
        }

        // ---- Header names: 255 valid, 256 rejected ----

        [TestMethod]
        public void Name255Bytes_Succeeds()
        {
            var header = new EventStreamHeader(new string('a', MaxNameLength));
            header.SetBool(true);
            var decoded = RoundTrip(header);
            Assert.AreEqual(header.Name, decoded.Name);
        }

        [TestMethod]
        public void Name256Bytes_Throws()
        {
            var header = new EventStreamHeader(new string('a', MaxNameLength + 1));
            header.SetBool(true);
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[1024], 0));
        }

        // ---- String values: 32,767 valid; 32,768 and 65,536 rejected ----

        [TestMethod]
        public void String32767Bytes_RoundTrips()
        {
            var header = new EventStreamHeader("n");
            header.SetString(new string('a', MaxValueLength));
            var decoded = RoundTrip(header);
            Assert.AreEqual(MaxValueLength, decoded.AsString().Length);
            Assert.AreEqual(header.AsString(), decoded.AsString());
        }

        [TestMethod]
        public void String32768Bytes_Throws()
        {
            var header = new EventStreamHeader("n");
            header.SetString(new string('a', MaxValueLength + 1));
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[70000], 0));
        }

        [TestMethod]
        public void String65536Bytes_Throws()
        {
            // The pre-fix truncation point: 65,536 would have encoded a length of zero.
            var header = new EventStreamHeader("n");
            header.SetString(new string('a', 65536));
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[70000], 0));
        }

        // ---- Byte-array values: 32,767 valid; 32,768 and 65,536 rejected ----

        [TestMethod]
        public void ByteBuf32767Bytes_RoundTrips()
        {
            var header = new EventStreamHeader("n");
            header.SetByteBuf(new byte[MaxValueLength]);
            var decoded = RoundTrip(header);
            Assert.AreEqual(MaxValueLength, decoded.AsByteBuf().Length);
        }

        [TestMethod]
        public void ByteBuf32768Bytes_Throws()
        {
            var header = new EventStreamHeader("n");
            header.SetByteBuf(new byte[MaxValueLength + 1]);
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[70000], 0));
        }

        [TestMethod]
        public void ByteBuf65536Bytes_Throws()
        {
            var header = new EventStreamHeader("n");
            header.SetByteBuf(new byte[65536]);
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[70000], 0));
        }

        // ---- Multibyte: char count in range, but encoded byte length over the limit ----

        [TestMethod]
        public void MultibyteStringWithinCharsButOverBytes_Throws()
        {
            // 'ñ' (U+00F1) encodes to 2 UTF-8 bytes. 16,384 chars = 32,768 bytes > 32,767,
            // while the char count (16,384) is well under the limit.
            var header = new EventStreamHeader("n");
            header.SetString(new string('ñ', 16384));
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[70000], 0));
        }

        [TestMethod]
        public void MultibyteNameWithinCharsButOverBytes_Throws()
        {
            // 128 chars of a 2-byte character = 256 bytes > 255.
            var header = new EventStreamHeader(new string('ñ', 128));
            header.SetBool(true);
            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(new byte[1024], 0));
        }

        // ---- Failure atomicity: a rejected header writes nothing ----

        [TestMethod]
        public void OversizedValue_LeavesBufferUntouched()
        {
            var header = new EventStreamHeader("n");
            header.SetString(new string('a', MaxValueLength + 1));

            var buffer = new byte[70000];
            for (var i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0xFF;
            }

            Assert.ThrowsExactly<EventStreamParseException>(() => header.WriteToBuffer(buffer, 0));
            Assert.IsTrue(buffer.All(b => b == 0xFF), "No bytes should be written when validation fails.");
        }

        // ---- Fixed-width and round-trip coverage for every supported header type ----

        [TestMethod]
        public void AllHeaderTypes_RoundTrip()
        {
            var sbyteHeader = new EventStreamHeader("n");
            sbyteHeader.SetSByte(sbyte.MinValue);
            Assert.AreEqual(sbyte.MinValue, RoundTrip(sbyteHeader).AsSByte());

            var int16Header = new EventStreamHeader("n");
            int16Header.SetInt16(short.MinValue);
            Assert.AreEqual(short.MinValue, RoundTrip(int16Header).AsInt16());

            var int32Header = new EventStreamHeader("n");
            int32Header.SetInt32(int.MinValue);
            Assert.AreEqual(int.MinValue, RoundTrip(int32Header).AsInt32());

            var int64Header = new EventStreamHeader("n");
            int64Header.SetInt64(long.MinValue);
            Assert.AreEqual(long.MinValue, RoundTrip(int64Header).AsInt64());

            var doubleHeader = new EventStreamHeader("n");
            doubleHeader.SetDouble(Math.PI);
            Assert.AreEqual(Math.PI, RoundTrip(doubleHeader).AsDouble());

            var boolTrue = new EventStreamHeader("n");
            boolTrue.SetBool(true);
            Assert.IsTrue(RoundTrip(boolTrue).AsBool());

            var boolFalse = new EventStreamHeader("n");
            boolFalse.SetBool(false);
            Assert.IsFalse(RoundTrip(boolFalse).AsBool());

            var timestampHeader = new EventStreamHeader("n");
            var timestamp = new DateTime(2026, 10, 6, 1, 2, 3, DateTimeKind.Utc);
            timestampHeader.SetTimestamp(timestamp);
            Assert.AreEqual(timestamp, RoundTrip(timestampHeader).AsTimestamp());

            var uuidHeader = new EventStreamHeader("n");
            var uuid = Guid.NewGuid();
            uuidHeader.SetUUID(uuid);
            Assert.AreEqual(uuid, RoundTrip(uuidHeader).AsUUID());
        }

        [TestMethod]
        public void UuidHeader_AlwaysOccupiesExactly16ValueBytes()
        {
            // Guid.ToByteArray is always 16 bytes, so the fixed-width UUID value cannot
            // misalign the header block. 1 byte name length + 1 name + 1 type + 16 value.
            var header = new EventStreamHeader("n");
            header.SetUUID(Guid.NewGuid());
            Assert.AreEqual(19, header.GetWireSize());
            Assert.AreEqual(19, WriteHeader(header).Length);
        }

        // ---- A forged-header input cannot produce a transmissible frame ----

        [TestMethod]
        public void OversizedHeaderValue_CannotSerializeMessage()
        {
            var header = new EventStreamHeader("DataType");
            header.SetString(new string('a', 65536));
            var message = new EventStreamMessage(new List<IEventStreamHeader> { header }, new byte[0]);
            Assert.ThrowsExactly<EventStreamParseException>(() => message.ToByteArray());
        }
    }
}
