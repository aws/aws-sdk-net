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
    /// Container for the parameters to the UpdateAddon operation. Updates an Amazon EKS add-on.
    /// </summary>
    public partial class UpdateAddonRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListAddons.html">
        /// <c>ListAddons</c> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on. The version must match one of the versions returned by
        /// <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeAddonVersions.html">
        /// <c>DescribeAddonVersions</c> </a>.
        /// </para>
        /// </summary>
        public string AddonVersion { get; set; }

        /// <summary>
        /// Checks to see if the AddonVersion property is set.
        /// </summary>
        internal bool IsSetAddonVersion() => this.AddonVersion != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ConfigurationValues. 
        /// <para>
        /// The set of configuration values for the add-on that's created. The values that you
        /// provide are validated against the schema returned by <c>DescribeAddonConfiguration</c>.
        /// </para>
        /// </summary>
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property PodIdentityAssociations. 
        /// <para>
        /// An array of EKS Pod Identity associations to be updated. Each association maps a Kubernetes
        /// service account to an IAM role. If this value is left blank, no change. If an empty
        /// array is provided, existing associations owned by the add-on are deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/add-ons-iam.html">Attach
        /// an IAM Role to an Amazon EKS add-on using EKS Pod Identity</a> in the <i>Amazon EKS
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonPodIdentityAssociations> PodIdentityAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<AddonPodIdentityAssociations>() : null;

        /// <summary>
        /// Checks to see if the PodIdentityAssociations property is set.
        /// </summary>
        internal bool IsSetPodIdentityAssociations() => this.PodIdentityAssociations != null && (this.PodIdentityAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolveConflicts. 
        /// <para>
        /// How to resolve field value conflicts for an Amazon EKS add-on if you've changed a
        /// value from the Amazon EKS default value. Conflicts are handled based on the option
        /// you choose:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>None</b> – Amazon EKS doesn't change the value. The update might fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Overwrite</b> – Amazon EKS overwrites the changed value back to the Amazon EKS
        /// default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Preserve</b> – Amazon EKS preserves the value. If you choose this option, we recommend
        /// that you test any field and value changes on a non-production cluster before updating
        /// the add-on on your production cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolveConflicts ResolveConflicts { get; set; }

        /// <summary>
        /// Checks to see if the ResolveConflicts property is set.
        /// </summary>
        internal bool IsSetResolveConflicts() => this.ResolveConflicts != null;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string ServiceAccountRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccountRoleArn() => this.ServiceAccountRoleArn != null;
    }
}
