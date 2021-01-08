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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a Transport Layer Security (TLS) validation context trust.
    /// </summary>
    public partial class VirtualGatewayTlsValidationContextTrust
    {
        private VirtualGatewayTlsValidationContextAcmTrust _acm;
        private VirtualGatewayTlsValidationContextFileTrust _file;

        /// <summary>
        /// Gets and sets the property Acm. 
        /// <para>
        /// A reference to an object that represents a TLS validation context trust for an AWS
        /// Certicate Manager (ACM) certificate.
        /// </para>
        /// </summary>
        public VirtualGatewayTlsValidationContextAcmTrust Acm
        {
            get { return this._acm; }
            set { this._acm = value; }
        }

        // Check to see if Acm property is set
        internal bool IsSetAcm()
        {
            return this._acm != null;
        }

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// An object that represents a TLS validation context trust for a local file.
        /// </para>
        /// </summary>
        public VirtualGatewayTlsValidationContextFileTrust File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

    }
}