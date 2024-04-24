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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a path statement.
    /// </summary>
    public partial class PathStatement
    {
        private PacketHeaderStatement _packetHeaderStatement;
        private ResourceStatement _resourceStatement;

        /// <summary>
        /// Gets and sets the property PacketHeaderStatement. 
        /// <para>
        /// The packet header statement.
        /// </para>
        /// </summary>
        public PacketHeaderStatement PacketHeaderStatement
        {
            get { return this._packetHeaderStatement; }
            set { this._packetHeaderStatement = value; }
        }

        // Check to see if PacketHeaderStatement property is set
        internal bool IsSetPacketHeaderStatement()
        {
            return this._packetHeaderStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatement. 
        /// <para>
        /// The resource statement.
        /// </para>
        /// </summary>
        public ResourceStatement ResourceStatement
        {
            get { return this._resourceStatement; }
            set { this._resourceStatement = value; }
        }

        // Check to see if ResourceStatement property is set
        internal bool IsSetResourceStatement()
        {
            return this._resourceStatement != null;
        }

    }
}