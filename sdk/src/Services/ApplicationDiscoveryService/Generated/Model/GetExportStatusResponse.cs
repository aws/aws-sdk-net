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
    /// This is the response object from the GetExportStatus operation.
    /// </summary>
    public partial class GetExportStatusResponse : AmazonWebServiceResponse
    {
        private string _exportId;
        private Dictionary<string, string> _exportStatusMap = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// Returns configuration details, including the configuration ID, attribute names, and
        /// attribute values.
        /// </para>
        /// </summary>
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property ExportStatusMap. 
        /// <para>
        /// Returns export details. When the status is complete, the response includes a URL for
        /// an Amazon S3 bucket where you can view the data in a CSV file.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ExportStatusMap
        {
            get { return this._exportStatusMap; }
            set { this._exportStatusMap = value; }
        }

        // Check to see if ExportStatusMap property is set
        internal bool IsSetExportStatusMap()
        {
            return this._exportStatusMap != null && this._exportStatusMap.Count > 0; 
        }

    }
}