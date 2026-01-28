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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Container for the parameters to the CreateRouterOutput operation.
    /// Creates a new router output in AWS Elemental MediaConnect.
    /// </summary>
    public partial class CreateRouterOutputRequest : AmazonMediaConnectRequest
    {
        private string _availabilityZone;
        private string _clientToken;
        private RouterOutputConfiguration _configuration;
        private MaintenanceConfiguration _maintenanceConfiguration;
        private long? _maximumBitrate;
        private string _name;
        private string _regionName;
        private RoutingScope _routingScope;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RouterOutputTier _tier;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where you want to create the router output. This must be a valid
        /// Availability Zone for the region specified by <c>regionName</c>, or the current region
        /// if no <c>regionName</c> is provided. 
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request to ensure idempotency.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceConfiguration. 
        /// <para>
        /// The maintenance configuration settings for the router output, including preferred
        /// maintenance windows and schedules.
        /// </para>
        /// </summary>
        public MaintenanceConfiguration MaintenanceConfiguration
        {
            get { return this._maintenanceConfiguration; }
            set { this._maintenanceConfiguration = value; }
        }

        // Check to see if MaintenanceConfiguration property is set
        internal bool IsSetMaintenanceConfiguration()
        {
            return this._maintenanceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long MaximumBitrate
        {
            get { return this._maximumBitrate.GetValueOrDefault(); }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region for the router output. Defaults to the current region
        /// if not specified.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Specifies whether the router output can take inputs that are in different Regions.
        /// REGIONAL (default) - can only take inputs from same Region. GLOBAL - can take inputs
        /// from any Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingScope RoutingScope
        {
            get { return this._routingScope; }
            set { this._routingScope = value; }
        }

        // Check to see if RoutingScope property is set
        internal bool IsSetRoutingScope()
        {
            return this._routingScope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to tag this router output.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier level for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}