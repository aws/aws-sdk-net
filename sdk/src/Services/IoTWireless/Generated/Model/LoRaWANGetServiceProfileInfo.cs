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
    /// LoRaWANGetServiceProfileInfo object.
    /// </summary>
    public partial class LoRaWANGetServiceProfileInfo
    {
        private bool? _addGwMetadata;
        private string _channelMask;
        private int? _devStatusReqFreq;
        private int? _dlBucketSize;
        private int? _dlRate;
        private string _dlRatePolicy;
        private int? _drMax;
        private int? _drMin;
        private bool? _hrAllowed;
        private int? _minGwDiversity;
        private int? _nbTransMax;
        private int? _nbTransMin;
        private bool? _nwkGeoLoc;
        private bool? _prAllowed;
        private bool? _raAllowed;
        private bool? _reportDevStatusBattery;
        private bool? _reportDevStatusMargin;
        private int? _targetPer;
        private int? _txPowerIndexMax;
        private int? _txPowerIndexMin;
        private int? _ulBucketSize;
        private int? _ulRate;
        private string _ulRatePolicy;

        /// <summary>
        /// Gets and sets the property AddGwMetadata. 
        /// <para>
        /// The AddGWMetaData value.
        /// </para>
        /// </summary>
        public bool? AddGwMetadata
        {
            get { return this._addGwMetadata; }
            set { this._addGwMetadata = value; }
        }

        // Check to see if AddGwMetadata property is set
        internal bool IsSetAddGwMetadata()
        {
            return this._addGwMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelMask. 
        /// <para>
        /// The ChannelMask value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ChannelMask
        {
            get { return this._channelMask; }
            set { this._channelMask = value; }
        }

        // Check to see if ChannelMask property is set
        internal bool IsSetChannelMask()
        {
            return this._channelMask != null;
        }

        /// <summary>
        /// Gets and sets the property DevStatusReqFreq. 
        /// <para>
        /// The DevStatusReqFreq value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? DevStatusReqFreq
        {
            get { return this._devStatusReqFreq; }
            set { this._devStatusReqFreq = value; }
        }

        // Check to see if DevStatusReqFreq property is set
        internal bool IsSetDevStatusReqFreq()
        {
            return this._devStatusReqFreq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DlBucketSize. 
        /// <para>
        /// The DLBucketSize value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? DlBucketSize
        {
            get { return this._dlBucketSize; }
            set { this._dlBucketSize = value; }
        }

        // Check to see if DlBucketSize property is set
        internal bool IsSetDlBucketSize()
        {
            return this._dlBucketSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DlRate. 
        /// <para>
        /// The DLRate value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? DlRate
        {
            get { return this._dlRate; }
            set { this._dlRate = value; }
        }

        // Check to see if DlRate property is set
        internal bool IsSetDlRate()
        {
            return this._dlRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DlRatePolicy. 
        /// <para>
        /// The DLRatePolicy value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DlRatePolicy
        {
            get { return this._dlRatePolicy; }
            set { this._dlRatePolicy = value; }
        }

        // Check to see if DlRatePolicy property is set
        internal bool IsSetDlRatePolicy()
        {
            return this._dlRatePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DrMax. 
        /// <para>
        /// The DRMax value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? DrMax
        {
            get { return this._drMax; }
            set { this._drMax = value; }
        }

        // Check to see if DrMax property is set
        internal bool IsSetDrMax()
        {
            return this._drMax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DrMin. 
        /// <para>
        /// The DRMin value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? DrMin
        {
            get { return this._drMin; }
            set { this._drMin = value; }
        }

        // Check to see if DrMin property is set
        internal bool IsSetDrMin()
        {
            return this._drMin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrAllowed. 
        /// <para>
        /// The HRAllowed value that describes whether handover roaming is allowed.
        /// </para>
        /// </summary>
        public bool? HrAllowed
        {
            get { return this._hrAllowed; }
            set { this._hrAllowed = value; }
        }

        // Check to see if HrAllowed property is set
        internal bool IsSetHrAllowed()
        {
            return this._hrAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinGwDiversity. 
        /// <para>
        /// The MinGwDiversity value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MinGwDiversity
        {
            get { return this._minGwDiversity; }
            set { this._minGwDiversity = value; }
        }

        // Check to see if MinGwDiversity property is set
        internal bool IsSetMinGwDiversity()
        {
            return this._minGwDiversity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NbTransMax. 
        /// <para>
        /// The maximum number of transmissions.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>3</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? NbTransMax
        {
            get { return this._nbTransMax; }
            set { this._nbTransMax = value; }
        }

        // Check to see if NbTransMax property is set
        internal bool IsSetNbTransMax()
        {
            return this._nbTransMax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NbTransMin. 
        /// <para>
        /// The minimum number of transmissions.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? NbTransMin
        {
            get { return this._nbTransMin; }
            set { this._nbTransMin = value; }
        }

        // Check to see if NbTransMin property is set
        internal bool IsSetNbTransMin()
        {
            return this._nbTransMin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NwkGeoLoc. 
        /// <para>
        /// The NwkGeoLoc value.
        /// </para>
        /// </summary>
        public bool? NwkGeoLoc
        {
            get { return this._nwkGeoLoc; }
            set { this._nwkGeoLoc = value; }
        }

        // Check to see if NwkGeoLoc property is set
        internal bool IsSetNwkGeoLoc()
        {
            return this._nwkGeoLoc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrAllowed. 
        /// <para>
        /// The PRAllowed value that describes whether passive roaming is allowed.
        /// </para>
        /// </summary>
        public bool? PrAllowed
        {
            get { return this._prAllowed; }
            set { this._prAllowed = value; }
        }

        // Check to see if PrAllowed property is set
        internal bool IsSetPrAllowed()
        {
            return this._prAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RaAllowed. 
        /// <para>
        /// The RAAllowed value that describes whether roaming activation is allowed.
        /// </para>
        /// </summary>
        public bool? RaAllowed
        {
            get { return this._raAllowed; }
            set { this._raAllowed = value; }
        }

        // Check to see if RaAllowed property is set
        internal bool IsSetRaAllowed()
        {
            return this._raAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportDevStatusBattery. 
        /// <para>
        /// The ReportDevStatusBattery value.
        /// </para>
        /// </summary>
        public bool? ReportDevStatusBattery
        {
            get { return this._reportDevStatusBattery; }
            set { this._reportDevStatusBattery = value; }
        }

        // Check to see if ReportDevStatusBattery property is set
        internal bool IsSetReportDevStatusBattery()
        {
            return this._reportDevStatusBattery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportDevStatusMargin. 
        /// <para>
        /// The ReportDevStatusMargin value.
        /// </para>
        /// </summary>
        public bool? ReportDevStatusMargin
        {
            get { return this._reportDevStatusMargin; }
            set { this._reportDevStatusMargin = value; }
        }

        // Check to see if ReportDevStatusMargin property is set
        internal bool IsSetReportDevStatusMargin()
        {
            return this._reportDevStatusMargin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetPer. 
        /// <para>
        /// The TargetPER value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? TargetPer
        {
            get { return this._targetPer; }
            set { this._targetPer = value; }
        }

        // Check to see if TargetPer property is set
        internal bool IsSetTargetPer()
        {
            return this._targetPer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TxPowerIndexMax. 
        /// <para>
        /// The Transmit Power Index maximum value.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>15</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? TxPowerIndexMax
        {
            get { return this._txPowerIndexMax; }
            set { this._txPowerIndexMax = value; }
        }

        // Check to see if TxPowerIndexMax property is set
        internal bool IsSetTxPowerIndexMax()
        {
            return this._txPowerIndexMax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TxPowerIndexMin. 
        /// <para>
        /// The Transmit Power Index minimum value.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int? TxPowerIndexMin
        {
            get { return this._txPowerIndexMin; }
            set { this._txPowerIndexMin = value; }
        }

        // Check to see if TxPowerIndexMin property is set
        internal bool IsSetTxPowerIndexMin()
        {
            return this._txPowerIndexMin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UlBucketSize. 
        /// <para>
        /// The ULBucketSize value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? UlBucketSize
        {
            get { return this._ulBucketSize; }
            set { this._ulBucketSize = value; }
        }

        // Check to see if UlBucketSize property is set
        internal bool IsSetUlBucketSize()
        {
            return this._ulBucketSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UlRate. 
        /// <para>
        /// The ULRate value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? UlRate
        {
            get { return this._ulRate; }
            set { this._ulRate = value; }
        }

        // Check to see if UlRate property is set
        internal bool IsSetUlRate()
        {
            return this._ulRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UlRatePolicy. 
        /// <para>
        /// The ULRatePolicy value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string UlRatePolicy
        {
            get { return this._ulRatePolicy; }
            set { this._ulRatePolicy = value; }
        }

        // Check to see if UlRatePolicy property is set
        internal bool IsSetUlRatePolicy()
        {
            return this._ulRatePolicy != null;
        }

    }
}