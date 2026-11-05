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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains configuration settings for a quick connect.
    /// </summary>
    public partial class QuickConnectConfig
    {
        /// <summary>
        /// Gets and sets the property FlowConfig. 
        /// <para>
        ///  Flow configuration for quick connect setup. 
        /// </para>
        /// </summary>
        public FlowQuickConnectConfig FlowConfig { get; set; }

        /// <summary>
        /// Checks to see if the FlowConfig property is set.
        /// </summary>
        internal bool IsSetFlowConfig() => this.FlowConfig != null;

        /// <summary>
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// The phone configuration. This is required only if QuickConnectType is PHONE_NUMBER.
        /// </para>
        /// </summary>
        public PhoneNumberQuickConnectConfig PhoneConfig { get; set; }

        /// <summary>
        /// Checks to see if the PhoneConfig property is set.
        /// </summary>
        internal bool IsSetPhoneConfig() => this.PhoneConfig != null;

        /// <summary>
        /// Gets and sets the property QueueConfig. 
        /// <para>
        /// The queue configuration. This is required only if QuickConnectType is QUEUE.
        /// </para>
        /// </summary>
        public QueueQuickConnectConfig QueueConfig { get; set; }

        /// <summary>
        /// Checks to see if the QueueConfig property is set.
        /// </summary>
        internal bool IsSetQueueConfig() => this.QueueConfig != null;

        /// <summary>
        /// Gets and sets the property QuickConnectType. 
        /// <para>
        /// The type of quick connect. In the Connect Customer admin website, when you create
        /// a quick connect, you are prompted to assign one of the following types: Agent (USER),
        /// External (PHONE_NUMBER), or Queue (QUEUE). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuickConnectType QuickConnectType { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectType property is set.
        /// </summary>
        internal bool IsSetQuickConnectType() => this.QuickConnectType != null;

        /// <summary>
        /// Gets and sets the property UserConfig. 
        /// <para>
        /// The user configuration. This is required only if QuickConnectType is USER.
        /// </para>
        /// </summary>
        public UserQuickConnectConfig UserConfig { get; set; }

        /// <summary>
        /// Checks to see if the UserConfig property is set.
        /// </summary>
        internal bool IsSetUserConfig() => this.UserConfig != null;
    }
}
