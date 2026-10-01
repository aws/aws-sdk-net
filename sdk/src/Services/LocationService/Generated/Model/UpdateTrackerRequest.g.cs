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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTracker operation. Updates the specified
    /// properties of a given tracker resource.
    /// </summary>
    public partial class UpdateTrackerRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBridgeEnabled. 
        /// <para>
        /// Whether to enable position <c>UPDATE</c> events from this tracker to be sent to EventBridge.
        /// </para>
        ///  <note> 
        /// <para>
        /// You do not need enable this feature to get <c>ENTER</c> and <c>EXIT</c> events for
        /// geofences with this tracker. Those events are always sent to EventBridge.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EventBridgeEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeEnabled property is set.
        /// </summary>
        internal bool IsSetEventBridgeEnabled() => this.EventBridgeEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyEnableGeospatialQueries. 
        /// <para>
        /// Enables <c>GeospatialQueries</c> for a tracker that uses a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html">Amazon
        /// Web Services KMS customer managed key</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only used if you are using a KMS customer managed key.
        /// </para>
        /// </summary>
        public bool? KmsKeyEnableGeospatialQueries { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyEnableGeospatialQueries property is set.
        /// </summary>
        internal bool IsSetKmsKeyEnableGeospatialQueries() => this.KmsKeyEnableGeospatialQueries.HasValue;

        /// <summary>
        /// Gets and sets the property PositionFiltering. 
        /// <para>
        /// Updates the position filtering for the tracker resource.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TimeBased</c> - Location updates are evaluated against linked geofence collections,
        /// but not every location update is stored. If your update frequency is more often than
        /// 30 seconds, only one update per 30 seconds is stored for each unique device ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DistanceBased</c> - If the device has moved less than 30 m (98.4 ft), location
        /// updates are ignored. Location updates within this distance are neither evaluated against
        /// linked geofence collections, nor stored. This helps control costs by reducing the
        /// number of geofence evaluations and historical device positions to paginate through.
        /// Distance-based filtering can also reduce the effects of GPS noise when displaying
        /// device trajectories on a map. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccuracyBased</c> - If the device has moved less than the measured accuracy, location
        /// updates are ignored. For example, if two consecutive updates from a device have a
        /// horizontal accuracy of 5 m and 10 m, the second update is ignored if the device has
        /// moved less than 15 m. Ignored location updates are neither evaluated against linked
        /// geofence collections, nor stored. This helps educe the effects of GPS noise when displaying
        /// device trajectories on a map, and can help control costs by reducing the number of
        /// geofence evaluations. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PositionFiltering PositionFiltering { get; set; }

        /// <summary>
        /// Checks to see if the PositionFiltering property is set.
        /// </summary>
        internal bool IsSetPositionFiltering() => this.PositionFiltering != null;

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// No longer used. If included, the only allowed value is <c>RequestBasedUsage</c>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. If included, the only allowed value is RequestBasedUsage.")]
        public PricingPlan PricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlan property is set.
        /// </summary>
        internal bool IsSetPricingPlan() => this.PricingPlan != null;

        /// <summary>
        /// Gets and sets the property PricingPlanDataSource. 
        /// <para>
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. No longer allowed.")]
        public string PricingPlanDataSource { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlanDataSource property is set.
        /// </summary>
        internal bool IsSetPricingPlanDataSource() => this.PricingPlanDataSource != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;
    }
}
