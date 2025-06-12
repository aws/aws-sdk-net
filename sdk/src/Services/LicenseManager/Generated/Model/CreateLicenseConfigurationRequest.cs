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
    /// Container for the parameters to the CreateLicenseConfiguration operation.
    /// Creates a license configuration.
    /// 
    ///  
    /// <para>
    /// A license configuration is an abstraction of a customer license agreement that can
    /// be consumed and enforced by License Manager. Components include specifications for
    /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
    /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
    /// host (how long a license must be associated with a host), and the number of licenses
    /// purchased and used.
    /// </para>
    /// </summary>
    public partial class CreateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        private string _description;
        private bool? _disassociateWhenNotFound;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private LicenseCountingType _licenseCountingType;
        private List<string> _licenseRules = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<ProductInformation> _productInformationList = AWSConfigs.InitializeCollections ? new List<ProductInformation>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// Number of licenses managed by the license configuration.
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
        /// Indicates whether hard or soft license enforcement is used. Exceeding a hard limit
        /// blocks the launch of new instances.
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
        /// Dimension used to track the license inventory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// License rules. The syntax is #name=value (for example, #allowedTenancy=EC2-DedicatedHost).
        /// The available rules vary by dimension, as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Cores</c> dimension: <c>allowedTenancy</c> | <c>licenseAffinityToHost</c> | <c>maximumCores</c>
        /// | <c>minimumCores</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Instances</c> dimension: <c>allowedTenancy</c> | <c>maximumVcpus</c> | <c>minimumVcpus</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sockets</c> dimension: <c>allowedTenancy</c> | <c>licenseAffinityToHost</c> |
        /// <c>maximumSockets</c> | <c>minimumSockets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vCPUs</c> dimension: <c>allowedTenancy</c> | <c>honorVcpuOptimization</c> | <c>maximumVcpus</c>
        /// | <c>minimumVcpus</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The unit for <c>licenseAffinityToHost</c> is days and the range is 1 to 180. The possible
        /// values for <c>allowedTenancy</c> are <c>EC2-Default</c>, <c>EC2-DedicatedHost</c>,
        /// and <c>EC2-DedicatedInstance</c>. The possible values for <c>honorVcpuOptimization</c>
        /// are <c>True</c> and <c>False</c>.
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
        /// Name of the license configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the license configuration.
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