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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Content for an asset, either a single file or a zip bundle
    /// </summary>
    public partial class AssetContent
    {
        private AssetFileContent _file;
        private AssetZipContent _zip;

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// A single file with path and content
        /// </para>
        /// </summary>
        public AssetFileContent File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property Zip. 
        /// <para>
        /// A zip file containing multiple files
        /// </para>
        /// </summary>
        public AssetZipContent Zip
        {
            get { return this._zip; }
            set { this._zip = value; }
        }

        // Check to see if Zip property is set
        internal bool IsSetZip()
        {
            return this._zip != null;
        }

    }
}