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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePlaceIndex operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// you upgrade to the Places API V2 unless you require Grab data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>UpdatePlaceIndex</c> is part of a previous Amazon Location Service Places API
    /// (version 1) which has been superseded by a more intuitive, powerful, and complete
    /// API (version 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Places API version 2 has a simplified interface that can be used without creating
    /// or managing place index resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using an Amazon Web Services SDK or the Amazon Web Services CLI, note that
    /// the Places API version 2 is found under <c>geo-places</c> or <c>geo_places</c>, not
    /// under <c>location</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Since Grab is not yet fully supported in Places API version 2, we recommend you continue
    /// using API version 1 when using Grab.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Start your version 2 API journey with the Places V2 <a href="/location/latest/APIReference/API_Operations_Amazon_Location_Service_Places_V2.html">API
    /// Reference</a> or the <a href="/location/latest/developerguide/places.html">Developer
    /// Guide</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Updates the specified properties of a given place index resource.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class UpdatePlaceIndexRequest : AmazonLocationServiceRequest
    {
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _description;
        private string _indexName;
        private PricingPlan _pricingPlan;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Updates the data storage option for the place index resource.
        /// </para>
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration
        {
            get { return this._dataSourceConfiguration; }
            set { this._dataSourceConfiguration = value; }
        }

        // Check to see if DataSourceConfiguration property is set
        internal bool IsSetDataSourceConfiguration()
        {
            return this._dataSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the description for the place index resource.
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
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// No longer used. If included, the only allowed value is <c>RequestBasedUsage</c>.
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

    }
}