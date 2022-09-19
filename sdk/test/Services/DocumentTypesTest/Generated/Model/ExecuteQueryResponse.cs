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
 * Do not modify this file. This file is generated from the document-types-test-2022-09-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocumentTypesTest.Model
{
    /// <summary>
    /// This is the response object from the ExecuteQuery operation.
    /// </summary>
    public partial class ExecuteQueryResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _queryDocument;
        private List<Amazon.Runtime.Documents.Document> _queryList = new List<Amazon.Runtime.Documents.Document>();
        private List<Dictionary<string, Amazon.Runtime.Documents.Document>> _queryListOfMap = new List<Dictionary<string, Amazon.Runtime.Documents.Document>>();
        private Dictionary<string, Amazon.Runtime.Documents.Document> _queryMap = new Dictionary<string, Amazon.Runtime.Documents.Document>();

        /// <summary>
        /// Gets and sets the property QueryDocument.
        /// </summary>
        public Amazon.Runtime.Documents.Document QueryDocument
        {
            get { return this._queryDocument; }
            set { this._queryDocument = value; }
        }

        // Check to see if QueryDocument property is set
        internal bool IsSetQueryDocument()
        {
            return !this._queryDocument.IsNull();
        }

        /// <summary>
        /// Gets and sets the property QueryList.
        /// </summary>
        public List<Amazon.Runtime.Documents.Document> QueryList
        {
            get { return this._queryList; }
            set { this._queryList = value; }
        }

        // Check to see if QueryList property is set
        internal bool IsSetQueryList()
        {
            return this._queryList != null && this._queryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryListOfMap.
        /// </summary>
        public List<Dictionary<string, Amazon.Runtime.Documents.Document>> QueryListOfMap
        {
            get { return this._queryListOfMap; }
            set { this._queryListOfMap = value; }
        }

        // Check to see if QueryListOfMap property is set
        internal bool IsSetQueryListOfMap()
        {
            return this._queryListOfMap != null && this._queryListOfMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryMap.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> QueryMap
        {
            get { return this._queryMap; }
            set { this._queryMap = value; }
        }

        // Check to see if QueryMap property is set
        internal bool IsSetQueryMap()
        {
            return this._queryMap != null && this._queryMap.Count > 0; 
        }

    }
}