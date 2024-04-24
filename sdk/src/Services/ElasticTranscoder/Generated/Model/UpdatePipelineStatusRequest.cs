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
    /// Container for the parameters to the UpdatePipelineStatus operation.
    /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
    /// stops or restarts the processing of jobs.
    /// 
    ///  
    /// <para>
    /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
    /// can't cancel jobs after Elastic Transcoder has started processing them; if you pause
    /// the pipeline to which you submitted the jobs, you have more time to get the job IDs
    /// for the jobs that you want to cancel, and to send a <a>CancelJob</a> request. 
    /// </para>
    /// </summary>
    public partial class UpdatePipelineStatusRequest : AmazonElasticTranscoderRequest
    {
        private string _id;
        private string _status;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the pipeline to update.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The desired status of the pipeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c>: The pipeline is processing jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Paused</c>: The pipeline is not currently processing jobs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
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