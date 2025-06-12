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
    /// Container for the parameters to the UpdateLicenseConfiguration operation.
    /// Modifies the attributes of an existing license configuration.
    /// </summary>
    public partial class UpdateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        private string _description;
        private bool? _disassociateWhenNotFound;
        private string _licenseConfigurationArn;
        private LicenseConfigurationStatus _licenseConfigurationStatus;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private List<string> _licenseRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<ProductInformation> _productInformationList = AWSConfigs.InitializeCollections ? new List<ProductInformation>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// New description of the license configuration.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LicenseConfigurationStatus. 
        /// <para>
        /// New status of the license configuration.
        /// </para>
        /// </summary>
        public LicenseConfigurationStatus LicenseConfigurationStatus
        {
            get { return this._licenseConfigurationStatus; }
            set { this._licenseConfigurationStatus = value; }
        }

        // Check to see if LicenseConfigurationStatus property is set
        internal bool IsSetLicenseConfigurationStatus()
        {
            return this._licenseConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// New number of licenses managed by the license configuration.
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
        /// New hard limit of the number of available licenses.
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
        /// Gets and sets the property LicenseRules. 
        /// <para>
        /// New license rule. The only rule that you can add after you create a license configuration
        /// is licenseAffinityToHost.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// New name of the license configuration.
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
        /// Gets and sets the property ProductInformationList. 
        /// <para>
        /// New product information.
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

    }
}