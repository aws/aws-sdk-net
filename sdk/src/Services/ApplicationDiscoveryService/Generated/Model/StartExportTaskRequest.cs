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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportTask operation.
    /// Export the configuration data about discovered configuration items and relationships
    /// to an S3 bucket in a specified format.
    /// </summary>
    public partial class StartExportTaskRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _exportDataFormat = new List<string>();

        /// <summary>
        /// Gets and sets the property ExportDataFormat. 
        /// <para>
        /// The file format for the returned export data. Default value is <code>CSV</code>.
        /// </para>
        /// </summary>
        public List<string> ExportDataFormat
        {
            get { return this._exportDataFormat; }
            set { this._exportDataFormat = value; }
        }

        // Check to see if ExportDataFormat property is set
        internal bool IsSetExportDataFormat()
        {
            return this._exportDataFormat != null && this._exportDataFormat.Count > 0; 
        }

    }
}