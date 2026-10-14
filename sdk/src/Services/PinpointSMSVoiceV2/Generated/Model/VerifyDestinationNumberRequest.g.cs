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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the VerifyDestinationNumber operation. Use the verification
    /// code that was received by the verified destination phone number to opt-in the verified
    /// destination phone number to receive more messages.
    /// </summary>
    public partial class VerifyDestinationNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property VerificationCode. 
        /// <para>
        /// The verification code that was received by the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// Checks to see if the VerificationCode property is set.
        /// </summary>
        internal bool IsSetVerificationCode() => this.VerificationCode != null;

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verififed destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VerifiedDestinationNumberId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedDestinationNumberId property is set.
        /// </summary>
        internal bool IsSetVerifiedDestinationNumberId() => this.VerifiedDestinationNumberId != null;
    }
}
