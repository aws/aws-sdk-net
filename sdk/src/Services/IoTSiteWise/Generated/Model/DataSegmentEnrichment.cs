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
    /// Contains enrichment status information for a data segment.
    /// </summary>
    public partial class DataSegmentEnrichment
    {
        private DateTime? _lastEnrichedAt;
        private EnrichmentStatus _status;

        /// <summary>
        /// Gets and sets the property LastEnrichedAt. 
        /// <para>
        /// The date the data segment was last enriched, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastEnrichedAt
        {
            get { return this._lastEnrichedAt; }
            set { this._lastEnrichedAt = value; }
        }

        // Check to see if LastEnrichedAt property is set
        internal bool IsSetLastEnrichedAt()
        {
            return this._lastEnrichedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The enrichment status of the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}