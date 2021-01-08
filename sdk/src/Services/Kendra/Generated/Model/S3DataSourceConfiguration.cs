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
    /// Provides configuration information for a data source to index documents in an Amazon
    /// S3 bucket.
    /// </summary>
    public partial class S3DataSourceConfiguration
    {
        private AccessControlListConfiguration _accessControlListConfiguration;
        private string _bucketName;
        private DocumentsMetadataConfiguration _documentsMetadataConfiguration;
        private List<string> _exclusionPatterns = new List<string>();
        private List<string> _inclusionPatterns = new List<string>();
        private List<string> _inclusionPrefixes = new List<string>();

        /// <summary>
        /// Gets and sets the property AccessControlListConfiguration. 
        /// <para>
        /// Provides the path to the S3 bucket that contains the user context filtering files
        /// for the data source. For the format of the file, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/s3-acl.html">Access
        /// control for S3 data sources</a>.
        /// </para>
        /// </summary>
        public AccessControlListConfiguration AccessControlListConfiguration
        {
            get { return this._accessControlListConfiguration; }
            set { this._accessControlListConfiguration = value; }
        }

        // Check to see if AccessControlListConfiguration property is set
        internal bool IsSetAccessControlListConfiguration()
        {
            return this._accessControlListConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentsMetadataConfiguration.
        /// </summary>
        public DocumentsMetadataConfiguration DocumentsMetadataConfiguration
        {
            get { return this._documentsMetadataConfiguration; }
            set { this._documentsMetadataConfiguration = value; }
        }

        // Check to see if DocumentsMetadataConfiguration property is set
        internal bool IsSetDocumentsMetadataConfiguration()
        {
            return this._documentsMetadataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of glob patterns for documents that should not be indexed. If a document that
        /// matches an inclusion prefix or inclusion pattern also matches an exclusion pattern,
        /// the document is not indexed.
        /// </para>
        ///  
        /// <para>
        /// For more information about glob patterns, see <a href="https://en.wikipedia.org/wiki/Glob_(programming)">glob
        /// (programming)</a> in <i>Wikipedia</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && this._exclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of glob patterns for documents that should be indexed. If a document that matches
        /// an inclusion pattern also matches an exclusion pattern, the document is not indexed.
        /// </para>
        ///  
        /// <para>
        /// For more information about glob patterns, see <a href="https://en.wikipedia.org/wiki/Glob_(programming)">glob
        /// (programming)</a> in <i>Wikipedia</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && this._inclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPrefixes. 
        /// <para>
        /// A list of S3 prefixes for the documents that should be included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InclusionPrefixes
        {
            get { return this._inclusionPrefixes; }
            set { this._inclusionPrefixes = value; }
        }

        // Check to see if InclusionPrefixes property is set
        internal bool IsSetInclusionPrefixes()
        {
            return this._inclusionPrefixes != null && this._inclusionPrefixes.Count > 0; 
        }

    }
}