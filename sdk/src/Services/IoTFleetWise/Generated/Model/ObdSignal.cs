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
    /// Information about signal messages using the on-board diagnostics (OBD) II protocol
    /// in a vehicle.
    /// </summary>
    public partial class ObdSignal
    {
        private int? _bitMaskLength;
        private int? _bitRightShift;
        private int? _byteLength;
        private bool? _isSigned;
        private double? _offset;
        private int? _pid;
        private int? _pidResponseLength;
        private double? _scaling;
        private int? _serviceMode;
        private SignalValueType _signalValueType;
        private int? _startByte;

        /// <summary>
        /// Gets and sets the property BitMaskLength. 
        /// <para>
        /// The number of bits to mask in a message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public int? BitMaskLength
        {
            get { return this._bitMaskLength; }
            set { this._bitMaskLength = value; }
        }

        // Check to see if BitMaskLength property is set
        internal bool IsSetBitMaskLength()
        {
            return this._bitMaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BitRightShift. 
        /// <para>
        /// The number of positions to shift bits in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? BitRightShift
        {
            get { return this._bitRightShift; }
            set { this._bitRightShift = value; }
        }

        // Check to see if BitRightShift property is set
        internal bool IsSetBitRightShift()
        {
            return this._bitRightShift.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByteLength. 
        /// <para>
        /// The length of a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public int? ByteLength
        {
            get { return this._byteLength; }
            set { this._byteLength = value; }
        }

        // Check to see if ByteLength property is set
        internal bool IsSetByteLength()
        {
            return this._byteLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSigned. 
        /// <para>
        /// Determines whether the message is signed (<c>true</c>) or not (<c>false</c>). If it's
        /// signed, the message can represent both positive and negative numbers. The <c>isSigned</c>
        /// parameter only applies to the <c>INTEGER</c> raw signal type, and it doesn't affect
        /// the <c>FLOATING_POINT</c> raw signal type. The default value is <c>false</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with scaling, the calculation
        /// is <c>value = raw_value * scaling + offset</c>.
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
        /// Gets and sets the property Pid. 
        /// <para>
        /// The diagnostic code used to request data from a vehicle for this signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PidResponseLength. 
        /// <para>
        /// The length of the requested data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2147483647)]
        public int? PidResponseLength
        {
            get { return this._pidResponseLength; }
            set { this._pidResponseLength = value; }
        }

        // Check to see if PidResponseLength property is set
        internal bool IsSetPidResponseLength()
        {
            return this._pidResponseLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// A multiplier used to decode the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Scaling
        {
            get { return this._scaling; }
            set { this._scaling = value; }
        }

        // Check to see if Scaling property is set
        internal bool IsSetScaling()
        {
            return this._scaling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceMode. 
        /// <para>
        /// The mode of operation (diagnostic service) in a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? ServiceMode
        {
            get { return this._serviceMode; }
            set { this._serviceMode = value; }
        }

        // Check to see if ServiceMode property is set
        internal bool IsSetServiceMode()
        {
            return this._serviceMode.HasValue; 
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
        /// Gets and sets the property StartByte. 
        /// <para>
        /// Indicates the beginning of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? StartByte
        {
            get { return this._startByte; }
            set { this._startByte = value; }
        }

        // Check to see if StartByte property is set
        internal bool IsSetStartByte()
        {
            return this._startByte.HasValue; 
        }

    }
}