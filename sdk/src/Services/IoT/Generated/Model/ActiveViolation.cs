/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about an active Device Defender security profile behavior violation.
    /// </summary>
    public partial class ActiveViolation
    {
        private Behavior _behavior;
        private DateTime? _lastViolationTime;
        private MetricValue _lastViolationValue;
        private string _securityProfileName;
        private string _thingName;
        private string _violationId;
        private DateTime? _violationStartTime;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior which is being violated.
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
        /// Gets and sets the property LastViolationTime. 
        /// <para>
        /// The time the most recent violation occurred.
        /// </para>
        /// </summary>
        public DateTime LastViolationTime
        {
            get { return this._lastViolationTime.GetValueOrDefault(); }
            set { this._lastViolationTime = value; }
        }

        // Check to see if LastViolationTime property is set
        internal bool IsSetLastViolationTime()
        {
            return this._lastViolationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastViolationValue. 
        /// <para>
        /// The value of the metric (the measurement) which caused the most recent violation.
        /// </para>
        /// </summary>
        public MetricValue LastViolationValue
        {
            get { return this._lastViolationValue; }
            set { this._lastViolationValue = value; }
        }

        // Check to see if LastViolationValue property is set
        internal bool IsSetLastViolationValue()
        {
            return this._lastViolationValue != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The security profile whose behavior is in violation.
        /// </para>
        /// </summary>
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
        /// The name of the thing responsible for the active violation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ViolationId. 
        /// <para>
        /// The ID of the active violation.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ViolationStartTime. 
        /// <para>
        /// The time the violation started.
        /// </para>
        /// </summary>
        public DateTime ViolationStartTime
        {
            get { return this._violationStartTime.GetValueOrDefault(); }
            set { this._violationStartTime = value; }
        }

        // Check to see if ViolationStartTime property is set
        internal bool IsSetViolationStartTime()
        {
            return this._violationStartTime.HasValue; 
        }

    }
}