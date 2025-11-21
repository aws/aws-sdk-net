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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// The configuration settings for a router output.
    /// </summary>
    public partial class RouterOutputConfiguration
    {
        private MediaConnectFlowRouterOutputConfiguration _mediaConnectFlow;
        private MediaLiveInputRouterOutputConfiguration _mediaLiveInput;
        private StandardRouterOutputConfiguration _standard;

        /// <summary>
        /// Gets and sets the property MediaConnectFlow.
        /// </summary>
        public MediaConnectFlowRouterOutputConfiguration MediaConnectFlow
        {
            get { return this._mediaConnectFlow; }
            set { this._mediaConnectFlow = value; }
        }

        // Check to see if MediaConnectFlow property is set
        internal bool IsSetMediaConnectFlow()
        {
            return this._mediaConnectFlow != null;
        }

        /// <summary>
        /// Gets and sets the property MediaLiveInput.
        /// </summary>
        public MediaLiveInputRouterOutputConfiguration MediaLiveInput
        {
            get { return this._mediaLiveInput; }
            set { this._mediaLiveInput = value; }
        }

        // Check to see if MediaLiveInput property is set
        internal bool IsSetMediaLiveInput()
        {
            return this._mediaLiveInput != null;
        }

        /// <summary>
        /// Gets and sets the property Standard.
        /// </summary>
        public StandardRouterOutputConfiguration Standard
        {
            get { return this._standard; }
            set { this._standard = value; }
        }

        // Check to see if Standard property is set
        internal bool IsSetStandard()
        {
            return this._standard != null;
        }

    }
}