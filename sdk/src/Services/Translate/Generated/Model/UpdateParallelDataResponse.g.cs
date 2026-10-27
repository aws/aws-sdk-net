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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the UpdateParallelData operation.
    /// </summary>
    public partial class UpdateParallelDataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptAt. 
        /// <para>
        /// The time that the most recent update was attempted.
        /// </para>
        /// </summary>
        public DateTime? LatestUpdateAttemptAt { get; set; }

        /// <summary>
        /// Checks to see if the LatestUpdateAttemptAt property is set.
        /// </summary>
        internal bool IsSetLatestUpdateAttemptAt() => this.LatestUpdateAttemptAt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptStatus. 
        /// <para>
        /// The status of the parallel data update attempt. When the updated parallel data resource
        /// is ready for you to use, the status is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public ParallelDataStatus LatestUpdateAttemptStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestUpdateAttemptStatus property is set.
        /// </summary>
        internal bool IsSetLatestUpdateAttemptStatus() => this.LatestUpdateAttemptStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parallel data resource being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the parallel data resource that you are attempting to update. Your update
        /// request is accepted only if this status is either <c>ACTIVE</c> or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ParallelDataStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
