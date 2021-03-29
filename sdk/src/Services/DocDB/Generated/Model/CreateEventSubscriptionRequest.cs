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
    /// You can specify the type of source (<code>SourceType</code>) that you want to be notified
    /// of. You can also provide a list of Amazon DocumentDB sources (<code>SourceIds</code>)
    /// that trigger the events, and you can provide a list of event categories (<code>EventCategories</code>)
    /// for events that you want to be notified of. For example, you can specify <code>SourceType
    /// = db-instance</code>, <code>SourceIds = mydbinstance1, mydbinstance2</code> and <code>EventCategories
    /// = Availability, Backup</code>.
    /// </para>
    ///  
    /// <para>
    /// If you specify both the <code>SourceType</code> and <code>SourceIds</code> (such as
    /// <code>SourceType = db-instance</code> and <code>SourceIdentifier = myDBInstance1</code>),
    /// you are notified of all the <code>db-instance</code> events for the specified source.
    /// If you specify a <code>SourceType</code> but do not specify a <code>SourceIdentifier</code>,
    /// you receive notice of the events for that source type for all your Amazon DocumentDB
    /// sources. If you do not specify either the <code>SourceType</code> or the <code>SourceIdentifier</code>,
    /// you are notified of events generated from all Amazon DocumentDB sources belonging
    /// to your customer account.
    /// </para>
    /// </summary>
    public partial class CreateEventSubscriptionRequest : AmazonDocDBRequest
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
        ///  A Boolean value; set to <code>true</code> to activate the subscription, set to <code>false</code>
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
        ///  A list of event categories for a <code>SourceType</code> that you want to subscribe
        /// to. 
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
        /// If <code>SourceIds</code> are provided, <code>SourceType</code> must also be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is an instance, a <code>DBInstanceIdentifier</code> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a security group, a <code>DBSecurityGroupName</code> must be
        /// provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a parameter group, a <code>DBParameterGroupName</code> must
        /// be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a snapshot, a <code>DBSnapshotIdentifier</code> must be provided.
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
            return this._sourceIds != null && this._sourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source that is generating the events. For example, if you want to be notified
        /// of events generated by an instance, you would set this parameter to <code>db-instance</code>.
        /// If this value is not specified, all events are returned.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>db-instance</code>, <code>db-cluster</code>, <code>db-parameter-group</code>,
        /// <code>db-security-group</code>, <code>db-snapshot</code>, <code>db-cluster-snapshot</code>
        /// 
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}