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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a single controller area network (CAN) signal and the messages it
    /// receives and transmits.
    /// </summary>
    public partial class CanSignal
    {
        private double? _factor;
        private bool? _isBigEndian;
        private bool? _isSigned;
        private int? _length;
        private int? _messageId;
        private string _name;
        private double? _offset;
        private SignalValueType _signalValueType;
        private int? _startBit;

        /// <summary>
        /// Gets and sets the property Factor. 
        /// <para>
        /// A multiplier used to decode the CAN message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Factor
        {
            get { return this._factor; }
            set { this._factor = value; }
        }

        // Check to see if Factor property is set
        internal bool IsSetFactor()
        {
            return this._factor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsBigEndian. 
        /// <para>
        /// Whether the byte ordering of a CAN message is big-endian.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsBigEndian
        {
            get { return this._isBigEndian; }
            set { this._isBigEndian = value; }
        }

        // Check to see if IsBigEndian property is set
        internal bool IsSetIsBigEndian()
        {
            return this._isBigEndian.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSigned. 
        /// <para>
        /// Determines whether the message is signed (<c>true</c>) or not (<c>false</c>). If it's
        /// signed, the message can represent both positive and negative numbers. The <c>isSigned</c>
        /// parameter only applies to the <c>INTEGER</c> raw signal type, and it doesn't affect
        /// the <c>FLOATING_POINT</c> raw signal type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsSigned
        {
            get { return this._isSigned; }
            set { this._isSigned = value; }
        }

        // Check to see if IsSigned property is set
        internal bool IsSetIsSigned()
        {
            return this._isSigned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// How many bytes of data are in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with factor, the calculation
        /// is <c>value = raw_value * factor + offset</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignalValueType. 
        /// <para>
        /// The value type of the signal. The default value is <c>INTEGER</c>.
        /// </para>
        /// </summary>
        public SignalValueType SignalValueType
        {
            get { return this._signalValueType; }
            set { this._signalValueType = value; }
        }

        // Check to see if SignalValueType property is set
        internal bool IsSetSignalValueType()
        {
            return this._signalValueType != null;
        }

        /// <summary>
        /// Gets and sets the property StartBit. 
        /// <para>
        /// Indicates the beginning of the CAN signal. This should always be the least significant
        /// bit (LSB).
        /// </para>
        ///  
        /// <para>
        /// This value might be different from the value in a DBC file. For little endian signals,
        /// <c>startBit</c> is the same value as in the DBC file. For big endian signals in a
        /// DBC file, the start bit is the most significant bit (MSB). You will have to calculate
        /// the LSB instead and pass it as the <c>startBit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? StartBit
        {
            get { return this._startBit; }
            set { this._startBit = value; }
        }

        // Check to see if StartBit property is set
        internal bool IsSetStartBit()
        {
            return this._startBit.HasValue; 
        }

    }
}