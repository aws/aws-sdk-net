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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// <b>This operation has been expanded to use with the Amazon GameLift containers feature,
    /// which is currently in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// The set of port numbers to open on each instance in a container fleet. Connection
    /// ports are used by inbound traffic to connect with processes that are running in containers
    /// on the fleet.
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a>ContainerGroupsConfiguration</a>, <a>ContainerGroupsAttributes</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ConnectionPortRange
    {
        private int? _fromPort;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// Starting value for the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=60000)]
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// Ending value for the port. Port numbers are end-inclusive. This value must be equal
        /// to or greater than <c>FromPort</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=60000)]
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}