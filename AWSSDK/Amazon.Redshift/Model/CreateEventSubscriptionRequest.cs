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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventSubscription operation.
    /// <para> Creates an Amazon Redshift event notification subscription. This action requires an ARN (Amazon Resource Name) of an Amazon SNS topic
    /// created by either the Amazon Redshift console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you must
    /// create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed in the SNS console. </para> <para> You can specify the source
    /// type, and lists of Amazon Redshift source IDs, event categories, and event severities. Notifications will be sent for all events you want
    /// that match those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1 and mycluster2, event categories =
    /// Availability, Backup, and severity = ERROR. The subsription will only send notifications for those ERROR events in the Availability and
    /// Backup categores for the specified clusters. </para> <para> If you specify both the source type and source IDs, such as source type =
    /// cluster and source identifier = my-cluster-1, notifiactions will be sent for all the cluster events for my-cluster-1. If you specify a
    /// source type but do not specify a source identifier, you will receive notice of the events for the objects of that type in your AWS account.
    /// If you do not specify either the SourceType nor the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
    /// sources belonging to your AWS account. You must specify a source type if you specify a source ID. </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.CreateEventSubscription"/>
    public class CreateEventSubscriptionRequest : AmazonWebServiceRequest
    {
        private string subscriptionName;
        private string snsTopicArn;
        private string sourceType;
        private List<string> sourceIds = new List<string>();
        private List<string> eventCategories = new List<string>();
        private string severity;
        private bool? enabled;

        /// <summary>
        /// The name of the event subscription to be created. Constraints: <ul> <li>Cannot be null, empty, or blank.</li> <li>Must contain from 1 to 255
        /// alphanumeric characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> </ul>
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
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic used to transmit the event notifications. The ARN is created by Amazon SNS when you
        /// create a topic and subscribe to it.
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
        /// The type of source that will be generating the events. For example, if you want to be notified of events generated by a cluster, you would
        /// set this parameter to cluster. If this value is not specified, events are returned for all Amazon Redshift objects in your AWS account. You
        /// must specify a source type in order to specify source IDs. Valid values: cluster, cluster-parameter-group, cluster-security-group, and
        /// cluster-snapshot.
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
        /// A list of one or more identifiers of Amazon Redshift source objects. All of the objects must be of the same type as was specified in the
        /// source type parameter. The event subscription will return only events generated by the specified objects. If not specified, then events are
        /// returned for all objects within the source type specified. Example: my-cluster-1, my-cluster-2 Example: my-snapshot-20131010
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
        /// Specifies the Amazon Redshift event categories to be published by the event notification subscription. Values: Configuration, Management,
        /// Monitoring, Security
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
        /// Specifies the Amazon Redshift event severity to be published by the event notification subscription. Values: ERROR, INFO
        ///  
        /// </summary>
        public string Severity
        {
            get { return this.severity; }
            set { this.severity = value; }
        }

        /// <summary>
        /// Sets the Severity property
        /// </summary>
        /// <param name="severity">The value to set for the Severity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEventSubscriptionRequest WithSeverity(string severity)
        {
            this.severity = severity;
            return this;
        }
            

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }

        /// <summary>
        /// A Boolean value; set to <c>true</c> to activate the subscription, set to <c>false</c> to create the subscription but not active it.
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
    
