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
    /// This is the response object from the DescribeGeofenceCollection operation.
    /// </summary>
    public partial class DescribeGeofenceCollectionResponse : AmazonWebServiceResponse
    {
        private string _collectionArn;
        private string _collectionName;
        private DateTime? _createTime;
        private string _description;
        private string _kmsKeyId;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CollectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the geofence collection resource. Used when you
        /// need to specify a resource across all Amazon Web Services. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <code>arn:aws:geo:region:account-id:geofence-collection/ExampleGeofenceCollection</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string CollectionArn
        {
            get { return this._collectionArn; }
            set { this._collectionArn = value; }
        }

        // Check to see if CollectionArn property is set
        internal bool IsSetCollectionArn()
        {
            return this._collectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The name of the geofence collection.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the geofence resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the geofence collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
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
        /// Web Services KMS customer managed key</a> assigned to the Amazon Location resource
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
        /// No longer used. Always returns <code>RequestBasedUsage</code>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. Always returns RequestBasedUsage.")]
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
        /// No longer used. Always returns an empty string.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. Unused.")]
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
        /// Displays the key, value pairs of tags associated with this resource.
        /// </para>
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp for when the geofence collection was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}