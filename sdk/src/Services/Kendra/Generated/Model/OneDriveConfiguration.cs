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
    /// Provides the configuration information to connect to OneDrive as your data source.
    /// </summary>
    public partial class OneDriveConfiguration
    {
        private bool? _disableLocalGroups;
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OneDriveUsers _oneDriveUsers;
        private string _secretArn;
        private string _tenantDomain;

        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        ///  <c>TRUE</c> to disable local groups information.
        /// </para>
        /// </summary>
        public bool? DisableLocalGroups
        {
            get { return this._disableLocalGroups; }
            set { this._disableLocalGroups = value; }
        }

        // Check to see if DisableLocalGroups property is set
        internal bool IsSetDisableLocalGroups()
        {
            return this._disableLocalGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain documents in your OneDrive.
        /// Documents that match the patterns are excluded from the index. Documents that don't
        /// match the patterns are included in the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The pattern is applied to the file name.
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
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map OneDrive data source
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to OneDrive fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The OneDrive data source field names must exist in your OneDrive
        /// custom metadata.
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
        /// A list of regular expression patterns to include certain documents in your OneDrive.
        /// Documents that match the patterns are included in the index. Documents that don't
        /// match the patterns are excluded from the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The pattern is applied to the file name.
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
        /// Gets and sets the property OneDriveUsers. 
        /// <para>
        /// A list of user accounts whose documents should be indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OneDriveUsers OneDriveUsers
        {
            get { return this._oneDriveUsers; }
            set { this._oneDriveUsers = value; }
        }

        // Check to see if OneDriveUsers property is set
        internal bool IsSetOneDriveUsers()
        {
            return this._oneDriveUsers != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Managersecret that contains the user
        /// name and password to connect to OneDrive. The user name should be the application
        /// ID for the OneDrive application, and the password is the application key for the OneDrive
        /// application.
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

        /// <summary>
        /// Gets and sets the property TenantDomain. 
        /// <para>
        /// The Azure Active Directory domain of the organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TenantDomain
        {
            get { return this._tenantDomain; }
            set { this._tenantDomain = value; }
        }

        // Check to see if TenantDomain property is set
        internal bool IsSetTenantDomain()
        {
            return this._tenantDomain != null;
        }

    }
}