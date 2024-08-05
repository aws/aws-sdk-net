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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// LTE network measurements.
    /// </summary>
    public partial class LteNetworkMeasurements
    {
        private int? _cellId;
        private int? _earfcn;
        private int? _pci;
        private int? _rsrp;
        private float? _rsrq;

        /// <summary>
        /// Gets and sets the property CellId. 
        /// <para>
        /// E-UTRAN Cell Identifier (ECI).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=268435455)]
        public int? CellId
        {
            get { return this._cellId; }
            set { this._cellId = value; }
        }

        // Check to see if CellId property is set
        internal bool IsSetCellId()
        {
            return this._cellId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Earfcn. 
        /// <para>
        /// E-UTRA (Evolved Universal Terrestrial Radio Access) absolute radio frequency channel
        /// number (EARFCN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=262143)]
        public int? Earfcn
        {
            get { return this._earfcn; }
            set { this._earfcn = value; }
        }

        // Check to see if Earfcn property is set
        internal bool IsSetEarfcn()
        {
            return this._earfcn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pci. 
        /// <para>
        /// Physical Cell ID (PCI).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=503)]
        public int? Pci
        {
            get { return this._pci; }
            set { this._pci = value; }
        }

        // Check to see if Pci property is set
        internal bool IsSetPci()
        {
            return this._pci.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rsrp. 
        /// <para>
        /// Signal power of the reference signal received, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-140, Max=-44)]
        public int? Rsrp
        {
            get { return this._rsrp; }
            set { this._rsrp = value; }
        }

        // Check to see if Rsrp property is set
        internal bool IsSetRsrp()
        {
            return this._rsrp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rsrq. 
        /// <para>
        /// Signal quality of the reference Signal received, measured in decibels (dB).
        /// </para>
        /// </summary>
        [AWSProperty(Max=-3)]
        public float? Rsrq
        {
            get { return this._rsrq; }
            set { this._rsrq = value; }
        }

        // Check to see if Rsrq property is set
        internal bool IsSetRsrq()
        {
            return this._rsrq.HasValue; 
        }

    }
}