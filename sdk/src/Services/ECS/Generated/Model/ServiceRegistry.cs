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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details of the service registry.
    /// </summary>
    public partial class ServiceRegistry
    {
        private string _containerName;
        private int? _containerPort;
        private int? _port;
        private string _registryArn;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The container name value, already specified in the task definition, to be used for
        /// your service discovery service. If the task definition that your service task specifies
        /// uses the <code>bridge</code> or <code>host</code> network mode, you must specify a
        /// <code>containerName</code> and <code>containerPort</code> combination from the task
        /// definition. If the task definition that your service task specifies uses the <code>awsvpc</code>
        /// network mode and a type SRV DNS record is used, you must specify either a <code>containerName</code>
        /// and <code>containerPort</code> combination or a <code>port</code> value, but not both.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port value, already specified in the task definition, to be used for your service
        /// discovery service. If the task definition your service task specifies uses the <code>bridge</code>
        /// or <code>host</code> network mode, you must specify a <code>containerName</code> and
        /// <code>containerPort</code> combination from the task definition. If the task definition
        /// your service task specifies uses the <code>awsvpc</code> network mode and a type SRV
        /// DNS record is used, you must specify either a <code>containerName</code> and <code>containerPort</code>
        /// combination or a <code>port</code> value, but not both.
        /// </para>
        /// </summary>
        public int ContainerPort
        {
            get { return this._containerPort.GetValueOrDefault(); }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value used if your service discovery service specified an SRV record. This
        /// field is required if both the <code>awsvpc</code> network mode and SRV records are
        /// used.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service registry. The currently supported service
        /// registry is Amazon Route 53 Auto Naming. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_autonaming_Service.html">Service</a>.
        /// </para>
        /// </summary>
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

    }
}