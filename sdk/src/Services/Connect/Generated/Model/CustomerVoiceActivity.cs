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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about customer’s voice activity.
    /// </summary>
    public partial class CustomerVoiceActivity
    {
        private DateTime? _greetingEndTimestamp;
        private DateTime? _greetingStartTimestamp;

        /// <summary>
        /// Gets and sets the property GreetingEndTimestamp. 
        /// <para>
        /// Timestamp that measures the end of the customer greeting from an outbound voice call.
        /// </para>
        /// </summary>
        public DateTime? GreetingEndTimestamp
        {
            get { return this._greetingEndTimestamp; }
            set { this._greetingEndTimestamp = value; }
        }

        // Check to see if GreetingEndTimestamp property is set
        internal bool IsSetGreetingEndTimestamp()
        {
            return this._greetingEndTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreetingStartTimestamp. 
        /// <para>
        /// Timestamp that measures the beginning of the customer greeting from an outbound voice
        /// call.
        /// </para>
        /// </summary>
        public DateTime? GreetingStartTimestamp
        {
            get { return this._greetingStartTimestamp; }
            set { this._greetingStartTimestamp = value; }
        }

        // Check to see if GreetingStartTimestamp property is set
        internal bool IsSetGreetingStartTimestamp()
        {
            return this._greetingStartTimestamp.HasValue; 
        }

    }
}