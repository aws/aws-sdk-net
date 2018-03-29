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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a server certificate.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a>GetServerCertificate</a> operation.
    /// 
    /// </para>
    /// </summary>
    public partial class ServerCertificate
    {
        private string _certificateBody;
        private string _certificateChain;
        private ServerCertificateMetadata _serverCertificateMetadata;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ServerCertificate() { }

        /// <summary>
        /// Instantiates ServerCertificate with the parameterized properties
        /// </summary>
        /// <param name="serverCertificateMetadata">The meta information of the server certificate, such as its name, path, ID, and ARN.</param>
        /// <param name="certificateBody">The contents of the public key certificate.</param>
        public ServerCertificate(ServerCertificateMetadata serverCertificateMetadata, string certificateBody)
        {
            _serverCertificateMetadata = serverCertificateMetadata;
            _certificateBody = certificateBody;
        }

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the public key certificate.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The contents of the public key certificate chain.
        /// </para>
        /// </summary>
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateMetadata. 
        /// <para>
        /// The meta information of the server certificate, such as its name, path, ID, and ARN.
        /// </para>
        /// </summary>
        public ServerCertificateMetadata ServerCertificateMetadata
        {
            get { return this._serverCertificateMetadata; }
            set { this._serverCertificateMetadata = value; }
        }

        // Check to see if ServerCertificateMetadata property is set
        internal bool IsSetServerCertificateMetadata()
        {
            return this._serverCertificateMetadata != null;
        }

    }
}