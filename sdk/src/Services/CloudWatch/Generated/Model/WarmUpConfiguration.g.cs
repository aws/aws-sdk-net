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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The configuration settings that define the warm-up behavior for an alarm. Use these
    /// settings to delay alarm evaluation after you create or update the alarm, which reduces
    /// alarm noise while a new resource or service starts publishing data.
    /// 
    ///  
    /// <para>
    /// During the warm-up period, the alarm stays in <c>INSUFFICIENT_DATA</c> and does not
    /// perform alarm actions.
    /// </para>
    /// </summary>
    public partial class WarmUpConfiguration
    {
        /// <summary>
        /// Gets and sets the property OnlyStartEvaluatingAfterWarmUpPeriodEnds. 
        /// <para>
        /// Specifies whether the alarm waits for the full warm-up period before it starts to
        /// evaluate. The default is <c>false</c>. If <c>true</c>, the alarm waits the entire
        /// <c>WarmUpPeriodDurationInMinutes</c> before it starts to evaluate, even if metric
        /// data arrives earlier. If <c>false</c>, the alarm ends the warm-up period early. Evaluation
        /// begins as soon as the alarm has enough metric data to fill its evaluation window.
        /// </para>
        /// </summary>
        public bool? OnlyStartEvaluatingAfterWarmUpPeriodEnds { get; set; }

        /// <summary>
        /// Checks to see if the OnlyStartEvaluatingAfterWarmUpPeriodEnds property is set.
        /// </summary>
        internal bool IsSetOnlyStartEvaluatingAfterWarmUpPeriodEnds() => this.OnlyStartEvaluatingAfterWarmUpPeriodEnds.HasValue;

        /// <summary>
        /// Gets and sets the property WarmUpPeriodDurationInMinutes. 
        /// <para>
        /// The length of the warm-up period, in minutes. After you create or update the alarm,
        /// the alarm stays in <c>INSUFFICIENT_DATA</c> for this duration. During this time, the
        /// alarm does not perform alarm actions.
        /// </para>
        ///  
        /// <para>
        /// You can change this value at any time, including after the warm-up period ends. If
        /// you change it after the warm-up period ends, the new value does not restart the warm-up
        /// period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2880)]
        public int? WarmUpPeriodDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the WarmUpPeriodDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetWarmUpPeriodDurationInMinutes() => this.WarmUpPeriodDurationInMinutes.HasValue;
    }
}
