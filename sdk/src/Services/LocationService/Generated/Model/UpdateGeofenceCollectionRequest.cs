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
    /// Container for the parameters to the UpdateGeofenceCollection operation.
    /// Updates the specified properties of a given geofence collection.
    /// </summary>
    public partial class UpdateGeofenceCollectionRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private string _description;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The name of the geofence collection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CollectionName
        {
            get { return this._collectionName; }
            set { this._collectionName = value; }
        }

        // Check to see if CollectionName property is set
        internal bool IsSetCollectionName()
        {
            return this._collectionName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the geofence collection.
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
        /// Updates the pricing plan for the geofence collection.
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
        /// Updates the data provider for the geofence collection. 
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
        /// see the Amazon Location Service product page.
        /// </para>
        ///  <note> 
        /// <para>
        /// This can only be updated when updating the <code>PricingPlan</code> in the same request.
        /// </para>
        ///  
        /// <para>
        /// Amazon Location Service uses <code>PricingPlanDataSource</code> to calculate billing
        /// for your geofence collection. Your data won't be shared with the data provider, and
        /// will remain in your AWS account and Region unless you move it.
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

    }
}