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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the ExportMetadataModelAssessment operation.
    /// </summary>
    public partial class ExportMetadataModelAssessmentResponse : AmazonWebServiceResponse
    {
        private ExportMetadataModelAssessmentResultEntry _csvReport;
        private ExportMetadataModelAssessmentResultEntry _pdfReport;

        /// <summary>
        /// Gets and sets the property CsvReport. 
        /// <para>
        /// The Amazon S3 details for an assessment exported in CSV format.
        /// </para>
        /// </summary>
        public ExportMetadataModelAssessmentResultEntry CsvReport
        {
            get { return this._csvReport; }
            set { this._csvReport = value; }
        }

        // Check to see if CsvReport property is set
        internal bool IsSetCsvReport()
        {
            return this._csvReport != null;
        }

        /// <summary>
        /// Gets and sets the property PdfReport. 
        /// <para>
        /// The Amazon S3 details for an assessment exported in PDF format.
        /// </para>
        /// </summary>
        public ExportMetadataModelAssessmentResultEntry PdfReport
        {
            get { return this._pdfReport; }
            set { this._pdfReport = value; }
        }

        // Check to see if PdfReport property is set
        internal bool IsSetPdfReport()
        {
            return this._pdfReport != null;
        }

    }
}