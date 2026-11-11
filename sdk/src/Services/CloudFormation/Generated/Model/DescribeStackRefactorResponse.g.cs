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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeStackRefactor operation.
    /// </summary>
    public partial class DescribeStackRefactorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify the refactor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The stack refactor execution operation status that's provided after calling the <a>ExecuteStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public StackRefactorExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatusReason. 
        /// <para>
        /// A detailed explanation for the stack refactor <c>ExecutionStatus</c>.
        /// </para>
        /// </summary>
        public string ExecutionStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatusReason property is set.
        /// </summary>
        internal bool IsSetExecutionStatusReason() => this.ExecutionStatusReason != null;

        /// <summary>
        /// Gets and sets the property StackIds. 
        /// <para>
        /// The unique ID for each stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StackIds property is set.
        /// </summary>
        internal bool IsSetStackIds() => this.StackIds != null && (this.StackIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackRefactorId. 
        /// <para>
        /// The ID associated with the stack refactor created from the <a>CreateStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public string StackRefactorId { get; set; }

        /// <summary>
        /// Checks to see if the StackRefactorId property is set.
        /// </summary>
        internal bool IsSetStackRefactorId() => this.StackRefactorId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The stack refactor operation status that's provided after calling the <a>CreateStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        public StackRefactorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A detailed explanation for the stack refactor operation <c>Status</c>.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
