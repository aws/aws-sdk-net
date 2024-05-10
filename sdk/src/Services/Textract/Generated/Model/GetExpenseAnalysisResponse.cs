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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the GetExpenseAnalysis operation.
    /// </summary>
    public partial class GetExpenseAnalysisResponse : AmazonWebServiceResponse
    {
        private string _analyzeExpenseModelVersion;
        private DocumentMetadata _documentMetadata;
        private List<ExpenseDocument> _expenseDocuments = AWSConfigs.InitializeCollections ? new List<ExpenseDocument>() : null;
        private JobStatus _jobStatus;
        private string _nextToken;
        private string _statusMessage;
        private List<Warning> _warnings = AWSConfigs.InitializeCollections ? new List<Warning>() : null;

        /// <summary>
        /// Gets and sets the property AnalyzeExpenseModelVersion. 
        /// <para>
        /// The current model version of AnalyzeExpense.
        /// </para>
        /// </summary>
        public string AnalyzeExpenseModelVersion
        {
            get { return this._analyzeExpenseModelVersion; }
            set { this._analyzeExpenseModelVersion = value; }
        }

        // Check to see if AnalyzeExpenseModelVersion property is set
        internal bool IsSetAnalyzeExpenseModelVersion()
        {
            return this._analyzeExpenseModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Information about a document that Amazon Textract processed. <c>DocumentMetadata</c>
        /// is returned in every page of paginated responses from an Amazon Textract operation.
        /// </para>
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
        /// Gets and sets the property ExpenseDocuments. 
        /// <para>
        /// The expenses detected by Amazon Textract.
        /// </para>
        /// </summary>
        public List<ExpenseDocument> ExpenseDocuments
        {
            get { return this._expenseDocuments; }
            set { this._expenseDocuments = value; }
        }

        // Check to see if ExpenseDocuments property is set
        internal bool IsSetExpenseDocuments()
        {
            return this._expenseDocuments != null && (this._expenseDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the text detection job.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Textract returns this token. You can use this
        /// token in the subsequent request to retrieve the next set of text-detection results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns if the detection job could not be completed. Contains explanation for what
        /// error occured. 
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
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warnings that occurred during the text-detection operation for the document.
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
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}