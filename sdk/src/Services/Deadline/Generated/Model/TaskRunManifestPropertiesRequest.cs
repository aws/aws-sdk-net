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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The output manifest properties reported by the worker agent for a completed task run.
    /// </summary>
    public partial class TaskRunManifestPropertiesRequest
    {
        private string _outputManifestHash;
        private string _outputManifestPath;

        /// <summary>
        /// Gets and sets the property OutputManifestHash. 
        /// <para>
        /// The hash value of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OutputManifestHash
        {
            get { return this._outputManifestHash; }
            set { this._outputManifestHash = value; }
        }

        // Check to see if OutputManifestHash property is set
        internal bool IsSetOutputManifestHash()
        {
            return this._outputManifestHash != null;
        }

        /// <summary>
        /// Gets and sets the property OutputManifestPath. 
        /// <para>
        /// The manifest file path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string OutputManifestPath
        {
            get { return this._outputManifestPath; }
            set { this._outputManifestPath = value; }
        }

        // Check to see if OutputManifestPath property is set
        internal bool IsSetOutputManifestPath()
        {
            return this._outputManifestPath != null;
        }

    }
}