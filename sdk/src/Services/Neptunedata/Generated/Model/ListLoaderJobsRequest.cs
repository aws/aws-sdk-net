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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the ListLoaderJobs operation.
    /// Retrieves a list of the <code>loadIds</code> for all active loader jobs.
    /// </summary>
    public partial class ListLoaderJobsRequest : AmazonNeptunedataRequest
    {
        private bool? _includeQueuedLoads;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property IncludeQueuedLoads. 
        /// <para>
        /// An optional parameter that can be used to exclude the load IDs of queued load requests
        /// when requesting a list of load IDs by setting the parameter to <code>FALSE</code>.
        /// The default value is <code>TRUE</code>.
        /// </para>
        /// </summary>
        public bool IncludeQueuedLoads
        {
            get { return this._includeQueuedLoads.GetValueOrDefault(); }
            set { this._includeQueuedLoads = value; }
        }

        // Check to see if IncludeQueuedLoads property is set
        internal bool IsSetIncludeQueuedLoads()
        {
            return this._includeQueuedLoads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of load IDs to list. Must be a positive integer greater than zero and not
        /// more than <code>100</code> (which is the default).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}