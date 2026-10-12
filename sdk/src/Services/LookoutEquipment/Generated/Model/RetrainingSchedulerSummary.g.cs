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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Provides information about the specified retraining scheduler, including model name,
    /// status, start date, frequency, and lookback window.
    /// </summary>
    public partial class RetrainingSchedulerSummary
    {
        /// <summary>
        /// Gets and sets the property LookbackWindow. 
        /// <para>
        /// The number of past days of data used for retraining.
        /// </para>
        /// </summary>
        public string LookbackWindow { get; set; }

        /// <summary>
        /// Checks to see if the LookbackWindow property is set.
        /// </summary>
        internal bool IsSetLookbackWindow() => this.LookbackWindow != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the model that the retraining scheduler is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model that the retraining scheduler is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RetrainingFrequency. 
        /// <para>
        /// The frequency at which the model retraining is set. This follows the <a href="https://en.wikipedia.org/wiki/ISO_8601#Durations">ISO
        /// 8601</a> guidelines.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string RetrainingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingFrequency property is set.
        /// </summary>
        internal bool IsSetRetrainingFrequency() => this.RetrainingFrequency != null;

        /// <summary>
        /// Gets and sets the property RetrainingStartDate. 
        /// <para>
        /// The start date for the retraining scheduler. Lookout for Equipment truncates the time
        /// you provide to the nearest UTC day.
        /// </para>
        /// </summary>
        public DateTime? RetrainingStartDate { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingStartDate property is set.
        /// </summary>
        internal bool IsSetRetrainingStartDate() => this.RetrainingStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the retraining scheduler. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
