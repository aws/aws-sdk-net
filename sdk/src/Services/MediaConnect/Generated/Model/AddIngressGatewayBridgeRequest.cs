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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddIngressGatewayBridgeRequest
    {
        private int? _maxBitrate;
        private int? _maxOutputs;

        /// <summary>
        /// Gets and sets the property MaxBitrate. The maximum expected bitrate (in bps).
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxOutputs. The maximum number of expected outputs.
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxOutputs
        {
            get { return this._maxOutputs.GetValueOrDefault(); }
            set { this._maxOutputs = value; }
        }

        // Check to see if MaxOutputs property is set
        internal bool IsSetMaxOutputs()
        {
            return this._maxOutputs.HasValue; 
        }

    }
}