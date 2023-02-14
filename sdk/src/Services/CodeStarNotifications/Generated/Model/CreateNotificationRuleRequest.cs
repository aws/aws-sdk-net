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
    /// Container for the parameters to the CreateNotificationRule operation.
    /// Creates a notification rule for a resource. The rule specifies the events you want
    /// notifications about and the targets (such as Chatbot topics or Chatbot clients configured
    /// for Slack) where you want to receive them.
    /// </summary>
    public partial class CreateNotificationRuleRequest : AmazonCodeStarNotificationsRequest
    {
        private string _clientRequestToken;
        private DetailType _detailType;
        private List<string> _eventTypeIds = new List<string>();
        private string _name;
        private string _resource;
        private NotificationRuleStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that, when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request with the same
        /// parameters is received and a token is included, the request returns information about
        /// the initial request that used that token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Web Services SDKs prepopulate client request tokens. If you are using an
        /// Amazon Web Services SDK, an idempotency token is created for you.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// The level of detail to include in the notifications for this resource. <code>BASIC</code>
        /// will include only the contents of the event as it would appear in Amazon CloudWatch.
        /// <code>FULL</code> will include any supplemental information provided by AWS CodeStar
        /// Notifications and/or the service for the resource for which the notification is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of event types associated with this notification rule. For a list of allowed
        /// events, see <a>EventTypeSummary</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name for the notification rule. Notification rule names must be unique in your
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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
        /// The Amazon Resource Name (ARN) of the resource to associate with the notification
        /// rule. Supported resources include pipelines in CodePipeline, repositories in CodeCommit,
        /// and build projects in CodeBuild.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The status of the notification rule. The default value is <code>ENABLED</code>. If
        /// the status is set to <code>DISABLED</code>, notifications aren't sent for the notification
        /// rule.
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
        /// A list of tags to apply to this notification rule. Key names cannot start with "<code>aws</code>".
        /// 
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
        /// A list of Amazon Resource Names (ARNs) of Amazon Simple Notification Service topics
        /// and Chatbot clients to associate with the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10)]
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