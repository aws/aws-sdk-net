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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyUpdateProvisionedProductEngineWorkflowResult
    /// operation. Notifies the result of the update engine execution.
    /// </summary>
    public partial class NotifyUpdateProvisionedProductEngineWorkflowResultRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason why the update engine execution failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        ///  The idempotency token that identifies the update engine execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        ///  The output of the update engine execution. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordOutput> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordOutput>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        ///  The identifier of the record. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the update engine execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EngineWorkflowStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkflowToken. 
        /// <para>
        ///  The encrypted contents of the update engine execution payload that Service Catalog
        /// sends after the Terraform product update workflow starts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20000)]
        public string WorkflowToken { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowToken property is set.
        /// </summary>
        internal bool IsSetWorkflowToken() => this.WorkflowToken != null;
    }
}
