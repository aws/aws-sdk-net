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
    /// This is the response object from the VerifyDestinationNumber operation.
    /// </summary>
    public partial class VerifyDestinationNumberResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the destination phone number was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The phone number in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for being able to send messages to the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VerifiedDestinationNumberArn { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedDestinationNumberArn property is set.
        /// </summary>
        internal bool IsSetVerifiedDestinationNumberArn() => this.VerifiedDestinationNumberArn != null;

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VerifiedDestinationNumberId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedDestinationNumberId property is set.
        /// </summary>
        internal bool IsSetVerifiedDestinationNumberId() => this.VerifiedDestinationNumberId != null;
    }
}
