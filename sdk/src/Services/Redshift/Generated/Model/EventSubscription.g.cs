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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes event subscriptions.
    /// </summary>
    public partial class EventSubscription
    {
        /// <summary>
        /// Gets and sets the property CustSubscriptionId. 
        /// <para>
        /// The name of the Amazon Redshift event notification subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CustSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the CustSubscriptionId property is set.
        /// </summary>
        internal bool IsSetCustSubscriptionId() => this.CustSubscriptionId != null;

        /// <summary>
        /// Gets and sets the property CustomerAwsId. 
        /// <para>
        /// The Amazon Web Services account associated with the Amazon Redshift event notification
        /// subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CustomerAwsId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAwsId property is set.
        /// </summary>
        internal bool IsSetCustomerAwsId() => this.CustomerAwsId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A boolean value indicating whether the subscription is enabled; <c>true</c> indicates
        /// that the subscription is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EventCategoriesList. 
        /// <para>
        /// The list of Amazon Redshift event categories specified in the event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Values: Configuration, Management, Monitoring, Security, Pending
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventCategoriesList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventCategoriesList property is set.
        /// </summary>
        internal bool IsSetEventCategoriesList() => this.EventCategoriesList != null && (this.EventCategoriesList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic used by the event notification
        /// subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SourceIdsList. 
        /// <para>
        /// A list of the sources that publish events to the Amazon Redshift event notification
        /// subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceIdsList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceIdsList property is set.
        /// </summary>
        internal bool IsSetSourceIdsList() => this.SourceIdsList != null && (this.SourceIdsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the events returned by the Amazon Redshift event notification,
        /// such as cluster, cluster-snapshot, cluster-parameter-group, cluster-security-group,
        /// or scheduled-action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Redshift event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can be one of the following: active | no-permission | topic-not-exist
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The status "no-permission" indicates that Amazon Redshift no longer has permission
        /// to post to the Amazon SNS topic. The status "topic-not-exist" indicates that the topic
        /// was deleted after the subscription was created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscriptionCreationTime. 
        /// <para>
        /// The date and time the Amazon Redshift event notification subscription was created.
        /// </para>
        /// </summary>
        public DateTime? SubscriptionCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionCreationTime property is set.
        /// </summary>
        internal bool IsSetSubscriptionCreationTime() => this.SubscriptionCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the event subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
