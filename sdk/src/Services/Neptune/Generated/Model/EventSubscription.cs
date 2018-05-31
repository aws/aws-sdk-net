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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the results of a successful invocation of the <a>DescribeEventSubscriptions</a>
    /// action.
    /// </summary>
    public partial class EventSubscription
    {
        private string _customerAwsId;
        private string _custSubscriptionId;
        private bool? _enabled;
        private List<string> _eventCategoriesList = new List<string>();
        private string _eventSubscriptionArn;
        private string _snsTopicArn;
        private List<string> _sourceIdsList = new List<string>();
        private string _sourceType;
        private string _status;
        private string _subscriptionCreationTime;

        /// <summary>
        /// Gets and sets the property CustomerAwsId. 
        /// <para>
        /// The AWS customer account associated with the RDS event notification subscription.
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
        /// The RDS event notification subscription Id.
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
        /// A Boolean value indicating if the subscription is enabled. True indicates the subscription
        /// is enabled.
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
        /// A list of event categories for the RDS event notification subscription.
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
        /// Gets and sets the property EventSubscriptionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the event subscription.
        /// </para>
        /// </summary>
        public string EventSubscriptionArn
        {
            get { return this._eventSubscriptionArn; }
            set { this._eventSubscriptionArn = value; }
        }

        // Check to see if EventSubscriptionArn property is set
        internal bool IsSetEventSubscriptionArn()
        {
            return this._eventSubscriptionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The topic ARN of the RDS event notification subscription.
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
        /// A list of source IDs for the RDS event notification subscription.
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
        /// The source type for the RDS event notification subscription.
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
        /// The status of the RDS event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  
        /// <para>
        /// Can be one of the following: creating | modifying | deleting | active | no-permission
        /// | topic-not-exist
        /// </para>
        ///  
        /// <para>
        /// The status "no-permission" indicates that RDS no longer has permission to post to
        /// the SNS topic. The status "topic-not-exist" indicates that the topic was deleted after
        /// the subscription was created.
        /// </para>
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
        /// The time the RDS event notification subscription was created.
        /// </para>
        /// </summary>
        public string SubscriptionCreationTime
        {
            get { return this._subscriptionCreationTime; }
            set { this._subscriptionCreationTime = value; }
        }

        // Check to see if SubscriptionCreationTime property is set
        internal bool IsSetSubscriptionCreationTime()
        {
            return this._subscriptionCreationTime != null;
        }

    }
}