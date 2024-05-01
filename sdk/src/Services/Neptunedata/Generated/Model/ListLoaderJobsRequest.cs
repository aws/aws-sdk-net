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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the ListLoaderJobs operation.
    /// Retrieves a list of the <c>loadIds</c> for all active loader jobs.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listloaderjobs">neptune-db:ListLoaderJobs</a>
    /// IAM action in that cluster..
    /// </para>
    /// </summary>
    public partial class ListLoaderJobsRequest : AmazonNeptunedataRequest
    {
        private bool? _includeQueuedLoads;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property IncludeQueuedLoads. 
        /// <para>
        /// An optional parameter that can be used to exclude the load IDs of queued load requests
        /// when requesting a list of load IDs by setting the parameter to <c>FALSE</c>. The default
        /// value is <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? IncludeQueuedLoads
        {
            get { return this._includeQueuedLoads; }
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
        /// more than <c>100</c> (which is the default).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}