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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
    /// The configuration for the Kubernetes controller manager on an Amazon EKS cluster.
    /// </summary>
    public partial class KubeControllerManagerConfigRequest
    {
        private HorizontalPodAutoscalerControllerConfigRequest _horizontalPodAutoscalerControllerConfig;
        private PodGcControllerConfigRequest _podGcControllerConfig;

        /// <summary>
        /// Gets and sets the property HorizontalPodAutoscalerControllerConfig. 
        /// <para>
        /// The horizontal pod autoscaler controller configuration.
        /// </para>
        /// </summary>
        public HorizontalPodAutoscalerControllerConfigRequest HorizontalPodAutoscalerControllerConfig
        {
            get { return this._horizontalPodAutoscalerControllerConfig; }
            set { this._horizontalPodAutoscalerControllerConfig = value; }
        }

        // Check to see if HorizontalPodAutoscalerControllerConfig property is set
        internal bool IsSetHorizontalPodAutoscalerControllerConfig()
        {
            return this._horizontalPodAutoscalerControllerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PodGcControllerConfig. 
        /// <para>
        /// The pod garbage collection controller configuration.
        /// </para>
        /// </summary>
        public PodGcControllerConfigRequest PodGcControllerConfig
        {
            get { return this._podGcControllerConfig; }
            set { this._podGcControllerConfig = value; }
        }

        // Check to see if PodGcControllerConfig property is set
        internal bool IsSetPodGcControllerConfig()
        {
            return this._podGcControllerConfig != null;
        }

    }
}