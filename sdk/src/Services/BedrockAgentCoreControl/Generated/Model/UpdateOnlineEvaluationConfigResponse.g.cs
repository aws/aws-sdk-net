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
    /// This is the response object from the UpdateOnlineEvaluationConfig operation.
    /// </summary>
    public partial class UpdateOnlineEvaluationConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  The execution status indicating whether the online evaluation is currently running.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnlineEvaluationExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason for failure if the online evaluation configuration update or execution
        /// failed. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the updated online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigArn property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigArn() => this.OnlineEvaluationConfigArn != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigId. 
        /// <para>
        ///  The unique identifier of the updated online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigId { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigId property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigId() => this.OnlineEvaluationConfigId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the online evaluation configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnlineEvaluationConfigStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the online evaluation configuration was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
