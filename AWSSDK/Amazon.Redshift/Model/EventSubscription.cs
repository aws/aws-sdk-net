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
    /// 
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


        /// <summary>
        /// Sets the CustomerAwsId property
        /// </summary>
        /// <param name="customerAwsId">The value to set for the CustomerAwsId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithCustomerAwsId(string customerAwsId)
        {
            this._customerAwsId = customerAwsId;
            return this;
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


        /// <summary>
        /// Sets the CustSubscriptionId property
        /// </summary>
        /// <param name="custSubscriptionId">The value to set for the CustSubscriptionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithCustSubscriptionId(string custSubscriptionId)
        {
            this._custSubscriptionId = custSubscriptionId;
            return this;
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


        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEnabled(bool enabled)
        {
            this._enabled = enabled;
            return this;
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

        /// <summary>
        /// Sets the EventCategoriesList property
        /// </summary>
        /// <param name="eventCategoriesList">The values to add to the EventCategoriesList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEventCategoriesList(params string[] eventCategoriesList)
        {
            foreach (var element in eventCategoriesList)
            {
                this._eventCategoriesList.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EventCategoriesList property
        /// </summary>
        /// <param name="eventCategoriesList">The values to add to the EventCategoriesList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEventCategoriesList(IEnumerable<string> eventCategoriesList)
        {
            foreach (var element in eventCategoriesList)
            {
                this._eventCategoriesList.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the Severity property
        /// </summary>
        /// <param name="severity">The value to set for the Severity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSeverity(string severity)
        {
            this._severity = severity;
            return this;
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


        /// <summary>
        /// Sets the SnsTopicArn property
        /// </summary>
        /// <param name="snsTopicArn">The value to set for the SnsTopicArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSnsTopicArn(string snsTopicArn)
        {
            this._snsTopicArn = snsTopicArn;
            return this;
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

        /// <summary>
        /// Sets the SourceIdsList property
        /// </summary>
        /// <param name="sourceIdsList">The values to add to the SourceIdsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceIdsList(params string[] sourceIdsList)
        {
            foreach (var element in sourceIdsList)
            {
                this._sourceIdsList.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SourceIdsList property
        /// </summary>
        /// <param name="sourceIdsList">The values to add to the SourceIdsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceIdsList(IEnumerable<string> sourceIdsList)
        {
            foreach (var element in sourceIdsList)
            {
                this._sourceIdsList.Add(element);
            }
            return this;
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
        /// as cluster, or            cluster-snapshot.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }


        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceType(string sourceType)
        {
            this._sourceType = sourceType;
            return this;
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
        ///         <ul>            <li>Can be one of the following: active | no-permission |
        /// topic-not-exist</li>            <li>The status "no-permission" indicates that Amazon
        /// Redshift no longer has permission to post                to the Amazon SNS topic.
        /// The status "topic-not-exist" indicates that the topic was deleted                after
        /// the subscription was created.</li>        </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithStatus(string status)
        {
            this._status = status;
            return this;
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


        /// <summary>
        /// Sets the SubscriptionCreationTime property
        /// </summary>
        /// <param name="subscriptionCreationTime">The value to set for the SubscriptionCreationTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSubscriptionCreationTime(DateTime subscriptionCreationTime)
        {
            this._subscriptionCreationTime = subscriptionCreationTime;
            return this;
        }

        // Check to see if SubscriptionCreationTime property is set
        internal bool IsSetSubscriptionCreationTime()
        {
            return this._subscriptionCreationTime.HasValue; 
        }

    }
}