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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// The CancelJob operation cancels an unfinished job.
    /// 
    ///  <note> 
    /// <para>
    /// You can only cancel a job that has a status of <c>Submitted</c>. To prevent a pipeline
    /// from starting to process a job while you're getting the job identifier, use <a>UpdatePipelineStatus</a>
    /// to temporarily pause the pipeline.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CancelJobRequest : AmazonElasticTranscoderRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the job that you want to cancel.
        /// </para>
        ///  
        /// <para>
        /// To get a list of the jobs (including their <c>jobId</c>) that have a status of <c>Submitted</c>,
        /// use the <a>ListJobsByStatus</a> API action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}