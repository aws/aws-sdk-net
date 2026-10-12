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
    /// Information about a signal decoder.
    /// </summary>
    public partial class SignalDecoder
    {
        /// <summary>
        /// Gets and sets the property CanSignal. 
        /// <para>
        /// Information about signal decoder using the Controller Area Network (CAN) protocol.
        /// </para>
        /// </summary>
        public CanSignal CanSignal { get; set; }

        /// <summary>
        /// Checks to see if the CanSignal property is set.
        /// </summary>
        internal bool IsSetCanSignal() => this.CanSignal != null;

        /// <summary>
        /// Gets and sets the property CustomDecodingSignal. 
        /// <para>
        /// Information about a <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_CustomDecodingSignal.html">custom
        /// signal decoder</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
        /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
        /// FleetWise Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public CustomDecodingSignal CustomDecodingSignal { get; set; }

        /// <summary>
        /// Checks to see if the CustomDecodingSignal property is set.
        /// </summary>
        internal bool IsSetCustomDecodingSignal() => this.CustomDecodingSignal != null;

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of a signal decoder as defined in a vehicle model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the FullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetFullyQualifiedName() => this.FullyQualifiedName != null;

        /// <summary>
        /// Gets and sets the property InterfaceId. 
        /// <para>
        /// The ID of a network interface that specifies what network protocol a vehicle follows.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string InterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceId property is set.
        /// </summary>
        internal bool IsSetInterfaceId() => this.InterfaceId != null;

        /// <summary>
        /// Gets and sets the property MessageSignal. 
        /// <para>
        /// The decoding information for a specific message which supports higher order data types.
        /// 
        /// </para>
        /// </summary>
        public MessageSignal MessageSignal { get; set; }

        /// <summary>
        /// Checks to see if the MessageSignal property is set.
        /// </summary>
        internal bool IsSetMessageSignal() => this.MessageSignal != null;

        /// <summary>
        /// Gets and sets the property ObdSignal. 
        /// <para>
        /// Information about signal decoder using the on-board diagnostic (OBD) II protocol.
        /// </para>
        /// </summary>
        public ObdSignal ObdSignal { get; set; }

        /// <summary>
        /// Checks to see if the ObdSignal property is set.
        /// </summary>
        internal bool IsSetObdSignal() => this.ObdSignal != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The network protocol for the vehicle. For example, <c>CAN_SIGNAL</c> specifies a protocol
        /// that defines how data is communicated between electronic control units (ECUs). <c>OBD_SIGNAL</c>
        /// specifies a protocol that defines how self-diagnostic data is communicated between
        /// ECUs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SignalDecoderType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
