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
    /// This is the response object from the CreateWatchlist operation.
    /// </summary>
    public partial class CreateWatchlistResponse : AmazonWebServiceResponse
    {
        private Watchlist _watchlist;

        /// <summary>
        /// Gets and sets the property Watchlist. 
        /// <para>
        /// Information about the newly created watchlist.
        /// </para>
        /// </summary>
        public Watchlist Watchlist
        {
            get { return this._watchlist; }
            set { this._watchlist = value; }
        }

        // Check to see if Watchlist property is set
        internal bool IsSetWatchlist()
        {
            return this._watchlist != null;
        }

    }
}