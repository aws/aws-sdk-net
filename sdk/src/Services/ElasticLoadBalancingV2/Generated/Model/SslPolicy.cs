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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a policy used for SSL negotiation.
    /// </summary>
    public partial class SslPolicy
    {
        private List<Cipher> _ciphers = AWSConfigs.InitializeCollections ? new List<Cipher>() : null;
        private string _name;
        private List<string> _sslProtocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedLoadBalancerTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Ciphers. 
        /// <para>
        /// The ciphers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Cipher> Ciphers
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SslProtocols
        {
            get { return this._sslProtocols; }
            set { this._sslProtocols = value; }
        }

        // Check to see if SslProtocols property is set
        internal bool IsSetSslProtocols()
        {
            return this._sslProtocols != null && (this._sslProtocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedLoadBalancerTypes. 
        /// <para>
        ///  The supported load balancers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedLoadBalancerTypes
        {
            get { return this._supportedLoadBalancerTypes; }
            set { this._supportedLoadBalancerTypes = value; }
        }

        // Check to see if SupportedLoadBalancerTypes property is set
        internal bool IsSetSupportedLoadBalancerTypes()
        {
            return this._supportedLoadBalancerTypes != null && (this._supportedLoadBalancerTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}