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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the ExportNotebook operation.
    /// </summary>
    public partial class ExportNotebookResponse : AmazonWebServiceResponse
    {
        private NotebookMetadata _notebookMetadata;
        private string _payload;

        /// <summary>
        /// Gets and sets the property NotebookMetadata. 
        /// <para>
        /// The notebook metadata, including notebook ID, notebook name, and workgroup name.
        /// </para>
        /// </summary>
        public NotebookMetadata NotebookMetadata
        {
            get { return this._notebookMetadata; }
            set { this._notebookMetadata = value; }
        }

        // Check to see if NotebookMetadata property is set
        internal bool IsSetNotebookMetadata()
        {
            return this._notebookMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The content of the exported notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15728640)]
        public string Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

    }
}