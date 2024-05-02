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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Describes the attack.
    /// </summary>
    public partial class AttackVectorDescription
    {
        private string _vectorType;

        /// <summary>
        /// Gets and sets the property VectorType. 
        /// <para>
        /// The attack type. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// UDP_TRAFFIC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UDP_FRAGMENT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GENERIC_UDP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DNS_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CHARGEN_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSDP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PORT_MAPPER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RIP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SNMP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MSSQL_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NET_BIOS_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYN_FLOOD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACK_FLOOD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REQUEST_FLOOD
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UDS_REFLECTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMCACHED_REFLECTION
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VectorType
        {
            get { return this._vectorType; }
            set { this._vectorType = value; }
        }

        // Check to see if VectorType property is set
        internal bool IsSetVectorType()
        {
            return this._vectorType != null;
        }

    }
}