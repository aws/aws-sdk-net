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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the GetLendingAnalysisSummary operation.
    /// </summary>
    public partial class GetLendingAnalysisSummaryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalyzeLendingModelVersion. 
        /// <para>
        /// The current model version of the Analyze Lending API.
        /// </para>
        /// </summary>
        public string AnalyzeLendingModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzeLendingModelVersion property is set.
        /// </summary>
        internal bool IsSetAnalyzeLendingModelVersion() => this.AnalyzeLendingModelVersion != null;

        /// <summary>
        /// Gets and sets the property DocumentMetadata.
        /// </summary>
        public DocumentMetadata DocumentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DocumentMetadata property is set.
        /// </summary>
        internal bool IsSetDocumentMetadata() => this.DocumentMetadata != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        ///  The current status of the lending analysis job. 
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns if the lending analysis could not be completed. Contains explanation for what
        /// error occurred.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        ///  Contains summary information for documents grouped by type.
        /// </para>
        /// </summary>
        public LendingSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warnings that occurred during the lending analysis operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Warning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<Warning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
