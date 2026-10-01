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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon RDS event notification subscription. The subscription allows
    /// Amazon RDS to post events to an SNS topic.
    /// </summary>
    public partial class AwsRdsEventSubscriptionDetails
    {
        /// <summary>
        /// Gets and sets the property CustSubscriptionId. 
        /// <para>
        /// The identifier of the account that is associated with the event notification subscription.
        /// </para>
        /// </summary>
        public string CustSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the CustSubscriptionId property is set.
        /// </summary>
        internal bool IsSetCustSubscriptionId() => this.CustSubscriptionId != null;

        /// <summary>
        /// Gets and sets the property CustomerAwsId. 
        /// <para>
        /// The identifier of the event notification subscription.
        /// </para>
        /// </summary>
        public string CustomerAwsId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAwsId property is set.
        /// </summary>
        internal bool IsSetCustomerAwsId() => this.CustomerAwsId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the event notification subscription is enabled.
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
        /// The list of event categories for the event notification subscription.
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
        /// Gets and sets the property EventSubscriptionArn. 
        /// <para>
        /// The ARN of the event notification subscription.
        /// </para>
        /// </summary>
        public string EventSubscriptionArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSubscriptionArn property is set.
        /// </summary>
        internal bool IsSetEventSubscriptionArn() => this.EventSubscriptionArn != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the SNS topic to post the event notifications to.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SourceIdsList. 
        /// <para>
        /// A list of source identifiers for the event notification subscription.
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
        /// The source type for the event notification subscription.
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the event notification subscription.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>creating</c> | <c>modifying</c> | <c>deleting</c> | <c>active</c>
        /// | <c>no-permission</c> | <c>topic-not-exist</c> 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscriptionCreationTime. 
        /// <para>
        /// The datetime when the event notification subscription was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string SubscriptionCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionCreationTime property is set.
        /// </summary>
        internal bool IsSetSubscriptionCreationTime() => this.SubscriptionCreationTime != null;
    }
}
