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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
        private string _diagnostics;
        private long? _eventDurationInSeconds;
        private DateTime? _eventEndTime;
        private DateTime? _eventStartTime;
        private string _inferenceSchedulerArn;
        private string _inferenceSchedulerName;

        /// <summary>
        /// Gets and sets the property Diagnostics. 
        /// <para>
        ///  An array which specifies the names and values of all sensors contributing to an inference
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50000)]
        public string Diagnostics
        {
            get { return this._diagnostics; }
            set { this._diagnostics = value; }
        }

        // Check to see if Diagnostics property is set
        internal bool IsSetDiagnostics()
        {
            return this._diagnostics != null;
        }

        /// <summary>
        /// Gets and sets the property EventDurationInSeconds. 
        /// <para>
        ///  Indicates the size of an inference event in seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? EventDurationInSeconds
        {
            get { return this._eventDurationInSeconds; }
            set { this._eventDurationInSeconds = value; }
        }

        // Check to see if EventDurationInSeconds property is set
        internal bool IsSetEventDurationInSeconds()
        {
            return this._eventDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventEndTime. 
        /// <para>
        /// Indicates the ending time of an inference event. 
        /// </para>
        /// </summary>
        public DateTime? EventEndTime
        {
            get { return this._eventEndTime; }
            set { this._eventEndTime = value; }
        }

        // Check to see if EventEndTime property is set
        internal bool IsSetEventEndTime()
        {
            return this._eventEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventStartTime. 
        /// <para>
        /// Indicates the starting time of an inference event. 
        /// </para>
        /// </summary>
        public DateTime? EventStartTime
        {
            get { return this._eventStartTime; }
            set { this._eventStartTime = value; }
        }

        // Check to see if EventStartTime property is set
        internal bool IsSetEventStartTime()
        {
            return this._eventStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inference scheduler being used for the inference
        /// event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string InferenceSchedulerArn
        {
            get { return this._inferenceSchedulerArn; }
            set { this._inferenceSchedulerArn = value; }
        }

        // Check to see if InferenceSchedulerArn property is set
        internal bool IsSetInferenceSchedulerArn()
        {
            return this._inferenceSchedulerArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being used for the inference events. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string InferenceSchedulerName
        {
            get { return this._inferenceSchedulerName; }
            set { this._inferenceSchedulerName = value; }
        }

        // Check to see if InferenceSchedulerName property is set
        internal bool IsSetInferenceSchedulerName()
        {
            return this._inferenceSchedulerName != null;
        }

    }
}