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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The properties for the pod.
    /// </summary>
    public partial class EksPodProperties
    {
        private List<EksContainer> _containers = new List<EksContainer>();
        private string _dnsPolicy;
        private bool? _hostNetwork;
        private EksMetadata _metadata;
        private string _serviceAccountName;
        private List<EksVolume> _volumes = new List<EksVolume>();

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The properties of the container that's used on the Amazon EKS pod.
        /// </para>
        /// </summary>
        public List<EksContainer> Containers
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
        /// Gets and sets the property DnsPolicy. 
        /// <para>
        /// The DNS policy for the pod. The default value is <code>ClusterFirst</code>. If the
        /// <code>hostNetwork</code> parameter is not specified, the default is <code>ClusterFirstWithHostNet</code>.
        /// <code>ClusterFirst</code> indicates that any DNS query that does not match the configured
        /// cluster domain suffix is forwarded to the upstream nameserver inherited from the node.
        /// For more information, see <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/#pod-s-dns-policy">Pod's
        /// DNS policy</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>Default</code> | <code>ClusterFirst</code> | <code>ClusterFirstWithHostNet</code>
        /// 
        /// </para>
        /// </summary>
        public string DnsPolicy
        {
            get { return this._dnsPolicy; }
            set { this._dnsPolicy = value; }
        }

        // Check to see if DnsPolicy property is set
        internal bool IsSetDnsPolicy()
        {
            return this._dnsPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property HostNetwork. 
        /// <para>
        /// Indicates if the pod uses the hosts' network IP address. The default value is <code>true</code>.
        /// Setting this to <code>false</code> enables the Kubernetes pod networking model. Most
        /// Batch workloads are egress-only and don't require the overhead of IP allocation for
        /// each pod for incoming connections. For more information, see <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#host-namespaces">Host
        /// namespaces</a> and <a href="https://kubernetes.io/docs/concepts/workloads/pods/#pod-networking">Pod
        /// networking</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool HostNetwork
        {
            get { return this._hostNetwork.GetValueOrDefault(); }
            set { this._hostNetwork = value; }
        }

        // Check to see if HostNetwork property is set
        internal bool IsSetHostNetwork()
        {
            return this._hostNetwork.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata.
        /// </summary>
        public EksMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountName. 
        /// <para>
        /// The name of the service account that's used to run the pod. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service-accounts.html">Kubernetes
        /// service accounts</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/associate-service-account-role.html">Configure
        /// a Kubernetes service account to assume an IAM role</a> in the <i>Amazon EKS User Guide</i>
        /// and <a href="https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/">Configure
        /// service accounts for pods</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public string ServiceAccountName
        {
            get { return this._serviceAccountName; }
            set { this._serviceAccountName = value; }
        }

        // Check to see if ServiceAccountName property is set
        internal bool IsSetServiceAccountName()
        {
            return this._serviceAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Specifies the volumes for a job definition that uses Amazon EKS resources.
        /// </para>
        /// </summary>
        public List<EksVolume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && this._volumes.Count > 0; 
        }

    }
}