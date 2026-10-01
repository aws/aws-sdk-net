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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a site.
    /// </summary>
    public partial class Site
    {
        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1001)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        ///  Notes about a site. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property OperatingAddressCity. 
        /// <para>
        ///  City where the hardware is installed and powered on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string OperatingAddressCity { get; set; }

        /// <summary>
        /// Checks to see if the OperatingAddressCity property is set.
        /// </summary>
        internal bool IsSetOperatingAddressCity() => this.OperatingAddressCity != null;

        /// <summary>
        /// Gets and sets the property OperatingAddressCountryCode. 
        /// <para>
        ///  The ISO-3166 two-letter country code where the hardware is installed and powered
        /// on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string OperatingAddressCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the OperatingAddressCountryCode property is set.
        /// </summary>
        internal bool IsSetOperatingAddressCountryCode() => this.OperatingAddressCountryCode != null;

        /// <summary>
        /// Gets and sets the property OperatingAddressStateOrRegion. 
        /// <para>
        ///  State or region where the hardware is installed and powered on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string OperatingAddressStateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the OperatingAddressStateOrRegion property is set.
        /// </summary>
        internal bool IsSetOperatingAddressStateOrRegion() => this.OperatingAddressStateOrRegion != null;

        /// <summary>
        /// Gets and sets the property RackPhysicalProperties. 
        /// <para>
        ///  Information about the physical and logistical details for a rack at the site. 
        /// </para>
        /// </summary>
        public RackPhysicalProperties RackPhysicalProperties { get; set; }

        /// <summary>
        /// Checks to see if the RackPhysicalProperties property is set.
        /// </summary>
        internal bool IsSetRackPhysicalProperties() => this.RackPhysicalProperties != null;

        /// <summary>
        /// Gets and sets the property SiteArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SiteArn { get; set; }

        /// <summary>
        /// Checks to see if the SiteArn property is set.
        /// </summary>
        internal bool IsSetSiteArn() => this.SiteArn != null;

        /// <summary>
        /// Gets and sets the property SiteId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The site tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
