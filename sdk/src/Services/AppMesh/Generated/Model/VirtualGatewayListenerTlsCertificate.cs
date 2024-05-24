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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a listener's Transport Layer Security (TLS) certificate.
    /// </summary>
    public partial class VirtualGatewayListenerTlsCertificate
    {
        private VirtualGatewayListenerTlsAcmCertificate _acm;
        private VirtualGatewayListenerTlsFileCertificate _file;
        private VirtualGatewayListenerTlsSdsCertificate _sds;

        /// <summary>
        /// Gets and sets the property Acm. 
        /// <para>
        /// A reference to an object that represents an Certificate Manager certificate.
        /// </para>
        /// </summary>
        public VirtualGatewayListenerTlsAcmCertificate Acm
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
        /// A reference to an object that represents a local file certificate.
        /// </para>
        /// </summary>
        public VirtualGatewayListenerTlsFileCertificate File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property Sds. 
        /// <para>
        /// A reference to an object that represents a virtual gateway's listener's Secret Discovery
        /// Service certificate.
        /// </para>
        /// </summary>
        public VirtualGatewayListenerTlsSdsCertificate Sds
        {
            get { return this._sds; }
            set { this._sds = value; }
        }

        // Check to see if Sds property is set
        internal bool IsSetSds()
        {
            return this._sds != null;
        }

    }
}