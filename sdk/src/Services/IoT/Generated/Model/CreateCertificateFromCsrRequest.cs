/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCertificateFromCsr operation.
    /// Creates an X.509 certificate using the specified certificate signing request.
    /// 
    ///  
    /// <para>
    /// <b>Note</b> Reusing the same certificate signing request (CSR) results in a distinct
    /// certificate.
    /// </para>
    /// </summary>
    public partial class CreateCertificateFromCsrRequest : AmazonIoTRequest
    {
        private string _certificateSigningRequest;
        private bool? _setAsActive;

        /// <summary>
        /// Gets and sets the property CertificateSigningRequest. 
        /// <para>
        /// The certificate signing request (CSR).
        /// </para>
        /// </summary>
        public string CertificateSigningRequest
        {
            get { return this._certificateSigningRequest; }
            set { this._certificateSigningRequest = value; }
        }

        // Check to see if CertificateSigningRequest property is set
        internal bool IsSetCertificateSigningRequest()
        {
            return this._certificateSigningRequest != null;
        }

        /// <summary>
        /// Gets and sets the property SetAsActive. 
        /// <para>
        /// Specifies whether the certificate is active.
        /// </para>
        /// </summary>
        public bool SetAsActive
        {
            get { return this._setAsActive.GetValueOrDefault(); }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

    }
}