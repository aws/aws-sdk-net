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
    /// This is the response object from the GetExpenseAnalysis operation.
    /// </summary>
    public partial class GetExpenseAnalysisResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalyzeExpenseModelVersion. 
        /// <para>
        /// The current model version of AnalyzeExpense.
        /// </para>
        /// </summary>
        public string AnalyzeExpenseModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzeExpenseModelVersion property is set.
        /// </summary>
        internal bool IsSetAnalyzeExpenseModelVersion() => this.AnalyzeExpenseModelVersion != null;

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Information about a document that Amazon Textract processed. <c>DocumentMetadata</c>
        /// is returned in every page of paginated responses from an Amazon Textract operation.
        /// </para>
        /// </summary>
        public DocumentMetadata DocumentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DocumentMetadata property is set.
        /// </summary>
        internal bool IsSetDocumentMetadata() => this.DocumentMetadata != null;

        /// <summary>
        /// Gets and sets the property ExpenseDocuments. 
        /// <para>
        /// The expenses detected by Amazon Textract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpenseDocument> ExpenseDocuments { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpenseDocument>() : null;

        /// <summary>
        /// Checks to see if the ExpenseDocuments property is set.
        /// </summary>
        internal bool IsSetExpenseDocuments() => this.ExpenseDocuments != null && (this.ExpenseDocuments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the text detection job.
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Textract returns this token. You can use this
        /// token in the subsequent request to retrieve the next set of text-detection results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns if the detection job could not be completed. Contains explanation for what
        /// error occured. 
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warnings that occurred during the text-detection operation for the document.
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
