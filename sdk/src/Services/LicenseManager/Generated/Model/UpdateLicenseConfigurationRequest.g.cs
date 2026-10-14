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
    /// Container for the parameters to the UpdateLicenseConfiguration operation. Modifies
    /// the attributes of an existing license configuration.
    /// </summary>
    public partial class UpdateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// New description of the license configuration.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisassociateWhenNotFound. 
        /// <para>
        /// When true, disassociates a resource when software is uninstalled.
        /// </para>
        /// </summary>
        public bool? DisassociateWhenNotFound { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateWhenNotFound property is set.
        /// </summary>
        internal bool IsSetDisassociateWhenNotFound() => this.DisassociateWhenNotFound.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LicenseConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConfigurationArn property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationArn() => this.LicenseConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LicenseConfigurationStatus. 
        /// <para>
        /// New status of the license configuration.
        /// </para>
        /// </summary>
        public LicenseConfigurationStatus LicenseConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationStatus() => this.LicenseConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// New number of licenses managed by the license configuration.
        /// </para>
        /// </summary>
        public long? LicenseCount { get; set; }

        /// <summary>
        /// Checks to see if the LicenseCount property is set.
        /// </summary>
        internal bool IsSetLicenseCount() => this.LicenseCount.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseCountHardLimit. 
        /// <para>
        /// New hard limit of the number of available licenses.
        /// </para>
        /// </summary>
        public bool? LicenseCountHardLimit { get; set; }

        /// <summary>
        /// Checks to see if the LicenseCountHardLimit property is set.
        /// </summary>
        internal bool IsSetLicenseCountHardLimit() => this.LicenseCountHardLimit.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseExpiry. 
        /// <para>
        /// License configuration expiry time.
        /// </para>
        /// </summary>
        public long? LicenseExpiry { get; set; }

        /// <summary>
        /// Checks to see if the LicenseExpiry property is set.
        /// </summary>
        internal bool IsSetLicenseExpiry() => this.LicenseExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseRules. 
        /// <para>
        /// New license rule. The only rule that you can add after you create a license configuration
        /// is licenseAffinityToHost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseRules { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LicenseRules property is set.
        /// </summary>
        internal bool IsSetLicenseRules() => this.LicenseRules != null && (this.LicenseRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// New name of the license configuration.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProductInformationList. 
        /// <para>
        /// New product information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductInformation> ProductInformationList { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductInformation>() : null;

        /// <summary>
        /// Checks to see if the ProductInformationList property is set.
        /// </summary>
        internal bool IsSetProductInformationList() => this.ProductInformationList != null && (this.ProductInformationList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
