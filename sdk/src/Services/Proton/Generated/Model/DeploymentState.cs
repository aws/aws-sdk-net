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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// The detailed data about the current state of the deployment.
    /// </summary>
    public partial class DeploymentState
    {
        private ComponentState _component;
        private EnvironmentState _environment;
        private ServiceInstanceState _serviceInstance;
        private ServicePipelineState _servicePipeline;

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The state of the component associated with the deployment.
        /// </para>
        /// </summary>
        public ComponentState Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The state of the environment associated with the deployment.
        /// </para>
        /// </summary>
        public EnvironmentState Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInstance. 
        /// <para>
        /// The state of the service instance associated with the deployment.
        /// </para>
        /// </summary>
        public ServiceInstanceState ServiceInstance
        {
            get { return this._serviceInstance; }
            set { this._serviceInstance = value; }
        }

        // Check to see if ServiceInstance property is set
        internal bool IsSetServiceInstance()
        {
            return this._serviceInstance != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePipeline. 
        /// <para>
        /// The state of the service pipeline associated with the deployment.
        /// </para>
        /// </summary>
        public ServicePipelineState ServicePipeline
        {
            get { return this._servicePipeline; }
            set { this._servicePipeline = value; }
        }

        // Check to see if ServicePipeline property is set
        internal bool IsSetServicePipeline()
        {
            return this._servicePipeline != null;
        }

    }
}