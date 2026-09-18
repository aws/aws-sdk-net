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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// For a Distillation job, the status details for sub-tasks of the job. Possible statuses
    /// for each sub-task include the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// NotStarted
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// InProgress
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Completed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stopping
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stopped
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Failed
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StatusDetails
    {
        /// <summary>
        /// Gets and sets the property DataProcessingDetails. 
        /// <para>
        /// The status details for the data processing sub-task of the job.
        /// </para>
        /// </summary>
        public DataProcessingDetails DataProcessingDetails { get; set; }

        /// <summary>
        /// Checks to see if the DataProcessingDetails property is set.
        /// </summary>
        internal bool IsSetDataProcessingDetails() => this.DataProcessingDetails != null;

        /// <summary>
        /// Gets and sets the property TrainingDetails. 
        /// <para>
        /// The status details for the training sub-task of the job.
        /// </para>
        /// </summary>
        public TrainingDetails TrainingDetails { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDetails property is set.
        /// </summary>
        internal bool IsSetTrainingDetails() => this.TrainingDetails != null;

        /// <summary>
        /// Gets and sets the property ValidationDetails. 
        /// <para>
        /// The status details for the validation sub-task of the job.
        /// </para>
        /// </summary>
        public ValidationDetails ValidationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ValidationDetails property is set.
        /// </summary>
        internal bool IsSetValidationDetails() => this.ValidationDetails != null;
    }
}
