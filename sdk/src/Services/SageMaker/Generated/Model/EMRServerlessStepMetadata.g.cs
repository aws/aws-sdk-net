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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configurations and outcomes of an Amazon EMR Serverless step execution.
    /// </summary>
    public partial class EMRServerlessStepMetadata
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon EMR Serverless application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The identifier of the Amazon EMR Serverless job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Checks to see if the JobRunId property is set.
        /// </summary>
        internal bool IsSetJobRunId() => this.JobRunId != null;

        /// <summary>
        /// Gets and sets the property JobRunName. 
        /// <para>
        /// The name of the Amazon EMR Serverless job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string JobRunName { get; set; }

        /// <summary>
        /// Checks to see if the JobRunName property is set.
        /// </summary>
        internal bool IsSetJobRunName() => this.JobRunName != null;

        /// <summary>
        /// Gets and sets the property LogFilePath. 
        /// <para>
        /// The path to the log file for the Amazon EMR Serverless job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LogFilePath { get; set; }

        /// <summary>
        /// Checks to see if the LogFilePath property is set.
        /// </summary>
        internal bool IsSetLogFilePath() => this.LogFilePath != null;
    }
}
