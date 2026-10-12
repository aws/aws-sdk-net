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
    /// Contains information about the specific inference event, including start and end time,
    /// diagnostics information, event duration and so on.
    /// </summary>
    public partial class InferenceEventSummary
    {
        /// <summary>
        /// Gets and sets the property Diagnostics. 
        /// <para>
        ///  An array which specifies the names and values of all sensors contributing to an inference
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string Diagnostics { get; set; }

        /// <summary>
        /// Checks to see if the Diagnostics property is set.
        /// </summary>
        internal bool IsSetDiagnostics() => this.Diagnostics != null;

        /// <summary>
        /// Gets and sets the property EventDurationInSeconds. 
        /// <para>
        ///  Indicates the size of an inference event in seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EventDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EventDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetEventDurationInSeconds() => this.EventDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// Indicates the ending time of an inference event. 
        /// </para>
        /// </summary>
        public DateTime? EventEndTime { get; set; }

        /// <summary>
        /// Checks to see if the EventEndTime property is set.
        /// </summary>
        internal bool IsSetEventEndTime() => this.EventEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventStartTime. 
        /// <para>
        /// Indicates the starting time of an inference event. 
        /// </para>
        /// </summary>
        public DateTime? EventStartTime { get; set; }

        /// <summary>
        /// Checks to see if the EventStartTime property is set.
        /// </summary>
        internal bool IsSetEventStartTime() => this.EventStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inference scheduler being used for the inference
        /// event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string InferenceSchedulerArn { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerArn property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerArn() => this.InferenceSchedulerArn != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being used for the inference events. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;
    }
}
