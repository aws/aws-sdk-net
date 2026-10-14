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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the GetLicenseManagerReportGenerator operation.
    /// </summary>
    public partial class GetLicenseManagerReportGeneratorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ReportGenerator. 
        /// <para>
        /// A report generator that creates periodic reports about your license configurations.
        /// </para>
        /// </summary>
        public ReportGenerator ReportGenerator { get; set; }

        /// <summary>
        /// Checks to see if the ReportGenerator property is set.
        /// </summary>
        internal bool IsSetReportGenerator() => this.ReportGenerator != null;
    }
}
