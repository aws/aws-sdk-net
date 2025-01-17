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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Provides additional information about the current <c>NotificationHub</c> status.
    /// </summary>
    public partial class NotificationHubStatusSummary
    {
        private string _reason;
        private NotificationHubStatus _status;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// An explanation for the current status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status information about the <c>NotificationHub</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Incoming <c>NotificationEvents</c> are replicated to this <c>NotificationHub</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>REGISTERING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>NotificationConfiguration</c> is initializing. A <c>NotificationConfiguration</c>
        /// with this status can't be deregistered.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DEREGISTERING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>NotificationConfiguration</c> is being deleted. You can't register additional
        /// <c>NotificationHubs</c> in the same Region as a <c>NotificationConfiguration</c> with
        /// this status.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationHubStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}