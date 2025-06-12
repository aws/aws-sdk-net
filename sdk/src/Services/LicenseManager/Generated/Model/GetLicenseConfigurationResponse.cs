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
    /// This is the response object from the GetLicenseConfiguration operation.
    /// </summary>
    public partial class GetLicenseConfigurationResponse : AmazonWebServiceResponse
    {
        private AutomatedDiscoveryInformation _automatedDiscoveryInformation;
        private long? _consumedLicenses;
        private List<ConsumedLicenseSummary> _consumedLicenseSummaryList = AWSConfigs.InitializeCollections ? new List<ConsumedLicenseSummary>() : null;
        private string _description;
        private bool? _disassociateWhenNotFound;
        private string _licenseConfigurationArn;
        private string _licenseConfigurationId;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private LicenseCountingType _licenseCountingType;
        private List<string> _licenseRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ManagedResourceSummary> _managedResourceSummaryList = AWSConfigs.InitializeCollections ? new List<ManagedResourceSummary>() : null;
        private string _name;
        private string _ownerAccountId;
        private List<ProductInformation> _productInformationList = AWSConfigs.InitializeCollections ? new List<ProductInformation>() : null;
        private string _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutomatedDiscoveryInformation. 
        /// <para>
        /// Automated discovery information.
        /// </para>
        /// </summary>
        public AutomatedDiscoveryInformation AutomatedDiscoveryInformation
        {
            get { return this._automatedDiscoveryInformation; }
            set { this._automatedDiscoveryInformation = value; }
        }

        // Check to see if AutomatedDiscoveryInformation property is set
        internal bool IsSetAutomatedDiscoveryInformation()
        {
            return this._automatedDiscoveryInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumedLicenses. 
        /// <para>
        /// Number of licenses assigned to resources.
        /// </para>
        /// </summary>
        public long? ConsumedLicenses
        {
            get { return this._consumedLicenses; }
            set { this._consumedLicenses = value; }
        }

        // Check to see if ConsumedLicenses property is set
        internal bool IsSetConsumedLicenses()
        {
            return this._consumedLicenses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumedLicenseSummaryList. 
        /// <para>
        /// Summaries of the licenses consumed by resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConsumedLicenseSummary> ConsumedLicenseSummaryList
        {
            get { return this._consumedLicenseSummaryList; }
            set { this._consumedLicenseSummaryList = value; }
        }

        // Check to see if ConsumedLicenseSummaryList property is set
        internal bool IsSetConsumedLicenseSummaryList()
        {
            return this._consumedLicenseSummaryList != null && (this._consumedLicenseSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the license configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DisassociateWhenNotFound. 
        /// <para>
        /// When true, disassociates a resource when software is uninstalled.
        /// </para>
        /// </summary>
        public bool? DisassociateWhenNotFound
        {
            get { return this._disassociateWhenNotFound; }
            set { this._disassociateWhenNotFound = value; }
        }

        // Check to see if DisassociateWhenNotFound property is set
        internal bool IsSetDisassociateWhenNotFound()
        {
            return this._disassociateWhenNotFound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration.
        /// </para>
        /// </summary>
        public string LicenseConfigurationArn
        {
            get { return this._licenseConfigurationArn; }
            set { this._licenseConfigurationArn = value; }
        }

        // Check to see if LicenseConfigurationArn property is set
        internal bool IsSetLicenseConfigurationArn()
        {
            return this._licenseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationId. 
        /// <para>
        /// Unique ID for the license configuration.
        /// </para>
        /// </summary>
        public string LicenseConfigurationId
        {
            get { return this._licenseConfigurationId; }
            set { this._licenseConfigurationId = value; }
        }

        // Check to see if LicenseConfigurationId property is set
        internal bool IsSetLicenseConfigurationId()
        {
            return this._licenseConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// Number of available licenses.
        /// </para>
        /// </summary>
        public long? LicenseCount
        {
            get { return this._licenseCount; }
            set { this._licenseCount = value; }
        }

        // Check to see if LicenseCount property is set
        internal bool IsSetLicenseCount()
        {
            return this._licenseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseCountHardLimit. 
        /// <para>
        /// Sets the number of available licenses as a hard limit.
        /// </para>
        /// </summary>
        public bool? LicenseCountHardLimit
        {
            get { return this._licenseCountHardLimit; }
            set { this._licenseCountHardLimit = value; }
        }

        // Check to see if LicenseCountHardLimit property is set
        internal bool IsSetLicenseCountHardLimit()
        {
            return this._licenseCountHardLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseCountingType. 
        /// <para>
        /// Dimension for which the licenses are counted.
        /// </para>
        /// </summary>
        public LicenseCountingType LicenseCountingType
        {
            get { return this._licenseCountingType; }
            set { this._licenseCountingType = value; }
        }

        // Check to see if LicenseCountingType property is set
        internal bool IsSetLicenseCountingType()
        {
            return this._licenseCountingType != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseRules. 
        /// <para>
        /// License rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseRules
        {
            get { return this._licenseRules; }
            set { this._licenseRules = value; }
        }

        // Check to see if LicenseRules property is set
        internal bool IsSetLicenseRules()
        {
            return this._licenseRules != null && (this._licenseRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedResourceSummaryList. 
        /// <para>
        /// Summaries of the managed resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedResourceSummary> ManagedResourceSummaryList
        {
            get { return this._managedResourceSummaryList; }
            set { this._managedResourceSummaryList = value; }
        }

        // Check to see if ManagedResourceSummaryList property is set
        internal bool IsSetManagedResourceSummaryList()
        {
            return this._managedResourceSummaryList != null && (this._managedResourceSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the license configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Account ID of the owner of the license configuration.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductInformationList. 
        /// <para>
        /// Product information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductInformation> ProductInformationList
        {
            get { return this._productInformationList; }
            set { this._productInformationList = value; }
        }

        // Check to see if ProductInformationList property is set
        internal bool IsSetProductInformationList()
        {
            return this._productInformationList != null && (this._productInformationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License configuration status.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the license configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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