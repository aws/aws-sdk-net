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
    /// Update an existing ingress-type bridge.
    /// </summary>
    public partial class UpdateIngressGatewayBridgeRequest
    {
        private int? _maxBitrate;
        private int? _maxOutputs;

        /// <summary>
        /// Gets and sets the property MaxBitrate. 
        /// <para>
        ///  The maximum expected bitrate (in bps).
        /// </para>
        /// </summary>
        public int? MaxBitrate
        {
            get { return this._maxBitrate; }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxOutputs. 
        /// <para>
        ///  The maximum number of expected outputs.
        /// </para>
        /// </summary>
        public int? MaxOutputs
        {
            get { return this._maxOutputs; }
            set { this._maxOutputs = value; }
        }

        // Check to see if MaxOutputs property is set
        internal bool IsSetMaxOutputs()
        {
            return this._maxOutputs.HasValue; 
        }

    }
}