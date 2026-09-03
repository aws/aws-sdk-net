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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRouterOutput operation. Creates a new router
    /// output in AWS Elemental MediaConnect.
    /// </summary>
    public partial class CreateRouterOutputRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where you want to create the router output. This must be a valid
        /// Availability Zone for the region specified by <c>regionName</c>, or the current region
        /// if no <c>regionName</c> is provided. 
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property FabricConfiguration. 
        /// <para>
        /// The fabric configuration settings for the router output.
        /// </para>
        /// </summary>
        public FabricConfiguration FabricConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FabricConfiguration property is set.
        /// </summary>
        internal bool IsSetFabricConfiguration() => this.FabricConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaintenanceConfiguration. 
        /// <para>
        /// The maintenance configuration settings for the router output, including preferred
        /// maintenance windows and schedules.
        /// </para>
        /// </summary>
        public MaintenanceConfiguration MaintenanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceConfiguration property is set.
        /// </summary>
        internal bool IsSetMaintenanceConfiguration() => this.MaintenanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region for the router output. Defaults to the current region
        /// if not specified.
        /// </para>
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Specifies whether the router output can take inputs that are in different Regions.
        /// REGIONAL (default) - can only take inputs from same Region. GLOBAL - can take inputs
        /// from any Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingScope RoutingScope { get; set; }

        /// <summary>
        /// Checks to see if the RoutingScope property is set.
        /// </summary>
        internal bool IsSetRoutingScope() => this.RoutingScope != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to tag this router output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier level for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
