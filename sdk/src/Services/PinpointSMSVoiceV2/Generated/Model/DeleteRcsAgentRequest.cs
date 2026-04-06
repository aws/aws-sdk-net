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
    /// Container for the parameters to the DeleteRcsAgent operation.
    /// Deletes an existing RCS agent. If deletion protection is enabled, an error is returned.
    /// </summary>
    public partial class DeleteRcsAgentRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _rcsAgentId;

        /// <summary>
        /// Gets and sets the property RcsAgentId. 
        /// <para>
        /// The unique identifier of the RCS agent to delete. You can use either the RcsAgentId
        /// or RcsAgentArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RcsAgentId
        {
            get { return this._rcsAgentId; }
            set { this._rcsAgentId = value; }
        }

        // Check to see if RcsAgentId property is set
        internal bool IsSetRcsAgentId()
        {
            return this._rcsAgentId != null;
        }

    }
}