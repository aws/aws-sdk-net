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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDevice operation. Creates a new device in
    /// a global network. If you specify both a site ID and a location, the location of the
    /// site is used for visualization in the Network Manager console.
    /// </summary>
    public partial class CreateDeviceRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AWSLocation. 
        /// <para>
        /// The Amazon Web Services location of the device, if applicable. For an on-premises
        /// device, you can omit this parameter.
        /// </para>
        /// </summary>
        public AWSLocation AWSLocation { get; set; }

        /// <summary>
        /// Checks to see if the AWSLocation property is set.
        /// </summary>
        internal bool IsSetAWSLocation() => this.AWSLocation != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The ID of the site.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the resource during creation.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;
    }
}
