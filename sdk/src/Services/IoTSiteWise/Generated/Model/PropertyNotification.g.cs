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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains asset property value notification information. When the notification state
    /// is enabled, IoT SiteWise publishes property value updates to a unique MQTT topic.
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/interact-with-other-services.html">Interacting
    /// with other services</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class PropertyNotification
    {
        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current notification state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyNotificationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The MQTT topic to which IoT SiteWise publishes property value update notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;
    }
}
