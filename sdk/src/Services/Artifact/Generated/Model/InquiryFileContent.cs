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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// File content structure for compliance inquiry uploads.
    /// </summary>
    public partial class InquiryFileContent
    {
        private MemoryStream _content;
        private List<string> _fileSections = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Binary content of the uploaded file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream Content
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
        /// Gets and sets the property FileSections. 
        /// <para>
        /// List of file sections/sheets to process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<string> FileSections
        {
            get { return this._fileSections; }
            set { this._fileSections = value; }
        }

        // Check to see if FileSections property is set
        internal bool IsSetFileSections()
        {
            return this._fileSections != null && (this._fileSections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}