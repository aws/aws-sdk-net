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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// A transformation function is a pair of operations that select and modify the rows
    /// in a related time series. You select the rows that you want with a condition operation
    /// and you modify the rows with a transformation operation. All conditions are joined
    /// with an AND operation, meaning that all conditions must be true for the transformation
    /// to be applied. Transformations are applied in the order that they are listed.
    /// </summary>
    public partial class TimeSeriesTransformation
    {
        private Action _action;
        private List<TimeSeriesCondition> _timeSeriesConditions = AWSConfigs.InitializeCollections ? new List<TimeSeriesCondition>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// An array of actions that define a time series and how it is transformed. These transformations
        /// create a new time series that is used for the what-if analysis.
        /// </para>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesConditions. 
        /// <para>
        /// An array of conditions that define which members of the related time series are transformed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TimeSeriesCondition> TimeSeriesConditions
        {
            get { return this._timeSeriesConditions; }
            set { this._timeSeriesConditions = value; }
        }

        // Check to see if TimeSeriesConditions property is set
        internal bool IsSetTimeSeriesConditions()
        {
            return this._timeSeriesConditions != null && (this._timeSeriesConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}