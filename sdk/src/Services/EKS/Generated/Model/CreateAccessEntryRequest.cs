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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessEntry operation.
    /// Creates an access entry.
    /// 
    ///  
    /// <para>
    /// An access entry allows an IAM principal to access your cluster. Access entries can
    /// replace the need to maintain entries in the <code>aws-auth</code> <code>ConfigMap</code>
    /// for authentication. You have the following options for authorizing an IAM principal
    /// to access Kubernetes objects on your cluster: Kubernetes role-based access control
    /// (RBAC), Amazon EKS, or both. Kubernetes RBAC authorization requires you to create
    /// and manage Kubernetes <code>Role</code>, <code>ClusterRole</code>, <code>RoleBinding</code>,
    /// and <code>ClusterRoleBinding</code> objects, in addition to managing access entries.
    /// If you use Amazon EKS authorization exclusively, you don't need to create and manage
    /// Kubernetes <code>Role</code>, <code>ClusterRole</code>, <code>RoleBinding</code>,
    /// and <code>ClusterRoleBinding</code> objects.
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
        private List<string> _kubernetesGroups = new List<string>();
        private string _principalArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
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
        /// The value for <code>name</code> that you've specified for <code>kind: Group</code>
        /// as a <code>subject</code> in a Kubernetes <code>RoleBinding</code> or <code>ClusterRoleBinding</code>
        /// object. Amazon EKS doesn't confirm that the value for <code>name</code> exists in
        /// any bindings on your cluster. You can specify one or more names.
        /// </para>
        ///  
        /// <para>
        /// Kubernetes authorizes the <code>principalArn</code> of the access entry to access
        /// any cluster objects that you've specified in a Kubernetes <code>Role</code> or <code>ClusterRole</code>
        /// object that is also specified in a binding's <code>roleRef</code>. For more information
        /// about creating Kubernetes <code>RoleBinding</code>, <code>ClusterRoleBinding</code>,
        /// <code>Role</code>, or <code>ClusterRole</code> objects, see <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Using
        /// RBAC Authorization in the Kubernetes documentation</a>.
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon EKS to authorize the <code>principalArn</code> (instead of, or
        /// in addition to Kubernetes authorizing the <code>principalArn</code>), you can associate
        /// one or more access policies to the access entry using <code>AssociateAccessPolicy</code>.
        /// If you associate any access policies, the <code>principalARN</code> has all permissions
        /// assigned in the associated access policies and all permissions in any Kubernetes <code>Role</code>
        /// or <code>ClusterRole</code> objects that the group names are bound to.
        /// </para>
        /// </summary>
        public List<string> KubernetesGroups
        {
            get { return this._kubernetesGroups; }
            set { this._kubernetesGroups = value; }
        }

        // Check to see if KubernetesGroups property is set
        internal bool IsSetKubernetesGroups()
        {
            return this._kubernetesGroups != null && this._kubernetesGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal for the <code>AccessEntry</code>. You can specify one
        /// ARN for each access entry. You can't specify the same ARN in more than one access
        /// entry. This value can't be changed after access entry creation.
        /// </para>
        ///  
        /// <para>
        /// The valid principals differ depending on the type of the access entry in the <code>type</code>
        /// field. The only valid ARN is IAM roles for the types of access entries for nodes:
        /// <code/> <code/>. You can use every IAM principal type for <code>STANDARD</code> access
        /// entries. You can't use the STS session principal type with access entries because
        /// this is a temporary principal for each session and not a permanent identity that can
        /// be assigned permissions.
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the new access entry. Valid values are <code>Standard</code>, <code>FARGATE_LINUX</code>,
        /// <code>EC2_LINUX</code>, and <code>EC2_WINDOWS</code>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>principalArn</code> is for an IAM role that's used for self-managed Amazon
        /// EC2 nodes, specify <code>EC2_LINUX</code> or <code>EC2_WINDOWS</code>. Amazon EKS
        /// grants the necessary permissions to the node for you. If the <code>principalArn</code>
        /// is for any other purpose, specify <code>STANDARD</code>. If you don't specify a value,
        /// Amazon EKS sets the value to <code>STANDARD</code>. It's unnecessary to create access
        /// entries for IAM roles used with Fargate profiles or managed Amazon EC2 nodes, because
        /// Amazon EKS creates entries in the <code>aws-auth</code> <code>ConfigMap</code> for
        /// the roles. You can't change this value once you've created the access entry.
        /// </para>
        ///  
        /// <para>
        /// If you set the value to <code>EC2_LINUX</code> or <code>EC2_WINDOWS</code>, you can't
        /// specify values for <code>kubernetesGroups</code>, or associate an <code>AccessPolicy</code>
        /// to the access entry.
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