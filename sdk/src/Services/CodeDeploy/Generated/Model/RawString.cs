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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// A revision for an Lambda deployment that is a YAML-formatted or JSON-formatted string.
    /// For Lambda deployments, the revision is the same as the AppSpec file.
    /// </summary>
    [Obsolete("RawString and String revision type are deprecated, use AppSpecContent type instead.")]
    public partial class RawString
    {
        private string _content;
        private string _sha256;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The YAML-formatted or JSON-formatted revision string. It includes information about
        /// which Lambda function to update and optional Lambda functions that validate deployment
        /// lifecycle events.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA256 hash value of the revision content.
        /// </para>
        /// </summary>
        public string Sha256
        {
            get { return this._sha256; }
            set { this._sha256 = value; }
        }

        // Check to see if Sha256 property is set
        internal bool IsSetSha256()
        {
            return this._sha256 != null;
        }

    }
}