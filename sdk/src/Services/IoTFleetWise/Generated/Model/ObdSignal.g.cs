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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about signal messages using the on-board diagnostics (OBD) II protocol
    /// in a vehicle.
    /// </summary>
    public partial class ObdSignal
    {
        /// <summary>
        /// Gets and sets the property BitMaskLength. 
        /// <para>
        /// The number of bits to mask in a message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public int? BitMaskLength { get; set; }

        /// <summary>
        /// Checks to see if the BitMaskLength property is set.
        /// </summary>
        internal bool IsSetBitMaskLength() => this.BitMaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property BitRightShift. 
        /// <para>
        /// The number of positions to shift bits in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? BitRightShift { get; set; }

        /// <summary>
        /// Checks to see if the BitRightShift property is set.
        /// </summary>
        internal bool IsSetBitRightShift() => this.BitRightShift.HasValue;

        /// <summary>
        /// Gets and sets the property ByteLength. 
        /// <para>
        /// The length of a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public int? ByteLength { get; set; }

        /// <summary>
        /// Checks to see if the ByteLength property is set.
        /// </summary>
        internal bool IsSetByteLength() => this.ByteLength.HasValue;

        /// <summary>
        /// Gets and sets the property IsSigned. 
        /// <para>
        /// Determines whether the message is signed (<c>true</c>) or not (<c>false</c>). If it's
        /// signed, the message can represent both positive and negative numbers. The <c>isSigned</c>
        /// parameter only applies to the <c>INTEGER</c> raw signal type, and it doesn't affect
        /// the <c>FLOATING_POINT</c> raw signal type. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IsSigned { get; set; }

        /// <summary>
        /// Checks to see if the IsSigned property is set.
        /// </summary>
        internal bool IsSetIsSigned() => this.IsSigned.HasValue;

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset used to calculate the signal value. Combined with scaling, the calculation
        /// is <c>value = raw_value * scaling + offset</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Offset { get; set; }

        /// <summary>
        /// Checks to see if the Offset property is set.
        /// </summary>
        internal bool IsSetOffset() => this.Offset.HasValue;

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        /// The diagnostic code used to request data from a vehicle for this signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;

        /// <summary>
        /// Gets and sets the property PidResponseLength. 
        /// <para>
        /// The length of the requested data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2147483647)]
        public int? PidResponseLength { get; set; }

        /// <summary>
        /// Checks to see if the PidResponseLength property is set.
        /// </summary>
        internal bool IsSetPidResponseLength() => this.PidResponseLength.HasValue;

        /// <summary>
        /// Gets and sets the property Scaling. 
        /// <para>
        /// A multiplier used to decode the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Scaling { get; set; }

        /// <summary>
        /// Checks to see if the Scaling property is set.
        /// </summary>
        internal bool IsSetScaling() => this.Scaling.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceMode. 
        /// <para>
        /// The mode of operation (diagnostic service) in a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? ServiceMode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceMode property is set.
        /// </summary>
        internal bool IsSetServiceMode() => this.ServiceMode.HasValue;

        /// <summary>
        /// Gets and sets the property SignalValueType. 
        /// <para>
        /// The value type of the signal. The default value is <c>INTEGER</c>.
        /// </para>
        /// </summary>
        public SignalValueType SignalValueType { get; set; }

        /// <summary>
        /// Checks to see if the SignalValueType property is set.
        /// </summary>
        internal bool IsSetSignalValueType() => this.SignalValueType != null;

        /// <summary>
        /// Gets and sets the property StartByte. 
        /// <para>
        /// Indicates the beginning of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? StartByte { get; set; }

        /// <summary>
        /// Checks to see if the StartByte property is set.
        /// </summary>
        internal bool IsSetStartByte() => this.StartByte.HasValue;
    }
}
