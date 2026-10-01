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
    /// Container for the parameters to the StartCodeInterpreterSession operation. Creates
    /// and initializes a code interpreter session in Amazon Bedrock AgentCore. The session
    /// enables agents to execute code as part of their response generation, supporting programming
    /// languages such as Python for data analysis, visualization, and computation tasks.
    /// <para> To create a session, you must specify a code interpreter identifier and a name.
    /// The session remains active until it times out or you explicitly stop it using the
    /// <c>StopCodeInterpreterSession</c> operation. </para> <para> The following operations
    /// are related to <c>StartCodeInterpreterSession</c>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_InvokeCodeInterpreter.html">InvokeCodeInterpreter</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class StartCodeInterpreterSessionRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// A list of certificates to install in the code interpreter session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Certificate> Certificates { get; set; } = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null && (this.Certificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock AgentCore
        /// ignores the request, but does not return an error. This parameter helps prevent the
        /// creation of duplicate sessions if there are temporary network issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter to use for this session. This identifier
        /// specifies which code interpreter environment to initialize for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CodeInterpreterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CodeInterpreterIdentifier property is set.
        /// </summary>
        internal bool IsSetCodeInterpreterIdentifier() => this.CodeInterpreterIdentifier != null;

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The file system configurations to mount into the code interpreter session. Use these
        /// configurations to mount your own Amazon Simple Storage Service (Amazon S3) Files or
        /// Amazon Elastic File System (Amazon EFS) access points. Your session can then read
        /// and write your data. If you don't specify this field, no additional file systems are
        /// mounted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ToolsFileSystemConfiguration> FilesystemConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolsFileSystemConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FilesystemConfigurations property is set.
        /// </summary>
        internal bool IsSetFilesystemConfigurations() => this.FilesystemConfigurations != null && (this.FilesystemConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code interpreter session. This name helps you identify and manage
        /// the session. The name does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The duration in seconds (time-to-live) after which the session automatically terminates,
        /// regardless of ongoing activity. Defaults to 900 seconds (15 minutes). Recommended
        /// minimum: 60 seconds. Maximum allowed: 28,800 seconds (8 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 28800)]
        public int? SessionTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetSessionTimeoutSeconds() => this.SessionTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceParent { get; set; }

        /// <summary>
        /// Checks to see if the TraceParent property is set.
        /// </summary>
        internal bool IsSetTraceParent() => this.TraceParent != null;
    }
}
