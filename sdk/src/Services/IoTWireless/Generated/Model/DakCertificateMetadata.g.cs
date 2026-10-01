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
    /// The device attestation key (DAK) information.
    /// </summary>
    public partial class DakCertificateMetadata
    {
        /// <summary>
        /// Gets and sets the property ApId. 
        /// <para>
        /// The advertised product ID (APID) that's used for pre-production and production applications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ApId { get; set; }

        /// <summary>
        /// Checks to see if the ApId property is set.
        /// </summary>
        internal bool IsSetApId() => this.ApId != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The certificate ID for the DAK.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeId. 
        /// <para>
        /// The device type ID that's used for prototyping applications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DeviceTypeId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeId property is set.
        /// </summary>
        internal bool IsSetDeviceTypeId() => this.DeviceTypeId != null;

        /// <summary>
        /// Gets and sets the property FactorySupport. 
        /// <para>
        /// Whether factory support has been enabled.
        /// </para>
        /// </summary>
        public bool? FactorySupport { get; set; }

        /// <summary>
        /// Checks to see if the FactorySupport property is set.
        /// </summary>
        internal bool IsSetFactorySupport() => this.FactorySupport.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllowedSignature. 
        /// <para>
        /// The maximum number of signatures that the DAK can sign. A value of <c>-1</c> indicates
        /// that there's no device limit.
        /// </para>
        /// </summary>
        public int? MaxAllowedSignature { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowedSignature property is set.
        /// </summary>
        internal bool IsSetMaxAllowedSignature() => this.MaxAllowedSignature.HasValue;
    }
}
