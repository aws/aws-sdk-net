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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the Git submodules configuration for an AWS CodeBuild build project.
    /// </summary>
    public partial class GitSubmodulesConfig
    {
        private bool? _fetchSubmodules;

        /// <summary>
        /// Gets and sets the property FetchSubmodules. 
        /// <para>
        ///  Set to true to fetch Git submodules for your AWS CodeBuild build project. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool FetchSubmodules
        {
            get { return this._fetchSubmodules.GetValueOrDefault(); }
            set { this._fetchSubmodules = value; }
        }

        // Check to see if FetchSubmodules property is set
        internal bool IsSetFetchSubmodules()
        {
            return this._fetchSubmodules.HasValue; 
        }

    }
}