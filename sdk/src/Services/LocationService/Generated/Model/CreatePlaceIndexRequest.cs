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
    /// Container for the parameters to the CreatePlaceIndex operation.
    /// Creates a Place index resource in your AWS account, which supports Places functions
    /// with geospatial data sourced from your chosen data provider.
    /// 
    ///  <note> 
    /// <para>
    /// By using Places, you agree that AWS may transmit your API queries to your selected
    /// third party provider for processing, which may be outside the AWS region you are currently
    /// using. 
    /// </para>
    ///  
    /// <para>
    /// Because of licensing limitations, you may not use HERE to store results for locations
    /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePlaceIndexRequest : AmazonLocationServiceRequest
    {
        private string _dataSource;
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _description;
        private string _indexName;
        private PricingPlan _pricingPlan;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Specifies the data provider of geospatial data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Specifies the data storage option for requesting Places.
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
        /// The optional description for the Place index resource.
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
        /// The name of the Place index resource. 
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A-Z, a-z, 0-9) , hyphens (-) and underscores
        /// (_) ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique Place index resource name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExamplePlaceIndex</code>.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies the pricing plan for your Place index resource. There's three pricing plan
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RequestBasedUsage</code> — Selects the "Request-Based Usage" pricing plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MobileAssetTracking</code> — Selects the "Mobile Asset Tracking" pricing plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MobileAssetManagement</code> — Selects the "Mobile Asset Management" pricing
        /// plan.
        /// </para>
        ///  </li> </ul> 
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

    }
}