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
    /// Information about an add-on.
    /// </summary>
    public partial class AddonInfo
    {
        private string _addonName;
        private List<AddonVersionInfo> _addonVersions = AWSConfigs.InitializeCollections ? new List<AddonVersionInfo>() : null;
        private string _defaultNamespace;
        private MarketplaceInformation _marketplaceInformation;
        private string _owner;
        private string _publisher;
        private string _type;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AddonVersions. 
        /// <para>
        /// An object representing information about available add-on versions and compatible
        /// Kubernetes versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonVersionInfo> AddonVersions
        {
            get { return this._addonVersions; }
            set { this._addonVersions = value; }
        }

        // Check to see if AddonVersions property is set
        internal bool IsSetAddonVersions()
        {
            return this._addonVersions != null && (this._addonVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default Kubernetes namespace where this addon is typically installed if no custom
        /// namespace is specified.
        /// </para>
        /// </summary>
        public string DefaultNamespace
        {
            get { return this._defaultNamespace; }
            set { this._defaultNamespace = value; }
        }

        // Check to see if DefaultNamespace property is set
        internal bool IsSetDefaultNamespace()
        {
            return this._defaultNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceInformation. 
        /// <para>
        /// Information about the add-on from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public MarketplaceInformation MarketplaceInformation
        {
            get { return this._marketplaceInformation; }
            set { this._marketplaceInformation = value; }
        }

        // Check to see if MarketplaceInformation property is set
        internal bool IsSetMarketplaceInformation()
        {
            return this._marketplaceInformation != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the add-on.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The publisher of the add-on.
        /// </para>
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        // Check to see if Publisher property is set
        internal bool IsSetPublisher()
        {
            return this._publisher != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the add-on.
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

    }
}