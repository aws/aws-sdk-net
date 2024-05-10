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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The forecast configuration that is used in a line chart's display properties.
    /// </summary>
    public partial class ForecastConfiguration
    {
        private TimeBasedForecastProperties _forecastProperties;
        private ForecastScenario _scenario;

        /// <summary>
        /// Gets and sets the property ForecastProperties. 
        /// <para>
        /// The forecast properties setup of a forecast in the line chart.
        /// </para>
        /// </summary>
        public TimeBasedForecastProperties ForecastProperties
        {
            get { return this._forecastProperties; }
            set { this._forecastProperties = value; }
        }

        // Check to see if ForecastProperties property is set
        internal bool IsSetForecastProperties()
        {
            return this._forecastProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Scenario. 
        /// <para>
        /// The forecast scenario of a forecast in the line chart.
        /// </para>
        /// </summary>
        public ForecastScenario Scenario
        {
            get { return this._scenario; }
            set { this._scenario = value; }
        }

        // Check to see if Scenario property is set
        internal bool IsSetScenario()
        {
            return this._scenario != null;
        }

    }
}