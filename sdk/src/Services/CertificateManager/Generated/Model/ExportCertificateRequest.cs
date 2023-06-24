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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the ExportCertificate operation.
    /// Exports a private certificate issued by a private certificate authority (CA) for use
    /// anywhere. The exported file contains the certificate, the certificate chain, and the
    /// encrypted private 2048-bit RSA key associated with the public key that is embedded
    /// in the certificate. For security, you must assign a passphrase for the private key
    /// when exporting it. 
    /// 
    ///  
    /// <para>
    /// For information about exporting and formatting a certificate using the ACM console
    /// or CLI, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-export-private.html">Export
    /// a Private Certificate</a>.
    /// </para>
    /// </summary>
    public partial class ExportCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private MemoryStream _passphrase;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) of the issued certificate. This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:region:account:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Passphrase. 
        /// <para>
        /// Passphrase to associate with the encrypted exported private key. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When creating your passphrase, you can use any ASCII character except #, $, or %.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want to later decrypt the private key, you must have the passphrase. You can
        /// use the following OpenSSL command to decrypt a private key. After entering the command,
        /// you are prompted for the passphrase.
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl rsa -in encrypted_key.pem -out decrypted_key.pem</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=128)]
        public MemoryStream Passphrase
        {
            get { return this._passphrase; }
            set { this._passphrase = value; }
        }

        // Check to see if Passphrase property is set
        internal bool IsSetPassphrase()
        {
            return this._passphrase != null;
        }

    }
}