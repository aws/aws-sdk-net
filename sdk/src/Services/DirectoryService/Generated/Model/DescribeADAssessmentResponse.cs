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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeADAssessment operation.
    /// </summary>
    public partial class DescribeADAssessmentResponse : AmazonWebServiceResponse
    {
        private Assessment _assessment;
        private List<AssessmentReport> _assessmentReports = AWSConfigs.InitializeCollections ? new List<AssessmentReport>() : null;

        /// <summary>
        /// Gets and sets the property Assessment. 
        /// <para>
        /// Detailed information about the self-managed instance settings (IDs and DNS IPs).
        /// </para>
        /// </summary>
        public Assessment Assessment
        {
            get { return this._assessment; }
            set { this._assessment = value; }
        }

        // Check to see if Assessment property is set
        internal bool IsSetAssessment()
        {
            return this._assessment != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentReports. 
        /// <para>
        /// A list of assessment reports containing validation results for each domain controller
        /// and test category. Each report includes specific validation details and outcomes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssessmentReport> AssessmentReports
        {
            get { return this._assessmentReports; }
            set { this._assessmentReports = value; }
        }

        // Check to see if AssessmentReports property is set
        internal bool IsSetAssessmentReports()
        {
            return this._assessmentReports != null && (this._assessmentReports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}