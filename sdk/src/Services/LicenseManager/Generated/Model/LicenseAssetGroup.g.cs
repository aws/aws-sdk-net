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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// License asset group.
    /// </summary>
    public partial class LicenseAssetGroup
    {
        /// <summary>
        /// Gets and sets the property AssociatedLicenseAssetRulesetARNs. 
        /// <para>
        /// ARNs of associated license asset rulesets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AssociatedLicenseAssetRulesetARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedLicenseAssetRulesetARNs property is set.
        /// </summary>
        internal bool IsSetAssociatedLicenseAssetRulesetARNs() => this.AssociatedLicenseAssetRulesetARNs != null && (this.AssociatedLicenseAssetRulesetARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// License asset group description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestResourceDiscoveryTime. 
        /// <para>
        /// Latest resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? LatestResourceDiscoveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestResourceDiscoveryTime property is set.
        /// </summary>
        internal bool IsSetLatestResourceDiscoveryTime() => this.LatestResourceDiscoveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestUsageAnalysisTime. 
        /// <para>
        /// Latest usage analysis time.
        /// </para>
        /// </summary>
        public DateTime? LatestUsageAnalysisTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestUsageAnalysisTime property is set.
        /// </summary>
        internal bool IsSetLatestUsageAnalysisTime() => this.LatestUsageAnalysisTime.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license asset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseAssetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseAssetGroupArn property is set.
        /// </summary>
        internal bool IsSetLicenseAssetGroupArn() => this.LicenseAssetGroupArn != null;

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupConfigurations. 
        /// <para>
        /// License asset group configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseAssetGroupConfiguration> LicenseAssetGroupConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupConfiguration>() : null;

        /// <summary>
        /// Checks to see if the LicenseAssetGroupConfigurations property is set.
        /// </summary>
        internal bool IsSetLicenseAssetGroupConfigurations() => this.LicenseAssetGroupConfigurations != null && (this.LicenseAssetGroupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// License asset group name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// License asset group properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseAssetGroupProperty> Properties { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseAssetGroupProperty>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License asset group status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseAssetGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// License asset group status message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
