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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the StartQuotaUtilizationReport operation.
    /// </summary>
    public partial class StartQuotaUtilizationReportResponse : AmazonWebServiceResponse
    {
        private string _message;
        private string _reportId;
        private ReportStatus _status;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An optional message providing additional information about the report generation status.
        /// This field may contain details about the report initiation or indicate if an existing
        /// recent report is being reused.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// A unique identifier for the quota utilization report. Use this identifier with the
        /// <c>GetQuotaUtilizationReport</c> operation to retrieve the report results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the report generation. The status will be <c>PENDING</c> when
        /// the report is first initiated.
        /// </para>
        /// </summary>
        public ReportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}