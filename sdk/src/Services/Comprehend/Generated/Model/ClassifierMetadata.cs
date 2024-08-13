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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides information about a document classifier.
    /// </summary>
    public partial class ClassifierMetadata
    {
        private ClassifierEvaluationMetrics _evaluationMetrics;
        private int? _numberOfLabels;
        private int? _numberOfTestDocuments;
        private int? _numberOfTrainedDocuments;

        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        ///  Describes the result metrics for the test data associated with an documentation classifier.
        /// </para>
        /// </summary>
        public ClassifierEvaluationMetrics EvaluationMetrics
        {
            get { return this._evaluationMetrics; }
            set { this._evaluationMetrics = value; }
        }

        // Check to see if EvaluationMetrics property is set
        internal bool IsSetEvaluationMetrics()
        {
            return this._evaluationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfLabels. 
        /// <para>
        /// The number of labels in the input data. 
        /// </para>
        /// </summary>
        public int? NumberOfLabels
        {
            get { return this._numberOfLabels; }
            set { this._numberOfLabels = value; }
        }

        // Check to see if NumberOfLabels property is set
        internal bool IsSetNumberOfLabels()
        {
            return this._numberOfLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTestDocuments. 
        /// <para>
        /// The number of documents in the input data that were used to test the classifier. Typically
        /// this is 10 to 20 percent of the input documents, up to 10,000 documents.
        /// </para>
        /// </summary>
        public int? NumberOfTestDocuments
        {
            get { return this._numberOfTestDocuments; }
            set { this._numberOfTestDocuments = value; }
        }

        // Check to see if NumberOfTestDocuments property is set
        internal bool IsSetNumberOfTestDocuments()
        {
            return this._numberOfTestDocuments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTrainedDocuments. 
        /// <para>
        /// The number of documents in the input data that were used to train the classifier.
        /// Typically this is 80 to 90 percent of the input documents.
        /// </para>
        /// </summary>
        public int? NumberOfTrainedDocuments
        {
            get { return this._numberOfTrainedDocuments; }
            set { this._numberOfTrainedDocuments = value; }
        }

        // Check to see if NumberOfTrainedDocuments property is set
        internal bool IsSetNumberOfTrainedDocuments()
        {
            return this._numberOfTrainedDocuments.HasValue; 
        }

    }
}