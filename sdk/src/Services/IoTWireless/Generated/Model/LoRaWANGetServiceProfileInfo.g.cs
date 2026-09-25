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
    /// LoRaWANGetServiceProfileInfo object.
    /// </summary>
    public partial class LoRaWANGetServiceProfileInfo
    {
        /// <summary>
        /// Gets and sets the property AddGwMetadata. 
        /// <para>
        /// The AddGWMetaData value.
        /// </para>
        /// </summary>
        public bool? AddGwMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AddGwMetadata property is set.
        /// </summary>
        internal bool IsSetAddGwMetadata() => this.AddGwMetadata.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelMask. 
        /// <para>
        /// The ChannelMask value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ChannelMask { get; set; }

        /// <summary>
        /// Checks to see if the ChannelMask property is set.
        /// </summary>
        internal bool IsSetChannelMask() => this.ChannelMask != null;

        /// <summary>
        /// Gets and sets the property DevStatusReqFreq. 
        /// <para>
        /// The DevStatusReqFreq value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? DevStatusReqFreq { get; set; }

        /// <summary>
        /// Checks to see if the DevStatusReqFreq property is set.
        /// </summary>
        internal bool IsSetDevStatusReqFreq() => this.DevStatusReqFreq.HasValue;

        /// <summary>
        /// Gets and sets the property DlBucketSize. 
        /// <para>
        /// The DLBucketSize value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? DlBucketSize { get; set; }

        /// <summary>
        /// Checks to see if the DlBucketSize property is set.
        /// </summary>
        internal bool IsSetDlBucketSize() => this.DlBucketSize.HasValue;

        /// <summary>
        /// Gets and sets the property DlRate. 
        /// <para>
        /// The DLRate value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? DlRate { get; set; }

        /// <summary>
        /// Checks to see if the DlRate property is set.
        /// </summary>
        internal bool IsSetDlRate() => this.DlRate.HasValue;

        /// <summary>
        /// Gets and sets the property DlRatePolicy. 
        /// <para>
        /// The DLRatePolicy value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DlRatePolicy { get; set; }

        /// <summary>
        /// Checks to see if the DlRatePolicy property is set.
        /// </summary>
        internal bool IsSetDlRatePolicy() => this.DlRatePolicy != null;

        /// <summary>
        /// Gets and sets the property DrMax. 
        /// <para>
        /// The DRMax value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? DrMax { get; set; }

        /// <summary>
        /// Checks to see if the DrMax property is set.
        /// </summary>
        internal bool IsSetDrMax() => this.DrMax.HasValue;

        /// <summary>
        /// Gets and sets the property DrMin. 
        /// <para>
        /// The DRMin value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? DrMin { get; set; }

        /// <summary>
        /// Checks to see if the DrMin property is set.
        /// </summary>
        internal bool IsSetDrMin() => this.DrMin.HasValue;

        /// <summary>
        /// Gets and sets the property HrAllowed. 
        /// <para>
        /// The HRAllowed value that describes whether handover roaming is allowed.
        /// </para>
        /// </summary>
        public bool? HrAllowed { get; set; }

        /// <summary>
        /// Checks to see if the HrAllowed property is set.
        /// </summary>
        internal bool IsSetHrAllowed() => this.HrAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property MinGwDiversity. 
        /// <para>
        /// The MinGwDiversity value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MinGwDiversity { get; set; }

        /// <summary>
        /// Checks to see if the MinGwDiversity property is set.
        /// </summary>
        internal bool IsSetMinGwDiversity() => this.MinGwDiversity.HasValue;

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
        [AWSProperty(Min = 0, Max = 15)]
        public int? NbTransMax { get; set; }

        /// <summary>
        /// Checks to see if the NbTransMax property is set.
        /// </summary>
        internal bool IsSetNbTransMax() => this.NbTransMax.HasValue;

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
        [AWSProperty(Min = 0, Max = 15)]
        public int? NbTransMin { get; set; }

        /// <summary>
        /// Checks to see if the NbTransMin property is set.
        /// </summary>
        internal bool IsSetNbTransMin() => this.NbTransMin.HasValue;

        /// <summary>
        /// Gets and sets the property NwkGeoLoc. 
        /// <para>
        /// The NwkGeoLoc value.
        /// </para>
        /// </summary>
        public bool? NwkGeoLoc { get; set; }

        /// <summary>
        /// Checks to see if the NwkGeoLoc property is set.
        /// </summary>
        internal bool IsSetNwkGeoLoc() => this.NwkGeoLoc.HasValue;

        /// <summary>
        /// Gets and sets the property PrAllowed. 
        /// <para>
        /// The PRAllowed value that describes whether passive roaming is allowed.
        /// </para>
        /// </summary>
        public bool? PrAllowed { get; set; }

        /// <summary>
        /// Checks to see if the PrAllowed property is set.
        /// </summary>
        internal bool IsSetPrAllowed() => this.PrAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property RaAllowed. 
        /// <para>
        /// The RAAllowed value that describes whether roaming activation is allowed.
        /// </para>
        /// </summary>
        public bool? RaAllowed { get; set; }

        /// <summary>
        /// Checks to see if the RaAllowed property is set.
        /// </summary>
        internal bool IsSetRaAllowed() => this.RaAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property ReportDevStatusBattery. 
        /// <para>
        /// The ReportDevStatusBattery value.
        /// </para>
        /// </summary>
        public bool? ReportDevStatusBattery { get; set; }

        /// <summary>
        /// Checks to see if the ReportDevStatusBattery property is set.
        /// </summary>
        internal bool IsSetReportDevStatusBattery() => this.ReportDevStatusBattery.HasValue;

        /// <summary>
        /// Gets and sets the property ReportDevStatusMargin. 
        /// <para>
        /// The ReportDevStatusMargin value.
        /// </para>
        /// </summary>
        public bool? ReportDevStatusMargin { get; set; }

        /// <summary>
        /// Checks to see if the ReportDevStatusMargin property is set.
        /// </summary>
        internal bool IsSetReportDevStatusMargin() => this.ReportDevStatusMargin.HasValue;

        /// <summary>
        /// Gets and sets the property TargetPer. 
        /// <para>
        /// The TargetPER value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? TargetPer { get; set; }

        /// <summary>
        /// Checks to see if the TargetPer property is set.
        /// </summary>
        internal bool IsSetTargetPer() => this.TargetPer.HasValue;

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
        [AWSProperty(Min = 0, Max = 15)]
        public int? TxPowerIndexMax { get; set; }

        /// <summary>
        /// Checks to see if the TxPowerIndexMax property is set.
        /// </summary>
        internal bool IsSetTxPowerIndexMax() => this.TxPowerIndexMax.HasValue;

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
        [AWSProperty(Min = 0, Max = 15)]
        public int? TxPowerIndexMin { get; set; }

        /// <summary>
        /// Checks to see if the TxPowerIndexMin property is set.
        /// </summary>
        internal bool IsSetTxPowerIndexMin() => this.TxPowerIndexMin.HasValue;

        /// <summary>
        /// Gets and sets the property UlBucketSize. 
        /// <para>
        /// The ULBucketSize value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? UlBucketSize { get; set; }

        /// <summary>
        /// Checks to see if the UlBucketSize property is set.
        /// </summary>
        internal bool IsSetUlBucketSize() => this.UlBucketSize.HasValue;

        /// <summary>
        /// Gets and sets the property UlRate. 
        /// <para>
        /// The ULRate value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? UlRate { get; set; }

        /// <summary>
        /// Checks to see if the UlRate property is set.
        /// </summary>
        internal bool IsSetUlRate() => this.UlRate.HasValue;

        /// <summary>
        /// Gets and sets the property UlRatePolicy. 
        /// <para>
        /// The ULRatePolicy value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string UlRatePolicy { get; set; }

        /// <summary>
        /// Checks to see if the UlRatePolicy property is set.
        /// </summary>
        internal bool IsSetUlRatePolicy() => this.UlRatePolicy != null;
    }
}
