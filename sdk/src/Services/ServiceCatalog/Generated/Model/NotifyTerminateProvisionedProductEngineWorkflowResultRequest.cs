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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyTerminateProvisionedProductEngineWorkflowResult operation.
    /// Notifies the result of the terminate engine execution.
    /// </summary>
    public partial class NotifyTerminateProvisionedProductEngineWorkflowResultRequest : AmazonServiceCatalogRequest
    {
        private string _failureReason;
        private string _idempotencyToken;
        private string _recordId;
        private EngineWorkflowStatus _status;
        private string _workflowToken;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason why the terminate engine execution failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        ///  The idempotency token that identifies the terminate engine execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        ///  The identifier of the record. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the terminate engine execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngineWorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowToken. 
        /// <para>
        ///  The encrypted contents of the terminate engine execution payload that Service Catalog
        /// sends after the Terraform product terminate workflow starts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20000)]
        public string WorkflowToken
        {
            get { return this._workflowToken; }
            set { this._workflowToken = value; }
        }

        // Check to see if WorkflowToken property is set
        internal bool IsSetWorkflowToken()
        {
            return this._workflowToken != null;
        }

    }
}