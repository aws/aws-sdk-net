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
    /// Container for the parameters to the CreatePodIdentityAssociation operation. Creates
    /// an EKS Pod Identity association between a service account in an Amazon EKS cluster
    /// and an IAM role with <i>EKS Pod Identity</i>. Use EKS Pod Identity to give temporary
    /// IAM credentials to Pods and the credentials are rotated automatically. <para> Amazon
    /// EKS Pod Identity associations provide the ability to manage credentials for your applications,
    /// similar to the way that Amazon EC2 instance profiles provide credentials to Amazon
    /// EC2 instances. </para> <para> If a Pod uses a service account that has an association,
    /// Amazon EKS sets environment variables in the containers of the Pod. The environment
    /// variables configure the Amazon Web Services SDKs, including the Command Line Interface,
    /// to use the EKS Pod Identity credentials. </para> <para> EKS Pod Identity is a simpler
    /// method than <i>IAM roles for service accounts</i>, as this method doesn't use OIDC
    /// identity providers. Additionally, you can configure a role for EKS Pod Identity once,
    /// and reuse it across clusters. </para> <para> Similar to Amazon Web Services IAM behavior,
    /// EKS Pod Identity associations are eventually consistent, and may take several seconds
    /// to be effective after the initial API call returns successfully. You must design your
    /// applications to account for these potential delays. We recommend that you don’t include
    /// association create/updates in the critical, high-availability code paths of your application.
    /// Instead, make changes in a separate initialization or setup routine that you run less
    /// frequently. </para> <para> You can set a <i>target IAM role</i> in the same or a different
    /// account for advanced scenarios. With a target role, EKS Pod Identity automatically
    /// performs two role assumptions in sequence: first assuming the role in the association
    /// that is in this account, then using those credentials to assume the target IAM role.
    /// This process provides your Pod with temporary credentials that have the permissions
    /// defined in the target role, allowing secure access to resources in another Amazon
    /// Web Services account. </para>
    /// </summary>
    public partial class CreatePodIdentityAssociationRequest : AmazonEKSRequest
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
        /// The name of the cluster to create the EKS Pod Identity association in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property DisableSessionTags. 
        /// <para>
        /// Disable the automatic sessions tags that are appended by EKS Pod Identity.
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
        ///  
        /// <para>
        /// Amazon Web Services compresses inline session policies, managed policy ARNs, and session
        /// tags into a packed binary format that has a separate limit. If you receive a <c>PackedPolicyTooLarge</c>
        /// error indicating the packed binary format has exceeded the size limit, you can attempt
        /// to reduce the size by disabling the session tags added by EKS Pod Identity.
        /// </para>
        /// </summary>
        public bool? DisableSessionTags { get; set; }

        /// <summary>
        /// Checks to see if the DisableSessionTags property is set.
        /// </summary>
        internal bool IsSetDisableSessionTags() => this.DisableSessionTags.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster to create the EKS Pod Identity
        /// association in. The service account and the Pods that use the service account must
        /// be in this namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

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
        ///  
        /// <para>
        ///  <b>Important considerations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Session tags:</b> When using this policy, <c>disableSessionTags</c> must be set
        /// to <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Target role permissions:</b> If you specify both a <c>TargetRoleArn</c> and a
        /// policy, the policy restrictions apply only to the target role's permissions, not to
        /// the initial role used for assuming the target role.
        /// </para>
        ///  </li> </ul>
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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
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
        ///  
        /// <para>
        /// When you run applications on Amazon EKS, your application might need to access Amazon
        /// Web Services resources from a different role that exists in the same or different
        /// Amazon Web Services account. For example, your application running in “Account A”
        /// might need to access resources, such as Amazon S3 buckets in “Account B” or within
        /// “Account A” itself. You can create a association to access Amazon Web Services resources
        /// in “Account B” by creating two IAM roles: a role in “Account A” and a role in “Account
        /// B” (which can be the same or different account), each with the necessary trust and
        /// permission policies. After you provide these roles in the <i>IAM role</i> and <i>Target
        /// IAM role</i> fields, EKS will perform role chaining to ensure your application gets
        /// the required permissions. This means Role A will assume Role B, allowing your Pods
        /// to securely access resources like S3 buckets in the target account.
        /// </para>
        /// </summary>
        public string TargetRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetRoleArn property is set.
        /// </summary>
        internal bool IsSetTargetRoleArn() => this.TargetRoleArn != null;
    }
}
