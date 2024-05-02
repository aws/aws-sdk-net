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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the StopTextTranslationJob operation.
    /// Stops an asynchronous batch translation job that is in progress.
    /// 
    ///  
    /// <para>
    /// If the job's state is <c>IN_PROGRESS</c>, the job will be marked for termination and
    /// put into the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped,
    /// it is put into the <c>COMPLETED</c> state. Otherwise, the job is put into the <c>STOPPED</c>
    /// state.
    /// </para>
    ///  
    /// <para>
    /// Asynchronous batch translation jobs are started with the <a>StartTextTranslationJob</a>
    /// operation. You can use the <a>DescribeTextTranslationJob</a> or <a>ListTextTranslationJobs</a>
    /// operations to get a batch translation job's <c>JobId</c>.
    /// </para>
    /// </summary>
    public partial class StopTextTranslationJobRequest : AmazonTranslateRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID of the job to be stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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