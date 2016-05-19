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
    /// This is the response object from the DescribeExportConfigurations operation.
    /// </summary>
    public partial class DescribeExportConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<ExportInfo> _exportsInfo = new List<ExportInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportsInfo. 
        /// <para>
        /// Returns export details. When the status is complete, the response includes a URL for
        /// an Amazon S3 bucket where you can view the data in a CSV file.
        /// </para>
        /// </summary>
        public List<ExportInfo> ExportsInfo
        {
            get { return this._exportsInfo; }
            set { this._exportsInfo = value; }
        }

        // Check to see if ExportsInfo property is set
        internal bool IsSetExportsInfo()
        {
            return this._exportsInfo != null && this._exportsInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to get the next set of results. For example, if you specified 100 IDs for
        /// <code>DescribeConfigurationsRequest$configurationIds</code> but set <code>DescribeExportConfigurationsRequest$maxResults</code>
        /// to 10, you will get results in a set of 10. Use the token in the query to get the
        /// next set of 10.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}