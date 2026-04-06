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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// This is the response object from the GetPatientInsightsJob operation.
    /// </summary>
    public partial class GetPatientInsightsJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private PatientInsightsEncounterContext _encounterContext;
        private InputDataConfig _inputDataConfig;
        private InsightsContext _insightsContext;
        private InsightsOutput _insightsOutput;
        private string _jobArn;
        private string _jobId;
        private JobStatus _jobStatus;
        private OutputDataConfig _outputDataConfig;
        private PatientInsightsPatientContext _patientContext;
        private string _statusDetails;
        private DateTime? _updatedTime;
        private UserContext _userContext;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time the patient insights job was submitted.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncounterContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public PatientInsightsEncounterContext EncounterContext
        {
            get { return this._encounterContext; }
            set { this._encounterContext = value; }
        }

        // Check to see if EncounterContext property is set
        internal bool IsSetEncounterContext()
        {
            return this._encounterContext != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightsContext InsightsContext
        {
            get { return this._insightsContext; }
            set { this._insightsContext = value; }
        }

        // Check to see if InsightsContext property is set
        internal bool IsSetInsightsContext()
        {
            return this._insightsContext != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsOutput.
        /// </summary>
        public InsightsOutput InsightsOutput
        {
            get { return this._insightsOutput; }
            set { this._insightsOutput = value; }
        }

        // Check to see if InsightsOutput property is set
        internal bool IsSetInsightsOutput()
        {
            return this._insightsOutput != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=200)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OutputDataConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PatientContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public PatientInsightsPatientContext PatientContext
        {
            get { return this._patientContext; }
            set { this._patientContext = value; }
        }

        // Check to see if PatientContext property is set
        internal bool IsSetPatientContext()
        {
            return this._patientContext != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Contains information about the status of a job.
        /// </para>
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// Date and time the patient insights job was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime
        {
            get { return this._updatedTime; }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public UserContext UserContext
        {
            get { return this._userContext; }
            set { this._userContext = value; }
        }

        // Check to see if UserContext property is set
        internal bool IsSetUserContext()
        {
            return this._userContext != null;
        }

    }
}