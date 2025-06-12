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
    /// Container for the parameters to the CreateAccessEntry operation.
    /// Creates an access entry.
    /// 
    ///  
    /// <para>
    /// An access entry allows an IAM principal to access your cluster. Access entries can
    /// replace the need to maintain entries in the <c>aws-auth</c> <c>ConfigMap</c> for authentication.
    /// You have the following options for authorizing an IAM principal to access Kubernetes
    /// objects on your cluster: Kubernetes role-based access control (RBAC), Amazon EKS,
    /// or both. Kubernetes RBAC authorization requires you to create and manage Kubernetes
    /// <c>Role</c>, <c>ClusterRole</c>, <c>RoleBinding</c>, and <c>ClusterRoleBinding</c>
    /// objects, in addition to managing access entries. If you use Amazon EKS authorization
    /// exclusively, you don't need to create and manage Kubernetes <c>Role</c>, <c>ClusterRole</c>,
    /// <c>RoleBinding</c>, and <c>ClusterRoleBinding</c> objects.
    /// </para>
    ///  
    /// <para>
    /// For more information about access entries, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html">Access
    /// entries</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAccessEntryRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private List<string> _kubernetesGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _principalArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _type;
        private string _username;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
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
        /// The name of your cluster.
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
        /// Gets and sets the property KubernetesGroups. 
        /// <para>
        /// The value for <c>name</c> that you've specified for <c>kind: Group</c> as a <c>subject</c>
        /// in a Kubernetes <c>RoleBinding</c> or <c>ClusterRoleBinding</c> object. Amazon EKS
        /// doesn't confirm that the value for <c>name</c> exists in any bindings on your cluster.
        /// You can specify one or more names.
        /// </para>
        ///  
        /// <para>
        /// Kubernetes authorizes the <c>principalArn</c> of the access entry to access any cluster
        /// objects that you've specified in a Kubernetes <c>Role</c> or <c>ClusterRole</c> object
        /// that is also specified in a binding's <c>roleRef</c>. For more information about creating
        /// Kubernetes <c>RoleBinding</c>, <c>ClusterRoleBinding</c>, <c>Role</c>, or <c>ClusterRole</c>
        /// objects, see <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Using
        /// RBAC Authorization in the Kubernetes documentation</a>.
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon EKS to authorize the <c>principalArn</c> (instead of, or in addition
        /// to Kubernetes authorizing the <c>principalArn</c>), you can associate one or more
        /// access policies to the access entry using <c>AssociateAccessPolicy</c>. If you associate
        /// any access policies, the <c>principalARN</c> has all permissions assigned in the associated
        /// access policies and all permissions in any Kubernetes <c>Role</c> or <c>ClusterRole</c>
        /// objects that the group names are bound to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KubernetesGroups
        {
            get { return this._kubernetesGroups; }
            set { this._kubernetesGroups = value; }
        }

        // Check to see if KubernetesGroups property is set
        internal bool IsSetKubernetesGroups()
        {
            return this._kubernetesGroups != null && (this._kubernetesGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal for the <c>AccessEntry</c>. You can specify one ARN for
        /// each access entry. You can't specify the same ARN in more than one access entry. This
        /// value can't be changed after access entry creation.
        /// </para>
        ///  
        /// <para>
        /// The valid principals differ depending on the type of the access entry in the <c>type</c>
        /// field. For <c>STANDARD</c> access entries, you can use every IAM principal type. For
        /// nodes (<c>EC2</c> (for EKS Auto Mode), <c>EC2_LINUX</c>, <c>EC2_WINDOWS</c>, <c>FARGATE_LINUX</c>,
        /// and <c>HYBRID_LINUX</c>), the only valid ARN is IAM roles. You can't use the STS session
        /// principal type with access entries because this is a temporary principal for each
        /// session and not a permanent identity that can be assigned permissions.
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#bp-users-federation-idp">IAM
        /// best practices</a> recommend using IAM roles with temporary credentials, rather than
        /// IAM users with long-term credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
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
        /// The type of the new access entry. Valid values are <c>STANDARD</c>, <c>FARGATE_LINUX</c>,
        /// <c>EC2_LINUX</c>, <c>EC2_WINDOWS</c>, <c>EC2</c> (for EKS Auto Mode), <c>HYBRID_LINUX</c>,
        /// and <c>HYPERPOD_LINUX</c>. 
        /// </para>
        ///  
        /// <para>
        /// If the <c>principalArn</c> is for an IAM role that's used for self-managed Amazon
        /// EC2 nodes, specify <c>EC2_LINUX</c> or <c>EC2_WINDOWS</c>. Amazon EKS grants the necessary
        /// permissions to the node for you. If the <c>principalArn</c> is for any other purpose,
        /// specify <c>STANDARD</c>. If you don't specify a value, Amazon EKS sets the value to
        /// <c>STANDARD</c>. If you have the access mode of the cluster set to <c>API_AND_CONFIG_MAP</c>,
        /// it's unnecessary to create access entries for IAM roles used with Fargate profiles
        /// or managed Amazon EC2 nodes, because Amazon EKS creates entries in the <c>aws-auth</c>
        /// <c>ConfigMap</c> for the roles. You can't change this value once you've created the
        /// access entry.
        /// </para>
        ///  
        /// <para>
        /// If you set the value to <c>EC2_LINUX</c> or <c>EC2_WINDOWS</c>, you can't specify
        /// values for <c>kubernetesGroups</c>, or associate an <c>AccessPolicy</c> to the access
        /// entry.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username to authenticate to Kubernetes with. We recommend not specifying a username
        /// and letting Amazon EKS specify it for you. For more information about the value Amazon
        /// EKS specifies for you, or constraints before specifying your own username, see <a
        /// href="https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html#creating-access-entries">Creating
        /// access entries</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}