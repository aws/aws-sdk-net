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
    /// Information about an add-on.
    /// </summary>
    public partial class AddonInfo
    {
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
        /// Gets and sets the property AddonVersions. 
        /// <para>
        /// An object representing information about available add-on versions and compatible
        /// Kubernetes versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonVersionInfo> AddonVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<AddonVersionInfo>() : null;

        /// <summary>
        /// Checks to see if the AddonVersions property is set.
        /// </summary>
        internal bool IsSetAddonVersions() => this.AddonVersions != null && (this.AddonVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default Kubernetes namespace where this addon is typically installed if no custom
        /// namespace is specified.
        /// </para>
        /// </summary>
        public string DefaultNamespace { get; set; }

        /// <summary>
        /// Checks to see if the DefaultNamespace property is set.
        /// </summary>
        internal bool IsSetDefaultNamespace() => this.DefaultNamespace != null;

        /// <summary>
        /// Gets and sets the property MarketplaceInformation. 
        /// <para>
        /// Information about the add-on from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public MarketplaceInformation MarketplaceInformation { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceInformation property is set.
        /// </summary>
        internal bool IsSetMarketplaceInformation() => this.MarketplaceInformation != null;

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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the add-on.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
