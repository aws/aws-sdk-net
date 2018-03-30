/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StopContact operation.
    /// Ends the contact initiated by the <code>StartOutboundVoiceContact</code> operation.
    /// 
    ///  
    /// <para>
    /// If you are using an IAM account, it must have permissions to the <code>connect:StopContact</code>
    /// operation.
    /// </para>
    /// </summary>
    public partial class StopContactRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The unique identifier of the contact to end. This is the <code>ContactId</code> value
        /// returned from the <code>StartOutboundVoiceContact</code> operation.
        /// </para>
        /// </summary>
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance in which the contact is active.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}