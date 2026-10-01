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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The control plane component configuration defaults and constraints.
    /// </summary>
    public partial class ControlPlaneConfigInfo
    {
        /// <summary>
        /// Gets and sets the property KubeApiServerConfig. 
        /// <para>
        /// The Kubernetes API server configuration defaults and constraints.
        /// </para>
        /// </summary>
        public KubeApiServerVersionConfig KubeApiServerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeApiServerConfig property is set.
        /// </summary>
        internal bool IsSetKubeApiServerConfig() => this.KubeApiServerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeControllerManagerConfig. 
        /// <para>
        /// The Kubernetes controller manager configuration defaults and constraints.
        /// </para>
        /// </summary>
        public KubeControllerManagerVersionConfig KubeControllerManagerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeControllerManagerConfig property is set.
        /// </summary>
        internal bool IsSetKubeControllerManagerConfig() => this.KubeControllerManagerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeSchedulerConfig. 
        /// <para>
        /// The Kubernetes scheduler configuration defaults and constraints.
        /// </para>
        /// </summary>
        public KubeSchedulerVersionConfig KubeSchedulerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeSchedulerConfig property is set.
        /// </summary>
        internal bool IsSetKubeSchedulerConfig() => this.KubeSchedulerConfig != null;
    }
}
