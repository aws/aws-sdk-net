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
    /// Container for the parameters to the ListNotificationConfigurations operation. Returns
    /// a list of abbreviated <c>NotificationConfigurations</c> according to specified filters,
    /// in reverse chronological order (newest first).
    /// </summary>
    public partial class ListNotificationConfigurationsRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Channel to match.
        /// </para>
        /// </summary>
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property EventRuleSource. 
        /// <para>
        /// The matched event source.
        /// </para>
        ///  
        /// <para>
        /// Must match one of the valid EventBridge sources. Only Amazon Web Services service
        /// sourced events are supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string EventRuleSource { get; set; }

        /// <summary>
        /// Checks to see if the EventRuleSource property is set.
        /// </summary>
        internal bool IsSetEventRuleSource() => this.EventRuleSource != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in this call. Defaults to 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The <c>NotificationConfiguration</c> status to match.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All <c>EventRules</c> are <c>ACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some <c>EventRules</c> are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can
        /// be run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All <c>EventRules</c> are <c>INACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This <c>NotificationConfiguration</c> is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only <c>GET</c> and <c>LIST</c> calls can be run.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public NotificationConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// The subtype used to filter the notification configurations in the request.
        /// </para>
        /// </summary>
        public NotificationConfigurationSubtype Subtype { get; set; }

        /// <summary>
        /// Checks to see if the Subtype property is set.
        /// </summary>
        internal bool IsSetSubtype() => this.Subtype != null;
    }
}
