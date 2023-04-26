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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The device attestation key (DAK) information.
    /// </summary>
    public partial class DakCertificateMetadata
    {
        private string _apId;
        private string _certificateId;
        private string _deviceTypeId;
        private bool? _factorySupport;
        private int? _maxAllowedSignature;

        /// <summary>
        /// Gets and sets the property ApId. 
        /// <para>
        /// The advertised product ID (APID) that's used for pre-production and production applications.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ApId
        {
            get { return this._apId; }
            set { this._apId = value; }
        }

        // Check to see if ApId property is set
        internal bool IsSetApId()
        {
            return this._apId != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The certificate ID for the DAK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeId. 
        /// <para>
        /// The device type ID that's used for prototyping applications.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string DeviceTypeId
        {
            get { return this._deviceTypeId; }
            set { this._deviceTypeId = value; }
        }

        // Check to see if DeviceTypeId property is set
        internal bool IsSetDeviceTypeId()
        {
            return this._deviceTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property FactorySupport. 
        /// <para>
        /// Whether factory support has been enabled.
        /// </para>
        /// </summary>
        public bool FactorySupport
        {
            get { return this._factorySupport.GetValueOrDefault(); }
            set { this._factorySupport = value; }
        }

        // Check to see if FactorySupport property is set
        internal bool IsSetFactorySupport()
        {
            return this._factorySupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllowedSignature. 
        /// <para>
        /// The maximum number of signatures that the DAK can sign. A value of <code>-1</code>
        /// indicates that there's no device limit.
        /// </para>
        /// </summary>
        public int MaxAllowedSignature
        {
            get { return this._maxAllowedSignature.GetValueOrDefault(); }
            set { this._maxAllowedSignature = value; }
        }

        // Check to see if MaxAllowedSignature property is set
        internal bool IsSetMaxAllowedSignature()
        {
            return this._maxAllowedSignature.HasValue; 
        }

    }
}