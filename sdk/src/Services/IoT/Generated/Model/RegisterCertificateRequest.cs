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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterCertificate operation.
    /// Registers a device certificate with IoT in the same <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CertificateDescription.html#iot-Type-CertificateDescription-certificateMode">certificate
    /// mode</a> as the signing CA. If you have more than one CA certificate that has the
    /// same subject field, you must specify the CA certificate that was used to sign the
    /// device certificate being registered.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterCertificate</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class RegisterCertificateRequest : AmazonIoTRequest
    {
        private string _caCertificatePem;
        private string _certificatePem;
        private bool? _setAsActive;
        private CertificateStatus _status;

        /// <summary>
        /// Gets and sets the property CaCertificatePem. 
        /// <para>
        /// The CA certificate used to sign the device certificate being registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string CaCertificatePem
        {
            get { return this._caCertificatePem; }
            set { this._caCertificatePem = value; }
        }

        // Check to see if CaCertificatePem property is set
        internal bool IsSetCaCertificatePem()
        {
            return this._caCertificatePem != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The certificate data, in PEM format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string CertificatePem
        {
            get { return this._certificatePem; }
            set { this._certificatePem = value; }
        }

        // Check to see if CertificatePem property is set
        internal bool IsSetCertificatePem()
        {
            return this._certificatePem != null;
        }

        /// <summary>
        /// Gets and sets the property SetAsActive. 
        /// <para>
        /// A boolean value that specifies if the certificate is set to active.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ACTIVE | INACTIVE</c> 
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated")]
        public bool? SetAsActive
        {
            get { return this._setAsActive; }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the register certificate request. Valid values that you can use include
        /// <c>ACTIVE</c>, <c>INACTIVE</c>, and <c>REVOKED</c>.
        /// </para>
        /// </summary>
        public CertificateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}