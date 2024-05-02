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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A port mapping for the container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsPortMappingsDetails
    {
        private int? _containerPort;
        private int? _hostPort;
        private string _protocol;

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container that is bound to the user-specified or automatically
        /// assigned host port.
        /// </para>
        /// </summary>
        public int? ContainerPort
        {
            get { return this._containerPort; }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostPort. 
        /// <para>
        /// The port number on the container instance to reserve for the container.
        /// </para>
        /// </summary>
        public int? HostPort
        {
            get { return this._hostPort; }
            set { this._hostPort = value; }
        }

        // Check to see if HostPort property is set
        internal bool IsSetHostPort()
        {
            return this._hostPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the port mapping. The default is <c>tcp</c>.
        /// </para>
        /// </summary>
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