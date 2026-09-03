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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The configuration settings for a router input.
    /// </summary>
    public partial class RouterInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Failover.
        /// </summary>
        public FailoverRouterInputConfiguration Failover { get; set; }

        /// <summary>
        /// Checks to see if the Failover property is set.
        /// </summary>
        internal bool IsSetFailover() => this.Failover != null;

        /// <summary>
        /// Gets and sets the property MediaConnectFlow.
        /// </summary>
        public MediaConnectFlowRouterInputConfiguration MediaConnectFlow { get; set; }

        /// <summary>
        /// Checks to see if the MediaConnectFlow property is set.
        /// </summary>
        internal bool IsSetMediaConnectFlow() => this.MediaConnectFlow != null;

        /// <summary>
        /// Gets and sets the property MediaLiveChannel.
        /// </summary>
        public MediaLiveChannelRouterInputConfiguration MediaLiveChannel { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveChannel property is set.
        /// </summary>
        internal bool IsSetMediaLiveChannel() => this.MediaLiveChannel != null;

        /// <summary>
        /// Gets and sets the property Merge.
        /// </summary>
        public MergeRouterInputConfiguration Merge { get; set; }

        /// <summary>
        /// Checks to see if the Merge property is set.
        /// </summary>
        internal bool IsSetMerge() => this.Merge != null;

        /// <summary>
        /// Gets and sets the property Standard.
        /// </summary>
        public StandardRouterInputConfiguration Standard { get; set; }

        /// <summary>
        /// Checks to see if the Standard property is set.
        /// </summary>
        internal bool IsSetStandard() => this.Standard != null;
    }
}
