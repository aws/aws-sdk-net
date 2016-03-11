/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes event subscriptions.
    /// </summary>
    public partial class EventSubscription
    {
        private string _customerAwsId;
        private string _custSubscriptionId;
        private bool? _enabled;
        private List<string> _eventCategoriesList = new List<string>();
        private string _severity;
        private string _snsTopicArn;
        private List<string> _sourceIdsList = new List<string>();
        private string _sourceType;
        private string _status;
        private DateTime? _subscriptionCreationTime;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CustomerAwsId. 
        /// <para>
        /// The AWS customer account associated with the Amazon Redshift event notification subscription.
        /// </para>
        /// </summary>
        public string CustomerAwsId
        {
            get { return this._customerAwsId; }
            set { this._customerAwsId = value; }
        }

        // Check to see if CustomerAwsId property is set
        internal bool IsSetCustomerAwsId()
        {
            return this._customerAwsId != null;
        }

        /// <summary>
        /// Gets and sets the property CustSubscriptionId. 
        /// <para>
        /// The name of the Amazon Redshift event notification subscription.
        /// </para>
        /// </summary>
        public string CustSubscriptionId
        {
            get { return this._custSubscriptionId; }
            set { this._custSubscriptionId = value; }
        }

        // Check to see if CustSubscriptionId property is set
        internal bool IsSetCustSubscriptionId()
        {
            return this._custSubscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean value indicating whether the subscription is enabled. <code>true</code>
        /// indicates the subscription is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventCategoriesList. 
        /// <para>
        /// The list of Amazon Redshift event categories specified in the event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: Configuration, Management, Monitoring, Security
        /// </para>
        /// </summary>
        public List<string> EventCategoriesList
        {
            get { return this._eventCategoriesList; }
            set { this._eventCategoriesList = value; }
        }

        // Check to see if EventCategoriesList property is set
        internal bool IsSetEventCategoriesList()
        {
            return this._eventCategoriesList != null && this._eventCategoriesList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The event severity specified in the Amazon Redshift event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: ERROR, INFO
        /// </para>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic used by the event notification
        /// subscription.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIdsList. 
        /// <para>
        /// A list of the sources that publish events to the Amazon Redshift event notification
        /// subscription.
        /// </para>
        /// </summary>
        public List<string> SourceIdsList
        {
            get { return this._sourceIdsList; }
            set { this._sourceIdsList = value; }
        }

        // Check to see if SourceIdsList property is set
        internal bool IsSetSourceIdsList()
        {
            return this._sourceIdsList != null && this._sourceIdsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the events returned the Amazon Redshift event notification, such
        /// as cluster, or cluster-snapshot.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Redshift event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Can be one of the following: active | no-permission | topic-not-exist</li>
        /// <li>The status "no-permission" indicates that Amazon Redshift no longer has permission
        /// to post to the Amazon SNS topic. The status "topic-not-exist" indicates that the topic
        /// was deleted after the subscription was created.</li> </ul>
        /// </summary>
        public string Status
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
        /// Gets and sets the property SubscriptionCreationTime. 
        /// <para>
        /// The date and time the Amazon Redshift event notification subscription was created.
        /// </para>
        /// </summary>
        public DateTime SubscriptionCreationTime
        {
            get { return this._subscriptionCreationTime.GetValueOrDefault(); }
            set { this._subscriptionCreationTime = value; }
        }

        // Check to see if SubscriptionCreationTime property is set
        internal bool IsSetSubscriptionCreationTime()
        {
            return this._subscriptionCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the event subscription.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}