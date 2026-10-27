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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a database snapshot.
    /// </summary>
    public partial class RelationalDatabaseSnapshot
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database snapshot.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the database snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The software of the database snapshot (for example, <c>MySQL</c>)
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version for the database snapshot (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database from which the database snapshot was
        /// created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the FromRelationalDatabaseArn property is set.
        /// </summary>
        internal bool IsSetFromRelationalDatabaseArn() => this.FromRelationalDatabaseArn != null;

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseBlueprintId. 
        /// <para>
        /// The blueprint ID of the database from which the database snapshot was created. A blueprint
        /// describes the major engine version of a database.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseBlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the FromRelationalDatabaseBlueprintId property is set.
        /// </summary>
        internal bool IsSetFromRelationalDatabaseBlueprintId() => this.FromRelationalDatabaseBlueprintId != null;

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID of the database from which the database snapshot was created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseBundleId { get; set; }

        /// <summary>
        /// Checks to see if the FromRelationalDatabaseBundleId property is set.
        /// </summary>
        internal bool IsSetFromRelationalDatabaseBundleId() => this.FromRelationalDatabaseBundleId != null;

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseName. 
        /// <para>
        /// The name of the source database from which the database snapshot was created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the FromRelationalDatabaseName property is set.
        /// </summary>
        internal bool IsSetFromRelationalDatabaseName() => this.FromRelationalDatabaseName != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Region name and Availability Zone where the database snapshot is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database snapshot.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (for example, <c>32</c>) for the database snapshot.
        /// </para>
        /// </summary>
        public int? SizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGb property is set.
        /// </summary>
        internal bool IsSetSizeInGb() => this.SizeInGb.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the database snapshot.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for the database snapshot. Include this code in your email to support
        /// when you have questions about a database snapshot in Lightsail. This code enables
        /// our support team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
