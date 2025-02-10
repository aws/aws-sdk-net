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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
        private string _localPodName;
        private string _localPodNamespace;
        private string _localServiceName;
        private string _remotePodName;
        private string _remotePodNamespace;
        private string _remoteServiceName;

        /// <summary>
        /// Gets and sets the property LocalPodName. 
        /// <para>
        /// The name of the pod for a local resource.
        /// </para>
        /// </summary>
        public string LocalPodName
        {
            get { return this._localPodName; }
            set { this._localPodName = value; }
        }

        // Check to see if LocalPodName property is set
        internal bool IsSetLocalPodName()
        {
            return this._localPodName != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPodNamespace. 
        /// <para>
        /// The namespace of the pod for a local resource.
        /// </para>
        /// </summary>
        public string LocalPodNamespace
        {
            get { return this._localPodNamespace; }
            set { this._localPodNamespace = value; }
        }

        // Check to see if LocalPodNamespace property is set
        internal bool IsSetLocalPodNamespace()
        {
            return this._localPodNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property LocalServiceName. 
        /// <para>
        /// The service name for a local resource.
        /// </para>
        /// </summary>
        public string LocalServiceName
        {
            get { return this._localServiceName; }
            set { this._localServiceName = value; }
        }

        // Check to see if LocalServiceName property is set
        internal bool IsSetLocalServiceName()
        {
            return this._localServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property RemotePodName. 
        /// <para>
        /// The name of the pod for a remote resource.
        /// </para>
        /// </summary>
        public string RemotePodName
        {
            get { return this._remotePodName; }
            set { this._remotePodName = value; }
        }

        // Check to see if RemotePodName property is set
        internal bool IsSetRemotePodName()
        {
            return this._remotePodName != null;
        }

        /// <summary>
        /// Gets and sets the property RemotePodNamespace. 
        /// <para>
        /// The namespace of the pod for a remote resource.
        /// </para>
        /// </summary>
        public string RemotePodNamespace
        {
            get { return this._remotePodNamespace; }
            set { this._remotePodNamespace = value; }
        }

        // Check to see if RemotePodNamespace property is set
        internal bool IsSetRemotePodNamespace()
        {
            return this._remotePodNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteServiceName. 
        /// <para>
        /// The service name for a remote resource.
        /// </para>
        /// </summary>
        public string RemoteServiceName
        {
            get { return this._remoteServiceName; }
            set { this._remoteServiceName = value; }
        }

        // Check to see if RemoteServiceName property is set
        internal bool IsSetRemoteServiceName()
        {
            return this._remoteServiceName != null;
        }

    }
}