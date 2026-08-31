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
    /// Information about the router output's stream, including connection state and destination
    /// details. The specific details provided vary based on the router output type.
    /// </summary>
    public partial class RouterOutputStreamDetails
    {
        /// <summary>
        /// Gets and sets the property MediaConnectFlow.
        /// </summary>
        public MediaConnectFlowRouterOutputStreamDetails MediaConnectFlow { get; set; }

        /// <summary>
        /// Checks to see if the MediaConnectFlow property is set.
        /// </summary>
        internal bool IsSetMediaConnectFlow() => this.MediaConnectFlow != null;

        /// <summary>
        /// Gets and sets the property MediaLiveInput.
        /// </summary>
        public MediaLiveInputRouterOutputStreamDetails MediaLiveInput { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveInput property is set.
        /// </summary>
        internal bool IsSetMediaLiveInput() => this.MediaLiveInput != null;

        /// <summary>
        /// Gets and sets the property Standard.
        /// </summary>
        public StandardRouterOutputStreamDetails Standard { get; set; }

        /// <summary>
        /// Checks to see if the Standard property is set.
        /// </summary>
        internal bool IsSetStandard() => this.Standard != null;
    }
}
