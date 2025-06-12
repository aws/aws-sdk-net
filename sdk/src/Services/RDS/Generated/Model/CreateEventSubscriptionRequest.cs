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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an RDS event notification subscription. This operation requires a topic Amazon
    /// Resource Name (ARN) created by either the RDS console, the SNS console, or the SNS
    /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
    /// to the topic. The ARN is displayed in the SNS console.
    /// 
    ///  
    /// <para>
    /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
    /// of and provide a list of RDS sources (<c>SourceIds</c>) that triggers the events.
    /// You can also provide a list of event categories (<c>EventCategories</c>) for events
    /// that you want to be notified of. For example, you can specify <c>SourceType</c> =
    /// <c>db-instance</c>, <c>SourceIds</c> = <c>mydbinstance1</c>, <c>mydbinstance2</c>
    /// and <c>EventCategories</c> = <c>Availability</c>, <c>Backup</c>.
    /// </para>
    ///  
    /// <para>
    /// If you specify both the <c>SourceType</c> and <c>SourceIds</c>, such as <c>SourceType</c>
    /// = <c>db-instance</c> and <c>SourceIds</c> = <c>myDBInstance1</c>, you are notified
    /// of all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
    /// but do not specify <c>SourceIds</c>, you receive notice of the events for that source
    /// type for all your RDS sources. If you don't specify either the SourceType or the <c>SourceIds</c>,
    /// you are notified of events generated from all RDS sources belonging to your customer
    /// account.
    /// </para>
    ///  
    /// <para>
    /// For more information about subscribing to an event for RDS DB engines, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Subscribing.html">
    /// Subscribing to Amazon RDS event notification</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about subscribing to an event for Aurora DB engines, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Subscribing.html">
    /// Subscribing to Amazon RDS event notification</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonRDSRequest
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
        /// Specifies whether to activate the subscription. If the event notification subscription
        /// isn't activated, the subscription is created but not active.
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
        /// A list of event categories for a particular source type (<c>SourceType</c>) that you
        /// want to subscribe to. You can see a list of the categories for a given source type
        /// in the "Amazon RDS event categories and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
        /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
        /// <i>Amazon Aurora User Guide</i> </a>. You can also see this list by using the <c>DescribeEventCategories</c>
        /// operation.
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
        /// The Amazon Resource Name (ARN) of the SNS topic created for event notification. SNS
        /// automatically creates the ARN when you create a topic and subscribe to it.
        /// </para>
        ///  <note> 
        /// <para>
        /// RDS doesn't support FIFO (first in, first out) topics. For more information, see <a
        /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">Message ordering
        /// and deduplication (FIFO topics)</a> in the <i>Amazon Simple Notification Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
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
        /// The list of identifiers of the event sources for which events are returned. If not
        /// specified, then all sources are included in the response. An identifier must begin
        /// with a letter and must contain only ASCII letters, digits, and hyphens. It can't end
        /// with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>SourceIds</c> are supplied, <c>SourceType</c> must also be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB instance, a <c>DBInstanceIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster, a <c>DBClusterIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB parameter group, a <c>DBParameterGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB security group, a <c>DBSecurityGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB snapshot, a <c>DBSnapshotIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster snapshot, a <c>DBClusterSnapshotIdentifier</c>
        /// value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is an RDS Proxy, a <c>DBProxyName</c> value must be supplied.
        /// </para>
        ///  </li> </ul>
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
        /// The type of source that is generating the events. For example, if you want to be notified
        /// of events generated by a DB instance, you set this parameter to <c>db-instance</c>.
        /// For RDS Proxy events, specify <c>db-proxy</c>. If this value isn't specified, all
        /// events are returned.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:<c> db-instance | db-cluster | db-parameter-group | db-security-group
        /// | db-snapshot | db-cluster-snapshot | db-proxy | zero-etl | custom-engine-version
        /// | blue-green-deployment </c> 
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
        /// The name of the subscription.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The name must be less than 255 characters.
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