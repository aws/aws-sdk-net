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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about all brokers.
    /// </summary>
    public partial class BrokerInstance
    {
        private string _consoleURL;
        private List<string> _endpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ipAddress;

        /// <summary>
        /// Gets and sets the property ConsoleURL. 
        /// <para>
        /// The brokers web console URL.
        /// </para>
        /// </summary>
        public string ConsoleURL
        {
            get { return this._consoleURL; }
            set { this._consoleURL = value; }
        }

        // Check to see if ConsoleURL property is set
        internal bool IsSetConsoleURL()
        {
            return this._consoleURL != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The broker's wire-level protocol endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the Elastic Network Interface (ENI) attached to the broker. Does
        /// not apply to RabbitMQ brokers.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

    }
}