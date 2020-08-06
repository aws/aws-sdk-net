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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System.Globalization;

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Container for the parameters to the UploadDocuments operation.
    /// Posts a batch of documents to a search domain for indexing.  A document batch is a
    /// collection of add and delete operations that represent the documents you want to add,
    /// update, or delete from your domain. Batches can be described in either JSON or XML.
    /// Each item that you want Amazon CloudSearch to return as a search result (such as a
    /// product) is represented as a document. Every document has a unique ID and one or more
    /// fields that contain the data that you want to search and return in results. Individual
    /// documents  cannot contain more than 1 MB of data. The entire batch cannot exceed 5
    /// MB. To get the best possible upload performance, group add and delete operations in
    /// batches that are close the 5 MB limit. Submitting a large volume of single-document
    /// batches can overload a domain's document service.  
    /// 
    ///       
    /// <para>
    /// The endpoint for submitting <code>UploadDocuments</code> requests is domain-specific.
    /// To get the document endpoint for your domain, use the Amazon CloudSearch configuration
    /// service <code>DescribeDomains</code> action. A domain's endpoints are also displayed
    /// on the domain dashboard in the Amazon CloudSearch console. 
    /// </para>
    ///       
    /// <para>
    /// For more information about formatting your data for Amazon CloudSearch, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/preparing-data.html">Preparing
    /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>.       For more information
    /// about uploading data for indexing, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/uploading-data.html">Uploading
    /// Data</a> in the <i>Amazon CloudSearch Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UploadDocumentsRequest
    {

        private string filePath;

        /// <summary>
        /// <para>
        /// The full path and name to a file that contains a batch of documents to be uploaded.
        /// The batch of documents should be formatted in JSON or HTML.        
        /// If this property is set, the UploadDocumentsRequest.Documents property is ignored.
        /// </para>
        /// <para>
        /// For WinRT and Windows Phone this property must be in the form of "ms-appdata:///local/file.txt".
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        internal void SetupForFilePath()
        {
            this.Documents = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        }
    }
}
