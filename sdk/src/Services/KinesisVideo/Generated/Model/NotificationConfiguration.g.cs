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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Use this API to configure Amazon Simple Notification Service (Amazon SNS) notifications
    /// for when fragments become available in a stream. If this parameter is null, the configuration
    /// will be deleted from the stream.
    /// 
    ///  
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/notifications.html">Notifications
    /// in Kinesis Video Streams</a> for more information.
    /// </para>
    /// </summary>
    public partial class NotificationConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// The destination information required to deliver a notification to a customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationDestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfig property is set.
        /// </summary>
        internal bool IsSetDestinationConfig() => this.DestinationConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates if a notification configuration is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
