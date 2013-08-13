/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>Contains the results of a successful invocation of the DescribeEventSubscriptions action.</para>
    /// </summary>
    public class EventSubscription
    {
        
        private string customerAwsId;
        private string custSubscriptionId;
        private string snsTopicArn;
        private string status;
        private string subscriptionCreationTime;
        private string sourceType;
        private List<string> sourceIdsList = new List<string>();
        private List<string> eventCategoriesList = new List<string>();
        private bool? enabled;

        /// <summary>
        /// The AWS customer account associated with the RDS event notification subscription.
        ///  
        /// </summary>
        public string CustomerAwsId
        {
            get { return this.customerAwsId; }
            set { this.customerAwsId = value; }
        }

        /// <summary>
        /// Sets the CustomerAwsId property
        /// </summary>
        /// <param name="customerAwsId">The value to set for the CustomerAwsId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithCustomerAwsId(string customerAwsId)
        {
            this.customerAwsId = customerAwsId;
            return this;
        }
            

        // Check to see if CustomerAwsId property is set
        internal bool IsSetCustomerAwsId()
        {
            return this.customerAwsId != null;
        }

        /// <summary>
        /// The RDS event notification subscription Id.
        ///  
        /// </summary>
        public string CustSubscriptionId
        {
            get { return this.custSubscriptionId; }
            set { this.custSubscriptionId = value; }
        }

        /// <summary>
        /// Sets the CustSubscriptionId property
        /// </summary>
        /// <param name="custSubscriptionId">The value to set for the CustSubscriptionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithCustSubscriptionId(string custSubscriptionId)
        {
            this.custSubscriptionId = custSubscriptionId;
            return this;
        }
            

        // Check to see if CustSubscriptionId property is set
        internal bool IsSetCustSubscriptionId()
        {
            return this.custSubscriptionId != null;
        }

        /// <summary>
        /// The topic ARN of the RDS event notification subscription.
        ///  
        /// </summary>
        public string SnsTopicArn
        {
            get { return this.snsTopicArn; }
            set { this.snsTopicArn = value; }
        }

        /// <summary>
        /// Sets the SnsTopicArn property
        /// </summary>
        /// <param name="snsTopicArn">The value to set for the SnsTopicArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSnsTopicArn(string snsTopicArn)
        {
            this.snsTopicArn = snsTopicArn;
            return this;
        }
            

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this.snsTopicArn != null;
        }

        /// <summary>
        /// The status of the RDS event notification subscription. Constraints: Can be one of the following: creating | modifying | deleting | active |
        /// no-permission | topic-not-exist The status "no-permission" indicates that RDS no longer has permission to post to the SNS topic. The status
        /// "topic-not-exist" indicates that the topic was deleted after the subscription was created.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The time the RDS event notification subscription was created.
        ///  
        /// </summary>
        public string SubscriptionCreationTime
        {
            get { return this.subscriptionCreationTime; }
            set { this.subscriptionCreationTime = value; }
        }

        /// <summary>
        /// Sets the SubscriptionCreationTime property
        /// </summary>
        /// <param name="subscriptionCreationTime">The value to set for the SubscriptionCreationTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSubscriptionCreationTime(string subscriptionCreationTime)
        {
            this.subscriptionCreationTime = subscriptionCreationTime;
            return this;
        }
            

        // Check to see if SubscriptionCreationTime property is set
        internal bool IsSetSubscriptionCreationTime()
        {
            return this.subscriptionCreationTime != null;
        }

        /// <summary>
        /// The source type for the RDS event notification subscription.
        ///  
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceType(string sourceType)
        {
            this.sourceType = sourceType;
            return this;
        }
            

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;
        }

        /// <summary>
        /// A list of source Ids for the RDS event notification subscription.
        ///  
        /// </summary>
        public List<string> SourceIdsList
        {
            get { return this.sourceIdsList; }
            set { this.sourceIdsList = value; }
        }
        /// <summary>
        /// Adds elements to the SourceIdsList collection
        /// </summary>
        /// <param name="sourceIdsList">The values to add to the SourceIdsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceIdsList(params string[] sourceIdsList)
        {
            foreach (string element in sourceIdsList)
            {
                this.sourceIdsList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SourceIdsList collection
        /// </summary>
        /// <param name="sourceIdsList">The values to add to the SourceIdsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithSourceIdsList(IEnumerable<string> sourceIdsList)
        {
            foreach (string element in sourceIdsList)
            {
                this.sourceIdsList.Add(element);
            }

            return this;
        }

        // Check to see if SourceIdsList property is set
        internal bool IsSetSourceIdsList()
        {
            return this.sourceIdsList.Count > 0;
        }

        /// <summary>
        /// A list of event categories for the RDS event notification subscription.
        ///  
        /// </summary>
        public List<string> EventCategoriesList
        {
            get { return this.eventCategoriesList; }
            set { this.eventCategoriesList = value; }
        }
        /// <summary>
        /// Adds elements to the EventCategoriesList collection
        /// </summary>
        /// <param name="eventCategoriesList">The values to add to the EventCategoriesList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEventCategoriesList(params string[] eventCategoriesList)
        {
            foreach (string element in eventCategoriesList)
            {
                this.eventCategoriesList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EventCategoriesList collection
        /// </summary>
        /// <param name="eventCategoriesList">The values to add to the EventCategoriesList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEventCategoriesList(IEnumerable<string> eventCategoriesList)
        {
            foreach (string element in eventCategoriesList)
            {
                this.eventCategoriesList.Add(element);
            }

            return this;
        }

        // Check to see if EventCategoriesList property is set
        internal bool IsSetEventCategoriesList()
        {
            return this.eventCategoriesList.Count > 0;
        }

        /// <summary>
        /// A Boolean value indicating if the subscription is enabled. True indicates the subscription is enabled.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EventSubscription WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }
            

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }
    }
}
