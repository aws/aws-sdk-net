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
    /// A summary of the call execution that includes an execution ID, the type of execution
    /// (for example, <c>Command</c>), and the date/time of the execution using a datetime
    /// object that is saved in the following format: <c>yyyy-MM-dd'T'HH:mm:ss'Z'</c>
    /// </summary>
    public partial class ComplianceExecutionSummary
    {
        private string _executionId;
        private DateTime? _executionTime;
        private string _executionType;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// An ID created by the system when <c>PutComplianceItems</c> was called. For example,
        /// <c>CommandID</c> is a valid execution ID. You can use this ID in subsequent calls.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The time the execution ran as a datetime object that is saved in the following format:
        /// <c>yyyy-MM-dd'T'HH:mm:ss'Z'</c> 
        /// </para>
        ///  <important> 
        /// <para>
        /// For State Manager associations, this timestamp represents when the compliance status
        /// was captured and reported by the Systems Manager service, not when the underlying
        /// association was actually executed on the managed node. To track actual association
        /// execution times, use the <a>DescribeAssociationExecutionTargets</a> command or check
        /// the association execution history in the Systems Manager console.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// The type of execution. For example, <c>Command</c> is a valid execution type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string ExecutionType
        {
            get { return this._executionType; }
            set { this._executionType = value; }
        }

        // Check to see if ExecutionType property is set
        internal bool IsSetExecutionType()
        {
            return this._executionType != null;
        }

    }
}