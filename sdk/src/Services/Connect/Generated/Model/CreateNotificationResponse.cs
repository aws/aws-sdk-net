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
    /// This is the response object from the CreateNotification operation.
    /// </summary>
    public partial class CreateNotificationResponse : AmazonWebServiceResponse
    {
        private string _notificationArn;
        private string _notificationId;

        /// <summary>
        /// Gets and sets the property NotificationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationArn
        {
            get { return this._notificationArn; }
            set { this._notificationArn = value; }
        }

        // Check to see if NotificationArn property is set
        internal bool IsSetNotificationArn()
        {
            return this._notificationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationId. 
        /// <para>
        /// The unique identifier assigned to the created notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NotificationId
        {
            get { return this._notificationId; }
            set { this._notificationId = value; }
        }

        // Check to see if NotificationId property is set
        internal bool IsSetNotificationId()
        {
            return this._notificationId != null;
        }

    }
}