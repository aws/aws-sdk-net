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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
    /// Container for the parameters to the PutDeliverabilityDashboardOption operation.
    /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
    /// dashboard, you gain access to reputation, deliverability, and other metrics for the
    /// domains that you use to send email. You also gain the ability to perform predictive
    /// inbox placement tests.
    /// 
    ///  
    /// <para>
    /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
    /// in addition to any other fees that you accrue by using Amazon SES and other Amazon
    /// Web Services services. For more information about the features and cost of a Deliverability
    /// dashboard subscription, see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES
    /// Pricing</a>.
    /// </para>
    /// </summary>
    public partial class PutDeliverabilityDashboardOptionRequest : AmazonSimpleEmailServiceV2Request
    {
        private bool? _dashboardEnabled;
        private List<DomainDeliverabilityTrackingOption> _subscribedDomains = AWSConfigs.InitializeCollections ? new List<DomainDeliverabilityTrackingOption>() : null;

        /// <summary>
        /// Gets and sets the property DashboardEnabled. 
        /// <para>
        /// Specifies whether to enable the Deliverability dashboard. To enable the dashboard,
        /// set this value to <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DashboardEnabled
        {
            get { return this._dashboardEnabled; }
            set { this._dashboardEnabled = value; }
        }

        // Check to see if DashboardEnabled property is set
        internal bool IsSetDashboardEnabled()
        {
            return this._dashboardEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubscribedDomains. 
        /// <para>
        /// An array of objects, one for each verified domain that you use to send email and enabled
        /// the Deliverability dashboard for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainDeliverabilityTrackingOption> SubscribedDomains
        {
            get { return this._subscribedDomains; }
            set { this._subscribedDomains = value; }
        }

        // Check to see if SubscribedDomains property is set
        internal bool IsSetSubscribedDomains()
        {
            return this._subscribedDomains != null && (this._subscribedDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}