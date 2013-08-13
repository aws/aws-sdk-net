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
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// <para>Creates an RDS event notification subscription. This action requires a topic ARN (Amazon Resource Name) created by either the RDS
    /// console, the SNS console, or the SNS API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to the topic. The
    /// ARN is displayed in the SNS console.</para> <para>You can specify the type of source (SourceType) you want to be notified of, provide a list
    /// of RDS sources (SourceIds) that triggers the events, and provide a list of event categories (EventCategories) for events you want to be
    /// notified of. For example, you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2 and EventCategories =
    /// Availability, Backup.</para> <para>If you specify both the SourceType and SourceIds, such as SourceType = db-instance and SourceIdentifier =
    /// myDBInstance1, you will be notified of all the db-instance events for the specified source. If you specify a SourceType but do not specify a
    /// SourceIdentifier, you will receive notice of the events for that source type for all your RDS sources. If you do not specify either the
    /// SourceType nor the SourceIdentifier, you will be notified of events generated from all RDS sources belonging to your customer
    /// account.</para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateEventSubscription"/>
    public class CreateEventSubscriptionRequest : AmazonWebServiceRequest
    {
        private string subscriptionName;
        private string snsTopicArn;
        private string sourceType;
        private List<string> eventCategories = new List<string>();
        private List<string> sourceIds = new List<string>();
        private bool? enabled;

        /// <summary>
        /// The name of the subscription. Constraints: The name must be less than 255 characters.
        ///  
        /// </summary>
        public string SubscriptionName
        {
            get { return this.subscriptionName; }
            set { this.subscriptionName = value; }
        }

        /// <summary>
        /// Sets the SubscriptionName property
        /// </summary>
        /// <param name="subscriptionName">The value to set for the SubscriptionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithSubscriptionName(string subscriptionName)
        {
            this.subscriptionName = subscriptionName;
            return this;
        }
            

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this.subscriptionName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the SNS topic created for event notification. The ARN is created by Amazon SNS when you create a topic and
        /// subscribe to it.
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
        public CreateEventSubscriptionRequest WithSnsTopicArn(string snsTopicArn)
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
        /// The type of source that will be generating the events. For example, if you want to be notified of events generated by a DB instance, you
        /// would set this parameter to db-instance. if this value is not specified, all events are returned. Valid values: db-instance |
        /// db-parameter-group | db-security-group | db-snapshot
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
        public CreateEventSubscriptionRequest WithSourceType(string sourceType)
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
        /// A list of event categories for a SourceType that you want to subscribe to. You can see a list of the categories for a given SourceType in
        /// the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a> topic in the Amazon RDS User Guide or by
        /// using the <b>DescribeEventCategories</b> action.
        ///  
        /// </summary>
        public List<string> EventCategories
        {
            get { return this.eventCategories; }
            set { this.eventCategories = value; }
        }
        /// <summary>
        /// Adds elements to the EventCategories collection
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithEventCategories(params string[] eventCategories)
        {
            foreach (string element in eventCategories)
            {
                this.eventCategories.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EventCategories collection
        /// </summary>
        /// <param name="eventCategories">The values to add to the EventCategories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithEventCategories(IEnumerable<string> eventCategories)
        {
            foreach (string element in eventCategories)
            {
                this.eventCategories.Add(element);
            }

            return this;
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this.eventCategories.Count > 0;
        }

        /// <summary>
        /// The list of identifiers of the event sources for which events will be returned. If not specified, then all sources are included in the
        /// response. An identifier must begin with a letter and must contain only ASCII letters, digits, and hyphens; it cannot end with a hyphen or
        /// contain two consecutive hyphens. Constraints: <ul> <li>If SourceIds are supplied, SourceType must also be provided.</li> <li>If the source
        /// type is a DB instance, then a DBInstanceIdentifier must be supplied.</li> <li>If the source type is a DB security group, a
        /// DBSecurityGroupName must be supplied.</li> <li>If the source type is a DB parameter group, a DBParameterGroupName must be supplied.</li>
        /// <li>If the source type is a DB Snapshot, a DBSnapshotIdentifier must be supplied.</li> </ul>
        ///  
        /// </summary>
        public List<string> SourceIds
        {
            get { return this.sourceIds; }
            set { this.sourceIds = value; }
        }
        /// <summary>
        /// Adds elements to the SourceIds collection
        /// </summary>
        /// <param name="sourceIds">The values to add to the SourceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithSourceIds(params string[] sourceIds)
        {
            foreach (string element in sourceIds)
            {
                this.sourceIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SourceIds collection
        /// </summary>
        /// <param name="sourceIds">The values to add to the SourceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithSourceIds(IEnumerable<string> sourceIds)
        {
            foreach (string element in sourceIds)
            {
                this.sourceIds.Add(element);
            }

            return this;
        }

        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this.sourceIds.Count > 0;
        }

        /// <summary>
        /// A Boolean value; set to <b>true</b> to activate the subscription, set to <b>false</b> to create the subscription but not active it.
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
        public CreateEventSubscriptionRequest WithEnabled(bool enabled)
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
    
