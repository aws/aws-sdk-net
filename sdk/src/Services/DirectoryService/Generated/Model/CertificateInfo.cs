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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains general information about a certificate.
    /// </summary>
    public partial class CertificateInfo
    {
        private string _certificateId;
        private string _commonName;
        private DateTime? _expiryDateTime;
        private CertificateState _state;
        private CertificateType _type;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the certificate.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name for the certificate.
        /// </para>
        /// </summary>
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiryDateTime. 
        /// <para>
        /// The date and time when the certificate will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiryDateTime
        {
            get { return this._expiryDateTime; }
            set { this._expiryDateTime = value; }
        }

        // Check to see if ExpiryDateTime property is set
        internal bool IsSetExpiryDateTime()
        {
            return this._expiryDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the certificate.
        /// </para>
        /// </summary>
        public CertificateState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The function that the registered certificate performs. Valid values include <c>ClientLDAPS</c>
        /// or <c>ClientCertAuth</c>. The default value is <c>ClientLDAPS</c>.
        /// </para>
        /// </summary>
        public CertificateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}