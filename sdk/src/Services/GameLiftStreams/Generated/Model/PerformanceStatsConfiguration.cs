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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Configuration settings for sharing the stream session's performance stats with the
    /// client
    /// </summary>
    public partial class PerformanceStatsConfiguration
    {
        private bool? _sharedWithClient;

        /// <summary>
        /// Gets and sets the property SharedWithClient. 
        /// <para>
        /// Performance stats for the session are streamed to the client when set to <c>true</c>.
        /// Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? SharedWithClient
        {
            get { return this._sharedWithClient; }
            set { this._sharedWithClient = value; }
        }

        // Check to see if SharedWithClient property is set
        internal bool IsSetSharedWithClient()
        {
            return this._sharedWithClient.HasValue; 
        }

    }
}