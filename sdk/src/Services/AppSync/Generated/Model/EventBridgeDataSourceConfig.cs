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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an Amazon EventBridge bus data source configuration.
    /// </summary>
    public partial class EventBridgeDataSourceConfig
    {
        private string _eventBusArn;

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The ARN of the event bus. For more information about event buses, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-bus.html">Amazon
        /// EventBridge event buses</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventBusArn
        {
            get { return this._eventBusArn; }
            set { this._eventBusArn = value; }
        }

        // Check to see if EventBusArn property is set
        internal bool IsSetEventBusArn()
        {
            return this._eventBusArn != null;
        }

    }
}