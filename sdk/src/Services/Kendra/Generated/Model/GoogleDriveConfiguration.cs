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
    /// Provides configuration information for data sources that connect to Google Drive.
    /// </summary>
    public partial class GoogleDriveConfiguration
    {
        private List<string> _excludeMimeTypes = new List<string>();
        private List<string> _excludeSharedDrives = new List<string>();
        private List<string> _excludeUserAccounts = new List<string>();
        private List<string> _exclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionPatterns = new List<string>();
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property ExcludeMimeTypes. 
        /// <para>
        /// A list of MIME types to exclude from the index. All documents matching the specified
        /// MIME type are excluded. 
        /// </para>
        ///  
        /// <para>
        /// For a list of MIME types, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-google-drive.html">Using
        /// a Google Workspace Drive data source</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<string> ExcludeMimeTypes
        {
            get { return this._excludeMimeTypes; }
            set { this._excludeMimeTypes = value; }
        }

        // Check to see if ExcludeMimeTypes property is set
        internal bool IsSetExcludeMimeTypes()
        {
            return this._excludeMimeTypes != null && this._excludeMimeTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeSharedDrives. 
        /// <para>
        /// A list of identifiers or shared drives to exclude from the index. All files and folders
        /// stored on the shared drive are excluded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExcludeSharedDrives
        {
            get { return this._excludeSharedDrives; }
            set { this._excludeSharedDrives = value; }
        }

        // Check to see if ExcludeSharedDrives property is set
        internal bool IsSetExcludeSharedDrives()
        {
            return this._excludeSharedDrives != null && this._excludeSharedDrives.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeUserAccounts. 
        /// <para>
        /// A list of email addresses of the users. Documents owned by these users are excluded
        /// from the index. Documents shared with excluded users are indexed unless they are excluded
        /// in another way.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExcludeUserAccounts
        {
            get { return this._excludeUserAccounts; }
            set { this._excludeUserAccounts = value; }
        }

        // Check to see if ExcludeUserAccounts property is set
        internal bool IsSetExcludeUserAccounts()
        {
            return this._excludeUserAccounts != null && this._excludeUserAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns that apply to the path on Google Drive. Items
        /// that match the pattern are excluded from the index from both shared drives and users'
        /// My Drives. Items that don't match the pattern are included in the index. If an item
        /// matches both an exclusion pattern and an inclusion pattern, it is excluded from the
        /// index.
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
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Defines mapping between a field in the Google Drive and a Amazon Kendra index field.
        /// </para>
        ///  
        /// <para>
        /// If you are using the console, you can define index fields when creating the mapping.
        /// If you are using the API, you must first create the field using the <a>UpdateIndex</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns that apply to path on Google Drive. Items that
        /// match the pattern are included in the index from both shared drives and users' My
        /// Drives. Items that don't match the pattern are excluded from the index. If an item
        /// matches both an inclusion pattern and an exclusion pattern, it is excluded from the
        /// index.
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a AWS Secrets Manager secret that contains the credentials
        /// required to connect to Google Drive. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-google-drive.html">Using
        /// a Google Workspace Drive data source</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}