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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitRegistryRecordForApproval operation. Submits
    /// a registry record for approval. This transitions the record from <c>DRAFT</c> status
    /// to <c>PENDING_APPROVAL</c> status. If the registry has auto-approval enabled, the
    /// record is automatically approved.
    /// </summary>
    public partial class SubmitRegistryRecordForApprovalRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the registry record to submit for approval. You can specify either
        /// the Amazon Resource Name (ARN) or the ID of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry containing the record. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;
    }
}
