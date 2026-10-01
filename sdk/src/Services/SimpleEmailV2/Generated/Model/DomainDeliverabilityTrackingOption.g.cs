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

namespace Amazon.SimpleEmailV2.Model
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
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// A verified domain that’s associated with your Amazon Web Services account and currently
        /// has an active Deliverability dashboard subscription.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property InboxPlacementTrackingOption. 
        /// <para>
        /// An object that contains information about the inbox placement data settings for the
        /// domain.
        /// </para>
        /// </summary>
        public InboxPlacementTrackingOption InboxPlacementTrackingOption { get; set; }

        /// <summary>
        /// Checks to see if the InboxPlacementTrackingOption property is set.
        /// </summary>
        internal bool IsSetInboxPlacementTrackingOption() => this.InboxPlacementTrackingOption != null;

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The date when you enabled the Deliverability dashboard for the domain.
        /// </para>
        /// </summary>
        public DateTime? SubscriptionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStartDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionStartDate() => this.SubscriptionStartDate.HasValue;
    }
}
