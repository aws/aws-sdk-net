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
    /// Provides the configuration information to connect to Google Drive as your data source.
    /// </summary>
    public partial class GoogleDriveConfiguration
    {
        private List<string> _excludeMimeTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeSharedDrives = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeUserAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludeMimeTypes != null && (this._excludeMimeTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeSharedDrives. 
        /// <para>
        /// A list of identifiers or shared drives to exclude from the index. All files and folders
        /// stored on the shared drive are excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludeSharedDrives != null && (this._excludeSharedDrives.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeUserAccounts. 
        /// <para>
        /// A list of email addresses of the users. Documents owned by these users are excluded
        /// from the index. Documents shared with excluded users are indexed unless they are excluded
        /// in another way.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludeUserAccounts != null && (this._excludeUserAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain items in your Google Drive,
        /// including shared drives and users' My Drives. Items that match the patterns are excluded
        /// from the index. Items that don't match the patterns are included in the index. If
        /// an item matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the item isn't included in the index.
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
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Maps Google Drive data source attributes or field names to Amazon Kendra index field
        /// names. To create custom fields, use the <c>UpdateIndex</c> API before you map to Google
        /// Drive fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Google Drive data source field names must exist in your
        /// Google Drive custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._fieldMappings != null && (this._fieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain items in your Google Drive,
        /// including shared drives and users' My Drives. Items that match the patterns are included
        /// in the index. Items that don't match the patterns are excluded from the index. If
        /// an item matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the item isn't included in the index.
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Secrets Managersecret that contains the credentials
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