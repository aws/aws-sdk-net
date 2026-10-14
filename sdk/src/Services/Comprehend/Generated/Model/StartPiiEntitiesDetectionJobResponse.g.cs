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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the StartPiiEntitiesDetectionJob operation.
    /// </summary>
    public partial class StartPiiEntitiesDetectionJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the PII entity detection job. It is a unique, fully
        /// qualified identifier for the job. It includes the Amazon Web Services account, Amazon
        /// Web Services Region, and the job ID. The format of the ARN is as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:comprehend:&lt;region&gt;:&lt;account-id&gt;:pii-entities-detection-job/&lt;job-id&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is an example job ARN:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:comprehend:us-west-2:111122223333:pii-entities-detection-job/1234abcd12ab34cd56ef1234567890ab</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier generated for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the job.
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;
    }
}
