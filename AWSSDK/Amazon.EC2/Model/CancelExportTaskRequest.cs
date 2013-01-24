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
    /// <summary>
    /// Cancels an active export task.
    /// </summary>
    /// <remarks>
    /// The action removes all artifacts of the export, including any partially created Amazon S3 objects.
    /// If the export task is complete or is in the process of transferring the final disk image,
    /// the action fails and returns an error.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelExportTaskRequest
    {
        private string exportTaskIdField;

        /// <summary>
        /// The ID of the export task you want to cancel.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportTaskId")]
        public string ExportTaskId
        {
            get { return this.exportTaskIdField; }
            set { this.exportTaskIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the export task you want to cancel.
        /// </summary>
        /// <param name="exportTaskId">Id of the export task to cancel</param>
        /// <returns>this instance</returns>
        public CancelExportTaskRequest WithExportTaskId(string exportTaskId)
        {
            this.exportTaskIdField = exportTaskId;
            return this;
        }

        /// <summary>
        /// Checks if the ExportTaskId property is set.
        /// </summary>
        /// <returns>True if the ExportTaskId property is set</returns>
        public bool IsSetExportTaskId()
        {
            return !string.IsNullOrEmpty(this.exportTaskIdField);
        }
    }
}
