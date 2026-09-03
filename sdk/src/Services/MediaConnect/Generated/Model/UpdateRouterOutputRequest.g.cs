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
    /// Container for the parameters to the UpdateRouterOutput operation. Updates the configuration
    /// of an existing router output in AWS Elemental MediaConnect.
    /// </summary>
    public partial class UpdateRouterOutputRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router output that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated configuration settings for the router output. Changing the type of the
        /// configuration is not supported.
        /// </para>
        /// </summary>
        public RouterOutputConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property FabricConfiguration. 
        /// <para>
        /// The updated fabric configuration settings for the router output. You cannot update
        /// the fabric configuration while the output has an active route. You must unroute the
        /// output before updating the fabric configuration.
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
        /// The updated maintenance configuration settings for the router output, including any
        /// changes to preferred maintenance windows and schedules.
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
        /// The updated maximum bitrate for the router output.
        /// </para>
        /// </summary>
        public long? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Specifies whether the router output can take inputs that are in different Regions.
        /// REGIONAL (default) - can only take inputs from same Region. GLOBAL - can take inputs
        /// from any Region.
        /// </para>
        /// </summary>
        public RoutingScope RoutingScope { get; set; }

        /// <summary>
        /// Checks to see if the RoutingScope property is set.
        /// </summary>
        internal bool IsSetRoutingScope() => this.RoutingScope != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The updated tier level for the router output.
        /// </para>
        /// </summary>
        public RouterOutputTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
