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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Represents the information required for client programs to connect to the endpoint
    /// for a DAX cluster.
    /// </summary>
    public partial class Endpoint
    {
        private string _address;
        private int? _port;
        private string _url;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The DNS hostname of the endpoint.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that applications should use to connect to the endpoint.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property URL. 
        /// <para>
        /// The URL that applications should use to connect to the endpoint. The default ports
        /// are 8111 for the "dax" protocol and 9111 for the "daxs" protocol.
        /// </para>
        /// </summary>
        public string URL
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if URL property is set
        internal bool IsSetURL()
        {
            return this._url != null;
        }

    }
}