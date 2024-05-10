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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a job entity.
    /// </summary>
    public partial class JobEntity
    {
        private EnvironmentDetailsEntity _environmentDetails;
        private JobAttachmentDetailsEntity _jobAttachmentDetails;
        private JobDetailsEntity _jobDetails;
        private StepDetailsEntity _stepDetails;

        /// <summary>
        /// Gets and sets the property EnvironmentDetails. 
        /// <para>
        /// The environment details for the job entity.
        /// </para>
        /// </summary>
        public EnvironmentDetailsEntity EnvironmentDetails
        {
            get { return this._environmentDetails; }
            set { this._environmentDetails = value; }
        }

        // Check to see if EnvironmentDetails property is set
        internal bool IsSetEnvironmentDetails()
        {
            return this._environmentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobAttachmentDetails. 
        /// <para>
        /// The job attachment details.
        /// </para>
        /// </summary>
        public JobAttachmentDetailsEntity JobAttachmentDetails
        {
            get { return this._jobAttachmentDetails; }
            set { this._jobAttachmentDetails = value; }
        }

        // Check to see if JobAttachmentDetails property is set
        internal bool IsSetJobAttachmentDetails()
        {
            return this._jobAttachmentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// The job details.
        /// </para>
        /// </summary>
        public JobDetailsEntity JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// The step details.
        /// </para>
        /// </summary>
        public StepDetailsEntity StepDetails
        {
            get { return this._stepDetails; }
            set { this._stepDetails = value; }
        }

        // Check to see if StepDetails property is set
        internal bool IsSetStepDetails()
        {
            return this._stepDetails != null;
        }

    }
}