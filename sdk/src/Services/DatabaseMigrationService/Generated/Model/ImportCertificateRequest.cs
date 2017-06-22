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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ImportCertificate operation.
    /// Uploads the specified certificate.
    /// </summary>
    public partial class ImportCertificateRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _certificateIdentifier;
        private string _certificatePem;
        private MemoryStream _certificateWallet;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// The customer-assigned name of the certificate. Valid characters are A-z and 0-9.
        /// </para>
        /// </summary>
        public string CertificateIdentifier
        {
            get { return this._certificateIdentifier; }
            set { this._certificateIdentifier = value; }
        }

        // Check to see if CertificateIdentifier property is set
        internal bool IsSetCertificateIdentifier()
        {
            return this._certificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The contents of the .pem X.509 certificate file for the certificate.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificateWallet. 
        /// <para>
        /// The location of the imported Oracle Wallet certificate for use with SSL.
        /// </para>
        /// </summary>
        public MemoryStream CertificateWallet
        {
            get { return this._certificateWallet; }
            set { this._certificateWallet = value; }
        }

        // Check to see if CertificateWallet property is set
        internal bool IsSetCertificateWallet()
        {
            return this._certificateWallet != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the certificate.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}