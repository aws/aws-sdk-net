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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// A single controller area network (CAN) device interface.
    /// </summary>
    public partial class CanInterface
    {
        private string _name;
        private string _protocolName;
        private string _protocolVersion;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ProtocolName. 
        /// <para>
        /// The name of the communication protocol for the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ProtocolName
        {
            get { return this._protocolName; }
            set { this._protocolName = value; }
        }

        // Check to see if ProtocolName property is set
        internal bool IsSetProtocolName()
        {
            return this._protocolName != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        /// The version of the communication protocol for the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ProtocolVersion
        {
            get { return this._protocolVersion; }
            set { this._protocolVersion = value; }
        }

        // Check to see if ProtocolVersion property is set
        internal bool IsSetProtocolVersion()
        {
            return this._protocolVersion != null;
        }

    }
}