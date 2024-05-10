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
    /// The certificate issuer indentifier.
    /// </summary>
    public partial class IssuerCertificateIdentifier
    {
        private string _issuerCertificateSerialNumber;
        private string _issuerCertificateSubject;
        private string _issuerId;

        /// <summary>
        /// Gets and sets the property IssuerCertificateSerialNumber. 
        /// <para>
        /// The issuer certificate serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public string IssuerCertificateSerialNumber
        {
            get { return this._issuerCertificateSerialNumber; }
            set { this._issuerCertificateSerialNumber = value; }
        }

        // Check to see if IssuerCertificateSerialNumber property is set
        internal bool IsSetIssuerCertificateSerialNumber()
        {
            return this._issuerCertificateSerialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property IssuerCertificateSubject. 
        /// <para>
        /// The subject of the issuer certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string IssuerCertificateSubject
        {
            get { return this._issuerCertificateSubject; }
            set { this._issuerCertificateSubject = value; }
        }

        // Check to see if IssuerCertificateSubject property is set
        internal bool IsSetIssuerCertificateSubject()
        {
            return this._issuerCertificateSubject != null;
        }

        /// <summary>
        /// Gets and sets the property IssuerId. 
        /// <para>
        /// The issuer ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string IssuerId
        {
            get { return this._issuerId; }
            set { this._issuerId = value; }
        }

        // Check to see if IssuerId property is set
        internal bool IsSetIssuerId()
        {
            return this._issuerId != null;
        }

    }
}