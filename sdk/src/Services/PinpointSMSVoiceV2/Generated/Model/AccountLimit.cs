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
    /// The current resource quotas associated with an Amazon Web Services account.
    /// </summary>
    public partial class AccountLimit
    {
        private long? _max;
        private AccountLimitName _name;
        private long? _used;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The Amazon Web Services set limit for that resource type, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute to apply the account limit to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountLimitName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        /// The current amount that has been spent, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Used
        {
            get { return this._used; }
            set { this._used = value; }
        }

        // Check to see if Used property is set
        internal bool IsSetUsed()
        {
            return this._used.HasValue; 
        }

    }
}