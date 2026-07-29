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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Configuration for the enrichment job defining which analysis type to perform on video
    /// time-series data. Currently supports event detection enrichment. Exactly one member
    /// must be specified.
    /// </summary>
    public partial class EnrichmentJobConfiguration
    {
        private EventDetection _eventDetection;

        /// <summary>
        /// Gets and sets the property EventDetection. 
        /// <para>
        /// Event detection configuration that generates embeddings from video time-series data
        /// enabling natural language similarity search on events. The service processes video
        /// data and creates embeddings stored in IoT SiteWise for semantic querying.
        /// </para>
        /// </summary>
        public EventDetection EventDetection
        {
            get { return this._eventDetection; }
            set { this._eventDetection = value; }
        }

        // Check to see if EventDetection property is set
        internal bool IsSetEventDetection()
        {
            return this._eventDetection != null;
        }

    }
}