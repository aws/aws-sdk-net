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
    /// An access entry allows an IAM principal (user or role) to access your cluster. Access
    /// entries can replace the need to maintain the <c>aws-auth</c> <c>ConfigMap</c> for
    /// authentication. For more information about access entries, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-entries.html">Access
    /// entries</a> in the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class AccessEntry
    {
        private string _accessEntryArn;
        private string _clusterName;
        private DateTime? _createdAt;
        private List<string> _kubernetesGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _modifiedAt;
        private string _principalArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _type;
        private string _username;

        /// <summary>
        /// Gets and sets the property AccessEntryArn. 
        /// <para>
        /// The ARN of the access entry.
        /// </para>
        /// </summary>
        public string AccessEntryArn
        {
            get { return this._accessEntryArn; }
            set { this._accessEntryArn = value; }
        }

        // Check to see if AccessEntryArn property is set
        internal bool IsSetAccessEntryArn()
        {
            return this._accessEntryArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
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
        /// The Unix epoch timestamp at object creation.
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
        /// Gets and sets the property KubernetesGroups. 
        /// <para>
        /// A <c>name</c> that you've specified in a Kubernetes <c>RoleBinding</c> or <c>ClusterRoleBinding</c>
        /// object so that Kubernetes authorizes the <c>principalARN</c> access to cluster objects.
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The Unix epoch timestamp for the last modification to the object.
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
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal for the access entry. If you ever delete the IAM principal
        /// with this ARN, the access entry isn't automatically deleted. We recommend that you
        /// delete the access entry with an ARN for an IAM principal that you delete. If you don't
        /// delete the access entry and ever recreate the IAM principal, even if it has the same
        /// ARN, the access entry won't work. This is because even though the ARN is the same
        /// for the recreated IAM principal, the <c>roleID</c> or <c>userID</c> (you can see this
        /// with the Security Token Service <c>GetCallerIdentity</c> API) is different for the
        /// recreated IAM principal than it was for the original IAM principal. Even though you
        /// don't see the IAM principal's <c>roleID</c> or <c>userID</c> for an access entry,
        /// Amazon EKS stores it with the access entry.
        /// </para>
        /// </summary>
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
        /// The type of the access entry.
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
        /// The <c>name</c> of a user that can authenticate to your cluster.
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