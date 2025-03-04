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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This object defines the length of the look-back window used to calculate one burn
    /// rate metric for this SLO. The burn rate measures how fast the service is consuming
    /// the error budget, relative to the attainment goal of the SLO. A burn rate of exactly
    /// 1 indicates that the SLO goal will be met exactly.
    /// 
    ///  
    /// <para>
    /// For example, if you specify 60 as the number of minutes in the look-back window, the
    /// burn rate is calculated as the following:
    /// </para>
    ///  
    /// <para>
    ///  <i>burn rate = error rate over the look-back window / (100% - attainment goal percentage)</i>
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information about burn rates, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html#CloudWatch-ServiceLevelObjectives-burn">Calculate
    /// burn rates</a>.
    /// </para>
    /// </summary>
    public partial class BurnRateConfiguration
    {
        private int? _lookBackWindowMinutes;

        /// <summary>
        /// Gets and sets the property LookBackWindowMinutes. 
        /// <para>
        /// The number of minutes to use as the look-back window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10080)]
        public int? LookBackWindowMinutes
        {
            get { return this._lookBackWindowMinutes; }
            set { this._lookBackWindowMinutes = value; }
        }

        // Check to see if LookBackWindowMinutes property is set
        internal bool IsSetLookBackWindowMinutes()
        {
            return this._lookBackWindowMinutes.HasValue; 
        }

    }
}