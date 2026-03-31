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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The trust store used for mutual TLS authentication. It contains the certificate authority
    /// (CA) certificates and optional certificate revocation list (CRL).
    /// </summary>
    public partial class TrustStore
    {
        private string _caContent;
        private string _crlContent;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property CAContent. 
        /// <para>
        /// The PEM-encoded certificate authority (CA) certificates bundle for the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=500000)]
        public string CAContent
        {
            get { return this._caContent; }
            set { this._caContent = value; }
        }

        // Check to see if CAContent property is set
        internal bool IsSetCAContent()
        {
            return this._caContent != null;
        }

        /// <summary>
        /// Gets and sets the property CrlContent. 
        /// <para>
        /// The PEM-encoded certificate revocation lists (CRLs) for the trust store. There can
        /// be one CRL per certificate authority (CA) in the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500000)]
        public string CrlContent
        {
            get { return this._crlContent; }
            set { this._crlContent = value; }
        }

        // Check to see if CrlContent property is set
        internal bool IsSetCrlContent()
        {
            return this._crlContent != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the trust store contents.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}