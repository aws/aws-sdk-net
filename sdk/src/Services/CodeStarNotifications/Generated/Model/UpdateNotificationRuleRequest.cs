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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNotificationRule operation.
    /// Updates a notification rule for a resource. You can change the events that trigger
    /// the notification rule, the status of the rule, and the targets that receive the notifications.
    /// 
    ///  <note> 
    /// <para>
    /// To add or remove tags for a notification rule, you must use <a>TagResource</a> and
    /// <a>UntagResource</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateNotificationRuleRequest : AmazonCodeStarNotificationsRequest
    {
        private string _arn;
        private DetailType _detailType;
        private List<string> _eventTypeIds = new List<string>();
        private string _name;
        private NotificationRuleStatus _status;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// The level of detail to include in the notifications for this resource. BASIC will
        /// include only the contents of the event as it would appear in Amazon CloudWatch. FULL
        /// will include any supplemental information provided by AWS CodeStar Notifications and/or
        /// the service for the resource for which the notification is created.
        /// </para>
        /// </summary>
        public DetailType DetailType
        {
            get { return this._detailType; }
            set { this._detailType = value; }
        }

        // Check to see if DetailType property is set
        internal bool IsSetDetailType()
        {
            return this._detailType != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeIds. 
        /// <para>
        /// A list of event types associated with this notification rule. For a complete list
        /// of event types and IDs, see <a href="https://docs.aws.amazon.com/codestar-notifications/latest/userguide/concepts.html#concepts-api">Notification
        /// concepts</a> in the <i>Developer Tools Console User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> EventTypeIds
        {
            get { return this._eventTypeIds; }
            set { this._eventTypeIds = value; }
        }

        // Check to see if EventTypeIds property is set
        internal bool IsSetEventTypeIds()
        {
            return this._eventTypeIds != null && this._eventTypeIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Name
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notification rule. Valid statuses include enabled (sending notifications)
        /// or disabled (not sending notifications).
        /// </para>
        /// </summary>
        public NotificationRuleStatus Status
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The address and type of the targets to receive notifications from this notification
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}