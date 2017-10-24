/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchStopJobRun operation.
    /// </summary>
    public partial class BatchStopJobRunResponse : AmazonWebServiceResponse
    {
        private List<BatchStopJobRunError> _errors = new List<BatchStopJobRunError>();
        private List<BatchStopJobRunSuccessfulSubmission> _successfulSubmissions = new List<BatchStopJobRunSuccessfulSubmission>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list containing the job run Ids and details of the error that occurred for each
        /// job run while submitting to stop.
        /// </para>
        /// </summary>
        public List<BatchStopJobRunError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulSubmissions. 
        /// <para>
        /// A list of job runs which are successfully submitted for stopping.
        /// </para>
        /// </summary>
        public List<BatchStopJobRunSuccessfulSubmission> SuccessfulSubmissions
        {
            get { return this._successfulSubmissions; }
            set { this._successfulSubmissions = value; }
        }

        // Check to see if SuccessfulSubmissions property is set
        internal bool IsSetSuccessfulSubmissions()
        {
            return this._successfulSubmissions != null && this._successfulSubmissions.Count > 0; 
        }

    }
}