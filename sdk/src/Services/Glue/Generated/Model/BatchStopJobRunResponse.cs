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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchStopJobRun operation.
    /// </summary>
    public partial class BatchStopJobRunResponse : AmazonWebServiceResponse
    {
        private List<BatchStopJobRunError> _errors = AWSConfigs.InitializeCollections ? new List<BatchStopJobRunError>() : null;
        private List<BatchStopJobRunSuccessfulSubmission> _successfulSubmissions = AWSConfigs.InitializeCollections ? new List<BatchStopJobRunSuccessfulSubmission>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of the errors that were encountered in trying to stop <c>JobRuns</c>, including
        /// the <c>JobRunId</c> for which each error was encountered and details about the error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchStopJobRunError> Errors
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
        /// Gets and sets the property SuccessfulSubmissions. 
        /// <para>
        /// A list of the JobRuns that were successfully submitted for stopping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchStopJobRunSuccessfulSubmission> SuccessfulSubmissions
        {
            get { return this._successfulSubmissions; }
            set { this._successfulSubmissions = value; }
        }

        // Check to see if SuccessfulSubmissions property is set
        internal bool IsSetSuccessfulSubmissions()
        {
            return this._successfulSubmissions != null && (this._successfulSubmissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}