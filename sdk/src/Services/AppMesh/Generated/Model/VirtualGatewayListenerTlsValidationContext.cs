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
    /// An object that represents a virtual gateway's listener's Transport Layer Security
    /// (TLS) validation context.
    /// </summary>
    public partial class VirtualGatewayListenerTlsValidationContext
    {
        private SubjectAlternativeNames _subjectAlternativeNames;
        private VirtualGatewayListenerTlsValidationContextTrust _trust;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// A reference to an object that represents the SANs for a virtual gateway listener's
        /// Transport Layer Security (TLS) validation context.
        /// </para>
        /// </summary>
        public SubjectAlternativeNames SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null;
        }

        /// <summary>
        /// Gets and sets the property Trust. 
        /// <para>
        /// A reference to where to retrieve the trust chain when validating a peer’s Transport
        /// Layer Security (TLS) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualGatewayListenerTlsValidationContextTrust Trust
        {
            get { return this._trust; }
            set { this._trust = value; }
        }

        // Check to see if Trust property is set
        internal bool IsSetTrust()
        {
            return this._trust != null;
        }

    }
}