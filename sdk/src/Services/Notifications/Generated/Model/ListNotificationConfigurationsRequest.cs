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
    /// Container for the parameters to the ListNotificationConfigurations operation.
    /// Returns a list of abbreviated <c>NotificationConfigurations</c> according to specified
    /// filters, in reverse chronological order (newest first).
    /// </summary>
    public partial class ListNotificationConfigurationsRequest : AmazonNotificationsRequest
    {
        private string _channelArn;
        private string _eventRuleSource;
        private int? _maxResults;
        private string _nextToken;
        private NotificationConfigurationStatus _status;
        private NotificationConfigurationSubtype _subtype;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Channel to match.
        /// </para>
        /// </summary>
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventRuleSource. 
        /// <para>
        /// The matched event source.
        /// </para>
        ///  
        /// <para>
        /// Must match one of the valid EventBridge sources. Only Amazon Web Services service
        /// sourced events are supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string EventRuleSource
        {
            get { return this._eventRuleSource; }
            set { this._eventRuleSource = value; }
        }

        // Check to see if EventRuleSource property is set
        internal bool IsSetEventRuleSource()
        {
            return this._eventRuleSource != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in this call. Defaults to 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The start token for paginated calls. Retrieved from the response of a previous <c>ListEventRules</c>
        /// call. Next token uses Base64 encoding.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The <c>NotificationConfiguration</c> status to match.
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
        /// All <c>EventRules</c> are <c>ACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some <c>EventRules</c> are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can
        /// be run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All <c>EventRules</c> are <c>INACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This <c>NotificationConfiguration</c> is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only <c>GET</c> and <c>LIST</c> calls can be run.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public NotificationConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// The subtype used to filter the notification configurations in the request.
        /// </para>
        /// </summary>
        public NotificationConfigurationSubtype Subtype
        {
            get { return this._subtype; }
            set { this._subtype = value; }
        }

        // Check to see if Subtype property is set
        internal bool IsSetSubtype()
        {
            return this._subtype != null;
        }

    }
}