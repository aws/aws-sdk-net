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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The configuration properties for the task run.
    /// </summary>
    public partial class TaskRunProperties
    {
        /// <summary>
        /// Gets and sets the property ExportLabelsTaskRunProperties. 
        /// <para>
        /// The configuration properties for an exporting labels task run.
        /// </para>
        /// </summary>
        public ExportLabelsTaskRunProperties ExportLabelsTaskRunProperties { get; set; }

        /// <summary>
        /// Checks to see if the ExportLabelsTaskRunProperties property is set.
        /// </summary>
        internal bool IsSetExportLabelsTaskRunProperties() => this.ExportLabelsTaskRunProperties != null;

        /// <summary>
        /// Gets and sets the property FindMatchesTaskRunProperties. 
        /// <para>
        /// The configuration properties for a find matches task run.
        /// </para>
        /// </summary>
        public FindMatchesTaskRunProperties FindMatchesTaskRunProperties { get; set; }

        /// <summary>
        /// Checks to see if the FindMatchesTaskRunProperties property is set.
        /// </summary>
        internal bool IsSetFindMatchesTaskRunProperties() => this.FindMatchesTaskRunProperties != null;

        /// <summary>
        /// Gets and sets the property ImportLabelsTaskRunProperties. 
        /// <para>
        /// The configuration properties for an importing labels task run.
        /// </para>
        /// </summary>
        public ImportLabelsTaskRunProperties ImportLabelsTaskRunProperties { get; set; }

        /// <summary>
        /// Checks to see if the ImportLabelsTaskRunProperties property is set.
        /// </summary>
        internal bool IsSetImportLabelsTaskRunProperties() => this.ImportLabelsTaskRunProperties != null;

        /// <summary>
        /// Gets and sets the property LabelingSetGenerationTaskRunProperties. 
        /// <para>
        /// The configuration properties for a labeling set generation task run.
        /// </para>
        /// </summary>
        public LabelingSetGenerationTaskRunProperties LabelingSetGenerationTaskRunProperties { get; set; }

        /// <summary>
        /// Checks to see if the LabelingSetGenerationTaskRunProperties property is set.
        /// </summary>
        internal bool IsSetLabelingSetGenerationTaskRunProperties() => this.LabelingSetGenerationTaskRunProperties != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task run.
        /// </para>
        /// </summary>
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;
    }
}
