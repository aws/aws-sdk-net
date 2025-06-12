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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMigrationProject operation.
    /// Creates the migration project using the specified parameters.
    /// 
    ///  
    /// <para>
    /// You can run this action only after you create an instance profile and data providers
    /// using <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateInstanceProfile.html">CreateInstanceProfile</a>
    /// and <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateDataProvider.html">CreateDataProvider</a>.
    /// </para>
    /// </summary>
    public partial class CreateMigrationProjectRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _description;
        private string _instanceProfileIdentifier;
        private string _migrationProjectName;
        private SCApplicationAttributes _schemaConversionApplicationAttributes;
        private List<DataProviderDescriptorDefinition> _sourceDataProviderDescriptors = AWSConfigs.InitializeCollections ? new List<DataProviderDescriptorDefinition>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<DataProviderDescriptorDefinition> _targetDataProviderDescriptors = AWSConfigs.InitializeCollections ? new List<DataProviderDescriptorDefinition>() : null;
        private string _transformationRules;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the migration project.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileIdentifier. 
        /// <para>
        /// The identifier of the associated instance profile. Identifiers must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens. They can't end with a hyphen,
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceProfileIdentifier
        {
            get { return this._instanceProfileIdentifier; }
            set { this._instanceProfileIdentifier = value; }
        }

        // Check to see if InstanceProfileIdentifier property is set
        internal bool IsSetInstanceProfileIdentifier()
        {
            return this._instanceProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationProjectName. 
        /// <para>
        /// A user-friendly name for the migration project.
        /// </para>
        /// </summary>
        public string MigrationProjectName
        {
            get { return this._migrationProjectName; }
            set { this._migrationProjectName = value; }
        }

        // Check to see if MigrationProjectName property is set
        internal bool IsSetMigrationProjectName()
        {
            return this._migrationProjectName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaConversionApplicationAttributes. 
        /// <para>
        /// The schema conversion application attributes, including the Amazon S3 bucket name
        /// and Amazon S3 role ARN.
        /// </para>
        /// </summary>
        public SCApplicationAttributes SchemaConversionApplicationAttributes
        {
            get { return this._schemaConversionApplicationAttributes; }
            set { this._schemaConversionApplicationAttributes = value; }
        }

        // Check to see if SchemaConversionApplicationAttributes property is set
        internal bool IsSetSchemaConversionApplicationAttributes()
        {
            return this._schemaConversionApplicationAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataProviderDescriptors. 
        /// <para>
        /// Information about the source data provider, including the name, ARN, and Secrets Manager
        /// parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataProviderDescriptorDefinition> SourceDataProviderDescriptors
        {
            get { return this._sourceDataProviderDescriptors; }
            set { this._sourceDataProviderDescriptors = value; }
        }

        // Check to see if SourceDataProviderDescriptors property is set
        internal bool IsSetSourceDataProviderDescriptors()
        {
            return this._sourceDataProviderDescriptors != null && (this._sourceDataProviderDescriptors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the migration project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetDataProviderDescriptors. 
        /// <para>
        /// Information about the target data provider, including the name, ARN, and Amazon Web
        /// Services Secrets Manager parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataProviderDescriptorDefinition> TargetDataProviderDescriptors
        {
            get { return this._targetDataProviderDescriptors; }
            set { this._targetDataProviderDescriptors = value; }
        }

        // Check to see if TargetDataProviderDescriptors property is set
        internal bool IsSetTargetDataProviderDescriptors()
        {
            return this._targetDataProviderDescriptors != null && (this._targetDataProviderDescriptors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransformationRules. 
        /// <para>
        /// The settings in JSON format for migration rules. Migration rules make it possible
        /// for you to change the object names according to the rules that you specify. For example,
        /// you can change an object name to lowercase or uppercase, add or remove a prefix or
        /// suffix, or rename objects.
        /// </para>
        /// </summary>
        public string TransformationRules
        {
            get { return this._transformationRules; }
            set { this._transformationRules = value; }
        }

        // Check to see if TransformationRules property is set
        internal bool IsSetTransformationRules()
        {
            return this._transformationRules != null;
        }

    }
}