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
    /// An object that represents a Transport Layer Security (TLS) client policy.
    /// </summary>
    public partial class VirtualGatewayClientPolicyTls
    {
        private bool? _enforce;
        private List<int> _ports = new List<int>();
        private VirtualGatewayTlsValidationContext _validation;

        /// <summary>
        /// Gets and sets the property Enforce. 
        /// <para>
        /// Whether the policy is enforced. The default is <code>True</code>, if a value isn't
        /// specified.
        /// </para>
        /// </summary>
        public bool Enforce
        {
            get { return this._enforce.GetValueOrDefault(); }
            set { this._enforce = value; }
        }

        // Check to see if Enforce property is set
        internal bool IsSetEnforce()
        {
            return this._enforce.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// One or more ports that the policy is enforced for.
        /// </para>
        /// </summary>
        public List<int> Ports
        {
            get { return this._ports; }
            set { this._ports = value; }
        }

        // Check to see if Ports property is set
        internal bool IsSetPorts()
        {
            return this._ports != null && this._ports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// A reference to an object that represents a TLS validation context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualGatewayTlsValidationContext Validation
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