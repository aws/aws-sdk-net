/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExportTasks operation.
    /// Describes the specified export instance tasks or all your export instance tasks.
    /// </summary>
    public partial class DescribeExportTasksRequest : AmazonEC2Request
    {
        private List<string> _exportTaskIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();

        /// <summary>
        /// Gets and sets the property ExportTaskIds. 
        /// <para>
        /// The export task IDs.
        /// </para>
        /// </summary>
        public List<string> ExportTaskIds
        {
            get { return this._exportTaskIds; }
            set { this._exportTaskIds = value; }
        }

        // Check to see if ExportTaskIds property is set
        internal bool IsSetExportTaskIds()
        {
            return this._exportTaskIds != null && this._exportTaskIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

    }
}