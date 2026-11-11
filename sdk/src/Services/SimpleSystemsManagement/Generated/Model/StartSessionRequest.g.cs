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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StartSession operation. Initiates a connection
    /// to a target (for example, a managed node) for a Session Manager session. Returns a
    /// URL and token that can be used to open a WebSocket connection for sending input and
    /// receiving outputs. <note> <para> Amazon Web Services CLI usage: <c>start-session</c>
    /// is an interactive command that requires the Session Manager plugin to be installed
    /// on the client machine making the call. For information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Install
    /// the Session Manager plugin for the Amazon Web Services CLI</a> in the <i>Amazon Web
    /// Services Systems Manager User Guide</i>. </para> <para> Amazon Web Services Tools
    /// for PowerShell usage: Start-SSMSession isn't currently supported by Amazon Web Services
    /// Tools for PowerShell on Windows local machines. </para> </note>
    /// </summary>
    public partial class StartSessionRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the SSM document you want to use to define the type of session, input
        /// parameters, or preferences for the session. For example, <c>SSM-SessionManagerRunShell</c>.
        /// You can call the <a>GetDocument</a> API to verify the document exists before attempting
        /// to start a session. If no document name is provided, a shell to the managed node is
        /// launched by default. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-sessions-start.html">Start
        /// a session</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The values you want to specify for the parameters defined in the Session document.
        /// For more information about these parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/getting-started-create-preferences-cli.html">Create
        /// a Session Manager preferences document</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for connecting to the instance. This value is included in the details for
        /// the Amazon CloudWatch Events event created when you start the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The managed node to connect to for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 400)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
