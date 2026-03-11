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
    /// Container for the parameters to the CreateCapability operation.
    /// Creates a managed capability resource for an Amazon EKS cluster.
    /// 
    ///  
    /// <para>
    /// Capabilities provide fully managed capabilities to build and scale with Kubernetes.
    /// When you create a capability, Amazon EKSprovisions and manages the infrastructure
    /// required to run the capability outside of your cluster. This approach reduces operational
    /// overhead and preserves cluster resources.
    /// </para>
    ///  
    /// <para>
    /// You can only create one Capability of each type on a given Amazon EKS cluster. Valid
    /// types are Argo CD for declarative GitOps deployment, Amazon Web Services Controllers
    /// for Kubernetes (ACK) for resource management, and Kube Resource Orchestrator (KRO)
    /// for Kubernetes custom resource orchestration.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/capabilities.html">EKS
    /// Capabilities</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCapabilityRequest : AmazonEKSRequest
    {
        private string _capabilityName;
        private string _clientRequestToken;
        private string _clusterName;
        private CapabilityConfigurationRequest _configuration;
        private CapabilityDeletePropagationPolicy _deletePropagationPolicy;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CapabilityType _type;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// A unique name for the capability. The name must be unique within your cluster and
        /// can contain alphanumeric characters, hyphens, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapabilityName
        {
            get { return this._capabilityName; }
            set { this._capabilityName = value; }
        }

        // Check to see if CapabilityName property is set
        internal bool IsSetCapabilityName()
        {
            return this._capabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is valid for 24 hours after creation. If you retry a request
        /// with the same client request token and the same parameters after the original request
        /// has completed successfully, the result of the original request is returned.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster where you want to create the capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the capability. The structure of this object varies
        /// depending on the capability type. For Argo CD capabilities, you can configure IAM
        /// Identity CenterIAM; Identity Center integration, RBAC role mappings, and network access
        /// settings.
        /// </para>
        /// </summary>
        public CapabilityConfigurationRequest Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DeletePropagationPolicy. 
        /// <para>
        /// Specifies how Kubernetes resources managed by the capability should be handled when
        /// the capability is deleted. Currently, the only supported value is <c>RETAIN</c> which
        /// retains all Kubernetes resources managed by the capability when the capability is
        /// deleted.
        /// </para>
        ///  
        /// <para>
        /// Because resources are retained, all Kubernetes resources created by the capability
        /// should be deleted from the cluster before deleting the capability itself. After the
        /// capability is deleted, these resources become difficult to manage because the controller
        /// is no longer available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapabilityDeletePropagationPolicy DeletePropagationPolicy
        {
            get { return this._deletePropagationPolicy; }
            set { this._deletePropagationPolicy = value; }
        }

        // Check to see if DeletePropagationPolicy property is set
        internal bool IsSetDeletePropagationPolicy()
        {
            return this._deletePropagationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the capability uses to interact
        /// with Amazon Web Services services. This role must have a trust policy that allows
        /// the EKS service principal to assume it, and it must have the necessary permissions
        /// for the capability type you're creating.
        /// </para>
        ///  
        /// <para>
        /// For ACK capabilities, the role needs permissions to manage the resources you want
        /// to control through Kubernetes. For Argo CD capabilities, the role needs permissions
        /// to access Git repositories and Secrets Manager. For KRO capabilities, the role needs
        /// permissions based on the resources you'll be orchestrating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of capability to create. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACK</c> – Amazon Web Services Controllers for Kubernetes (ACK), which lets you
        /// manage resources directly from Kubernetes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARGOCD</c> – Argo CD for GitOps-based continuous delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KRO</c> – Kube Resource Orchestrator (KRO) for composing and managing custom Kubernetes
        /// resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapabilityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}