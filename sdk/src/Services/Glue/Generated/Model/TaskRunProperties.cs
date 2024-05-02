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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private ExportLabelsTaskRunProperties _exportLabelsTaskRunProperties;
        private FindMatchesTaskRunProperties _findMatchesTaskRunProperties;
        private ImportLabelsTaskRunProperties _importLabelsTaskRunProperties;
        private LabelingSetGenerationTaskRunProperties _labelingSetGenerationTaskRunProperties;
        private TaskType _taskType;

        /// <summary>
        /// Gets and sets the property ExportLabelsTaskRunProperties. 
        /// <para>
        /// The configuration properties for an exporting labels task run.
        /// </para>
        /// </summary>
        public ExportLabelsTaskRunProperties ExportLabelsTaskRunProperties
        {
            get { return this._exportLabelsTaskRunProperties; }
            set { this._exportLabelsTaskRunProperties = value; }
        }

        // Check to see if ExportLabelsTaskRunProperties property is set
        internal bool IsSetExportLabelsTaskRunProperties()
        {
            return this._exportLabelsTaskRunProperties != null;
        }

        /// <summary>
        /// Gets and sets the property FindMatchesTaskRunProperties. 
        /// <para>
        /// The configuration properties for a find matches task run.
        /// </para>
        /// </summary>
        public FindMatchesTaskRunProperties FindMatchesTaskRunProperties
        {
            get { return this._findMatchesTaskRunProperties; }
            set { this._findMatchesTaskRunProperties = value; }
        }

        // Check to see if FindMatchesTaskRunProperties property is set
        internal bool IsSetFindMatchesTaskRunProperties()
        {
            return this._findMatchesTaskRunProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ImportLabelsTaskRunProperties. 
        /// <para>
        /// The configuration properties for an importing labels task run.
        /// </para>
        /// </summary>
        public ImportLabelsTaskRunProperties ImportLabelsTaskRunProperties
        {
            get { return this._importLabelsTaskRunProperties; }
            set { this._importLabelsTaskRunProperties = value; }
        }

        // Check to see if ImportLabelsTaskRunProperties property is set
        internal bool IsSetImportLabelsTaskRunProperties()
        {
            return this._importLabelsTaskRunProperties != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingSetGenerationTaskRunProperties. 
        /// <para>
        /// The configuration properties for a labeling set generation task run.
        /// </para>
        /// </summary>
        public LabelingSetGenerationTaskRunProperties LabelingSetGenerationTaskRunProperties
        {
            get { return this._labelingSetGenerationTaskRunProperties; }
            set { this._labelingSetGenerationTaskRunProperties = value; }
        }

        // Check to see if LabelingSetGenerationTaskRunProperties property is set
        internal bool IsSetLabelingSetGenerationTaskRunProperties()
        {
            return this._labelingSetGenerationTaskRunProperties != null;
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task run.
        /// </para>
        /// </summary>
        public TaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

    }
}