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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
        private int? _classBTimeout;
        private int? _classCTimeout;
        private List<int> _factoryPresetFreqsList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _macVersion;
        private int? _maxDutyCycle;
        private int? _maxEirp;
        private int? _pingSlotDr;
        private int? _pingSlotFreq;
        private int? _pingSlotPeriod;
        private string _regParamsRevision;
        private string _rfRegion;
        private int? _rxDataRate2;
        private int? _rxDelay1;
        private int? _rxDrOffset1;
        private int? _rxFreq2;
        private bool? _supports32BitFCnt;
        private bool? _supportsClassB;
        private bool? _supportsClassC;
        private bool? _supportsJoin;

        /// <summary>
        /// Gets and sets the property ClassBTimeout. 
        /// <para>
        /// The ClassBTimeout value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? ClassBTimeout
        {
            get { return this._classBTimeout; }
            set { this._classBTimeout = value; }
        }

        // Check to see if ClassBTimeout property is set
        internal bool IsSetClassBTimeout()
        {
            return this._classBTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClassCTimeout. 
        /// <para>
        /// The ClassCTimeout value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? ClassCTimeout
        {
            get { return this._classCTimeout; }
            set { this._classCTimeout = value; }
        }

        // Check to see if ClassCTimeout property is set
        internal bool IsSetClassCTimeout()
        {
            return this._classCTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FactoryPresetFreqsList. 
        /// <para>
        /// The list of values that make up the FactoryPresetFreqs value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<int> FactoryPresetFreqsList
        {
            get { return this._factoryPresetFreqsList; }
            set { this._factoryPresetFreqsList = value; }
        }

        // Check to see if FactoryPresetFreqsList property is set
        internal bool IsSetFactoryPresetFreqsList()
        {
            return this._factoryPresetFreqsList != null && (this._factoryPresetFreqsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MacVersion. 
        /// <para>
        /// The MAC version (such as OTAA 1.1 or OTAA 1.0.3) to use with this device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string MacVersion
        {
            get { return this._macVersion; }
            set { this._macVersion = value; }
        }

        // Check to see if MacVersion property is set
        internal bool IsSetMacVersion()
        {
            return this._macVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDutyCycle. 
        /// <para>
        /// The MaxDutyCycle value. It ranges from 0 to 15.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxDutyCycle
        {
            get { return this._maxDutyCycle; }
            set { this._maxDutyCycle = value; }
        }

        // Check to see if MaxDutyCycle property is set
        internal bool IsSetMaxDutyCycle()
        {
            return this._maxDutyCycle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxEirp. 
        /// <para>
        /// The MaxEIRP value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? MaxEirp
        {
            get { return this._maxEirp; }
            set { this._maxEirp = value; }
        }

        // Check to see if MaxEirp property is set
        internal bool IsSetMaxEirp()
        {
            return this._maxEirp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PingSlotDr. 
        /// <para>
        /// The PingSlotDR value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? PingSlotDr
        {
            get { return this._pingSlotDr; }
            set { this._pingSlotDr = value; }
        }

        // Check to see if PingSlotDr property is set
        internal bool IsSetPingSlotDr()
        {
            return this._pingSlotDr.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PingSlotFreq. 
        /// <para>
        /// The PingSlotFreq value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1000000, Max=16700000)]
        public int? PingSlotFreq
        {
            get { return this._pingSlotFreq; }
            set { this._pingSlotFreq = value; }
        }

        // Check to see if PingSlotFreq property is set
        internal bool IsSetPingSlotFreq()
        {
            return this._pingSlotFreq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PingSlotPeriod. 
        /// <para>
        /// The PingSlotPeriod value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=4096)]
        public int? PingSlotPeriod
        {
            get { return this._pingSlotPeriod; }
            set { this._pingSlotPeriod = value; }
        }

        // Check to see if PingSlotPeriod property is set
        internal bool IsSetPingSlotPeriod()
        {
            return this._pingSlotPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegParamsRevision. 
        /// <para>
        /// The version of regional parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RegParamsRevision
        {
            get { return this._regParamsRevision; }
            set { this._regParamsRevision = value; }
        }

        // Check to see if RegParamsRevision property is set
        internal bool IsSetRegParamsRevision()
        {
            return this._regParamsRevision != null;
        }

        /// <summary>
        /// Gets and sets the property RfRegion. 
        /// <para>
        /// The frequency band (RFRegion) value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RxDataRate2. 
        /// <para>
        /// The RXDataRate2 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? RxDataRate2
        {
            get { return this._rxDataRate2; }
            set { this._rxDataRate2 = value; }
        }

        // Check to see if RxDataRate2 property is set
        internal bool IsSetRxDataRate2()
        {
            return this._rxDataRate2.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RxDelay1. 
        /// <para>
        /// The RXDelay1 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? RxDelay1
        {
            get { return this._rxDelay1; }
            set { this._rxDelay1 = value; }
        }

        // Check to see if RxDelay1 property is set
        internal bool IsSetRxDelay1()
        {
            return this._rxDelay1.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RxDrOffset1. 
        /// <para>
        /// The RXDROffset1 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int? RxDrOffset1
        {
            get { return this._rxDrOffset1; }
            set { this._rxDrOffset1 = value; }
        }

        // Check to see if RxDrOffset1 property is set
        internal bool IsSetRxDrOffset1()
        {
            return this._rxDrOffset1.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RxFreq2. 
        /// <para>
        /// The RXFreq2 value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1000000, Max=16700000)]
        public int? RxFreq2
        {
            get { return this._rxFreq2; }
            set { this._rxFreq2 = value; }
        }

        // Check to see if RxFreq2 property is set
        internal bool IsSetRxFreq2()
        {
            return this._rxFreq2.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Supports32BitFCnt. 
        /// <para>
        /// The Supports32BitFCnt value.
        /// </para>
        /// </summary>
        public bool? Supports32BitFCnt
        {
            get { return this._supports32BitFCnt; }
            set { this._supports32BitFCnt = value; }
        }

        // Check to see if Supports32BitFCnt property is set
        internal bool IsSetSupports32BitFCnt()
        {
            return this._supports32BitFCnt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsClassB. 
        /// <para>
        /// The SupportsClassB value.
        /// </para>
        /// </summary>
        public bool? SupportsClassB
        {
            get { return this._supportsClassB; }
            set { this._supportsClassB = value; }
        }

        // Check to see if SupportsClassB property is set
        internal bool IsSetSupportsClassB()
        {
            return this._supportsClassB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsClassC. 
        /// <para>
        /// The SupportsClassC value.
        /// </para>
        /// </summary>
        public bool? SupportsClassC
        {
            get { return this._supportsClassC; }
            set { this._supportsClassC = value; }
        }

        // Check to see if SupportsClassC property is set
        internal bool IsSetSupportsClassC()
        {
            return this._supportsClassC.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsJoin. 
        /// <para>
        /// The SupportsJoin value.
        /// </para>
        /// </summary>
        public bool? SupportsJoin
        {
            get { return this._supportsJoin; }
            set { this._supportsJoin = value; }
        }

        // Check to see if SupportsJoin property is set
        internal bool IsSetSupportsJoin()
        {
            return this._supportsJoin.HasValue; 
        }

    }
}