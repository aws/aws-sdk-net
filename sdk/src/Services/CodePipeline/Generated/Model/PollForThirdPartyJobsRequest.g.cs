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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PollForThirdPartyJobs operation. Determines whether
    /// there are any third party jobs for a job worker to act on. Used for partner actions
    /// only. <important> <para> When this API is called, CodePipeline returns temporary credentials
    /// for the S3 bucket used to store artifacts for the pipeline, if the action requires
    /// access to that S3 bucket for input or output artifacts. </para> </important>
    /// </summary>
    public partial class PollForThirdPartyJobsRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// Represents information about an action type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionTypeId ActionTypeId { get; set; }

        /// <summary>
        /// Checks to see if the ActionTypeId property is set.
        /// </summary>
        internal bool IsSetActionTypeId() => this.ActionTypeId != null;

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum number of jobs to return in a poll for jobs call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSize property is set.
        /// </summary>
        internal bool IsSetMaxBatchSize() => this.MaxBatchSize.HasValue;
    }
}
