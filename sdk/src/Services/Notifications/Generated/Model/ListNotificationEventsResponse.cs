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
    /// This is the response object from the ListNotificationEvents operation.
    /// </summary>
    public partial class ListNotificationEventsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<NotificationEventOverview> _notificationEvents = AWSConfigs.InitializeCollections ? new List<NotificationEventOverview>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token. If a non-null pagination token is returned in a result, pass its
        /// value in another request to retrieve more entries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEvents. 
        /// <para>
        /// The list of notification events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<NotificationEventOverview> NotificationEvents
        {
            get { return this._notificationEvents; }
            set { this._notificationEvents = value; }
        }

        // Check to see if NotificationEvents property is set
        internal bool IsSetNotificationEvents()
        {
            return this._notificationEvents != null && (this._notificationEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}