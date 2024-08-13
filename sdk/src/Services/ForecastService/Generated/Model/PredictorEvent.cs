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
    /// Provides details about a predictor event, such as a retraining.
    /// </summary>
    public partial class PredictorEvent
    {
        private DateTime? _datetime;
        private string _detail;

        /// <summary>
        /// Gets and sets the property Datetime. 
        /// <para>
        /// The timestamp for when the event occurred.
        /// </para>
        /// </summary>
        public DateTime? Datetime
        {
            get { return this._datetime; }
            set { this._datetime = value; }
        }

        // Check to see if Datetime property is set
        internal bool IsSetDatetime()
        {
            return this._datetime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The type of event. For example, <c>Retrain</c>. A retraining event denotes the timepoint
        /// when a predictor was retrained. Any monitor results from before the <c>Datetime</c>
        /// are from the previous predictor. Any new metrics are for the newly retrained predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

    }
}