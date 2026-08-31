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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The details for the pod.
    /// </summary>
    public partial class EksPodPropertiesDetail
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The properties of the container that's used on the Amazon EKS pod.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainerDetail> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<EksContainerDetail>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsPolicy. 
        /// <para>
        /// The DNS policy for the pod. The default value is <c>ClusterFirst</c>. If the <c>hostNetwork</c>
        /// parameter is not specified, the default is <c>ClusterFirstWithHostNet</c>. <c>ClusterFirst</c>
        /// indicates that any DNS query that does not match the configured cluster domain suffix
        /// is forwarded to the upstream nameserver inherited from the node. If no value was specified
        /// for <c>dnsPolicy</c> in the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html">RegisterJobDefinition</a>
        /// API operation, then no value will be returned for <c>dnsPolicy</c> by either of <a
        /// href="https://docs.aws.amazon.com/batch/latest/APIReference/API_DescribeJobDefinitions.html">DescribeJobDefinitions</a>
        /// or <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_DescribeJobs.html">DescribeJobs</a>
        /// API operations. The pod spec setting will contain either <c>ClusterFirst</c> or <c>ClusterFirstWithHostNet</c>,
        /// depending on the value of the <c>hostNetwork</c> parameter. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/#pod-s-dns-policy">Pod's
        /// DNS policy</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Default</c> | <c>ClusterFirst</c> | <c>ClusterFirstWithHostNet</c>
        /// 
        /// </para>
        /// </summary>
        public string DnsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DnsPolicy property is set.
        /// </summary>
        internal bool IsSetDnsPolicy() => this.DnsPolicy != null;

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
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Checks to see if the HostNetwork property is set.
        /// </summary>
        internal bool IsSetHostNetwork() => this.HostNetwork.HasValue;

        /// <summary>
        /// Gets and sets the property ImagePullSecrets. 
        /// <para>
        /// Displays the reference pointer to the Kubernetes secret resource. These secrets help
        /// to gain access to pull an images from a private registry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImagePullSecret> ImagePullSecrets { get; set; } = AWSConfigs.InitializeCollections ? new List<ImagePullSecret>() : null;

        /// <summary>
        /// Checks to see if the ImagePullSecrets property is set.
        /// </summary>
        internal bool IsSetImagePullSecrets() => this.ImagePullSecrets != null && (this.ImagePullSecrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitContainers. 
        /// <para>
        /// The container registered with the Amazon EKS Connector agent and persists the registration
        /// information in the Kubernetes backend data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainerDetail> InitContainers { get; set; } = AWSConfigs.InitializeCollections ? new List<EksContainerDetail>() : null;

        /// <summary>
        /// Checks to see if the InitContainers property is set.
        /// </summary>
        internal bool IsSetInitContainers() => this.InitContainers != null && (this.InitContainers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Describes and uniquely identifies Kubernetes resources. For example, the compute environment
        /// that a pod runs in or the <c>jobID</c> for a job running in the pod. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/">Understanding
        /// Kubernetes Objects</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node for this job.
        /// </para>
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property PodName. 
        /// <para>
        /// The name of the pod for this job.
        /// </para>
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// Checks to see if the PodName property is set.
        /// </summary>
        internal bool IsSetPodName() => this.PodName != null;

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
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountName property is set.
        /// </summary>
        internal bool IsSetServiceAccountName() => this.ServiceAccountName != null;

        /// <summary>
        /// Gets and sets the property ShareProcessNamespace. 
        /// <para>
        /// Indicates if the processes in a container are shared, or visible, to other containers
        /// in the same pod. For more information, see <a href="https://kubernetes.io/docs/tasks/configure-pod-container/share-process-namespace/">Share
        /// Process Namespace between Containers in a Pod</a>.
        /// </para>
        /// </summary>
        public bool? ShareProcessNamespace { get; set; }

        /// <summary>
        /// Checks to see if the ShareProcessNamespace property is set.
        /// </summary>
        internal bool IsSetShareProcessNamespace() => this.ShareProcessNamespace.HasValue;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Specifies the volumes for a job definition using Amazon EKS resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksVolume> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<EksVolume>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
