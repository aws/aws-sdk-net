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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an export instance task.
    /// </summary>
    public partial class ExportTask
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the resource being exported.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExportTaskId. 
        /// <para>
        /// The ID of the export task.
        /// </para>
        /// </summary>
        public string ExportTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ExportTaskId property is set.
        /// </summary>
        internal bool IsSetExportTaskId() => this.ExportTaskId != null;

        /// <summary>
        /// Gets and sets the property ExportToS3Task. 
        /// <para>
        /// Information about the export task.
        /// </para>
        /// </summary>
        public ExportToS3Task ExportToS3Task { get; set; }

        /// <summary>
        /// Checks to see if the ExportToS3Task property is set.
        /// </summary>
        internal bool IsSetExportToS3Task() => this.ExportToS3Task != null;

        /// <summary>
        /// Gets and sets the property InstanceExportDetails. 
        /// <para>
        /// Information about the instance to export.
        /// </para>
        /// </summary>
        public InstanceExportDetails InstanceExportDetails { get; set; }

        /// <summary>
        /// Checks to see if the InstanceExportDetails property is set.
        /// </summary>
        internal bool IsSetInstanceExportDetails() => this.InstanceExportDetails != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the export task.
        /// </para>
        /// </summary>
        public ExportTaskState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message related to the export task.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the export task.
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
