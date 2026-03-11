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
    /// Container for the parameters to the UpdateLicenseAssetGroup operation.
    /// Updates a license asset group.
    /// </summary>
    public partial class UpdateLicenseAssetGroupRequest : AmazonLicenseManagerRequest
    {
        private List<string> _associatedLicenseAssetRulesetARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _description;
        private string _licenseAssetGroupArn;
        private List<LicenseAssetGroupConfiguration> _licenseAssetGroupConfigurations = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupConfiguration>() : null;
        private string _name;
        private List<LicenseAssetGroupProperty> _properties = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupProperty>() : null;
        private LicenseAssetGroupStatus _status;

        /// <summary>
        /// Gets and sets the property AssociatedLicenseAssetRulesetARNs. 
        /// <para>
        /// ARNs of associated license asset rulesets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property LicenseAssetGroupArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license asset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string LicenseAssetGroupArn
        {
            get { return this._licenseAssetGroupArn; }
            set { this._licenseAssetGroupArn = value; }
        }

        // Check to see if LicenseAssetGroupArn property is set
        internal bool IsSetLicenseAssetGroupArn()
        {
            return this._licenseAssetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupConfigurations. 
        /// <para>
        /// License asset group configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        [AWSProperty(Max=128)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// License asset group status. The possible values are <c>ACTIVE</c> | <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public LicenseAssetGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}