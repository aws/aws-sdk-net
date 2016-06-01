/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A filter that can use conditional operators.
    /// </summary>
    public partial class Filter
    {
        private string _condition;
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A conditional operator. The following operators are valid: EQUALS, NOT_EQUALS, CONTAINS,
        /// NOT_CONTAINS. If you specify multiple filters, the system utilizes all filters as
        /// though concatenated by <i>AND</i>. If you specify multiple values for a particular
        /// filter, the system differentiates the values using <i>OR</i>. Calling either <i>DescribeConfigurations</i>
        /// or <i>ListConfigurations</i> returns attributes of matching configuration items.
        /// </para>
        /// </summary>
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter. The following filter names are allowed for <code>SERVER</code>
        /// configuration items.
        /// </para>
        ///  <p class="title"> <b>Server</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>server.hostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.osName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.osVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.configurationid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.agentid</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The name of the filter. The following filter names are allowed for <code>PROCESS</code>
        /// configuration items.
        /// </para>
        ///  <p class="title"> <b>Process</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>process.configurationid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>process.name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>process.commandLine</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.configurationid</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.hostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.osName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.osVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server.agentId</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The name of the filter. The following filter names are allowed for <code>CONNECTION</code>
        /// configuration items.
        /// </para>
        ///  <p class="title"> <b>Connection</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>connection.sourceIp</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection.destinationIp</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection.destinationPort</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceProcess.configurationId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceProcess.name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceProcess.commandLine</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationProcess.configurationId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationProcess.name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationProcess.commandLine</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceServer.configurationId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceServer.hostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceServer.osName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceServer.osVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sourceServer.agentId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationServer.configurationId</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationServer.hostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationServer.osName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationServer.osVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>destinationServer.agentId</code> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Values. 
        /// <para>
        /// A string value that you want to filter on. For example, if you choose the <code>destinationServer.osVersion</code>
        /// filter name, you could specify <code>Ubuntu</code> for the value.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}