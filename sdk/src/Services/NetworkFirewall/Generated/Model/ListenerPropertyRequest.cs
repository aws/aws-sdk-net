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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This data type is used specifically for the <a>CreateProxy</a> and <a>UpdateProxy</a>
    /// APIs.
    /// 
    ///  
    /// <para>
    /// Open port for taking HTTP or HTTPS traffic.
    /// </para>
    /// </summary>
    public partial class ListenerPropertyRequest
    {
        private int? _port;
        private ListenerPropertyType _type;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port for processing traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Selection of HTTP or HTTPS traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListenerPropertyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}