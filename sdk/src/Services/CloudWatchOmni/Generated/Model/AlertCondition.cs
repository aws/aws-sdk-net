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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
    /// The condition that determines when the alert fires.
    /// 
    ///  
    /// <para>
    /// On UpdateAlert a supplied condition is replaced whole, not merged: an omitted {@code
    /// warningThreshold} or {@code criticalThreshold} removes that tier, and an omitted {@code
    /// thresholdField} clears it. A condition must keep at least one tier. {@code thresholdMode}
    /// and {@code comparator} are optional at the Smithy level (so a single-tier condition
    /// is expressible) but are required whenever a threshold is present; enforced by the
    /// service-side validator.
    /// </para>
    /// </summary>
    public partial class AlertCondition
    {
        private Comparator _comparator;
        private double? _criticalThreshold;
        private string _thresholdField;
        private ThresholdMode _thresholdMode;
        private double? _warningThreshold;

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The comparison operator applied to the threshold.
        /// </para>
        /// </summary>
        public Comparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property CriticalThreshold. 
        /// <para>
        /// The value at which the alert enters the CRITICAL state.
        /// </para>
        /// </summary>
        public double? CriticalThreshold
        {
            get { return this._criticalThreshold; }
            set { this._criticalThreshold = value; }
        }

        // Check to see if CriticalThreshold property is set
        internal bool IsSetCriticalThreshold()
        {
            return this._criticalThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdField. 
        /// <para>
        /// The field the threshold is evaluated against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ThresholdField
        {
            get { return this._thresholdField; }
            set { this._thresholdField = value; }
        }

        // Check to see if ThresholdField property is set
        internal bool IsSetThresholdField()
        {
            return this._thresholdField != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdMode. 
        /// <para>
        /// How the threshold is applied to query results.
        /// </para>
        /// </summary>
        public ThresholdMode ThresholdMode
        {
            get { return this._thresholdMode; }
            set { this._thresholdMode = value; }
        }

        // Check to see if ThresholdMode property is set
        internal bool IsSetThresholdMode()
        {
            return this._thresholdMode != null;
        }

        /// <summary>
        /// Gets and sets the property WarningThreshold. 
        /// <para>
        /// The value at which the alert enters the WARNING state.
        /// </para>
        /// </summary>
        public double? WarningThreshold
        {
            get { return this._warningThreshold; }
            set { this._warningThreshold = value; }
        }

        // Check to see if WarningThreshold property is set
        internal bool IsSetWarningThreshold()
        {
            return this._warningThreshold.HasValue; 
        }

    }
}