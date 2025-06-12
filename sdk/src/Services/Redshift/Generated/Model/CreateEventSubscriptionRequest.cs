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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an Amazon Redshift event notification subscription. This action requires an
    /// ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon Redshift
    /// console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon
    /// SNS, you must create a topic in Amazon SNS and subscribe to the topic. The ARN is
    /// displayed in the SNS console.
    /// 
    ///  
    /// <para>
    /// You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
    /// and event severities. Notifications will be sent for all events you want that match
    /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
    /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
    /// subscription will only send notifications for those ERROR events in the Availability
    /// and Backup categories for the specified clusters.
    /// </para>
    ///  
    /// <para>
    /// If you specify both the source type and source IDs, such as source type = cluster
    /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
    /// events for my-cluster-1. If you specify a source type but do not specify a source
    /// identifier, you will receive notice of the events for the objects of that type in
    /// your Amazon Web Services account. If you do not specify either the SourceType nor
    /// the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
    /// sources belonging to your Amazon Web Services account. You must specify a source type
    /// if you specify a source ID.
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonRedshiftRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _severity;
        private string _snsTopicArn;
        private List<string> _sourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceType;
        private string _subscriptionName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A boolean value; set to <c>true</c> to activate the subscription, and set to <c>false</c>
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
        /// Specifies the Amazon Redshift event categories to be published by the event notification
        /// subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: configuration, management, monitoring, security, pending
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// Specifies the Amazon Redshift event severity to be published by the event notification
        /// subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: ERROR, INFO
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic used to transmit the event
        /// notifications. The ARN is created by Amazon SNS when you create a topic and subscribe
        /// to it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// A list of one or more identifiers of Amazon Redshift source objects. All of the objects
        /// must be of the same type as was specified in the source type parameter. The event
        /// subscription will return only events generated by the specified objects. If not specified,
        /// then events are returned for all objects within the source type specified.
        /// </para>
        ///  
        /// <para>
        /// Example: my-cluster-1, my-cluster-2
        /// </para>
        ///  
        /// <para>
        /// Example: my-snapshot-20131010
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
        /// The type of source that will be generating the events. For example, if you want to
        /// be notified of events generated by a cluster, you would set this parameter to cluster.
        /// If this value is not specified, events are returned for all Amazon Redshift objects
        /// in your Amazon Web Services account. You must specify a source type in order to specify
        /// source IDs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: cluster, cluster-parameter-group, cluster-security-group, cluster-snapshot,
        /// and scheduled-action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The name of the event subscription to be created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cannot be null, empty, or blank.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// A list of tag instances.
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