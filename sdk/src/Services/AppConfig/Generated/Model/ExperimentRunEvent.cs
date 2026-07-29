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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
        private string _associatedDeployment;
        private string _description;
        private ExperimentRunEventType _eventType;
        private float? _exposurePercentage;
        private DateTime? _occurredAt;
        private TreatmentOverrides _treatmentOverrides;
        private TriggeredBy _triggeredBy;

        /// <summary>
        /// Gets and sets the property AssociatedDeployment. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment associated with this event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AssociatedDeployment
        {
            get { return this._associatedDeployment; }
            set { this._associatedDeployment = value; }
        }

        // Check to see if AssociatedDeployment property is set
        internal bool IsSetAssociatedDeployment()
        {
            return this._associatedDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. Valid values: <c>RUN_STARTED</c>, <c>EXPOSURE_UPDATED</c>, <c>OVERRIDES_UPDATED</c>,
        /// <c>RUN_STOPPED</c>.
        /// </para>
        /// </summary>
        public ExperimentRunEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The exposure percentage at the time of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? ExposurePercentage
        {
            get { return this._exposurePercentage; }
            set { this._exposurePercentage = value; }
        }

        // Check to see if ExposurePercentage property is set
        internal bool IsSetExposurePercentage()
        {
            return this._exposurePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OccurredAt. 
        /// <para>
        /// The date and time the event occurred, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? OccurredAt
        {
            get { return this._occurredAt; }
            set { this._occurredAt = value; }
        }

        // Check to see if OccurredAt property is set
        internal bool IsSetOccurredAt()
        {
            return this._occurredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// The treatment overrides at the time of the event.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides
        {
            get { return this._treatmentOverrides; }
            set { this._treatmentOverrides = value; }
        }

        // Check to see if TreatmentOverrides property is set
        internal bool IsSetTreatmentOverrides()
        {
            return this._treatmentOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The principal that triggered the event.
        /// </para>
        /// </summary>
        public TriggeredBy TriggeredBy
        {
            get { return this._triggeredBy; }
            set { this._triggeredBy = value; }
        }

        // Check to see if TriggeredBy property is set
        internal bool IsSetTriggeredBy()
        {
            return this._triggeredBy != null;
        }

    }
}