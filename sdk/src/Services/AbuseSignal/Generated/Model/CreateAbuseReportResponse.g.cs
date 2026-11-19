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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AbuseSignal.Model
{
    /// <summary>
    /// This is the response object from the CreateAbuseReport operation.
    /// </summary>
    public partial class CreateAbuseReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CorrelationId. 
        /// <para>
        /// The correlation ID that you provided in the request, if any. The service echoes this
        /// value back in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationId property is set.
        /// </summary>
        internal bool IsSetCorrelationId() => this.CorrelationId != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier assigned to the submitted abuse report. Use this ID with <a>GetAbuseReportStatus</a>
        /// to track processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 64)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;
    }
}
