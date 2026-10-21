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
    /// This is the response object from the CreateEventRule operation.
    /// </summary>
    public partial class CreateEventRuleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN of a <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property StatusSummaryByRegion. 
        /// <para>
        /// A list of an <c>EventRule</c>'s status by Region. Regions are mapped to <c>EventRuleStatusSummary</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, EventRuleStatusSummary> StatusSummaryByRegion { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, EventRuleStatusSummary>() : null;

        /// <summary>
        /// Checks to see if the StatusSummaryByRegion property is set.
        /// </summary>
        internal bool IsSetStatusSummaryByRegion() => this.StatusSummaryByRegion != null && (this.StatusSummaryByRegion.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
