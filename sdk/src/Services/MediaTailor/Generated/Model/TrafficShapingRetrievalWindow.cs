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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration that tells Elemental MediaTailor how to spread out requests to the
    /// ad decision server (ADS). Instead of sending ADS requests for all sessions at the
    /// same time, MediaTailor spreads the requests across the amount of time specified in
    /// the retrieval window.
    /// </summary>
    public partial class TrafficShapingRetrievalWindow
    {
        private int? _retrievalWindowDurationSeconds;

        /// <summary>
        /// Gets and sets the property RetrievalWindowDurationSeconds. 
        /// <para>
        /// The amount of time, in seconds, that MediaTailor spreads prefetch requests to the
        /// ADS. 
        /// </para>
        /// </summary>
        public int? RetrievalWindowDurationSeconds
        {
            get { return this._retrievalWindowDurationSeconds; }
            set { this._retrievalWindowDurationSeconds = value; }
        }

        // Check to see if RetrievalWindowDurationSeconds property is set
        internal bool IsSetRetrievalWindowDurationSeconds()
        {
            return this._retrievalWindowDurationSeconds.HasValue; 
        }

    }
}