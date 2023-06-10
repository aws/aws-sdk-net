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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Details of the watchlists in a domain.
    /// </summary>
    public partial class WatchlistDetails
    {
        private string _defaultWatchlistId;

        /// <summary>
        /// Gets and sets the property DefaultWatchlistId. 
        /// <para>
        /// The identifier of the default watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string DefaultWatchlistId
        {
            get { return this._defaultWatchlistId; }
            set { this._defaultWatchlistId = value; }
        }

        // Check to see if DefaultWatchlistId property is set
        internal bool IsSetDefaultWatchlistId()
        {
            return this._defaultWatchlistId != null;
        }

    }
}