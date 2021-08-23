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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeReportPlan operation.
    /// </summary>
    public partial class DescribeReportPlanResponse : AmazonWebServiceResponse
    {
        private ReportPlan _reportPlan;

        /// <summary>
        /// Gets and sets the property ReportPlan. 
        /// <para>
        /// Returns details about the report plan that is specified by its name. These details
        /// include the report plan's Amazon Resource Name (ARN), description, settings, delivery
        /// channel, deployment status, creation time, and last attempted and successful run times.
        /// </para>
        /// </summary>
        public ReportPlan ReportPlan
        {
            get { return this._reportPlan; }
            set { this._reportPlan = value; }
        }

        // Check to see if ReportPlan property is set
        internal bool IsSetReportPlan()
        {
            return this._reportPlan != null;
        }

    }
}