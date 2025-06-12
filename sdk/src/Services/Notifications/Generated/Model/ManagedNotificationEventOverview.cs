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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
        private List<string> _aggregatedNotificationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AggregationEventType _aggregationEventType;
        private AggregationSummary _aggregationSummary;
        private string _arn;
        private DateTime? _creationTime;
        private string _managedNotificationConfigurationArn;
        private ManagedNotificationEventSummary _notificationEvent;
        private string _organizationalUnitId;
        private string _relatedAccount;

        /// <summary>
        /// Gets and sets the property AggregatedNotificationRegions. 
        /// <para>
        /// The list of the regions where the aggregated notifications in this <c>NotificationEvent</c>
        /// originated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AggregatedNotificationRegions
        {
            get { return this._aggregatedNotificationRegions; }
            set { this._aggregatedNotificationRegions = value; }
        }

        // Check to see if AggregatedNotificationRegions property is set
        internal bool IsSetAggregatedNotificationRegions()
        {
            return this._aggregatedNotificationRegions != null && (this._aggregatedNotificationRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public AggregationEventType AggregationEventType
        {
            get { return this._aggregationEventType; }
            set { this._aggregationEventType = value; }
        }

        // Check to see if AggregationEventType property is set
        internal bool IsSetAggregationEventType()
        {
            return this._aggregationEventType != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationSummary.
        /// </summary>
        public AggregationSummary AggregationSummary
        {
            get { return this._aggregationSummary; }
            set { this._aggregationSummary = value; }
        }

        // Check to see if AggregationSummary property is set
        internal bool IsSetAggregationSummary()
        {
            return this._aggregationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ManagedNotificationEvent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>ManagedNotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedNotificationConfigurationArn
        {
            get { return this._managedNotificationConfigurationArn; }
            set { this._managedNotificationConfigurationArn = value; }
        }

        // Check to see if ManagedNotificationConfigurationArn property is set
        internal bool IsSetManagedNotificationConfigurationArn()
        {
            return this._managedNotificationConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEvent.
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedNotificationEventSummary NotificationEvent
        {
            get { return this._notificationEvent; }
            set { this._notificationEvent = value; }
        }

        // Check to see if NotificationEvent property is set
        internal bool IsSetNotificationEvent()
        {
            return this._notificationEvent != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The Organizational Unit Id that an Amazon Web Services account belongs to.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account that related to the <c>ManagedNotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedAccount
        {
            get { return this._relatedAccount; }
            set { this._relatedAccount = value; }
        }

        // Check to see if RelatedAccount property is set
        internal bool IsSetRelatedAccount()
        {
            return this._relatedAccount != null;
        }

    }
}