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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetReports operation.
    /// </summary>
    public partial class BatchGetReportsResponse : AmazonWebServiceResponse
    {
        private List<Report> _reports = AWSConfigs.InitializeCollections ? new List<Report>() : null;
        private List<string> _reportsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Reports. 
        /// <para>
        ///  The array of <c>Report</c> objects returned by <c>BatchGetReports</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Report> Reports
        {
            get { return this._reports; }
            set { this._reports = value; }
        }

        // Check to see if Reports property is set
        internal bool IsSetReports()
        {
            return this._reports != null && (this._reports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportsNotFound. 
        /// <para>
        ///  An array of ARNs passed to <c>BatchGetReportGroups</c> that are not associated with
        /// a <c>Report</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ReportsNotFound
        {
            get { return this._reportsNotFound; }
            set { this._reportsNotFound = value; }
        }

        // Check to see if ReportsNotFound property is set
        internal bool IsSetReportsNotFound()
        {
            return this._reportsNotFound != null && (this._reportsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}