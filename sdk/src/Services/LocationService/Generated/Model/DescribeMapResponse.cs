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
    /// This is the response object from the DescribeMap operation.
    /// </summary>
    public partial class DescribeMapResponse : AmazonWebServiceResponse
    {
        private MapConfiguration _configuration;
        private DateTime? _createTime;
        private string _dataSource;
        private string _description;
        private string _mapArn;
        private string _mapName;
        private PricingPlan _pricingPlan;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the map tile style selected from a partner data provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapConfiguration Configuration
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the map resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>.
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Specifies the data provider for the associated map tiles.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the map resource.
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
        /// Gets and sets the property MapArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the map resource. Used to specify a resource across
        /// all Amazon Web Services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <code>arn:aws:geo:region:account-id:map/ExampleMap</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string MapArn
        {
            get { return this._mapArn; }
            set { this._mapArn = value; }
        }

        // Check to see if MapArn property is set
        internal bool IsSetMapArn()
        {
            return this._mapArn != null;
        }

        /// <summary>
        /// Gets and sets the property MapName. 
        /// <para>
        /// The map style selected from an available provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MapName
        {
            get { return this._mapName; }
            set { this._mapName = value; }
        }

        // Check to see if MapName property is set
        internal bool IsSetMapName()
        {
            return this._mapName != null;
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the map resource.
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
        /// The timestamp for when the map resource was last update in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>.
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