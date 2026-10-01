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
    /// This is the response object from the GetDeliverabilityDashboardOptions operation.
    /// </summary>
    public partial class GetDeliverabilityDashboardOptionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountStatus. 
        /// <para>
        /// The current status of your Deliverability dashboard subscription. If this value is
        /// <c>PENDING_EXPIRATION</c>, your subscription is scheduled to expire at the end of
        /// the current calendar month.
        /// </para>
        /// </summary>
        public DeliverabilityDashboardAccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountStatus property is set.
        /// </summary>
        internal bool IsSetAccountStatus() => this.AccountStatus != null;

        /// <summary>
        /// Gets and sets the property ActiveSubscribedDomains. 
        /// <para>
        /// An array of objects, one for each verified domain that you use to send email and currently
        /// has an active Deliverability dashboard subscription that isn’t scheduled to expire
        /// at the end of the current calendar month.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainDeliverabilityTrackingOption> ActiveSubscribedDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainDeliverabilityTrackingOption>() : null;

        /// <summary>
        /// Checks to see if the ActiveSubscribedDomains property is set.
        /// </summary>
        internal bool IsSetActiveSubscribedDomains() => this.ActiveSubscribedDomains != null && (this.ActiveSubscribedDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DashboardEnabled. 
        /// <para>
        /// Specifies whether the Deliverability dashboard is enabled. If this value is <c>true</c>,
        /// the dashboard is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DashboardEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DashboardEnabled property is set.
        /// </summary>
        internal bool IsSetDashboardEnabled() => this.DashboardEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PendingExpirationSubscribedDomains. 
        /// <para>
        /// An array of objects, one for each verified domain that you use to send email and currently
        /// has an active Deliverability dashboard subscription that's scheduled to expire at
        /// the end of the current calendar month.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainDeliverabilityTrackingOption> PendingExpirationSubscribedDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainDeliverabilityTrackingOption>() : null;

        /// <summary>
        /// Checks to see if the PendingExpirationSubscribedDomains property is set.
        /// </summary>
        internal bool IsSetPendingExpirationSubscribedDomains() => this.PendingExpirationSubscribedDomains != null && (this.PendingExpirationSubscribedDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscriptionExpiryDate. 
        /// <para>
        /// The date when your current subscription to the Deliverability dashboard is scheduled
        /// to expire, if your subscription is scheduled to expire at the end of the current calendar
        /// month. This value is null if you have an active subscription that isn’t due to expire
        /// at the end of the month.
        /// </para>
        /// </summary>
        public DateTime? SubscriptionExpiryDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionExpiryDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionExpiryDate() => this.SubscriptionExpiryDate.HasValue;
    }
}
