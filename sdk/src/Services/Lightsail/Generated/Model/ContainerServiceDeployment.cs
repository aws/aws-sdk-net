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

#pragma warning disable CS0612,CS0618,CS1570
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
    public partial class ContainerServiceDeployment
    {
        private Dictionary<string, Container> _containers = AWSConfigs.InitializeCollections ? new Dictionary<string, Container>() : null;
        private DateTime? _createdAt;
        private ContainerServiceEndpoint _publicEndpoint;
        private ContainerServiceDeploymentState _state;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// An object that describes the configuration for the containers of the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Container> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the deployment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicEndpoint. 
        /// <para>
        /// An object that describes the endpoint of the deployment.
        /// </para>
        /// </summary>
        public ContainerServiceEndpoint PublicEndpoint
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the deployment.
        /// </para>
        ///  
        /// <para>
        /// A deployment can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVATING</c> - The deployment is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The deployment was successfully created, and it's currently running
        /// on the container service. The container service can have only one deployment in an
        /// active state at a time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> - The deployment was previously successfully created, but it is not
        /// currently running on the container service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The deployment failed. Use the <c>GetContainerLog</c> action to view
        /// the log events for the containers in the deployment to try to determine the reason
        /// for the failure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerServiceDeploymentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the deployment.
        /// </para>
        /// </summary>
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}