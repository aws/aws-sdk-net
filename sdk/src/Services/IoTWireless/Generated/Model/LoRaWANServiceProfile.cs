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
    /// LoRaWANServiceProfile object.
    /// </summary>
    public partial class LoRaWANServiceProfile
    {
        private bool? _addGwMetadata;
        private int? _drMax;
        private int? _drMin;
        private int? _nbTransMax;
        private int? _nbTransMin;
        private bool? _prAllowed;
        private bool? _raAllowed;
        private int? _txPowerIndexMax;
        private int? _txPowerIndexMin;

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
        /// Gets and sets the property DrMax. 
        /// <para>
        /// The DrMax value.
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
        /// The DrMin value.
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
        /// Gets and sets the property TxPowerIndexMax. 
        /// <para>
        /// The Transmit Power Index maximum.
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
        /// The Transmit Power Index minimum.
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

    }
}