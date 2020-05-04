/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The <code>BatchPutDocument</code> operation enables you to ingest inline documents
    /// or a set of documents stored in an Amazon S3 bucket. Use this operation to ingest
    /// your text and unstructured text into an index, add custom attributes to the documents,
    /// and to attach an access control list to the documents added to the index.
    /// </para>
    ///  
    /// <para>
    /// The documents are indexed asynchronously. You can see the progress of the batch using
    /// AWS CloudWatch. Any error messages related to processing the batch are sent to your
    /// AWS CloudWatch log.
    /// </para>
    /// </summary>
    public partial class BatchPutDocumentRequest : AmazonKendraRequest
    {
        private List<Document> _documents = new List<Document>();
        private string _indexId;
        private string _roleArn;

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
        /// 5 MB total size for inline documents
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 50 MB total size for files from an S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5 MB extracted text for any file
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about file size and transaction per second quotas, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>.
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
        /// first using the <a>CreateIndex</a> operation.
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
        /// The Amazon Resource Name (ARN) of a role that is allowed to run the <code>BatchPutDocument</code>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// Roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
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