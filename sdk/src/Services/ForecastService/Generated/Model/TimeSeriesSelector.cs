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
    /// Defines the set of time series that are used to create the forecasts in a <c>TimeSeriesIdentifiers</c>
    /// object.
    /// 
    ///  
    /// <para>
    /// The <c>TimeSeriesIdentifiers</c> object needs the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DataSource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Format</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Schema</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TimeSeriesSelector
    {
        private TimeSeriesIdentifiers _timeSeriesIdentifiers;

        /// <summary>
        /// Gets and sets the property TimeSeriesIdentifiers. 
        /// <para>
        /// Details about the import file that contains the time series for which you want to
        /// create forecasts.
        /// </para>
        /// </summary>
        public TimeSeriesIdentifiers TimeSeriesIdentifiers
        {
            get { return this._timeSeriesIdentifiers; }
            set { this._timeSeriesIdentifiers = value; }
        }

        // Check to see if TimeSeriesIdentifiers property is set
        internal bool IsSetTimeSeriesIdentifiers()
        {
            return this._timeSeriesIdentifiers != null;
        }

    }
}