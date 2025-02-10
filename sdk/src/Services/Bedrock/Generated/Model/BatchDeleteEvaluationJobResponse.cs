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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteEvaluationJob operation.
    /// </summary>
    public partial class BatchDeleteEvaluationJobResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteEvaluationJobError> _errors = AWSConfigs.InitializeCollections ? new List<BatchDeleteEvaluationJobError>() : null;
        private List<BatchDeleteEvaluationJobItem> _evaluationJobs = AWSConfigs.InitializeCollections ? new List<BatchDeleteEvaluationJobItem>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A JSON object containing the HTTP status codes and the ARNs of evaluation jobs that
        /// failed to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<BatchDeleteEvaluationJobError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationJobs. 
        /// <para>
        /// The list of evaluation jobs for deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteEvaluationJobItem> EvaluationJobs
        {
            get { return this._evaluationJobs; }
            set { this._evaluationJobs = value; }
        }

        // Check to see if EvaluationJobs property is set
        internal bool IsSetEvaluationJobs()
        {
            return this._evaluationJobs != null && (this._evaluationJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}