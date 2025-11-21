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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResponderGateway operation.
    /// Updates a responder gateway.
    /// </summary>
    public partial class UpdateResponderGatewayRequest : AmazonRTBFabricRequest
    {
        private string _clientToken;
        private string _description;
        private string _domainName;
        private string _gatewayId;
        private ManagedEndpointConfiguration _managedEndpointConfiguration;
        private int? _port;
        private Protocol _protocol;
        private TrustStoreConfiguration _trustStoreConfiguration;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique client token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the responder gateway.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for the responder gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedEndpointConfiguration. 
        /// <para>
        /// The configuration for the managed endpoint.
        /// </para>
        /// </summary>
        public ManagedEndpointConfiguration ManagedEndpointConfiguration
        {
            get { return this._managedEndpointConfiguration; }
            set { this._managedEndpointConfiguration = value; }
        }

        // Check to see if ManagedEndpointConfiguration property is set
        internal bool IsSetManagedEndpointConfiguration()
        {
            return this._managedEndpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The networking port to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The networking protocol to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreConfiguration. 
        /// <para>
        /// The configuration of the trust store.
        /// </para>
        /// </summary>
        public TrustStoreConfiguration TrustStoreConfiguration
        {
            get { return this._trustStoreConfiguration; }
            set { this._trustStoreConfiguration = value; }
        }

        // Check to see if TrustStoreConfiguration property is set
        internal bool IsSetTrustStoreConfiguration()
        {
            return this._trustStoreConfiguration != null;
        }

    }
}