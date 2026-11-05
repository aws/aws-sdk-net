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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes an overview and metadata for a ManagedNotificationEvent.
    /// </summary>
    public partial class ManagedNotificationEventOverview
    {
        /// <summary>
        /// Gets and sets the property AggregatedNotificationRegions. 
        /// <para>
        /// The list of the regions where the aggregated notifications in this <c>NotificationEvent</c>
        /// originated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AggregatedNotificationRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AggregatedNotificationRegions property is set.
        /// </summary>
        internal bool IsSetAggregatedNotificationRegions() => this.AggregatedNotificationRegions != null && (this.AggregatedNotificationRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregationEventType. 
        /// <para>
        /// The notifications aggregation type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AGGREGATE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The notification event is an aggregate notification. Aggregate notifications summarize
        /// grouped events over a specified time period.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CHILD</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some <c>EventRules</c> are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can
        /// be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The notification isn't aggregated.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public AggregationEventType AggregationEventType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationEventType property is set.
        /// </summary>
        internal bool IsSetAggregationEventType() => this.AggregationEventType != null;

        /// <summary>
        /// Gets and sets the property AggregationSummary.
        /// </summary>
        public AggregationSummary AggregationSummary { get; set; }

        /// <summary>
        /// Checks to see if the AggregationSummary property is set.
        /// </summary>
        internal bool IsSetAggregationSummary() => this.AggregationSummary != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ManagedNotificationEvent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>ManagedNotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManagedNotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedNotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetManagedNotificationConfigurationArn() => this.ManagedNotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property NotificationEvent.
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagedNotificationEventSummary NotificationEvent { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEvent property is set.
        /// </summary>
        internal bool IsSetNotificationEvent() => this.NotificationEvent != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The Organizational Unit Id that an Amazon Web Services account belongs to.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account that related to the <c>ManagedNotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelatedAccount { get; set; }

        /// <summary>
        /// Checks to see if the RelatedAccount property is set.
        /// </summary>
        internal bool IsSetRelatedAccount() => this.RelatedAccount != null;
    }
}
