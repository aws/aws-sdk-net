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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Launch Status of the Job Post Launch Actions.
    /// </summary>
    public partial class JobPostLaunchActionsLaunchStatus
    {
        /// <summary>
        /// Gets and sets the property ExecutionID. 
        /// <para>
        /// AWS Systems Manager Document's execution ID of the Job Post Launch Actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionID property is set.
        /// </summary>
        internal bool IsSetExecutionID() => this.ExecutionID != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// AWS Systems Manager Document's execution status.
        /// </para>
        /// </summary>
        public PostLaunchActionExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// AWS Systems Manager Document's failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property SsmDocument. 
        /// <para>
        /// AWS Systems Manager's Document of the Job Post Launch Actions.
        /// </para>
        /// </summary>
        public SsmDocument SsmDocument { get; set; }

        /// <summary>
        /// Checks to see if the SsmDocument property is set.
        /// </summary>
        internal bool IsSetSsmDocument() => this.SsmDocument != null;

        /// <summary>
        /// Gets and sets the property SsmDocumentType. 
        /// <para>
        /// AWS Systems Manager Document type.
        /// </para>
        /// </summary>
        public SsmDocumentType SsmDocumentType { get; set; }

        /// <summary>
        /// Checks to see if the SsmDocumentType property is set.
        /// </summary>
        internal bool IsSetSsmDocumentType() => this.SsmDocumentType != null;
    }
}
