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
    /// This is the response object from the ListNotifications operation.
    /// </summary>
    public partial class ListNotificationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Notification> _notificationSummaryList = AWSConfigs.InitializeCollections ? new List<Notification>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. If present, there are more results available.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NotificationSummaryList. 
        /// <para>
        /// A list of notification summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Notification> NotificationSummaryList
        {
            get { return this._notificationSummaryList; }
            set { this._notificationSummaryList = value; }
        }

        // Check to see if NotificationSummaryList property is set
        internal bool IsSetNotificationSummaryList()
        {
            return this._notificationSummaryList != null && (this._notificationSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}