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
    /// This is the response object from the GetLicenseConfiguration operation.
    /// </summary>
    public partial class GetLicenseConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutomatedDiscoveryInformation. 
        /// <para>
        /// Automated discovery information.
        /// </para>
        /// </summary>
        public AutomatedDiscoveryInformation AutomatedDiscoveryInformation { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedDiscoveryInformation property is set.
        /// </summary>
        internal bool IsSetAutomatedDiscoveryInformation() => this.AutomatedDiscoveryInformation != null;

        /// <summary>
        /// Gets and sets the property ConsumedLicenseSummaryList. 
        /// <para>
        /// Summaries of the licenses consumed by resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConsumedLicenseSummary> ConsumedLicenseSummaryList { get; set; } = AWSConfigs.InitializeCollections ? new List<ConsumedLicenseSummary>() : null;

        /// <summary>
        /// Checks to see if the ConsumedLicenseSummaryList property is set.
        /// </summary>
        internal bool IsSetConsumedLicenseSummaryList() => this.ConsumedLicenseSummaryList != null && (this.ConsumedLicenseSummaryList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConsumedLicenses. 
        /// <para>
        /// Number of licenses assigned to resources.
        /// </para>
        /// </summary>
        public long? ConsumedLicenses { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedLicenses property is set.
        /// </summary>
        internal bool IsSetConsumedLicenses() => this.ConsumedLicenses.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the license configuration.
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
        public string LicenseConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConfigurationArn property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationArn() => this.LicenseConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LicenseConfigurationId. 
        /// <para>
        /// Unique ID for the license configuration.
        /// </para>
        /// </summary>
        public string LicenseConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConfigurationId property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationId() => this.LicenseConfigurationId != null;

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// Number of available licenses.
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
        /// Sets the number of available licenses as a hard limit.
        /// </para>
        /// </summary>
        public bool? LicenseCountHardLimit { get; set; }

        /// <summary>
        /// Checks to see if the LicenseCountHardLimit property is set.
        /// </summary>
        internal bool IsSetLicenseCountHardLimit() => this.LicenseCountHardLimit.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseCountingType. 
        /// <para>
        /// Dimension for which the licenses are counted.
        /// </para>
        /// </summary>
        public LicenseCountingType LicenseCountingType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseCountingType property is set.
        /// </summary>
        internal bool IsSetLicenseCountingType() => this.LicenseCountingType != null;

        /// <summary>
        /// Gets and sets the property LicenseExpiry. 
        /// <para>
        /// License Expiry.
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
        /// License rules.
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
        /// Gets and sets the property ManagedResourceSummaryList. 
        /// <para>
        /// Summaries of the managed resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedResourceSummary> ManagedResourceSummaryList { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedResourceSummary>() : null;

        /// <summary>
        /// Checks to see if the ManagedResourceSummaryList property is set.
        /// </summary>
        internal bool IsSetManagedResourceSummaryList() => this.ManagedResourceSummaryList != null && (this.ManagedResourceSummaryList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the license configuration.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Account ID of the owner of the license configuration.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ProductInformationList. 
        /// <para>
        /// Product information.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License configuration status.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the license configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
