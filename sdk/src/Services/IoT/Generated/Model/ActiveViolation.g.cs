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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about an active Device Defender security profile behavior violation.
    /// </summary>
    public partial class ActiveViolation
    {
        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior that is being violated.
        /// </para>
        /// </summary>
        public Behavior Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;

        /// <summary>
        /// Gets and sets the property LastViolationTime. 
        /// <para>
        /// The time the most recent violation occurred.
        /// </para>
        /// </summary>
        public DateTime? LastViolationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastViolationTime property is set.
        /// </summary>
        internal bool IsSetLastViolationTime() => this.LastViolationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastViolationValue. 
        /// <para>
        /// The value of the metric (the measurement) that caused the most recent violation.
        /// </para>
        /// </summary>
        public MetricValue LastViolationValue { get; set; }

        /// <summary>
        /// Checks to see if the LastViolationValue property is set.
        /// </summary>
        internal bool IsSetLastViolationValue() => this.LastViolationValue != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The security profile with the behavior is in violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing responsible for the active violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The verification state of the violation (detect alarm).
        /// </para>
        /// </summary>
        public VerificationState VerificationState { get; set; }

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null;

        /// <summary>
        /// Gets and sets the property VerificationStateDescription. 
        /// <para>
        /// The description of the verification state of the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string VerificationStateDescription { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStateDescription property is set.
        /// </summary>
        internal bool IsSetVerificationStateDescription() => this.VerificationStateDescription != null;

        /// <summary>
        /// Gets and sets the property ViolationEventAdditionalInfo. 
        /// <para>
        ///  The details of a violation event. 
        /// </para>
        /// </summary>
        public ViolationEventAdditionalInfo ViolationEventAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the ViolationEventAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetViolationEventAdditionalInfo() => this.ViolationEventAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        /// The ID of the active violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ViolationId { get; set; }

        /// <summary>
        /// Checks to see if the ViolationId property is set.
        /// </summary>
        internal bool IsSetViolationId() => this.ViolationId != null;

        /// <summary>
        /// Gets and sets the property ViolationStartTime. 
        /// <para>
        /// The time the violation started.
        /// </para>
        /// </summary>
        public DateTime? ViolationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ViolationStartTime property is set.
        /// </summary>
        internal bool IsSetViolationStartTime() => this.ViolationStartTime.HasValue;
    }
}
