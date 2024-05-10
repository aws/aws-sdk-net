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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about a Device Defender security profile behavior violation.
    /// </summary>
    public partial class ViolationEvent
    {
        private Behavior _behavior;
        private MetricValue _metricValue;
        private string _securityProfileName;
        private string _thingName;
        private VerificationState _verificationState;
        private string _verificationStateDescription;
        private ViolationEventAdditionalInfo _violationEventAdditionalInfo;
        private DateTime? _violationEventTime;
        private ViolationEventType _violationEventType;
        private string _violationId;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior that was violated.
        /// </para>
        /// </summary>
        public Behavior Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The value of the metric (the measurement).
        /// </para>
        /// </summary>
        public MetricValue MetricValue
        {
            get { return this._metricValue; }
            set { this._metricValue = value; }
        }

        // Check to see if MetricValue property is set
        internal bool IsSetMetricValue()
        {
            return this._metricValue != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name of the security profile whose behavior was violated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing responsible for the violation event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The verification state of the violation (detect alarm).
        /// </para>
        /// </summary>
        public VerificationState VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationStateDescription. 
        /// <para>
        /// The description of the verification state of the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string VerificationStateDescription
        {
            get { return this._verificationStateDescription; }
            set { this._verificationStateDescription = value; }
        }

        // Check to see if VerificationStateDescription property is set
        internal bool IsSetVerificationStateDescription()
        {
            return this._verificationStateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationEventAdditionalInfo. 
        /// <para>
        ///  The details of a violation event. 
        /// </para>
        /// </summary>
        public ViolationEventAdditionalInfo ViolationEventAdditionalInfo
        {
            get { return this._violationEventAdditionalInfo; }
            set { this._violationEventAdditionalInfo = value; }
        }

        // Check to see if ViolationEventAdditionalInfo property is set
        internal bool IsSetViolationEventAdditionalInfo()
        {
            return this._violationEventAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationEventTime. 
        /// <para>
        /// The time the violation event occurred.
        /// </para>
        /// </summary>
        public DateTime? ViolationEventTime
        {
            get { return this._violationEventTime; }
            set { this._violationEventTime = value; }
        }

        // Check to see if ViolationEventTime property is set
        internal bool IsSetViolationEventTime()
        {
            return this._violationEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViolationEventType. 
        /// <para>
        /// The type of violation event.
        /// </para>
        /// </summary>
        public ViolationEventType ViolationEventType
        {
            get { return this._violationEventType; }
            set { this._violationEventType = value; }
        }

        // Check to see if ViolationEventType property is set
        internal bool IsSetViolationEventType()
        {
            return this._violationEventType != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        /// The ID of the violation event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ViolationId
        {
            get { return this._violationId; }
            set { this._violationId = value; }
        }

        // Check to see if ViolationId property is set
        internal bool IsSetViolationId()
        {
            return this._violationId != null;
        }

    }
}