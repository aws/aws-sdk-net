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
        private double? _offset;
        private int? _pid;
        private int? _pidResponseLength;
        private double? _scaling;
        private int? _serviceMode;
        private int? _startByte;

        /// <summary>
        /// Gets and sets the property BitMaskLength. 
        /// <para>
        /// The number of bits to mask in a message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public int BitMaskLength
        {
            get { return this._bitMaskLength.GetValueOrDefault(); }
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
        [AWSProperty(Min=0)]
        public int BitRightShift
        {
            get { return this._bitRightShift.GetValueOrDefault(); }
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
        public int ByteLength
        {
            get { return this._byteLength.GetValueOrDefault(); }
            set { this._byteLength = value; }
        }

        // Check to see if ByteLength property is set
        internal bool IsSetByteLength()
        {
            return this._byteLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with scaling, the calculation
        /// is <code>value = raw_value * scaling + offset</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double Offset
        {
            get { return this._offset.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Min=0)]
        public int Pid
        {
            get { return this._pid.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Min=1)]
        public int PidResponseLength
        {
            get { return this._pidResponseLength.GetValueOrDefault(); }
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
        public double Scaling
        {
            get { return this._scaling.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Min=0)]
        public int ServiceMode
        {
            get { return this._serviceMode.GetValueOrDefault(); }
            set { this._serviceMode = value; }
        }

        // Check to see if ServiceMode property is set
        internal bool IsSetServiceMode()
        {
            return this._serviceMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartByte. 
        /// <para>
        /// Indicates the beginning of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int StartByte
        {
            get { return this._startByte.GetValueOrDefault(); }
            set { this._startByte = value; }
        }

        // Check to see if StartByte property is set
        internal bool IsSetStartByte()
        {
            return this._startByte.HasValue; 
        }

    }
}