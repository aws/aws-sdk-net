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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeExportTasksResult
    {
        private List<ExportTaskType> exportTaskTypesField;

        /// <summary>
        /// Gets and sets the details of the created ExportVM tasks.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportTaskType")]
        public List<ExportTaskType> ExportTasks
        {
            get 
            {
                if (this.exportTaskTypesField == null)
                {
                    this.exportTaskTypesField = new List<ExportTaskType>();
                }
                return this.exportTaskTypesField; 
            }
            set { this.exportTaskTypesField = value; }
        }

        /// <summary>
        /// Checks if the ExportTasks property is set.
        /// </summary>
        /// <returns>True if the ExportTasks property is set</returns>
        public bool IsSetExportTasks()
        {
            return (this.ExportTasks.Count > 0);
        }
    }
}
