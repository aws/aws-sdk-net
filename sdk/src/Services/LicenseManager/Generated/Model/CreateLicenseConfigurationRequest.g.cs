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
    /// Container for the parameters to the CreateLicenseConfiguration operation. Creates
    /// a license configuration. <para> A license configuration is an abstraction of a customer
    /// license agreement that can be consumed and enforced by License Manager. Components
    /// include specifications for the license type (licensing by instance, socket, CPU, or
    /// vCPU), allowed tenancy (shared tenancy, Dedicated Instance, Dedicated Host, or all
    /// of these), license affinity to host (how long a license must be associated with a
    /// host), and the number of licenses purchased and used. </para>
    /// </summary>
    public partial class CreateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
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
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// Number of licenses managed by the license configuration.
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
        /// Indicates whether hard or soft license enforcement is used. Exceeding a hard limit
        /// blocks the launch of new instances.
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
        /// Dimension used to track the license inventory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseCountingType LicenseCountingType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseCountingType property is set.
        /// </summary>
        internal bool IsSetLicenseCountingType() => this.LicenseCountingType != null;

        /// <summary>
        /// Gets and sets the property LicenseExpiry. 
        /// <para>
        /// License configuration expiry.
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
        /// Name of the license configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the license configuration.
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
