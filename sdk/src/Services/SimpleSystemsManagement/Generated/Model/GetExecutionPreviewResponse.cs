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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetExecutionPreview operation.
    /// </summary>
    public partial class GetExecutionPreviewResponse : AmazonWebServiceResponse
    {
        private DateTime? _endedAt;
        private ExecutionPreview _executionPreview;
        private string _executionPreviewId;
        private ExecutionPreviewStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// A UTC timestamp indicating when the execution preview operation ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionPreview.
        /// </summary>
        public ExecutionPreview ExecutionPreview
        {
            get { return this._executionPreview; }
            set { this._executionPreview = value; }
        }

        // Check to see if ExecutionPreview property is set
        internal bool IsSetExecutionPreview()
        {
            return this._executionPreview != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionPreviewId. 
        /// <para>
        /// The generated ID for the existing execution preview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ExecutionPreviewId
        {
            get { return this._executionPreviewId; }
            set { this._executionPreviewId = value; }
        }

        // Check to see if ExecutionPreviewId property is set
        internal bool IsSetExecutionPreviewId()
        {
            return this._executionPreviewId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the execution preview operation.
        /// </para>
        /// </summary>
        public ExecutionPreviewStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Supplemental information about the current status of the execution preview.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}