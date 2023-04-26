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
    /// Container for the parameters to the BatchPutDocument operation.
    /// Adds one or more documents to an index.
    /// 
    ///  
    /// <para>
    /// The <code>BatchPutDocument</code> API enables you to ingest inline documents or a
    /// set of documents stored in an Amazon S3 bucket. Use this API to ingest your text and
    /// unstructured text into an index, add custom attributes to the documents, and to attach
    /// an access control list to the documents added to the index.
    /// </para>
    ///  
    /// <para>
    /// The documents are indexed asynchronously. You can see the progress of the batch using
    /// Amazon Web Services CloudWatch. Any error messages related to processing the batch
    /// are sent to your Amazon Web Services CloudWatch log.
    /// </para>
    ///  
    /// <para>
    /// For an example of ingesting inline documents using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-adding-binary-doc.html">Adding
    /// files directly to an index</a>.
    /// </para>
    /// </summary>
    public partial class BatchPutDocumentRequest : AmazonKendraRequest
    {
        private CustomDocumentEnrichmentConfiguration _customDocumentEnrichmentConfiguration;
        private List<Document> _documents = new List<Document>();
        private string _indexId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CustomDocumentEnrichmentConfiguration. 
        /// <para>
        /// Configuration information for altering your document metadata and content during the
        /// document ingestion process when you use the <code>BatchPutDocument</code> API.
        /// </para>
        ///  
        /// <para>
        /// For more information on how to create, modify and delete document metadata, or make
        /// other content alterations when you ingest documents into Amazon Kendra, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html">Customizing
        /// document metadata during the ingestion process</a>.
        /// </para>
        /// </summary>
        public CustomDocumentEnrichmentConfiguration CustomDocumentEnrichmentConfiguration
        {
            get { return this._customDocumentEnrichmentConfiguration; }
            set { this._customDocumentEnrichmentConfiguration = value; }
        }

        // Check to see if CustomDocumentEnrichmentConfiguration property is set
        internal bool IsSetCustomDocumentEnrichmentConfiguration()
        {
            return this._customDocumentEnrichmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// One or more documents to add to the index.
        /// </para>
        ///  
        /// <para>
        /// Documents have the following file size limits.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 50 MB total size for any file
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5 MB extracted text for any file
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<Document> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && this._documents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index to add the documents to. You need to create the index
        /// first using the <code>CreateIndex</code> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access your S3 bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// access roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}