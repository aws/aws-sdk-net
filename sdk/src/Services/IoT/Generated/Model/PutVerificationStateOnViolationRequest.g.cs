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
    /// Container for the parameters to the PutVerificationStateOnViolation operation. <note>
    /// <para> The IoT Device Defender detect feature will no longer be available to new customers
    /// starting August 31, 2026. If you would like to use the detect feature, sign up prior
    /// to August 31, 2026. To learn about alternatives to IoT Device Defender detect, see
    /// IoT Device Defender detect feature availability change in the IoT Device Defender
    /// Developer Guide. There is no change to IoT Device Defender audit availability. </para>
    /// </note> <para> Set a verification state and provide a description of that verification
    /// state on a violation (detect alarm). </para>
    /// </summary>
    public partial class PutVerificationStateOnViolationRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The verification state of the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationState VerificationState { get; set; }

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null;

        /// <summary>
        /// Gets and sets the property VerificationStateDescription. 
        /// <para>
        /// The description of the verification state of the violation (detect alarm).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string VerificationStateDescription { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStateDescription property is set.
        /// </summary>
        internal bool IsSetVerificationStateDescription() => this.VerificationStateDescription != null;

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        /// The violation ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ViolationId { get; set; }

        /// <summary>
        /// Checks to see if the ViolationId property is set.
        /// </summary>
        internal bool IsSetViolationId() => this.ViolationId != null;
    }
}
