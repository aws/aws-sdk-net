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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the GetPredictiveScalingForecast operation.
    /// </summary>
    public partial class GetPredictiveScalingForecastResponse : AmazonWebServiceResponse
    {
        private CapacityForecast _capacityForecast;
        private List<LoadForecast> _loadForecast = AWSConfigs.InitializeCollections ? new List<LoadForecast>() : null;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CapacityForecast. 
        /// <para>
        /// The capacity forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityForecast CapacityForecast
        {
            get { return this._capacityForecast; }
            set { this._capacityForecast = value; }
        }

        // Check to see if CapacityForecast property is set
        internal bool IsSetCapacityForecast()
        {
            return this._capacityForecast != null;
        }

        /// <summary>
        /// Gets and sets the property LoadForecast. 
        /// <para>
        /// The load forecast.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LoadForecast> LoadForecast
        {
            get { return this._loadForecast; }
            set { this._loadForecast = value; }
        }

        // Check to see if LoadForecast property is set
        internal bool IsSetLoadForecast()
        {
            return this._loadForecast != null && (this._loadForecast.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the forecast was made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}