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
    /// This is the response object from the GetCodeInterpreterSession operation.
    /// </summary>
    public partial class GetCodeInterpreterSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The list of certificates installed in the code interpreter session.
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
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The identifier of the code interpreter.
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
        /// The time at which the code interpreter session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The file system configurations for the code interpreter session. Each entry describes
        /// an access point and its mount path.
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
        /// The name of the code interpreter session.
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
        /// The identifier of the code interpreter session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The timeout period for the code interpreter session in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 28800)]
        public int? SessionTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetSessionTimeoutSeconds() => this.SessionTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code interpreter session. Possible values include ACTIVE,
        /// STOPPING, and STOPPED.
        /// </para>
        /// </summary>
        public CodeInterpreterSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
