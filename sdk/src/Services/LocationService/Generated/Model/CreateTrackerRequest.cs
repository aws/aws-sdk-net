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
    /// Container for the parameters to the CreateTracker operation.
    /// Creates a tracker resource in your Amazon Web Services account, which lets you retrieve
    /// current and historical location of devices.
    /// </summary>
    public partial class CreateTrackerRequest : AmazonLocationServiceRequest
    {
        private string _description;
        private string _kmsKeyId;
        private PositionFiltering _positionFiltering;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the tracker resource.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// A key identifier for an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html">Amazon
        /// Web Services KMS customer managed key</a>. Enter a key ID, key ARN, alias name, or
        /// alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PositionFiltering. 
        /// <para>
        /// Specifies the position filtering for the tracker resource.
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
        /// updates are ignored. Location updates within this area are neither evaluated against
        /// linked geofence collections, nor stored. This helps control costs by reducing the
        /// number of geofence evaluations and historical device positions to paginate through.
        /// Distance-based filtering can also reduce the effects of GPS noise when displaying
        /// device trajectories on a map. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccuracyBased</code> - If the device has moved less than the measured accuracy,
        /// location updates are ignored. For example, if two consecutive updates from a device
        /// have a horizontal accuracy of 5 m and 10 m, the second update is ignored if the device
        /// has moved less than 15 m. Ignored location updates are neither evaluated against linked
        /// geofence collections, nor stored. This can reduce the effects of GPS noise when displaying
        /// device trajectories on a map, and can help control your costs by reducing the number
        /// of geofence evaluations. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field is optional. If not specified, the default value is <code>TimeBased</code>.
        /// </para>
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
        /// No longer used. If included, the only allowed value is <code>RequestBasedUsage</code>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. If included, the only allowed value is RequestBasedUsage.")]
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
        /// This parameter is no longer used.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. No longer allowed.")]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to the tracker resource. A tag is a key-value pair helps
        /// manage, identify, search, and filter your resources by labelling them.
        /// </para>
        ///  
        /// <para>
        /// Format: <code>"key" : "value"</code> 
        /// </para>
        ///  
        /// <para>
        /// Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum 50 tags per resource
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource tag must be unique with a maximum of one value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can use alphanumeric characters (A–Z, a–z, 0–9), and the following characters: + -
        /// = . _ : / @. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot use "aws:" as a prefix for a key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name for the tracker resource.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A-Z, a-z, 0-9) , hyphens (-), periods (.), and
        /// underscores (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique tracker resource name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExampleTracker</code>.
        /// </para>
        ///  </li> </ul>
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