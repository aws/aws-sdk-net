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
    /// Container for the parameters to the CreateGeofenceCollection operation.
    /// Creates a geofence collection, which manages and stores geofences.
    /// </summary>
    public partial class CreateGeofenceCollectionRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private string _description;
        private string _kmsKeyId;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// A custom name for the geofence collection.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), periods (.), and
        /// underscores (_). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique geofence collection name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExampleGeofenceCollection</code>.
        /// </para>
        ///  </li> </ul>
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
        /// An optional description for the geofence collection.
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
        /// A key identifier for an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html">AWS
        /// KMS customer managed key</a>. Enter a key ID, key ARN, alias name, or alias ARN. 
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
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Specifies the pricing plan for the geofence collection.
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
        /// Specifies the data provider for the geofence collection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required value for the following pricing plans: <code>MobileAssetTracking </code>|
        /// <code>MobileAssetManagement</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about <a href="https://aws.amazon.com/location/data-providers/">Data
        /// Providers</a>, and <a href="https://aws.amazon.com/location/pricing/">Pricing plans</a>,
        /// see the Amazon Location Service product page.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Location Service only uses <code>PricingPlanDataSource</code> to calculate
        /// billing for your geofence collection. Your data won't be shared with the data provider,
        /// and will remain in your AWS account or Region unless you move it.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>Esri </code>| <code>Here</code> 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to the geofence collection. A tag is a key-value pair helps
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

    }
}