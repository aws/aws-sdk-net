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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the GetLendingAnalysisSummary operation.
    /// </summary>
    public partial class GetLendingAnalysisSummaryResponse : AmazonWebServiceResponse
    {
        private string _analyzeLendingModelVersion;
        private DocumentMetadata _documentMetadata;
        private JobStatus _jobStatus;
        private string _statusMessage;
        private LendingSummary _summary;
        private List<Warning> _warnings = new List<Warning>();

        /// <summary>
        /// Gets and sets the property AnalyzeLendingModelVersion. 
        /// <para>
        /// The current model version of the Analyze Lending API.
        /// </para>
        /// </summary>
        public string AnalyzeLendingModelVersion
        {
            get { return this._analyzeLendingModelVersion; }
            set { this._analyzeLendingModelVersion = value; }
        }

        // Check to see if AnalyzeLendingModelVersion property is set
        internal bool IsSetAnalyzeLendingModelVersion()
        {
            return this._analyzeLendingModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata.
        /// </summary>
        public DocumentMetadata DocumentMetadata
        {
            get { return this._documentMetadata; }
            set { this._documentMetadata = value; }
        }

        // Check to see if DocumentMetadata property is set
        internal bool IsSetDocumentMetadata()
        {
            return this._documentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        ///  The current status of the lending analysis job. 
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns if the lending analysis could not be completed. Contains explanation for what
        /// error occurred.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        ///  Contains summary information for documents grouped by type.
        /// </para>
        /// </summary>
        public LendingSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warnings that occurred during the lending analysis operation.
        /// </para>
        /// </summary>
        public List<Warning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}