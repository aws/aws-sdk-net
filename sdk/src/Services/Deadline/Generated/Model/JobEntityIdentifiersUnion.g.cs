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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a job entity identifier.
    /// </summary>
    public partial class JobEntityIdentifiersUnion
    {
        /// <summary>
        /// Gets and sets the property EnvironmentDetails. 
        /// <para>
        /// The environment details.
        /// </para>
        /// </summary>
        public EnvironmentDetailsIdentifiers EnvironmentDetails { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentDetails property is set.
        /// </summary>
        internal bool IsSetEnvironmentDetails() => this.EnvironmentDetails != null;

        /// <summary>
        /// Gets and sets the property JobAttachmentDetails. 
        /// <para>
        /// The job attachment details.
        /// </para>
        /// </summary>
        public JobAttachmentDetailsIdentifiers JobAttachmentDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobAttachmentDetails property is set.
        /// </summary>
        internal bool IsSetJobAttachmentDetails() => this.JobAttachmentDetails != null;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// The job details.
        /// </para>
        /// </summary>
        public JobDetailsIdentifiers JobDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobDetails property is set.
        /// </summary>
        internal bool IsSetJobDetails() => this.JobDetails != null;

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// The step details.
        /// </para>
        /// </summary>
        public StepDetailsIdentifiers StepDetails { get; set; }

        /// <summary>
        /// Checks to see if the StepDetails property is set.
        /// </summary>
        internal bool IsSetStepDetails() => this.StepDetails != null;
    }
}
