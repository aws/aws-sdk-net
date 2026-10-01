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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Meta data about Kubernetes resources.
    /// </summary>
    public partial class KubernetesMetadata
    {
        /// <summary>
        /// Gets and sets the property LocalPodName. 
        /// <para>
        /// The name of the pod for a local resource.
        /// </para>
        /// </summary>
        public string LocalPodName { get; set; }

        /// <summary>
        /// Checks to see if the LocalPodName property is set.
        /// </summary>
        internal bool IsSetLocalPodName() => this.LocalPodName != null;

        /// <summary>
        /// Gets and sets the property LocalPodNamespace. 
        /// <para>
        /// The namespace of the pod for a local resource.
        /// </para>
        /// </summary>
        public string LocalPodNamespace { get; set; }

        /// <summary>
        /// Checks to see if the LocalPodNamespace property is set.
        /// </summary>
        internal bool IsSetLocalPodNamespace() => this.LocalPodNamespace != null;

        /// <summary>
        /// Gets and sets the property LocalServiceName. 
        /// <para>
        /// The service name for a local resource.
        /// </para>
        /// </summary>
        public string LocalServiceName { get; set; }

        /// <summary>
        /// Checks to see if the LocalServiceName property is set.
        /// </summary>
        internal bool IsSetLocalServiceName() => this.LocalServiceName != null;

        /// <summary>
        /// Gets and sets the property RemotePodName. 
        /// <para>
        /// The name of the pod for a remote resource.
        /// </para>
        /// </summary>
        public string RemotePodName { get; set; }

        /// <summary>
        /// Checks to see if the RemotePodName property is set.
        /// </summary>
        internal bool IsSetRemotePodName() => this.RemotePodName != null;

        /// <summary>
        /// Gets and sets the property RemotePodNamespace. 
        /// <para>
        /// The namespace of the pod for a remote resource.
        /// </para>
        /// </summary>
        public string RemotePodNamespace { get; set; }

        /// <summary>
        /// Checks to see if the RemotePodNamespace property is set.
        /// </summary>
        internal bool IsSetRemotePodNamespace() => this.RemotePodNamespace != null;

        /// <summary>
        /// Gets and sets the property RemoteServiceName. 
        /// <para>
        /// The service name for a remote resource.
        /// </para>
        /// </summary>
        public string RemoteServiceName { get; set; }

        /// <summary>
        /// Checks to see if the RemoteServiceName property is set.
        /// </summary>
        internal bool IsSetRemoteServiceName() => this.RemoteServiceName != null;
    }
}
