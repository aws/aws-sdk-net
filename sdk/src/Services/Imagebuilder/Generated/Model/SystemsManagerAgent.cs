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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains settings for the Systems Manager agent on your build instance. This setting
    /// applies to Linux and macOS build instances only. Requests that set it for a recipe
    /// with a Windows base image are rejected.
    /// </summary>
    public partial class SystemsManagerAgent
    {
        private bool? _uninstallAfterBuild;

        /// <summary>
        /// Gets and sets the property UninstallAfterBuild. 
        /// <para>
        /// Specifies whether the Systems Manager agent is removed from your final build image
        /// before Image Builder creates the new AMI. If <c>true</c>, the agent is removed. If
        /// <c>false</c>, the agent is kept, so that it's included in the AMI. If you don't set
        /// this property, Image Builder removes the agent only if Image Builder installed the
        /// agent during the build. An agent that was pre-installed on the base image is kept.
        /// </para>
        /// </summary>
        public bool? UninstallAfterBuild
        {
            get { return this._uninstallAfterBuild; }
            set { this._uninstallAfterBuild = value; }
        }

        // Check to see if UninstallAfterBuild property is set
        internal bool IsSetUninstallAfterBuild()
        {
            return this._uninstallAfterBuild.HasValue; 
        }

    }
}