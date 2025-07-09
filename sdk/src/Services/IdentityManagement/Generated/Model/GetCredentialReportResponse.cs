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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetCredentialReport.html">GetCredentialReport</a>
    /// request.
    /// </summary>
    public partial class GetCredentialReportResponse : AmazonWebServiceResponse
    {
        private MemoryStream _content;
        private DateTime? _generatedTime;
        private ReportFormatType _reportFormat;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains the credential report. The report is Base64-encoded.
        /// </para>
        /// </summary>
        public MemoryStream Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedTime. 
        /// <para>
        ///  The date and time when the credential report was created, in <a href="http://www.iso.org/iso/iso8601">ISO
        /// 8601 date-time format</a>.
        /// </para>
        /// </summary>
        public DateTime? GeneratedTime
        {
            get { return this._generatedTime; }
            set { this._generatedTime = value; }
        }

        // Check to see if GeneratedTime property is set
        internal bool IsSetGeneratedTime()
        {
            return this._generatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// The format (MIME type) of the credential report.
        /// </para>
        /// </summary>
        public ReportFormatType ReportFormat
        {
            get { return this._reportFormat; }
            set { this._reportFormat = value; }
        }

        // Check to see if ReportFormat property is set
        internal bool IsSetReportFormat()
        {
            return this._reportFormat != null;
        }

    }
}