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
    /// This is the response object from the DescribeNotificationRule operation.
    /// </summary>
    public partial class DescribeNotificationRuleResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _createdBy;
        private DateTime? _createdTimestamp;
        private DetailType _detailType;
        private List<EventTypeSummary> _eventTypes = new List<EventTypeSummary>();
        private DateTime? _lastModifiedTimestamp;
        private string _name;
        private string _resource;
        private NotificationRuleStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<TargetSummary> _targets = new List<TargetSummary>();

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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The name or email alias of the person who created the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date and time the notification rule was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// The level of detail included in the notifications for this resource. BASIC will include
        /// only the contents of the event as it would appear in Amazon CloudWatch. FULL will
        /// include any supplemental information provided by AWS CodeStar Notifications and/or
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
        /// Gets and sets the property EventTypes. 
        /// <para>
        /// A list of the event types associated with the notification rule.
        /// </para>
        /// </summary>
        public List<EventTypeSummary> EventTypes
        {
            get { return this._eventTypes; }
            set { this._eventTypes = value; }
        }

        // Check to see if EventTypes property is set
        internal bool IsSetEventTypes()
        {
            return this._eventTypes != null && this._eventTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The date and time the notification rule was most recently updated, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp.GetValueOrDefault(); }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with the notification rule.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notification rule. Valid statuses are on (sending notifications)
        /// or off (not sending notifications).
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the notification rule.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of the Chatbot topics and Chatbot clients associated with the notification
        /// rule.
        /// </para>
        /// </summary>
        public List<TargetSummary> Targets
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