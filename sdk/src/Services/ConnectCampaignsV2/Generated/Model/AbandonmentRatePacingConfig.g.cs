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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Configuration for abandonment-rate-based dialer throttling.
    /// </summary>
    public partial class AbandonmentRatePacingConfig
    {
        /// <summary>
        /// Gets and sets the property ConnectionStartPoint. Event from which connectionThresholdSeconds
        /// is measured.
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionStartPoint ConnectionStartPoint { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStartPoint property is set.
        /// </summary>
        internal bool IsSetConnectionStartPoint() => this.ConnectionStartPoint != null;

        /// <summary>
        /// Gets and sets the property ConnectionThresholdSeconds. Seconds after connectionStartPoint
        /// before a contact counts as abandoned.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? ConnectionThresholdSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionThresholdSeconds property is set.
        /// </summary>
        internal bool IsSetConnectionThresholdSeconds() => this.ConnectionThresholdSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationWindow. Rolling window over which abandonmentRate
        /// is computed.
        /// </summary>
        [AWSProperty(Required = true, Max = 5)]
        public string EvaluationWindow { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationWindow property is set.
        /// </summary>
        internal bool IsSetEvaluationWindow() => this.EvaluationWindow != null;

        /// <summary>
        /// Gets and sets the property TargetRate.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? TargetRate { get; set; }

        /// <summary>
        /// Checks to see if the TargetRate property is set.
        /// </summary>
        internal bool IsSetTargetRate() => this.TargetRate.HasValue;
    }
}
