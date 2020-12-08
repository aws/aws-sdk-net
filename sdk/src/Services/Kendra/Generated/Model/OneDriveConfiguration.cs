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
    /// Provides configuration information for data sources that connect to OneDrive.
    /// </summary>
    public partial class OneDriveConfiguration
    {
        private bool? _disableLocalGroups;
        private List<string> _exclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionPatterns = new List<string>();
        private OneDriveUsers _oneDriveUsers;
        private string _secretArn;
        private string _tenantDomain;

        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        /// A Boolean value that specifies whether local groups are disabled (<code>True</code>)
        /// or enabled (<code>False</code>). 
        /// </para>
        /// </summary>
        public bool DisableLocalGroups
        {
            get { return this._disableLocalGroups.GetValueOrDefault(); }
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
        /// List of regular expressions applied to documents. Items that match the exclusion pattern
        /// are not indexed. If you provide both an inclusion pattern and an exclusion pattern,
        /// any item that matches the exclusion pattern isn't indexed. 
        /// </para>
        ///  
        /// <para>
        /// The exclusion pattern is applied to the file name.
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
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map Microsoft OneDrive
        /// fields to custom fields in the Amazon Kendra index. You must first create the index
        /// fields before you map OneDrive fields.
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
        /// A list of regular expression patterns. Documents that match the pattern are included
        /// in the index. Documents that don't match the pattern are excluded from the index.
        /// If a document matches both an inclusion pattern and an exclusion pattern, the document
        /// is not included in the index. 
        /// </para>
        ///  
        /// <para>
        /// The exclusion pattern is applied to the file name.
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
        /// The Amazon Resource Name (ARN) of an AWS Secrets Manager secret that contains the
        /// user name and password to connect to OneDrive. The user namd should be the application
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