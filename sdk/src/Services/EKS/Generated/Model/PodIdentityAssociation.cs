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
    /// Amazon EKS Pod Identity associations provide the ability to manage credentials for
    /// your applications, similar to the way that Amazon EC2 instance profiles provide credentials
    /// to Amazon EC2 instances.
    /// </summary>
    public partial class PodIdentityAssociation
    {
        private string _associationArn;
        private string _associationId;
        private string _clusterName;
        private DateTime? _createdAt;
        private bool? _disableSessionTags;
        private string _externalId;
        private DateTime? _modifiedAt;
        private string _awsNamespace;
        private string _ownerArn;
        private string _roleArn;
        private string _serviceAccount;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetRoleArn;

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        public string AssociationArn
        {
            get { return this._associationArn; }
            set { this._associationArn = value; }
        }

        // Check to see if AssociationArn property is set
        internal bool IsSetAssociationArn()
        {
            return this._associationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the association is in.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp that the association was created at.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

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
        public bool? DisableSessionTags
        {
            get { return this._disableSessionTags; }
            set { this._disableSessionTags = value; }
        }

        // Check to see if DisableSessionTags property is set
        internal bool IsSetDisableSessionTags()
        {
            return this._disableSessionTags.HasValue; 
        }

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
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The most recent timestamp that the association was modified at.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster to create the association
        /// in. The service account and the Pods that use the service account must be in this
        /// namespace.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// If defined, the EKS Pod Identity association is owned by an Amazon EKS add-on.
        /// </para>
        /// </summary>
        public string OwnerArn
        {
            get { return this._ownerArn; }
            set { this._ownerArn = value; }
        }

        // Check to see if OwnerArn property is set
        internal bool IsSetOwnerArn()
        {
            return this._ownerArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the service account.
        /// The EKS Pod Identity agent manages credentials to assume this role for applications
        /// in the containers in the Pods that use this service account.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account inside the cluster to associate the IAM
        /// credentials with.
        /// </para>
        /// </summary>
        public string ServiceAccount
        {
            get { return this._serviceAccount; }
            set { this._serviceAccount = value; }
        }

        // Check to see if ServiceAccount property is set
        internal bool IsSetServiceAccount()
        {
            return this._serviceAccount != null;
        }

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
        /// Gets and sets the property TargetRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target IAM role to associate with the service
        /// account. This role is assumed by using the EKS Pod Identity association role, then
        /// the credentials for this role are injected into the Pod.
        /// </para>
        /// </summary>
        public string TargetRoleArn
        {
            get { return this._targetRoleArn; }
            set { this._targetRoleArn = value; }
        }

        // Check to see if TargetRoleArn property is set
        internal bool IsSetTargetRoleArn()
        {
            return this._targetRoleArn != null;
        }

    }
}