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
    /// Container for the parameters to the UpdateAccessEntry operation. Updates an access
    /// entry.
    /// </summary>
    public partial class UpdateAccessEntryRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KubernetesGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KubernetesGroups property is set.
        /// </summary>
        internal bool IsSetKubernetesGroups() => this.KubernetesGroups != null && (this.KubernetesGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal for the <c>AccessEntry</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

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
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
