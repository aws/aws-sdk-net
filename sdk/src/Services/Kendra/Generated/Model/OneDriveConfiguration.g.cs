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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        ///  <c>TRUE</c> to disable local groups information.
        /// </para>
        /// </summary>
        public bool? DisableLocalGroups { get; set; }

        /// <summary>
        /// Checks to see if the DisableLocalGroups property is set.
        /// </summary>
        internal bool IsSetDisableLocalGroups() => this.DisableLocalGroups.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> ExclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionPatterns property is set.
        /// </summary>
        internal bool IsSetExclusionPatterns() => this.ExclusionPatterns != null && (this.ExclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the FieldMappings property is set.
        /// </summary>
        internal bool IsSetFieldMappings() => this.FieldMappings != null && (this.FieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> InclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionPatterns property is set.
        /// </summary>
        internal bool IsSetInclusionPatterns() => this.InclusionPatterns != null && (this.InclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OneDriveUsers. 
        /// <para>
        /// A list of user accounts whose documents should be indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OneDriveUsers OneDriveUsers { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveUsers property is set.
        /// </summary>
        internal bool IsSetOneDriveUsers() => this.OneDriveUsers != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Managersecret that contains the user
        /// name and password to connect to OneDrive. The user name should be the application
        /// ID for the OneDrive application, and the password is the application key for the OneDrive
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property TenantDomain. 
        /// <para>
        /// The Azure Active Directory domain of the organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TenantDomain { get; set; }

        /// <summary>
        /// Checks to see if the TenantDomain property is set.
        /// </summary>
        internal bool IsSetTenantDomain() => this.TenantDomain != null;
    }
}
