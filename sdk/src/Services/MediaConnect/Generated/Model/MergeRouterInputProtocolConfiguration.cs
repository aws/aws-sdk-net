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
    /// Protocol configuration settings for merge router inputs.
    /// </summary>
    public partial class MergeRouterInputProtocolConfiguration
    {
        private RistRouterInputConfiguration _rist;
        private RtpRouterInputConfiguration _rtp;

        /// <summary>
        /// Gets and sets the property Rist.
        /// </summary>
        public RistRouterInputConfiguration Rist
        {
            get { return this._rist; }
            set { this._rist = value; }
        }

        // Check to see if Rist property is set
        internal bool IsSetRist()
        {
            return this._rist != null;
        }

        /// <summary>
        /// Gets and sets the property Rtp.
        /// </summary>
        public RtpRouterInputConfiguration Rtp
        {
            get { return this._rtp; }
            set { this._rtp = value; }
        }

        // Check to see if Rtp property is set
        internal bool IsSetRtp()
        {
            return this._rtp != null;
        }

    }
}