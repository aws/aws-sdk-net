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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Describes an event that occurred during an experiment run.
    /// </summary>
    public partial class ExperimentRunEvent
    {
        /// <summary>
        /// Gets and sets the property AssociatedDeployment. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment associated with this event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AssociatedDeployment { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedDeployment property is set.
        /// </summary>
        internal bool IsSetAssociatedDeployment() => this.AssociatedDeployment != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. Valid values: <c>RUN_STARTED</c>, <c>EXPOSURE_UPDATED</c>, <c>OVERRIDES_UPDATED</c>,
        /// <c>RUN_STOPPED</c>.
        /// </para>
        /// </summary>
        public ExperimentRunEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The exposure percentage at the time of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ExposurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ExposurePercentage property is set.
        /// </summary>
        internal bool IsSetExposurePercentage() => this.ExposurePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property OccurredAt. 
        /// <para>
        /// The date and time the event occurred, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? OccurredAt { get; set; }

        /// <summary>
        /// Checks to see if the OccurredAt property is set.
        /// </summary>
        internal bool IsSetOccurredAt() => this.OccurredAt.HasValue;

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// The treatment overrides at the time of the event.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentOverrides property is set.
        /// </summary>
        internal bool IsSetTreatmentOverrides() => this.TreatmentOverrides != null;

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The principal that triggered the event.
        /// </para>
        /// </summary>
        public TriggeredBy TriggeredBy { get; set; }

        /// <summary>
        /// Checks to see if the TriggeredBy property is set.
        /// </summary>
        internal bool IsSetTriggeredBy() => this.TriggeredBy != null;
    }
}
