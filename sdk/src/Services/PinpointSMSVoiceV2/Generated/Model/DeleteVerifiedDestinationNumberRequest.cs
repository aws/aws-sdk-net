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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
    /// Container for the parameters to the DeleteVerifiedDestinationNumber operation.
    /// Delete a verified destination phone number.
    /// </summary>
    public partial class DeleteVerifiedDestinationNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _verifiedDestinationNumberId;

        /// <summary>
        /// Gets and sets the property VerifiedDestinationNumberId. 
        /// <para>
        /// The unique identifier for the verified destination phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VerifiedDestinationNumberId
        {
            get { return this._verifiedDestinationNumberId; }
            set { this._verifiedDestinationNumberId = value; }
        }

        // Check to see if VerifiedDestinationNumberId property is set
        internal bool IsSetVerifiedDestinationNumberId()
        {
            return this._verifiedDestinationNumberId != null;
        }

    }
}