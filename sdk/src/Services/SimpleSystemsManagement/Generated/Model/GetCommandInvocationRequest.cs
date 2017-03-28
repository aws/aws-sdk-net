/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetCommandInvocation operation.
    /// Returns detailed information about command execution for an invocation or plugin.
    /// </summary>
    public partial class GetCommandInvocationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _commandId;
        private string _instanceId;
        private string _pluginName;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// (Required) The parent command ID of the invocation plugin.
        /// </para>
        /// </summary>
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// (Required) The ID of the managed instance targeted by the command. A managed instance
        /// can be an Amazon EC2 instance or an instance in your hybrid environment that is configured
        /// for Systems Manager.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PluginName. 
        /// <para>
        /// (Optional) The name of the plugin for which you want detailed results. If the document
        /// contains only one plugin, the name can be omitted and the details will be returned.
        /// </para>
        /// </summary>
        public string PluginName
        {
            get { return this._pluginName; }
            set { this._pluginName = value; }
        }

        // Check to see if PluginName property is set
        internal bool IsSetPluginName()
        {
            return this._pluginName != null;
        }

    }
}