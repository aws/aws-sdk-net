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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyMigrationProject operation. Modifies the
    /// specified migration project using the provided parameters. <para> <b>Required permissions:</b>
    /// <c>dms:UpdateMigrationProject</c>. For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>. </para> <note> <para>
    /// The migration project must be closed before you can modify it. </para> </note>
    /// </summary>
    public partial class ModifyMigrationProjectRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the migration project.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileIdentifier property is set.
        /// </summary>
        internal bool IsSetInstanceProfileIdentifier() => this.InstanceProfileIdentifier != null;

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// The identifier of the migration project. Identifiers must begin with a letter and
        /// must contain only ASCII letters, digits, and hyphens. They can't end with a hyphen,
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MigrationProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetMigrationProjectIdentifier() => this.MigrationProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property MigrationProjectName. 
        /// <para>
        /// A user-friendly name for the migration project.
        /// </para>
        /// </summary>
        public string MigrationProjectName { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectName property is set.
        /// </summary>
        internal bool IsSetMigrationProjectName() => this.MigrationProjectName != null;

        /// <summary>
        /// Gets and sets the property SchemaConversionApplicationAttributes. 
        /// <para>
        /// The schema conversion application attributes, including the Amazon S3 bucket name
        /// and Amazon S3 role ARN.
        /// </para>
        /// </summary>
        public SCApplicationAttributes SchemaConversionApplicationAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SchemaConversionApplicationAttributes property is set.
        /// </summary>
        internal bool IsSetSchemaConversionApplicationAttributes() => this.SchemaConversionApplicationAttributes != null;

        /// <summary>
        /// Gets and sets the property SourceDataProviderDescriptors. 
        /// <para>
        /// Information about the source data provider, including the name, ARN, and Amazon Web
        /// Services Secrets Manager parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataProviderDescriptorDefinition> SourceDataProviderDescriptors { get; set; } = AWSConfigs.InitializeCollections ? new List<DataProviderDescriptorDefinition>() : null;

        /// <summary>
        /// Checks to see if the SourceDataProviderDescriptors property is set.
        /// </summary>
        internal bool IsSetSourceDataProviderDescriptors() => this.SourceDataProviderDescriptors != null && (this.SourceDataProviderDescriptors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDataProviderDescriptors. 
        /// <para>
        /// Information about the target data provider, including the name, ARN, and Amazon Web
        /// Services Secrets Manager parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataProviderDescriptorDefinition> TargetDataProviderDescriptors { get; set; } = AWSConfigs.InitializeCollections ? new List<DataProviderDescriptorDefinition>() : null;

        /// <summary>
        /// Checks to see if the TargetDataProviderDescriptors property is set.
        /// </summary>
        internal bool IsSetTargetDataProviderDescriptors() => this.TargetDataProviderDescriptors != null && (this.TargetDataProviderDescriptors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransformationRules. 
        /// <para>
        /// A JSON string that specifies the transformation rules for the migration project. Transformation
        /// rules let you customize how DMS Schema Conversion converts your source database objects,
        /// including renaming, adding prefixes or suffixes, and changing data types. For the
        /// transformation rule format and examples, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/sc-transformation-rules.html">Transformation
        /// rules in DMS Schema Conversion</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Homogeneous data migrations do not support transformation rules.
        /// </para>
        ///  </note>
        /// </summary>
        public string TransformationRules { get; set; }

        /// <summary>
        /// Checks to see if the TransformationRules property is set.
        /// </summary>
        internal bool IsSetTransformationRules() => this.TransformationRules != null;
    }
}
