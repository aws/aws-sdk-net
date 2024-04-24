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
    /// Container for the parameters to the ModifyReportDefinition operation.
    /// Allows you to programmatically update your report preferences.
    /// </summary>
    public partial class ModifyReportDefinitionRequest : AmazonCostAndUsageReportRequest
    {
        private ReportDefinition _reportDefinition;
        private string _reportName;

        /// <summary>
        /// Gets and sets the property ReportDefinition.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportDefinition ReportDefinition
        {
            get { return this._reportDefinition; }
            set { this._reportDefinition = value; }
        }

        // Check to see if ReportDefinition property is set
        internal bool IsSetReportDefinition()
        {
            return this._reportDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ReportName.
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