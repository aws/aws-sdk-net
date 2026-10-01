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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A condensed representation of a code interpreter session in Amazon Bedrock AgentCore.
    /// This structure contains key information about a code interpreter session, including
    /// identifiers, status, and timestamps, without the full details of the session configuration.
    /// </summary>
    public partial class CodeInterpreterSessionSummary
    {
        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter associated with the session. This identifier
        /// specifies which code interpreter environment is used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CodeInterpreterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CodeInterpreterIdentifier property is set.
        /// </summary>
        internal bool IsSetCodeInterpreterIdentifier() => this.CodeInterpreterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the code interpreter session was created. This value is in ISO
        /// 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the code interpreter session was last updated. This value is in
        /// ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code interpreter session. This name helps identify and manage the
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the code interpreter session. This identifier is used in
        /// operations that interact with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code interpreter session. Possible values include ACTIVE,
        /// STOPPING, and STOPPED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeInterpreterSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
