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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about different modes of client authentication.
    /// </summary>
    public partial class AwsMskClusterClusterInfoClientAuthenticationDetails
    {
        private AwsMskClusterClusterInfoClientAuthenticationSaslDetails _sasl;
        private AwsMskClusterClusterInfoClientAuthenticationTlsDetails _tls;
        private AwsMskClusterClusterInfoClientAuthenticationUnauthenticatedDetails _unauthenticated;

        /// <summary>
        /// Gets and sets the property Sasl. 
        /// <para>
        ///  Provides details for client authentication using SASL.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoClientAuthenticationSaslDetails Sasl
        {
            get { return this._sasl; }
            set { this._sasl = value; }
        }

        // Check to see if Sasl property is set
        internal bool IsSetSasl()
        {
            return this._sasl != null;
        }

        /// <summary>
        /// Gets and sets the property Tls. 
        /// <para>
        ///  Provides details for client authentication using TLS.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoClientAuthenticationTlsDetails Tls
        {
            get { return this._tls; }
            set { this._tls = value; }
        }

        // Check to see if Tls property is set
        internal bool IsSetTls()
        {
            return this._tls != null;
        }

        /// <summary>
        /// Gets and sets the property Unauthenticated. 
        /// <para>
        ///  Provides details for allowing no client authentication.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoClientAuthenticationUnauthenticatedDetails Unauthenticated
        {
            get { return this._unauthenticated; }
            set { this._unauthenticated = value; }
        }

        // Check to see if Unauthenticated property is set
        internal bool IsSetUnauthenticated()
        {
            return this._unauthenticated != null;
        }

    }
}