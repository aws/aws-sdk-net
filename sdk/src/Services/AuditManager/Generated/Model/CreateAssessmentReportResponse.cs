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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the CreateAssessmentReport operation.
    /// </summary>
    public partial class CreateAssessmentReportResponse : AmazonWebServiceResponse
    {
        private AssessmentReport _assessmentReport;

        /// <summary>
        /// Gets and sets the property AssessmentReport. 
        /// <para>
        ///  The new assessment report that the <c>CreateAssessmentReport</c> API returned. 
        /// </para>
        /// </summary>
        public AssessmentReport AssessmentReport
        {
            get { return this._assessmentReport; }
            set { this._assessmentReport = value; }
        }

        // Check to see if AssessmentReport property is set
        internal bool IsSetAssessmentReport()
        {
            return this._assessmentReport != null;
        }

    }
}