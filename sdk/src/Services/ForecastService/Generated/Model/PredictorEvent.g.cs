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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Datetime. 
        /// <para>
        /// The timestamp for when the event occurred.
        /// </para>
        /// </summary>
        public DateTime? Datetime { get; set; }

        /// <summary>
        /// Checks to see if the Datetime property is set.
        /// </summary>
        internal bool IsSetDatetime() => this.Datetime.HasValue;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The type of event. For example, <c>Retrain</c>. A retraining event denotes the timepoint
        /// when a predictor was retrained. Any monitor results from before the <c>Datetime</c>
        /// are from the previous predictor. Any new metrics are for the newly retrained predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;
    }
}
