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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Launch Status of the Job Post Launch Actions.
    /// </summary>
    public partial class JobPostLaunchActionsLaunchStatus
    {
        private string _executionid;
        private PostLaunchActionExecutionStatus _executionStatus;
        private string _failureReason;
        private SsmDocument _ssmDocument;
        private SsmDocumentType _ssmDocumentType;

        /// <summary>
        /// Gets and sets the property ExecutionID. 
        /// <para>
        /// AWS Systems Manager Document's execution ID of the of the Job Post Launch Actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ExecutionID
        {
            get { return this._executionid; }
            set { this._executionid = value; }
        }

        // Check to see if ExecutionID property is set
        internal bool IsSetExecutionID()
        {
            return this._executionid != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// AWS Systems Manager Document's execution status.
        /// </para>
        /// </summary>
        public PostLaunchActionExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// AWS Systems Manager Document's failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property SsmDocument. 
        /// <para>
        /// AWS Systems Manager's Document of the of the Job Post Launch Actions.
        /// </para>
        /// </summary>
        public SsmDocument SsmDocument
        {
            get { return this._ssmDocument; }
            set { this._ssmDocument = value; }
        }

        // Check to see if SsmDocument property is set
        internal bool IsSetSsmDocument()
        {
            return this._ssmDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SsmDocumentType. 
        /// <para>
        /// AWS Systems Manager Document type.
        /// </para>
        /// </summary>
        public SsmDocumentType SsmDocumentType
        {
            get { return this._ssmDocumentType; }
            set { this._ssmDocumentType = value; }
        }

        // Check to see if SsmDocumentType property is set
        internal bool IsSetSsmDocumentType()
        {
            return this._ssmDocumentType != null;
        }

    }
}