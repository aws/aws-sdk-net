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
    /// This is the response object from the CreatePlugin operation.
    /// </summary>
    public partial class CreatePluginResponse : AmazonWebServiceResponse
    {
        private PluginBuildStatus _buildStatus;
        private string _pluginArn;
        private string _pluginId;

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The current status of a plugin. A plugin is modified asynchronously.
        /// </para>
        /// </summary>
        public PluginBuildStatus BuildStatus
        {
            get { return this._buildStatus; }
            set { this._buildStatus = value; }
        }

        // Check to see if BuildStatus property is set
        internal bool IsSetBuildStatus()
        {
            return this._buildStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string PluginArn
        {
            get { return this._pluginArn; }
            set { this._pluginArn = value; }
        }

        // Check to see if PluginArn property is set
        internal bool IsSetPluginArn()
        {
            return this._pluginArn != null;
        }

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PluginId
        {
            get { return this._pluginId; }
            set { this._pluginId = value; }
        }

        // Check to see if PluginId property is set
        internal bool IsSetPluginId()
        {
            return this._pluginId != null;
        }

    }
}