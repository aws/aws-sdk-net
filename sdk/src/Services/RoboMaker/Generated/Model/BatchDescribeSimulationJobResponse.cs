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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the BatchDescribeSimulationJob operation.
    /// </summary>
    public partial class BatchDescribeSimulationJobResponse : AmazonWebServiceResponse
    {
        private List<SimulationJob> _jobs = new List<SimulationJob>();
        private List<string> _unprocessedJobs = new List<string>();

        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// A list of simulation jobs.
        /// </para>
        /// </summary>
        public List<SimulationJob> Jobs
        {
            get { return this._jobs; }
            set { this._jobs = value; }
        }

        // Check to see if Jobs property is set
        internal bool IsSetJobs()
        {
            return this._jobs != null && this._jobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedJobs. 
        /// <para>
        /// A list of unprocessed simulation job Amazon Resource Names (ARNs).
        /// </para>
        /// </summary>
        public List<string> UnprocessedJobs
        {
            get { return this._unprocessedJobs; }
            set { this._unprocessedJobs = value; }
        }

        // Check to see if UnprocessedJobs property is set
        internal bool IsSetUnprocessedJobs()
        {
            return this._unprocessedJobs != null && this._unprocessedJobs.Count > 0; 
        }

    }
}