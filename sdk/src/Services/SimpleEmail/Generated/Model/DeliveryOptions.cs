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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Specifies whether messages that use the configuration set are required to use Transport
    /// Layer Security (TLS).
    /// </summary>
    public partial class DeliveryOptions
    {
        private TlsPolicy _tlsPolicy;

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// Specifies whether messages that use the configuration set are required to use Transport
        /// Layer Security (TLS). If the value is <c>Require</c>, messages are only delivered
        /// if a TLS connection can be established. If the value is <c>Optional</c>, messages
        /// can be delivered in plain text if a TLS connection can't be established.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy
        {
            get { return this._tlsPolicy; }
            set { this._tlsPolicy = value; }
        }

        // Check to see if TlsPolicy property is set
        internal bool IsSetTlsPolicy()
        {
            return this._tlsPolicy != null;
        }

    }
}