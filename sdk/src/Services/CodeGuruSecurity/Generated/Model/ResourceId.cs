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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// The identifier for a resource object that contains resources to scan. Specifying a
    /// codeArtifactId is required to create a scan.
    /// </summary>
    public partial class ResourceId
    {
        private string _codeArtifactId;

        /// <summary>
        /// Gets and sets the property CodeArtifactId. 
        /// <para>
        /// The identifier for the code file uploaded to the resource object. Returned by <c>CreateUploadUrl</c>
        /// when you upload resources to be scanned.
        /// </para>
        /// </summary>
        public string CodeArtifactId
        {
            get { return this._codeArtifactId; }
            set { this._codeArtifactId = value; }
        }

        // Check to see if CodeArtifactId property is set
        internal bool IsSetCodeArtifactId()
        {
            return this._codeArtifactId != null;
        }

    }
}