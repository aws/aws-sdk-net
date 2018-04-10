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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an AWS DMS event notification subscription. 
    /// 
    ///  
    /// <para>
    /// You can specify the type of source (<code>SourceType</code>) you want to be notified
    /// of, provide a list of AWS DMS source IDs (<code>SourceIds</code>) that triggers the
    /// events, and provide a list of event categories (<code>EventCategories</code>) for
    /// events you want to be notified of. If you specify both the <code>SourceType</code>
    /// and <code>SourceIds</code>, such as <code>SourceType = replication-instance</code>
    /// and <code>SourceIdentifier = my-replinstance</code>, you will be notified of all the
    /// replication instance events for the specified source. If you specify a <code>SourceType</code>
    /// but don't specify a <code>SourceIdentifier</code>, you receive notice of the events
    /// for that source type for all your AWS DMS sources. If you don't specify either <code>SourceType</code>
    /// nor <code>SourceIdentifier</code>, you will be notified of events generated from all
    /// AWS DMS sources belonging to your customer account.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS DMS events, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">
    /// Working with Events and Notifications </a> in the AWS Database MIgration Service User
    /// Guide.
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonDatabaseMigrationServiceRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = new List<string>();
        private string _snsTopicArn;
        private List<string> _sourceIds = new List<string>();
        private string _sourceType;
        private string _subscriptionName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  A Boolean value; set to <b>true</b> to activate the subscription, or set to <b>false</b>
        /// to create the subscription but not activate it. 
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
        /// Gets and sets the property EventCategories. 
        /// <para>
        ///  A list of event categories for a source type that you want to subscribe to. You can
        /// see a list of the categories for a given source type by calling the <b>DescribeEventCategories</b>
        /// action or in the topic <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">
        /// Working with Events and Notifications</a> in the AWS Database Migration Service User
        /// Guide. 
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && this._eventCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon SNS topic created for event notification.
        /// The ARN is created by Amazon SNS when you create a topic and subscribe to it. 
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
        /// Gets and sets the property SourceIds. 
        /// <para>
        ///  The list of identifiers of the event sources for which events will be returned. If
        /// not specified, then all sources are included in the response. An identifier must begin
        /// with a letter and must contain only ASCII letters, digits, and hyphens; it cannot
        /// end with a hyphen or contain two consecutive hyphens. 
        /// </para>
        /// </summary>
        public List<string> SourceIds
        {
            get { return this._sourceIds; }
            set { this._sourceIds = value; }
        }

        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this._sourceIds != null && this._sourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  The type of AWS DMS resource that generates the events. For example, if you want
        /// to be notified of events generated by a replication instance, you set this parameter
        /// to <code>replication-instance</code>. If this value is not specified, all events are
        /// returned. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: replication-instance | migration-task
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
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the AWS DMS event notification subscription. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: The name must be less than 255 characters. 
        /// </para>
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag to be attached to the event subscription.
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