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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Identifies a document for which to retrieve status information
    /// </summary>
    public partial class DocumentInfo
    {
        private List<DocumentAttribute> _attributes = new List<DocumentAttribute>();
        private string _documentId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes that identify a specific version of a document to check.
        /// </para>
        ///  
        /// <para>
        /// The only valid attributes are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// version
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// datasourceId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// jobExecutionId
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The attributes follow these rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>dataSourceId</code> and <code>jobExecutionId</code> must be used together.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code> is ignored if <code>dataSourceId</code> and <code>jobExecutionId</code>
        /// are not provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>dataSourceId</code> and <code>jobExecutionId</code> are provided, but <code>version</code>
        /// is not, the version defaults to "0".
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<DocumentAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

    }
}