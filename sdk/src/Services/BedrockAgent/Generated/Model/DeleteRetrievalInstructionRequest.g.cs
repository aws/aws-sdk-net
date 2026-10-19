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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRetrievalInstruction operation. Deletes
    /// a retrieval instruction or a single version of it. Omit retrievalInstructionVersion
    /// to delete the retrieval instruction itself; the service rejects that request with
    /// ConflictException while the retrieval instruction has versions or while lastTransitionStatus
    /// is CREATING or UPDATING. Specify retrievalInstructionVersion to delete only that version;
    /// the retrieval instruction and its other versions are unaffected.
    /// </summary>
    public partial class DeleteRetrievalInstructionRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the retrieval instruction to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionVersion. 
        /// <para>
        /// The version to delete. Omit this field to delete the retrieval instruction itself,
        /// which you can do only when it has no versions; while any version exists the service
        /// rejects the request with ConflictException. You cannot delete DRAFT on its own; deleting
        /// the retrieval instruction removes it.
        /// </para>
        /// </summary>
        public string RetrievalInstructionVersion { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionVersion property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionVersion() => this.RetrievalInstructionVersion != null;
    }
}
