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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetCalculationExecution operation.
    /// </summary>
    public partial class GetCalculationExecutionResponse : AmazonWebServiceResponse
    {
        private string _calculationExecutionId;
        private string _description;
        private CalculationResult _result;
        private string _sessionId;
        private CalculationStatistics _statistics;
        private CalculationStatus _status;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property CalculationExecutionId. 
        /// <para>
        /// The calculation execution UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string CalculationExecutionId
        {
            get { return this._calculationExecutionId; }
            set { this._calculationExecutionId = value; }
        }

        // Check to see if CalculationExecutionId property is set
        internal bool IsSetCalculationExecutionId()
        {
            return this._calculationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the calculation execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// Contains result information. This field is populated only if the calculation is completed.
        /// </para>
        /// </summary>
        public CalculationResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID that the calculation ran in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Contains information about the data processing unit (DPU) execution time and progress.
        /// This field is populated only when statistics are available.
        /// </para>
        /// </summary>
        public CalculationStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information about the status of the calculation.
        /// </para>
        /// </summary>
        public CalculationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The Amazon S3 location in which calculation results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}