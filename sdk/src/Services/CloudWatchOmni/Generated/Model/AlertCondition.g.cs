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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The condition that determines when the alert fires. On UpdateAlert a supplied condition
    /// is replaced whole, not merged: an omitted {@code warningThreshold} or {@code criticalThreshold}
    /// removes that tier, and an omitted {@code thresholdField} clears it. A condition must
    /// keep at least one tier. {@code thresholdMode} and {@code comparator} are optional
    /// at the Smithy level (so a single-tier condition is expressible) but are required whenever
    /// a threshold is present; enforced by the service-side validator.
    /// </summary>
    public partial class AlertCondition
    {
        /// <summary>
        /// Gets and sets the property Comparator. The comparison operator applied to the threshold.
        /// </summary>
        public Comparator Comparator { get; set; }

        /// <summary>
        /// Checks to see if the Comparator property is set.
        /// </summary>
        internal bool IsSetComparator() => this.Comparator != null;

        /// <summary>
        /// Gets and sets the property CriticalThreshold. The value at which the alert enters
        /// the CRITICAL state.
        /// </summary>
        public double? CriticalThreshold { get; set; }

        /// <summary>
        /// Checks to see if the CriticalThreshold property is set.
        /// </summary>
        internal bool IsSetCriticalThreshold() => this.CriticalThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdField. The field the threshold is evaluated against.
        /// </summary>
        [AWSProperty(Max = 256)]
        public string ThresholdField { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdField property is set.
        /// </summary>
        internal bool IsSetThresholdField() => this.ThresholdField != null;

        /// <summary>
        /// Gets and sets the property ThresholdMode. How the threshold is applied to query results.
        /// </summary>
        public ThresholdMode ThresholdMode { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdMode property is set.
        /// </summary>
        internal bool IsSetThresholdMode() => this.ThresholdMode != null;

        /// <summary>
        /// Gets and sets the property WarningThreshold. The value at which the alert enters the
        /// WARNING state.
        /// </summary>
        public double? WarningThreshold { get; set; }

        /// <summary>
        /// Checks to see if the WarningThreshold property is set.
        /// </summary>
        internal bool IsSetWarningThreshold() => this.WarningThreshold.HasValue;
    }
}
