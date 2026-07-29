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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Specifies which ports are accessible on a MicroVM. Only one of the port specification
    /// options can be set.
    /// </summary>
    public partial class PortSpecification
    {
        private Unit _allPorts;
        private int? _port;
        private PortRange _range;

        /// <summary>
        /// Gets and sets the property AllPorts. 
        /// <para>
        /// Indicates that all ports are accessible.
        /// </para>
        /// </summary>
        public Unit AllPorts
        {
            get { return this._allPorts; }
            set { this._allPorts = value; }
        }

        // Check to see if AllPorts property is set
        internal bool IsSetAllPorts()
        {
            return this._allPorts != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// A single port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// Gets and sets the property Range. 
        /// <para>
        /// A range of ports.
        /// </para>
        /// </summary>
        public PortRange Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

    }
}