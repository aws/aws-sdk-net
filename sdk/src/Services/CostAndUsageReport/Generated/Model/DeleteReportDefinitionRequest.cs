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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
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
namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReportDefinition operation.
    /// Deletes the specified report. Any tags associated with the report are also deleted.
    /// </summary>
    public partial class DeleteReportDefinitionRequest : AmazonCostAndUsageReportRequest
    {
        private string _reportName;

        /// <summary>
        /// Gets and sets the property ReportName. 
        /// <para>
        /// The name of the report that you want to delete. The name must be unique, is case sensitive,
        /// and can't include spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ReportName
        {
            get { return this._reportName; }
            set { this._reportName = value; }
        }

        // Check to see if ReportName property is set
        internal bool IsSetReportName()
        {
            return this._reportName != null;
        }

    }
}