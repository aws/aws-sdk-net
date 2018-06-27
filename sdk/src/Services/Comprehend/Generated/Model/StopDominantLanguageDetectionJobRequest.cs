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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StopDominantLanguageDetectionJob operation.
    /// Stops a dominant language detection job in progress.
    /// 
    ///  
    /// <para>
    /// If the job state is <code>IN_PROGRESS</code> the job will be marked for termination
    /// and put into the <code>STOPPING</code> state.
    /// </para>
    ///  
    /// <para>
    /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
    /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation will
    /// return a 400 Internal Request Exception. 
    /// </para>
    ///  
    /// <para>
    /// When a job is stopped, any document that has already been processed will be written
    /// to the output location.
    /// </para>
    /// </summary>
    public partial class StopDominantLanguageDetectionJobRequest : AmazonComprehendRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier of the dominant language detection job to stop.
        /// </para>
        /// </summary>
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