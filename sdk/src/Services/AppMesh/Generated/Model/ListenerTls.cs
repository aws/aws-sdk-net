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
    /// An object that represents the Transport Layer Security (TLS) properties for a listener.
    /// </summary>
    public partial class ListenerTls
    {
        private ListenerTlsCertificate _certificate;
        private ListenerTlsMode _mode;
        private ListenerTlsValidationContext _validation;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// A reference to an object that represents a listener's Transport Layer Security (TLS)
        /// certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListenerTlsCertificate Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

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
        [AWSProperty(Required=true)]
        public ListenerTlsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// A reference to an object that represents a listener's Transport Layer Security (TLS)
        /// validation context.
        /// </para>
        /// </summary>
        public ListenerTlsValidationContext Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }

        // Check to see if Validation property is set
        internal bool IsSetValidation()
        {
            return this._validation != null;
        }

    }
}