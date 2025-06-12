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
    /// Provides the configuration information to connect to an Amazon S3 bucket.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Kendra now supports an upgraded Amazon S3 connector.
    /// </para>
    ///  
    /// <para>
    /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
    /// object instead of the <c>S3DataSourceConfiguration</c> object to configure your connector.
    /// </para>
    ///  
    /// <para>
    /// Connectors configured using the older console and API architecture will continue to
    /// function as configured. However, you won't be able to edit or update them. If you
    /// want to edit or update your connector configuration, you must create a new connector.
    /// </para>
    ///  
    /// <para>
    /// We recommended migrating your connector workflow to the upgraded version. Support
    /// for connectors configured using the older architecture is scheduled to end by June
    /// 2024.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class S3DataSourceConfiguration
    {
        private AccessControlListConfiguration _accessControlListConfiguration;
        private string _bucketName;
        private DocumentsMetadataConfiguration _documentsMetadataConfiguration;
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inclusionPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// A list of glob patterns (patterns that can expand a wildcard pattern into a list of
        /// path names that match the given pattern) for certain file names and file types to
        /// exclude from your index. If a document matches both an inclusion and exclusion prefix
        /// or pattern, the exclusion prefix takes precendence and the document is not indexed.
        /// Examples of glob patterns include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>/myapp/config/*</i>—All files inside config directory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*.png</i>—All .png files in all directories.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*.{png, ico, md}</i>—All .png, .ico or .md files in all directories.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>/myapp/src/**/*.ts</i>—All .ts files inside src directory (and all its subdirectories).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/!(*.module).ts</i>—All .ts files but not .module.ts
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>*.png , *.jpg</i>—All PNG and JPEG image files in a directory (files with the
        /// extensions .png and .jpg).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>*internal*</i>—All files in a directory that contain 'internal' in the file name,
        /// such as 'internal', 'internal_only', 'company_internal'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*internal*</i>—All internal-related files in a directory and its subdirectories.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more examples, see <a href="https://docs.aws.amazon.com/cli/latest/reference/s3/#use-of-exclude-and-include-filters">Use
        /// of Exclude and Include Filters</a> in the Amazon Web Services CLI Command Reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && (this._exclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of glob patterns (patterns that can expand a wildcard pattern into a list of
        /// path names that match the given pattern) for certain file names and file types to
        /// include in your index. If a document matches both an inclusion and exclusion prefix
        /// or pattern, the exclusion prefix takes precendence and the document is not indexed.
        /// Examples of glob patterns include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>/myapp/config/*</i>—All files inside config directory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*.png</i>—All .png files in all directories.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*.{png, ico, md}</i>—All .png, .ico or .md files in all directories.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>/myapp/src/**/*.ts</i>—All .ts files inside src directory (and all its subdirectories).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/!(*.module).ts</i>—All .ts files but not .module.ts
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>*.png , *.jpg</i>—All PNG and JPEG image files in a directory (files with the
        /// extensions .png and .jpg).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>*internal*</i>—All files in a directory that contain 'internal' in the file name,
        /// such as 'internal', 'internal_only', 'company_internal'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>**/*internal*</i>—All internal-related files in a directory and its subdirectories.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more examples, see <a href="https://docs.aws.amazon.com/cli/latest/reference/s3/#use-of-exclude-and-include-filters">Use
        /// of Exclude and Include Filters</a> in the Amazon Web Services CLI Command Reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && (this._inclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InclusionPrefixes. 
        /// <para>
        /// A list of S3 prefixes for the documents that should be included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> InclusionPrefixes
        {
            get { return this._inclusionPrefixes; }
            set { this._inclusionPrefixes = value; }
        }

        // Check to see if InclusionPrefixes property is set
        internal bool IsSetInclusionPrefixes()
        {
            return this._inclusionPrefixes != null && (this._inclusionPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}