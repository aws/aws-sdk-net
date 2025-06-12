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
    /// Provides the configuration information to connect to Amazon FSx as your data source.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Kendra now supports an upgraded Amazon FSx Windows connector.
    /// </para>
    ///  
    /// <para>
    /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
    /// object instead of the <c>FsxConfiguration</c> object to configure your connector.
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
    public partial class FsxConfiguration
    {
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private string _fileSystemId;
        private FsxFileSystemType _fileSystemType;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _secretArn;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files in your Amazon FSx
        /// file system. Files that match the patterns are excluded from the index. Files that
        /// don't match the patterns are included in the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
        /// in the index.
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
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map Amazon FSx data source
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Amazon FSx fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Amazon FSx data source field names must exist in your
        /// Amazon FSx custom metadata.
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
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The identifier of the Amazon FSx file system.
        /// </para>
        ///  
        /// <para>
        /// You can find your file system ID on the file system dashboard in the Amazon FSx console.
        /// For information on how to create a file system in Amazon FSx console, using Windows
        /// File Server as an example, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/getting-started-step1.html">Amazon
        /// FSx Getting started guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// The Amazon FSx file system type. Windows is currently the only supported type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FsxFileSystemType FileSystemType
        {
            get { return this._fileSystemType; }
            set { this._fileSystemType = value; }
        }

        // Check to see if FileSystemType property is set
        internal bool IsSetFileSystemType()
        {
            return this._fileSystemType != null;
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files in your Amazon FSx
        /// file system. Files that match the patterns are included in the index. Files that don't
        /// match the patterns are excluded from the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
        /// in the index.
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
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the key-value
        /// pairs required to connect to your Amazon FSx file system. Windows is currently the
        /// only supported type. The secret must contain a JSON structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// username—The Active Directory user name, along with the Domain Name System (DNS) domain
        /// name. For example, <i>user@corp.example.com</i>. The Active Directory user account
        /// must have read and mounting access to the Amazon FSx file system for Windows.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// password—The password of the Active Directory user account with read and mounting
        /// access to the Amazon FSx Windows file system.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
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

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Amazon
        /// FSx. Your Amazon FSx instance must reside inside your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}