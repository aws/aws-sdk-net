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
    /// Container for the parameters to the PauseContact operation.
    /// Allows pausing an ongoing task contact.
    /// </summary>
    public partial class PauseContactRequest : AmazonConnectRequest
    {
        private string _contactFlowId;
        private string _contactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The identifier of the Amazon Connect instance. You can find the <c>instanceId</c>
        /// in the ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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