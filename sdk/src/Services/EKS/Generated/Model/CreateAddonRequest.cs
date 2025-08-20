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
    /// Container for the parameters to the CreateAddon operation.
    /// Creates an Amazon EKS add-on.
    /// 
    ///  
    /// <para>
    /// Amazon EKS add-ons help to automate the provisioning and lifecycle management of common
    /// operational software for Amazon EKS clusters. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html">Amazon
    /// EKS add-ons</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAddonRequest : AmazonEKSRequest
    {
        private string _addonName;
        private string _addonVersion;
        private string _clientRequestToken;
        private string _clusterName;
        private string _configurationValues;
        private AddonNamespaceConfigRequest _namespaceConfig;
        private List<AddonPodIdentityAssociations> _podIdentityAssociations = AWSConfigs.InitializeCollections ? new List<AddonPodIdentityAssociations>() : null;
        private ResolveConflicts _resolveConflicts;
        private string _serviceAccountRoleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <c>DescribeAddonVersions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on. The version must match one of the versions returned by
        /// <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html">
        /// <c>DescribeAddonVersions</c> </a>.
        /// </para>
        /// </summary>
        public string AddonVersion
        {
            get { return this._addonVersion; }
            set { this._addonVersion = value; }
        }

        // Check to see if AddonVersion property is set
        internal bool IsSetAddonVersion()
        {
            return this._addonVersion != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ConfigurationValues. 
        /// <para>
        /// The set of configuration values for the add-on that's created. The values that you
        /// provide are validated against the schema returned by <c>DescribeAddonConfiguration</c>.
        /// </para>
        /// </summary>
        public string ConfigurationValues
        {
            get { return this._configurationValues; }
            set { this._configurationValues = value; }
        }

        // Check to see if ConfigurationValues property is set
        internal bool IsSetConfigurationValues()
        {
            return this._configurationValues != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceConfig. 
        /// <para>
        /// The namespace configuration for the addon. If specified, this will override the default
        /// namespace for the addon.
        /// </para>
        /// </summary>
        public AddonNamespaceConfigRequest NamespaceConfig
        {
            get { return this._namespaceConfig; }
            set { this._namespaceConfig = value; }
        }

        // Check to see if NamespaceConfig property is set
        internal bool IsSetNamespaceConfig()
        {
            return this._namespaceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PodIdentityAssociations. 
        /// <para>
        /// An array of EKS Pod Identity associations to be created. Each association maps a Kubernetes
        /// service account to an IAM role.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/add-ons-iam.html">Attach
        /// an IAM Role to an Amazon EKS add-on using EKS Pod Identity</a> in the <i>Amazon EKS
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonPodIdentityAssociations> PodIdentityAssociations
        {
            get { return this._podIdentityAssociations; }
            set { this._podIdentityAssociations = value; }
        }

        // Check to see if PodIdentityAssociations property is set
        internal bool IsSetPodIdentityAssociations()
        {
            return this._podIdentityAssociations != null && (this._podIdentityAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolveConflicts. 
        /// <para>
        /// How to resolve field value conflicts for an Amazon EKS add-on. Conflicts are handled
        /// based on the value you choose:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>None</b> – If the self-managed version of the add-on is installed on your cluster,
        /// Amazon EKS doesn't change the value. Creation of the add-on might fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Overwrite</b> – If the self-managed version of the add-on is installed on your
        /// cluster and the Amazon EKS default value is different than the existing value, Amazon
        /// EKS changes the value to the Amazon EKS default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Preserve</b> – This is similar to the NONE option. If the self-managed version
        /// of the add-on is installed on your cluster Amazon EKS doesn't change the add-on resource
        /// properties. Creation of the add-on might fail if conflicts are detected. This option
        /// works differently during the update operation. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_UpdateAddon.html">
        /// <c>UpdateAddon</c> </a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't currently have the self-managed version of the add-on installed on your
        /// cluster, the Amazon EKS add-on is installed. Amazon EKS sets all values to default
        /// values, regardless of the option that you specify.
        /// </para>
        /// </summary>
        public ResolveConflicts ResolveConflicts
        {
            get { return this._resolveConflicts; }
            set { this._resolveConflicts = value; }
        }

        // Check to see if ResolveConflicts property is set
        internal bool IsSetResolveConflicts()
        {
            return this._resolveConflicts != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IAM role to bind to the add-on's service
        /// account. The role must be assigned the IAM permissions required by the add-on. If
        /// you don't specify an existing IAM role, then the add-on uses the permissions assigned
        /// to the node IAM role. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html">Amazon
        /// EKS node IAM role</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify an existing IAM role, you must have an IAM OpenID Connect (OIDC) provider
        /// created for your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/enable-iam-roles-for-service-accounts.html">Enabling
        /// IAM roles for service accounts on your cluster</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ServiceAccountRoleArn
        {
            get { return this._serviceAccountRoleArn; }
            set { this._serviceAccountRoleArn = value; }
        }

        // Check to see if ServiceAccountRoleArn property is set
        internal bool IsSetServiceAccountRoleArn()
        {
            return this._serviceAccountRoleArn != null;
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

    }
}