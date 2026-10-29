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
    /// Container for the parameters to the GetCommandInvocation operation. Returns detailed
    /// information about command execution for an invocation or plugin. The Run Command API
    /// follows an eventual consistency model, due to the distributed nature of the system
    /// supporting the API. This means that the result of an API command you run that affects
    /// your resources might not be immediately visible to all subsequent commands you run.
    /// You should keep this in mind when you carry out an API command that immediately follows
    /// a previous API command. <para> <c>GetCommandInvocation</c> only gives the execution
    /// status of a plugin in a document. To get the command execution status on a specific
    /// managed node, use <a>ListCommandInvocations</a>. To get the command execution status
    /// across managed nodes, use <a>ListCommands</a>. </para>
    /// </summary>
    public partial class GetCommandInvocationRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// (Required) The parent command ID of the invocation plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// (Required) The ID of the managed node targeted by the command. A <i>managed node</i>
        /// can be an Amazon Elastic Compute Cloud (Amazon EC2) instance, edge device, and on-premises
        /// server or VM in your hybrid environment that is configured for Amazon Web Services
        /// Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PluginName. 
        /// <para>
        /// The name of the step for which you want detailed results. If the document contains
        /// only one step, you can omit the name and details for that step. If the document contains
        /// more than one step, you must specify the name of the step for which you want to view
        /// details. Be sure to specify the name of the step, not the name of a plugin like <c>aws:RunShellScript</c>.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>PluginName</c>, check the document content and find the name of the
        /// step you want details for. Alternatively, use <a>ListCommandInvocations</a> with the
        /// <c>CommandId</c> and <c>Details</c> parameters. The <c>PluginName</c> is the <c>Name</c>
        /// attribute of the <c>CommandPlugin</c> object in the <c>CommandPlugins</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4)]
        public string PluginName { get; set; }

        /// <summary>
        /// Checks to see if the PluginName property is set.
        /// </summary>
        internal bool IsSetPluginName() => this.PluginName != null;
    }
}
