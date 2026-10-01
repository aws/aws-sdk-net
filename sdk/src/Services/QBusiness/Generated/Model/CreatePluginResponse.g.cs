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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the CreatePlugin operation.
    /// </summary>
    public partial class CreatePluginResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The current status of a plugin. A plugin is modified asynchronously.
        /// </para>
        /// </summary>
        public PluginBuildStatus BuildStatus { get; set; }

        /// <summary>
        /// Checks to see if the BuildStatus property is set.
        /// </summary>
        internal bool IsSetBuildStatus() => this.BuildStatus != null;

        /// <summary>
        /// Gets and sets the property PluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string PluginArn { get; set; }

        /// <summary>
        /// Checks to see if the PluginArn property is set.
        /// </summary>
        internal bool IsSetPluginArn() => this.PluginArn != null;

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PluginId { get; set; }

        /// <summary>
        /// Checks to see if the PluginId property is set.
        /// </summary>
        internal bool IsSetPluginId() => this.PluginId != null;
    }
}
