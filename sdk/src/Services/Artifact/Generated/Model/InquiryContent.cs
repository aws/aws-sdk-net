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
    /// Content for creating a compliance inquiry - either a single query or file content.
    /// </summary>
    public partial class InquiryContent
    {
        private InquiryFileContent _fileContent;
        private string _query;

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// File content with multiple questions.
        /// </para>
        /// </summary>
        public InquiryFileContent FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        // Check to see if FileContent property is set
        internal bool IsSetFileContent()
        {
            return this._fileContent != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// Single text query for AI-generated answer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

    }
}