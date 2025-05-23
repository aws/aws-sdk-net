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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Returns the details of the DB instance’s server certificate.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/ca_cert_rotation.html">Updating
    /// Your Amazon DocumentDB TLS Certificates</a> and <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/security.encryption.ssl.html">
    /// Encrypting Data in Transit</a> in the <i>Amazon DocumentDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CertificateDetails
    {
        private string _caIdentifier;
        private DateTime? _validTill;

        /// <summary>
        /// Gets and sets the property CAIdentifier. 
        /// <para>
        /// The CA identifier of the CA certificate used for the DB instance's server certificate.
        /// </para>
        /// </summary>
        public string CAIdentifier
        {
            get { return this._caIdentifier; }
            set { this._caIdentifier = value; }
        }

        // Check to see if CAIdentifier property is set
        internal bool IsSetCAIdentifier()
        {
            return this._caIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ValidTill. 
        /// <para>
        /// The expiration date of the DB instance’s server certificate.
        /// </para>
        /// </summary>
        public DateTime? ValidTill
        {
            get { return this._validTill; }
            set { this._validTill = value; }
        }

        // Check to see if ValidTill property is set
        internal bool IsSetValidTill()
        {
            return this._validTill.HasValue; 
        }

    }
}