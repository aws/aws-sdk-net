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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>ListEventSubscriptions</a>
    /// action.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Gets and sets the property EventSubscriptions. 
        /// <para>
        /// The list of existing event subscriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<EventSubscription> EventSubscriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<EventSubscription>() : null;

        /// <summary>
        /// Checks to see if the EventSubscriptions property is set.
        /// </summary>
        internal bool IsSetEventSubscriptions() => this.EventSubscriptions != null && (this.EventSubscriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the assessment template that is used during the event for which the SNS
        /// notification is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the Amazon Simple Notification Service (SNS) topic to which the SNS notifications
        /// are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string TopicArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicArn property is set.
        /// </summary>
        internal bool IsSetTopicArn() => this.TopicArn != null;
    }
}
