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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetCredentialReport operation.
    /// </summary>
    public partial class GetCredentialReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains the credential report. The report is Base64-encoded.
        /// </para>
        /// </summary>
        public MemoryStream Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property GeneratedTime. 
        /// <para>
        ///  The date and time when the credential report was created, in <a href="http://www.iso.org/iso/iso8601">ISO
        /// 8601 date-time format</a>.
        /// </para>
        /// </summary>
        public DateTime? GeneratedTime { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedTime property is set.
        /// </summary>
        internal bool IsSetGeneratedTime() => this.GeneratedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// The format (MIME type) of the credential report.
        /// </para>
        /// </summary>
        public ReportFormatType ReportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ReportFormat property is set.
        /// </summary>
        internal bool IsSetReportFormat() => this.ReportFormat != null;
    }
}
