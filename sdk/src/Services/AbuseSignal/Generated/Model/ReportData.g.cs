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
    /// The abuse report data in XARF format. This is a union type, so exactly one member
    /// must be specified.
    /// </summary>
    public partial class ReportData
    {
        /// <summary>
        /// Gets and sets the property Xarf. 
        /// <para>
        /// A JSON object that conforms to the XARF v4 specification. At a minimum, the document
        /// must include the XARF core fields, including the required <c>category</c> and <c>type</c>
        /// fields that classify the report (for example, <c>category</c> <c>content</c> with
        /// <c>type</c> <c>phishing</c>). For the XARF core fields and detailed schema definitions
        /// of each report type, see the <a href="https://xarf.org/docs/specification/">XARF v4
        /// Technical Specification on the XARF website</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Never include images, video, or copies of child sexual abuse or child sexual exploitation
        /// material in a report, in any field and for any report type. Send URLs, hash values,
        /// and reference identifiers only.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you suspect that activity is illegal, use the XARF <c>description</c> field to
        /// explain why and name the laws concerned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Testing your integration</b> 
        /// </para>
        ///  
        /// <para>
        /// To test your integration, add the tag <c>lifecycle:test</c> to the report. Amazon
        /// Web Services validates test reports and returns a report ID and status in the same
        /// way as other reports, but doesn't process them as abuse reports. Amazon Web Services
        /// deletes test reports shortly after submission.
        /// </para>
        ///  
        /// <para>
        /// Use test values only, such as example.com and the IP address ranges reserved for documentation
        /// (192.0.2.0/24, 198.51.100.0/24 and 203.0.113.0/24). Don't add this tag to a real abuse
        /// report.
        /// </para>
        ///  
        /// <para>
        /// Tag keys that begin with <c>aws:</c> are reserved.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Xarf { get; set; }

        /// <summary>
        /// Checks to see if the Xarf property is set.
        /// </summary>
        internal bool IsSetXarf() => !this.Xarf.IsNull();
    }
}
