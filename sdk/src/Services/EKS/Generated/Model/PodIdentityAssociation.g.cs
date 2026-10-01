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
    /// Amazon EKS Pod Identity associations provide the ability to manage credentials for
    /// your applications, similar to the way that Amazon EC2 instance profiles provide credentials
    /// to Amazon EC2 instances.
    /// </summary>
    public partial class PodIdentityAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        public string AssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociationArn property is set.
        /// </summary>
        internal bool IsSetAssociationArn() => this.AssociationArn != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the association is in.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp that the association was created at.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisableSessionTags. 
        /// <para>
        /// The state of the automatic sessions tags. The value of <i>true</i> disables these
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// EKS Pod Identity adds a pre-defined set of session tags when it assumes the role.
        /// You can use these tags to author a single role that can work across resources by allowing
        /// access to Amazon Web Services resources based on matching tags. By default, EKS Pod
        /// Identity attaches six tags, including tags for cluster name, namespace, and service
        /// account name. For the list of tags added by EKS Pod Identity, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-id-abac.html#pod-id-abac-tags">List
        /// of session tags added by EKS Pod Identity</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? DisableSessionTags { get; set; }

        /// <summary>
        /// Checks to see if the DisableSessionTags property is set.
        /// </summary>
        internal bool IsSetDisableSessionTags() => this.DisableSessionTags.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The unique identifier for this EKS Pod Identity association for a target IAM role.
        /// You put this value in the trust policy of the target role, in a <c>Condition</c> to
        /// match the <c>sts.ExternalId</c>. This ensures that the target role can only be assumed
        /// by this association. This prevents the <i>confused deputy problem</i>. For more information
        /// about the confused deputy problem, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/confused-deputy.html">The
        /// confused deputy problem</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to use the same target role with multiple associations or other roles,
        /// use independent statements in the trust policy to allow <c>sts:AssumeRole</c> access
        /// from each role.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The most recent timestamp that the association was modified at.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster to create the association
        /// in. The service account and the Pods that use the service account must be in this
        /// namespace.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// If defined, the EKS Pod Identity association is owned by an Amazon EKS add-on.
        /// </para>
        /// </summary>
        public string OwnerArn { get; set; }

        /// <summary>
        /// Checks to see if the OwnerArn property is set.
        /// </summary>
        internal bool IsSetOwnerArn() => this.OwnerArn != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An optional IAM policy in JSON format (as an escaped string) that applies additional
        /// restrictions to this pod identity association beyond the IAM policies attached to
        /// the IAM role. This policy is applied as the intersection of the role's policies and
        /// this policy, allowing you to reduce the permissions that applications in the pods
        /// can use. Use this policy to enforce least privilege access while still leveraging
        /// a shared IAM role across multiple applications.
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the service account.
        /// The EKS Pod Identity agent manages credentials to assume this role for applications
        /// in the containers in the Pods that use this service account.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account inside the cluster to associate the IAM
        /// credentials with.
        /// </para>
        /// </summary>
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccount property is set.
        /// </summary>
        internal bool IsSetServiceAccount() => this.ServiceAccount != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource – 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length – 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length – 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target IAM role to associate with the service
        /// account. This role is assumed by using the EKS Pod Identity association role, then
        /// the credentials for this role are injected into the Pod.
        /// </para>
        /// </summary>
        public string TargetRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetRoleArn property is set.
        /// </summary>
        internal bool IsSetTargetRoleArn() => this.TargetRoleArn != null;
    }
}
