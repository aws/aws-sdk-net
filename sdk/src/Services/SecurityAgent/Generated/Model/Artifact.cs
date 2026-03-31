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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Files containing relevant data for review
    /// </summary>
    public partial class Artifact
    {
        private string _contents;
        private ArtifactType _type;

        /// <summary>
        /// Gets and sets the property Contents. 
        /// <para>
        /// The content of the artifact
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Contents
        {
            get { return this._contents; }
            set { this._contents = value; }
        }

        // Check to see if Contents property is set
        internal bool IsSetContents()
        {
            return this._contents != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The file type of the artifact
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}