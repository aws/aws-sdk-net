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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a container deployment configuration of an Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// A deployment specifies the settings, such as the ports and launch command, of containers
    /// that are deployed to your container service.
    /// </para>
    /// </summary>
    public partial class ContainerServiceDeploymentRequest
    {
        private Dictionary<string, Container> _containers = new Dictionary<string, Container>();
        private EndpointRequest _publicEndpoint;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// An object that describes the configuration for the containers of the deployment.
        /// </para>
        /// </summary>
        public Dictionary<string, Container> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && this._containers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PublicEndpoint. 
        /// <para>
        /// An object that describes the endpoint of the deployment.
        /// </para>
        /// </summary>
        public EndpointRequest PublicEndpoint
        {
            get { return this._publicEndpoint; }
            set { this._publicEndpoint = value; }
        }

        // Check to see if PublicEndpoint property is set
        internal bool IsSetPublicEndpoint()
        {
            return this._publicEndpoint != null;
        }

    }
}