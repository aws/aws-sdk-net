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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
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
namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// This is the response object from the UpdateJobExecution operation.
    /// </summary>
    public partial class UpdateJobExecutionResponse : AmazonWebServiceResponse
    {
        private JobExecutionState _executionState;
        private string _jobDocument;

        /// <summary>
        /// Gets and sets the property ExecutionState. 
        /// <para>
        /// A JobExecutionState object.
        /// </para>
        /// </summary>
        public JobExecutionState ExecutionState
        {
            get { return this._executionState; }
            set { this._executionState = value; }
        }

        // Check to see if ExecutionState property is set
        internal bool IsSetExecutionState()
        {
            return this._executionState != null;
        }

        /// <summary>
        /// Gets and sets the property JobDocument. 
        /// <para>
        /// The contents of the Job Documents.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string JobDocument
        {
            get { return this._jobDocument; }
            set { this._jobDocument = value; }
        }

        // Check to see if JobDocument property is set
        internal bool IsSetJobDocument()
        {
            return this._jobDocument != null;
        }

    }
}