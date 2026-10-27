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
    /// Container for the parameters to the ListEventRules operation. Returns a list of <c>EventRules</c>
    /// according to specified filters, in reverse chronological order (newest first).
    /// </summary>
    public partial class ListEventRulesRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in this call. The default value is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The start token for paginated calls. Retrieved from the response of a previous <c>ListEventRules</c>
        /// call. Next token uses Base64 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;
    }
}
