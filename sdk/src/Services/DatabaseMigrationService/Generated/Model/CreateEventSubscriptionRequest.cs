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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an DMS event notification subscription. 
    /// 
    ///  
    /// <para>
    /// You can specify the type of source (<c>SourceType</c>) you want to be notified of,
    /// provide a list of DMS source IDs (<c>SourceIds</c>) that triggers the events, and
    /// provide a list of event categories (<c>EventCategories</c>) for events you want to
    /// be notified of. If you specify both the <c>SourceType</c> and <c>SourceIds</c>, such
    /// as <c>SourceType = replication-instance</c> and <c>SourceIdentifier = my-replinstance</c>,
    /// you will be notified of all the replication instance events for the specified source.
    /// If you specify a <c>SourceType</c> but don't specify a <c>SourceIdentifier</c>, you
    /// receive notice of the events for that source type for all your DMS sources. If you
    /// don't specify either <c>SourceType</c> nor <c>SourceIdentifier</c>, you will be notified
    /// of events generated from all DMS sources belonging to your customer account.
    /// </para>
    ///  
    /// <para>
    /// For more information about DMS events, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
    /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
    /// 
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonDatabaseMigrationServiceRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _snsTopicArn;
        private List<string> _sourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceType;
        private string _subscriptionName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  A Boolean value; set to <c>true</c> to activate the subscription, or set to <c>false</c>
        /// to create the subscription but not activate it. 
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// A list of event categories for a source type that you want to subscribe to. For more
        /// information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && (this._eventCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon SNS topic created for event notification.
        /// The ARN is created by Amazon SNS when you create a topic and subscribe to it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of identifiers for which DMS provides notification events.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, notifications are provided for all sources.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple values, they must be of the same type. For example, if you
        /// specify a database instance ID, then all of the other values must be database instance
        /// IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceIds
        {
            get { return this._sourceIds; }
            set { this._sourceIds = value; }
        }

        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this._sourceIds != null && (this._sourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  The type of DMS resource that generates the events. For example, if you want to be
        /// notified of events generated by a replication instance, you set this parameter to
        /// <c>replication-instance</c>. If this value isn't specified, all events are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>replication-instance</c> | <c>replication-task</c> 
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
        /// The name of the DMS event notification subscription. This name must be less than 255
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// One or more tags to be assigned to the event subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}