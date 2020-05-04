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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The details of a Job node present in the workflow.
    /// </summary>
    public partial class JobNodeDetails
    {
        private List<JobRun> _jobRuns = new List<JobRun>();

        /// <summary>
        /// Gets and sets the property JobRuns. 
        /// <para>
        /// The information for the job runs represented by the job node.
        /// </para>
        /// </summary>
        public List<JobRun> JobRuns
        {
            get { return this._jobRuns; }
            set { this._jobRuns = value; }
        }

        // Check to see if JobRuns property is set
        internal bool IsSetJobRuns()
        {
            return this._jobRuns != null && this._jobRuns.Count > 0; 
        }

    }
}