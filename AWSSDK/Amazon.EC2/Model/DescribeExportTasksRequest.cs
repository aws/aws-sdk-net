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
    /// Describes your export tasks.
    /// If no export task IDs are specified, all export tasks initiated by you are returned.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeExportTasksRequest
    {
        private List<string> exportTaskIdsField;

        /// <summary>
        /// One or more export task IDs.
        /// If no task IDs are provided, all active export tasks will be described.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportTaskIds")]
        public List<string> ExportTaskIds
        {
            get
            {
                if (this.exportTaskIdsField == null)
                {
                    this.exportTaskIdsField = new List<string>();
                }
                return this.exportTaskIdsField;

            }
            set { this.exportTaskIdsField = value; }
        }

        /// <summary>
        /// Sets export task IDs.
        /// </summary>
        /// <param name="list">Collection of export task ids to describe</param>
        /// <returns>this instance</returns>
        public DescribeExportTasksRequest WithExportTaskIds(params string[] list)
        {
            foreach (string item in list)
            {
                ExportTaskIds.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the ExportTaskIds property is set.
        /// </summary>
        /// <returns>True if the ExportTaskIds property is set</returns>
        public bool IsSetExportTaskIds()
        {
            return (this.ExportTaskIds.Count > 0);
        }
    }
}
