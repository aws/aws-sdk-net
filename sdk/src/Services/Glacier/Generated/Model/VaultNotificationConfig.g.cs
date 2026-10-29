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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Represents a vault's notification configuration.
    /// </summary>
    public partial class VaultNotificationConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public VaultNotificationConfig() { }

        /// <summary>
        /// Instantiates VaultNotificationConfig with the parameterized properties
        /// </summary>
        /// <param name="snsTopic">The Amazon Simple Notification Service (Amazon SNS) topic Amazon Resource Name   (ARN).</param>
        /// <param name="events">A list of one or more events for which Amazon Glacier will send a notification to the   specified Amazon SNS topic.</param>
        public VaultNotificationConfig(string snsTopic, List<string> events)
        {
            this.SNSTopic = snsTopic;
            this.Events = events;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of one or more events for which Amazon Glacier will send a notification to
        /// the specified Amazon SNS topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SNSTopic. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) topic Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string SNSTopic { get; set; }

        /// <summary>
        /// Checks to see if the SNSTopic property is set.
        /// </summary>
        internal bool IsSetSNSTopic() => this.SNSTopic != null;
    }
}
