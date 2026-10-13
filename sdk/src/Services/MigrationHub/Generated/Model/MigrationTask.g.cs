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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Represents a migration task in a migration tool.
    /// </summary>
    public partial class MigrationTask
    {
        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task. <i>Do not store personal data
        /// in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MigrationTaskName { get; set; }

        /// <summary>
        /// Checks to see if the MigrationTaskName property is set.
        /// </summary>
        internal bool IsSetMigrationTaskName() => this.MigrationTaskName != null;

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// A name that identifies the vendor of the migration tool being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ProgressUpdateStream { get; set; }

        /// <summary>
        /// Checks to see if the ProgressUpdateStream property is set.
        /// </summary>
        internal bool IsSetProgressUpdateStream() => this.ProgressUpdateStream != null;

        /// <summary>
        /// Gets and sets the property ResourceAttributeList. 
        /// <para>
        /// Information about the resource that is being migrated. This data will be used to map
        /// the task to a resource in the Application Discovery Service repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ResourceAttribute> ResourceAttributeList { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceAttribute>() : null;

        /// <summary>
        /// Checks to see if the ResourceAttributeList property is set.
        /// </summary>
        internal bool IsSetResourceAttributeList() => this.ResourceAttributeList != null && (this.ResourceAttributeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// Task object encapsulating task information.
        /// </para>
        /// </summary>
        public Task Task { get; set; }

        /// <summary>
        /// Checks to see if the Task property is set.
        /// </summary>
        internal bool IsSetTask() => this.Task != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The timestamp when the task was gathered.
        /// </para>
        /// </summary>
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;
    }
}
