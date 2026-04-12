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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// This is the response object from the GetScheduledReport operation.
    /// </summary>
    public partial class GetScheduledReportResponse : AmazonWebServiceResponse
    {
        private ScheduledReport _scheduledReport;

        /// <summary>
        /// Gets and sets the property ScheduledReport. 
        /// <para>
        /// The scheduled report configuration and metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledReport ScheduledReport
        {
            get { return this._scheduledReport; }
            set { this._scheduledReport = value; }
        }

        // Check to see if ScheduledReport property is set
        internal bool IsSetScheduledReport()
        {
            return this._scheduledReport != null;
        }

    }
}