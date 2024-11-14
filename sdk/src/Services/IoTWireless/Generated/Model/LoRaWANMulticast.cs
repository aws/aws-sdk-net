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
    /// The LoRaWAN information that is to be used with the multicast group.
    /// </summary>
    public partial class LoRaWANMulticast
    {
        private DlClass _dlClass;
        private ParticipatingGatewaysMulticast _participatingGateways;
        private SupportedRfRegion _rfRegion;

        /// <summary>
        /// Gets and sets the property DlClass.
        /// </summary>
        [AWSProperty(Max=256)]
        public DlClass DlClass
        {
            get { return this._dlClass; }
            set { this._dlClass = value; }
        }

        // Check to see if DlClass property is set
        internal bool IsSetDlClass()
        {
            return this._dlClass != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipatingGateways.
        /// </summary>
        public ParticipatingGatewaysMulticast ParticipatingGateways
        {
            get { return this._participatingGateways; }
            set { this._participatingGateways = value; }
        }

        // Check to see if ParticipatingGateways property is set
        internal bool IsSetParticipatingGateways()
        {
            return this._participatingGateways != null;
        }

        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        public SupportedRfRegion RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

    }
}