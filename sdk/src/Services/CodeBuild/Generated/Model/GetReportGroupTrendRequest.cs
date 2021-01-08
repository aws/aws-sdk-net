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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the GetReportGroupTrend operation.
    /// 
    /// </summary>
    public partial class GetReportGroupTrendRequest : AmazonCodeBuildRequest
    {
        private int? _numOfReports;
        private string _reportGroupArn;
        private ReportGroupTrendFieldType _trendField;

        /// <summary>
        /// Gets and sets the property NumOfReports.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int NumOfReports
        {
            get { return this._numOfReports.GetValueOrDefault(); }
            set { this._numOfReports = value; }
        }

        // Check to see if NumOfReports property is set
        internal bool IsSetNumOfReports()
        {
            return this._numOfReports.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportGroupArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ReportGroupArn
        {
            get { return this._reportGroupArn; }
            set { this._reportGroupArn = value; }
        }

        // Check to see if ReportGroupArn property is set
        internal bool IsSetReportGroupArn()
        {
            return this._reportGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrendField.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportGroupTrendFieldType TrendField
        {
            get { return this._trendField; }
            set { this._trendField = value; }
        }

        // Check to see if TrendField property is set
        internal bool IsSetTrendField()
        {
            return this._trendField != null;
        }

    }
}