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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the GetPhoneNumberSettings operation.
    /// </summary>
    public partial class GetPhoneNumberSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The default outbound calling name for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CallingName { get; set; }

        /// <summary>
        /// Checks to see if the CallingName property is set.
        /// </summary>
        internal bool IsSetCallingName() => this.CallingName != null;

        /// <summary>
        /// Gets and sets the property CallingNameUpdatedTimestamp. 
        /// <para>
        /// The updated outbound calling name timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CallingNameUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CallingNameUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCallingNameUpdatedTimestamp() => this.CallingNameUpdatedTimestamp.HasValue;
    }
}
