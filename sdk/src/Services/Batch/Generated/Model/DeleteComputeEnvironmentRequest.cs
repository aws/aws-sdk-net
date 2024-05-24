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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// Container for the parameters to the DeleteComputeEnvironment operation.
    /// Deletes an Batch compute environment.
    /// 
    ///  
    /// <para>
    /// Before you can delete a compute environment, you must set its state to <c>DISABLED</c>
    /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
    /// job queues with the <a>UpdateJobQueue</a> API operation. Compute environments that
    /// use Fargate resources must terminate all active jobs on that compute environment before
    /// deleting the compute environment. If this isn't done, the compute environment enters
    /// an invalid state.
    /// </para>
    /// </summary>
    public partial class DeleteComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironment;

        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the compute environment to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironment
        {
            get { return this._computeEnvironment; }
            set { this._computeEnvironment = value; }
        }

        // Check to see if ComputeEnvironment property is set
        internal bool IsSetComputeEnvironment()
        {
            return this._computeEnvironment != null;
        }

    }
}