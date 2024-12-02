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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about content defined inline in bytes.
    /// </summary>
    public partial class ByteContentDoc
    {
        private MemoryStream _data;
        private string _mimeType;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The base64-encoded string of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=5242880)]
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the content. For a list of MIME types, see <a href="https://www.iana.org/assignments/media-types/media-types.xhtml">Media
        /// Types</a>. The following MIME types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// text/plain
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/html
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/csv
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/vtt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// message/rfc822
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/xhtml+xml
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/pdf
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/msword
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-word.document.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-word.template.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-excel
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-excel.addin.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-excel.sheet.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-excel.template.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-excel.sheet.binary.macroenabled.12
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.ms-spreadsheetml
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.openxmlformats-officedocument.spreadsheetml.template
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.openxmlformats-officedocument.wordprocessingml.document
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.openxmlformats-officedocument.wordprocessingml.template
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MimeType
        {
            get { return this._mimeType; }
            set { this._mimeType = value; }
        }

        // Check to see if MimeType property is set
        internal bool IsSetMimeType()
        {
            return this._mimeType != null;
        }

    }
}