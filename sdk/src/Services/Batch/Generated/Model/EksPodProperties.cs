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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The properties for the pod.
    /// </summary>
    public partial class EksPodProperties
    {
        private List<EksContainer> _containers = AWSConfigs.InitializeCollections ? new List<EksContainer>() : null;
        private string _dnsPolicy;
        private bool? _hostNetwork;
        private List<ImagePullSecret> _imagePullSecrets = AWSConfigs.InitializeCollections ? new List<ImagePullSecret>() : null;
        private List<EksContainer> _initContainers = AWSConfigs.InitializeCollections ? new List<EksContainer>() : null;
        private EksMetadata _metadata;
        private string _serviceAccountName;
        private bool? _shareProcessNamespace;
        private List<EksVolume> _volumes = AWSConfigs.InitializeCollections ? new List<EksVolume>() : null;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The properties of the container that's used on the Amazon EKS pod.
        /// </para>
        ///  <note> 
        /// <para>
        /// This object is limited to 10 elements.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainer> Containers
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
        /// Gets and sets the property DnsPolicy. 
        /// <para>
        /// The DNS policy for the pod. The default value is <c>ClusterFirst</c>. If the <c>hostNetwork</c>
        /// parameter is not specified, the default is <c>ClusterFirstWithHostNet</c>. <c>ClusterFirst</c>
        /// indicates that any DNS query that does not match the configured cluster domain suffix
        /// is forwarded to the upstream nameserver inherited from the node. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/#pod-s-dns-policy">Pod's
        /// DNS policy</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Default</c> | <c>ClusterFirst</c> | <c>ClusterFirstWithHostNet</c>
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
        /// Indicates if the pod uses the hosts' network IP address. The default value is <c>true</c>.
        /// Setting this to <c>false</c> enables the Kubernetes pod networking model. Most Batch
        /// workloads are egress-only and don't require the overhead of IP allocation for each
        /// pod for incoming connections. For more information, see <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#host-namespaces">Host
        /// namespaces</a> and <a href="https://kubernetes.io/docs/concepts/workloads/pods/#pod-networking">Pod
        /// networking</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool? HostNetwork
        {
            get { return this._hostNetwork; }
            set { this._hostNetwork = value; }
        }

        // Check to see if HostNetwork property is set
        internal bool IsSetHostNetwork()
        {
            return this._hostNetwork.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImagePullSecrets. 
        /// <para>
        /// References a Kubernetes secret resource. It holds a list of secrets. These secrets
        /// help to gain access to pull an images from a private registry.
        /// </para>
        ///  
        /// <para>
        ///  <c>ImagePullSecret$name</c> is required when this object is used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImagePullSecret> ImagePullSecrets
        {
            get { return this._imagePullSecrets; }
            set { this._imagePullSecrets = value; }
        }

        // Check to see if ImagePullSecrets property is set
        internal bool IsSetImagePullSecrets()
        {
            return this._imagePullSecrets != null && (this._imagePullSecrets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitContainers. 
        /// <para>
        /// These containers run before application containers, always runs to completion, and
        /// must complete successfully before the next container starts. These containers are
        /// registered with the Amazon EKS Connector agent and persists the registration information
        /// in the Kubernetes backend data store. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/pods/init-containers/">Init
        /// Containers</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This object is limited to 10 elements.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainer> InitContainers
        {
            get { return this._initContainers; }
            set { this._initContainers = value; }
        }

        // Check to see if InitContainers property is set
        internal bool IsSetInitContainers()
        {
            return this._initContainers != null && (this._initContainers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the Kubernetes pod. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/">Understanding
        /// Kubernetes Objects</a> in the <i>Kubernetes documentation</i>.
        /// </para>
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
        /// Gets and sets the property ShareProcessNamespace. 
        /// <para>
        /// Indicates if the processes in a container are shared, or visible, to other containers
        /// in the same pod. For more information, see <a href="https://kubernetes.io/docs/tasks/configure-pod-container/share-process-namespace/">Share
        /// Process Namespace between Containers in a Pod</a>.
        /// </para>
        /// </summary>
        public bool? ShareProcessNamespace
        {
            get { return this._shareProcessNamespace; }
            set { this._shareProcessNamespace = value; }
        }

        // Check to see if ShareProcessNamespace property is set
        internal bool IsSetShareProcessNamespace()
        {
            return this._shareProcessNamespace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Specifies the volumes for a job definition that uses Amazon EKS resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksVolume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}