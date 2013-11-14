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
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EventSubscription : AmazonWebServiceResponse
    {
        
        private string customerAwsId;
        private string custSubscriptionId;
        private string snsTopicArn;
        private string status;
        private DateTime? subscriptionCreationTime;
        private string sourceType;
        private List<string> sourceIdsList = new List<string>();
        private List<string> eventCategoriesList = new List<string>();
        private string severity;
        private bool? enabled;


        /// <summary>
        /// The AWS customer account associated with the Amazon Redshift event notification subscription.
        ///  
        /// </summary>
        public string CustomerAwsId
        {
            get { return this.customerAwsId; }
            set { this.customerAwsId = value; }
        }

        // Check to see if CustomerAwsId property is set
        internal bool IsSetCustomerAwsId()
        {
            return this.customerAwsId != null;
        }

        /// <summary>
        /// The name of the Amazon Redshift event notification subscription.
        ///  
        /// </summary>
        public string CustSubscriptionId
        {
            get { return this.custSubscriptionId; }
            set { this.custSubscriptionId = value; }
        }

        // Check to see if CustSubscriptionId property is set
        internal bool IsSetCustSubscriptionId()
        {
            return this.custSubscriptionId != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic used by the event notification subscription.
        ///  
        /// </summary>
        public string SnsTopicArn
        {
            get { return this.snsTopicArn; }
            set { this.snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this.snsTopicArn != null;
        }

        /// <summary>
        /// The status of the Amazon Redshift event notification subscription. Constraints: <ul> <li>Can be one of the following: active | no-permission
        /// | topic-not-exist</li> <li>The status "no-permission" indicates that Amazon Redshift no longer has permission to post to the Amazon SNS
        /// topic. The status "topic-not-exist" indicates that the topic was deleted after the subscription was created.</li> </ul>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The date and time the Amazon Redshift event notification subscription was created.
        ///  
        /// </summary>
        public DateTime SubscriptionCreationTime
        {
            get { return this.subscriptionCreationTime ?? default(DateTime); }
            set { this.subscriptionCreationTime = value; }
        }

        // Check to see if SubscriptionCreationTime property is set
        internal bool IsSetSubscriptionCreationTime()
        {
            return this.subscriptionCreationTime.HasValue;
        }

        /// <summary>
        /// The source type of the events returned the Amazon Redshift event notification, such as cluster, or cluster-snapshot.
        ///  
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;
        }

        /// <summary>
        /// A list of the sources that publish events to the Amazon Redshift event notification subscription.
        ///  
        /// </summary>
        public List<string> SourceIdsList
        {
            get { return this.sourceIdsList; }
            set { this.sourceIdsList = value; }
        }

        // Check to see if SourceIdsList property is set
        internal bool IsSetSourceIdsList()
        {
            return this.sourceIdsList.Count > 0;
        }

        /// <summary>
        /// The list of Amazon Redshift event categories specified in the event notification subscription. Values: Configuration, Management,
        /// Monitoring, Security
        ///  
        /// </summary>
        public List<string> EventCategoriesList
        {
            get { return this.eventCategoriesList; }
            set { this.eventCategoriesList = value; }
        }

        // Check to see if EventCategoriesList property is set
        internal bool IsSetEventCategoriesList()
        {
            return this.eventCategoriesList.Count > 0;
        }

        /// <summary>
        /// The event severity specified in the Amazon Redshift event notification subscription. Values: ERROR, INFO
        ///  
        /// </summary>
        public string Severity
        {
            get { return this.severity; }
            set { this.severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }

        /// <summary>
        /// A Boolean value indicating whether the subscription is enabled. <c>true</c> indicates the subscription is enabled.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }
    }
}
