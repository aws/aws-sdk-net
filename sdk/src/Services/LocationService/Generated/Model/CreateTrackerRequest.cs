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
    /// Creates a tracker resource in your AWS account, which lets you retrieve current and
    /// historical location of devices.
    /// </summary>
    public partial class CreateTrackerRequest : AmazonLocationServiceRequest
    {
        private string _description;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
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
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Specifies the pricing plan for your tracker resource.
        /// </para>
        ///  
        /// <para>
        /// For additional details and restrictions on each pricing plan option, see the <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service pricing page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies the plan data source. Required if the Mobile Asset Tracking (MAT) or the
        /// Mobile Asset Management (MAM) pricing plan is selected.
        /// </para>
        ///  
        /// <para>
        /// Billing is determined by the resource usage, the associated pricing plan, and data
        /// source that was specified. For more information about each pricing plan option and
        /// restrictions, see the <a href="https://aws.amazon.com/location/pricing/">Amazon Location
        /// Service pricing page</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>Esri</code> | <code>Here</code> 
        /// </para>
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