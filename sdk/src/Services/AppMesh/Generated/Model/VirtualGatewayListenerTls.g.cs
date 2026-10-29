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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// An object that represents the Transport Layer Security (TLS) properties for a listener.
    /// </summary>
    public partial class VirtualGatewayListenerTls
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// An object that represents a Transport Layer Security (TLS) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VirtualGatewayListenerTlsCertificate Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specify one of the following modes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b/>STRICT – Listener only accepts connections with TLS enabled. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b/>PERMISSIVE – Listener accepts connections with or without TLS enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b/>DISABLED – Listener only accepts connections without TLS. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public VirtualGatewayListenerTlsMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// A reference to an object that represents a virtual gateway's listener's Transport
        /// Layer Security (TLS) validation context.
        /// </para>
        /// </summary>
        public VirtualGatewayListenerTlsValidationContext Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;
    }
}
