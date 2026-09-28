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
    /// LoRaWANServiceProfile object.
    /// </summary>
    public partial class LoRaWANServiceProfile
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
        /// Gets and sets the property DrMax. 
        /// <para>
        /// The DrMax value.
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
        /// The DrMin value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? DrMin { get; set; }

        /// <summary>
        /// Checks to see if the DrMin property is set.
        /// </summary>
        internal bool IsSetDrMin() => this.DrMin.HasValue;

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
        /// Gets and sets the property TxPowerIndexMax. 
        /// <para>
        /// The Transmit Power Index maximum.
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
        /// The Transmit Power Index minimum.
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
    }
}
