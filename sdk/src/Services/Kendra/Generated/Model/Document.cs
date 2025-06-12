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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A document in an index.
    /// </summary>
    public partial class Document
    {
        private string _accessControlConfigurationId;
        private List<Principal> _accessControlList = AWSConfigs.InitializeCollections ? new List<Principal>() : null;
        private List<DocumentAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<DocumentAttribute>() : null;
        private MemoryStream _blob;
        private ContentType _contentType;
        private List<HierarchicalPrincipal> _hierarchicalAccessControlList = AWSConfigs.InitializeCollections ? new List<HierarchicalPrincipal>() : null;
        private string _id;
        private S3Path _s3Path;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccessControlConfigurationId. 
        /// <para>
        /// The identifier of the access control configuration that you want to apply to the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string AccessControlConfigurationId
        {
            get { return this._accessControlConfigurationId; }
            set { this._accessControlConfigurationId = value; }
        }

        // Check to see if AccessControlConfigurationId property is set
        internal bool IsSetAccessControlConfigurationId()
        {
            return this._accessControlConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// Information on principals (users and/or groups) and which documents they should have
        /// access to. This is useful for user context filtering, where search results are filtered
        /// based on the user or their group access to documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Principal> AccessControlList
        {
            get { return this._accessControlList; }
            set { this._accessControlList = value; }
        }

        // Check to see if AccessControlList property is set
        internal bool IsSetAccessControlList()
        {
            return this._accessControlList != null && (this._accessControlList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Custom attributes to apply to the document. Use the custom attributes to provide additional
        /// information for searching, to provide facets for refining searches, and to provide
        /// additional information in the query response.
        /// </para>
        ///  
        /// <para>
        /// For example, 'DataSourceId' and 'DataSourceSyncJobId' are custom attributes that provide
        /// information on the synchronization of documents running on a data source. Note, 'DataSourceSyncJobId'
        /// could be an optional custom attribute as Amazon Kendra will use the ID of a running
        /// sync job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// The contents of the document. 
        /// </para>
        ///  
        /// <para>
        /// Documents passed to the <c>Blob</c> parameter must be base64 encoded. Your code might
        /// not need to encode the document file bytes if you're using an Amazon Web Services
        /// SDK to call Amazon Kendra APIs. If you are calling the Amazon Kendra endpoint directly
        /// using REST, you must base64 encode the contents before sending.
        /// </para>
        /// </summary>
        public MemoryStream Blob
        {
            get { return this._blob; }
            set { this._blob = value; }
        }

        // Check to see if Blob property is set
        internal bool IsSetBlob()
        {
            return this._blob != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The file type of the document in the <c>Blob</c> field.
        /// </para>
        ///  
        /// <para>
        /// If you want to index snippets or subsets of HTML documents instead of the entirety
        /// of the HTML documents, you must add the <c>HTML</c> start and closing tags (<c>&lt;HTML&gt;content&lt;/HTML&gt;</c>)
        /// around the content.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchicalAccessControlList. 
        /// <para>
        /// The list of <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Principal.html">principal</a>
        /// lists that define the hierarchy for which documents users should have access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<HierarchicalPrincipal> HierarchicalAccessControlList
        {
            get { return this._hierarchicalAccessControlList; }
            set { this._hierarchicalAccessControlList = value; }
        }

        // Check to see if HierarchicalAccessControlList property is set
        internal bool IsSetHierarchicalAccessControlList()
        {
            return this._hierarchicalAccessControlList != null && (this._hierarchicalAccessControlList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A identifier of the document in the index.
        /// </para>
        ///  
        /// <para>
        /// Note, each document ID must be unique per index. You cannot create a data source to
        /// index your documents with their unique IDs and then use the <c>BatchPutDocument</c>
        /// API to index the same documents, or vice versa. You can delete a data source and then
        /// use the <c>BatchPutDocument</c> API to index the same documents, or vice versa.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property S3Path.
        /// </summary>
        public S3Path S3Path
        {
            get { return this._s3Path; }
            set { this._s3Path = value; }
        }

        // Check to see if S3Path property is set
        internal bool IsSetS3Path()
        {
            return this._s3Path != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the document.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}