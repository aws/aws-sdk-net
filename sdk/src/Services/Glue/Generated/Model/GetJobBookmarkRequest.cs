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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetJobBookmark operation.
    /// Returns information on a job bookmark entry.
    /// 
    ///  
    /// <para>
    /// For more information about enabling and using job bookmarks, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-continuations.html">Tracking
    /// processed data using job bookmarks</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Job
    /// parameters used by Glue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html#aws-glue-api-jobs-job-Job">Job
    /// structure</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetJobBookmarkRequest : AmazonGlueRequest
    {
        private string _jobName;
        private string _runId;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job in question.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique run identifier associated with this job run.
        /// </para>
        /// </summary>
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

    }
}