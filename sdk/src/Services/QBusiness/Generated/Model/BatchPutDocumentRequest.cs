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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutDocument operation.
    /// Adds one or more documents to an Amazon Q Business index.
    /// 
    ///  
    /// <para>
    /// You use this API to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// ingest your structured and unstructured documents and documents stored in an Amazon
    /// S3 bucket into an Amazon Q Business index.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// add custom attributes to documents in an Amazon Q Business index.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// attach an access control list to the documents added to an Amazon Q Business index.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can see the progress of the deletion, and any error messages related to the process,
    /// by using CloudWatch.
    /// </para>
    /// </summary>
    public partial class BatchPutDocumentRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _dataSourceSyncId;
        private List<Document> _documents = AWSConfigs.InitializeCollections ? new List<Document>() : null;
        private string _indexId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceSyncId. 
        /// <para>
        /// The identifier of the data source sync during which the documents were added.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DataSourceSyncId
        {
            get { return this._dataSourceSyncId; }
            set { this._dataSourceSyncId = value; }
        }

        // Check to see if DataSourceSyncId property is set
        internal bool IsSetDataSourceSyncId()
        {
            return this._dataSourceSyncId != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// One or more documents to add to the index.
        /// </para>
        ///  <important> 
        /// <para>
        /// Ensure that the name of your document doesn't contain any confidential information.
        /// Amazon Q Business returns document names in chat responses and citations when relevant.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._documents != null && (this._documents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the Amazon Q Business index to add the documents to. 
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