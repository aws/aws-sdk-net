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
    /// Container for the parameters to the UpdateRouterOutput operation.
    /// Updates the configuration of an existing router output in AWS Elemental MediaConnect.
    /// </summary>
    public partial class UpdateRouterOutputRequest : AmazonMediaConnectRequest
    {
        private string _arn;
        private RouterOutputConfiguration _configuration;
        private MaintenanceConfiguration _maintenanceConfiguration;
        private long? _maximumBitrate;
        private string _name;
        private RoutingScope _routingScope;
        private RouterOutputTier _tier;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router output that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated configuration settings for the router output. Changing the type of the
        /// configuration is not supported.
        /// </para>
        /// </summary>
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
        /// The updated maintenance configuration settings for the router output, including any
        /// changes to preferred maintenance windows and schedules.
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
        /// The updated maximum bitrate for the router output.
        /// </para>
        /// </summary>
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
        /// The updated name for the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Specifies whether the router output can take inputs that are in different Regions.
        /// REGIONAL (default) - can only take inputs from same Region. GLOBAL - can take inputs
        /// from any Region.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tier. 
        /// <para>
        /// The updated tier level for the router output.
        /// </para>
        /// </summary>
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