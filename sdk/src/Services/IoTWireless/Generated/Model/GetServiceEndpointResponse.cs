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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetServiceEndpoint operation.
    /// </summary>
    public partial class GetServiceEndpointResponse : AmazonWebServiceResponse
    {
        private string _serverTrust;
        private string _serviceEndpoint;
        private WirelessGatewayServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property ServerTrust. 
        /// <para>
        /// The Root CA of the server trust certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ServerTrust
        {
            get { return this._serverTrust; }
            set { this._serverTrust = value; }
        }

        // Check to see if ServerTrust property is set
        internal bool IsSetServerTrust()
        {
            return this._serverTrust != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEndpoint. 
        /// <para>
        /// The service endpoint value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ServiceEndpoint
        {
            get { return this._serviceEndpoint; }
            set { this._serviceEndpoint = value; }
        }

        // Check to see if ServiceEndpoint property is set
        internal bool IsSetServiceEndpoint()
        {
            return this._serviceEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The endpoint's service type.
        /// </para>
        /// </summary>
        public WirelessGatewayServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}