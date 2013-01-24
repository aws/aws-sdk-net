/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    /// Details of an ExportVM task.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ExportTaskType
    {
        private string exportTaskIdField;
        private string descriptionField;
        private string stateField;
        private string statusMessageField;
        private InstanceExportTaskType instanceExportTaskTypeField;
        private ExportToS3TaskType exportToS3TaskTypeField;

        /// <summary>
        /// The ID of the export task.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportTaskId")]
        public string ExportTaskId
        {
            get { return this.exportTaskIdField; }
            set { this.exportTaskIdField = value; }
        }

        /// <summary>
        /// Checks if the ExportTaskId property is set.
        /// </summary>
        /// <returns>True if the ExportTaskId property is set</returns>
        public bool IsSetExportTaskId()
        {
            return !string.IsNullOrEmpty(this.exportTaskIdField); 
        }

        /// <summary>
        /// The description of the resource being exported.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Checks if the Description property is set.
        /// </summary>
        /// <returns>True if the Description property is set</returns>
        public bool IsSetDescription()
        {
            return !string.IsNullOrEmpty(this.descriptionField);
        }

        /// <summary>
        /// The state of the conversion task.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Checks if the State property is set.
        /// </summary>
        /// <returns>True if the State property is set</returns>
        public bool IsSetState()
        {
            return !string.IsNullOrEmpty(this.stateField);
        }

        /// <summary>
        /// The status message related to the export task.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField; }
            set { this.statusMessageField = value; }
        }

        /// <summary>
        /// Checks if the StatusMessage property is set.
        /// </summary>
        /// <returns>True if the StatusMessage property is set</returns>
        public bool IsSetStatusMessage()
        {
            return !string.IsNullOrEmpty(this.statusMessageField);
        }

        /// <summary>
        /// Information about the instance being exported.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceExportTaskType")]
        public InstanceExportTaskType InstanceExportTask
        {
            get { return this.instanceExportTaskTypeField; }
            set { this.instanceExportTaskTypeField = value; }
        }

        /// <summary>
        /// Checks if the InstanceExportTask property is set.
        /// </summary>
        /// <returns>True if the InstanceExportTask property is set</returns>
        public bool IsSetInstanceExportTask()
        {
            return this.instanceExportTaskTypeField != null;
        }

        /// <summary>
        /// Information about the destination Amazon S3 bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportToS3TaskType")]
        public ExportToS3TaskType ExportToS3Task
        {
            get { return this.exportToS3TaskTypeField; }
            set { this.exportToS3TaskTypeField = value; }
        }

        /// <summary>
        /// Checks if the ExportToS3Task property is set.
        /// </summary>
        /// <returns>True if the ExportToS3Task property is set</returns>
        public bool IsSetExportToS3Task()
        {
            return this.exportToS3TaskTypeField != null;
        }
    }
}
