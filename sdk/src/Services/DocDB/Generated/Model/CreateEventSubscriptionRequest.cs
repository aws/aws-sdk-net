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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// Creates an Amazon DocumentDB event notification subscription. This action requires
    /// a topic Amazon Resource Name (ARN) created by using the Amazon DocumentDB console,
    /// the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you
    /// must create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed
    /// in the Amazon SNS console.
    /// 
    ///  
    /// <para>
    /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
    /// of. You can also provide a list of Amazon DocumentDB sources (<c>SourceIds</c>) that
    /// trigger the events, and you can provide a list of event categories (<c>EventCategories</c>)
    /// for events that you want to be notified of. For example, you can specify <c>SourceType
    /// = db-instance</c>, <c>SourceIds = mydbinstance1, mydbinstance2</c> and <c>EventCategories
    /// = Availability, Backup</c>.
    /// </para>
    ///  
    /// <para>
    /// If you specify both the <c>SourceType</c> and <c>SourceIds</c> (such as <c>SourceType
    /// = db-instance</c> and <c>SourceIdentifier = myDBInstance1</c>), you are notified of
    /// all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
    /// but do not specify a <c>SourceIdentifier</c>, you receive notice of the events for
    /// that source type for all your Amazon DocumentDB sources. If you do not specify either
    /// the <c>SourceType</c> or the <c>SourceIdentifier</c>, you are notified of events generated
    /// from all Amazon DocumentDB sources belonging to your customer account.
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonDocDBRequest
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
        ///  A Boolean value; set to <c>true</c> to activate the subscription, set to <c>false</c>
        /// to create the subscription but not active it. 
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
        ///  A list of event categories for a <c>SourceType</c> that you want to subscribe to.
        /// 
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
            return this._eventCategories != null && (this._eventCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS topic created for event notification. Amazon
        /// SNS creates the ARN when you create a topic and subscribe to it.
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
        /// The list of identifiers of the event sources for which events are returned. If not
        /// specified, then all sources are included in the response. An identifier must begin
        /// with a letter and must contain only ASCII letters, digits, and hyphens; it can't end
        /// with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>SourceIds</c> are provided, <c>SourceType</c> must also be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is an instance, a <c>DBInstanceIdentifier</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a security group, a <c>DBSecurityGroupName</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a parameter group, a <c>DBParameterGroupName</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a snapshot, a <c>DBSnapshotIdentifier</c> must be provided.
        /// </para>
        ///  </li> </ul>
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
        /// of events generated by an instance, you would set this parameter to <c>db-instance</c>.
        /// If this value is not specified, all events are returned.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>db-instance</c>, <c>db-cluster</c>, <c>db-parameter-group</c>, <c>db-security-group</c>,
        /// <c>db-cluster-snapshot</c> 
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
        /// Constraints: The name must be fewer than 255 characters.
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
        /// The tags to be assigned to the event subscription.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}