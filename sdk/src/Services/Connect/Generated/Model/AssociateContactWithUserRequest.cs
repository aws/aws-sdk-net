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
    /// Container for the parameters to the AssociateContactWithUser operation.
    /// Associates a queued contact with an agent.
    /// 
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  
    /// <para>
    /// Following are common uses cases for this API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Custom contact routing. You can build custom contact routing mechanisms beyond the
    /// default system routing in Amazon Connect. You can create tailored contact distribution
    /// logic that offers queued contacts directly to specific agents.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Manual contact assignment. You can programmatically assign queued contacts to available
    /// users. This provides flexibility to contact centers that require manual oversight
    /// or specialized routing workflows outside of standard queue management.
    /// </para>
    ///  
    /// <para>
    /// For information about how manual contact assignment works in the agent workspace,
    /// see the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/worklist-app.html">Access
    /// the Worklist app in the Amazon Connect agent workspace</a> in the <i>Amazon Connect
    /// Administrator Guide</i>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use this API chat/SMS, email, and task contacts. It does not support voice contacts.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use it to associate contacts with users regardless of their current state, including
    /// custom states. Ensure your application logic accounts for user availability before
    /// making associations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It honors the IAM context key <c>connect:PreferredUserArn</c> to prevent unauthorized
    /// contact associations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It respects the IAM context key <c>connect:PreferredUserArn</c> to enforce authorization
    /// controls and prevent unauthorized contact associations. Verify that your IAM policies
    /// are properly configured to support your intended use cases.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class AssociateContactWithUserRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _instanceId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
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
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for the user. This can be the ID or the ARN of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}