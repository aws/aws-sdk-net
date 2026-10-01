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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the StartActiveApprovalTeamDeletion operation.
    /// </summary>
    public partial class StartActiveApprovalTeamDeletionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeletionCompletionTime. 
        /// <para>
        /// Timestamp when the deletion process is scheduled to complete.
        /// </para>
        /// </summary>
        public DateTime? DeletionCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionCompletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionCompletionTime() => this.DeletionCompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionStartTime. 
        /// <para>
        /// Timestamp when the deletion process was initiated.
        /// </para>
        /// </summary>
        public DateTime? DeletionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionStartTime property is set.
        /// </summary>
        internal bool IsSetDeletionStartTime() => this.DeletionStartTime.HasValue;
    }
}
