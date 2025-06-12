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
    /// This is the response object from the GetReportGroupTrend operation.
    /// </summary>
    public partial class GetReportGroupTrendResponse : AmazonWebServiceResponse
    {
        private List<ReportWithRawData> _rawData = AWSConfigs.InitializeCollections ? new List<ReportWithRawData>() : null;
        private ReportGroupTrendStats _stats;

        /// <summary>
        /// Gets and sets the property RawData. 
        /// <para>
        /// An array that contains the raw data for each report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReportWithRawData> RawData
        {
            get { return this._rawData; }
            set { this._rawData = value; }
        }

        // Check to see if RawData property is set
        internal bool IsSetRawData()
        {
            return this._rawData != null && (this._rawData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Stats. 
        /// <para>
        /// Contains the accumulated trend data.
        /// </para>
        /// </summary>
        public ReportGroupTrendStats Stats
        {
            get { return this._stats; }
            set { this._stats = value; }
        }

        // Check to see if Stats property is set
        internal bool IsSetStats()
        {
            return this._stats != null;
        }

    }
}