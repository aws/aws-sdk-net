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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The settings for a PUSH type input.
    /// </summary>
    public partial class InputDestination
    {
        private string _ip;
        private string _network;
        private List<InputDestinationRoute> _networkRoutes = AWSConfigs.InitializeCollections ? new List<InputDestinationRoute>() : null;
        private string _port;
        private string _url;
        private InputDestinationVpc _vpc;

        /// <summary>
        /// Gets and sets the property Ip. The system-generated static IP address of endpoint.It
        /// remains fixed for the lifetime of the input.
        /// </summary>
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property Network. The ID of the attached network.
        /// </summary>
        public string Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkRoutes. If the push input has an input location
        /// of ON-PREM it's a requirement to specify what the route of the inputis going to be
        /// on the customer local network.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDestinationRoute> NetworkRoutes
        {
            get { return this._networkRoutes; }
            set { this._networkRoutes = value; }
        }

        // Check to see if NetworkRoutes property is set
        internal bool IsSetNetworkRoutes()
        {
            return this._networkRoutes != null && (this._networkRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Port. The port number for the input.
        /// </summary>
        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port != null;
        }

        /// <summary>
        /// Gets and sets the property Url. This represents the endpoint that the customer stream
        /// will bepushed to.
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc.
        /// </summary>
        public InputDestinationVpc Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}