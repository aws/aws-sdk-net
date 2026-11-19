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
    /// The run of a source action on one source server as part of a job.
    /// </summary>
    public partial class RemoteSourceActionInvocation
    {
        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the command finished.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RemoteSourceActionArn. 
        /// <para>
        /// The ARN of the source action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 100)]
        public string RemoteSourceActionArn { get; set; }

        /// <summary>
        /// Checks to see if the RemoteSourceActionArn property is set.
        /// </summary>
        internal bool IsSetRemoteSourceActionArn() => this.RemoteSourceActionArn != null;

        /// <summary>
        /// Gets and sets the property SourceServerArn. 
        /// <para>
        /// The ARN of the source server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 100)]
        public string SourceServerArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerArn property is set.
        /// </summary>
        internal bool IsSetSourceServerArn() => this.SourceServerArn != null;

        /// <summary>
        /// Gets and sets the property SsmCommandInvocationID. 
        /// <para>
        /// The ID of the AWS Systems Manager command that runs the source action on the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SsmCommandInvocationID { get; set; }

        /// <summary>
        /// Checks to see if the SsmCommandInvocationID property is set.
        /// </summary>
        internal bool IsSetSsmCommandInvocationID() => this.SsmCommandInvocationID != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the command started running.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the invocation.
        /// </para>
        /// </summary>
        public RemoteSourceActionInvocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
