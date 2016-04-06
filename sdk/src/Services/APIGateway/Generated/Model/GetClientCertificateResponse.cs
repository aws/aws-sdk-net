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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a Client Certificate used to configure client-side SSL authentication while
    /// sending requests to the integration endpoint.
    /// </summary>
    public partial class GetClientCertificateResponse : AmazonWebServiceResponse
    {
        private string _clientCertificateId;
        private DateTime? _createdDate;
        private string _description;
        private DateTime? _expirationDate;
        private string _pemEncodedCertificate;

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of the Client Certificate.
        /// </para>
        /// </summary>
        public string ClientCertificateId
        {
            get { return this._clientCertificateId; }
            set { this._clientCertificateId = value; }
        }

        // Check to see if ClientCertificateId property is set
        internal bool IsSetClientCertificateId()
        {
            return this._clientCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the Client Certificate was created, in <a href="http://www.iso.org/iso/home/standards/iso8601.htm"
        /// target="_blank">ISO 8601 format</a>.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Client Certificate.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when the Client Certificate will expire, in <a href="http://www.iso.org/iso/home/standards/iso8601.htm"
        /// target="_blank">ISO 8601 format</a>.
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PemEncodedCertificate. 
        /// <para>
        /// The PEM-encoded public key of the Client Certificate, that can be used to configure
        /// certificate authentication in the integration endpoint .
        /// </para>
        /// </summary>
        public string PemEncodedCertificate
        {
            get { return this._pemEncodedCertificate; }
            set { this._pemEncodedCertificate = value; }
        }

        // Check to see if PemEncodedCertificate property is set
        internal bool IsSetPemEncodedCertificate()
        {
            return this._pemEncodedCertificate != null;
        }

    }
}