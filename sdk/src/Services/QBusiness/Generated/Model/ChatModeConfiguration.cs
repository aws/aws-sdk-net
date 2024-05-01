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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information for Amazon Q Business conversation modes.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/guardrails.html">Admin
    /// controls and guardrails</a> and <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/using-web-experience.html#chat-source-scope">Conversation
    /// settings</a>.
    /// </para>
    /// </summary>
    public partial class ChatModeConfiguration
    {
        private PluginConfiguration _pluginConfiguration;

        /// <summary>
        /// Gets and sets the property PluginConfiguration. 
        /// <para>
        /// Configuration information required to invoke chat in <c>PLUGIN_MODE</c>.
        /// </para>
        /// </summary>
        public PluginConfiguration PluginConfiguration
        {
            get { return this._pluginConfiguration; }
            set { this._pluginConfiguration = value; }
        }

        // Check to see if PluginConfiguration property is set
        internal bool IsSetPluginConfiguration()
        {
            return this._pluginConfiguration != null;
        }

    }
}