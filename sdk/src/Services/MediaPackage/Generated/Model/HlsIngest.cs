/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// An HTTP Live Streaming (HLS) ingest resource configuration.
    /// </summary>
    public partial class HlsIngest
    {
        private List<IngestEndpoint> _ingestEndpoints = new List<IngestEndpoint>();

        /// <summary>
        /// Gets and sets the property IngestEndpoints. A list of endpoints to which the source
        /// stream should be sent.
        /// </summary>
        public List<IngestEndpoint> IngestEndpoints
        {
            get { return this._ingestEndpoints; }
            set { this._ingestEndpoints = value; }
        }

        // Check to see if IngestEndpoints property is set
        internal bool IsSetIngestEndpoints()
        {
            return this._ingestEndpoints != null && this._ingestEndpoints.Count > 0; 
        }

    }
}