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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetCalculationExecution operation.
    /// </summary>
    public partial class GetCalculationExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CalculationExecutionId. 
        /// <para>
        /// The calculation execution UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string CalculationExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the CalculationExecutionId property is set.
        /// </summary>
        internal bool IsSetCalculationExecutionId() => this.CalculationExecutionId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the calculation execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// Contains result information. This field is populated only if the calculation is completed.
        /// </para>
        /// </summary>
        public CalculationResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID that the calculation ran in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Contains information about the data processing unit (DPU) execution time and progress.
        /// This field is populated only when statistics are available.
        /// </para>
        /// </summary>
        public CalculationStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information about the status of the calculation.
        /// </para>
        /// </summary>
        public CalculationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The Amazon S3 location in which calculation results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
