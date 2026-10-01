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
    /// An Amazon EKS add-on. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html">Amazon
    /// EKS add-ons</a> in the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class Addon
    {
        /// <summary>
        /// Gets and sets the property AddonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the add-on.
        /// </para>
        /// </summary>
        public string AddonArn { get; set; }

        /// <summary>
        /// Checks to see if the AddonArn property is set.
        /// </summary>
        internal bool IsSetAddonArn() => this.AddonArn != null;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on.
        /// </para>
        /// </summary>
        public string AddonVersion { get; set; }

        /// <summary>
        /// Checks to see if the AddonVersion property is set.
        /// </summary>
        internal bool IsSetAddonVersion() => this.AddonVersion != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ConfigurationValues. 
        /// <para>
        /// The configuration values that you provided.
        /// </para>
        /// </summary>
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// An object that represents the health of the add-on.
        /// </para>
        /// </summary>
        public AddonHealth Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property MarketplaceInformation. 
        /// <para>
        /// Information about an Amazon EKS add-on from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public MarketplaceInformation MarketplaceInformation { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceInformation property is set.
        /// </summary>
        internal bool IsSetMarketplaceInformation() => this.MarketplaceInformation != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The Unix epoch timestamp for the last modification to the object.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceConfig. 
        /// <para>
        /// The namespace configuration for the addon. This specifies the Kubernetes namespace
        /// where the addon is installed.
        /// </para>
        /// </summary>
        public AddonNamespaceConfigResponse NamespaceConfig { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceConfig property is set.
        /// </summary>
        internal bool IsSetNamespaceConfig() => this.NamespaceConfig != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the add-on.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PodIdentityAssociations. 
        /// <para>
        /// An array of EKS Pod Identity associations owned by the add-on. Each association maps
        /// a role to a service account in a namespace in the cluster.
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
        public List<string> PodIdentityAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PodIdentityAssociations property is set.
        /// </summary>
        internal bool IsSetPodIdentityAssociations() => this.PodIdentityAssociations != null && (this.PodIdentityAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The publisher of the add-on.
        /// </para>
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Checks to see if the Publisher property is set.
        /// </summary>
        internal bool IsSetPublisher() => this.Publisher != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that's bound to the Kubernetes <c>ServiceAccount</c>
        /// object that the add-on uses.
        /// </para>
        /// </summary>
        public string ServiceAccountRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccountRoleArn() => this.ServiceAccountRoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the add-on.
        /// </para>
        /// </summary>
        public AddonStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
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
    }
}
