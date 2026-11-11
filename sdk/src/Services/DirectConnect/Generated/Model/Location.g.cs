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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an Direct Connect location.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Gets and sets the property AvailableBillingModes. 
        /// <para>
        /// The billing modes available at the location, including the port speeds and Amazon
        /// Web Services Regions supported by each mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailableBillingMode> AvailableBillingModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailableBillingMode>() : null;

        /// <summary>
        /// Checks to see if the AvailableBillingModes property is set.
        /// </summary>
        internal bool IsSetAvailableBillingModes() => this.AvailableBillingModes != null && (this.AvailableBillingModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableMacSecPortSpeeds. 
        /// <para>
        /// The available MAC Security (MACsec) port speeds for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailableMacSecPortSpeeds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableMacSecPortSpeeds property is set.
        /// </summary>
        internal bool IsSetAvailableMacSecPortSpeeds() => this.AvailableMacSecPortSpeeds != null && (this.AvailableMacSecPortSpeeds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailablePortSpeeds. 
        /// <para>
        /// The available port speeds for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailablePortSpeeds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailablePortSpeeds property is set.
        /// </summary>
        internal bool IsSetAvailablePortSpeeds() => this.AvailablePortSpeeds != null && (this.AvailablePortSpeeds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailableProviders. 
        /// <para>
        /// The name of the service provider for the location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailableProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailableProviders property is set.
        /// </summary>
        internal bool IsSetAvailableProviders() => this.AvailableProviders != null && (this.AvailableProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocationCode. 
        /// <para>
        /// The code for the location.
        /// </para>
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// Checks to see if the LocationCode property is set.
        /// </summary>
        internal bool IsSetLocationCode() => this.LocationCode != null;

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// The name of the location. This includes the name of the colocation partner and the
        /// physical site of the building.
        /// </para>
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// Checks to see if the LocationName property is set.
        /// </summary>
        internal bool IsSetLocationName() => this.LocationName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for the location.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
