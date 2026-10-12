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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Contains the health status information for a scheduled report, including the status
    /// code and any reasons for an unhealthy state.
    /// </summary>
    public partial class HealthStatus
    {
        /// <summary>
        /// Gets and sets the property LastRefreshedAt. 
        /// <para>
        /// The timestamp when the health status was last refreshed.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshedAt property is set.
        /// </summary>
        internal bool IsSetLastRefreshedAt() => this.LastRefreshedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The health status code. <c>HEALTHY</c> indicates the scheduled report is configured
        /// properly and has all required permissions to execute. <c>UNHEALTHY</c> indicates the
        /// scheduled report is unable to deliver the notification to the default Amazon EventBridge
        /// EventBus in your account and your action is needed. The reason for the unhealthy state
        /// is captured in the health status reasons.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// The list of reasons for the current health status. Only present when the status is
        /// <c>UNHEALTHY</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
