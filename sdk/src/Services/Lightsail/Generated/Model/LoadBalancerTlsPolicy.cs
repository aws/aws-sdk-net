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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the TLS security policies that are available for Lightsail load balancers.
    /// 
    ///  
    /// <para>
    /// For more information about load balancer TLS security policies, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configure-load-balancer-tls-security-policy">Configuring
    /// TLS security policies on your Amazon Lightsail load balancers</a> in the <i>Amazon
    /// Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class LoadBalancerTlsPolicy
    {
        private List<string> _ciphers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private bool? _isDefault;
        private string _name;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Ciphers. 
        /// <para>
        /// The ciphers used by the TLS security policy.
        /// </para>
        ///  
        /// <para>
        /// The ciphers are listed in order of preference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ciphers
        {
            get { return this._ciphers; }
            set { this._ciphers = value; }
        }

        // Check to see if Ciphers property is set
        internal bool IsSetCiphers()
        {
            return this._ciphers != null && (this._ciphers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the TLS security policy.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// A Boolean value that indicates whether the TLS security policy is the default.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the TLS security policy.
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
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols used in a given TLS security policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}