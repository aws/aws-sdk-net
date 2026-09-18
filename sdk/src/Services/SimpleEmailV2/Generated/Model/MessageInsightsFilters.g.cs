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
    /// An object containing Message Insights filters.
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are joined by AND.
    /// </para>
    ///  
    /// <para>
    /// If you specify multiple values for a filter, the values are joined by OR. Filter values
    /// are case-sensitive.
    /// </para>
    ///  
    /// <para>
    ///  <c>FromEmailAddress</c>, <c>Destination</c>, and <c>Subject</c> filters support partial
    /// match. A partial match is performed by using the <c>*</c> wildcard character placed
    /// at the beginning (suffix match), the end (prefix match) or both ends of the string
    /// (contains match). In order to match the literal characters <c>*</c> or <c>\</c>, they
    /// must be escaped using the <c>\</c> character. If no wildcard character is present,
    /// an exact match is performed. 
    /// </para>
    /// </summary>
    public partial class MessageInsightsFilters
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The recipient's email address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Destination { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null && (this.Destination.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The from address used to send the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> FromEmailAddress { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null && (this.FromEmailAddress.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Isp. 
        /// <para>
        /// The recipient's ISP (e.g., <c>Gmail</c>, <c>Yahoo</c>, etc.).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Isp { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Isp property is set.
        /// </summary>
        internal bool IsSetIsp() => this.Isp != null && (this.Isp.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastDeliveryEvent. 
        /// <para>
        ///  The last delivery-related event for the email, where the ordering is as follows:
        /// <c>SEND</c> &lt; <c>BOUNCE</c> &lt; <c>DELIVERY</c> &lt; <c>COMPLAINT</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> LastDeliveryEvent { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LastDeliveryEvent property is set.
        /// </summary>
        internal bool IsSetLastDeliveryEvent() => this.LastDeliveryEvent != null && (this.LastDeliveryEvent.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastEngagementEvent. 
        /// <para>
        ///  The last engagement-related event for the email, where the ordering is as follows:
        /// <c>OPEN</c> &lt; <c>CLICK</c>. 
        /// </para>
        ///  
        /// <para>
        ///  Engagement events are only available if <a href="https://docs.aws.amazon.com/ses/latest/dg/vdm-settings.html">Engagement
        /// tracking</a> is enabled. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> LastEngagementEvent { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LastEngagementEvent property is set.
        /// </summary>
        internal bool IsSetLastEngagementEvent() => this.LastEngagementEvent != null && (this.LastEngagementEvent.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Subject { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null && (this.Subject.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant used when sending the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> TenantName { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null && (this.TenantName.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
