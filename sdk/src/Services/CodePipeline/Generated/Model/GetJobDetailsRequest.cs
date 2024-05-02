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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the GetJobDetails operation.
    /// Returns information about a job. Used for custom actions only.
    /// 
    ///  <important> 
    /// <para>
    /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
    /// used to store artifacts for the pipeline, if the action requires access to that S3
    /// bucket for input or output artifacts. This API also returns any secret values defined
    /// for the action.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetJobDetailsRequest : AmazonCodePipelineRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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