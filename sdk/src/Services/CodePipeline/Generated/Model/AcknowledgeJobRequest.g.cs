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
    /// Container for the parameters to the AcknowledgeJob operation. Returns information
    /// about a specified job and whether that job has been received by the job worker. Used
    /// for custom actions only.
    /// </summary>
    public partial class AcknowledgeJobRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID of the job for which you want to confirm receipt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Nonce. 
        /// <para>
        /// A system-generated random number that CodePipeline uses to ensure that the job is
        /// being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a>
        /// request that returned this job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Nonce { get; set; }

        /// <summary>
        /// Checks to see if the Nonce property is set.
        /// </summary>
        internal bool IsSetNonce() => this.Nonce != null;
    }
}
