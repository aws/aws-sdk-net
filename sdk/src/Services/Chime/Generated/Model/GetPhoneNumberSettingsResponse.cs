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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the GetPhoneNumberSettings operation.
    /// </summary>
    public partial class GetPhoneNumberSettingsResponse : AmazonWebServiceResponse
    {
        private string _callingName;
        private DateTime? _callingNameUpdatedTimestamp;

        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The default outbound calling name for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CallingName
        {
            get { return this._callingName; }
            set { this._callingName = value; }
        }

        // Check to see if CallingName property is set
        internal bool IsSetCallingName()
        {
            return this._callingName != null;
        }

        /// <summary>
        /// Gets and sets the property CallingNameUpdatedTimestamp. 
        /// <para>
        /// The updated outbound calling name timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CallingNameUpdatedTimestamp
        {
            get { return this._callingNameUpdatedTimestamp.GetValueOrDefault(); }
            set { this._callingNameUpdatedTimestamp = value; }
        }

        // Check to see if CallingNameUpdatedTimestamp property is set
        internal bool IsSetCallingNameUpdatedTimestamp()
        {
            return this._callingNameUpdatedTimestamp.HasValue; 
        }

    }
}