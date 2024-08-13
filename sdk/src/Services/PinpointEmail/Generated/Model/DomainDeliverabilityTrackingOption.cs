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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that contains information about the Deliverability dashboard subscription
    /// for a verified domain that you use to send email and currently has an active Deliverability
    /// dashboard subscription. If a Deliverability dashboard subscription is active for a
    /// domain, you gain access to reputation, inbox placement, and other metrics for the
    /// domain.
    /// </summary>
    public partial class DomainDeliverabilityTrackingOption
    {
        private string _domain;
        private InboxPlacementTrackingOption _inboxPlacementTrackingOption;
        private DateTime? _subscriptionStartDate;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// A verified domain that’s associated with your AWS account and currently has an active
        /// Deliverability dashboard subscription.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property InboxPlacementTrackingOption. 
        /// <para>
        /// An object that contains information about the inbox placement data settings for the
        /// domain.
        /// </para>
        /// </summary>
        public InboxPlacementTrackingOption InboxPlacementTrackingOption
        {
            get { return this._inboxPlacementTrackingOption; }
            set { this._inboxPlacementTrackingOption = value; }
        }

        // Check to see if InboxPlacementTrackingOption property is set
        internal bool IsSetInboxPlacementTrackingOption()
        {
            return this._inboxPlacementTrackingOption != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The date, in Unix time format, when you enabled the Deliverability dashboard for the
        /// domain.
        /// </para>
        /// </summary>
        public DateTime? SubscriptionStartDate
        {
            get { return this._subscriptionStartDate; }
            set { this._subscriptionStartDate = value; }
        }

        // Check to see if SubscriptionStartDate property is set
        internal bool IsSetSubscriptionStartDate()
        {
            return this._subscriptionStartDate.HasValue; 
        }

    }
}