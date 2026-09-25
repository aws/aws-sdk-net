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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWANDeviceProfile object.
    /// </summary>
    public partial class LoRaWANDeviceProfile
    {
        /// <summary>
        /// Gets and sets the property ClassBTimeout. 
        /// <para>
        /// The ClassBTimeout value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? ClassBTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ClassBTimeout property is set.
        /// </summary>
        internal bool IsSetClassBTimeout() => this.ClassBTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property ClassCTimeout. 
        /// <para>
        /// The ClassCTimeout value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? ClassCTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ClassCTimeout property is set.
        /// </summary>
        internal bool IsSetClassCTimeout() => this.ClassCTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property FactoryPresetFreqsList. 
        /// <para>
        /// The list of values that make up the FactoryPresetFreqs value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<int> FactoryPresetFreqsList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the FactoryPresetFreqsList property is set.
        /// </summary>
        internal bool IsSetFactoryPresetFreqsList() => this.FactoryPresetFreqsList != null && (this.FactoryPresetFreqsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MacVersion. 
        /// <para>
        /// The MAC version (such as OTAA 1.1 or OTAA 1.0.3) to use with this device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string MacVersion { get; set; }

        /// <summary>
        /// Checks to see if the MacVersion property is set.
        /// </summary>
        internal bool IsSetMacVersion() => this.MacVersion != null;

        /// <summary>
        /// Gets and sets the property MaxDutyCycle. 
        /// <para>
        /// The MaxDutyCycle value. It ranges from 0 to 15.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? MaxDutyCycle { get; set; }

        /// <summary>
        /// Checks to see if the MaxDutyCycle property is set.
        /// </summary>
        internal bool IsSetMaxDutyCycle() => this.MaxDutyCycle.HasValue;

        /// <summary>
        /// Gets and sets the property MaxEirp. 
        /// <para>
        /// The MaxEIRP value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? MaxEirp { get; set; }

        /// <summary>
        /// Checks to see if the MaxEirp property is set.
        /// </summary>
        internal bool IsSetMaxEirp() => this.MaxEirp.HasValue;

        /// <summary>
        /// Gets and sets the property PingSlotDr. 
        /// <para>
        /// The PingSlotDR value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? PingSlotDr { get; set; }

        /// <summary>
        /// Checks to see if the PingSlotDr property is set.
        /// </summary>
        internal bool IsSetPingSlotDr() => this.PingSlotDr.HasValue;

        /// <summary>
        /// Gets and sets the property PingSlotFreq. 
        /// <para>
        /// The PingSlotFreq value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1000000, Max = 16700000)]
        public int? PingSlotFreq { get; set; }

        /// <summary>
        /// Checks to see if the PingSlotFreq property is set.
        /// </summary>
        internal bool IsSetPingSlotFreq() => this.PingSlotFreq.HasValue;

        /// <summary>
        /// Gets and sets the property PingSlotPeriod. 
        /// <para>
        /// The PingSlotPeriod value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 4096)]
        public int? PingSlotPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PingSlotPeriod property is set.
        /// </summary>
        internal bool IsSetPingSlotPeriod() => this.PingSlotPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property RegParamsRevision. 
        /// <para>
        /// The version of regional parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RegParamsRevision { get; set; }

        /// <summary>
        /// Checks to see if the RegParamsRevision property is set.
        /// </summary>
        internal bool IsSetRegParamsRevision() => this.RegParamsRevision != null;

        /// <summary>
        /// Gets and sets the property RfRegion. 
        /// <para>
        /// The frequency band (RFRegion) value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RfRegion { get; set; }

        /// <summary>
        /// Checks to see if the RfRegion property is set.
        /// </summary>
        internal bool IsSetRfRegion() => this.RfRegion != null;

        /// <summary>
        /// Gets and sets the property RxDataRate2. 
        /// <para>
        /// The RXDataRate2 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? RxDataRate2 { get; set; }

        /// <summary>
        /// Checks to see if the RxDataRate2 property is set.
        /// </summary>
        internal bool IsSetRxDataRate2() => this.RxDataRate2.HasValue;

        /// <summary>
        /// Gets and sets the property RxDelay1. 
        /// <para>
        /// The RXDelay1 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? RxDelay1 { get; set; }

        /// <summary>
        /// Checks to see if the RxDelay1 property is set.
        /// </summary>
        internal bool IsSetRxDelay1() => this.RxDelay1.HasValue;

        /// <summary>
        /// Gets and sets the property RxDrOffset1. 
        /// <para>
        /// The RXDROffset1 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 7)]
        public int? RxDrOffset1 { get; set; }

        /// <summary>
        /// Checks to see if the RxDrOffset1 property is set.
        /// </summary>
        internal bool IsSetRxDrOffset1() => this.RxDrOffset1.HasValue;

        /// <summary>
        /// Gets and sets the property RxFreq2. 
        /// <para>
        /// The RXFreq2 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1000000, Max = 16700000)]
        public int? RxFreq2 { get; set; }

        /// <summary>
        /// Checks to see if the RxFreq2 property is set.
        /// </summary>
        internal bool IsSetRxFreq2() => this.RxFreq2.HasValue;

        /// <summary>
        /// Gets and sets the property Supports32BitFCnt. 
        /// <para>
        /// The Supports32BitFCnt value.
        /// </para>
        /// </summary>
        public bool? Supports32BitFCnt { get; set; }

        /// <summary>
        /// Checks to see if the Supports32BitFCnt property is set.
        /// </summary>
        internal bool IsSetSupports32BitFCnt() => this.Supports32BitFCnt.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsClassB. 
        /// <para>
        /// The SupportsClassB value.
        /// </para>
        /// </summary>
        public bool? SupportsClassB { get; set; }

        /// <summary>
        /// Checks to see if the SupportsClassB property is set.
        /// </summary>
        internal bool IsSetSupportsClassB() => this.SupportsClassB.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsClassC. 
        /// <para>
        /// The SupportsClassC value.
        /// </para>
        /// </summary>
        public bool? SupportsClassC { get; set; }

        /// <summary>
        /// Checks to see if the SupportsClassC property is set.
        /// </summary>
        internal bool IsSetSupportsClassC() => this.SupportsClassC.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsJoin. 
        /// <para>
        /// The SupportsJoin value.
        /// </para>
        /// </summary>
        public bool? SupportsJoin { get; set; }

        /// <summary>
        /// Checks to see if the SupportsJoin property is set.
        /// </summary>
        internal bool IsSetSupportsJoin() => this.SupportsJoin.HasValue;
    }
}
