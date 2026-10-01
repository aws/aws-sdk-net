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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// This is the response object from the GetPatientInsightsJob operation.
    /// </summary>
    public partial class GetPatientInsightsJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time the patient insights job was submitted.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EncounterContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public PatientInsightsEncounterContext EncounterContext { get; set; }

        /// <summary>
        /// Checks to see if the EncounterContext property is set.
        /// </summary>
        internal bool IsSetEncounterContext() => this.EncounterContext != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property InsightsContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightsContext InsightsContext { get; set; }

        /// <summary>
        /// Checks to see if the InsightsContext property is set.
        /// </summary>
        internal bool IsSetInsightsContext() => this.InsightsContext != null;

        /// <summary>
        /// Gets and sets the property InsightsOutput.
        /// </summary>
        public InsightsOutput InsightsOutput { get; set; }

        /// <summary>
        /// Checks to see if the InsightsOutput property is set.
        /// </summary>
        internal bool IsSetInsightsOutput() => this.InsightsOutput != null;

        /// <summary>
        /// Gets and sets the property JobArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 200)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus.
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property PatientContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public PatientInsightsPatientContext PatientContext { get; set; }

        /// <summary>
        /// Checks to see if the PatientContext property is set.
        /// </summary>
        internal bool IsSetPatientContext() => this.PatientContext != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Contains information about the status of a job.
        /// </para>
        /// </summary>
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// Date and time the patient insights job was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property UserContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public UserContext UserContext { get; set; }

        /// <summary>
        /// Checks to see if the UserContext property is set.
        /// </summary>
        internal bool IsSetUserContext() => this.UserContext != null;
    }
}
