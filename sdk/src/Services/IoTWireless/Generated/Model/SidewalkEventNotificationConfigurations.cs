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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// <c>SidewalkEventNotificationConfigurations</c> object, which is the event configuration
    /// object for Sidewalk-related event topics.
    /// </summary>
    public partial class SidewalkEventNotificationConfigurations
    {
        private EventNotificationTopicStatus _amazonIdEventTopic;

        /// <summary>
        /// Gets and sets the property AmazonIdEventTopic. 
        /// <para>
        /// Denotes whether the Amazon ID event topic is enabled or disabled.
        /// </para>
        /// </summary>
        public EventNotificationTopicStatus AmazonIdEventTopic
        {
            get { return this._amazonIdEventTopic; }
            set { this._amazonIdEventTopic = value; }
        }

        // Check to see if AmazonIdEventTopic property is set
        internal bool IsSetAmazonIdEventTopic()
        {
            return this._amazonIdEventTopic != null;
        }

    }
}