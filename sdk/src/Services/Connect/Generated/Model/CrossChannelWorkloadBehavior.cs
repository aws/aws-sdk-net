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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Defines the cross-channel and workload type routing behavior that allows an agent
    /// working on a contact to be offered a contact from a different channel or workload
    /// type.
    /// </summary>
    public partial class CrossChannelWorkloadBehavior
    {
        private ChannelWorkloadBehaviorType _channelWorkloadBehaviorType;

        /// <summary>
        /// Gets and sets the property ChannelWorkloadBehaviorType. 
        /// <para>
        /// Specifies the routing behavior for an agent handling their current channel and workload
        /// type.
        /// </para>
        /// </summary>
        public ChannelWorkloadBehaviorType ChannelWorkloadBehaviorType
        {
            get { return this._channelWorkloadBehaviorType; }
            set { this._channelWorkloadBehaviorType = value; }
        }

        // Check to see if ChannelWorkloadBehaviorType property is set
        internal bool IsSetChannelWorkloadBehaviorType()
        {
            return this._channelWorkloadBehaviorType != null;
        }

    }
}