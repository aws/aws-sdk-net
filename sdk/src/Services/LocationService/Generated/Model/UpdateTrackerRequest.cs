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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTracker operation.
    /// Updates the specified properties of a given tracker resource.
    /// </summary>
    public partial class UpdateTrackerRequest : AmazonLocationServiceRequest
    {
        private string _description;
        private PositionFiltering _positionFiltering;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        ///  <code>TimeBased</code> - Location updates are evaluated against linked geofence collections,
        /// but not every location update is stored. If your update frequency is more often than
        /// 30 seconds, only one update per 30 seconds is stored for each unique device ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DistanceBased</code> - If the device has moved less than 30 m (98.4 ft), location
        /// updates are ignored. Location updates within this distance are neither evaluated against
        /// linked geofence collections, nor stored. This helps control costs by reducing the
        /// number of geofence evaluations and device positions to retrieve. Distance-based filtering
        /// can also reduce the jitter effect when displaying device trajectory on a map. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PositionFiltering PositionFiltering
        {
            get { return this._positionFiltering; }
            set { this._positionFiltering = value; }
        }

        // Check to see if PositionFiltering property is set
        internal bool IsSetPositionFiltering()
        {
            return this._positionFiltering != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Updates the pricing plan for the tracker resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about each pricing plan option restrictions, see <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service pricing</a>.
        /// </para>
        /// </summary>
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlanDataSource. 
        /// <para>
        /// Updates the data provider for the tracker resource. 
        /// </para>
        ///  
        /// <para>
        /// A required value for the following pricing plans: <code>MobileAssetTracking</code>|
        /// <code>MobileAssetManagement</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information about <a href="https://aws.amazon.com/location/data-providers/">data
        /// providers</a> and <a href="https://aws.amazon.com/location/pricing/">pricing plans</a>,
        /// see the Amazon Location Service product page
        /// </para>
        ///  <note> 
        /// <para>
        /// This can only be updated when updating the <code>PricingPlan</code> in the same request.
        /// </para>
        ///  
        /// <para>
        /// Amazon Location Service uses <code>PricingPlanDataSource</code> to calculate billing
        /// for your tracker resource. Your data won't be shared with the data provider, and will
        /// remain in your AWS account and Region unless you move it.
        /// </para>
        ///  </note>
        /// </summary>
        public string PricingPlanDataSource
        {
            get { return this._pricingPlanDataSource; }
            set { this._pricingPlanDataSource = value; }
        }

        // Check to see if PricingPlanDataSource property is set
        internal bool IsSetPricingPlanDataSource()
        {
            return this._pricingPlanDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

    }
}