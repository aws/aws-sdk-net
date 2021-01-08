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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Includes all client authentication information.
    /// </summary>
    public partial class ClientAuthentication
    {
        private Sasl _sasl;
        private Tls _tls;

        /// <summary>
        /// Gets and sets the property Sasl.             
        /// <para>
        /// Details for ClientAuthentication using SASL.
        /// </para>
        /// </summary>
        public Sasl Sasl
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
        /// Details for ClientAuthentication using TLS.
        /// </para>
        /// </summary>
        public Tls Tls
        {
            get { return this._tls; }
            set { this._tls = value; }
        }

        // Check to see if Tls property is set
        internal bool IsSetTls()
        {
            return this._tls != null;
        }

    }
}