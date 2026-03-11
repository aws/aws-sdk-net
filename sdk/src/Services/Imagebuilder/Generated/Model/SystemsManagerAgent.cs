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
    /// Contains settings for the Systems Manager agent on your build instance.
    /// </summary>
    public partial class SystemsManagerAgent
    {
        private bool? _uninstallAfterBuild;

        /// <summary>
        /// Gets and sets the property UninstallAfterBuild. 
        /// <para>
        /// Controls whether the Systems Manager agent is removed from your final build image,
        /// prior to creating the new AMI. If this is set to true, then the agent is removed from
        /// the final image. If it's set to false, then the agent is left in, so that it is included
        /// in the new AMI. default value is false.
        /// </para>
        ///  
        /// <para>
        /// The default behavior of uninstallAfterBuild is to remove the SSM Agent if it was installed
        /// by EC2 Image Builder
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