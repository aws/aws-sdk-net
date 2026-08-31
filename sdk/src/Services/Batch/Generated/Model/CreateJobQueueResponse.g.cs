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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the CreateJobQueue operation.
    /// </summary>
    public partial class CreateJobQueueResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property JobQueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueArn property is set.
        /// </summary>
        internal bool IsSetJobQueueArn() => this.JobQueueArn != null;

        /// <summary>
        /// Gets and sets the property JobQueueName. 
        /// <para>
        /// The name of the job queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueueName { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueName property is set.
        /// </summary>
        internal bool IsSetJobQueueName() => this.JobQueueName != null;
    }
}
