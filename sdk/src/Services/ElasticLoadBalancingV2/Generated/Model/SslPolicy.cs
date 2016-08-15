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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a policy used for SSL negotiation.
    /// </summary>
    public partial class SslPolicy
    {
        private List<Cipher> _ciphers = new List<Cipher>();
        private string _name;
        private List<string> _sslProtocols = new List<string>();

        /// <summary>
        /// Gets and sets the property Ciphers. 
        /// <para>
        /// The ciphers.
        /// </para>
        /// </summary>
        public List<Cipher> Ciphers
        {
            get { return this._ciphers; }
            set { this._ciphers = value; }
        }

        // Check to see if Ciphers property is set
        internal bool IsSetCiphers()
        {
            return this._ciphers != null && this._ciphers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SslProtocols. 
        /// <para>
        /// The protocols.
        /// </para>
        /// </summary>
        public List<string> SslProtocols
        {
            get { return this._sslProtocols; }
            set { this._sslProtocols = value; }
        }

        // Check to see if SslProtocols property is set
        internal bool IsSetSslProtocols()
        {
            return this._sslProtocols != null && this._sslProtocols.Count > 0; 
        }

    }
}