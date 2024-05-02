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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// An individual Firewall Manager application.
    /// </summary>
    public partial class App
    {
        private string _appName;
        private long? _port;
        private string _protocol;

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The application's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AppName
        {
            get { return this._appName; }
            set { this._appName = value; }
        }

        // Check to see if AppName property is set
        internal bool IsSetAppName()
        {
            return this._appName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The application's port number, for example <c>80</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public long? Port
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
        /// The IP protocol name or number. The name can be one of <c>tcp</c>, <c>udp</c>, or
        /// <c>icmp</c>. For information on possible numbers, see <a href="https://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}