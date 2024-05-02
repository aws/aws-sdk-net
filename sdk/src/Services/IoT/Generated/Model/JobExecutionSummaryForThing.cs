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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The job execution summary for a thing.
    /// </summary>
    public partial class JobExecutionSummaryForThing
    {
        private JobExecutionSummary _jobExecutionSummary;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobExecutionSummary. 
        /// <para>
        /// Contains a subset of information about a job execution.
        /// </para>
        /// </summary>
        public JobExecutionSummary JobExecutionSummary
        {
            get { return this._jobExecutionSummary; }
            set { this._jobExecutionSummary = value; }
        }

        // Check to see if JobExecutionSummary property is set
        internal bool IsSetJobExecutionSummary()
        {
            return this._jobExecutionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}