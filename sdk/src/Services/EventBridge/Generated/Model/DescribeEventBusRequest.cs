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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventBus operation.
    /// Displays details about an event bus in your account. This can include the external
    /// AWS accounts that are permitted to write events to your default event bus, and the
    /// associated policy. For custom event buses and partner event buses, it displays the
    /// name, ARN, policy, state, and creation time.
    /// 
    ///  
    /// <para>
    ///  To enable your account to receive events from other accounts on its default event
    /// bus, use <a>PutPermission</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about partner event buses, see <a>CreateEventBus</a>.
    /// </para>
    /// </summary>
    public partial class DescribeEventBusRequest : AmazonEventBridgeRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name or ARN of the event bus to show details for. If you omit this, the default
        /// event bus is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}