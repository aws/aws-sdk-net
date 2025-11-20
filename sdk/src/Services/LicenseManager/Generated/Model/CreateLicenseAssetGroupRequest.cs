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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLicenseAssetGroup operation.
    /// Creates a license asset group.
    /// </summary>
    public partial class CreateLicenseAssetGroupRequest : AmazonLicenseManagerRequest
    {
        private List<string> _associatedLicenseAssetRulesetARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _description;
        private List<LicenseAssetGroupConfiguration> _licenseAssetGroupConfigurations = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupConfiguration>() : null;
        private string _name;
        private List<LicenseAssetGroupProperty> _properties = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupProperty>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedLicenseAssetRulesetARNs. 
        /// <para>
        /// ARNs of associated license asset rulesets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssociatedLicenseAssetRulesetARNs
        {
            get { return this._associatedLicenseAssetRulesetARNs; }
            set { this._associatedLicenseAssetRulesetARNs = value; }
        }

        // Check to see if AssociatedLicenseAssetRulesetARNs property is set
        internal bool IsSetAssociatedLicenseAssetRulesetARNs()
        {
            return this._associatedLicenseAssetRulesetARNs != null && (this._associatedLicenseAssetRulesetARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// License asset group description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupConfigurations. 
        /// <para>
        /// License asset group configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LicenseAssetGroupConfiguration> LicenseAssetGroupConfigurations
        {
            get { return this._licenseAssetGroupConfigurations; }
            set { this._licenseAssetGroupConfigurations = value; }
        }

        // Check to see if LicenseAssetGroupConfigurations property is set
        internal bool IsSetLicenseAssetGroupConfigurations()
        {
            return this._licenseAssetGroupConfigurations != null && (this._licenseAssetGroupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// License asset group name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// License asset group properties.
        /// </para>
        /// </summary>
        public List<LicenseAssetGroupProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the license asset group.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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