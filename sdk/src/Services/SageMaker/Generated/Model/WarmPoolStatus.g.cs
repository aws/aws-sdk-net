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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Status and billing information about the warm pool.
    /// </summary>
    public partial class WarmPoolStatus
    {
        /// <summary>
        /// Gets and sets the property ResourceRetainedBillableTimeInSeconds. 
        /// <para>
        /// The billable time in seconds used by the warm pool. Billable time refers to the absolute
        /// wall-clock time.
        /// </para>
        ///  
        /// <para>
        /// Multiply <c>ResourceRetainedBillableTimeInSeconds</c> by the number of instances (<c>InstanceCount</c>)
        /// in your training cluster to get the total compute time SageMaker bills you if you
        /// run warm pool training. The formula is as follows: <c>ResourceRetainedBillableTimeInSeconds
        /// * InstanceCount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ResourceRetainedBillableTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRetainedBillableTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetResourceRetainedBillableTimeInSeconds() => this.ResourceRetainedBillableTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ReusedByJob. 
        /// <para>
        /// The name of the matching training job that reused the warm pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ReusedByJob { get; set; }

        /// <summary>
        /// Checks to see if the ReusedByJob property is set.
        /// </summary>
        internal bool IsSetReusedByJob() => this.ReusedByJob != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the warm pool.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InUse</c>: The warm pool is in use for the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Available</c>: The warm pool is available to reuse for a matching training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Reused</c>: The warm pool moved to a matching training job for reuse.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminated</c>: The warm pool is no longer available. Warm pools are unavailable
        /// if they are terminated by a user, terminated for a patch update, or terminated for
        /// exceeding the specified <c>KeepAlivePeriodInSeconds</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public WarmPoolResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
