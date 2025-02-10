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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// An identifier for the <c>StartBatchJob</c> API to show that it is a restart operation.
    /// </summary>
    public partial class RestartBatchJobIdentifier
    {
        private string _executionId;
        private JobStepRestartMarker _jobStepRestartMarker;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The <c>executionId</c> from the <c>StartBatchJob</c> response when the job ran for
        /// the first time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStepRestartMarker. 
        /// <para>
        /// The step/procedure step information for a restart batch job operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStepRestartMarker JobStepRestartMarker
        {
            get { return this._jobStepRestartMarker; }
            set { this._jobStepRestartMarker = value; }
        }

        // Check to see if JobStepRestartMarker property is set
        internal bool IsSetJobStepRestartMarker()
        {
            return this._jobStepRestartMarker != null;
        }

    }
}