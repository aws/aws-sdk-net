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
    /// Container for the parameters to the CreateContainerServiceDeployment operation.
    /// Creates a deployment for your Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// A deployment specifies the containers that will be launched on the container service
    /// and their settings, such as the ports to open, the environment variables to apply,
    /// and the launch command to run. It also specifies the container that will serve as
    /// the public endpoint of the deployment and its settings, such as the HTTP or HTTPS
    /// port to use, and the health check configuration.
    /// </para>
    ///  
    /// <para>
    /// You can deploy containers to your container service using container images from a
    /// public registry like Docker Hub, or from your local machine. For more information,
    /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-images">Creating
    /// container images for your Amazon Lightsail container services</a> in the <i>Lightsail
    /// Dev Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateContainerServiceDeploymentRequest : AmazonLightsailRequest
    {
        private Dictionary<string, Container> _containers = new Dictionary<string, Container>();
        private EndpointRequest _publicEndpoint;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// An object that describes the settings of the containers that will be launched on the
        /// container service.
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
        /// An object that describes the settings of the public endpoint for the container service.
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

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service for which to create the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}