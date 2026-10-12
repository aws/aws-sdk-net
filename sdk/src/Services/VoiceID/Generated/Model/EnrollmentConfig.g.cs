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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains configurations defining enrollment behavior for the batch job.
    /// </summary>
    public partial class EnrollmentConfig
    {
        /// <summary>
        /// Gets and sets the property ExistingEnrollmentAction. 
        /// <para>
        ///  The action to take when the specified speaker is already enrolled in the specified
        /// domain. The default value is <c>SKIP</c>, which skips the enrollment for the existing
        /// speaker. Setting the value to <c>OVERWRITE</c> replaces the existing voice prints
        /// and enrollment audio stored for that speaker with new data generated from the latest
        /// audio.
        /// </para>
        /// </summary>
        public ExistingEnrollmentAction ExistingEnrollmentAction { get; set; }

        /// <summary>
        /// Checks to see if the ExistingEnrollmentAction property is set.
        /// </summary>
        internal bool IsSetExistingEnrollmentAction() => this.ExistingEnrollmentAction != null;

        /// <summary>
        /// Gets and sets the property FraudDetectionConfig. 
        /// <para>
        /// The fraud detection configuration to use for the speaker enrollment job.
        /// </para>
        /// </summary>
        public EnrollmentJobFraudDetectionConfig FraudDetectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the FraudDetectionConfig property is set.
        /// </summary>
        internal bool IsSetFraudDetectionConfig() => this.FraudDetectionConfig != null;
    }
}
